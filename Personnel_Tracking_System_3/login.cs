using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personnel_Tracking_System_3
{
    public partial class login : Form
    {
        public string user;
        public string password;
        public string admin;
        public string A_password;
        public string Login_User;
        public string Login_Password;

        public login()
        {
            InitializeComponent();
        }
        public string User_Send(string Login_User)
        {
            Login_User = textBox1.Text;
            return Login_User;
        }
        public string Password_Send(string Login_Password)
        {
            Login_Password = textBox2.Text;
            return Login_Password;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            admin =dataBase.Admin_name(admin);
            A_password = dataBase.Admin_password(A_password);

            user = dataBase.Username(user);
            password = dataBase.UserPassword(password);

            int yetki = comboBox1.SelectedIndex;
            string yetkis = yetki.ToString();
            string Adminyetki = "0";
            string Useryetki = "1";

            if (yetkis == Adminyetki)
            {
                if (textBox1.Text == admin && textBox2.Text == A_password)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Username Or Password Error","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else if (yetkis == Useryetki)
            {
                if (textBox1.Text == user && textBox2.Text == password)
                {
                    UserPage userPage = new UserPage();
                    this.Hide();
                    userPage.Show();
                }
                else
                {
                    MessageBox.Show("Username Or Password Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Choose authorization", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                

            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            string yazi =dataBase.Username(user);
            label3.Text = yazi;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Input Username=sabri Password=2001\nUser Input Username=meliha Password=1971");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }


        }

        private void login_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }
    }
}
