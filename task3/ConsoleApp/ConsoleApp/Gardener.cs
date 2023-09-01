using System;
using Vegetables;

namespace People
{
    class Gardener
    {
        // Fields.
        public string Name { get; }

        protected TomatoBush plant;


        // Constructors.
        public Gardener(string name, TomatoBush plant) 
        {
            Name = name;
            this.plant = plant;
        }

        // Methods.
        public static void KnowledgeBase()
        {
            Console.WriteLine("Справка по садоводству:");
            Console.WriteLine("1. Посадите семена помидоров.");
            Console.WriteLine("2. Регулярно поливайте и удобряйте растения.");
            Console.WriteLine("3. Следите за ростом и созреванием помидоров.");
            Console.WriteLine("4. Соберите спелые помидоры.");
        }

        public void Work()
        {
            plant.GrowAll();
        }

        public void Harvest()
        {
            if (plant.AllAreRipe())
            {
                plant.GiveAwayAll();
                Console.WriteLine($"{Name} собрал все помидоры!");
            }
            else
            {
                Console.WriteLine($"{Name} не может собрать урожай. Некоторые помидоры еще не созрели.");
            }
        }
    }
}
