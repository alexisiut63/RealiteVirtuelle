﻿using Microsoft.Kinect;
using Rokinect.metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualRocky
{
    class Program
    {
        static void Main(string[] args)
        {
            Start s = new Start();
            s.ajouterGesture();
            s.start();
            
            Console.ReadKey();
            Console.Clear();
        }

    }
}
