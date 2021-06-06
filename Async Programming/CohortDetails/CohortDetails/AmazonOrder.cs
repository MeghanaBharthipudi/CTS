using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohortDetails
{
    class AmazonOrder
    {
        public static void OrderDetails(string Seller_name, string Product_name,int Orderquantity=1,bool Isreturnable=true)
        {
            Console.WriteLine("Here is the order detail –" +
                " {0} number of {1} by {2} is ordered. It’s returnable status is {3}",Orderquantity, Product_name,Seller_name,Isreturnable);
        }
        public void Main(string[] args)
        {
            string Seller_name = Console.ReadLine();
            string Product_name = Console.ReadLine();
            OrderDetails(Seller_name, Product_name);
            Console.ReadLine();

           // Orderquantity – Optional with default value 1
           //Is returnable – Optional with default value TRUE
        }
    }
}
