﻿using CarLibrary;
using System;

namespace SharedCarLibClient
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***** Shared Assembly Client *****");
            SportsCar c = new SportsCar();
            c.TurboBoost();
            Console.ReadLine();
        }
    }
}
