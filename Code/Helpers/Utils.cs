using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wurqout.Code.Helpers
{
    public class Utils
    {
        private static readonly Random _random = new Random();

        public static int RandomNumber(int min, int max)
        {
            lock (_random)
            {
                return _random.Next(min, max);
            }
        }


    }
}
