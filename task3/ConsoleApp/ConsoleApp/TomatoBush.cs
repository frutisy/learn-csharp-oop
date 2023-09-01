using System;

namespace Vegetables
{
    class TomatoBush
    {
        // Fields.
        private Tomato[] _tomatoes;

        // Constructors.
        public TomatoBush(int numberOfTomatoes)
        {
            if (numberOfTomatoes <= 0)
            {
                throw new ArgumentException("Количество томатов на ветке должно быть больше нуля!");
            }

            _tomatoes = new Tomato[numberOfTomatoes];
            for (int i = 0; i < _tomatoes.Length; i++)
                _tomatoes[i] = new Tomato();
        }

        // Methods.
        public void GrowAll()
        {
            foreach (var tomato in _tomatoes)
                tomato.Grow();
        }

        public bool AllAreRipe()
        {
            foreach (var tomato in _tomatoes)
            {
                if (!tomato.IsRipe())
                {
                    return false;
                }
            }
            return true;
        }

        public void GiveAwayAll()
        {
            Array.Clear(_tomatoes, 0, _tomatoes.Length);
        }
    }
}
