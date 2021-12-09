using System;

namespace enum_example
{
    class Program
{
        enum WeekDays
        {
            Monday, Tuesday, Wednesday,
            Thursday, Friday, Saturday, Sunday
        };

    static void Main(string[] args)
    {
            // Массив с название дней недели на русском
            string[] WeekdayRussianName =
                {
                "Понедельник", "Вторник", "Среда",
                "Четверг", "Пятница", "Суббота", "Воскресенье"
            };

            WeekDays day = WeekDays.Thursday;

            // Вывод дня недели в разных форматах

            Console.WriteLine("Сегодня " + day);
            Console.WriteLine("Сегодня " + WeekdayRussianName[(int) day] );
            int dayIndex = (int)day + 1;
            Console.WriteLine("Номер дня " + dayIndex);

            // Вот так делается проверка сравнением
            if (day == WeekDays.Thursday)
                Console.WriteLine("Сегодня четверг");
            Console.ReadLine();

        }
    }
}
