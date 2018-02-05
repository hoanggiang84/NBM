namespace SAM.UnitTests
{
    public class ScanTrajactoryPlanner
    {
        public readonly double Resolution;
        public readonly double ScanWidth;
        public ScanTrajactoryPlanner(double scanDistance, double resolution = 0.001)
        {
            ScanWidth = scanDistance;
            Resolution = resolution;
        }

        public double GetScanWidthDestination(int scanIndex)
        {
            return IsEven(scanIndex) ? ScanWidth : 0;
        }

        public static bool IsEven(int num)
        {
            return num%2 == 0;
        }

        public double GetNextScanHeightPosition(int scanIndex)
        {
            return scanIndex*Resolution;
        }
    }
}