using CopilotDemo.Repositories;

namespace CopilotDemo.Tests
{
    [TestClass]
    public class ItemRepositoryTests
    {
        private const string TestFilePath = "test_item.csv";

        [TestInitialize]
        public void Setup()
        {
            var testData = new List<string>
            {
                "ItemCode,ItemName,Price",
                "001,Apple,100",
                "002,Banana,150",
                "003,Orange,200"
            };
            File.WriteAllLines(TestFilePath, testData);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(TestFilePath))
            {
                File.Delete(TestFilePath);
            }
        }

        [TestMethod]
        public void GetItemByCode_ValidCode_ReturnsItem()
        {
            var repository = new ItemRepository();
            var item = repository.GetItemByCode("001");

            Assert.IsNotNull(item);
            Assert.AreEqual("001", item.ItemCode);
            Assert.AreEqual("Apple", item.ItemName);
            Assert.AreEqual(100, item.Price);
        }

        [TestMethod]
        public void GetItemByCode_InvalidCode_ReturnsNull()
        {
            var repository = new ItemRepository();
            var item = repository.GetItemByCode("999");

            Assert.IsNull(item);
        }

        [TestMethod]
        public void GetItemsByName_ValidName_ReturnsItems()
        {
            var repository = new ItemRepository();
            var items = repository.GetItemsByName("Apple");

            Assert.AreEqual(1, items.Count);
            Assert.AreEqual("001", items[0].ItemCode);
            Assert.AreEqual("Apple", items[0].ItemName);
            Assert.AreEqual(100, items[0].Price);
        }

        [TestMethod]
        public void GetItemsByName_InvalidName_ReturnsEmptyList()
        {
            var repository = new ItemRepository();
            var items = repository.GetItemsByName("Pineapple");

            Assert.AreEqual(0, items.Count);
        }
    }
}
