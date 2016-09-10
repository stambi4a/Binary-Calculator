namespace Calculator.Core.Strategies.UnsignedInt16Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationUnsignedInt16Strategy
    {
        public ushort Calculate(ushort first, ushort second)
        {
            var bitsCount = (ushort)(Marshal.SizeOf(typeof(ushort)) * Constants.BitsInAByte);
            second = (ushort)(second % bitsCount);
            var rightMostBits = new List<ushort>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (ushort)((1 << (j - 1) & first) != 0 ? 1 : 0);
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (ushort)((1 << (j - 1) & first) != 0 ? 1 : 0);
                first = (ushort)(first & ~(1 << (j - second - 1)));
                first |= (ushort)(bitToGet << (j - second - 1));
            }

            for (var j = 0; j < second; j++)
            {
                first = (ushort)(first & ~(1 << (bitsCount - second + j)));
                first |= (ushort)(rightMostBits[j] << (bitsCount - second + j));
            }

            return first;
        }
    }
}
