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
    public partial class frm_register : Form
    {
        SqlConnection con;// ket noi sql ser
        SqlCommand cmd;// thuc thi cau lenh sql vi du select , insert , update
        SqlDataReader dr; // kiem tra ket qua cau lenh chay
        public frm_register()
        {
            InitializeComponent();
            con = new SqlConnection("server=DESKTOP-VIEPHU2\\SQLEXPRESS; database=library_db;uid=sa;pwd=123456");
            con.Open();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            frm_login Login = new frm_login();
            this.Hide();
            Login.Show();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if (id_txb.Text != string.Empty || username_txb.Text != string.Empty || pass_txb.Text != string.Empty || cfpass_txb.Text != string.Empty)
            {
                if (cfpass_txb.Text == cfpass_txb.Text)
                {

                    cmd = new SqlCommand("select * from Login_Form where Username='" + username_txb.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        //dr.Close();
                        MessageBox.Show("Username already exist, try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();


                    }
                    else
                    {
                        dr.Close();
                        try
                        {
                            SqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandText = "insert into Login_Form values(@Username,@Password,@m_Id)";

                            cmd1.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username_txb.Text;
                            cmd1.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = pass_txb.Text;
                            cmd1.Parameters.Add("@m_Id", SqlDbType.Int).Value = id_txb.Text;


                            cmd1.ExecuteNonQuery();


                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        catch (SqlException ex)

                        {
                            MessageBox.Show(ex.Message, "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
