using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrateCalculator.Tests
{
    [TestClass()]
    public class CrateTests
    {
        [TestMethod()]
        public void getCostTest()
        {
            Crate c = new Crate();
            c.Length = 2;
            c.Width = 2;
            c.Height = 3;

            decimal result = c.getCost();   //this should be wrong should multiply by 0.23 *2*2*3
            decimal target = 2.76M;
            Assert.AreEqual(target, result, "getCostTest failed");
        }

        [TestMethod()]
        public void getChargeTest()
        {
            Crate c = new Crate();
            c.Length = 2;
            c.Width = 2;
            c.Height = 3;

            decimal result = c.getCharge();
            decimal target = 6;
            Assert.AreEqual(target, result, "getChargeTest failed");
        }

        [TestMethod()]
        public void getProfitTest()
        {
            Crate c = new Crate();
            c.Length = 2;
            c.Width = 2;
            c.Height = 3;

            decimal result = c.getProfit();
            decimal target = 3.24M;
            Assert.AreEqual(target, result, "getProfitTest failed");
        }


        [TestMethod()]
        public void CrateTest()
        {
            // let's just make a crate object and
            // make sure that doesn't crash.

            Crate c = new Crate();
        }

        [TestMethod()]
        public void getVolumeTest()
        {
            Crate c = new Crate();
            c.Length = 0;
            c.Width = 0;
            c.Height = 0;
            decimal result = c.getVolume();
            decimal target = 0;

            Assert.AreEqual(target, result, "getVolume zero test failed");

            c.Length = 1;
            c.Width = 2;
            c.Height = 3;
            result = c.getVolume();
            target = 6;

            Assert.AreEqual(target, result, "getVolume failed");
        }


        [TestMethod()]
        public void display_outputTest()
        {
            // create a crate, and call
            // display_output, for a 1x1x1
            // crate.  As long as it hasn't crashed,
            // it passes the test.

            Crate c = new Crate();
            c.display_output();
            c.Height = 1;
            c.Width = 1;
            c.Length = 1;
            c.display_output();

        }

    }
}