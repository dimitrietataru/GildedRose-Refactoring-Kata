using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly  IList<Item> items = new List<Item>();

        public GildedRose(IList<Item> items) => this.items = items;

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                switch (item.Name)
                {
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    case "Aged Brie":
                        HandleAgedBrie(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        HandleBackstagePasses(item);
                        break;
                    case "Conjured Mana Cake":
                        HandleConjuredManaCake(item);
                        break;
                    default:
                        HandleDefault(item);
                        break;
                }
            }
        }

        private void HandleDefault(Item item)
        {
            int modifier = item.SellIn > 0 ? -1 : -2;

            PassOneDay(item, modifier);
        }

        private void HandleAgedBrie(Item item)
        {
            int modifier = item.SellIn > 0 ? 1 : 2;

            PassOneDay(item, modifier);
        }

        private void HandleBackstagePasses(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
                item.SellIn--;

                return;
            }

            int modifier = 1;
            modifier = item.SellIn <= 10 ? 2 : modifier;
            modifier = item.SellIn <= 5 ? 3 : modifier;
            
            PassOneDay(item, modifier);
        }

        private void HandleConjuredManaCake(Item item)
        {
            int modifier = item.SellIn > 0 ? -1 : -2;

            PassOneDay(item, modifier);
        }

        private void PassOneDay(Item item, int modifier)
        {
            item.Quality += modifier;
            item.SellIn--;

            item.Quality = Math.Max(0, item.Quality);
            item.Quality = Math.Min(50, item.Quality);
        }
    }
}
