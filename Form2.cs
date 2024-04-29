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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ANNA;Initial Catalog=""ремонт оборудования"";Integrated Security=True;Connect Timeout=30;");
        private void DisplayFormMaimMenu()
        {
            Con.Open();
            string Query = "Select*from Заказы ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda); var ds = new DataSet(); sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            nomTb.Text = "";
            ДатаTb.Text = "";
            оборTb.Text = "";
            типTB.Text = "";
            опtb.Text = "";
            ФИОTb.Text = "";             
            статусCb.SelectedIndex = -1; 
            
            
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (nomTb.Text == "" || ДатаTb.Text == "" || оборTb.Text == "" || типTB.Text == "" || опtb.Text == "" ||ФИОTb.Text == "" || статусCb.SelectedIndex == -1)
            {
                MessageBox.Show("введите данные");

            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Заказы (Номер_заявки,Дата,Оборудование,Тип_неисправности,Описание_проблемы,Клиент,Статус_заказа) values(@EN, @EF,@EA,@ED,@EY,@EP,@EC) ", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.Parameters.AddWithValue("@EF",ДатаTb.Value.Date);
                    cmd.Parameters.AddWithValue("@EA", оборTb.Text);
                    cmd.Parameters.AddWithValue("@ED", типTB.Text);
                    cmd.Parameters.AddWithValue("@EY", опtb.Text);
                    cmd.Parameters.AddWithValue("@EP", ФИОTb.Text);
                    cmd.Parameters.AddWithValue("@EC", статусCb.SelectedItem.ToString());
                                     
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказ добавлен");
                    Con.Close();
                    DisplayFormMaimMenu(); Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string номерЗаказа = row.Cells["Номер_заявки"].Value.ToString();
                string дата = row.Cells["Дата"].Value.ToString();
                string оборудование = row.Cells["Оборудование"].Value.ToString();
                string типнеисправности = row.Cells["Тип_неисправности"].Value.ToString();
                string описаниепроблемы = row.Cells["Описание_проблемы"].Value.ToString();
                string клиент = row.Cells["Клиент"].Value.ToString();
                string статусзаказа = row.Cells["Статус_заказа"].Value.ToString();
                nomTb.Text = номерЗаказа;
                ДатаTb.Text = дата;
                оборTb.Text = оборудование;
                типTB.Text = типнеисправности;
                опtb.Text = описаниепроблемы;
                ФИОTb.Text =клиент;
                статусCb.SelectedItem = статусзаказа;
            }
            else
            {
                MessageBox.Show("Выберите заказ для обновления");
            }
        }

         private void delete_Click(object sender, EventArgs e)
         {
            if (string.IsNullOrEmpty(nomTb.Text))
            {
                MessageBox.Show("Введите номер заказа");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Заказы where Номер_заявки=@EN", Con);
                    cmd.Parameters.AddWithValue("@EN", nomTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказ удален");
                    Con.Close(); Clear();
                    DisplayFormMaimMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       
      

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide(); 
            form7.Show();
        }
    }
}
