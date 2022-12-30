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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-7JR81D4O\\SABRI;Initial Catalog=Personnel_Table;Integrated Security=True");
        private void showdata()
        {
            // TODO: Bu kod satırı 'personnel_TableDataSet3.Personnel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personnelTableAdapter.Fill(this.personnel_TableDataSet3.Personnel);
            // TODO: Bu kod satırı 'personnel_TableDataSet2.Off_Day_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.off_Day_TableTableAdapter.Fill(this.personnel_TableDataSet2.Off_Day_Table);

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            showdata();
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand add = new SqlCommand("insert into Off_Day_Table (Per_Name,Per_Surname,Off_Day) values (@p1,@p2,@p3)", connect);         
            add.Parameters.AddWithValue("@p1", txt_off_name.Text);
            add.Parameters.AddWithValue("@p2", txt_off_surname.Text);
            add.Parameters.AddWithValue("@p3", dateTimePicker3.Value);
            add.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand add = new SqlCommand("insert into Personnel (Per_Name,Per_SurName,Per_Birtday,Per_Gender,Per_Start_Time,Per_Position,Id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect);
            add.Parameters.AddWithValue("@p1", txtbox_Name.Text);
            add.Parameters.AddWithValue("@p2", txtbox_Surname.Text);
            add.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            add.Parameters.AddWithValue("@p4", txtbox_gender.Text);
            add.Parameters.AddWithValue("@p5", dateTimePicker2.Value);
            add.Parameters.AddWithValue("@p6", txtbox_position.Text);
            add.Parameters.AddWithValue("@p7", txtbox_Id.Text);
            add.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            txtbox_Id.Text = dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtbox_Name.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtbox_Surname.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            txtbox_gender.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            txtbox_position.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();
            txt_off_name.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            txt_off_surname.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
