using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAM.Core.HPCNC
{
    public class CncCommand
    {
        const Byte HEADER = 0x1A;
        private const string CMD_CNC_STATUS = "64000000";
        private const string CMD_RESET_X_ABS = "B100";
        private const string CMD_RESET_Y_ABS = "B101";
        private const string CMD_RESET_Z_ABS = "B102";
        private const string CMD_RESET = "71";
        private const string CMD_START = "72";
        private const string CMD_PAUSE = "73";
        private const string CMD_HOME = "74";
        private const string CMD_JOG = "64";
        private const string CMD_GCODE = "C8";

        public CncCommand(byte address)
        {
            Address = address;
        }

        public byte Address { get; private set; }
        public string CurrentFunctionCode { get; private set; }

        public List<byte> RequireCncStatus()
        {
            CurrentFunctionCode = getFunctionCode(CMD_CNC_STATUS);
            return create_command_package(extract_byte_list(CMD_CNC_STATUS));
        }

        private string getFunctionCode(string cmdStr)
        {
            return cmdStr.Substring(0, 2);
        }

        public List<byte> XSetZeroAbsolute()
        {
            CurrentFunctionCode = getFunctionCode(CMD_RESET_X_ABS);
            return create_command_package(extract_byte_list(CMD_RESET_X_ABS));
        }

        public List<byte> YSetZeroAbsolute()
        {
            CurrentFunctionCode = getFunctionCode(CMD_RESET_Y_ABS);
            return create_command_package(extract_byte_list(CMD_RESET_Y_ABS));
        }
        public List<byte> ZSetZeroAbsolute()
        {
            CurrentFunctionCode = getFunctionCode(CMD_RESET_Z_ABS);
            return create_command_package(extract_byte_list(CMD_RESET_Z_ABS));
        }

        public List<byte> Home()
        {
            CurrentFunctionCode = getFunctionCode(CMD_HOME);
            return create_command_package(extract_byte_list(CMD_HOME));
        }

        public List<byte> Reset()
        {
            CurrentFunctionCode = getFunctionCode(CMD_RESET);
            return create_command_package(extract_byte_list(CMD_RESET));
        }

        public List<byte> StartAuto()
        {
            CurrentFunctionCode = getFunctionCode(CMD_START);
            return create_command_package(extract_byte_list(CMD_START));
        }

        public List<byte> PauseAuto()
        {
            CurrentFunctionCode = getFunctionCode(CMD_PAUSE);
            return create_command_package(extract_byte_list(CMD_PAUSE));
        }

        public List<byte> GCode(string gcode, byte feedrateInHundredPercent)
        {
            CurrentFunctionCode = getFunctionCode(CMD_GCODE);
            var gCodeBytes = extract_byte_list(gcode);
            var gCodeLength = extract_two_hex_bytes((byte) gCodeBytes.Count);
            var validFeedrate = validate_feed_rate(feedrateInHundredPercent);
            var feedrate = extract_two_hex_bytes(validFeedrate);

            var cmdBytes = extract_byte_list(CMD_GCODE);
            cmdBytes.AddRange(feedrate);
            cmdBytes.AddRange(gCodeLength);
            cmdBytes.AddRange(gCodeBytes);
            return create_command_package(cmdBytes);
        }

        public List<byte> XJogPlus(byte feedRate)
        {
            CurrentFunctionCode = getFunctionCode(CMD_JOG);
            var validFeed = validate_feed_rate(feedRate);
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(validFeed, 0,0));
            return create_command_package(cmdBytes);
        }

        public List<byte> XJogMinus(byte feedRate)
        {
            CurrentFunctionCode = getFunctionCode(CMD_JOG);
            var validFeed = (byte) (- validate_feed_rate(feedRate));
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(validFeed, 0, 0));
            return create_command_package(cmdBytes);
        }

        public List<byte> YJogPlus(byte feedRate)
        {
            CurrentFunctionCode = getFunctionCode(CMD_JOG);
            var validFeed = validate_feed_rate(feedRate);
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0, validFeed, 0));
            return create_command_package(cmdBytes);
        }

        public List<byte> YJogMinus(byte feedRate)
        {
            CurrentFunctionCode = getFunctionCode(CMD_JOG);
            var validFeed = (byte) (-validate_feed_rate(feedRate));
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0, validFeed, 0));
            return create_command_package(cmdBytes);
        }

        public List<byte> ZJogPlus(byte feedRate)
        {
            CurrentFunctionCode = getFunctionCode(CMD_JOG);
            var validFeed = validate_feed_rate(feedRate);
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0,0,validFeed));
            return create_command_package(cmdBytes);
        }

        public List<byte> ZJogMinus(byte feedRate)
        {
            CurrentFunctionCode = getFunctionCode(CMD_JOG);
            var validFeed = (byte) (-validate_feed_rate(feedRate));
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0, 0, validFeed));
            return create_command_package(cmdBytes);
        }

        #region Private methods
        private static IEnumerable<byte> extract_two_hex_bytes(byte num)
        {
            var result = new List<byte>();
            var numStr = num.ToString("X2");
            if (numStr.Length == 2)
            {
                result.Add((byte) numStr[0]);
                result.Add((byte) numStr[1]);
            }

            return result;
        }

        private static byte calculate_checksum(IReadOnlyCollection<byte> bytes)
        {
            return Utilities.CalculateChecksum(bytes);
        }

        private List<byte> create_command_package(IEnumerable<byte> bytes)
        {
            var bytesForCheckSum = new List<byte>();
            bytesForCheckSum.AddRange(extract_two_hex_bytes(Address));
            bytesForCheckSum.AddRange(bytes);

            var cmdPackage = new List<byte> { HEADER };
            cmdPackage.AddRange(bytesForCheckSum);
            cmdPackage.AddRange(extract_two_hex_bytes(calculate_checksum(bytesForCheckSum)));
            cmdPackage.Add((byte)'\r');
            cmdPackage.Add((byte)'\n');
            return cmdPackage;
        }

        private static IEnumerable<byte> form_jog_params(byte xFeed, byte yFeed, byte zFeed)
        {
            var jogParams = new List<Byte>();
            jogParams.AddRange(extract_two_hex_bytes(yFeed));
            jogParams.AddRange(extract_two_hex_bytes(xFeed));
            jogParams.AddRange(extract_two_hex_bytes(zFeed));
            return jogParams;
        }

        private static byte validate_feed_rate(byte feed)
        {
            if (feed <= 0)
                return 0;

            return feed > 100 ? (byte) 100 : feed;
        }

        private static List<byte> extract_byte_list(string str)
        {
            return str.Select(c => (byte)c).ToList();
        }

        /// <summary>
        /// Verify package address and package function code
        /// </summary>
        /// <param name="package"></param>
        /// <returns></returns>
        public bool VerifyPackage(string package)
        {
            try
            {
                if (package[0] == 0x1A)
                {
                    return Address == byte.Parse(package.Substring(1, 2))
                        && CurrentFunctionCode == package.Substring(3,2);
                }

                return Address == byte.Parse(package.Substring(0, 2))
                       && CurrentFunctionCode == package.Substring(2, 2);
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool VerifyPackage(List<byte> package)
        {
            try
            {
                var addBytes = new List<byte> {package[0], package[1]};
                var fCodeBytes = new List<byte>{package[2], package[3]};
                if (package[0] == 0x1A)
                {
                    addBytes = new List<byte> { package[1], package[2] };
                    fCodeBytes = new List<byte> { package[3], package[4] };
                }

                var add = byte.Parse(Encoding.ASCII.GetString(addBytes.ToArray()));
                var fCode = Encoding.ASCII.GetString(fCodeBytes.ToArray());
                return Address == add && CurrentFunctionCode == fCode;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }

    public enum CMDTYPE
    {
        NONE,
        STATUS,
        RESET_XABS,
        RESET_YABS,
        RESET_ZABS,
        JOG,
        HOME,
        RESET_CNC,
        START,
        PAUSE,
        GCODE
    }
}
