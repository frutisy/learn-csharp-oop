using System;
using RealEstateAgency.Houses;
using RealEstateAgency.People;

namespace RealEstateAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тестирование классов: Human, House и SmallHouse";


            Human.DefaultInfo(); // 1) Вызов справочного метода default_info() для класса Human.

            Console.WriteLine();

            Human human = new Human("Евгений", 22); // 2) Создание объекта класса Human. 
            human.Info(); // 3) Вывод справочной информации о созданном объекте.

            Console.WriteLine();

            SmallHouse smallHouse = new SmallHouse(500000.0); // 4) Создание объекта класса SmallHouse.
            human.BuyHouse(smallHouse, 0); // 5) Попытка купить созданный дом.

            Console.WriteLine();

            human.EarnMoney(750000.0); // 6) Улучшаем финансовое состояние.
            human.BuyHouse(smallHouse, 0); // 7) Снова пробуем купить дом.
            human.Info(); // 8) Смотрим, как изменилось состояние объекта класса Human.


            Console.WriteLine();
        }
    }
}
