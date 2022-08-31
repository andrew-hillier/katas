namespace Katas.GildedRose;

internal class StandardItemUpdater : IItemUpdater
{
    public void UpdateQuality(Item item)
    {
        GildedRose.DecrementQuality(item);

        if (item.SellIn < 0)
        {
            GildedRose.DecrementQuality(item);
        }
    }

    public void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}