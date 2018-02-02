using System;
using System.IO;
using NUnit.Framework;

namespace SAM.UnitTests
{
    public class NetVerification:Specification
    {
        [Test]
        public void NetVerifyTest()
        {
            var str = 1.ToString("X2");
            Assert.AreEqual(2,str.Length);
            Assert.AreEqual('0', str[0]);
            Assert.AreEqual('1', str[1]);
        }

        private const string path = @"D:\CurrentWork\Matlab\SamData\CoinNov16\coinNov16_401.dat";

        [Test]
        public void ConvertBinaryFileToBScanData()
        {
            Assert.True(File.Exists(path),"Non existing file");

            var fileBytes = File.ReadAllBytes(path);
            var bScanData = new double[fileBytes.Length/8];

            var dblIdx = 0;
            for (var i = 0; i < fileBytes.Length; i = i + 8)
            {
                var dblBytes = new[]
                                   {
                                       fileBytes[i],
                                       fileBytes[i+1],
                                       fileBytes[i+2],
                                       fileBytes[i+3],
                                       fileBytes[i+4],
                                       fileBytes[i+5],
                                       fileBytes[i+6],
                                       fileBytes[i+7]
                                   };
                bScanData[dblIdx++] = BitConverter.ToDouble(dblBytes,0);
            }
            
            Assert.True(DblEqual(0.002148437546566, bScanData[0]));
            Assert.True(DblEqual(-0.002148437546566, bScanData[1]));
            Assert.True(DblEqual(0.006445312639698, bScanData[1000]));
            Assert.True(DblEqual(0.006445312639698, bScanData[1001]));
            Assert.True(DblEqual(0.006445312639698, bScanData[1002]));
        }

        [Test]
        public void ConvertBinaryFileTo2Darray()
        {
            Assert.True(File.Exists(path), "Existing file");

            var fileBytes = File.ReadAllBytes(path);
            
            var dblIdx = 0;
            const int numberOfRecords = 2500;
            const int recordLength = 500;
            var bScanData = new double[numberOfRecords, recordLength];

            for (var i = 0; i <fileBytes.Length; i = i + 8)
            {
                var row = dblIdx / recordLength;
                var col = dblIdx % recordLength;
                dblIdx++;

                var dblBytes = new[]
                                   {
                                       fileBytes[i],
                                       fileBytes[i+1],
                                       fileBytes[i+2],
                                       fileBytes[i+3],
                                       fileBytes[i+4],
                                       fileBytes[i+5],
                                       fileBytes[i+6],
                                       fileBytes[i+7]
                                   };

                bScanData[row, col] = BitConverter.ToDouble(dblBytes, 0);
                
            }

            Assert.True(DblEqual(0.002148437546566, bScanData[0,0]));
            Assert.True(DblEqual(-0.002148437546566, bScanData[0,1]));
            Assert.True(DblEqual(0.006445312639698, bScanData[2,0]));
            Assert.True(DblEqual(0.006445312639698, bScanData[2,1]));
            Assert.True(DblEqual(0.006445312639698, bScanData[2,2]));
        }

        [Test]
        public void BackAndForthRefPositionTest()
        {
            var minResolution = 0.01;
            var distance = 25;
            var modifiedDis = distance + minResolution;

            var numberOfRecords = (int) (modifiedDis/minResolution);
            Assert.AreEqual(2501, numberOfRecords);
        }
        
        [Test]
        public void WriteBinaryFileTest()
        {

        }

    }
}
