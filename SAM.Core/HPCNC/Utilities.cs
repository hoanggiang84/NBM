using System.Collections.Generic;
using System.Linq;

namespace SAM.Core.HPCNC
{
    public static class Utilities
    {
        public static byte CalculateChecksum(IReadOnlyCollection<byte> bytes)
        {
            byte sum = 0;
            if (bytes == null || bytes.Count == 0)
                sum = 0;
            else
                sum = bytes.Aggregate(sum, (current, b) => (byte)(current + b));

            return (byte)(0xff - sum + 1);
        }

        public static double Max(this double[]  array, out int index)
        {
            var max = double.MinValue;
            index = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (!(array[i] >= max))
                    continue;
                max = array[i];
                index = i;
            }
            return max;
        }
    }
}
