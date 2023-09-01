using System;

namespace Vegetables
{
    class Tomato
    {
        // Fields.
        public static string[] states = { "Отсутствует", "Цветение", "Зелёный", "Красный" };

        protected int state;

        // Constructors.
        public Tomato() 
        { 
            this.state = 0;
        }

        // Methods.
        public void Grow()
        {
            if (state < states.Length - 1)
            {
                state++;
            }
        }

        public bool IsRipe()
        {
            if (state == states.Length - 1)
                return true;
            return false;
        }
    }
}
