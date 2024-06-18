using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.ViewModels;

namespace Wurqout.Code.Workout
{
    public class WorkoutBuilder
    {

        // Fields

        private List<WorkoutBlock> WorkoutBlocks;

        private readonly List<Block> blocks;

        private readonly Settings settings;

        // Constructors

        public WorkoutBuilder(List<Block> blocks, Settings settings)
        {
            this.blocks = blocks;
            this.settings = settings;
        }

        public List<WorkoutBlock> Build()
        {
            AddCountIn();
            AddAllExercises();
            return WorkoutBlocks;
        }
        private void AddCountIn()
        {
            WorkoutBlocks = new List<WorkoutBlock>
            {
                new WorkoutBlock
                {
                    Image = blocks[0].Exercise.ImageUrl,
                    Steps = blocks[0].Exercise.Steps,
                    Next = blocks[0].Exercise.Name,
                    Title = "Get Ready",
                    Duration = 8,
                    Position = 0,
                    Set = 0,
                }
            };
        }

        private void AddAllExercises()
        {
            for (int i = 0; i < settings.NumberSets; i++)
            {
                for (int j = 0; j < blocks.Count; j++)
                {
                    if (LastExerciseInSet(j))
                    {
                        if (LastSet(i))
                        {
                            AddLastExerciseInWorkout(ref WorkoutBlocks, j, i);
                        }
                        else
                        {
                            AddLastExerciseInSet(ref WorkoutBlocks, j, i);
                        }
                    }
                    else
                    {
                        AddExercise(ref WorkoutBlocks, j, i);
                    }
                }
            }
        }

        private bool LastExerciseInSet(int index) =>
            index == blocks.Count - 1;

        private bool LastSet(int index) =>
            index == settings.NumberSets - 1;

        private void AddExercise(ref List<WorkoutBlock> viewmodels, int index, int set)
        {
            // Create exercise
            WorkoutBlock ex;

            if (blocks[index].IsTimed)
            {
                ex = new WorkoutBlock
                {
                    Duration = settings.DurationInterval,
                    Image = blocks[index].Exercise.ImageUrl,
                    Next = blocks[index + 1].Exercise.Name,
                    Steps = blocks[index].Exercise.Steps,
                    Title = blocks[index].Exercise.Name,
                    Position = index + 1,
                    Set = set + 1
                };
            }
            else
            {
                ex = new WorkoutBlock
                {
                    Image = blocks[index].Exercise.ImageUrl,
                    Next = blocks[index + 1].Exercise.Name,
                    Steps = blocks[index].Exercise.Steps,
                    Title = blocks[index].Exercise.Name,
                    NumReps = blocks[index].NumReps,
                    Position = index + 1,
                    IsTimed = false,
                    Set = set + 1
                };
            }

            // Create rest
            var rs = new WorkoutBlock
            {
                Image = blocks[index + 1].Exercise.ImageUrl,
                Steps = blocks[index + 1].Exercise.Steps,
                Duration = settings.DurationRest,
                Position = index + 1,
                Set = set + 1,
                Title = "Rest",
                Next = ex.Next,
            };

            // Add items to the list
            viewmodels.Add(ex);
            viewmodels.Add(rs);
        }

        private void AddLastExerciseInSet(ref List<WorkoutBlock> viewmodels, int index, int set)
        {
            // Last exercise in the set with a break after it
            WorkoutBlock ex;

            if (blocks[index].IsTimed)
            {
                ex = new WorkoutBlock
                {
                    Duration = settings.DurationInterval,
                    Image = blocks[index].Exercise.ImageUrl,
                    Steps = blocks[index].Exercise.Steps,
                    Title = blocks[index].Exercise.Name,
                    Position = index + 1,
                    Next = "Break",
                    Set = set + 1
                };
            }
            else
            {
                ex = new WorkoutBlock
                {
                    Image = blocks[index].Exercise.ImageUrl,
                    Steps = blocks[index].Exercise.Steps,
                    Title = blocks[index].Exercise.Name,
                    NumReps = blocks[index].NumReps,
                    Position = index + 1,
                    IsTimed = false,
                    Next = "Break",
                    Set = set + 1
                };
            }

            // End of set, create break
            var br = new WorkoutBlock
            {
                Duration = settings.DurationBreak,
                Image = blocks[0].Exercise.ImageUrl,
                Steps = blocks[0].Exercise.Steps,
                Next = blocks[0].Exercise.Name,
                Title = "Break",
                Set = set + 1,
                Position = 0
            };

            // Add items to the list
            viewmodels.Add(ex);
            viewmodels.Add(br);
        }

        private void AddLastExerciseInWorkout(ref List<WorkoutBlock> viewmodels, int index, int set)
        {
            // Last exercise in the last set - no break after it
            viewmodels.Add(new WorkoutBlock
            {
                Duration = settings.DurationInterval,
                Image = blocks[index].Exercise.ImageUrl,
                Steps = blocks[index].Exercise.Steps,
                Title = blocks[index].Exercise.Name,
                Position = index + 1,
                Next = "Done",
                Set = set + 1
            });
        }

    }
}
