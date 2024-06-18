using System;
using System.Collections.Generic;
using System.Text;

namespace Wurqout.ViewModels
{
    public class Block
    {

        public Exercise Exercise { get; set; }

        public bool IsTimed { get; set; }

        public int Duration { get; set; }

        public int NumReps { get; set; }

        // Methods

        public Block Clone() => new Block
        {
            Exercise = Exercise,
            Duration = Duration,
            IsTimed = IsTimed,
            NumReps = NumReps,
        };

    }
}
