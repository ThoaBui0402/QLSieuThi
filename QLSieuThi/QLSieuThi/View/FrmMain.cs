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
          private void btnkhachhang_Click(object sender, EventArgs e)
          {
               KhachHang f = new KhachHang();
               this.Hide();
               f.ShowDialog();
               this.Close();
          }
     }
}
