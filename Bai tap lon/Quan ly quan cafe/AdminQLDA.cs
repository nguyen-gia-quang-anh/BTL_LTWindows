using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_ly_quan_cafe
{
    public partial class AdminQLDA : UserControl
    {
        string connectionString = "Data Source=quanhlap;Initial Catalog=QLCoffee;Integrated Security=True";
        SqlConnection conn = null;
        string query;
        SqlCommand command;

        public AdminQLDA()
        {
            InitializeComponent();
        }

        private void AdminQLDA_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            refreshDGV();
        }

        public void refreshDGV()
        {
            query = "select * from QLSP";
            command = new SqlCommand(query, conn);
            SqlDataAdapter adt = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adt.Fill(dataTable);
            dgvProduct.DataSource = dataTable;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMado.Enabled = false;
            tbTendo.Enabled = false;
            cbLoai.DropDownStyle = ComboBoxStyle.DropDown;
            cbLoai.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            tbMado.Text = dgvProduct.SelectedCells[0].Value.ToString();
            tbTendo.Text = dgvProduct.SelectedCells[1].Value.ToString();
            tbGia.Text = dgvProduct.SelectedCells[2].Value.ToString();
            cbLoai.Text = dgvProduct.SelectedCells[3].Value.ToString();
            cbLoai.SelectedIndex = 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMado.Enabled == false)
            {
                btnClear_Click(sender, e);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                tbMado.Enabled = true;
                tbTendo.Enabled = true;
                cbLoai.DropDownStyle = ComboBoxStyle.DropDownList;
                cbLoai.Enabled = true;
                tbMado.Focus();
            }
            else
            {
                query = "insert into QLSP values (@mado, @tendo, @gia, @loai, 0)";
                if (checkNull())
                {
                    try
                    {
                        command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@mado", tbMado.Text);
                        command.Parameters.AddWithValue("@tendo", tbTendo.Text);
                        command.Parameters.AddWithValue("@gia", int.Parse(tbGia.Text));
                        command.Parameters.AddWithValue("@loai", cbLoai.Text);
                        command.ExecuteNonQuery();
                        refreshDGV();
                        btnClear_Click(sender, e);
                        tbMado.Enabled = false;
                        tbTendo.Enabled = false;
                        cbLoai.DropDownStyle = ComboBoxStyle.DropDown;
                        cbLoai.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Du lieu khong hop le", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMado.Text = "";
            tbTendo.Text = "";
            tbGia.Text = "";
            cbLoai.Text = "";
            cbLoai.SelectedIndex = -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            query = "delete from QLSP where MAP = @mado";
            command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@mado", tbMado.Text);
            command.ExecuteNonQuery();
            refreshDGV();
            btnClear_Click(sender, e);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            query = "update QLSP set Gia = @gia where MAP = @mado";
            if (checkNull())
            {
                try
                {
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@gia", int.Parse(tbGia.Text));
                    command.Parameters.AddWithValue("@mado", tbMado.Text);
                    command.ExecuteNonQuery();
                    refreshDGV();
                    btnClear_Click(sender, e);
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Du lieu khong hop le!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool checkNull()
        {
            if (tbMado.Text.Trim() == "" || tbTendo.Text.Trim() == "" || tbGia.Text.Trim() == "" || cbLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ dữ liệu!", "Error", MessageBoxButtons.OK);
                return false;
            }
            else
                return true;
        }
    }
}
