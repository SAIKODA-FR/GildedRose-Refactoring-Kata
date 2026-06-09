using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private const string AgedBrie = "Aged Brie";
    private const string BackStage = "Backstage passes to a TAFKAL80ETC concert";
    private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
    private const int MaxQuality = 50;

    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            if (item.Name == Sulfuras)
            {
                continue;
            }
            if (item.Name == AgedBrie)
            {
                UpdateQualityAndSellinBrie(item);
                continue;
            }
            if (item.Name == BackStage)
            {
                UpdateQualityAndSellinBackStage(item);
                continue;
            }
            UpdateQualityAndSellin(item);
        }
    }

    private void UpdateQualityAndSellinSulfuras(Item item)
    {

    }

    private void UpdateQualityAndSellin(Item item)
    {
        item.DecreaseQuality();

        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            item.DecreaseQuality();
        }
    }

    private void UpdateQualityAndSellinBackStage(Item item)
    {
        if (item.Quality < MaxQuality)
        {
            item.IncreaseQuality();

            if (item.SellIn < 11)
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < MaxQuality)
                {
                    item.IncreaseQuality();
                }
            }
        }

        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            item.ResetQuality();
        }
    }

    private void UpdateQualityAndSellinBrie(Item item)
    {
        if (item.Quality < MaxQuality)
        {
            item.IncreaseQuality();
        }

        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            if (item.Quality < MaxQuality)
            {
                item.IncreaseQuality();
            }
        }
    }

}