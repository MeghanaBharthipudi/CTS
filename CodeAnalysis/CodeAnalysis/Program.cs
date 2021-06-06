using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Boby", "Charig", "John","Denis","Alfee","Bond" };

            var NamesOfB = names.Where(x => x.StartsWith("B"));

            //-----------Task 2
            Console.WriteLine("Enter a N value to print");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            while(i<n)
            {
                Console.WriteLine(i);
                i++;
            }
            //-----------Task 3
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
            }
        }
    }
}
