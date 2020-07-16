using System;

namespace CrateCalculator
{
	public class Crate
	{
		const decimal COST_PER_CUBIC_FOOT = 0.23M;
		const decimal CHARGE_PER_CUBIC_FOOT = 0.5M;

		// A crate has a Length, Width, and Height
		// you are not allowed to add additional properties
		// here (don't add volume, cost, charge or profit).

		public decimal Length { get; set; }
		public decimal Width { get; set; }
		public decimal Height { get; set; }

		public Crate() { }   // Don't change me.  If you're adding a new
							 // constructor, leave this default constructor 
							 // alone.

		public Crate(decimal Length, decimal Width, decimal Height)
        {
			this.Length = Length;
			this.Width = Width;
			this.Height = Height;
        }

		public void input_data()
		{
			Console.WriteLine("---------------------");
			Console.WriteLine("CBI Crate builder Inc");
			Console.WriteLine("---------------------");

			this.Width = 0;
			this.Length = 0;
			this.Height = 0;

			Console.WriteLine("Please enter all dimensions in feet.");
			Console.Write("Enter width:");
			this.Width = decimal.Parse(Console.ReadLine());

			Console.Write("Enter length:");
			this.Length = decimal.Parse(Console.ReadLine());

			Console.Write("Enter height:");
			this.Height = decimal.Parse(Console.ReadLine());


		}


		public decimal getVolume()
		{
			return this.Height * this.Width * this.Length;
		}

		public decimal getCharge()
		{
			return this.getVolume() * Crate.CHARGE_PER_CUBIC_FOOT;
		}

		public decimal getCost()
		{
			return this.getVolume() * Crate.COST_PER_CUBIC_FOOT;
		}

		public decimal getProfit()
		{
			return this.getCharge() - this.getCost();
		}

		public void display_output()
		{
			decimal volume = 0;
			decimal cost = 0, charge = 0, profit = 0;
			volume = getVolume();
			cost = getCost();
			charge = getCharge();
			profit = getProfit();

			Console.WriteLine("---------------------");
			Console.WriteLine("CBI Crate builder Inc");
			Console.WriteLine("---------------------");
			Console.WriteLine("Crate purchase");
			Console.Write("Crate dimensions in feet:");
			Console.Write($"width = {Width}");
			Console.Write($", length = {Length}");
			Console.WriteLine($", height = {Height}");
			Console.WriteLine($"Crate volume: {volume:0.00} cubic ft");

			Console.WriteLine($"Customer charged {charge:0.00}");
			Console.WriteLine($"Material cost {cost:0.00}");
			Console.WriteLine($"Profit earned {profit:0.00}");

			Console.WriteLine("---------------------");
		}





	};
	class Program
	{
		static void Main(string[] args)
		{
			// part 1
			//
			// Fix the Crate class so that the input, calculations,
			// and output work in the way shown in the assignment
			// document.

			Crate c1 = new Crate();
			c1.input_data();
			c1.display_output();

			// part 2 
			//
			// Uncomment the code below and
			// make sure this code works.  
			//
			// If part 1 is done, it should fine
			// without further change.
			// 
			 Crate c = new Crate();
			 c.Height = 1;
			 c.Width = 2;
			 c.Length = 3;
			 
			 decimal v1 = c.getVolume();
			 decimal p1 = c.getProfit();
			 Console.WriteLine($"Crate volume = {v1} profit = {p1}");

			// part 3 
			//
			// Uncomment this code and change the Crate
			// class to make it work.  You'll have
			// to add a parameterized constructor to 
			// the Crate class.
			// 
			 Crate c2 = new Crate(1,2,3);
			 
			 decimal v2 = c.getVolume();
			 decimal p2 = c.getProfit();
			 Console.WriteLine($"Crate volume = {v2} profit = {p2}");


			Console.WriteLine("(Done - press enter)");
			Console.ReadLine();

		}
	}
}
