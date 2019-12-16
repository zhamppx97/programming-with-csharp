using System;
using System.Collections;
using System.Collections.Generic;

namespace programming_with_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listing 1-1 to 1-4
            #region Starting with a simple data type
            // Listing 1-1 The Product Type
            ArrayList list1_1Product = Listing1_1.GetSampleProducts();
            Console.WriteLine("Listing 1-1 The Product Type");
            foreach (var item in list1_1Product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Listing 1-2 Strongly typed collection and private setters
            List<Listing1_2> list1_2Product = Listing1_2.GetSampleProducts();
            Console.WriteLine("Listing 1-2 Strongly typed collection and private setters");
            foreach (var item in list1_2Product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Listing 1-3 Automationcally implemented properties and simpler initialization
            List<Listing1_3> list1_3Product = Listing1_3.GetSampleProducts();
            Console.WriteLine("Listing 1-3 Automationcally implemented properties and simpler initialization");
            foreach (var item in list1_3Product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Listing 1-4 Named arguments for clear initialization code
            List<Listing1_4> list1_4Product = Listing1_4.GetSampleProducts();
            Console.WriteLine("Listing 1-4 Named arguments for clear initialization code");
            foreach (var item in list1_4Product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            // Listing 1-5
            #region Sorting and filtering
            // Listing 1-5 Sorting an ArrayList using IComparer (Listing 1-1)
            ArrayList products1_1 = Listing1_1.GetSampleProducts();
            products1_1.Sort(new ProductNameComparer1_5());
            Console.WriteLine("Listing 1-5 Sorting an ArrayList using IComparer (Listing 1-1)");
            foreach (var item in products1_1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Listing 1-6 Sorting a List<Product> using IComparer<Product> (Listing 1-2)
            List<Listing1_2> products1_2 = Listing1_2.GetSampleProducts();
            products1_2.Sort(new ProductNameComparer1_6());
            Console.WriteLine("Listing 1-6 Sorting a List<Product> using IComparer<Product> (Listing 1-2)");
            foreach (var item in products1_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            Console.ReadLine();
        }
    }
}
