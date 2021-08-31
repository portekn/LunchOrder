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

        //----------Methods----------//
        private void ClearTotals() //Clears the totals in the Order Total group box
        {
            //code to clear totals here
            txtOrderTotal.Text.Equals("");
            txtSalesTax.Text.Equals("");
            txtSubtotal.Text.Equals("");
        }

        private void ClearAddOns() //Clears the selected add ons in the Add-on group box
        {
            //code to clear add ons here
            checkBox1.CheckState.Equals(false);
            checkBox2.CheckState.Equals(false);
            checkBox3.CheckState.Equals(false);
        }

    }
}
