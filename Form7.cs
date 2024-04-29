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
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();

        }
        public bool Выполнено { get; set; }
        public int ВремяВыполнения { get; set; }
        

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""ремонт оборудования"";Integrated Security=True;Connect Timeout=30;");

        private void DisplayFormMaimMenu()
        {
            Con.Open();
            string Query = "Select*from Отчет ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet(); sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_оборудованияDataSet2.Отчеты". При необходимости она может быть перемещена или удалена.
            this.отчетыTableAdapter.Fill(this.ремонт_оборудованияDataSet2.Отчеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_оборудованияDataSet1.Отчет". При необходимости она может быть перемещена или удалена.
            this.отчетTableAdapter1.Fill(this.ремонт_оборудованияDataSet1.Отчет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ремонт_оборудованияDataSet.Отчет". При необходимости она может быть перемещена или удалена.
            this.отчетTableAdapter.Fill(this.ремонт_оборудованияDataSet.Отчет);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""ремонт оборудования"";Integrated Security=True;Connect Timeout=30;");
            SqlCommand command = new SqlCommand("SELECT COUNT(*) AS TotalCompletedOrders, AVG(DATEDIFF(SECOND, '00:00:00', время)) AS AvgTime" +
                " FROM Отчеты WHERE Состояние = 'выполнено'", connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox1.Text = reader["TotalCompletedOrders"].ToString();
                        TimeSpan totalTime = TimeSpan.FromSeconds(Convert.ToDouble(reader["AvgTime"]));
                        textBox2.Text = totalTime.ToString(@"hh\:mm\:ss");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    




        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }
    }

}
