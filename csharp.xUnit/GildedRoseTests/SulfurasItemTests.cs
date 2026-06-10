using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class SulfurasItemTests
{
    [Fact]
    public void Given_Quality_10_When_One_Day_Passes_Then_Quality_Is_10()
    {
        var item = new SulfurasItem("Sulfuras, Hand of Ragnaros", sellIn: 5, quality: 10);
        item.UpdateQuality();
        Assert.Equal(10, item.Quality);
    }

    [Fact]
    public void Given_SellIn_Negative_When_One_Day_Passes_Then_SellIn_Is_Unchanged()
    {
        var item = new SulfurasItem("Sulfuras, Hand of Ragnaros", sellIn: -1, quality: 80);
        item.UpdateQuality();
        Assert.Equal(-1, item.SellIn);
    }
}
