namespace Calculator.Core.Strategies.SignedInt32Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;

    using Utilities;

    [Component]
    public class BitwiseRotationLeftOperationSignedInt32Strategy
    {
        public int Calculate(int first, int second)
        {
            var bitsCount = Marshal.SizeOf(typeof(int)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var leftMostBits = new List<int>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1 << (bitsCount - j) & first)!= 0 ? 1 : 0;
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1 << (bitsCount - j)) & first;
                first = first & ~(1 << (bitsCount - (j - second)));
                first |= bitToGet << second;
            }
            for (var j = 0; j < second; j++)
            {
                first = first & ~(1 << (second - j - 1));
                first |= (leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
