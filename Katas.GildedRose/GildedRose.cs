namespace Katas.GildedRose;

public class GildedRose
{
    IList<Item> Items;
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        var itemUpdaterFactory = new ItemUpdaterFactory();

        foreach (Item item in Items)
        {
            var itemUpdater = itemUpdaterFactory.Create(item.Name);

            itemUpdater.UpdateSellIn(item);
            itemUpdater.UpdateQuality(item);

            if (item.Name == "Sulfuras, Hand of Ragnaros") continue;
            if (item.Name == "Aged Brie") continue;
            if (item.Name == "Backstage passes to a TAFKAL80ETC concert") continue;

            DecrementQuality(item);

            if (item.SellIn < 0)
            {
                DecrementQuality(item);
            }
        }
    }

    internal static void IncrementQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality = item.Quality + 1;
        }
    }

    internal static void DecrementQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality--;
        }
    }
}