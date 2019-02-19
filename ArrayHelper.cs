using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length < 2)
                throw new ArgumentException();
            //if ((source.Length % 2) > 0)
            //    return "No";
            int zeroCount = 0;
            for (int i = 0; i < source.Length; i++)
                if (source[i] == 0)
                    zeroCount++;
            if ((zeroCount == 0) || (zeroCount == source.Length))
                throw new ArgumentException();
            if (zeroCount == (source.Length / 2))
                return "Yes";
            else
                return "No";
        }
    }
}
