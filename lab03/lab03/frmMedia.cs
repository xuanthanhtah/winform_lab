using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format($"Ngày : { DateTime.Now.ToString("dd / MM / yyyy")} - giờ : {DateTime.Now.ToString("hh:mm:ss tt")}");
            this.Text = this.Text.Substring(1, this.Text.Length - 1) + this.Text.Substring(0, 1);
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "MP4 File | *.mp4";

            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName;
        }

        private void đóngFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("exit?", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            Close();
        }
    }
}
