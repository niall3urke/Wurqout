using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wurqout.Code.Helpers
{
    public static class Extensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.RandomThread.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


    }
}
