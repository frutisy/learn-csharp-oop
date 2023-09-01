using System;
using System.Linq;

namespace AlphabetNamespace
{
    class Alphabet
    {
        // Fields.
        protected string language;
        protected char[] letters;

        // Constructors.
        public Alphabet(string language, char[] letters) 
        { 
            this.language = language;
            this.letters = letters.ToArray();
        }

        // Methods.
        public virtual int LettersNum()
        {
            return letters.Length;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", letters));
        }
    }

    class EngAlphabet : Alphabet
    {
        // Fields.
        private static int _letters_num;
        private static string _englishLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // Constructors.
        public EngAlphabet() : base("Eng", _englishLetters.ToArray())
        {
            letters = _englishLetters.ToArray();
        }

        // Methods.
        public override int LettersNum() 
        {
            return letters.Length;
        }

        public static void Example()
        {
            Console.WriteLine("Enjoy every moment.");
        }

        public bool IsEngLetter(char letter)
        {
            return letters.Contains(letter);
        }
    }
}
