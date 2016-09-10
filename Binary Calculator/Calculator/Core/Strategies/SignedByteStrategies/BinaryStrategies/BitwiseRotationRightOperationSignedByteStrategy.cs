namespace Calculator.Core.Strategies.SignedByteStrategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationSignedByteStrategy
    {
        public sbyte Calculate(sbyte first, sbyte second)
        {
            var bitsCount = (sbyte)(Marshal.SizeOf(typeof(sbyte)) * Constants.BitsInAByte);
            second = (sbyte)(second % bitsCount);
            var rightMostBits = new List<sbyte>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (sbyte)((1 << (j - 1) & first) != 0 ? 1 : 0);
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (sbyte)((1 << (j - 1) & first) != 0 ? 1 : 0);
                first = (sbyte)(first & ~(1 << (j - second - 1)));
                first |= (sbyte)(bitToGet << (j - second - 1));
            }

            for (var j = 0; j < second; j++)
            {
                first = (sbyte)(first & ~(1 << (bitsCount - second + j)));
                first |= (sbyte)(rightMostBits[j] << (bitsCount - second + j));
            }

            return first;
        }
    }
}
