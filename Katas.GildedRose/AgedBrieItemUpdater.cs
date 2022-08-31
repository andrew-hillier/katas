namespace Katas.GildedRose;

internal class AgedBrieItemUpdater : IItemUpdater
{
    public void UpdateQuality(Item item)
    {
        GildedRose.IncrementQuality(item);

        if (item.SellIn < 0)
        {
            GildedRose.IncrementQuality(item);
        }
    }

    public void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}