using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_quan_cafe
{
    public partial class fMain : Form
    {
        public bool isExit = true;
        // tạo hàm ủy thác ( deligate )
        public event EventHandler Logout;
        public fMain()
        {
            InitializeComponent();
            Console.OutputEncoding = Encoding.UTF8;
        }
        // Ham nay de phan quyen user
        void Decentralization()
        {
            
        }

        public void fMain_FormLoad(object sender, EventArgs e)
        {
            if (PhanQuyenUser.AccountType == false)
            {
                lbUsername.Text = PhanQuyenUser.UserName;
                lbRole.Text = "NV : " + PhanQuyenUser.Name;
                btn_QLSP.Enabled = btn_TK.Enabled = btnQLNV.Enabled = false;

            }
            else
            {
                lbUsername.Text = PhanQuyenUser.UserName;
                lbRole.Text = "QL : " + PhanQuyenUser.Name;
            }
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban co muon thoat chuon trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void exitBtn_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            adminTaoHD.Visible = true;
            adminQLDA.Visible = false;
            adminQLNV.Visible = false;
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            adminTaoHD.Visible = false;
            adminQLDA.Visible = true;
            adminQLNV.Visible = false;
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            adminTaoHD.Visible = false;
            adminQLDA.Visible = false;
            adminQLNV.Visible = true;
        }
    }
}
