using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Stem_Assignment
{
    class Registration
    {
        public static void RegisterUser(User user)
        {
            if (File.Exists("Users.txt") /*&& File.Exists("customerdetails.txt")*/)//if users text file exists
            {
                var lines = File.ReadAllText("Users.txt");
                if (lines.Contains(user.PhoneNumber.ToString()))//we use this condition to restrict a phone number to only one user
                {
                    MessageBox.Show("An account with the input phone number already exists, enter a different phone number");
                }
                else
                {
                    //I group the details that have been entered into a single string to write the string to a text file
                    string st = user.FirstName + "#" + user.LastName + "#" + user.PhysicalAddress + "#" + user.PhoneNumber + "#" + user.Email;
                    //I do the same for password and username into a separate string to store them in a separate text file
                    string st2 = user.UserName + "#" + user.Password;
                    File.AppendAllText("Users.txt", st + System.Environment.NewLine);//I save the details into my users text file
                    File.AppendAllText("username+password.txt", st2 + System.Environment.NewLine);//i save the details to username and password text file
                    MessageBox.Show("Account created");
                    Login  loga = new Login();
                    loga.Show();

                }
            }
            else//if file does not exist
            {
                File.Create("Users.txt");//create the file
                                         //I group the details that have been entered into a single string to write the string to a text file
                File.Create("username+password.txt");
                string st = user.FirstName + "#" + user.LastName + "#" + user.PhysicalAddress + "#" + user.PhoneNumber + "#" + user.Email;
                //I do the same for password and username into a separate string to store them in a separate text file
                string st2 = user.UserName + "#" + user.Password;
                File.AppendAllText("Users.txt", st + System.Environment.NewLine);//I save the details into my users text file
                File.AppendAllText("username+password.txt", st2 + System.Environment.NewLine);//i save the details to username and password text file

            }


        }

        public  void RegisterCustomer(Customer customer)
        {
            if (File.Exists("customerdetails.txt"))//if customer text file exists
            {
                var details = File.ReadAllText("customerdetails.txt");
                if (details.Contains("customer.CustomerNumber"))//we make sure that a customer number is never the same for 2 people
                {
                    MessageBox.Show("An account containing the input customer number already exists, enter a different number");
                }
                else
                {
                    //details about a customer are grouped into a single string
                    string cus = customer.FirstName + "#" + customer.LastName + "#" + customer.CustomerNumber + "#" + customer.Date;

                    File.AppendAllText("customerdetails.txt", cus + System.Environment.NewLine);
                    //in line above the details are saved into customer details text file
                }
            }
            else//if it does not exist we create it
            {
                string cus = customer.FirstName + "#" + customer.LastName + "#" + customer.CustomerNumber + "#" + customer.Date;
                File.AppendAllText("customerdetails.txt", cus + System.Environment.NewLine);
                MessageBox.Show("The customer has been registered successfully");
            }
        }
    }
}

