namespace Calculator.Core.Strategies.SignedInt64Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationSignedInt64Strategy
    {
        public long Calculate(long first, long element)
        {
            var second = (int)element;
            var bitsCount = Marshal.SizeOf(typeof(long)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var rightMostBits = new List<long>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1L << (j - 1) & first) != 0 ? 1L : 0;
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = ((1L << (j - 1)) & first) != 0 ? 1L : 0;
                first = first & ~(1L << (j - second - 1));
                first |= bitToGet << (j - second - 1);
            }

            for (var j = 0; j < second; j++)
            {
                first = first & ~(1L << (bitsCount - second + j));
                first |= rightMostBits[j] << (bitsCount - second + j);
            }

            return first;
        }
    }
}
