using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class CinemaFactorTests
    {
        [TestMethod]
        public void TestCreationCinema()
        {
            var cinemaFactory = new CinemaFactory();

            var item = new AddItemsInProps
            {
                Type = "divertissement"
            };

            var actual = cinemaFactory.createspace(item);

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(Cinema));
            Assert.AreEqual(item.Type, actual.Type);
        }
    }
}
