﻿namespace Calculator.Core.Strategies.SignedInt16Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationLeftOperationSignedInt16Strategy
    {
        public short Calculate(short first, short second)
        {
            var bitsCount = (short)(Marshal.SizeOf(typeof(short)) * Constants.BitsInAByte);
            second = (short)(second % bitsCount);
            var leftMostBits = new List<short>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (short)((1 << (bitsCount - j) & first)!= 0 ? 1 : 0);
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (short)((1 << (bitsCount - j)) & first);
                first = (short)(first & ~(1 << (bitsCount - (j - second))));
                first |= (short)(bitToGet << second);
            }
            for (var j = 0; j < second; j++)
            {
                first = (short)(first & ~(1 << (second - j - 1)));
                first |= (short)(leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
