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
            UpdateQualityAndSellin(item);
        }
    }

    private void UpdateQualityAndSellinSulfuras(Item item)
    {

    }

    private void UpdateQualityAndSellin(Item item)
    {
        
        if (item.Name == BackStage)
        {
            HandleBackStage(item);
        }
        else
        {
            item.DecreaseQuality();
        }

        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            if (item.Name == BackStage)
            {
                item.ResetQuality();
            }
            else
            {
                item.DecreaseQuality();
            }
        }
    }

    private void UpdateQualityAndSellinBrie(Item item)
    {
        HandleBrie(item);
        item.DecreaseSellin();

        if (item.SellIn < 0)
        {
            if (item.Quality < MaxQuality)
            {
                item.IncreaseQuality();
            }
        }
    }

    private static void HandleBrie(Item item)
    {
        if (item.Quality < MaxQuality)
        {
            item.IncreaseQuality();
        }
    }

    private static void HandleBackStage(Item item)
    {
        if (item.Quality < MaxQuality)
        {
            item.IncreaseQuality();
            HandleBackStageQuality(item);
        }
    }

    private static void HandleBackStageQuality(Item item)
    {
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
}