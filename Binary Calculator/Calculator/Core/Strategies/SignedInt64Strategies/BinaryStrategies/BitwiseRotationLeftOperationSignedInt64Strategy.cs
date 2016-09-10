namespace Calculator.Core.Strategies.SignedInt64Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationLeftOperationSignedInt64Strategy
    {
        public long Calculate(long first, long element)
        {
            var second = (int)element;
            var bitsCount = Marshal.SizeOf(typeof(long)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var leftMostBits = new List<long>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1L << (bitsCount - j) & first)!= 0 ? 1L : 0;
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1L << (bitsCount - j)) & first;
                first = first & ~(1L << (bitsCount - (j - second)));
                first |= bitToGet << second;
            }
            for (var j = 0; j < second; j++)
            {
                first = first & ~(1L << (second - j - 1));
                first |= leftMostBits[j] << (second - j - 1);
            }

            return first;
        }
    }
}
