namespace Calculator.Core.Strategies.SignedByteStrategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationLeftOperationSignedByteStrategy
    {
        public sbyte Calculate(sbyte first, sbyte second)
        {
            var bitsCount = (sbyte)(Marshal.SizeOf(typeof(sbyte)) * Constants.BitsInAByte);
            second = (sbyte)(second % bitsCount);
            var leftMostBits = new List<sbyte>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (sbyte)((1 << (bitsCount - j) & first)!= 0 ? 1 : 0);
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (sbyte)((1 << (bitsCount - j)) & first);
                first = (sbyte)(first & ~(1 << (bitsCount - (j - second))));
                first |= (sbyte)(bitToGet << second);
            }
            for (var j = 0; j < second; j++)
            {
                first = (sbyte)(first & ~(1 << (second - j - 1)));
                first |= (sbyte)(leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
