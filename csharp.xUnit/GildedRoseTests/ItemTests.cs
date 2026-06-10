using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class ItemTests
{
    [Fact]
    public void Given_SellIn_12_When_One_Day_Passes_Then_SellIn_Is_11()
    {
        var item = new Item("Normal Item", sellIn: 12, quality: 5);
        item.UpdateQuality();
        Assert.Equal(11, item.SellIn);
    }

    [Fact]
    public void Given_Quality_12_When_One_Day_Passes_Then_Quality_Is_11()
    {
        var item = new Item("Normal Item", sellIn: 5, quality: 12);
        item.UpdateQuality();
        Assert.Equal(11, item.Quality);
    }

    [Fact]
    public void Given_Quality_12_And_SellIn_Expired_When_One_Day_Passes_Then_Quality_Is_10()
    {
        var item = new Item("Normal Item", sellIn: -1, quality: 12);
        item.UpdateQuality();
        Assert.Equal(10, item.Quality);
    }

    [Fact]
    public void Given_Quality_0_And_SellIn_Expired_When_One_Day_Passes_Then_Quality_Is_0()
    {
        var item = new Item("Normal Item", sellIn: -1, quality: 0);
        item.UpdateQuality();
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void Given_Quality_0_And_SellIn_Positive_When_One_Day_Passes_Then_Quality_Is_0()
    {
        var item = new Item("Normal Item", sellIn: 2, quality: 0);
        item.UpdateQuality();
        Assert.Equal(0, item.Quality);
    }
}
