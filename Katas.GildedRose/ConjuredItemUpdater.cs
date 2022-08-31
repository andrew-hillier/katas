namespace Katas.GildedRose;

internal class ConjuredItemUpdater : IItemUpdater
{
    public void UpdateQuality(Item item)
    {
        GildedRose.DecrementQuality(item);
        GildedRose.DecrementQuality(item);

        if (item.SellIn < 0)
        {
            GildedRose.DecrementQuality(item);
            GildedRose.DecrementQuality(item);
        }
    }

    public void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}