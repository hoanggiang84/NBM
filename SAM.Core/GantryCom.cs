using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace SAM.Core
{
    public class GantryCom : IDisposable
    {
        public const int BAUDRATE = 115200;
        public delegate void PackageReceived(List<byte> package);

        public event PackageReceived CncPackageReceived;

        private const byte HEADER = 0x1A;
        private const byte RETURN = (byte) '\r';
        private const byte NEWLINE = (byte) '\n';

        private SerialPort _comPort;
        private readonly string _portName;

        public GantryCom(string portName)
        {
            _portName = portName;
            initialize_serial_port();
        }

        private void initialize_serial_port()
        {
            _comPort = new SerialPort(_portName)
                           {
                               BaudRate = BAUDRATE,
                               DataBits = 8,
                               StopBits = StopBits.One,
                               Parity = Parity.None,
                               Handshake = Handshake.None
                           };

            _comPort.DataReceived += comPort_DataReceived;
        }

        private List<byte> _receiveCncPackage = new List<byte>();

        private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(5);
            var receiveMsg = _comPort.ReadExisting();
            var packageDetect = false;
            var returnDetect = false;
            foreach (var c in receiveMsg)
            {
                switch ((byte)c)
                {
                    case HEADER:
                        packageDetect = true;
                        _receiveCncPackage.Clear();
                        break;

                    case RETURN:
                        returnDetect = true;
                        break;

                    case NEWLINE:
                        if(!returnDetect)
                            throw new Exception("Unrecognized CNC response");

                        if(CncPackageReceived != null)
                            CncPackageReceived.Invoke(_receiveCncPackage);
                        break;

                    default:
                        if (packageDetect)
                            _receiveCncPackage.Add((byte)c);
                        break;
                }
            }
        }

        public void GetCncInfo()
        {
            var gantryCmd = new GantryCommand(1);
            var cmd = gantryCmd.RequireCncStatus();
            if(!_comPort.IsOpen)
                _comPort.Open();
            _comPort.Write(cmd.ToArray(), 0, cmd.Count);
        }

        public void Dispose()
        {
            if(_comPort.IsOpen)
                _comPort.Close();
        }
    }
}