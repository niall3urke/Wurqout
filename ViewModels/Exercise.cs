using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wurqout.ViewModels
{
    public class Exercise
    {

        // Properties
        public MuscleGroup PrimaryGroup { get; set; }

        public FocusArea FocusArea { get; set; }

        public Equipment Equipment { get; set; }

        public Impact ImpactRating { get; set; }

        public Family Family { get; set; }

        public string[] Steps { get; set; }

        public int Difficulty { get; set; }

        public bool IsCardio { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public bool HasWeights =>
            Equipment == Equipment.Kettlebell ||
            Equipment == Equipment.Dumbbell ||
            Equipment == Equipment.Barbell;


        // Constructors 

        public Exercise(string name)
        {
            Name = name;
        }

        public Exercise() { }
    }
}
