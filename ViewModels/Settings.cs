using System;
using System.Collections.Generic;
using System.Text;

namespace Wurqout.ViewModels
{
    public class Settings
    {

        // Constructor

        public Settings()
        {
            // Set default values 

            durationInterval = 40;
            numberExercises = 8;
            durationBreak = 60;
            durationRest = 20;
            numberSets = 3;
            ratio = 0.5;
        }

        // Properties

        public int DurationInterval
        {
            get
            {
                return durationInterval;
            }
            set
            {
                if (value < 5)
                    value = 5;

                if (value > 300)
                    value = 300;

                durationInterval = value;
            }
        }
        public int NumberExercises
        {
            get
            {
                return numberExercises;
            }
            set
            {
                if (value < 1)
                    value = 1;

                if (value > 50)
                    value = 50;

                numberExercises = value;
            }
        }
        public int DurationBreak
        {
            get
            {
                return durationBreak;
            }
            set
            {
                if (value < 5)
                    value = 5;

                if (value > 600)
                    value = 600;

                durationBreak = value;
            }
        }
        public int DurationRest
        {
            get
            {
                return durationRest;
            }
            set
            {
                if (value < 5)
                    value = 5;

                if (value > 300)
                    value = 300;

                durationRest = value;
            }
        }
        public int NumberSets
        {
            get
            {
                return numberSets;
            }
            set
            {
                if (value < 1)
                    value = 1;

                if (value > 50)
                    value = 50;

                numberSets = value;
            }
        }
        public double Ratio
        {
            get
            {
                return ratio;
            }
            set
            {
                if (value < 0)
                    value = 0;

                if (value > 1)
                    value = 1;

                ratio = value;
            }
        }

        public bool HasKettlebell { get; set; }

        public bool HasDumbbells { get; set; }

        public bool HasBarbell { get; set; }

        public bool HasBands { get; set; }

        public bool HasBox { get; set; }

        public bool IncludeUpperbody { get; set; } = true;

        public bool IncludeLowerbody { get; set; } = true;

        public bool IncludeCore { get; set; } = true;

        public bool LowImpactOnly { get; set; }

        // Readonly properties

        public int PercentWeight => 100 - PercentBodyweight;

        public int PercentBodyweight => (int)(Ratio * 100);

        public int Minutes => TotalSeconds / 60;

        public int Seconds => TotalSeconds % 60;

        public int TotalSeconds
        {
            get
            {
                int working = NumberSets * NumberExercises * (DurationInterval + DurationRest) - DurationRest;
                int resting = (NumberSets - 1) * DurationBreak;
                return working + resting;
            }
        }
        public bool HasWeights =>
            HasKettlebell || HasDumbbells || HasBarbell;

        // Fields

        private int durationInterval;

        private int numberExercises;

        private int durationBreak;

        private int durationRest;

        private int numberSets;

        private double ratio;

    }
}
