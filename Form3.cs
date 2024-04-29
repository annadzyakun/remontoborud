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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""ремонт оборудования"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFormMaimMenu()
        {
            Con.Open();
            string Query = "Select*from Исполнители ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet(); sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            nomTb.Text = "";
            idTb.Text = "";           
            ispCb.SelectedIndex = -1;
            comTb.Text = "";
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nomTb.Text == "" || idTb.Text == "" || ispCb.SelectedIndex == -1||comTb.Text == "")
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Исполнители (Номер_заявки,ID_исполнителя,Исполнитель,Комментарий)" +
                        " values(@EN, @EF,@EC, @EA) ", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@EF", idTb.Text);
                    cmd.Parameters.AddWithValue("@EC", ispCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EA", comTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Исполнитель добавлен");
                    Con.Close();
                    DisplayFormMaimMenu(); Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string номерЗаказа = row.Cells["Номер_заявки"].Value.ToString();
                string id = row.Cells["ID_исполнителя"].Value.ToString();                
                string исполнитель = row.Cells["Исполнитель"].Value.ToString();
                string комментарий = row.Cells["Комментарий"].Value.ToString();
                nomTb.Text = номерЗаказа;
                idTb.Text = id;
                ispCb.SelectedItem = исполнитель;
                comTb.Text = комментарий;
            }
            else
            {
                MessageBox.Show("Выберите исполнителя для обновления");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomTb.Text))
            {
                MessageBox.Show("Введите исполнителя");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Исполнители where Номер_заявки=@EN", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("исполнитель удален");
                    Con.Close(); Clear();
                    DisplayFormMaimMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }







        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
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
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide(); 
            form6.Show();
        }
    }
}
