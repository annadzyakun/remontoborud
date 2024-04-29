using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace уч_практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthUser(username, password))
            {
                MessageBox.Show("Успешный вход!");
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
        }
        private bool AuthUser(string username, string password)
        {
            Dictionary<string, string> users = new Dictionary<string, string>
            {
                { "admin", "administrator" },
                { "man", "manager" }
            };
            if (users.ContainsKey(username) && users[username] == password)
            {
                return true;
            }

            return false;
        }
    }
}
