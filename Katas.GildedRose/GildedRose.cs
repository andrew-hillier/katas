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
}