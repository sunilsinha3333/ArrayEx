using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx
{
    class array_example
    {

        public void array_population()
        {

            int[] arr = new int[] {34,35,456,678,12,43 };
            /*
            int i;
                  
            for(i=0; i<=5; i++)
            {
                Console.WriteLine("value in array arr at position {0} is {1}", i, arr[i]);

            }
           */

            foreach (int i in arr)
            {

                Console.WriteLine(i);
            }
            // example of string array

            string[] names = new string[] { "sunil", "sunil-1", "sunil-2","sunil-3","sunil-4" };
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

        }

        static void Main(String[] args)
        {
            array_example arr_ex = new array_example();
            arr_ex.array_population();
        }
    }



}