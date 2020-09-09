using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs354_project_2
{
	public partial class Form1 : Form
	{
		private double totalCost = 0;
		private double salesTax = 0;
		private int totalQuantity = 0;


		public Form1()
		{
			InitializeComponent();
			textBox3.Text = "The item name  , The price,  The quantity";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		//save button
		private void button1_Click(object sender, EventArgs e)
		{
			//create Item
			Item item = new Item(textBox1.Text,(int)numericUpDown1.Value, double.Parse(textBox2.Text));
			//calcualte total cost
			totalCost += item.totalCost(item.quantity, item.price);
			totalCost = Math.Round(totalCost, 2);
			//calculate salesTax
			salesTax += item.salesTax(item.price, item.quantity);
			salesTax = Math.Round(salesTax, 2);

			// Total quantity (need work)
			int i =+ item.quantity;
			totalQuantity = i;

			//add item to list
			listBox1.BeginUpdate();
			//use for loop to add
			for (int x =1; x<= i; x++) {
				listBox1.Items.Add(item);
			}
			listBox1.EndUpdate();

			//adding totals and display in listbox2
			listBox2.BeginUpdate();
			listBox2.Items.Add("The total quantity is: "+ totalQuantity);
			listBox2.Items.Add("The total cost is: " + totalCost);
			listBox2.Items.Add("The sales tax is: " + salesTax);
			listBox2.EndUpdate();


			MessageBox.Show("The data entered is saved");
		}

		/*
		 * enter the name of purchased item
		 * 
		 */
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			String itemName = textBox1.Text;


		}

		//button2 is a clear button
		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear(); // clear list
			textBox1.Clear(); // clear name box
			textBox2.Clear(); //clear price box
			numericUpDown1.ResetText(); //clear quantity numericupdown
		

			MessageBox.Show("Previous data have been cleared");
		}

		//this is the list.
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		//enter unit price
		//have to parse the text(string) into double
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			//have to parse the text(string) into double
		}

		//enter the quantity
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			int quantity = (int)numericUpDown1.Value;
		}

	
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
		//this stores 
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
