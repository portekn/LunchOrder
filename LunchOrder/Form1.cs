using System;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxMainCourse_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //----------Event Handlers----------//
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

        //----------Methods----------//
        private void ClearTotals() //Clears the totals in the Order Total group box
        {
            //code to clear totals here
            foreach (Control tBox in groupBox2.Controls)
            {
                if (tBox is TextBox)
                {
                    ((TextBox)tBox).Equals("");
                }
            }
            //txtOrderTotal.Text.Equals("");
            //txtSalesTax.Text.Equals("");
            //txtSubtotal.Text.Equals("");
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
    }
}
