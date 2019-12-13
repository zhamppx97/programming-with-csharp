using System;
using System.Collections;
using System.Collections.Generic;

namespace programming_with_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
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

            
            
            
            Console.ReadLine();
        }
    }
}
