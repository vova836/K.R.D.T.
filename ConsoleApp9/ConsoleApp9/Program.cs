using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiDispatcher dispatcher = new TaxiDispatcher();
            TaxiDriver driver = new TaxiDriver();
            dispatcher.ProcessTaxiOrder();
            driver.ProcessDriveTaxi();
            Console.ReadKey();
        }
    }
}
