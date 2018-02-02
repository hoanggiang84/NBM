using System.Collections.Generic;
using NUnit.Framework;
using SAM.Core;

namespace SAM.UnitTests
{
    [TestFixture]
    public class GantryCommandTest
    {
        private const byte ADDRESS = 1;
        private readonly GantryCommand _cmd = new GantryCommand(ADDRESS);

        [Test]
        public void CreateRequireCncCommandTest()
        {
            var cmdPackage = _cmd.RequireCncStatus();
            assert_package_length(15,cmdPackage);
            assert_header_and_address(cmdPackage);
            assert_function_code("64", cmdPackage);
            assert_end(cmdPackage);
        }

        private static void assert_end(List<byte> cmdPackage)
        {
            Assert.AreEqual('\r', cmdPackage[cmdPackage.Count - 2]);
            Assert.AreEqual('\n', cmdPackage[cmdPackage.Count - 1]);
        }

        [Test]
        public void CreateGCodeCommandTest()
        {
            const string gcode = "G01X0Y0Z0F600"; 
            var cmdPackage = _cmd.GCode(gcode, 50);
            assert_package_length(26, cmdPackage);
            assert_header_and_address(cmdPackage);
            assert_function_code("C8", cmdPackage);

            var idx = 5;
            Assert.AreEqual('3', cmdPackage[idx++]);
            Assert.AreEqual('2', cmdPackage[idx++]);
            Assert.AreEqual('0', cmdPackage[idx++]);
            Assert.AreEqual('D', cmdPackage[idx++]);
            foreach (var c in gcode)
                Assert.AreEqual(c, cmdPackage[idx++]);

            assert_checksum("2C", cmdPackage);
        }

        private static void assert_checksum(string checksum, List<byte> cmdPackage)
        {
            Assert.AreEqual((byte)checksum[0], cmdPackage[cmdPackage.Count - 4]);
            Assert.AreEqual((byte)checksum[1], cmdPackage[cmdPackage.Count - 3]);
        }

        private static void assert_package_length(int length, List<byte> cmdPackage)
        {
            Assert.AreEqual(length, cmdPackage.Count);
        }

        private static void assert_function_code(string functionCode, List<byte> cmdPackage)
        {
            var fcode = functionCode.ToCharArray();
            Assert.AreEqual(fcode[0], cmdPackage[3]);
            Assert.AreEqual(fcode[1], cmdPackage[4]);
        }

        private static void assert_header_and_address(List<byte> cmdPackage)
        {
            Assert.AreEqual(0x1A, cmdPackage[0]);
            Assert.AreEqual('0', cmdPackage[1]);
            Assert.AreEqual('1', cmdPackage[2]);
        }
    }
}