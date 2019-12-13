using System.Collections.Generic;

/// <summary>
/// Automationcally implemented properties and simpler initialization
/// </summary>
namespace programming_with_csharp
{
    class Listing1_3
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Listing1_3(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        Listing1_3() { }

        public static List<Listing1_3> GetSampleProducts()
        {
            return new List<Listing1_3>
            {
                new Listing1_3{ Name = "West Side Story", Price = 9.99m },
                new Listing1_3{ Name = "Assassins", Price = 14.99m },
                new Listing1_3{ Name = "Frogs", Price = 13.99m },
                new Listing1_3{ Name = "Sweeney Todd", Price = 10.99m }
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
