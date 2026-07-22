using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class StandardItemTests
    {
        [Fact]
        public void Sellin_decreases_each_day()
        {
            var standardItem = new StandardItem("testName", 0, 0);

            standardItem.UpdateQuality();

            Assert.Equal(-1, standardItem.SellIn);
        }
    }
}
