using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiDispatcher dispatcher = new TaxiDispatcher();
            dispatcher.ProcessTaxiOrder();
            Console.ReadKey();
        }
    }
}
