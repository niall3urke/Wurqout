using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wurqout.Code.Workout
{
    public class WorkoutBlock
    {

        public string[] Steps { get; set; }

        public bool IsTimed { get; set; } = true;

        public int Duration { get; set; }

        public int Position { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public string Next { get; set; }

        public int NumReps { get; set; }

        public int Set { get; set; }

    }
}
