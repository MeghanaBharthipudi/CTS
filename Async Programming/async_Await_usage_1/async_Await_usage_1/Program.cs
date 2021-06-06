using System;
using System.Threading;
using System.Threading.Tasks;

namespace async_Await_usage_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is main method\n");
            Method1();
            Console.ReadLine();
        }
        public static async  void Method1()
        {
            Task<string> task = Method2();
            string str = await task;
            Console.WriteLine("The string is " + str);

        }
        public static async Task<string> Method2()
        {
            string str = "Wellcome to async Programming";
            await Task.Run(() =>
            {
                    Console.WriteLine("This is Method 2");
                Thread.Sleep(2000);

            });
            
            return str;
        }
    }
}
