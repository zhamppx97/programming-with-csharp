using System.Collections.Generic;

/// <summary>
/// Sorting a List<Product> using IComparer<Product>
/// </summary>
class ProductNameComparer1_6 : IComparer<Listing1_2>
{
    public int Compare(Listing1_2 x, Listing1_2 y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
