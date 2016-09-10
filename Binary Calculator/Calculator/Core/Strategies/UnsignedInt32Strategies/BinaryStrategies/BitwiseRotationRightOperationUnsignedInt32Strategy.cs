namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationUnsignedInt32Strategy
    {
        public uint Calculate(uint first, uint element)
        {
            var second = (int)element;
            var bitsCount = Marshal.SizeOf(typeof(uint)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var rightMostBits = new List<uint>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1u << (j - 1) & first) != 0 ? 1u : 0;
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1u << (j - 1) & first) != 0 ? 1u : 0;
                first = first & ~(1u << (j - second - 1));
                first |= bitToGet << (j - second - 1);
            }

            for (var j = 0; j < second; j++)
            {
                first = first & ~(1u << (bitsCount - second + j));
                first |= rightMostBits[j] << (bitsCount - second + j);
            }

            return first;
        }
    }
}
