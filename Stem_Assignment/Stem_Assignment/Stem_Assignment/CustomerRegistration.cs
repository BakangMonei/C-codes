using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stem_Assignment
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void registerCustomerBtn_Click(object sender, EventArgs e)
        {
            DateTime nako = DateTime.Now;

            Customer custi = new Customer(firstnameTextBox1.Text, surnameTextBox2.Text, customerNumberTextBox3.Text, nako);
            Registration reggie = new Registration();
            reggie.RegisterCustomer(custi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
