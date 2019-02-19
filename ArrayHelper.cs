using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length < 1)
                throw new ArgumentException();
            bool simetric = true;
            for (int i = 0; i < source.Length / 2; i++)
                if (source[i] != source[source.Length - 1 - i])
                    simetric = false;
            if(simetric)
                return "Yes";
            else
                return "No";
        }
    }
}
