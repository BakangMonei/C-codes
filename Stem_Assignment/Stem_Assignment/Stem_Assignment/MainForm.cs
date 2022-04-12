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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facilitateLoans loan = new facilitateLoans();
            loan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerRegistration cus = new CustomerRegistration();
            cus.Show();
            this.Hide();
        }
    }
}
