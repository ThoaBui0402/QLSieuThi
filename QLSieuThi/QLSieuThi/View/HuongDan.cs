using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSieuThi.View
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            HDDangNhap frm2 = new HDDangNhap();
            frm2.TopLevel = false;
            panel1.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "dangnhap")
            {
                panel1.Controls.Clear();
                HDDangNhap frm2 = new HDDangNhap();
                frm2.TopLevel = false;
                panel1.Controls.Add(frm2);
                frm2.Dock = DockStyle.Fill;
                frm2.Show();

            }
            else

            if (e.Node.Name == "khachhang")
            {
                panel1.Controls.Clear();
                HDKhachHang frm2 = new HDKhachHang();
                frm2.TopLevel = false;
                panel1.Controls.Add(frm2);
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
            }
            else

            if (e.Node.Name == "nhanvien")
            {
                panel1.Controls.Clear();
                HDNhanVien frm2 = new HDNhanVien();
                frm2.TopLevel = false;
                panel1.Controls.Add(frm2);
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
            }
            else
            if (e.Node.Name == "hanghoa")
            {
                panel1.Controls.Clear();
                HDHangHoa frm2 = new HDHangHoa();
                frm2.TopLevel = false;
                panel1.Controls.Add(frm2);
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
            }

        }
    }
}
