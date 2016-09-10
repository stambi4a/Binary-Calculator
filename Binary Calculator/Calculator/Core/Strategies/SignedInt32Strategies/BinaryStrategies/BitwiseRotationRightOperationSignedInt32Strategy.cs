namespace Calculator.Core.Strategies.SignedInt32Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using Calculator.Attributes;
    using Calculator.Utilities;

    [Component]
    public class BitwiseRotationRightOperationSignedInt32Strategy
    {
        public int Calculate(int first, int second)
        {
            var bitsCount = Marshal.SizeOf(typeof(int)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var rightMostBits = new List<int>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1 << (j - 1) & first) != 0 ? 1 : 0;
                rightMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1 << (j - 1) & first) != 0 ? 1 : 0;
                first = first & ~(1 << (j - second - 1));
                first |= bitToGet << (j - second - 1);
            }

            for (var j = 0; j < second; j++)
            {
                first = first & ~(1 << (bitsCount - second + j));
                first |= rightMostBits[j] << (bitsCount - second + j);
            }

            return first;
        }
    }
}
