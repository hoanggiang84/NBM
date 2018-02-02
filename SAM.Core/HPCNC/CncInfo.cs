using System;
using System.Collections.Generic;
using System.Globalization;

namespace SAM.Core.HPCNC
{
    public class CncInfo
    {
        public const string STATUS_IDLE = "Idle";
        public const string STATUS_AUTORUN = "Auto Run";
        public const string STATUS_FEEDHOLD = "Feed Hold";
        public const string STATUS_HOMING = "Homing";
        public const string STATUS_ALARM = "Alarm";
        public const string STATUS_CHECKMODE = "Check Mode";
        public const string STATUS_SAFETYDOOR = "Safety Door";
        public const string STATUS_JOGGING = "Jogging";
        public const string STATUS_NO_RESPONSE = "No Response";
        public const string STATUS_WAITING = "Waiting";

        private readonly Dictionary<string, string> statusDictionary = new Dictionary<string, string>
                                                                           {
                                                                               {"Id", STATUS_IDLE},
                                                                               {"Ru", STATUS_AUTORUN},
                                                                               {"Ho", STATUS_FEEDHOLD},
                                                                               {"Hm", STATUS_HOMING},
                                                                               {"Al", STATUS_ALARM},
                                                                               {"Ck", STATUS_CHECKMODE},
                                                                               {"Dr", STATUS_SAFETYDOOR},
                                                                               {"Jg", STATUS_JOGGING}
                                                                           };
        public readonly string ReceivedMessage;
        public CncInfo(string receivedMessage)
        {
            ReceivedMessage = receivedMessage;
            extract_cnc_info();
        }

        private void extract_cnc_info()
        {
            validate_checksum();
            extract_id();
            extract_function_code();
            extract_status();
            extract_position_and_parameters();
        }

        private void extract_position_and_parameters()
        {
            var words = ReceivedMessage.Split(new [] {',', ':'}, StringSplitOptions.RemoveEmptyEntries);

            if(words.Length < 40)
                return;

            Xm = words[2];
            Ym = words[3];
            Zm = words[4];
            Am = words[5];

            Xa = words[7];
            Ya = words[8];
            Za = words[9];
            Aa = words[10];

            Ln = words[12];
            F = words[14];
            Fp = words[16];
            S = words[18];
            Sp = words[20];
            SP = words[22];
            CL = words[24];
            MI = words[26];
            AS = words[28];
            JT = words[30];
            JM = words[32];
            Hi = words[34];
            AL = words[36];
            BC = words[38];
        }

        private void extract_status()
        {
            var words = ReceivedMessage.Split(new[] { '<', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                Status = STATUS_NO_RESPONSE;
                return;
            }

            if (words.Length == 1)
            {
                Status = STATUS_WAITING;
                return;
            }

            var receivedStatus = words[1];
            Status = statusDictionary.ContainsKey(receivedStatus) ? statusDictionary[receivedStatus] : receivedStatus;
        }

        private void extract_function_code()
        {
            var fcodeStr = ReceivedMessage.Substring(2, 2);
            FunctionCode = int.Parse(fcodeStr, NumberStyles.HexNumber);
        }

        private void extract_id()
        {
            var idStr = ReceivedMessage.Substring(0, 2);
            ID = (byte) int.Parse(idStr, NumberStyles.HexNumber);
        }

        public byte ID { get; private set;}

        public int FunctionCode { get; private set; }

        public string Status { get; private set; }

        public byte Checksum { get; private set; }

        private void validate_checksum() 
        {
            try
            {
                var checksumStr = ReceivedMessage.Substring(ReceivedMessage.Length - 2, 2);
                var checksumVal = byte.Parse(checksumStr, NumberStyles.HexNumber);
                var bytesToCalculateChecksum = new List<byte>();
                for (var i = 0; i < ReceivedMessage.Length - 2; i++)
                    bytesToCalculateChecksum.Add((byte)ReceivedMessage[i]);

                var expectedChecksum = Utilities.CalculateChecksum(bytesToCalculateChecksum);
                if (checksumVal != expectedChecksum)
                    throw new Exception("Wrong Checksum");

                Checksum = checksumVal;
            }
            catch (Exception ex)
            {
                throw new Exception("Check Sum Error: " + ex.Message);
            }
        }

        public string Xm { get; private set; }
        public string Ym { get; private set; }
        public string Zm { get; private set; }
        public string Am { get; private set; }

        public string Xa { get; private set; }
        public string Ya { get; private set; }
        public string Za { get; private set; }
        public string Aa { get; private set; }

        public string Ln { get; private set; }
        public string F { get; private set; }
        public string Fp { get; private set; }
        public string S { get; private set; }

        public string Sp { get; private set; }
        public string SP { get; private set; }
        public string CL { get; private set; }
        public string MI { get; private set; }

        public string AS { get; private set; }
        public string JT { get; private set; }
        public string JM { get; private set; }
        public string Hi { get; private set; }

        public string AL { get; private set; }
        public string BC { get; private set; }
    }
}
