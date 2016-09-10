namespace Calculator.Core.Strategies.UnsignedInt16Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationLeftOperationUnsignedInt16Strategy
    {
        public ushort Calculate(ushort first, ushort second)
        {
            var bitsCount = (ushort)(Marshal.SizeOf(typeof(ushort)) * Constants.BitsInAByte);
            second = (ushort)(second % bitsCount);
            var leftMostBits = new List<ushort>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (ushort)((1 << (bitsCount - j) & first)!= 0 ? 1 : 0);
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (ushort)((1 << (bitsCount - j)) & first);
                first = (ushort)(first & ~(1 << (bitsCount - (j - second))));
                first |= (ushort)(bitToGet << second);
            }
            for (var j = 0; j < second; j++)
            {
                first = (ushort)(first & ~(1 << (second - j - 1)));
                first |= (ushort)(leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
