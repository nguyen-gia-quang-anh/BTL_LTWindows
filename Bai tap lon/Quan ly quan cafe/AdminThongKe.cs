using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_ly_quan_cafe
{
    public partial class AdminThongKe : UserControl
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1SBS0S1\\SQLEXPRESS;Initial Catalog = QLCoffee;" +
                                                        "Integrated Security=True");


        public AdminThongKe()
        {
            InitializeComponent();
        }

        private void btnDoAn_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong biểu đồ
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            if (cbLoaiThongKe.SelectedItem.ToString() == "Ngày")
            {
                // Lấy giá trị ngày
                DateTime LayNgay = dateThangNam.Value;
                
                // lấy dữ liệu từ CSDL
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT QLSP.TenP, SUM(CHITIETHOADON.SL) AS TongSoLuong" +
                    " FROM CHITIETHOADON " +
                    "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                    "WHERE HOADON.NgayLapHD = '"+LayNgay+"'AND QLSP.Loai = N'Đồ ăn' " +
                    "GROUP BY QLSP.TenP", conn);
                conn.Open();
                adapter.Fill(dt);
                conn.Close();
                // Đặt tên cho trục X và Y
                chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên loại đồ";
                chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                // Đưa ra mỗi tên cho trục X ( tránh trường hợp cột không có tên SP
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                // Đưa dữ liệu lên biểu đồ
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart.Series["ThongKe"].Points.AddXY(dt.Rows[i]["TenP"], dt.Rows[i]["TongSoLuong"]);
                }
                
            }

            else
            {
                
                if (cbLoaiThongKe.SelectedItem.ToString() == "Tháng")
                {
                    // Lấy ngày tháng
                    DateTime LayThang = dateThangNam.Value;
                    int Thang = LayThang.Month;
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    // Lấy dữ liệu từ CSDL
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT QLSP.TenP, SUM(CHITIETHOADON.SL) AS TongSoLuong " +
                        "FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE MONTH(HOADON.NgayLapHD) = '" + Thang + "' AND YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ ăn' " +
                        "GROUP BY QLSP.TenP", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    conn.Close();
                    // Đặt tên cho cột X và Y
                    chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên loại đồ";
                    chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                    // Đưa ra mỗi tên cho cột X
                    chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    // Đưa dữ liệu vào biểu đồ
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        chart.Series["ThongKe"].Points.AddXY(dt.Rows[i]["TenP"], dt.Rows[i]["TongSoLuong"]);
                    }
                    
                }
                else
                {
                    if (cbLoaiThongKe.SelectedItem.ToString() == "Năm")
                    {
                        DateTime LayNam = dateThangNam.Value;
                        int Nam = LayNam.Year;
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT QLSP.TenP, SUM(CHITIETHOADON.SL) AS TongSoLuong" +
                            " FROM CHITIETHOADON " +
                            "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD" +
                            " WHERE YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ ăn'" +
                            " GROUP BY QLSP.TenP", conn);
                        conn.Open();
                        adapter.Fill(dt);
                        conn.Close();
                        chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên loại đồ";
                        chart.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng";
                        chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            chart.Series["ThongKe"].Points.AddXY(dt.Rows[i]["TenP"], dt.Rows[i]["TongSoLuong"]);
                        }
                        
                    }
                }
            }
           
        }

        private void btnDoUong_Click(object sender, EventArgs e)
        {
            // clear biểu đồ
            // Tạo ra một vòng lặp duyệt qua tất cả các điểm của biểu đồ
            foreach (var series in chart.Series)
            {
                series.Points.Clear(); // xóa dữ liệu từng điểm của biểu đồ
            }
            if (cbLoaiThongKe.SelectedItem.ToString() == "Ngày") // Nếu giá trị chọn combobox là ngày
            {
                DateTime LayNgay = dateThangNam.Value; //  Lấy giá trị ở datetimepicker
                
                DataTable dt = new DataTable(); // Khởi tạo một datetable để chứa dữ liệu từ câu lệnh SQL
                // Khởi tạo một adapter để để truy vấn câu lệnh SQL
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT QLSP.TenP, SUM(CHITIETHOADON.SL) AS TongSoLuong " +
                    "FROM CHITIETHOADON " +
                    "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD" +
                    " WHERE HOADON.NgayLapHD = '"+LayNgay+"'  AND QLSP.Loai = N'Đồ uống'" +
                    " GROUP BY QLSP.TenP", conn);
                conn.Open(); // Kết nối với CSDL
                adapter.Fill(dt); // Lấy dữ liệu từ CSDL để đưa vào dataTable
                conn.Close(); // Sau khi lấy dữ liệu thì đóng CSDL
                chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên loại đồ"; // Đặt tên cho trục X
                chart.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng";// Đặt tên cho trục Y
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 1; // Để hiển thị mỗi tên cho trục X
                for (int i = 0; i < dt.Rows.Count; i++) // Tạo vòng lặp duyệt qua từng hàng trong dataTable
                {
                    // Lấy giá trị của hàng thứ i cột TenP để đưa vào trục X và cột TongThanhTien đưa vào cột Y
                    chart.Series["ThongKe"].Points.AddXY(dt.Rows[i]["TenP"], dt.Rows[i]["TongSoLuong"]);
                    // ThongKe là tên của biểu đồ
                }
                
            }
            else
            {
                if (cbLoaiThongKe.SelectedItem.ToString() == "Tháng")
                {
                    // Lấy giá trị của Tháng và Năm trong dateTimepicker
                    DateTime LayThang = dateThangNam.Value;
                    int Thang = LayThang.Month;
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    // Khởi tạo datatable để chứa dữ liệu từ CSDL
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT QLSP.TenP, SUM(CHITIETHOADON.SL) AS TongSoLuong" +
                        " FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE MONTH(HOADON.NgayLapHD) = '" + Thang + "' AND YEAR(HOADON.NgayLapHD) = '" + Nam + "'  AND QLSP.Loai = N'Đồ uống'" +
                        " GROUP BY QLSP.TenP", conn);
                    conn.Open();
                    adapter.Fill(dt);
                    conn.Close();
                    // Đặt tên trục X và Y
                    chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên loại đồ";
                    chart.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng";
                    // Đưa ra mỗi tên cho trục X
                    chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        // Lấy giá trị của hàng thứ i cột TenP để đưa vào trục X và cột TongThanhTien đưa vào cột Y
                        chart.Series["ThongKe"].Points.AddXY(dt.Rows[i]["TenP"], dt.Rows[i]["TongSoLuong"]);
                    }
                    
                }
                else
                {
                    if (cbLoaiThongKe.SelectedItem.ToString() == "Năm")
                    {
                        // Lấy giá trị năm
                        DateTime LayNam = dateThangNam.Value;
                        int Nam = LayNam.Year;
                        // lấy dữ liệu từ CSDL
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT QLSP.TenP, SUM(CHITIETHOADON.SL) AS TongSoLuong" +
                            " FROM CHITIETHOADON" +
                            " JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                            "WHERE YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ uống' " +
                            "GROUP BY QLSP.TenP", conn);
                        conn.Open();
                        adapter.Fill(dt);
                        conn.Close();
                        // Đặt tên trục X và Y
                        chart.ChartAreas["ChartArea1"].AxisX.Title = "Tên loại đồ";
                        chart.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
                        // Đưa ra mỗi tên cho trục X
                        chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                        // Đưa giá trị vào biểu đồ
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            chart.Series["ThongKe"].Points.AddXY(dt.Rows[i]["TenP"], dt.Rows[i]["TongSoLuong"]);
                        }
                        
                    }
                }
            }
           
        }

        private void cbLoaiThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateThangNam.Enabled = true;
        }

        private void dateThangNam_ValueChanged(object sender, EventArgs e)
        {
            btnDoUong.Enabled = true;
            btnDoAn.Enabled = true;
            // Lấy tổng số tiền của tất cả sản phẩm
            if (cbLoaiThongKe.SelectedItem.ToString() == "Ngày")
            {
                DateTime LayNgay = dateThangNam.Value;
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                    "FROM CHITIETHOADON " +
                    "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                    "WHERE HOADON.NgayLapHD = '" + LayNgay + "'", conn);
                conn.Open();
                adapter1.Fill(dt1);
                conn.Close();
                object value = dt1.Rows[0][0];
                lbTongDoanhThu.Text = value.ToString();
            }
            else
            {
                if (cbLoaiThongKe.SelectedItem.ToString() == "Tháng")
                {
                    DateTime LayThang = dateThangNam.Value;
                    int Thang = LayThang.Month;
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                        "FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE MONTH(HOADON.NgayLapHD) = '" + Thang + "' AND YEAR(HOADON.NgayLapHD) = '"+Nam+"'", conn);
                    conn.Open();
                    adapter1.Fill(dt1);
                    conn.Close();
                    object value = dt1.Rows[0][0];
                    lbTongDoanhThu.Text = value.ToString() ;
                }
                else
                {                 
                    if(cbLoaiThongKe.SelectedItem.ToString() == "Năm")
                    {
                        DateTime LayNam = dateThangNam.Value;
                        int Nam = LayNam.Year;
                        DataTable dt1 = new DataTable();
                        SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                            "FROM CHITIETHOADON " +
                            "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                            "WHERE YEAR(HOADON.NgayLapHD) = '" + Nam + "'", conn);
                        conn.Open();
                        adapter1.Fill(dt1);
                        conn.Close();
                        object value = dt1.Rows[0][0];
                        lbTongDoanhThu.Text = value.ToString() ;
                    }
                }
            }
            // Lấy Doanh thu của đồ ăn
            if (cbLoaiThongKe.SelectedItem.ToString() == "Ngày")
            {
                DateTime LayNgay = dateThangNam.Value;
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                    "FROM CHITIETHOADON " +
                    "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                    "WHERE HOADON.NgayLapHD = '" + LayNgay + "' AND QLSP.Loai = N'Đồ ăn'", conn);
                conn.Open();
                adapter1.Fill(dt1);
                conn.Close();
                object value = dt1.Rows[0][0];
                lbDoanhThuDoAn.Text = value.ToString() ;
            }
            else
            {
                if (cbLoaiThongKe.SelectedItem.ToString() == "Tháng")
                {
                    DateTime LayThang = dateThangNam.Value;
                    int Thang = LayThang.Month;
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                        "FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE MONTH(HOADON.NgayLapHD) = '" + Thang + "' AND YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ ăn'", conn);
                    conn.Open();
                    adapter1.Fill(dt1);
                    conn.Close();
                    object value = dt1.Rows[0][0];
                    lbDoanhThuDoAn.Text = value.ToString();
                }
                else
                {
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                        "FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ ăn'", conn);
                    conn.Open();
                    adapter1.Fill(dt1);
                    conn.Close();
                    object value = dt1.Rows[0][0];
                    lbDoanhThuDoAn.Text = value.ToString();
                }
            }

            // Lấy doanh thu đồ uống
            if (cbLoaiThongKe.SelectedItem.ToString() == "Ngày")
            {
                DateTime LayNgay = dateThangNam.Value;
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                    "FROM CHITIETHOADON " +
                    "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                    "WHERE HOADON.NgayLapHD = '" + LayNgay + "' AND QLSP.Loai = N'Đồ uống'", conn);
                conn.Open();
                adapter1.Fill(dt1);
                conn.Close();
                object value = dt1.Rows[0][0];
                lbDoanhThuDoUong.Text = value.ToString();
            }
            else
            {
                if (cbLoaiThongKe.SelectedItem.ToString() == "Tháng")
                {
                    DateTime LayThang = dateThangNam.Value;
                    int Thang = LayThang.Month;
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                        "FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE MONTH(HOADON.NgayLapHD) = '" + Thang + "' AND YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ uống'", conn);
                    conn.Open();
                    adapter1.Fill(dt1);
                    conn.Close();
                    object value = dt1.Rows[0][0];
                    lbDoanhThuDoUong.Text = value.ToString();
                }
                else
                {
                    DateTime LayNam = dateThangNam.Value;
                    int Nam = LayNam.Year;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT SUM(CHITIETHOADON.ThanhTien) AS TongTien " +
                        "FROM CHITIETHOADON " +
                        "JOIN QLSP ON CHITIETHOADON.MAP = QLSP.MAP JOIN HOADON ON CHITIETHOADON.MHD = HOADON.MHD " +
                        "WHERE YEAR(HOADON.NgayLapHD) = '" + Nam + "' AND QLSP.Loai = N'Đồ uống'", conn);
                    conn.Open();
                    adapter1.Fill(dt1);
                    conn.Close();
                    object value = dt1.Rows[0][0];
                    lbDoanhThuDoUong.Text = value.ToString() + " Đồng";
                }
            }
        }
    }
}
