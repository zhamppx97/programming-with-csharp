using System.Collections;

/// <summary>
/// Sorting an ArrayList using IComparer (Listing 1-1)
/// </summary>
class ProductNameComparer1_5 : IComparer
{
    public int Compare(object x, object y)
    {
        Listing1_1 first = (Listing1_1)x;
        Listing1_1 second = (Listing1_1)y;
        return first.Name.CompareTo(second.Name);
    }
}
