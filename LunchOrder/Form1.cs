using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //----------Event Handlers----------//
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void radioButton1_Checked(object sender, EventArgs e) //Hamburger
        {
            ClearTotals();
            ClearAddOns();
            groupBox1.Text = "Add-on items ($.75/each)";
            checkBox1.Text = "Lettuce, tomato, and onions";
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox3.Text = "French fries";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //Pizza
        {
            ClearTotals();
            ClearAddOns();
            groupBox1.Text = "Add-on items ($.50/each)";
            checkBox1.Text = "Pepperoni";
            checkBox2.Text = "Sausage";
            checkBox3.Text = "Olives";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //Salad
        {
            ClearTotals();
            ClearAddOns();
            groupBox1.Text = "Add-on items ($.25/each)";
            checkBox1.Text = "Croutons";
            checkBox2.Text = "Bacon bits";
            checkBox3.Text = "Bread sticks";
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
         ClearTotals();
        }

        //----------Methods----------//
        private void ClearTotals() //Clears the totals in the Order Total group box
        {
            //code to clear totals here
            foreach (Control tBox in groupBox2.Controls)
            {
                if (tBox is TextBox)
                {
                    ((TextBox)tBox).Text = "";
                }
            }
        }

        private void ClearAddOns() //Clears the selected add ons in the Add-on group box
        {
            //code to clear add ons here

            foreach (Control cBox in groupBox1.Controls)
            {
                if (cBox is CheckBox)
                {
                    ((CheckBox)cBox).Checked = false;
                }
            }
        }

        private void CalculateTotals() //Preforms the calculations
        {   
            

            double Main = 0; //Main course Price
            double addon = 0; //Add on price
            int cbCount = 0; //Number of check boxes checked

            double sub; //Subtotal
            double tax; //Tax added on
            double total; //Total bill

            //Check what radio button is checked and set main course and addon prices

                if (radioButton1.Checked == true)
                { Main = 6.95; addon = 0.75; }
                else if (radioButton2.Checked == true)
                { Main = 5.95; addon = 0.50; }
                else if (radioButton3.Checked == true)
                { Main = 4.95; addon = 0.25; }

            //Check how many check boxes are checked
            if (checkBox1.Checked == true)
            { cbCount++; }
            if (checkBox2.Checked == true)
            { cbCount++; }
            if (checkBox3.Checked == true)
            { cbCount++; }

            //Calculate
            sub = Main + (addon * cbCount); //Calcuates the Subtotal
            tax = (7.75/100) * sub; //Calculates the tax on the order
            total = sub + tax; //Calculates the Total of the order

            txtSubtotal.Text = sub.ToString("$#.##");
            txtSalesTax.Text = tax.ToString("$0.##");
            txtOrderTotal.Text = total.ToString("$#.##");
        }
    }
}
