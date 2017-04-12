using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mRegularDiscount = false;
        bool mChildDiscount = false;

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            
            if (chkDiscount.Checked)
                { mRegularDiscount = true; }
            //added check if Child is checked
            if(chkChild.Checked)
            { mChildDiscount = true; }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mRegularDiscount, mChildDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChild.Checked && chkDiscount.Checked)
            {
                chkChild.Checked = false;
            }
        }

        private void chkChild_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChild.Checked && chkDiscount.Checked)
            {
                chkDiscount.Checked = false;
            }
        }
     }
}
