using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Rebecca Allan
 * Date: January 2022
 * Purpose: An application form that will allow input
 * for customer name and kWh to calculate electrical bill.
 */

namespace CustomerGUI
{
    public partial class frmCustomer : Form
    {
        // creates a list of customers
        List<Customer> customers = new List<Customer>();
        // declare variable for statistics
        decimal TotalkWhUsed = 0;
        decimal TotalBill = 0;
        decimal AvgBill = 0;
        public frmCustomer()
        {
            InitializeComponent();
        }

        // focuses on First Name text box when form loads
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtFName.Focus();
        }

        // adds new customer when add button is clicked and displays in customer list box
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // variables for user entered data
            string FirstName;
            string LastName;
            decimal kWh;
            Customer cust; // reference variable

            // if valid customer data, adds and displays information
            if (Validator.IsPresent(txtFName) &&
                Validator.IsPresent(txtLName) &&
                Validator.IsPresent(txtkWhUsed) &&
                Validator.IsNonNegativeDecimal(txtkWhUsed)
               )
            {
                // gets text that user entered
                FirstName = txtFName.Text;
                LastName = txtLName.Text;
                kWh = Convert.ToDecimal(txtkWhUsed.Text);

                // build customer object 
                cust = new Customer(FirstName, LastName, kWh);

                // add to the list and display in the list box
                customers.Add(cust);
                DisplayCustomers();

                // update and display stats
                txtNoCust.Text = customers.Count.ToString();
                TotalkWhUsed += cust.kWh;
                txtTotalkWh.Text = TotalkWhUsed.ToString();
                TotalBill += cust.CalculateCharge();
                AvgBill = TotalBill / customers.Count;
                txtAvgBill.Text = AvgBill.ToString("c");

                // reset data entry controls
                ResetControls();
            }
        }

        // reset data entry controls
        private void ResetControls()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtkWhUsed.Text = "";
            txtFName.Focus();
        }

        // display customer data
        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            decimal BillAmount;
            foreach (Customer cust in customers)
            {
                // calculate charge for each customer
                BillAmount = cust.CalculateCharge();
                // add bill amount to customer data string
                lstCustomers.Items.Add($"{cust}: {BillAmount.ToString("c")}"); // calls ToString() from cust object
            }
        }

        // clears text boxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtkWhUsed.Text = "";
            txtFName.Focus();
        }
    }
}
