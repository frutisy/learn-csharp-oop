using System;

namespace RealEstateAgency.Houses
{
    class House
    {
        // Fields.
        protected double _area;
        protected double _price;

        // Constructors.
        public House(double area, double price) 
        { 
            _area = area;
            _price = price;
        }

        // Properties.
        public double Area { get { return _area; } }
        public double Price { get { return _price; } }

        // Methods.
        public double FinalPrice(double discount)
        {
            if (discount < 0 || discount > 100)
                throw new ArgumentException("Скидка должна быть между 0 и 100!");

            return Math.Round((_price - (_price * discount / 100)), 2);  
        }
    }

    class SmallHouse : House
    {
        // Constuctors.
        public SmallHouse(double price) : base(40.0, price) { }
    }
}
