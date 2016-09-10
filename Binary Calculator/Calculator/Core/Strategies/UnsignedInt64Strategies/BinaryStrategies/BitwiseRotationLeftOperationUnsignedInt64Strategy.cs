namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationLeftOperationUnsignedInt64Strategy
    {
        public ulong Calculate(ulong first, ulong element)
        {
            var second = (int)element;
            var bitsCount = Marshal.SizeOf(typeof(ulong)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var leftMostBits = new List<ulong>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1UL << (bitsCount - j) & first)!= 0 ? 1UL : 0;
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1UL << (bitsCount - j)) & first;
                first = first & ~(1UL << (bitsCount - (j - second)));
                first |= bitToGet << second;
            }
            for (var j = 0; j < second; j++)
            {
                first = first & ~(1UL << (second - j - 1));
                first |= (leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
