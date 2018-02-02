using System;
using System.IO;
using NUnit.Framework;
using SAM.Core.DataProcessing;

namespace SAM.UnitTests
{
    public class SamBScanLoaderTest:Specification
    {
        private const string path = @"D:\CurrentWork\Matlab\SamData\CoinNov16\coinNov16_401.dat";

        [Test]
        public void LoadBscanDataFileTest()
        {
            const int numberOfRecords = 2500;
            const int recordLength = 500;

            var data = SamBScanLoader.LoadDouble(path, numberOfRecords, recordLength);

            Assert.True(DblEqual(0.002148437546566, data[0, 0]));
            Assert.True(DblEqual(-0.002148437546566, data[0, 1]));
            Assert.True(DblEqual(0.006445312639698, data[2, 0]));
            Assert.True(DblEqual(0.006445312639698, data[2, 1]));
            Assert.True(DblEqual(0.006445312639698, data[2, 2]));
        }
    }

    
}