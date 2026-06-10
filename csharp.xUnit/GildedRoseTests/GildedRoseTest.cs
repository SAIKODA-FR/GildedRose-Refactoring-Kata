using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_calls_updateQuality_on_all_items()
        {
            var item = new SpyItem();
            IList<IItem> items = [item];
            var gildedRose = new GildedRose(items);

            gildedRose.UpdateQuality();

            Assert.All([item], (i) => Assert.True(i.WasCalled));
        }
    }
}
