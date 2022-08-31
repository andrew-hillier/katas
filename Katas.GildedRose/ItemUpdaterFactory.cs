namespace Katas.GildedRose;

internal class ItemUpdaterFactory
{
    public IItemUpdater Create(string itemName)
    {
        switch (itemName)
        {
            case "Aged Brie":
                return new AgedBrieItemUpdater();
            case "Backstage passes to a TAFKAL80ETC concert":
                return new BackstagePassItemUpdater();
            case "Sulfuras, Hand of Ragnaros":
                return new SulfurasItemUpdater();
            case "Conjured Item":
                return new ConjuredItemUpdater();
            default:
                return new StandardItemUpdater();
        }
    }
}