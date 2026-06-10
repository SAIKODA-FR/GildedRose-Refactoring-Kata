using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class AgedBrieItemTests
{
    [Fact]
    public void Given_Quality_10_When_One_Day_Passes_Then_Quality_Is_11()
    {
        var item = new BrieItem("Aged Brie", sellIn: 5, quality: 10);
        item.UpdateQuality();
        Assert.Equal(11, item.Quality);
    }


    [Fact]
    public void Quality_increases_by_2_when_expired()
    {
        var item = new BrieItem("Aged Brie", sellIn: -1, quality: 10);
        item.UpdateQuality();
        Assert.Equal(12, item.Quality);
    }

    [Fact]
    public void Given_Quality_At_Max_When_One_Day_Passes_Then_Quality_Does_Not_Exceed_50()
    {
        var item = new BrieItem("Aged Brie", sellIn: 5, quality: 50);
        item.UpdateQuality();
        Assert.Equal(50, item.Quality);
    }
}
