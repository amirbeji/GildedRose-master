using System.Collections.Generic;

namespace GildedRose.Console
{
  public  class Program
    {
    public    IList<Item> Items;
       static  void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
            {
                Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

            };
            UpdateStrategyFactory _updateStrategyFactory = new UpdateStrategyFactory();
            app.UpdateAllsQuality(_updateStrategyFactory);
            System.Console.ReadKey();



        }

        public  class Item
    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        private int p_quality;

        public int Quality
        {
            get
            {
                return p_quality;
            }

            set
            {
                //La qualité d'un article n'est jamais négative
                //La qualité d'un article n'est jamais supérieure à 50           
                if (value > 50)
                    p_quality = 50;
                else if (value <= 50 && value >= 0)
                    p_quality = value;
                else
                    p_quality = 0;
            }
        }
        

       

    }

    






public interface IUpdateStrategyFactory
{
    IUpdateStrategy Create(string name);


}

public interface IUpdateStrategy
{
    void UpdateQuality(Item item);
}

public class UpdateStrategyFactory : IUpdateStrategyFactory
{
    public IUpdateStrategy Create(string name)
    {
        if (name == "Sulfuras, Hand of Ragnaros")
        {
            return new SulfurasUpdateStrategy();
        }
        else if (name == "Aged Brie")
        {
            return new AgedBrieUpdateStrategy();
        }
        else if (name == "Backstage passes to a TAFKAL80ETC concert")
        {
            return new BackstagePassesOrdinaryUpdateStrategy();
        }
        
        else
        {
            return new OrdinaryUpdateStrategy();
        }
    }

   
}

public class SulfurasUpdateStrategy : IUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
       
    }
}
public class AgedBrieUpdateStrategy : IUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        if (item.SellIn <= 0)
            item.Quality = item.Quality + 1;


                item.SellIn--;
    }
}
public class BackstagePassesOrdinaryUpdateStrategy : IUpdateStrategy
{
    public void UpdateQuality(Item item)
    {

        if (item.SellIn > 10)
            item.Quality = item.Quality + 1;
        else if (item.SellIn <= 10 && item.SellIn > 5)
            item.Quality = item.Quality + 2;
        else if (item.SellIn <= 5 && item.SellIn > 0)
            item.Quality = item.Quality + 3;
        else
            item.Quality = 0;


        item.SellIn--;
    }
}

public class OrdinaryUpdateStrategy : IUpdateStrategy
{
    public void UpdateQuality(Item item)
    {
        if (item.SellIn > 0)
            item.Quality = item.Quality - 1;
        else
            item.Quality = item.Quality - 2;

        item.SellIn--;
    }
}

public void UpdateAllsQuality(UpdateStrategyFactory _updateStrategyFactory)
{
    foreach (Item item in Items)
    {
        var updateStrategy = _updateStrategyFactory.Create(item.Name);
        updateStrategy.UpdateQuality(item);
    }
        }
    }
}

