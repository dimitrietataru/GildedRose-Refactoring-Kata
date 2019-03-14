using System;
using System.Collections.Generic;

namespace GildedRoseRefactoring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = new List<Item>
            {
                new Item("+5 Dexterity Vest", 10, 20, true),
                new Item("Aged Brie", 2, 0, false),
                new Item("Elixir of the Mongoose", 5, 7, true),
                new Item("Sulfuras, Hand of Ragnaros", 0, 80, false),
                new Item("Sulfuras, Hand of Ragnaros", -1, 80, false),
                new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20, false),
                new Item("Backstage passes to a TAFKAL80ETC concert", 10, 49, false),
                new Item("Backstage passes to a TAFKAL80ETC concert", 5, 49, false),
				new Item("Conjured Mana Cake", 3, 6, true)
            };

            var app = new GildedRose(items);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");

                Console.WriteLine(string.Join(Environment.NewLine, items));
                Console.WriteLine();

                app.UpdateQuality();
            }
        }
    }
}
