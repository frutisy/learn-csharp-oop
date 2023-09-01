using System;
using RealEstateAgency.Houses;

namespace RealEstateAgency.People
{
	class Human
	{
		// Constant fields.
		public const string _DEFAULT_NAME="Владимир";
		public const int _DEFAULT_AGE = 18;

		// Fields.
		private string _name;
		private int _age;
		private double _money;
		private House _house;

		// Constructors.
		public Human(string name=null, int age=-1) 
		{
            Name = name ?? _DEFAULT_NAME;
            Age = age >= 0 ? age : _DEFAULT_AGE;
            Money = 0;
            House = null;
        }

		// Properties.
		public string Name 
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age
		{
			get { return _age; }
			set 
			{
				if (value < 0)
					throw new ArgumentException("Возраст не может быть негативным!");
				_age = value;
			}
		}

		public double Money
		{
			get { return _money; }
			set 
			{
				if (value < 0)
					throw new ArgumentException("Количество денег не должно быть негативным!");
				_money = value;
			}
		}

		public House House
		{
			get { return _house; }
			set { _house = value; }
		}

		// Methods.
		public static void DefaultInfo()
		{
            Console.WriteLine($"Имя по умолчанию: {_DEFAULT_NAME}");
            Console.WriteLine($"Возраст по умолчанию: {_DEFAULT_AGE}");
        }

		public void Info()
		{
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Возраст: {_age}");
            Console.WriteLine($"Дом: {(_house?.GetType().Name ?? "отсутствует")}");
            Console.WriteLine($"Деньги: {_money}");
        }

		public void EarnMoney(double money)
		{
			_money += money;
		}

		public void BuyHouse(House house, double discount)
		{
			double finalHousePrice = house.FinalPrice(discount);

			if (_money < finalHousePrice)
                Console.WriteLine("У вас недостаточно денег для покупки данного дома!");
			else
				MakeDeal(house, finalHousePrice);
        }

		private void MakeDeal(House house, double price)
		{
			_house = house;
			_money -= price;
		}
	}
}
