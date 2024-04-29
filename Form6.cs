using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Media.Media3D;
using System.Collections;
using System.Net.NetworkInformation;

namespace уч_практика
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


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
        private void Clear()
        {
            nomTb.Text = "";
            idTb.Text = "";
            
            vrTb.Text = "";
            matTb. Text = "";
            prTb.Text = "";
            soCb.SelectedIndex = -1;
            CenaTb.Text = "";
        }
        public void LoadDataIntoDataGridView()
        {
            string connectionString = @"Data Source=ANNA;Initial Catalog=""ремонт оборудования"";Integrated Security=True;Connect Timeout=30;";
            string query = @"SELECT Исполнители.Номер_заявки, Исполнители.ID_исполнителя, Исполнители.Исполнитель, Исполнители.Комментарий,
             Отчет.время, Отчет.материалы, Отчет.причина, Отчет.состояние, Отчет.стоимость 
              FROM Исполнители 
              LEFT JOIN Отчет ON Исполнители.Номер_заявки = Отчет.Номер_заявки AND Исполнители.ID_исполнителя = Отчет.ID_исполнителя";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (otch.Text == "" || nomTb.Text == "" || idTb.Text == ""  ||vrTb.Text == "" || matTb.Text == "" ||
                prTb.Text == "" || soCb.SelectedIndex == -1||CenaTb.Text == "" )
            {
                MessageBox.Show("введите данные");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Отчет(id_Отчета,Номер_заявки,ID_исполнителя,время," +
                        "материалы,причина,состояние,стоимость) values(@ES,@EN,@ED,@ER,@EY,@EP,@EF,@EL) ", Con);
                    cmd.Parameters.AddWithValue("@ES", otch.Text);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@ED", idTb.Text);                               
                    cmd.Parameters.AddWithValue("@ER", vrTb.Text);
                    cmd.Parameters.AddWithValue("@EY", matTb.Text);
                    cmd.Parameters.AddWithValue("@EP", prTb.Text);
                    cmd.Parameters.AddWithValue("@EF", soCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EL", CenaTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Отчет добавлен");
                    Con.Close();
                    DisplayFormMaimMenu(); Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string номерзаявки = row.Cells["Номер_заявки"].Value.ToString();
                string ID = row.Cells["ID_исполнителя"].Value.ToString();
                string время = row.Cells["время"].Value.ToString();
                string материалы = row.Cells["материалы"].Value.ToString();
                string причины = row.Cells["причина"].Value.ToString();
                string состояние = row.Cells["состояние"].Value.ToString();
                string стоимость = row.Cells["стоимость"].Value.ToString();
                nomTb.Text = номерзаявки;
                idTb.Text = ID;
                vrTb.Text = время;
                matTb.Text = материалы;
                prTb.Text = причины;
                soCb.SelectedItem = состояние;
                CenaTb.Text = стоимость;
            }
            else
            {
                MessageBox.Show("Выберите данные для обновления");
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomTb.Text))
            {
                MessageBox.Show("Введите поля для удаления");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Отчет where Номер_заявки=@EN", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("данные из отчета удалены");
                    Con.Close(); Clear();
                    DisplayFormMaimMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
