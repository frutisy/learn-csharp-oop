using System;
using Vegetables;
using People;

namespace Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тестирование классов: Tomato, TomatoBush и Gardener";


            Gardener.KnowledgeBase(); // 1) Вызов справки по садовоству.

            Console.WriteLine();

            TomatoBush tomatoBush = new TomatoBush(5); // 2) Создание объекта класса TomatoBush.
            Gardener gardener = new Gardener("Владимир", tomatoBush); // 2) Создание объекта класса gardener.

            gardener.Work(); // 3) Ухаживаем за кустом с помидорами.
            gardener.Harvest(); // 4) Попытка собрать урожай.

            Console.WriteLine();

            gardener.Work(); // 5) Продолжаем ухаживать за кустом.
            gardener.Work(); // 5) Продолжаем ухаживать за кустом.
            gardener.Harvest(); // 6) Собираем урожай.


            Console.WriteLine();
        }
    }
}
