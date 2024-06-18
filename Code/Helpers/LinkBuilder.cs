using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using Wurqout.ViewModels;
using Wurqout.Data;
using Wurqout.Code.Exercises;
using Microsoft.AspNetCore.WebUtilities;

namespace Wurqout.Code.Helpers
{
    public class LinkBuilder
    {

        // Query string keys

        private readonly string IntervalDuration = "s_id";
        private readonly string BreakDuration = "s_db";
        private readonly string RestDuration = "s_rd";
        private readonly string NumExercises = "s_ne";
        private readonly string NumSets = "s_ns";

        private readonly string Kettlebell = "s_hk";
        private readonly string Dumbbell = "s_hd";
        private readonly string Barbell = "s_hb";

        private readonly string UpperBody = "s_iu";
        private readonly string LowerBody = "s_il";
        private readonly string Core = "s_ic";

        private readonly string Exercises = "e_id";
        private readonly string LowImpact = "s_li";
        private readonly string Blocks = "b_id";
        private readonly string Ratio = "s_rt";

        // Constructors

        public LinkBuilder() { }

        // Methods: public 

        public static string GetQueryString(string uri, Settings settings, List<Block> blocks)
        {
            // Create a dictionary of key values
            var query = new Dictionary<string, string>
            {

                // Add the settings properties
                { "s_id", settings.DurationInterval.ToString() },
                { "s_db", settings.DurationBreak.ToString() },
                { "s_rd", settings.DurationRest.ToString() },
                { "s_ne", settings.NumberExercises.ToString() },
                { "s_ns", settings.NumberSets.ToString() },

                // Settings weights
                { "s_hk", settings.HasKettlebell ? "1" : "0" },
                { "s_hd", settings.HasDumbbells ? "1" : "0" },
                { "s_hb", settings.HasBarbell ? "1" : "0" },

                // Settings focus area
                { "s_iu", settings.IncludeUpperbody ? "1" : "0" },
                { "s_il", settings.IncludeLowerbody ? "1" : "0" },
                { "s_ic", settings.IncludeCore ? "1" : "0" },

                // Settings miscellaneous
                { "s_li", settings.LowImpactOnly ? "1" : "0" },
                { "s_rt", settings.Ratio.ToString() }
            };

            // Form the list of exercise ids
            string exerciseIds = "";
            string blockParams = "";

            foreach (var block in blocks)
            {
                exerciseIds += $"{block.Exercise.Id},";

                if (block.IsTimed)
                {
                    blockParams += $"t{block.Duration},";
                }
                else
                {
                    blockParams += $"r{block.NumReps},";
                }
            }

            if (exerciseIds.EndsWith(","))
                exerciseIds = exerciseIds[0..^1];

            if (blockParams.EndsWith(","))
                blockParams = blockParams[0..^1];

            // Add the exercise ids to the query 
            query.Add("e_id", exerciseIds);
            query.Add("b_id", blockParams);

            return QueryHelpers.AddQueryString(uri, query);
        }

        public void ParseQueryString(string url, out Settings settings, out List<Block> blocks)
        {
            // Get the name value dictionary
            var parameters = QueryHelpers.ParseQuery(url);
            var exercises = GetExercises(parameters);

            settings = GetSettings(parameters);
            blocks = GetBlocks(parameters);

            if (exercises.Count == blocks.Count)
            {
                for (int i = 0; i < blocks.Count; i++)
                {
                    blocks[i].Exercise = exercises[i];
                }
            }
            else
            {
                // Just create the default block for each exercise
                foreach (var exercise in exercises)
                {
                    blocks.Add(new Block
                    {
                        Duration = settings.DurationInterval,
                        Exercise = exercise,
                        IsTimed = true,
                    });
                }
            }
        }

        // Methods: private 

        private Settings GetSettings(Dictionary<string, StringValues> parameters)
        {
            var settings = new Settings();

            // Durations

            if (parameters.TryGetValue(IntervalDuration, out StringValues sId))
                settings.DurationInterval = GetInt(sId) ?? settings.DurationInterval;

            if (parameters.TryGetValue(BreakDuration, out StringValues sIb))
                settings.DurationBreak = GetInt(sIb) ?? settings.DurationBreak;

            if (parameters.TryGetValue(RestDuration, out StringValues sIr))
                settings.DurationRest = GetInt(sIr) ?? settings.DurationRest;

            // Number of exercises and sets

            if (parameters.TryGetValue(NumExercises, out StringValues sNe))
                settings.NumberExercises = GetInt(sNe) ?? settings.NumberExercises;

            if (parameters.TryGetValue(NumSets, out StringValues sNs))
                settings.NumberSets = GetInt(sNs) ?? settings.NumberSets;

            // Weights

            if (parameters.TryGetValue(Kettlebell, out StringValues sHk))
                settings.HasKettlebell = GetBool(sHk) ?? settings.HasKettlebell;

            if (parameters.TryGetValue(Dumbbell, out StringValues sHd))
                settings.HasDumbbells = GetBool(sHd) ?? settings.HasDumbbells;

            if (parameters.TryGetValue(Barbell, out StringValues sHb))
                settings.HasBarbell = GetBool(sHb) ?? settings.HasBarbell;

            // Focus areas

            if (parameters.TryGetValue(UpperBody, out StringValues sIu))
                settings.IncludeUpperbody = GetBool(sIu) ?? settings.IncludeUpperbody;

            if (parameters.TryGetValue(LowerBody, out StringValues sIl))
                settings.IncludeLowerbody = GetBool(sIl) ?? settings.IncludeLowerbody;

            if (parameters.TryGetValue(Core, out StringValues sIc))
                settings.IncludeCore = GetBool(sIc) ?? settings.IncludeCore;

            // Miscellanous

            if (parameters.TryGetValue(LowImpact, out StringValues sLi))
                settings.LowImpactOnly = GetBool(sLi) ?? settings.LowImpactOnly;

            if (parameters.TryGetValue(Ratio, out StringValues sRt))
                settings.Ratio = GetDouble(sRt) ?? settings.Ratio;

            return settings;
        }

        private List<Exercise> GetExercises(Dictionary<string, StringValues> parameters)
        {
            var exercises = new List<Exercise>();
           
            if (parameters.TryGetValue(Exercises, out StringValues value))
            {
                var ids = GetInts(value);

                foreach (var id in ids)
                {
                    var exercise = Repo.Records.Find(x => x.Id == id);

                    if (exercise != null)
                    {
                        exercises.Add(exercise);
                    }
                }
            }

            return exercises;
        }

        private List<Block> GetBlocks(Dictionary<string, StringValues> parameters)
        {
            var blocks = new List<Block>();

            if (!parameters.TryGetValue(Blocks, out StringValues value))
                return blocks;

            var sBlocks = value.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sblock in sBlocks)
            {
                if (sblock.ToLower().StartsWith("t"))
                {
                    if (!int.TryParse(sblock.Substring(1), out int duration))
                        continue;

                    blocks.Add(new Block
                    {
                        IsTimed = true,
                        Duration = duration
                    });
                }
                else
                {
                    if (!int.TryParse(sblock.Substring(1), out int numReps))
                        continue;

                    blocks.Add(new Block
                    {
                        IsTimed = false,
                        NumReps = numReps
                    });
                }
            }

            return blocks;
        }

        private int? GetInt(string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result;
            }
            return null;
        }

        private List<int> GetInts(string value)
        {
            string[] sIds = value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var ids = new List<int>();

            for (int i = 0; i < sIds.Length; i++)
            {
                if (int.TryParse(sIds[i], out int id))
                {
                    ids.Add(id);
                }
            }
            return ids;
        }

        private double? GetDouble(string value)
        {
            if (double.TryParse(value, out double result))
            {
                return result;
            }
            return null;
        }

        private bool? GetBool(string value)
        {
            if (int.TryParse(value, out int result))
            {
                return result == 1;
            }
            return null;
        }

    }
}
