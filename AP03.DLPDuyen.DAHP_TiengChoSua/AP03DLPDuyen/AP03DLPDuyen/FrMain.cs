using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP03DLPDuyen
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        //GỌI FORM QUẢN LÝ ÂM THANH
        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMP fr = new WMP();
            fr.ShowDialog();
        }//quảnLýÂmThanhDùngWMPToolStripMenuItem_Click

        //THOÁT KHỎI CHƯƠNG TRÌNH
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch =  MessageBox.Show("Thiệt thoát không (Y/N)?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //TẮT_ MỞ THANH THỰC ĐƠN 
        private void tắtMởThanhThựcĐơnMenuBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;
        }
        //TẮT_ MỞ THANH CÔNG CỤ
        private void tắtMởThanhCôngCụToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }
        //TẮT_ MỞ DÒNG TRẠNG THÁI
        private void tắtMởDòngTrạngTháiStatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }
        //TẮT_ MỞ MÀN HÌNH
        private void tắtFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible; //con trỏ This chính là màn hình Form hiện tại
        }
        //NHẢY ĐỒNG HỒ TRÊN DÒNG TRẠNG THÁI (GÓC DƯỚI BÊN PHẢI MÀN HÌNH)
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = System.DateTime.Now.ToLongTimeString();
        }
    }//class frMain: form
}//namespace AP03DLPDuyen
