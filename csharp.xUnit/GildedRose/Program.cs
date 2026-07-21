using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        Item[] items =
        [
            new StandardItem ("+5 Dexterity Vest", 10,  20),
            new AgedBrieItem ("Aged Brie", 2,  0),
            new StandardItem ("Elixir of the Mongoose", 5,  7),
            new LegendaryItem ("Sulfuras, Hand of Ragnaros", 0,  80),
            new LegendaryItem ("Sulfuras, Hand of Ragnaros", -1,  80),
            new BackstageItem
            (
                "Backstage passes to a TAFKAL80ETC concert",
                15,
                 20
            ),
            new BackstageItem
            (
                "Backstage passes to a TAFKAL80ETC concert",
                10,
                 49
            ),
            new BackstageItem
            (
                "Backstage passes to a TAFKAL80ETC concert",
                5,
                 49
            ),
            // this conjured item does not work properly yet
            new ConjuredItem ("Conjured Mana Cake", 3,  10)
        ];

        var app = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count(); j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}