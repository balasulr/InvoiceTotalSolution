using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal {

    public partial class FormInvoiceTotal : Form {
        public FormInvoiceTotal() {
            InitializeComponent();
        }

        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void FormInvoiceTotal_Load(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);

            decimal discountPercent = 0.25m; // Defaults the discount percent to 25%

            decimal discountAmount = Math.Round(subtotal * discountPercent, 2); // Round to 2 decimals

            decimal invoiceTotal = subtotal - discountAmount;

            txtSubtotal.Text = subtotal.ToString("c"); // Formats as currency
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices / numberOfInvoices;

            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");

            txtEnterSubtotal.Text = ""; // Clear what user entered
            txtEnterSubtotal.Focus();
        }

        private void btnClearTotals_Click(object sender, EventArgs e) {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubtotal.Focus();
        }
    }
}
