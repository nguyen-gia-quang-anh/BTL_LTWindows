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

namespace Quan_ly_quan_cafe
{
    public partial class fLogin : Form
    {
        // Khoi tao chuoi ket noi
        string connectionString = "Data Source=DESKTOP-1SBS0S1\\SQLEXPRESS;Initial Catalog = QLCoffee;Integrated Security=True";
        SqlConnection conn = null;
        int x = 2;
        public fLogin()
        {
            InitializeComponent();
        }

        // Ket noi CSDL de check User
        private void fLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connectionString);
                }

                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    MessageBox.Show("OK", "Info", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "Error", MessageBoxButtons.OK);
            }
        }

        public bool checkLogin()
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                return false; 
            }
            else
            {
                // kiem tra username va password co ton tai khong ( co su dung paramater )
                string selectAcc = "Select Chucvu, TNV from QLNV where username = @username and pass = @password";

                SqlCommand cmd = new SqlCommand(selectAcc, conn);
                cmd.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", tbPassword.Text.Trim());

                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dttb = new DataTable();
                adt.Fill(dttb);

                if (dttb.Rows.Count >= 1)
                {
                    PhanQuyenUser.UserName = tbUsername.Text;
                    PhanQuyenUser.Name = dttb.Rows[0][1].ToString();
                    //Console.WriteLine(dttb.Rows[0][1].ToString());
                    if (dttb.Rows[0][0].ToString() == "nv")
                    {
                        x = 1;
                        PhanQuyenUser.AccountType = false;
                    }
                    else
                    {
                        PhanQuyenUser.AccountType = true;

                    }
                    return true;
                    Console.WriteLine(dttb.Rows[0][0].ToString()); // ra 'nv' hoac 'ad'
                }
                else
                {
                    return false;
                }
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                Console.WriteLine(x);
                fMain f = new fMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai username hoac password", "Info", MessageBoxButtons.OK);
                tbUsername.Focus();
            }
        }
        private void F_Logout(object sender, EventArgs e)
        {
            // chi dang xuat chu khong thoat chuong trinh
            (sender as fMain).isExit = false;
            (sender as fMain).Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
