using System.Collections.Generic;

/// <summary>
/// Named arguments for clear initialization code
/// </summary>
class Listing1_4
{
    readonly string name;
    public string Name { get { return name; } }

    readonly decimal price;
    public decimal Price { get { return price; } }

    public Listing1_4(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public static List<Listing1_4> GetSampleProducts()
    {
        return new List<Listing1_4>
        {
            new Listing1_4( name: "West Side Story", price: 9.99m ),
            new Listing1_4( name: "Assassins", price: 14.99m ),
            new Listing1_4( name: "Frogs", price: 13.99m ),
            new Listing1_4( name: "Sweeney Todd", price: 10.99m )
        };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", Name, Price);
    }
}
