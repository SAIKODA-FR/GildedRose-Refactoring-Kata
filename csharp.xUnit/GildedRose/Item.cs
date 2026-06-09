namespace GildedRoseKata;

public class Item : IItem
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    private void ResetQuality()
    {
        Quality = 0;
    }

    private void DecreaseQuality()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }
    }

    private void DecreaseSellin()
    {
        SellIn = SellIn - 1;
    }

    public void UpdateQuality()
    {
        DecreaseQuality();

        DecreaseSellin();

        if (SellIn < 0)
        {
            DecreaseQuality();
        }
    }
}