namespace Calculator.Core.Strategies.SignedInt16Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationSignedInt16Strategy
    {
        public short Calculate(short first, short second)
        {
            var bitsCount = (short)(Marshal.SizeOf(typeof(short)) * Constants.BitsInAByte);
            second = (short)(second % bitsCount);
            var rightMostBits = new List<short>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (short)((1 << (j - 1) & first) != 0 ? 1 : 0);
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (short)((1 << (j - 1) & first) != 0 ? 1 : 0);
                first = (short)(first & ~(1 << (j - second - 1)));
                first |= (short)(bitToGet << (j - second - 1));
            }

            for (var j = 0; j < second; j++)
            {
                first = (short)(first & ~(1 << (bitsCount - second + j)));
                first |= (short)(rightMostBits[j] << (bitsCount - second + j));
            }

            return first;
        }
    }
}
