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
            dgvMatHang.DataSource = MatHangController.Instance.SearchMatHang(txtMaHang.Text, txtTenHang.Text, cbLoai.Text, cbMaQuay.Text, txtMaNCC.Text);
        }
        void ViewMatHang()
        {
            dgvMatHang.DataSource = MatHangController.Instance.XemMatHang();
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
    }
}
