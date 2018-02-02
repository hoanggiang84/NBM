using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace SAM.Core.HPCNC
{
    public class CncCom : IDisposable
    {
        public const int BAUDRATE = 115200;
        public const int TIMEOUT_MS = 2000;

        public readonly string PortName;
        public readonly byte Address;

        private const byte HEADER = 0x1A;
        private const byte RETURN = (byte) '\r';
        private const byte NEWLINE = (byte) '\n';

        private SerialPort _comPort;
        private readonly CncCommand _gantryCmd;
        private readonly List<byte> _receiveCncPackage = new List<byte>();

        private bool _packageDetect;
        private bool _returnDetect;

        public CncCom(string portName, byte address = 1)
        {
            PortName = portName;
            Address = address;
            _gantryCmd = new CncCommand(address);
            initialize_serial_port();
        }

        #region Private functions
        private void initialize_serial_port()
        {
            _comPort = new SerialPort(PortName)
                           {
                               BaudRate = BAUDRATE,
                               DataBits = 8,
                               StopBits = StopBits.One,
                               Parity = Parity.None,
                               Handshake = Handshake.None
                           };

            _comPort.Open();
        }

        private void extractCncReceivedPackage(string receiveMsg)
        {
            foreach (var c in receiveMsg)
            {
                switch ((byte) c)
                {
                    case HEADER:
                        _packageDetect = true;
                        _receiveCncPackage.Clear();
                        break;

                    case RETURN:
                        if (_packageDetect)
                            _returnDetect = true;
                        break;

                    case NEWLINE:
                        if (!_returnDetect)
                            _receiveCncPackage.Clear();

                        _packageDetect = false;
                        _returnDetect = false;
                        break;

                    default:
                        if (_packageDetect)
                            _receiveCncPackage.Add((byte) c);
                        break;
                }
            }
        }

        private void sendCommandAndVerifyResponse(List<byte> commandBytes)
        {
            var timer = new Stopwatch();
            timer.Restart();
            while (timer.ElapsedMilliseconds <= TIMEOUT_MS)
            {
                try
                {
                    sendCommand(commandBytes);
                    waitCncResponse();
                    verifyCncReceivedPackage();
                    return;
                }
                catch (InvalidCncReceivePackageException)
                {
                    throw;
                }
                catch(Exception)
                { }
            }
        }

        private void verifyCncReceivedPackage()
        {
            if (!_gantryCmd.VerifyPackage(_receiveCncPackage)) 
                throw new InvalidCncReceivePackageException("Invalid CNC Received Package");
        }

        private void waitCncResponse()
        {
            Thread.Sleep(50);

            var timer = new Stopwatch();
            timer.Restart();
            while (_comPort.BytesToRead <= 0)
            {
                if (timer.ElapsedMilliseconds <= 200)
                    Thread.Sleep(50);
                else
                    throw new ReceiveTimeOutException("Receive Time Out");
            }

            extractCncReceivedPackage(_comPort.ReadExisting());
        }

        private void sendCommand(List<byte> cmd)
        {
            if (!_comPort.IsOpen)
                _comPort.Open();

            _comPort.Write(cmd.ToArray(), 0, cmd.Count);
        }
        #endregion

        public List<byte> GetCncInfo()
        {
            sendCommandAndVerifyResponse(_gantryCmd.RequireCncStatus());
            return _receiveCncPackage;
        }

        public void Dispose()
        {
            if(_comPort.IsOpen)
                _comPort.Close();
        }

        public void Reset()
        {
            sendCommandAndVerifyResponse(_gantryCmd.Reset());
        }

        public void Home()
        {
            sendCommandAndVerifyResponse(_gantryCmd.Home());
        }

        /// <summary>
        /// Continue run G code after 'Pause'
        /// </summary>
        public void Start()
        {
            sendCommandAndVerifyResponse(_gantryCmd.StartAuto());
        }

        public void Pause()
        {
            sendCommandAndVerifyResponse(_gantryCmd.PauseAuto());
        }

        /// <summary>
        /// Run G code. Use 'Pause' and 'Start' to pause and continue run G code
        /// </summary>
        public void GCode(string gCode, byte feedRate)
        {
            sendCommandAndVerifyResponse(_gantryCmd.GCode(gCode, feedRate));    
        }

        public void XabsSetZero()
        {
            sendCommandAndVerifyResponse(_gantryCmd.XSetZeroAbsolute());
        }

        public void YabsSetZero()
        {
            sendCommandAndVerifyResponse(_gantryCmd.YSetZeroAbsolute());
        }

        public void ZabsSetZero()
        {
            sendCommandAndVerifyResponse(_gantryCmd.ZSetZeroAbsolute());
        }

        /// <summary>
        /// Stop jogging by calling RequireCncInfo or GetCncInfo
        /// </summary>
        public List<byte> Jog(JogDirection direction, byte feedrate)
        {
            switch (direction)
            {
                case JogDirection.XPLUS:
                    sendCommandAndVerifyResponse(_gantryCmd.XJogPlus(feedrate));
                    break;
                case JogDirection.XMINUS:
                    sendCommandAndVerifyResponse(_gantryCmd.XJogMinus(feedrate));
                    break;
                case JogDirection.YPLUS:
                    sendCommandAndVerifyResponse(_gantryCmd.YJogPlus(feedrate));
                    break;
                case JogDirection.YMINUS:
                    sendCommandAndVerifyResponse(_gantryCmd.YJogMinus(feedrate));
                    break;
                case JogDirection.ZPLUS:
                    sendCommandAndVerifyResponse(_gantryCmd.ZJogPlus(feedrate));
                    break;
                case JogDirection.ZMINUS:
                    sendCommandAndVerifyResponse(_gantryCmd.ZJogMinus(feedrate));
                    break;
            }
            return _receiveCncPackage;
        }
    }

    public enum JogDirection
    {
        NONE,
        XPLUS,
        XMINUS,
        YPLUS,
        YMINUS,
        ZPLUS,
        ZMINUS
    }

    public class InvalidCncReceivePackageException:Exception
    {
        public InvalidCncReceivePackageException(string message):base(message)
        {
        }
    }

    public class ReceiveTimeOutException:Exception
    {
        public ReceiveTimeOutException(string message):base(message)
        {
        }
    }
}