namespace Calculator.Core.Strategies.UnsignedInt64Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationUnsignedInt64Strategy
    {
        public ulong Calculate(ulong first, ulong element)
        {
            var second = (int)element;
            var bitsCount = Marshal.SizeOf(typeof(ulong)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var rightMostBits = new List<ulong>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1UL << (j - 1) & first) != 0 ? 1UL : 0;
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1UL << (j - 1) & first) != 0 ? 1UL : 0;
                first = first & ~(1UL << (j - second - 1));
                first |= bitToGet << (j - second - 1);
            }

            for (var j = 0; j < second; j++)
            {
                first = first & ~(1UL << (bitsCount - second + j));
                first |= rightMostBits[j] << (bitsCount - second + j);
            }

            return first;
        }
    }
}
