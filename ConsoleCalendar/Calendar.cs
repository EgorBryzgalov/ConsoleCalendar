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
        private DateTime Date { get; set; }
        
        private void GetInput()
        {
            Console.WriteLine("Введите интерсующую Вас дату в формате: ДД ММ ГГГГ:");
            string input = Console.ReadLine();
            input = input.Trim(' ');
            // предварительная проверка правильности введенных данных (наличие 3 чисел, отделенных пробелами)
            string pattern = @"\d{1,2} \d{1,2} [0-9]{4}";
            if (Regex.IsMatch(input, pattern))
            {
                
                string[] SplittedDateString = input.Split(' ');
                int day = Int32.Parse(SplittedDateString[0]);
                int month = Int32.Parse(SplittedDateString[1]);
                int year = Int32.Parse(SplittedDateString[2]);
                try
                {
                    Date = new DateTime(year, month, day);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Указанной даты не существует, проверьте корректность введенных данных (ДД ММ ГГГГ).");
                    GetInput();
                    return;
                }
                
            }
            else
            {
                Console.WriteLine("Данные введены некорректно. Программа принимает только дату в формате: ДД ММ ГГГГ!");
                GetInput();
                return;
            }

            if (Date.Year>2400||Date.Year<1600)
            {
                Console.WriteLine("Принимаются даты с 1600 года по 2400.");
                GetInput();
                return;
            }
                
        }
    
        private string[] GetOutput()
        {
            string[] output = new string[7];
            int DaysInMonth = DateTime.DaysInMonth(Date.Year, Date.Month);
            DateTime FirstDayOfMonth = new DateTime(Date.Year, Date.Month, 1);
            int m = (int)FirstDayOfMonth.DayOfWeek;
            int n = 1;
            int i = 1;
            while (i<= DaysInMonth)
            {
                if (n == m)
                {
                    output[n] += "   " + i;
                    if (n!=6)
                    {
                        n++;
                        m = n;
                    }
                    else
                    {
                        n = 0;
                        m = n;
                    }
                    i++;

                }
                else
                {
                    output[n] += "    ";
                    if (n != 6)
                        n++;
                    else
                        n = 0;
                   
                }
            }
            int day = Date.Day;
            int index = (int)Date.DayOfWeek;
            string OldString = " " + day.ToString() + " ";
            string NewString = "[" + day.ToString() + "]";
            output[index] = output[index].Replace(OldString, NewString);
            return output;
        }

        private void Print(string[] output)
        {
            Console.WriteLine("mon" + output[1]);
            Console.WriteLine("tue" + output[2]);
            Console.WriteLine("wed" + output[3]);
            Console.WriteLine("thu" + output[4]);
            Console.WriteLine("fri" + output[5]);
            Console.WriteLine("sat" + output[6]);
            Console.WriteLine("sun" + output[0]);
        }

        public void Activate()
        {
            GetInput();
            Print(GetOutput());
        }
    }
}
