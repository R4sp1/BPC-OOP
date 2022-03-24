using System;
using System.Linq;

namespace Cviceni_7
{
    public class Extremy
    {
        public static T Nejvetsi<T>(params T[] values) where T : IComparable
        {
            return values.Max();
        }

        public static T Nejmensi<T>(params T[] values) where T : IComparable
        {
            return values.Min();
        }
    }
}
