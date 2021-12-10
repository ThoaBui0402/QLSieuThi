using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSieuThi.Controller;
using QLSieuThi.View;
using QLSieuThi.Bus;
namespace QLSieuThi.View
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        private void btnSearch_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" && txtTenHang.Text == "" && cbLoai.Text == "" && cbMaQuay.Text == "" && txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng cần tìm");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng cần tìm");
                if (cbLoai.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa có loại sản phẩm cần tìm");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy cần tìm");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có mã nhà cung cấp cần tìm");
                MessageBox.Show("Nhập vào thông tin cần tìm");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            dgvMatHang.DataSource = MatHangControllercs.Instance.SearchMatHang(txtMaHang.Text, txtTenHang.Text, cbLoai.Text, cbMaQuay.Text, txtMaNCC.Text);
        }
        void ViewMatHang()
        {
            dgvMatHang.DataSource = MatHangControllercs.Instance.XemMatHang();
            dgvMatHang.Columns["ma"].HeaderText = @"Mã";
            dgvMatHang.Columns["ma"].Width = 45;
            dgvMatHang.Columns["ten"].HeaderText = @"Tên mặt hàng";
            dgvMatHang.Columns["ten"].Width = 80;
            dgvMatHang.Columns["loaimathang"].HeaderText = @"Loại mặt hàng";
            dgvMatHang.Columns["loaimathang"].Width = 60;
            dgvMatHang.Columns["donvitinh"].HeaderText = @"Đơn vị tính";
            dgvMatHang.Columns["donvitinh"].Width = 60;
            dgvMatHang.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvMatHang.Columns["maquay"].Width = 60;

            dgvMatHang.Columns["manhacc"].Width = 60;
            dgvMatHang.Columns["gia"].Width = 60;
        }

        private void btnView_MH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewMatHang();
        }

        private void menuHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.ShowDialog();
        }

      

        private void btnInsert_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || cbDonViTinh.Text == "" || cbLoai.Text == "" || txtGiaMh.Text == "" || cbMaQuay.Text == "" || txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa phân loại hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbDonViTinh, "Chưa có đơn vị tính");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có nhà cung cấp");
                if (txtGiaMh.Text == "")
                    errorProvider1.SetError(txtGiaMh, "Chưa có giá mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHang.Text;
                string ten = txtTenHang.Text;
                string loai = cbLoai.Text;
                string donvt = cbDonViTinh.Text;
                string maquay = cbMaQuay.Text;
                string mancc = txtMaNCC.Text;
                float gia = (float)Convert.ToDouble(txtGiaMh.Text);

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (MatHangControllercs.Instance.InsertMatHang(ma, ten, loai, donvt, maquay, mancc, gia))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewMatHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        private void btnUpdate_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || cbDonViTinh.Text == "" || cbLoai.Text == "" || txtGiaMh.Text == "" || cbMaQuay.Text == "" || txtMaNCC.Text == "")
            {
                if (txtMaHang.Text == "")
                    errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                if (txtTenHang.Text == "")
                    errorProvider1.SetError(txtTenHang, "Chưa có tên hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbLoai, "Chưa phân loại hàng");
                if (cbDonViTinh.Text == "")
                    errorProvider1.SetError(cbDonViTinh, "Chưa có đơn vị tính");
                if (cbMaQuay.Text == "")
                    errorProvider1.SetError(cbMaQuay, "Chưa có mã quầy");
                if (txtMaNCC.Text == "")
                    errorProvider1.SetError(txtMaNCC, "Chưa có nhà cung cấp");
                if (txtGiaMh.Text == "")
                    errorProvider1.SetError(txtGiaMh, "Chưa có giá mặt hàng");
                MessageBox.Show("Nhập thông tin đầy đủ");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHang.Text;
                string ten = txtTenHang.Text;
                string loai = cbLoai.Text;
                string donvt = cbDonViTinh.Text;
                string maquay = cbMaQuay.Text;
                string mancc = txtMaNCC.Text;
                float gia = (float)Convert.ToDouble(txtGiaMh.Text);

                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (MatHangControllercs.Instance.UpdateMatHang(ma, ten, loai, donvt, maquay, mancc, gia))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewMatHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        private void btnDelete_MH_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                errorProvider1.SetError(txtMaHang, "Chưa có mã hàng");
                MessageBox.Show("Nhập vào mã cần xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa hay không", "xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MatHangControllercs.Instance.DeleteMatHang(txtMaHang.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    ViewMatHang();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }

        private void btnExit_MH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //nhà sản xuất

        private void btnSearch_NSX_Click(object sender, EventArgs e)
        {
            if (txtNCC.Text == "" && txtTenNCC.Text == "")
            {
                if (txtNCC.Text == "")
                    errorProvider1.SetError(txtNCC, "Chưa có mã cần tìm");
                if (txtTenNCC.Text == "")
                    errorProvider1.SetError(txtTenNCC, "Chưa có tên cần tìm");
                MessageBox.Show("Nhập vào thông tin cần tìm");
                return;
            }
            dgvNSX.DataSource = NhaCCController.Instance.SearchNhaCC(txtNCC.Text, txtTenNCC.Text);
        }

        private void btnView_NSX_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewNhaSanXuat();
        }
        void ViewNhaSanXuat()
        {
            dgvNSX.DataSource = NhaCCController.Instance.XemNhaCC();
            dgvNSX.Columns["ma"].HeaderText = @"Mã ncc";
            dgvNSX.Columns["ma"].Width = 45;
            dgvNSX.Columns["ten"].HeaderText = @"Tên ncc";
            dgvNSX.Columns["ten"].Width = 80;
            dgvNSX.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvNSX.Columns["diachi"].Width = 100;
            dgvNSX.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvNSX.Columns["sodienthoai"].Width = 50;
            dgvNSX.Columns["email"].HeaderText = @"Email";
            dgvNSX.Columns["email"].Width = 100;
        }

        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNCC.Text = dgvNSX.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNSX.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNCC.Text = dgvNSX.CurrentRow.Cells[2].Value.ToString();
            txtDienThoaiNCC.Text = dgvNSX.CurrentRow.Cells[3].Value.ToString();
            txtEmailNCC.Text = dgvNSX.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnInsert_NSX_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtDienThoaiNCC.Text == "" || txtDiaChiNCC.Text == "")
            {
                if (txtNCC.Text == "")
                    errorProvider1.SetError(txtNCC, "Chưa nhập mã nhà cung cấp");
                if (txtTenNCC.Text == "")
                    errorProvider1.SetError(txtTenNCC, "Chưa nhập tên nhà cung cấp");
                if (txtDienThoaiNCC.Text == "")
                    errorProvider1.SetError(txtDienThoaiNCC, "Chưa nhập số điện thoại");
                if (txtEmailNCC.Text == "")
                    errorProvider1.SetError(txtEmailNCC, "Chưa nhập email");
                if (txtDiaChiNCC.Text == "")
                    errorProvider1.SetError(txtDiaChiNCC, "Chưa nhập địa chỉ");
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtNCC.Text;
                string ten = txtTenNCC.Text;
                string sdt = txtDienThoaiNCC.Text;
                string email = txtEmailNCC.Text;
                string diachi = txtDiaChiNCC.Text;
                if (MessageBox.Show("Bạn có muốn Thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhaCCController.Instance.InsertNhaCC(ma, ten, diachi, sdt, email))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }

        private void btnUpdate_NSX_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChiNCC.Text == "" || txtDienThoaiNCC.Text == "" || txtDiaChiNCC.Text == "")
            {
                if (txtNCC.Text == "")
                    errorProvider1.SetError(txtNCC, "Chưa nhập mã nhà cung cấp");
                if (txtTenNCC.Text == "")
                    errorProvider1.SetError(txtTenNCC, "Chưa nhập tên nhà cung cấp");
                if (txtDienThoaiNCC.Text == "")
                    errorProvider1.SetError(txtDienThoaiNCC, "Chưa nhập số điện thoại");
                if (txtEmailNCC.Text == "")
                    errorProvider1.SetError(txtEmailNCC, "Chưa nhập email");
                if (txtDiaChiNCC.Text == "")
                    errorProvider1.SetError(txtDiaChiNCC, "Chưa nhập địa chỉ");
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtNCC.Text;
                string ten = txtTenNCC.Text;
                string sdt = txtDienThoaiNCC.Text;
                string email = txtEmailNCC.Text;
                string diachi = txtDiaChiNCC.Text;
                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhaCCController.Instance.UpdateNhaCC(ma, ten, diachi, sdt, email))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
            }
        }

        private void btnDelete_NSX_Click(object sender, EventArgs e)
        {
            if (txtNCC.Text == "")
            {
                errorProvider1.SetError(txtNCC, "Chưa có mã cần xóa");
                MessageBox.Show("Nhập mã cần xóa");
                return;
            }
            try
            {
                string ma = txtNCC.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhaCCController.Instance.DeleteNhaCC(ma))
                    {
                        MessageBox.Show("Xóa thành công");
                        ViewNhaSanXuat();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        private void btnExit_NSX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
