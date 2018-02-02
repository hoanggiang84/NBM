using NUnit.Framework;
using SAM.Core.HPCNC;

namespace SAM.UnitTests
{
    [TestFixture]
    public class CncInfoTest
    {
        private const string receiveMsg = "0164<Id,MPos:148.408,-21.164,0.000,0.000,WPos:0.000,0.000,0.000,-3.500," 
            + "Ln:0,F:0.,Fp:100,S:0.,Sp:100,SP:0,CL:0,MI:0,AS:1,JT:0,JM:0,Hi:0,AL:0,BC:458,CS:07";

        private CncInfo cncInfo;
        
        [SetUp]
        public void SetUp()
        {
           cncInfo = new CncInfo(receiveMsg); 
        }

        [Test]
        public void CncIDTest()
        {
            Assert.AreEqual(1, cncInfo.ID);
        }

        [Test]
        public void CncFunctionCodeTest()
        {
            Assert.AreEqual(100, cncInfo.FunctionCode);
        }

        [Test]
        public void CncStatusTest()
        {
            Assert.AreEqual("Idle", cncInfo.Status);
        }

        [Test]
        public void CncChecksumTest()
        {
            Assert.AreEqual(7, cncInfo.Checksum);
        }

        [Test]
        public void CncPositionTest()
        {
            Assert.AreEqual("148.408", cncInfo.Xm);
            Assert.AreEqual("-21.164", cncInfo.Ym);
            Assert.AreEqual("0.000", cncInfo.Zm);
            Assert.AreEqual("0.000", cncInfo.Am);
            Assert.AreEqual("0.000", cncInfo.Xa);
            Assert.AreEqual("0.000", cncInfo.Ya);
            Assert.AreEqual("0.000", cncInfo.Za);
            Assert.AreEqual("-3.500", cncInfo.Aa);
        }

        [Test]
        public void CncParametersTest()
        {
            Assert.AreEqual("0", cncInfo.Ln);
            Assert.AreEqual("0.", cncInfo.F);
            Assert.AreEqual("100", cncInfo.Fp);
            Assert.AreEqual("0.", cncInfo.S);
            Assert.AreEqual("100", cncInfo.Sp);
            Assert.AreEqual("0", cncInfo.SP);
            Assert.AreEqual("0", cncInfo.CL);
            Assert.AreEqual("0", cncInfo.MI);
            Assert.AreEqual("1", cncInfo.AS);
            Assert.AreEqual("0", cncInfo.JT);
            Assert.AreEqual("0", cncInfo.JM);
            Assert.AreEqual("0", cncInfo.Hi);
            Assert.AreEqual("0", cncInfo.AL);
            Assert.AreEqual("458", cncInfo.BC);
        }
    }
}
