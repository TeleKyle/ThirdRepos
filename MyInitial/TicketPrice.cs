using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private bool regDiscount;
        private bool childDiscount;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecDiscount = 5.0m;
        const decimal mdecChildDiscount = 10.0m;

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

        //added child discount
         private bool ChildDiscount
         {
             get { return childDiscount; }
             set { childDiscount = value; }
         }

         private bool RegDiscount
         {
             get { return regDiscount; }
             set { regDiscount = value; }
         }

         public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

    // Constructor for TicketPrice
    public TicketPrice(int section, int quantity, bool regDiscount, bool childDiscount)
    {
        Section = section;
        Quantity = quantity;
        RegDiscount = regDiscount;
        ChildDiscount = childDiscount;
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
         }
         if (regDiscount)
         { 
             mPrice -= mdecDiscount;
         }
         else if (childDiscount)
         {
             mPrice -= mdecChildDiscount;
         }
         

         AmountDue = mPrice * quantity;

     }
    }
}
