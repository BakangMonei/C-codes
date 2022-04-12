using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Stem_Assignment
{
    class Authentication
    {
        public Authentication(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public  void Authenticate(Authentication user)
        {

            /*List<string> lines = File.ReadAllLines("username+password.txt").ToList();
            {
                foreach (var line in lines)
                {
                    line.Replace('#', ',');
                    line.Split(',');
                    string[] details = line; 
                   
                }
            }*/

            var lines = File.ReadAllLines("username+password.txt");//read the whole textfile username+password line by lines
            int count = 0;
            foreach (var line in lines)//for every line we 
            {
                //int count = 0;
                var holdvalue = line.Split('#');//splits the line in the text file into different enitites the first filed before # is index 0 and so on 
                if (user.UserName == holdvalue[0] && user.Password == holdvalue[1])//the 
                {
                    count++;
                }

            }
            if (count == 1)
            {
                MainForm mainf = new MainForm();
                mainf.Show();
                MessageBox.Show("Logged in successfully");
                DateTime date = DateTime.Now;
                string log = user.UserName + "#" + date;
                File.AppendAllText("Log.txt", log + System.Environment.NewLine);

            }
            else
            {
                MessageBox.Show("Incorrect details, please cross check your details");

            }

        }
    }
}

