﻿using System;
using System.Collections;

namespace ConsoleApp1
{

    public class Program
    {
        private static Dumpster _dumpster;

        public static void Main(string[] args)
        {
            _dumpster = new Dumpster();
            _dumpster.Dispose(new Bottle(), new Bottle(), new Food(), new Trash());
        }


    }
}
