﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiDispatcher dispatcher = new TaxiDispatcher();
            dispatcher.ProcessTaxiOrder();
            TaxiDriver driver = new TaxiDriver();
            driver.ProcessDriveTaxi();
            Console.ReadKey();
        }
    }
}
