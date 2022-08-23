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

namespace WindowsFormsApp1
{
    public partial class frm_management : Form
    {
        SqlConnection con;// ket noi sql ser
        SqlCommand cmd;// thuc thi cau lenh sql vi du select , insert , update
        SqlDataReader dr; // kiem tra ket qua cau lenh chay
        SqlDataAdapter adapt;
        public frm_management()
        {
            InitializeComponent();
            con = new SqlConnection("server=DESKTOP-VIEPHU2\\SQLEXPRESS; database=library_db;uid=sa;pwd=123456");
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // tao sql command de thuc thi lenh sql
                SqlCommand cmd1 = con.CreateCommand();

                // thiet lap thong so cau lenh insert
                cmd1.CommandText = "insert into Book values (@b_ID,@b_name,@b_author_id,@b_publisher,@b_language,@b_format) ";
                con.Open();


                // truyen tham so cho cau lenh insert
                cmd1.Parameters.Add("@b_ID", SqlDbType.Int).Value = bookID_txb.Text;
                cmd1.Parameters.Add("@b_name", SqlDbType.NVarChar, 100).Value = bookname_txb.Text;
                cmd1.Parameters.Add("@b_author_id", SqlDbType.Int).Value = author_txb.Text;
                cmd1.Parameters.Add("@b_publisher", SqlDbType.NVarChar, 50).Value = publisher_txb.Text;
                cmd1.Parameters.Add("@b_language", SqlDbType.NVarChar, 30).Value = language_txb.Text;
                cmd1.Parameters.Add("@b_format", SqlDbType.VarChar, 30).Value = format_txb.Text;

                // thuc thi truy van
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Add Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayDataBook()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Book", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SqlCommand cmd2;
                cmd2 = new SqlCommand("delete Book where b_ID = @b_ID", con);
                con.Open();
                cmd2.Parameters.AddWithValue("@b_ID", bookID_txb.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataBook();

            }
            else
            {
                MessageBox.Show("Select Record to Delete");
            }


        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            DisplayDataBook();
            if (bookID_txb.Text != "" && bookname_txb.Text != "" && author_txb.Text != "" && publisher_txb.Text != "" && language_txb.Text != "" && format_txb.Text != "")
            {
                cmd = new SqlCommand("update Book set b_Name=@b_name,b_author=@b_author,b_publisher=@b_publisher,b_language=@b_language,b_format=@b_format where b_ID=@b_ID", con);
                con.Open();

                cmd.Parameters.AddWithValue("@b_ID", bookID_txb.Text);
                cmd.Parameters.AddWithValue("@b_name", bookname_txb.Text);
                cmd.Parameters.AddWithValue("@b_author", author_txb.Text);
                cmd.Parameters.AddWithValue("@b_publisher", publisher_txb.Text);
                cmd.Parameters.AddWithValue("@b_language", language_txb.Text);
                cmd.Parameters.AddWithValue("@b_format", format_txb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully");
                con.Close();
                DisplayDataBook();
                // ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Member(object sender, EventArgs e)
        {
            this.Hide();
            member_management member_management = new member_management();
            member_management.ShowDialog();
            this.Close();
        }

        private void frm_management_Load(object sender, EventArgs e)
        {

        }
    }
}
