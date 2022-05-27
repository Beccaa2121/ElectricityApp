using System;

/*
 * Author: Rebecca Allan
 * Date: January 2022
 * Purpose: A customer class to store data on new customers
 * and calculate the bill amount.
 */

namespace CustomerData
{
    public class Customer
    {
        // constants to calculate charge
        const decimal AdminCharge = 12m;
        const decimal Rate = 0.07m;

        // customer data
        public int AccountNo; // customer account number
        public string FirstName; // customer first name
        public string LastName; // customer last name
        public decimal kWh; // number of kWh used
        public static int counter = 100; // counter starting at 100
        public decimal BillAmount; // total bill

        // constructor with parameters
        public Customer(string f, string l, decimal k)
        {
            FirstName = f;
            LastName = l;
            kWh = k;
            // auto generate account number adding by 1
            AccountNo = counter;
            counter++;
        }

        // method that calculates charge based on the kWh used by the customer
        public virtual decimal CalculateCharge() // allow overriding
        {
            // if there is a zero or negative kWh used the bill is $0
            if (kWh <= 0)
            {
                BillAmount = 0;
            }
            else
            {
                BillAmount = AdminCharge + (kWh * Rate); // Charge formula
            }
            return BillAmount;
        }

        // returns string to display customer data
        public override string ToString()
        {
            return $"{AccountNo}, {FirstName}, {LastName}, {kWh.ToString()}";
        }
    }
}
