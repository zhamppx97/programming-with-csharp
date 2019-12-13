using System.Collections.Generic;

/// <summary>
/// Strongly typed collection and private setters
/// </summary>
public class Listing1_2
{
    string name;
    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    decimal price;
    public decimal Price
    {
        get { return price; }
        private set { price = value; }
    }

    public Listing1_2(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public static List<Listing1_2> GetSampleProducts()
    {
        List<Listing1_2> list = new List<Listing1_2>
        {
            new Listing1_2("West Side Story", 9.99m),
            new Listing1_2("Assassins", 14.99m),
            new Listing1_2("Frogs", 13.99m),
            new Listing1_2("Sweeney Todd", 10.99m)
        };
        return list;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}
