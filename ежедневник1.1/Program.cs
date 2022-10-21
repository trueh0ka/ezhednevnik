using System;
using System.Data.SqlTypes;
namespace ежедневник1._1
{
    public class Program
    {

        static DateTime data1 = DateTime.Today;
        static void Main(string[] args)
        {
            Console.Write("Сегодня:");
            Console.WriteLine(data1);
            DayInfo day1 = new DayInfo();
            day1.Day = 21;
            day1.Month = 10;
            day1.Zametka = "Пойти похавать в 5.23";
            day1.Opisanie = "Не ну это надо)";
            DayInfo.DaysInfo.Add(day1);
            DayInfo day2 = new DayInfo();
            day2.Day = 23;
            day2.Month = 10;
            day2.Zametka = "Поиграть в кс";
            day2.Opisanie = "Месяц не играл, чёт не то";
            DayInfo.DaysInfo.Add(day2);
            DayInfo day3 = new DayInfo();
            day3.Day = 16;
            day3.Month = 10;
            day3.Zametka = "Поменять постельное белье";
            day3.Opisanie = "Чет лень";
            DayInfo.DaysInfo.Add(day3);
            DayInfo day4 = new DayInfo();
            day4.Day = 7;
            day4.Month = 10;
            day4.Zametka = "Завтра в шарагу в 6 вставать";
            day4.Opisanie = "А оно надо?";
            DayInfo.DaysInfo.Add(day4);
            DayInfo day5 = new DayInfo();
            day5.Day = 26;
            day5.Month = 10;
            day5.Zametka = "Сделать практическую по философии";
            day5.Opisanie = "Надо сегодня сдать, а я ни че не монимаю что там написано";
            DayInfo.DaysInfo.Add(day5);
            while(true)
            {
                Days();
              
            }
        }
        static int[] Days()
        {
      
                ConsoleKeyInfo clavisha = Console.ReadKey();
            Strelki();
            
            return Days();
        }
       static int[] Strelki()
        {
            Console.SetCursorPosition(0, 1);
            int position = 1;
            ConsoleKeyInfo clavisha = Console.ReadKey();
            if (clavisha.Key == ConsoleKey.Enter)
            {
                Desr();
            }
            while (clavisha.Key != ConsoleKey.Enter)
            {
               
                if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    if (position>1)
                    {
                    position--;
                    }

                }
                if (clavisha.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    Console.Write("Выбрана дата:");
                    Console.WriteLine(data1.AddDays(1));
                    data1 = data1.AddDays(1);

                }
                else if (clavisha.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    Console.Write("Выбрана дата:");
                    Console.WriteLine(data1.AddDays(-1));
                    data1 = data1.AddDays(-1);

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Вы выбрали: "+data1);
                Zametki();
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                clavisha = Console.ReadKey();

            }
            return Strelki();
        }

        private static void Desr()
        {
            Console.Clear();
            foreach (var i in DayInfo.DaysInfo)
            {

                if (i.Day == data1.Day)
                {
                    Console.Write($" {i.Zametka}: ");
                    Console.WriteLine(i.Opisanie);
                }
            }
        }

        private static void Zametki()
        {
            
            int indexer = 1;
            foreach (var i in DayInfo.DaysInfo)
            {
              
                if (i.Day == data1.Day)
                {
                    Console.Write($"    {indexer}. {i.Zametka}");
                }    
            }
        }
    }
}