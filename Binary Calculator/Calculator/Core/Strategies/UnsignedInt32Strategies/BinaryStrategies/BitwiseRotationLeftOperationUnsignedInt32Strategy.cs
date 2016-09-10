namespace Calculator.Core.Strategies.UnsignedInt32Strategies.BinaryStrategies
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;


    using Calculator.Utilities;

    public class BitwiseRotationLeftOperationUnsignedInt32Strategy/* */
    {
        public uint Calculate(uint first, uint element, object one)
        {
            var second = (int)element;
            var bitsCount = Marshal.SizeOf(typeof(uint)) * Constants.BitsInAByte;
            second = second % bitsCount;
            var leftMostBits = new List<uint>();
            for (var j = 1; j <= second; j++)
            {
                var bitToGet = (1u << (bitsCount - j) & first) != 0 ? 1u : 0;
                leftMostBits.Add(bitToGet);
            }

            for (var j = second + 1; j <= bitsCount; j++)
            {
                var bitToGet = (1u << (bitsCount - j)) & first;
                first = first & ~(1u << (bitsCount - (j - second)));
                first |= bitToGet << second;
            }
            for (var j = 0; j < second; j++)
            {
                first = first & ~(1u << (second - j - 1));
                first |= (leftMostBits[j] << (second - j - 1));
            }

            return first;
        }
    }
}
