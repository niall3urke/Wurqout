using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.ViewModels;
using Wurqout.Code.Helpers;

namespace Wurqout.Services
{
    public class RoutineService
    {
        // Actions 

        public Action RequestUpdate { get; set; }

        // Properties

        public List<Block> Blocks { get; set; }

        // Constructors

        public RoutineService()
        {
            Blocks = new List<Block>();
        }

        // Methods: public

        public void Superset(Block block)
        {
            Blocks.Insert(Blocks.IndexOf(block), block.Clone());
            RequestUpdate?.Invoke();
        }

        public void Update(Block block)
        {
            Blocks[Blocks.IndexOf(block)] = block;
            RequestUpdate?.Invoke();
        }

        public void Sort(SortStyle style)
        {
            switch (style)
            {
                case SortStyle.Alternate:
                    OrderAlternate();
                    break;
                case SortStyle.EasyToHard:
                    OrderEasyToHard();
                    break;
                case SortStyle.HardToEasy:
                    OrderHardToEasy();
                    break;
                case SortStyle.GroupByFocus:
                    OrderByFocus();
                    break;
                case SortStyle.Random:
                    OrderRandom();
                    break;
            }

            RequestUpdate?.Invoke();
        }

        // Methods: private

        private void OrderAlternate()
        {
            var weights = Blocks.Where(x => !x.Exercise.IsCardio).ToList();

            if (weights.Count == 0)
            {
                // TODO: Cardio-based routine only, alternate between
                // lower, core, and upper when available.
                return; 
            }

            var cardios = Blocks.Except(weights).ToList();

            if (weights.Count > cardios.Count)
            {
                Blocks = GetAlternatingList(weights, cardios);
            }
            else
            {
                Blocks = GetAlternatingList(cardios, weights);
            }
        }

        private List<Block> GetAlternatingList(List<Block> bigger, List<Block> smaller)
        {
            var sorted = new List<Block>();

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

        private void OrderEasyToHard() =>
            Blocks = Blocks.OrderBy(x => x.Exercise.Difficulty).ToList();

        private void OrderHardToEasy() =>
            Blocks = Blocks.OrderByDescending(x => x.Exercise.Difficulty).ToList();

        private void OrderByFocus() =>
            Blocks = Blocks.OrderBy(x => x.Exercise.FocusArea).ToList();

        private void OrderRandom() =>
            Blocks.Shuffle();

    }
}
