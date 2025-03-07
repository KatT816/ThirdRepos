﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool discount;
        private decimal amountDue;
        private decimal mPrice;
        private bool childDiscount; // Added child discount field

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        const decimal mdecChildDiscount = 1.0m; // 10% child discount
        const decimal mdecStalls = 15.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

         private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

         private bool Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        private bool ChildDiscount //Added Child Discount Property
        {
            get { return childDiscount; }
            set { childDiscount = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

        // Constructor for TcicketPrice (modified to accept childDiscount)
        public TicketPrice(int section, int quantity, bool discount, bool childDiscount)
    {
        Section = section;
        Quantity = quantity;
        Discount = discount;
        ChildDiscount = childDiscount; // Added Child Discount
        AmountDue = amountDue;
    }

     public void calculatePrice()
     {

         switch (section)
         {
             case 1:
                 mPrice = mdecBalcony;
                 break;
             case 2:
                 mPrice = mdecGeneral;
                 break;
             case 3:
                 mPrice = mdecBox;
                 break;
             case 4:
                    mPrice = mdecStalls;
                    break;
         }
         if (discount)
         { mPrice -= mdecDiscount; }

            if (childDiscount)
            {
                mPrice -= mdecChildDiscount; // Apply child discount
            }


            AmountDue = mPrice * quantity;

     }
    }
}
