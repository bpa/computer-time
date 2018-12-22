using NUnit.Framework;

namespace ComputerTime.Tests
{
    [TestFixture]
    public class ExtensionsTests
    {
        private static readonly byte[] ONE = new byte[] { 0x01 };
        private static readonly byte[] TWO = new byte[] { 0x01, 0x02 };
        private static readonly byte[] FOUR = new byte[] { 0x01, 0x02, 0x04, 0x08 };

        [TestCaseSource("BitRotations")]
        public void RotateBitsTest(byte[] orig, int rot, byte[] expected) => Assert.AreEqual(expected, orig.RotateBits(rot));

        private static readonly object[] BitRotations =
        {
            new object[] {ONE, 8, ONE},
            new object[] {ONE, 1, new byte[] { 0x80 } },
            new object[] {ONE, -1, new byte[] { 0x02 } },
            new object[] {ONE, 2, new byte[] { 0x40 } },
            new object[] {ONE, 3, new byte[] { 0x20 } },
            new object[] {ONE, 45, new byte[] { 0x08 } },
            new object[] {ONE, -10, new byte[] { 0x04 } },
            new object[] {TWO, 8, new byte[] { 0x02, 0x01 } },
            new object[] {TWO, -8, new byte[] { 0x02, 0x01 } },
            new object[] {FOUR, 4, new byte[] { 0x20, 0x40, 0x80, 0x10 } },
            new object[] {FOUR, -4, new byte[] { 0x10, 0x20, 0x40, 0x80 } }
        };
    }

}