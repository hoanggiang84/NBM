using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAM.HPCncForm.Classes
{
    class ScanGate
    {
        public int Offset;
        public int RecordLength;
        public double MaxAmp;

        public ScanGate(int offset = 0, int recordLength = 0, double maxAmp =0)
        {
            Offset = offset;
            RecordLength = recordLength;
            MaxAmp = maxAmp;
        }


    }
}
