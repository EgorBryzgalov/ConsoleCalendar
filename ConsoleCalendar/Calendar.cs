using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleCalendar
{
    class Calendar
    {
        private int Day { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }
        
        public void GetInput(string input)
        {
            Console.WriteLine("Введите инетерсующую Вас дату в формате: ДД ММ ГГГГ:");
            input = Console.ReadLine();
            string pattern = @"\d*\s\d*\s[0-9]{4}";
            if (Regex.IsMatch(input, pattern)) Console.WriteLine("работает");
            else Console.WriteLine("Не работает");
        }
    
    }
}
