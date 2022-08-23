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



    public partial class frm_login : Form
    {

        SqlConnection con;// ket noi sql ser
        SqlCommand cmd;// thuc thi cau lenh sql vi du select , insert , update
        SqlDataReader dr; // kiem tra ket qua cau lenh chay
      
        public frm_login()
        {
            InitializeComponent();
            con = new SqlConnection("server=DESKTOP-VIEPHU2\\SQLEXPRESS; database=library_db;uid=sa;pwd=123456");
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string user = username_txb.Text;
                string pass = password_txb.Text;
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Login_Form where Username='" + username_txb.Text + "' AND Password='" + password_txb.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login sucess Welcome ");
                    frm_management obj = new frm_management();// goi doi tuong toi form book
                    obj.Show();// hien thi form book ra
                    this.Hide();// an form hien tai
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);// hien thi thong bao loi neu co
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will move you to Register!", "Register!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_register Register = new frm_register();
            Register.Show();
            this.Hide();
        }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void frm_login_Load(object sender, EventArgs e)
    {

    }
}


