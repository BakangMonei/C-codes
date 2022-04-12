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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        internal bool addUser(object text1, object text2, object text3, object text4, object text5, object text6, object text7)
        {
            throw new NotImplementedException();
        }

        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            User modirisi = new User(usernameTextBox1.Text, passwordTextBox2.Text, firstnameTextBox3.Text,surnameTextBox4.Text, emailTextBox5.Text, physicalAddressTextBox7.Text, phoneNumberTextBox6.Text) ;
            Registration.RegisterUser(modirisi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ene = new Login();
            ene.Show();
            this.Hide();
        }
    }
}
