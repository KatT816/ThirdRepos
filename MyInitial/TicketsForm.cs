﻿using System;
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
        bool mDiscount = false;
        //adding new boolean for discount
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
                { mDiscount = true;
                //added additional conditions
                chkChildDiscount.Checked = false; //Uncheck child discount
                mChildDiscount = false;
            }
            //added child discount code
            if (chkChildDiscount.Checked)
                { mChildDiscount = true;
                chkDiscount.Checked = false; //Uncheck adult discount
                mDiscount = false;
            }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            //new rad button added
            if (radStalls.Checked)
            { mSection = 4; }

           
            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, mChildDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }
     }
}
