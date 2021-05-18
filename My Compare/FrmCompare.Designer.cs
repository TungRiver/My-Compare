namespace My_Compare
{
    partial class FrmCompare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompare));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btNext = new System.Windows.Forms.Button();
            this.btFre = new System.Windows.Forms.Button();
            this.btDif = new System.Windows.Forms.Button();
            this.btAll = new System.Windows.Forms.Button();
            this.cmB1 = new System.Windows.Forms.ComboBox();
            this.cmB2 = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.rTB2 = new System.Windows.Forms.RichTextBox();
            this.btOpen1 = new System.Windows.Forms.Button();
            this.btOpen2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTop.Controls.Add(this.btNext);
            this.panelTop.Controls.Add(this.btFre);
            this.panelTop.Controls.Add(this.btDif);
            this.panelTop.Controls.Add(this.btAll);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1248, 54);
            this.panelTop.TabIndex = 3;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Transparent;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNext.Location = new System.Drawing.Point(234, 4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(54, 44);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "差别";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNext.UseVisualStyleBackColor = false;
            // 
            // btFre
            // 
            this.btFre.BackColor = System.Drawing.Color.Transparent;
            this.btFre.FlatAppearance.BorderSize = 0;
            this.btFre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btFre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btFre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFre.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFre.Image = ((System.Drawing.Image)(resources.GetObject("btFre.Image")));
            this.btFre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFre.Location = new System.Drawing.Point(161, 4);
            this.btFre.Name = "btFre";
            this.btFre.Size = new System.Drawing.Size(54, 44);
            this.btFre.TabIndex = 4;
            this.btFre.Text = "差别";
            this.btFre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFre.UseVisualStyleBackColor = false;
            // 
            // btDif
            // 
            this.btDif.BackColor = System.Drawing.Color.Transparent;
            this.btDif.FlatAppearance.BorderSize = 0;
            this.btDif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btDif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDif.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDif.Image = ((System.Drawing.Image)(resources.GetObject("btDif.Image")));
            this.btDif.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDif.Location = new System.Drawing.Point(85, 4);
            this.btDif.Name = "btDif";
            this.btDif.Size = new System.Drawing.Size(54, 44);
            this.btDif.TabIndex = 2;
            this.btDif.Text = "差别";
            this.btDif.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDif.UseVisualStyleBackColor = false;
            // 
            // btAll
            // 
            this.btAll.BackColor = System.Drawing.Color.Transparent;
            this.btAll.FlatAppearance.BorderSize = 0;
            this.btAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAll.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAll.Image = ((System.Drawing.Image)(resources.GetObject("btAll.Image")));
            this.btAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAll.Location = new System.Drawing.Point(12, 4);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(54, 44);
            this.btAll.TabIndex = 1;
            this.btAll.Text = "全部\r\n";
            this.btAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAll.UseVisualStyleBackColor = false;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // cmB1
            // 
            this.cmB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmB1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmB1.FormattingEnabled = true;
            this.cmB1.Location = new System.Drawing.Point(25, 57);
            this.cmB1.Name = "cmB1";
            this.cmB1.Size = new System.Drawing.Size(386, 24);
            this.cmB1.TabIndex = 4;
            this.cmB1.DropDown += new System.EventHandler(this.cmB1_DropDown);
            this.cmB1.TextChanged += new System.EventHandler(this.cmB1_TextChanged);
            // 
            // cmB2
            // 
            this.cmB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmB2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmB2.FormattingEnabled = true;
            this.cmB2.Location = new System.Drawing.Point(577, 58);
            this.cmB2.Name = "cmB2";
            this.cmB2.Size = new System.Drawing.Size(279, 22);
            this.cmB2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(26, 103);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rTB1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rTB2);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 338);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // rTB1
            // 
            this.rTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB1.Location = new System.Drawing.Point(13, 3);
            this.rTB1.Name = "rTB1";
            this.rTB1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rTB1.Size = new System.Drawing.Size(510, 317);
            this.rTB1.TabIndex = 0;
            this.rTB1.Text = "";
            this.rTB1.WordWrap = false;
            this.rTB1.VScroll += new System.EventHandler(this.rTB1_VScroll);
            // 
            // rTB2
            // 
            this.rTB2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTB2.Location = new System.Drawing.Point(3, 3);
            this.rTB2.Name = "rTB2";
            this.rTB2.Size = new System.Drawing.Size(581, 317);
            this.rTB2.TabIndex = 0;
            this.rTB2.Text = "";
            this.rTB2.WordWrap = false;
            this.rTB2.VScroll += new System.EventHandler(this.rTB2_VScroll);
            // 
            // btOpen1
            // 
            this.btOpen1.FlatAppearance.BorderSize = 0;
            this.btOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen1.Image = ((System.Drawing.Image)(resources.GetObject("btOpen1.Image")));
            this.btOpen1.Location = new System.Drawing.Point(417, 59);
            this.btOpen1.Name = "btOpen1";
            this.btOpen1.Size = new System.Drawing.Size(34, 20);
            this.btOpen1.TabIndex = 7;
            this.btOpen1.UseVisualStyleBackColor = true;
            this.btOpen1.Click += new System.EventHandler(this.btOpen1_Click);
            // 
            // btOpen2
            // 
            this.btOpen2.FlatAppearance.BorderSize = 0;
            this.btOpen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen2.Image = ((System.Drawing.Image)(resources.GetObject("btOpen2.Image")));
            this.btOpen2.Location = new System.Drawing.Point(862, 59);
            this.btOpen2.Name = "btOpen2";
            this.btOpen2.Size = new System.Drawing.Size(34, 20);
            this.btOpen2.TabIndex = 8;
            this.btOpen2.UseVisualStyleBackColor = true;
            this.btOpen2.Click += new System.EventHandler(this.btOpen2_Click);
            // 
            // FrmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 467);
            this.Controls.Add(this.btOpen2);
            this.Controls.Add(this.btOpen1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cmB2);
            this.Controls.Add(this.cmB1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompare";
            this.Text = "FrmCompare";
            this.Load += new System.EventHandler(this.FrmCompare_Load);
            this.panelTop.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btFre;
        private System.Windows.Forms.Button btDif;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.ComboBox cmB1;
        private System.Windows.Forms.ComboBox cmB2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btOpen1;
        private System.Windows.Forms.Button btOpen2;
        private System.Windows.Forms.RichTextBox rTB1;
        private System.Windows.Forms.RichTextBox rTB2;
    }
}