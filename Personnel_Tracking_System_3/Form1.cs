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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void showdata()
        {
            this.personnelTableAdapter1.Fill(this.personnel_TableDataSet1.Personnel);
        }
        void showdata2()
        {
            this.off_Day_TableTableAdapter.Fill(this.personnel_TableDataSet4.Off_Day_Table);

        }

        void clear()
        {
            textBox1.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";

        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-7JR81D4O\\SABRI;Initial Catalog=Personnel_Table;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personnel_TableDataSet4.Off_Day_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.off_Day_TableTableAdapter.Fill(this.personnel_TableDataSet4.Off_Day_Table);
            this.personnelTableAdapter1.Fill(this.personnel_TableDataSet1.Personnel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.personnelTableAdapter1.Fill(this.personnel_TableDataSet1.Personnel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand add = new SqlCommand("insert into Personnel (Per_Name,Per_SurName,Per_Birtday,Per_Gender,Per_Start_Time,Per_Position,Id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",connect);
            add.Parameters.AddWithValue("@p1", textBox1.Text);
            add.Parameters.AddWithValue("@p2", textBox5.Text);
            add.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            add.Parameters.AddWithValue("@p4", textBox7.Text);
            add.Parameters.AddWithValue("@p5", dateTimePicker2.Value);
            add.Parameters.AddWithValue("@p6", textBox9.Text);
            int id = Convert.ToInt32(textBox2.Text);
            int newId = id + 1;
            add.Parameters.AddWithValue("@p7", newId);
            add.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            textBox9.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
            dateTimePicker2.Text= dataGridView1.Rows[select].Cells[5].Value.ToString();
            showdata2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand delete = new SqlCommand("Delete From Personnel Where Per_Name=@p1", connect);
            delete.Parameters.AddWithValue("@p1", textBox1.Text);
            delete.ExecuteNonQuery();
            showdata();
            MessageBox.Show("Records Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connect.Close();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand update = new SqlCommand("Update Personnel Set Per_Name=@p1,Per_SurName=@p2,Per_Birtday=@p3,Per_Gender=@p4,Per_Start_Time=@p5,Per_Position=@p6 where Id=@p7 ", connect);
            update.Parameters.AddWithValue("@p1", textBox1.Text);
            update.Parameters.AddWithValue("@p2", textBox5.Text);
            update.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            update.Parameters.AddWithValue("@p4", textBox7.Text);
            update.Parameters.AddWithValue("@p5", dateTimePicker2.Value);
            update.Parameters.AddWithValue("@p6", textBox9.Text);
            update.Parameters.AddWithValue("@p7", textBox2.Text);
            update.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView2.SelectedCells[0].RowIndex;
            textBox6.Text = dataGridView2.Rows[select].Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.Rows[select].Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.Rows[select].Cells[2].Value.ToString();
            dateTimePicker3.Text = dataGridView2.Rows[select].Cells[3].Value.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand update = new SqlCommand("Update Off_Day_Table Set Per_Name=@p2,Per_Surname=@p3,Off_Day=@p4,Accept=@p5 where Id=@p6 ", connect);
            if (radioButton1.Checked)
            {
                label14.Text = "true";
            }
            if (radioButton2.Checked)
            {
                
                label14.Text = "false";
                SqlCommand delete = new SqlCommand("Delete From Off_Day_Table Where Per_Name=@p1", connect);
                delete.Parameters.AddWithValue("@p1", textBox3.Text);
                delete.ExecuteNonQuery();
                
            }
            update.Parameters.AddWithValue("@p2", textBox3.Text);
            update.Parameters.AddWithValue("@p3", textBox4.Text);
            update.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            update.Parameters.AddWithValue("@p5", label14.Text);
            update.Parameters.AddWithValue("@p6", textBox6.Text);
            update.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Successfully Updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            showdata2();
        }
    }
}
