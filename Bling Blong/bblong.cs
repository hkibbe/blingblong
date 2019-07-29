using System;
using System.Collections.Generic;
using System.Linq;

namespace BlingBlong
{
    class Program
    {
        public static void BlingBlong(int i)
        {
            if ( i % 3 == 0)
            {
                Console.WriteLine("Bling");
            }
            if ( i % 5 == 0)
            {
                Console.WriteLine("Blong");
            }
            if ( i % 3 == 0 && i % 5 == 0 )
            {
                Console.WriteLine("BlingBlong");
            }
            else 
            {
                Console.WriteLine(i);
            }
        }
    }
}
