namespace Calculator.Core.Strategies.UnsignedByteStrategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationLeftOperationUnsignedByteStrategy
    {
        public byte Calculate(byte first, byte second)
        {
            var bitsCount = (byte)(Marshal.SizeOf(typeof(byte)) * Constants.BitsInAByte);
            second = (byte)(second % bitsCount);
            var leftMostBits = new List<byte>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (byte)((1 << (bitsCount - j) & first)!= 0 ? 1 : 0);
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (byte)((1 << (bitsCount - j)) & first);
                first = (byte)(first & ~(1 << (bitsCount - (j - second))));
                first |= (byte)(bitToGet << second);
            }
            for (var j = 0; j < second; j++)
            {
                first = (byte)(first & ~(1 << (second - j - 1)));
                first |= (byte)(leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
