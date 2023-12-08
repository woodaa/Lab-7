using Bits_Brewery;

namespace Hops_Type_Test
{
    [TestClass]
    public class HopTypeTest
    {
        [TestMethod]
        public void TestStateConstructor()
        {
            HopType hop1 = new HopType();
            Assert.IsNotNull(hop1);
            Assert.AreEqual(0, hop1.HopID);
            Assert.AreEqual(null, hop1.HopName);
            string newName = "Testing";
            HopType hop2 = new HopType(0, newName);
            Assert.IsNotNull(hop2);
            Assert.AreEqual(0, hop2.HopID);
            Assert.AreEqual(newName, hop2.HopName);
        }

            [TestMethod]
            public void TestStateToString()
            {
                HopType hop1 = new HopType(1, "Aroma");
                Assert.IsTrue(hop1.ToString().Contains("Aroma"));
            }
        
    }
}