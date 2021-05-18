using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Compare
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            OpenForm(f1);
        }
        FrmCompare f1 = new FrmCompare();
        public void OpenForm(Form frm)
        {
            frm.TopLevel = false;
            frm.TopMost = false;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }
        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btAll_Click(object sender, EventArgs e)
        {

        }

        private void btDif_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width-50;
            int h = this.Height-50;
            this.panelMain.Size = new Size(w, h);
            f1.Size = new Size(w, h);
            
            OpenForm(f1);
            this.Refresh();
        }
    }
}
