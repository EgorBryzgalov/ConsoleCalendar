﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();
            calendar.Activate();
            Console.ReadKey();
        }
    }
}
