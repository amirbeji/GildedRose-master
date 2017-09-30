using System.Collections.Generic;
using Xunit;


namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void CaseAgedBrie()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 30; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[1].Quality,28);
            Assert.Equal(pr.Items[1].SellIn, -28);
        }

        [Fact]
        public void CaseAgedBrieLimit()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 200; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[1].Quality, 50);
            Assert.Equal(pr.Items[1].SellIn, -198);
        }

        [Fact]
        public void SulfurasAgedBrie()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 30; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[3].Quality, 50);
            Assert.Equal(pr.Items[3].SellIn, 0);
        }

        [Fact]
        public void BackstagePassesAgedBrie()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 12; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[4].Quality, 41);
            Assert.Equal(pr.Items[4].SellIn, 3);
        }


        [Fact]
        public void BackstagePassesAgedBrieZero()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 20; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[4].Quality, 0);
            Assert.Equal(pr.Items[4].SellIn,-5 );
        }




        [Fact]
        public void BackstagePassesAgedBrie1()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 3; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[4].Quality,23);
            Assert.Equal(pr.Items[4].SellIn, 12);
        }
        [Fact]
        public void BackstagePassesAgedBrie2()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 8; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[4].Quality, 31);
            Assert.Equal(pr.Items[4].SellIn, 7);
        }

        [Fact]
        public void OrdinaryItems()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 2; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[5].Quality, 4);
            Assert.Equal(pr.Items[5].SellIn, 1);
        }

        [Fact]
        public void OrdinaryItemsNegatif()
        {
            Console.Program pr = new Console.Program();
            pr.Items = new List<Console.Program.Item>
                                          {
                                              new Console.Program.Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Console.Program.Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Console.Program.Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Console.Program.Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Console.Program.Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Console.Program.Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            Console.Program.UpdateStrategyFactory _updateStrategyFactory = new Console.Program.UpdateStrategyFactory();
            for (int i = 0; i < 10; i++)
            {
                pr.UpdateAllsQuality(_updateStrategyFactory);
            }
            Assert.Equal(pr.Items[5].Quality, 0);
            Assert.Equal(pr.Items[5].SellIn, -7);
        }
    }

   
}