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