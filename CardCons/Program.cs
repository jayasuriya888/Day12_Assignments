﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CardLibrary;
namespace CardCons
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Card));
            host.Open();
            Console.WriteLine("server stated");
            Console.WriteLine("press key to continue");
            Console.ReadLine();
        }
    }
}
