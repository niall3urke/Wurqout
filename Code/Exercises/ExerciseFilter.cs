using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.Data;
using Wurqout.ViewModels;

namespace Wurqout.Code.Exercises
{
    public class ExerciseFilter
    {
        
        // Properties

        public List<Exercise> BodyweightExercises { get; set; }

        public List<Exercise> WeightedExercises { get; set; }

        public List<Exercise> AllExercises { get; set; }

        public bool IncludeBodyweight { get; set; }

        public bool IncludeUpperbody { get; set; }

        public bool IncludeLowerbody { get; set; }

        public bool IncludeCore { get; set; }

        public bool HasKettlebell { get; set; }

        public bool HasDumbbells { get; set; }

        public bool HasBarbell { get; set; }

        public bool HasWeights => 
            HasKettlebell || HasDumbbells || HasBarbell;

        // Constructors 

        public ExerciseFilter() { }

        public ExerciseFilter(Settings settings, bool includeBodyweight = true)
        {
            IncludeUpperbody = settings.IncludeUpperbody;
            IncludeLowerbody = settings.IncludeLowerbody;
            IncludeCore = settings.IncludeCore;

            HasKettlebell = settings.HasKettlebell;
            HasDumbbells = settings.HasDumbbells;
            HasBarbell = settings.HasBarbell;

            IncludeBodyweight = includeBodyweight;
        }

        // Methods 

        public void Run()
        {
            this.BodyweightExercises = new List<Exercise>();
            this.WeightedExercises = new List<Exercise>();
            this.AllExercises = new List<Exercise>();

            // Add them both to the Filtered list property
            if (IncludeBodyweight)
            {
                BodyweightExercises = GetAllBodyweightByFocusArea();
                AllExercises.AddRange(BodyweightExercises);
            }

            if (HasKettlebell || HasDumbbells || HasBarbell)
            {
                WeightedExercises = GetAllWeightByFocusArea();
                AllExercises.AddRange(WeightedExercises);
            }
        }

        // Methods - private

        private List<Exercise> GetRecords(FocusArea area, Equipment weight) =>
            Repo.Records.Where(x => x.FocusArea == area && x.Equipment == weight).ToList();

        // ==================================
        // ===== Methods: Weighted exercises
        // ==================================

        private List<Exercise> GetAllWeightByFocusArea()
        {
            var weights = new List<Exercise>();

            if (IncludeLowerbody && IncludeUpperbody)
                weights.AddRange(GetWholebodyWeights());

            if (IncludeUpperbody)
                weights.AddRange(GetUpperbodyWeights());

            if (IncludeLowerbody)
                weights.AddRange(GetLowerbodyWeights());

            if (IncludeCore)
                weights.AddRange(GetCoreWeights());

            return weights;
        }

        private List<Exercise> GetUpperbodyWeights()
        {
            var exercises = new List<Exercise>();

            if (HasKettlebell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Upperbody, Equipment.Kettlebell));
            }

            if (HasDumbbells)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Upperbody, Equipment.Dumbbell));
            }

            if (HasBarbell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Upperbody, Equipment.Barbell));
            }

            return exercises;
        }

        private List<Exercise> GetLowerbodyWeights()
        {
            var exercises = new List<Exercise>();

            if (HasKettlebell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Lowerbody, Equipment.Kettlebell));
            }

            if (HasDumbbells)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Lowerbody, Equipment.Dumbbell));
            }

            if (HasBarbell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Lowerbody, Equipment.Barbell));
            }

            return exercises;
        }

        private List<Exercise> GetWholebodyWeights()
        {
            var exercises = new List<Exercise>();

            if (HasKettlebell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Wholebody, Equipment.Kettlebell));

            }

            if (HasDumbbells)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Wholebody, Equipment.Dumbbell));
            }

            if (HasBarbell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Wholebody, Equipment.Barbell));
            }

            return exercises;
        }

        private List<Exercise> GetCoreWeights()
        {
            var exercises = new List<Exercise>();

            if (HasKettlebell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Core, Equipment.Kettlebell));
            }

            if (HasDumbbells)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Core, Equipment.Dumbbell));
            }

            if (HasBarbell)
            {
                exercises.AddRange(
                    GetRecords(FocusArea.Core, Equipment.Barbell));
            }

            return exercises;

        }

        // ====================================
        // ===== Methods: Bodyweight exercises
        // ====================================

        private List<Exercise> GetAllBodyweightByFocusArea()
        {
            var bodyweights = new List<Exercise>();

            if (IncludeLowerbody && IncludeUpperbody)
                bodyweights.AddRange(GetWholebody());

            if (IncludeUpperbody)
                bodyweights.AddRange(GetUpperbody());

            if (IncludeLowerbody)
                bodyweights.AddRange(GetLowerbody());

            if (IncludeCore)
                bodyweights.AddRange(GetCore());

            return bodyweights;
        }

        private List<Exercise> GetUpperbody() =>
            GetRecords(FocusArea.Upperbody, Equipment.Bodyweight);

        private List<Exercise> GetLowerbody() =>
            GetRecords(FocusArea.Lowerbody, Equipment.Bodyweight);

        private List<Exercise> GetWholebody() =>
            GetRecords(FocusArea.Wholebody, Equipment.Bodyweight);

        private List<Exercise> GetCore() =>
            GetRecords(FocusArea.Core, Equipment.Bodyweight);
    }
}
