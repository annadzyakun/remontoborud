using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace уч_практика
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
  
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""ремонт оборудования"";
        Integrated Security=True;Connect Timeout=30;");
        private void LoadData(string Исполнитель, string Номер_заявки)
        {
            string query = "SELECT Заказы.Номер_заявки, Заказы.Дата, Заказы.Оборудование, Заказы.Тип_неисправности, " +
                "Заказы.Описание_проблемы, Заказы.Клиент, Заказы.Статус_заказа, Исполнители.ID_исполнителя, Исполнители.Исполнитель," +
                " Исполнители.Комментарий " +
                           "FROM Заказы " +
                           "LEFT JOIN Исполнители ON Заказы.Номер_заявки = Исполнители.Номер_заявки";

            if (!string.IsNullOrEmpty(Исполнитель))
            {
                query += $" WHERE Исполнители.Исполнитель LIKE '%{Исполнитель}%'";
            }

            if (!string.IsNullOrEmpty(Номер_заявки))
            {
                if (query.Contains("WHERE"))
                {
                    query += $" AND Заказы.Номер_заявки = '{Номер_заявки}'";
                }
                else
                {
                    query += $" WHERE Заказы.Номер_заявки = '{Номер_заявки}'";
                }
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=ANNA;Initial Catalog=ремонт оборудования;
            Integrated Security=True;Connect Timeout=30;"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string Исполнитель = textBox1.Text;
            string Номер_заявки = textBox2.Text;

            LoadData(Исполнитель, Номер_заявки);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }
    }
}



    