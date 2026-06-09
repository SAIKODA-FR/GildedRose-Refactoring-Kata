using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose(IList<IItem> Items)
{
    readonly IList<IItem> Items = Items;

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            item.UpdateQuality();
        }
    }
}