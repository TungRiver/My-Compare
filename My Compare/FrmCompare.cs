using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace My_Compare
{
    public partial class FrmCompare : Form
    {
        public FrmCompare()
        {
            InitializeComponent();
        }

        private void FrmCompare_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            int dif = cmB2.Location.X;
            int X = splitContainer1.Location.X + splitContainer1.Panel1.Width + splitContainer1.SplitterWidth;
            int Y = cmB2.Location.Y;
            cmB2.Location = new Point(X, Y);
            dif = X - dif;

            int Xb = btOpen2.Location.X + dif;
            int Yb = btOpen2.Location.Y;
            btOpen2.Location = new Point(Xb, Yb);

        }

        private void btOpen1_Click(object sender, EventArgs e)
        {
            string path = SelectPath();
            cmB1.Text = path;

            importTxtNoAdd(path, this.rTB1);
        }
        private string SelectPath()
        {
            string path = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Files (*.tab)|*.tab"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };

            //var result = openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            return path;
        }
        private void importTxtNoAdd(string textFilePath, RichTextBox tb)
        {
            var filestream = new System.IO.FileStream(textFilePath,
                                           System.IO.FileMode.Open,
                                           System.IO.FileAccess.Read,
                                           System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.Default, true, 128);
            string lineOfText = file.ReadLine();
            Int64 i = 0;
            while ((lineOfText != null))
            {
                if (lineOfText.Contains("---------------"))
                {
                    //tb.AppendText("===================    " + i.ToString() + "行\r\n");
                    while ((lineOfText = file.ReadLine()) != null)
                    {

                        if (lineOfText.Contains("---------------") == false)
                        {
                            tb.AppendText(lineOfText + "\r\n");
                        }
                        else if (lineOfText.Contains("---------------"))
                        {
                            break;
                        }
                    }
                    ++i;

                }
                else
                {

                }
            }
        }

        private void btOpen2_Click(object sender, EventArgs e)
        {
            string path = SelectPath();
            cmB2.Text = path;

            importTxtNoAdd(path, this.rTB2);
        }
        private int GetLineNoVscroll(RichTextBox rtb)
        {
            //获得当前坐标信息
            Point p = rtb.Location;
            int crntFirstIndex = rtb.GetCharIndexFromPosition(p);
            int crntFirstLine = rtb.GetLineFromCharIndex(crntFirstIndex);
            return crntFirstLine;
        }
        private int GetColNoVscroll(RichTextBox rtb)
        {
            //获得当前坐标信息
            Point p = rtb.Location;
            int crntFirstIndex = rtb.GetCharIndexFromPosition(p);
            int crntFirstLine = rtb.GetLineFromCharIndex(crntFirstIndex);
            return p.Y;
        }
        private void TrunRowsId(int iCodeRowsID, RichTextBox rtb)
        {
            try
            {
                rtb.SelectionStart = rtb.GetFirstCharIndexFromLine(iCodeRowsID);
                rtb.SelectionLength = 0;
                rtb.ScrollToCaret();
            }
            catch
            {

            }
        }
        void GotoLine(int wantedLine_zero_based, RichTextBox rtb) // int wantedLine_zero_based = wanted line number; 1st line = 0
        {
            int index = rtb.GetFirstCharIndexFromLine(wantedLine_zero_based);
            rtb.Select(index, 0);
            rtb.ScrollToCaret();
        }


        private void TrunColsId(int iCodeColID, RichTextBox rtb)
        {
            try
            {
                rtb.SelectionStart = rtb.GetFirstCharIndexFromLine(iCodeColID);
                rtb.SelectionLength = 0;
                rtb.ScrollToCaret();
            }
            catch
            {

            }
        }
        int crntLastLine;
        private void rTB1_VScroll(object sender, EventArgs e)
        {
            int nPos = GetScrollPos(rTB1.Handle, (int)ScrollBarType.SbVert);
            nPos <<= 16;
            uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
            SendMessage(rTB2.Handle, (int)Message.WM_VSCROLL, new IntPtr(wParam), new IntPtr(0));
        }

        private void rTB2_VScroll(object sender, EventArgs e)
        {
            //int nPos = GetScrollPos(rTB2.Handle, (int)ScrollBarType.SbVert);
            //nPos <<= 16;
            //uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
            //SendMessage(rTB1.Handle, (int)Message.WM_VSCROLL, new IntPtr(wParam), new IntPtr(0));
        }

        public enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }

        public enum Message : uint
        {
            WM_VSCROLL = 0x0115
        }

        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }

        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        private void btAll_Click(object sender, EventArgs e)
        {
            BProcess p = new BProcess();
            p.Intila(cmB1.Text);
        }

        private void cmB1_TextChanged(object sender, EventArgs e)
        {
            List<string> res= UI.ShowPathList(cmB1.Text, cmB1);
            if (res != null && 0 != res.Count)
            {
                //cmB1.AutoCompleteSource = AutoCompleteSource.ListItems;
                //cmB1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                for (int i = 0; i < res.Count; i++)
                {
                    cmB1.Items.Add(res[i]);
                }

            }
        }

        private void cmB1_MouseClick(object sender, MouseEventArgs e)
        {
            //cmB1.Text = cmB1.SelectedText;
        }

        private void cmB1_SelectedIndexChanged(object sender, EventArgs e)
        {
           cmB1.Text = cmB1.SelectedItem.ToString();
        }

        private void cmB1_DropDown(object sender, EventArgs e)
        {
        }
    }
}
