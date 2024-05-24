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

namespace BTL_QLNV
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-3CLN13P2;Initial Catalog=QLCongTy;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();

        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongTinNhanVien";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgv1.DataSource = table1;
        }

        void loaddata2()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongTinPhongBan";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgv2.DataSource = table2;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv1.CurrentRow.Index;
            tb_manv.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tb_tennv.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            dtime_ngaysinh.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            cb_gioitinh.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            tb_chucvu.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            tb_tienluong.Text = dgv1.Rows[i].Cells[5].Value.ToString();
            tb_mapb1.Text = dgv1.Rows[i].Cells[6].Value.ToString();
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv2.CurrentRow.Index;
            tb_mapb2.Text = dgv2.Rows[i].Cells[0].Value.ToString();
            tb_tenpb.Text = dgv2.Rows[i].Cells[1].Value.ToString();
            tb_diachi.Text = dgv2.Rows[i].Cells[2].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
            loaddata2();
        }

        private void bt_them1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO ThongTinNhanVien VALUES (@Manv, @Tennv, @Ngaysinh, @Gioitinh, @Chucvu, @Tienluong, @Mapb)";

            // Assuming connection is already open
            command.Parameters.AddWithValue("@Manv", tb_manv.Text);
            command.Parameters.AddWithValue("@Tennv", tb_tennv.Text);
            command.Parameters.AddWithValue("@Ngaysinh", DateTime.Parse(dtime_ngaysinh.Text)); // Assuming dtime_ngaysinh is a DateTimePicker
            command.Parameters.AddWithValue("@Gioitinh", cb_gioitinh.Text);
            command.Parameters.AddWithValue("@Chucvu", tb_chucvu.Text);
            command.Parameters.AddWithValue("@Tienluong", tb_tienluong.Text);
            command.Parameters.AddWithValue("@Mapb", tb_mapb1.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Nhân viên đã được thêm thành công.");
            loaddata1();
        }

        private void cb_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_xoa1_Click(object sender, EventArgs e)
        {
            // Check if a valid employee ID is selected
            if (string.IsNullOrEmpty(tb_manv.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên để xóa.");
                return;
            }

            // Ask for confirmation before deleting
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM ThongTinNhanVien WHERE MaNV = @MaNV";
                command.Parameters.AddWithValue("@MaNV", tb_manv.Text);

                // Execute the deletion command
                command.ExecuteNonQuery();
                MessageBox.Show("Nhân viên đã được xóa thành công.");

                // Reload data after deletion
                loaddata1();
            }
         }

        private void bt_sua1_Click(object sender, EventArgs e)
        {
            // Check if a valid employee ID is selected
            if (string.IsNullOrEmpty(tb_manv.Text))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên để sửa.");
                return;
            }

            // Ask for confirmation before updating
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin nhân viên này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "UPDATE ThongTinNhanVien SET TenNV = @TenNV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, ChucVu = @ChucVu, TienLuong = @TienLuong ,MaPB = @MaPB WHERE MaNV = @MaNV";

                // Assuming connection is already open
                command.Parameters.AddWithValue("@TenNV", tb_tennv.Text);
                command.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtime_ngaysinh.Text)); // Assuming dtime_ngaysinh is a DateTimePicker
                command.Parameters.AddWithValue("@GioiTinh", cb_gioitinh.Text);
                command.Parameters.AddWithValue("@ChucVu", tb_chucvu.Text);
                command.Parameters.AddWithValue("@TienLuong", tb_tienluong.Text);
                command.Parameters.AddWithValue("@MaPB", tb_mapb1.Text);
                command.Parameters.AddWithValue("@MaNV", tb_manv.Text);


                // Execute the update command
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công.");

                    // Reload data after updating
                    loaddata1();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã: " + tb_manv.Text);
                }
            }
        }

        private void bt_khoitao1_Click(object sender, EventArgs e)
        {
            tb_manv.Text = "";
            tb_tennv.Text = "";
            dtime_ngaysinh.Value = DateTime.Today; // Resetting date to today's date
            cb_gioitinh.SelectedIndex = -1; // Reset gender selection
            tb_chucvu.Text = "";
            tb_tienluong.Text = "";
            tb_mapb1.Text = "";
        }

        private void bt_them2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường dữ liệu đã được nhập đầy đủ chưa
            if (string.IsNullOrEmpty(tb_mapb2.Text) || string.IsNullOrEmpty(tb_tenpb.Text) || string.IsNullOrEmpty(tb_diachi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm phòng ban mới.");
                return;
            }

            // Tạo câu lệnh SQL để thêm phòng ban mới vào cơ sở dữ liệu
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO ThongTinPhongBan VALUES (@MaPB, @TenPB, @DiaChi)";

            // Thêm các tham số vào câu lệnh SQL
            command.Parameters.AddWithValue("@MaPB", tb_mapb2.Text);
            command.Parameters.AddWithValue("@TenPB", tb_tenpb.Text);
            command.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);

            // Thực thi câu lệnh SQL để thêm dữ liệu mới
            command.ExecuteNonQuery();
            MessageBox.Show("Phòng ban mới đã được thêm thành công.");

            // Tải lại dữ liệu cho bảng ThongTinPhongBan
            loaddata2();
        }

        private void bt_sua2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem một phòng ban nào đó đã được chọn hay chưa
            if (string.IsNullOrEmpty(tb_mapb2.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phòng ban để sửa.");
                return;
            }

            // Xác nhận với người dùng trước khi cập nhật
            DialogResult result = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin phòng ban này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                command.CommandText = "UPDATE ThongTinPhongBan SET TenPB = @TenPB, DiaChi = @DiaChi WHERE MaPB = @MaPB";

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@TenPB", tb_tenpb.Text);
                command.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                command.Parameters.AddWithValue("@MaPB", tb_mapb2.Text);

                // Thực thi câu lệnh SQL để cập nhật thông tin
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin phòng ban đã được cập nhật thành công.");

                    // Tải lại dữ liệu cho bảng ThongTinPhongBan
                    loaddata2();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng ban có mã: " + tb_mapb2.Text);
                }
            }
        }

        private void bt_xoa2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem một phòng ban nào đó đã được chọn hay không 
            if (string.IsNullOrEmpty(tb_mapb2.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phòng ban để xóa.");
                return;
            }

            // Xác nhận với người dùng trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phòng ban này? Tất cả nhân viên trong phòng ban này cũng sẽ bị xóa.", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    command = connection.CreateCommand();

                    // Begin a transaction
                    SqlTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;

                    // First, delete employees in the department
                    command.CommandText = "DELETE FROM ThongTinNhanVien WHERE MaPB = @MaPB1";
                    command.Parameters.AddWithValue("@MaPB1", tb_mapb2.Text);
                    command.ExecuteNonQuery();
                    command.Parameters.RemoveAt("@MaPB1"); // Remove parameter after use

                    // Then, delete the department
                    command.CommandText = "DELETE FROM ThongTinPhongBan WHERE MaPB = @MaPB2";
                    command.Parameters.AddWithValue("@MaPB2", tb_mapb2.Text);
                    command.ExecuteNonQuery();
                    command.Parameters.RemoveAt("@MaPB2"); // Remove parameter after use

                    // Commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Phòng ban và tất cả nhân viên trong phòng ban đã được xóa thành công.");

                    // Tải lại dữ liệu cho bảng ThongTinPhongBan
                    loaddata2();
                    // Tải lại dữ liệu cho bảng ThongTinNhanVien
                    loaddata1();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }




        private void bt_khoitao2_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu đang có
            tb_mapb2.Text = "";
            tb_tenpb.Text = "";
            tb_diachi.Text = "";
        }
    }
        }
