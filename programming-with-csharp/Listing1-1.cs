using System.Collections;

/// <summary>
/// The product type
/// </summary>
public class Listing1_1
{
    string name;
    public string Name { get { return name; } }

    decimal price;
    public decimal Price { get { return price; } }

    public Listing1_1(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public static ArrayList GetSampleProducts()
    {
        ArrayList list = new ArrayList
        {
            new Listing1_1("West Side Story", 9.99m),
            new Listing1_1("Assassins", 14.99m),
            new Listing1_1("Frogs", 13.99m),
            new Listing1_1("Sweeney Todd", 10.99m)
        };
        return list;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}
