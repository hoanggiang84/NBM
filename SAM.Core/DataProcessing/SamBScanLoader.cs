using System;
using System.IO;

namespace SAM.Core.DataProcessing
{
    public static class SamBScanLoader
    {
        public static double[,] LoadDouble(string dataBinaryFile, int row, int col)
        {
            if (!File.Exists(dataBinaryFile))
                return null;

            var fileBytes = File.ReadAllBytes(dataBinaryFile);

            var bScanData = new double[row, col];
            var dblIdx = 0;
            for (var i = 0; i < fileBytes.Length; i = i + 8)
            {
                var irow = dblIdx/col;
                var icol = dblIdx%col;
                dblIdx++;

                var dblBytes = new[]
                                   {
                                       fileBytes[i],
                                       fileBytes[i + 1],
                                       fileBytes[i + 2],
                                       fileBytes[i + 3],
                                       fileBytes[i + 4],
                                       fileBytes[i + 5],
                                       fileBytes[i + 6],
                                       fileBytes[i + 7]
                                   };
                bScanData[irow, icol] = BitConverter.ToDouble(dblBytes, 0);
            }

            return bScanData;
        }

        public static float[,] LoadFloat(string dataBinaryFile, int row, int col)
        {
            if (!File.Exists(dataBinaryFile))
                return null;

            var fileBytes = File.ReadAllBytes(dataBinaryFile);

            var bScanData = new float[row, col];
            var dblIdx = 0;
            for (var i = 0; i < fileBytes.Length; i = i + 4)
            {
                var irow = dblIdx/col;
                var icol = dblIdx%col;
                dblIdx++;

                var dblBytes = new[]
                                   {
                                       fileBytes[i],
                                       fileBytes[i + 1],
                                       fileBytes[i + 2],
                                       fileBytes[i + 3]
                                   };

                bScanData[irow, icol] = BitConverter.ToSingle(dblBytes, 0);
            }

            return bScanData;
        }
    }
}