using System;
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
            Calendar cal = new Calendar();
            cal.GetInput();
            cal.Print(cal.GetOutput());
            Console.ReadKey();
        }
    }
}
