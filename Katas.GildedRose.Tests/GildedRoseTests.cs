namespace Katas.GildedRose.Tests;

public class GildedRoseTests
{
    [Theory]
    [InlineData("Standard Item", 10, 10, 9, 9)] // At the end of each day our system lowers both values for every item
    [InlineData("Standard Item", 10, 0, 8, -1)] // Once the sell by date has passed, Quality degrades twice as fast
    [InlineData("Standard Item", 0, 10, 0, 9)] // The Quality of an item is never negative
    [InlineData("Aged Brie", 10, 10, 11, 9)] //“Aged Brie” actually increases in Quality the older it gets
    [InlineData("Aged Brie", 50, 10, 50, 9)] // The Quality of an item is never more than 50
    [InlineData("Aged Brie", 10, -10, 12, -11)] // ...
    [InlineData("Sulfuras, Hand of Ragnaros", 10, 10, 10, 10)] // “Sulfuras”, being a legendary item, never has to be sold or decreases in Quality
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 20, 20, 21, 19)] // “Backstage passes”, like aged brie, increases in Quality as it’s SellIn value approaches;
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 20, 10, 22, 9)] // ...Quality increases by 2 when there are 10 days or less
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 20, 5, 23, 4)] // ...and by 3 when there are 5 days or less
    [InlineData("Backstage passes to a TAFKAL80ETC concert", 20, 0, 0, -1)] // ...but Quality drops to 0 after the concert
    public void UpdateQuality_Scenarios(string name, int initialQuality, int initialSellIn, int expectedQuality, int expectedSellIn)
    {
        // Arrange.
        var item = new Item { Name = name, Quality = initialQuality, SellIn = initialSellIn };
        var sut = new GildedRose(new List<Item> { item });

        // Act.
        sut.UpdateQuality();

        // Assert.
        item.Quality.Should().Be(expectedQuality);
        item.SellIn.Should().Be(expectedSellIn);
    }
}