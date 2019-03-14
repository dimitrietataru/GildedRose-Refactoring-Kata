namespace GildedRoseRefactoring
{
    public class Item
    {
        public Item()
        {
        }

        public Item(string name, int sellIn, int quality, bool isDestructible)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
            IsDestructible = isDestructible;
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public bool IsDestructible { get; set; }

        public override string ToString()
        {
            return $"{Name}, {SellIn}, {Quality}";
        }
    }
}
