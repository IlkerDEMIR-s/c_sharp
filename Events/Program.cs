using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products harddisk = new Products(40);
            harddisk.ProductName = "Laptop";

            Products gsm = new Products(40);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;          

            for(int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();              
            }       

            Console.ReadLine();

        }

        private static void Gsm_StockControlEvent()
        {
            //throw new NotImplementedException();
            Console.WriteLine("GSM about to finish!!!");
        }
    }
}
