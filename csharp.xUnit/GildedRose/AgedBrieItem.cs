using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    internal class AgedBrieItem : Item
    {
        public override void UpdateQuality()
        {
            if (Quality < MAX_QUALITY)
            {
                IncreaseQuality();
            }

            DecreaseSellIn();

            if (SellIn < 0)
            {
                if (Quality < MAX_QUALITY)
                {
                    IncreaseQuality();
                }
            }
        }
    }
}
