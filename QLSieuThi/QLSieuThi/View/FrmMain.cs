using QL.Views;
using QLSieuThi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntHangHoa_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            f.Show();
        }

        private void bntKH_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.Show();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.Show();
        }

        private void bntNhanvien_Click(object sender, EventArgs e)
        {
            
        }

        private void bntdangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuHangHoa_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            f.Show();
        }
    }
}
