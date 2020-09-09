using System;

namespace cs354_project_2
{
	public class Item
	{
		public String Name { get; set; }
		public int quantity { get; set; }
		public double price { get; set; }

		/*
		 * constructor
		 */
		public Item(String item, int quantity, double price)
		{

			this.price = price;
			this.quantity = quantity;
			this.Name = item;

		}

		/*
		 * 
		 */
		public double salesTax(double price, int quantity)
		{
			return (price * quantity) * 0.10;
		}
		/*
		 * 
		 */
		public double totalCost(int quantity, double price)
		{

			return (price * quantity) * 1.10;
		}

		public override string ToString()
		{
			return String.Format("The item is: " + Name +". "+ "The quantity is: " + quantity + ". " + "The unit price is:" + price + " dollars.");
		}

	}

}