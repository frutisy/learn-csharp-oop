using System;
using AlphabetNamespace;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тестирование классов: Alphabet и EngAlphabet";


            EngAlphabet engAlphabet = new EngAlphabet(); // 1) Создание объекта класса EngAlphabet.

            Console.Write("Буквы английского алфавита: ");
            engAlphabet.Print(); // 2) Печать букв английского алфавита.

            Console.WriteLine($"Количество букв английского алфавита: {engAlphabet.LettersNum()}"); // 3) Вывод количества букв английского алфавита.

            Console.WriteLine($"Буква 'F' относится к английскому алфавиту? - {engAlphabet.IsEngLetter('F')}"); // 4) Проверка относится ли буква 'F' к английскому алфавиту.
            Console.WriteLine($"Буква 'Щ' относится к английскому алфавиту? - {engAlphabet.IsEngLetter('Щ')}"); // 5) Проверка относится ли буква 'Щ' к английскому алфавиту.

            Console.Write("Пример текста на английском языке: ");
            EngAlphabet.Example(); // 6) Вывод примера текста на английском языке.


            Console.WriteLine();

        }
    }
}
