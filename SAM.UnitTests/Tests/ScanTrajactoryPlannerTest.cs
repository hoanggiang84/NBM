using System;
using NUnit.Framework;

namespace SAM.UnitTests
{
    public class ScanTrajactoryPlannerTest:Specification
    {
        private const double scanDistance = 10.0;
        private const double resolution = 0.02;

        [Test]
        public void EvenScanIndex_GetScanDestination_ReturnScanWidth()
        {
            var scanIndex = GetRandomScanIndex()*2;
            var scanPlanner = new ScanTrajactoryPlanner(scanDistance);
            Assert.AreEqual(scanDistance, scanPlanner.GetScanWidthDestination(scanIndex));
        }

        private static int GetRandomScanIndex()
        {
            var rand = new Random();
            var scanIndex = rand.Next(1000);
            return scanIndex;
        }

        [Test]
        public void OddScanIndex_GetScanDestination_ReturnZero()
        {
            var scanIndex = GetRandomScanIndex()*2 + 1;
            var scanPlanner = new ScanTrajactoryPlanner(scanDistance);
            Assert.AreEqual(0, scanPlanner.GetScanWidthDestination(scanIndex));
        }

        [Test]
        public void GetNextScanPosition_ReturnResolutionMultipliesbyScanIndex()
        {
            var scanIndex = GetRandomScanIndex();
            var scanPlanner = new ScanTrajactoryPlanner(scanDistance, resolution);
            Assert.AreEqual(resolution*scanIndex, scanPlanner.GetNextScanHeightPosition(scanIndex));
        }


        private bool DoubleEquals(double d1, double d2)
        {
            return Math.Abs(d1 - d2) < 0.0000001;
        }
    }
}