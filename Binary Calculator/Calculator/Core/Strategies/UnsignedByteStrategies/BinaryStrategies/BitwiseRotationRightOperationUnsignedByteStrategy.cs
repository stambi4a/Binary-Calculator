namespace Calculator.Core.Strategies.UnsignedByteStrategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationUnsignedByteStrategy
    {
        public byte Calculate(byte first, byte second)
        {
            var bitsCount = (byte)(Marshal.SizeOf(typeof(byte)) * Constants.BitsInAByte);
            second = (byte)(second % bitsCount);
            var rightMostBits = new List<byte>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (byte)((1 << (j - 1) & first) != 0 ? 1 : 0);
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (byte)((1 << (j - 1) & first) != 0 ? 1 : 0);
                first = (byte)(first & ~(1 << (j - second - 1)));
                first |= (byte)(bitToGet << (j - second - 1));
            }

            for (var j = 0; j < second; j++)
            {
                first = (byte)(first & ~(1 << (bitsCount - second + j)));
                first |= (byte)(rightMostBits[j] << (bitsCount - second + j));
            }

            return first;
        }
    }
}
