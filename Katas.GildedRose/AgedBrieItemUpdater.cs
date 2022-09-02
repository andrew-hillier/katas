namespace Katas.GildedRose;

internal class AgedBrieItemUpdater : BaseItemUpdater
{
    public override void UpdateQuality(Item item)
    {
        IncrementQuality(item);

        if (item.SellIn < 0)
        {
            IncrementQuality(item);
        }
    }

    public override void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
}