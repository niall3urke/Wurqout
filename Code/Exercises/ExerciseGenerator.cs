using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.Code.Helpers;
using Wurqout.Data;
using Wurqout.ViewModels;

namespace Wurqout.Code.Exercises
{
    public class ExerciseGenerator
    {

        // Properties

        /// <summary>
        /// This list is populated with exercises from the Filtered
        /// list. It contains the specified number of weights/body
        /// weight exercises based on the settings ratio. 
        /// </summary>
        public List<Exercise> Exercises { get; set; }

        /// <summary>
        /// This list is used to contain the list of all exercises
        /// that match the settings criteria - whether to include
        /// weights/bodyweight exercises according to upperbody,
        /// lowerbody, core, and low-impact.
        /// </summary>
        public List<Exercise> Filtered { get; set; }

        // Constructor

        public ExerciseGenerator() { }

        // ======================
        // ===== Methods: public 
        // ======================

        public void Run(Settings settings)
        {
            var filter = new ExerciseFilter(settings);
            filter.Run();

            // We want to reset our lists for filtering and the random
            // exercises that are selected from the filtered list
            Exercises = new List<Exercise>();
            Filtered = new List<Exercise>();

            // First, check if we have any weighted exercises
            // We'll do this to see if we need to apply the 
            // weighted-to-bodyweight ratio
            if (filter.HasWeights)
            {
                // User has weights - get the number of weights and cardio
                // exercises to be included based on the users ratio 
                (int numWeight, int numCardio) = GetNumberOfExercises(
                    settings.NumberExercises, settings.Ratio);

                // Get the lists of all valid filtered exercises
                Filtered.AddRange(filter.BodyweightExercises);
                Filtered.AddRange(filter.WeightedExercises);

                // Populate the Exercises list property
                GetExercises(numCardio, filter.BodyweightExercises);
                GetExercises(numWeight, filter.WeightedExercises);
            }
            else
            {
                // User has no weights - bodyweight only
                Filtered = filter.BodyweightExercises;

                // Populate the Exercises list property
                GetExercises(settings.NumberExercises, Filtered);
            }
        }

        public void AddRandomExercise()
        {
            // The the unique instances of a family type on the
            // list of Filtered exercises
            int filterFamilyCount = Filtered
                .GroupBy(x => x.Family)
                .Select(x => x.First())
                .Count();

            AddExerciseToExercises(Filtered, filterFamilyCount);
        }

        public void GetNextVariation(Exercise exercise)
        {
            // Fetch all exercises that are of the same family
            // type as the passed exercise 
            var variations = Filtered
                .Where(x => x.Family == exercise.Family)
                .ToList();

            // If we only have one variation, there's no point
            // in continuing
            if (variations.Count < 2)
                return;

            // Get the next exercise index in the variations list
            int newIndex = variations.IndexOf(exercise) + 1;

            // Get the index of the old exercise in the exercises list
            int oldIndex = Exercises.IndexOf(exercise);

            // Check we're not out of bounds. If we are loop back
            // and go to the first variation
            newIndex = (newIndex > variations.Count - 1) ? 0 : newIndex;

            // Replace the old exercise with the new variation
            Exercises[oldIndex] = variations[newIndex];
        }

        public void MakeExercisesEasier()
        {
            // Loop all the exercises, look for variants of the exercise
            // family, and select a variant that has a lesser difficulty
            // rating (if any).
            for (int i = 0; i < Exercises.Count; i++)
            {
                // Get a reference to the current exercise for ease
                var exercise = Exercises[i];

                // If the difficulty is already on the easiest setting
                // then there's no point continuing
                if (exercise.Difficulty < 1)
                    continue;

                // Find all variants of the exercise based on the family
                var variants = Filtered.Where(
                    x => x.Family == exercise.Family).ToList();

                // If we only have one variant there's no point continuing
                if (variants.Count < 2)
                    continue;

                // Get the new difficulty level that we're looking for
                int difficulty = exercise.Difficulty - 1;

                // Track when we've found an easier exercise
                bool exit = false;

                while (!exit)
                {
                    // Do we have a matching difficulty in the variant list
                    if (variants.Any(x => x.Difficulty == difficulty))
                    {
                        // Get all variants with a matching difficulty
                        var easier = variants.Where(
                            x => x.Difficulty == difficulty).ToList();

                        // Loop the easier exercises and select one that 
                        // isn't already present in the Exercises list
                        for (int j = 0; j < easier.Count; j++)
                        {
                            if (Exercises.Contains(easier[j]))
                                continue;

                            // We have an easier exercise variant that's not
                            // already in the list. Replace the exercise
                            Exercises[i] = easier[j];

                            // Set our exit condition
                            exit = true;

                            // No point in continuing, get out of here
                            break;
                        }
                    }

                    // Have we found an easier exercise in the above code?
                    if (!exit)
                    {
                        // No exercise found, lets reduce the difficulty
                        difficulty--;

                        // Check we're still within our bounds 
                        exit = difficulty < 0;
                    }
                }
            }
        }

        public void MakeExercisesHarder()
        {
            // Loop all the exercises, look for variants of the exercise
            // family, and select a variant that has a greater difficulty
            // rating (if any).
            for (int i = 0; i < Exercises.Count; i++)
            {
                // Get a reference to the current exercise for ease
                var exercise = Exercises[i];

                // If the difficulty is already on the hardest setting
                // then there's no point continuing
                if (exercise.Difficulty > 5)
                    continue;

                // Find all variants of the exercise based on the family
                var variants = Filtered.Where(
                    x => x.Family == exercise.Family).ToList();

                // If we only have one variant there's no point continuing
                if (variants.Count < 2)
                    continue;

                // Get the new difficulty level that we're looking for
                int difficulty = exercise.Difficulty + 1;

                // Track when we've found an easier exercise
                bool exit = false;

                while (!exit)
                {
                    // Do we have a matching difficulty in the variant list
                    if (variants.Any(x => x.Difficulty == difficulty))
                    {
                        // Get all variants with a matching difficulty
                        var harder = variants.Where(
                            x => x.Difficulty == difficulty).ToList();

                        // Loop the easier exercises and select one that 
                        // isn't already present in the Exercises list
                        for (int j = 0; j < harder.Count; j++)
                        {
                            if (Exercises.Contains(harder[j]))
                                continue;

                            // We have an easier exercise variant that's not
                            // already in the list. Replace the exercise
                            Exercises[i] = harder[j];

                            // Set our exit condition
                            exit = true;

                            // No point in continuing, get out of here
                            break;
                        }
                    }

                    // Have we found an easier exercise in the above code?
                    if (!exit)
                    {
                        // No exercise found, lets reduce the difficulty
                        difficulty++;

                        // Check we're still within our bounds 
                        exit = difficulty > 5;
                    }
                }
            }
        }

        public void SupersetExercises()
        {
            var supersets = new List<Exercise>();

            // Any family type that doesn't appear twice in the list needs 
            // to have another variation added
            for (int i = 0; i < Exercises.Count; i++)
            {
                // Get a reference to the current exercise for ease
                var exercise = Exercises[i];

                // Continue if the exercise family already appears more than once
                if (Exercises.Count(x => x.Family == exercise.Family) > 1)
                    continue;

                // Fetch all exercises that are of the same family
                var variations = Filtered
                    .Where(x => x.Family == exercise.Family)
                    .ToList();

                // If we only have one variation, there's no point
                // in continuing
                if (variations.Count < 2)
                        return;

                // Just keep it simple and get the next variation 
                int index = variations.IndexOf(exercise) + 1;

                // Check we're not out of bounds. If we are loop back
                // and go to the first variation
                index = (index > variations.Count - 1) ? 0 : index;

                // Add the variation to the list of exercises
                supersets.Add(variations[index]);
            }

            // Add the superset exercises to the list
            Exercises.AddRange(supersets);

            // Ensure exercises are ordered by their family type
            Exercises = Exercises.OrderBy(x => x.Family).ToList();
        }

        public void AlternateExercises()
        {
            var weights = Exercises.Where(x => !x.IsCardio).ToList();
            var cardios = Exercises.Except(weights).ToList();

            if (weights.Count > cardios.Count)
            {
                Exercises = GetAlternatingList(weights, cardios);
            }
            else
            {
                Exercises = GetAlternatingList(cardios, weights);
            }
        }

        private List<Exercise> GetAlternatingList(List<Exercise> bigger, List<Exercise> smaller)
        {
            var sorted = new List<Exercise>();

            for (int i = 0; i < bigger.Count; i++)
            {
                sorted.Add(bigger[i]);

                if (i < smaller.Count)
                {
                    sorted.Add(smaller[i]);
                }
            }

            return sorted;
        }

        // =======================
        // ===== Methods: private
        // =======================

        private List<Exercise> GetRecords(FocusArea area, Equipment weight) =>
            Repo.Records.Where(x => x.FocusArea == area && x.Equipment == weight).ToList();

        /// <summary>
        /// Populates the Exercises property with the required number of 
        /// random exercises from a list that's been filtered based on 
        /// the users settings.
        /// </summary>
        /// <param name="numberRequired">
        /// The number of exercises required
        /// </param>
        /// <param name="filtered">
        /// A list that's been filtered for the equipment types and focus
        /// area's based on the users input through the Settings object
        /// </param>
        private void GetExercises(int numberRequired, List<Exercise> filtered)
        {
            if (numberRequired < 1)
                return;

            if (filtered.Count < 1)
                return;

            // The the unique instances of a family type on the
            // list of Filtered exercises
            int filterFamilyCount = filtered
                .GroupBy(x => x.Family)
                .Select(x => x.First())
                .Count();

            for (int i = 0; i < numberRequired; i++)
            {
                AddExerciseToExercises(filtered, filterFamilyCount);
            }
        }

        private void AddExerciseToExercises(List<Exercise> filtered, int filterFamilyCount)
        {
            // The the unique instances of a family type on the 
            // list of exercises
            int familyCount = Exercises
                .GroupBy(x => x.Family)
                .Select(x => x.First())
                .Count();

            // If the family count of the exercise list is already equal to
            // the filtered list family count, then we'll have to allow 
            // more than one exercise per family type
            bool allowDuplicatesFamily = (familyCount >= filterFamilyCount);

            // Get the number of distinct exercises 
            int distinct = Exercises.Distinct().Count();

            // If the number of distinct exercises is greater than the number
            // of Filtered exercises, then we'll have to allow the exercises 
            // to appear more than once in the list. Note that this implies
            // the families are not distinct and duplicates of them are OK.
            bool allowDuplicatesExercise = (distinct >= filtered.Count);

            if (allowDuplicatesExercise)
            {
                // We've already maxed out the family types - there are no 
                // families left to pick from. The exercises list is also 
                // already maxed out, so now we'll have to add duplicate
                // exercises. This one is nice and easy.
                Exercises.Add(GetRandomExerciseFromList(filtered));
            }
            else if (allowDuplicatesFamily)
            {
                // We don't have any duplicates of exercises - yet - but the
                // family count is maxed out, so now we'll have to duplicate
                // on the family type

                // Get a list of exercises that aren't in the exercises list
                var valid = filtered.Except(Exercises).ToList();

                // Get an exercise at random from the valid list
                Exercises.Add(GetRandomExerciseFromList(valid));
            }
            else
            {
                // Limit the exercises to those that aren't of the 
                // existing family types, or existing exercises

                // Get a list of exercises that excludes existing ones
                var valid = filtered.Except(Exercises).ToList();

                // Next we'll loop the valid exercises and remove those
                // which already have a family type in the exercises list
                for (int j = valid.Count - 1; j > -1; j--)
                {
                    // Does exercises already have an exercise with this family?
                    if (Exercises.Any(x => x.Family == valid[j].Family))
                        valid.RemoveAt(j);
                }

                // All we should have left now are valid exercises, but check 
                // the list count to be sure nothing's gone wrong
                if (valid.Count == 0)
                {
                    // Something went wrong - get an exercise from Filtered
                    Exercises.Add(GetRandomExerciseFromList(filtered));
                }
                else
                {
                    // We we successful in getting at least one exercise
                    // that doesn't have a family type or exercise in exercises
                    Exercises.Add(GetRandomExerciseFromList(valid));
                }
            }
        }

        private Exercise GetRandomExerciseFromList(List<Exercise> exercises) =>
            exercises[Utils.RandomNumber(0, exercises.Count - 1)];


        // ==================================
        // ===== Methods: Weighted exercises
        // ==================================

        private (int numWeight, int numCardio) GetNumberOfExercises(int numExercises, double ratio)
        {
            // Get the number of bodyweight exercises
            int numCardio = (int)Math.Round(ratio * numExercises);

            // Valid ratio, get the number of weights
            int numWeight = numExercises - numCardio;

            // Return the tuple
            return (numWeight, numCardio);
        }

        //private List<Exercise> GetAllWeightByFocusArea()
        //{
        //    var weights = new List<Exercise>();

        //    if (settings.IncludeLowerbody && settings.IncludeUpperbody)
        //        weights.AddRange(GetWholebodyWeights());

        //    if (settings.IncludeUpperbody)
        //        weights.AddRange(GetUpperbodyWeights());

        //    if (settings.IncludeLowerbody)
        //        weights.AddRange(GetLowerbodyWeights());

        //    if (settings.IncludeCore)
        //        weights.AddRange(GetCoreWeights());

        //    return weights;
        //}

        //private List<Exercise> GetUpperbodyWeights()
        //{
        //    var exercises = new List<Exercise>();

        //    if (settings.HasKettlebell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Upperbody, Equipment.Kettlebell));
        //    }

        //    if (settings.HasDumbbells)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Upperbody, Equipment.Dumbbell));
        //    }

        //    if (settings.HasBarbell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Upperbody, Equipment.Barbell));
        //    }

        //    return exercises;
        //}

        //private List<Exercise> GetLowerbodyWeights()
        //{
        //    var exercises = new List<Exercise>();

        //    if (settings.HasKettlebell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Lowerbody, Equipment.Kettlebell));
        //    }

        //    if (settings.HasDumbbells)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Lowerbody, Equipment.Dumbbell));
        //    }

        //    if (settings.HasBarbell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Lowerbody, Equipment.Barbell));
        //    }

        //    return exercises;
        //}

        //private List<Exercise> GetWholebodyWeights()
        //{
        //    var exercises = new List<Exercise>();

        //    if (settings.HasKettlebell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Wholebody, Equipment.Kettlebell));

        //    }

        //    if (settings.HasDumbbells)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Wholebody, Equipment.Dumbbell));
        //    }

        //    if (settings.HasBarbell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Wholebody, Equipment.Barbell));
        //    }

        //    return exercises;
        //}


        //private List<Exercise> GetCoreWeights()
        //{
        //    var exercises = new List<Exercise>();

        //    if (settings.HasKettlebell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Core, Equipment.Kettlebell));
        //    }

        //    if (settings.HasDumbbells)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Core, Equipment.Dumbbell));
        //    }

        //    if (settings.HasBarbell)
        //    {
        //        exercises.AddRange(
        //            GetRecords(FocusArea.Core, Equipment.Barbell));
        //    }

        //    return exercises;
        //}

        // ====================================
        // ===== Methods: Bodyweight exercises
        // ====================================

        //private List<Exercise> GetAllBodyweightByFocusArea(Filter filter)
        //{
        //    var bodyweights = new List<Exercise>();

        //    if (settings.IncludeLowerbody && settings.IncludeUpperbody)
        //        bodyweights.AddRange(GetWholebody());

        //    if (settings.IncludeUpperbody)
        //        bodyweights.AddRange(GetUpperbody());

        //    if (settings.IncludeLowerbody)
        //        bodyweights.AddRange(GetLowerbody());

        //    if (settings.IncludeCore)
        //        bodyweights.AddRange(GetCore());

        //    return bodyweights;
        //}

        //private List<Exercise> GetUpperbody() =>
        //    GetRecords(FocusArea.Upperbody, Equipment.Bodyweight);

        //private List<Exercise> GetLowerbody() =>
        //    GetRecords(FocusArea.Lowerbody, Equipment.Bodyweight);

        //private List<Exercise> GetWholebody() =>
        //    GetRecords(FocusArea.Wholebody, Equipment.Bodyweight);

        //private List<Exercise> GetCore() =>
        //    GetRecords(FocusArea.Core, Equipment.Bodyweight);

    }
}
