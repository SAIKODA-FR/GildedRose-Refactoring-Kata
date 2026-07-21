using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IReadOnlyCollection<Item> Items;

    public GildedRose(IReadOnlyCollection<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (Item item in Items)
        {
            item.UpdateQuality();
        }
    }
}