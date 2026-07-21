using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    internal class LegendaryItem: Item
    {
        public LegendaryItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
        }
    }
}
