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
            int zeroCount = 0;
            for (int i = 0; i < source.Length; i++)
                if (source[i] == 0)
                    zeroCount++;
            int oneCount = 0;
            for (int i = 0; i < source.Length; i++)
                if (source[i] == 1)
                    oneCount++;
            if (zeroCount == oneCount)
                return "Yes";
            else
                return "No";
        }
    }
}
