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
        private DateTime RequestDate { get; set; }
        
        public void GetInput()
        {
            Console.WriteLine("Введите интерсующую Вас дату в формате: ДД ММ ГГГГ:");
            string input = Console.ReadLine();

            // предварительная проверка правильности введенных данных (наличие 3 чисел, отделенных пробелами)
            string pattern = @"\d*\s\d*\s[0-9]{4}";
            if (Regex.IsMatch(input, pattern))
            {
                input = input.Trim(' ');
                string[] SplittedDateString = input.Split(' ');
                int day = Int32.Parse(SplittedDateString[0]);
                int month = Int32.Parse(SplittedDateString[1]);
                int year = Int32.Parse(SplittedDateString[2]);
                try
                {
                    RequestDate = new DateTime(year, month, day);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Указанной даты не существует, проверьте корректность введенных данных (ДД ММ ГГГГ).");
                    GetInput();
                    return;
                }
                Console.WriteLine(RequestDate);

            }
            else
            {
                Console.WriteLine("Данные введены некорректно. Программа принимает только дату в формате: ДД ММ ГГГГ!");
                GetInput();
                return;
            }
                
        }
    
    }
}
