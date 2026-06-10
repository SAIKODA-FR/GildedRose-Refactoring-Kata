using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class BackStageItemTests
{
    [Fact]
    public void Given_Quality_At_Max_And_SellIn_10_When_One_Day_Passes_Then_Quality_Does_Not_Exceed_50()
    {
        var item = new BackStageItem("Backstage passes to a TAFKAL80ETC concert", sellIn: 10, quality: 50);
        item.UpdateQuality();
        Assert.Equal(50, item.Quality);
    }

    [Fact]
    public void Given_Quality_20_And_SellIn_20_When_One_Day_Passes_Then_Quality_Is_21()
    {
        var item = new BackStageItem("Backstage passes to a TAFKAL80ETC concert", sellIn: 20, quality: 20);
        item.UpdateQuality();
        Assert.Equal(21, item.Quality);
    }

    [Fact]
    public void Given_Quality_20_And_SellIn_10_When_One_Day_Passes_Then_Quality_Is_22()
    {
        var item = new BackStageItem("Backstage passes to a TAFKAL80ETC concert", sellIn: 10, quality: 20);
        item.UpdateQuality();
        Assert.Equal(22, item.Quality);
    }

    [Fact]
    public void Given_Quality_20_And_SellIn_5_When_One_Day_Passes_Then_Quality_Is_23()
    {
        var item = new BackStageItem("Backstage passes to a TAFKAL80ETC concert", sellIn: 5, quality: 20);
        item.UpdateQuality();
        Assert.Equal(23, item.Quality);
    }

    [Fact]
    public void Given_Quality_20_And_SellIn_0_When_One_Day_Passes_Then_Quality_Drops_To_0()
    {
        var item = new BackStageItem("Backstage passes to a TAFKAL80ETC concert", sellIn: 0, quality: 20);
        item.UpdateQuality();
        Assert.Equal(0, item.Quality);
    }
}
