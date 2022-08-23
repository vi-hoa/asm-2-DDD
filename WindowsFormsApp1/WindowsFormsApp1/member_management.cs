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
    public partial class member_management : Form
    {
        SqlConnection con;// ket noi sql ser
        SqlCommand cmd;// thuc thi cau lenh sql vi du select , insert , update
        SqlDataReader dr; // kiem tra ket qua cau lenh chay
        SqlDataAdapter adapt;
        public member_management()
        {
            InitializeComponent();
            con = new SqlConnection("server=DESKTOP-VIEPHU2\\SQLEXPRESS; database=library_db;uid=sa;pwd=123456");
        }

        private void DisplayDataMember()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Member", con);
            adapt.Fill(dt);
            dgv_member.DataSource = dt;
            con.Close();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // tao sql command de thuc thi lenh sql
                SqlCommand cmd1 = con.CreateCommand();

                // thiet lap thong so cau lenh insert
                cmd1.CommandText = "insert into Book values (@m_ID,@m_name,@m_phone,@m_DOB,@m_email,@m_gender) ";
                con.Open();


                // truyen tham so cho cau lenh insert
                cmd1.Parameters.Add("@m_ID", SqlDbType.Int).Value = id_txb.Text;
                cmd1.Parameters.Add("@m_name", SqlDbType.NVarChar, 30).Value = name_txb.Text;
                cmd1.Parameters.Add("@m_phone", SqlDbType.VarChar, 20).Value = phone_txb.Text;
                cmd1.Parameters.Add("@m_DOB", SqlDbType.Date).Value = dateTimePicker1.Value;
                cmd1.Parameters.Add("@m_email", SqlDbType.VarChar, 40).Value = mail_txb.Text;
                cmd1.Parameters.Add("@m_gender", SqlDbType.Bit).Value = female_chb.Text;

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

        private void show_btn_Click(object sender, EventArgs e)
        {
            try
            {
       
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Member";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_member.DataSource = dt;
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (dgv_member.SelectedRows.Count == 1)
            {
                SqlCommand cmd2;
                cmd2 = new SqlCommand("delete Member where m_ID = @m_ID", con);
                con.Open();
                cmd2.Parameters.AddWithValue("@m_ID", id_txb.Text);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayDataMember();        

            }
            else
            {
                MessageBox.Show("Select Record to Delete");
            }

        }
    }
}
