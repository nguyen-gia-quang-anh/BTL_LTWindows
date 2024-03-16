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
    public partial class AdminQLNV : UserControl
    {
        // Khoi tao chuoi ket noi
        string connectionString = "Data Source=quanhlap;Initial Catalog=QLCoffee;Integrated Security=True";
        SqlConnection conn = null;
        DataTable dtTB_QLNV;
        SqlDataAdapter adptQLNV;
        public AdminQLNV()
        {
            InitializeComponent();
        }


        // Day du lieu len dgv
        private void AdminQLNV_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connectionString);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    MessageBox.Show("Ok", "info", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi CSDL that bai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string sqlSelect = "select MNV, TNV as 'Tên', SDT as 'SĐT', Ngaysinh as 'Ngày sinh', Diachi as 'Địa chỉ', Gioitinh as 'Giới tính', Chucvu as 'Chức vụ', username, pass as 'Password' from QLNV ";
            adptQLNV = new SqlDataAdapter(sqlSelect, conn);
            dtTB_QLNV = new DataTable();
            adptQLNV.Fill(dtTB_QLNV);
            dgvNhanVien.DataSource = dtTB_QLNV;

        }


        // Chuc nang them nhan vien
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbMNV.Enabled == false)
            {
                ClearFields();
                return;
            }
            if (tbMNV.Text.Trim() == "" || tbTNV.Text.Trim() == "" || tbDChi.Text.Trim() == "" || tbSDT.Text.Trim() == "" ||
                cBGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap day du cac turong thong tin", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string sdt = "0" + (Convert.ToInt32(tbSDT.Text.Trim())).ToString();
                    if (sdt.Length == 10)
                    {

                        Console.WriteLine(sdt);
                        string sql_insert = "insert into QLNV (MNV, TNV, SDT, Ngaysinh, Diachi, Gioitinh, username) " +
                            "values ('" + tbMNV.Text.Trim() + "',N'" + tbTNV.Text.Trim() + "','" + sdt + "', '" + dTPNgaySinh.Text.Trim() + "',N'" + tbDChi.Text.Trim() + "',N'" + cBGioiTinh.Text.Trim() + "','" + tbMNV.Text.Trim() + "')";

                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = sql_insert;
                            cmd.Connection = conn;

                            try
                            {
                                cmd.ExecuteNonQuery();
                                dtTB_QLNV.Rows.Clear();
                                adptQLNV.Fill(dtTB_QLNV);
                                dgvNhanVien.DataSource = dtTB_QLNV;
                                MessageBox.Show("Them nhan vien thanh cong");
                                ClearFields();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ma nhan vien da ton tai");
                                tbMNV.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("SDT khong hop le", "Error", MessageBoxButtons.OK);
                        tbSDT.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SDT khong hop le", "Error", MessageBoxButtons.OK);
                    tbSDT.Focus();
                }


            }
        }


        // Hien thi thong tin khi nhan vao nhan vien
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMNV.Enabled = false;
            try
            {
                using (DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex])
                {
                    tbMNV.Text = row.Cells[0].Value.ToString();
                    tbTNV.Text = row.Cells[1].Value.ToString();
                    tbDChi.Text = row.Cells[4].Value.ToString();
                    tbSDT.Text = row.Cells[2].Value.ToString();
                    dTPNgaySinh.Text = row.Cells[3].Value.ToString();
                    cBGioiTinh.DropDownStyle = ComboBoxStyle.DropDown;
                    cBGioiTinh.Text = row.Cells[5].Value.ToString();
                    cBGioiTinh.Enabled = false;
                    //cBGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {

            }
        }


        // Chuc nang xoa nhan vien
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from QLNV where MNV = '" + tbMNV.Text.Trim() + "'";

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlDelete;
                cmd.Connection = conn;
                try
                {
                    cmd.ExecuteNonQuery();
                    dtTB_QLNV.Rows.Clear();
                    adptQLNV.Fill(dtTB_QLNV);
                    dgvNhanVien.DataSource = dtTB_QLNV;

                    MessageBox.Show("Xoa thanh cong", "info", MessageBoxButtons.OK);
                    ClearFields();
                }
                catch (Exception ex)
                {

                }
            }

        }


        // Chức năng sửa nhân viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbMNV.Enabled == false)
            {
                if (tbMNV.Text.Trim() == "" || tbTNV.Text.Trim() == "" ||
                    tbDChi.Text.Trim() == "" || tbSDT.Text.Trim() == "" ||
                    cBGioiTinh.Text.Trim() == "")
                {
                    MessageBox.Show("Vui long nhap day du cac turong thong tin", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    // Kiem tra SDT hop le
                    try
                    {

                        string sdt = "0" + (Convert.ToInt32(tbSDT.Text.Trim())).ToString();

                        if (sdt.Length == 10)
                        {

                            Console.WriteLine(sdt);
                            // Lenh cap nhat du lieu
                            string sqlUpdate = "update QLNV set TNV = N'" + tbTNV.Text.Trim() + "', SDT = '" + sdt + "' , " +
                                    "Ngaysinh = '" + dTPNgaySinh.Text.Trim() + "', Diachi = N'" + tbDChi.Text.Trim() + "' where MNV = '" + tbMNV.Text.Trim() + "'";

                            using (SqlCommand cmd = new SqlCommand())
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = sqlUpdate;
                                cmd.Connection = conn;

                                try
                                {
                                    // thuc hien SQL va Update du lieu len dgv
                                    cmd.ExecuteNonQuery();
                                    dtTB_QLNV.Rows.Clear();
                                    adptQLNV.Fill(dtTB_QLNV);
                                    dgvNhanVien.DataSource = dtTB_QLNV;
                                    MessageBox.Show("Sua thong tin thanh cong");
                                    ClearFields();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Sua thong tin that bai");

                                }
                            }
                        }

                        // tra ve loi
                        else
                        {
                            MessageBox.Show("SDT khong hop le", "Error", MessageBoxButtons.OK);
                            tbSDT.Focus();
                        }
                    }
                    // tra ve loi
                    catch (Exception ex)
                    {
                        MessageBox.Show("SDT khong hop le", "Error", MessageBoxButtons.OK);
                        tbSDT.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui long chon 1 nhan vien de sua", "Error", MessageBoxButtons.OK);
            }
        }



        // Chức năng reset các trường
        void ClearFields()
        {
            tbMNV.Text = tbDChi.Text = tbSDT.Text = tbTNV.Text = "";
            tbMNV.Enabled = cBGioiTinh.Enabled = true;
            cBGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            dTPNgaySinh.Value = DateTime.Now;
        }

        // Nút clear để reset các fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
