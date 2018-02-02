using System;
using System.Collections.Generic;
using System.Linq;

namespace SAM.Core
{
    public class GantryCommand
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

        public GantryCommand(byte address)
        {
            Address = address;
        }

        public byte Address { get; private set; }

        public List<byte> RequireCncStatus()
        {
            return create_command_package(extract_byte_list(CMD_CNC_STATUS));
        }

        public List<byte> XSetZeroAbsolute()
        {
            return create_command_package(extract_byte_list(CMD_RESET_X_ABS));
        }

        public List<byte> YSetZeroAbsolute()
        {
            return create_command_package(extract_byte_list(CMD_RESET_Y_ABS));
        }
        public List<byte> ZSetZeroAbsolute()
        {
            return create_command_package(extract_byte_list(CMD_RESET_Z_ABS));
        }

        public List<byte> Home()
        {
            return create_command_package(extract_byte_list(CMD_HOME));
        }

        public List<byte> Reset()
        {
            return create_command_package(extract_byte_list(CMD_RESET));
        }

        public List<byte> StartAuto()
        {
            return create_command_package(extract_byte_list(CMD_START));
        }

        public List<byte> PauseAuto()
        {
            return create_command_package(extract_byte_list(CMD_PAUSE));
        }

        public List<byte> GCode(string gcode, byte feedrateInHundredPercent)
        {
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
            var validFeed = validate_feed_rate(feedRate);
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(validFeed, 0,0));
            return create_command_package(cmdBytes);
        }

        public List<byte> XJogMinus(byte feedRate)
        {
            var validFeed = (byte) (- validate_feed_rate(feedRate));
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(validFeed, 0, 0));
            return create_command_package(cmdBytes);
        }

        public List<byte> YJogPlus(byte feedRate)
        {
            var validFeed = validate_feed_rate(feedRate);
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0, validFeed, 0));
            return create_command_package(cmdBytes);
        }

        public List<byte> YJogMinus(byte feedRate)
        {
            var validFeed = (byte) (-validate_feed_rate(feedRate));
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0, validFeed, 0));
            return create_command_package(cmdBytes);
        }

        public List<byte> ZJogPlus(byte feedRate)
        {
            var validFeed = validate_feed_rate(feedRate);
            var cmdBytes = extract_byte_list(CMD_JOG);
            cmdBytes.AddRange(form_jog_params(0,0,validFeed));
            return create_command_package(cmdBytes);
        }

        public List<byte> ZJogMinus(byte feedRate)
        {
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
            byte sum = 0;
            if (bytes == null || bytes.Count == 0)
                sum = 0;
            else
                sum = bytes.Aggregate(sum, (current, b) => (byte)(current + b));

            return (byte)(0xff - sum + 1);
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
        #endregion
    }
}
