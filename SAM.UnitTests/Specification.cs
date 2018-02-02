using System;
using NUnit.Framework;

namespace SAM.UnitTests
{
    [TestFixture]
    public class Specification
    {
        protected bool DblEqual(double d1, double d2)
        {
            var dV = Math.Abs(d1 - d2);
            return dV < 0.0000001;
        }
    }


}