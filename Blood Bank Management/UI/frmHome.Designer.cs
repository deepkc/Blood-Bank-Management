namespace Blood_Bank_Management
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            menuStriTtop = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            panelFooter = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblOpositiveCount = new Label();
            LBLbLOODgROUP = new Label();
            panel2 = new Panel();
            label3 = new Label();
            lblANegativeCount = new Label();
            lblANegative = new Label();
            panel3 = new Panel();
            label6 = new Label();
            lblONegativeCount = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            lblAPositiveCount = new Label();
            lblAPositive = new Label();
            panel5 = new Panel();
            label12 = new Label();
            lblBNegativeCount = new Label();
            lblBNegative = new Label();
            panel6 = new Panel();
            label15 = new Label();
            lblABNegativecount = new Label();
            lblABNegative = new Label();
            panel7 = new Panel();
            label18 = new Label();
            lblABPositiveCount = new Label();
            lblABPositive = new Label();
            panel8 = new Panel();
            label21 = new Label();
            lblBpositiveCount = new Label();
            lblBPositive = new Label();
            dgvDoners = new DataGridView();
            lblsearch = new Label();
            txtSsearch = new TextBox();
            pictureBox1 = new PictureBox();
            menuStriTtop.SuspendLayout();
            panelFooter.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStriTtop
            // 
            menuStriTtop.BackColor = SystemColors.HighlightText;
            menuStriTtop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            menuStriTtop.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, donorsToolStripMenuItem });
            menuStriTtop.Location = new Point(0, 0);
            menuStriTtop.Name = "menuStriTtop";
            menuStriTtop.Padding = new Padding(6, 10, 0, 8);
            menuStriTtop.Size = new Size(1135, 39);
            menuStriTtop.TabIndex = 0;
            menuStriTtop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(53, 21);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // donorsToolStripMenuItem
            // 
            donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            donorsToolStripMenuItem.Size = new Size(65, 21);
            donorsToolStripMenuItem.Text = "Donors";
            donorsToolStripMenuItem.Click += donorsToolStripMenuItem_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = SystemColors.HighlightText;
            panelFooter.Controls.Add(label1);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 572);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1135, 38);
            panelFooter.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(420, 7);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 0;
            label1.Text = "Blood Bank Management System";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblOpositiveCount);
            panel1.Controls.Add(LBLbLOODgROUP);
            panel1.Location = new Point(12, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 100);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(116, 56);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Donors";
            // 
            // lblOpositiveCount
            // 
            lblOpositiveCount.AutoSize = true;
            lblOpositiveCount.BackColor = SystemColors.Control;
            lblOpositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOpositiveCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblOpositiveCount.Location = new Point(107, 3);
            lblOpositiveCount.Name = "lblOpositiveCount";
            lblOpositiveCount.Size = new Size(77, 47);
            lblOpositiveCount.TabIndex = 1;
            lblOpositiveCount.Text = "100";
            // 
            // LBLbLOODgROUP
            // 
            LBLbLOODgROUP.AutoSize = true;
            LBLbLOODgROUP.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LBLbLOODgROUP.ForeColor = Color.FromArgb(226, 76, 58);
            LBLbLOODgROUP.Location = new Point(3, 11);
            LBLbLOODgROUP.Name = "LBLbLOODgROUP";
            LBLbLOODgROUP.Size = new Size(98, 65);
            LBLbLOODgROUP.TabIndex = 0;
            LBLbLOODgROUP.Text = "O+";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblANegativeCount);
            panel2.Controls.Add(lblANegative);
            panel2.Location = new Point(297, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 100);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(116, 56);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Donors";
            // 
            // lblANegativeCount
            // 
            lblANegativeCount.AutoSize = true;
            lblANegativeCount.BackColor = SystemColors.Control;
            lblANegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblANegativeCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblANegativeCount.Location = new Point(107, 3);
            lblANegativeCount.Name = "lblANegativeCount";
            lblANegativeCount.Size = new Size(77, 47);
            lblANegativeCount.TabIndex = 1;
            lblANegativeCount.Text = "100";
            // 
            // lblANegative
            // 
            lblANegative.AutoSize = true;
            lblANegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblANegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblANegative.Location = new Point(3, 11);
            lblANegative.Name = "lblANegative";
            lblANegative.Size = new Size(81, 65);
            lblANegative.TabIndex = 0;
            lblANegative.Text = "A-";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblONegativeCount);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(297, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 100);
            panel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(116, 56);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 2;
            label6.Text = "Donors";
            // 
            // lblONegativeCount
            // 
            lblONegativeCount.AutoSize = true;
            lblONegativeCount.BackColor = SystemColors.Control;
            lblONegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblONegativeCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblONegativeCount.Location = new Point(107, 3);
            lblONegativeCount.Name = "lblONegativeCount";
            lblONegativeCount.Size = new Size(77, 47);
            lblONegativeCount.TabIndex = 1;
            lblONegativeCount.Text = "100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(226, 76, 58);
            label8.Location = new Point(3, 11);
            label8.Name = "label8";
            label8.Size = new Size(83, 65);
            label8.TabIndex = 0;
            label8.Text = "O-";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lblAPositiveCount);
            panel4.Controls.Add(lblAPositive);
            panel4.Location = new Point(13, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 100);
            panel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(116, 56);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 2;
            label9.Text = "Donors";
            // 
            // lblAPositiveCount
            // 
            lblAPositiveCount.AutoSize = true;
            lblAPositiveCount.BackColor = SystemColors.Control;
            lblAPositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAPositiveCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblAPositiveCount.Location = new Point(108, 3);
            lblAPositiveCount.Name = "lblAPositiveCount";
            lblAPositiveCount.Size = new Size(77, 47);
            lblAPositiveCount.TabIndex = 1;
            lblAPositiveCount.Text = "100";
            // 
            // lblAPositive
            // 
            lblAPositive.AutoSize = true;
            lblAPositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblAPositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblAPositive.Location = new Point(12, 11);
            lblAPositive.Name = "lblAPositive";
            lblAPositive.Size = new Size(96, 65);
            lblAPositive.TabIndex = 0;
            lblAPositive.Text = "A+";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label12);
            panel5.Controls.Add(lblBNegativeCount);
            panel5.Controls.Add(lblBNegative);
            panel5.Location = new Point(298, 279);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 100);
            panel5.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(116, 56);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 2;
            label12.Text = "Donors";
            // 
            // lblBNegativeCount
            // 
            lblBNegativeCount.AutoSize = true;
            lblBNegativeCount.BackColor = SystemColors.Control;
            lblBNegativeCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBNegativeCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblBNegativeCount.Location = new Point(107, 3);
            lblBNegativeCount.Name = "lblBNegativeCount";
            lblBNegativeCount.Size = new Size(77, 47);
            lblBNegativeCount.TabIndex = 1;
            lblBNegativeCount.Text = "100";
            // 
            // lblBNegative
            // 
            lblBNegative.AutoSize = true;
            lblBNegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBNegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblBNegative.Location = new Point(3, 11);
            lblBNegative.Name = "lblBNegative";
            lblBNegative.Size = new Size(78, 65);
            lblBNegative.TabIndex = 0;
            lblBNegative.Text = "B-";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(label15);
            panel6.Controls.Add(lblABNegativecount);
            panel6.Controls.Add(lblABNegative);
            panel6.Location = new Point(297, 408);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 100);
            panel6.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(125, 56);
            label15.Name = "label15";
            label15.Size = new Size(59, 20);
            label15.TabIndex = 2;
            label15.Text = "Donors";
            // 
            // lblABNegativecount
            // 
            lblABNegativecount.AutoSize = true;
            lblABNegativecount.BackColor = SystemColors.Control;
            lblABNegativecount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblABNegativecount.ForeColor = Color.FromArgb(226, 78, 56);
            lblABNegativecount.Location = new Point(107, 3);
            lblABNegativecount.Name = "lblABNegativecount";
            lblABNegativecount.Size = new Size(77, 47);
            lblABNegativecount.TabIndex = 1;
            lblABNegativecount.Text = "100";
            // 
            // lblABNegative
            // 
            lblABNegative.AutoSize = true;
            lblABNegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblABNegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblABNegative.Location = new Point(3, 11);
            lblABNegative.Name = "lblABNegative";
            lblABNegative.Size = new Size(112, 65);
            lblABNegative.TabIndex = 0;
            lblABNegative.Text = "AB-";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(label18);
            panel7.Controls.Add(lblABPositiveCount);
            panel7.Controls.Add(lblABPositive);
            panel7.Location = new Point(17, 408);
            panel7.Name = "panel7";
            panel7.Size = new Size(251, 100);
            panel7.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(135, 56);
            label18.Name = "label18";
            label18.Size = new Size(59, 20);
            label18.TabIndex = 2;
            label18.Text = "Donors";
            // 
            // lblABPositiveCount
            // 
            lblABPositiveCount.AutoSize = true;
            lblABPositiveCount.BackColor = SystemColors.Control;
            lblABPositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblABPositiveCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblABPositiveCount.Location = new Point(123, 3);
            lblABPositiveCount.Name = "lblABPositiveCount";
            lblABPositiveCount.Size = new Size(77, 47);
            lblABPositiveCount.TabIndex = 1;
            lblABPositiveCount.Text = "100";
            // 
            // lblABPositive
            // 
            lblABPositive.AutoSize = true;
            lblABPositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblABPositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblABPositive.Location = new Point(2, 11);
            lblABPositive.Name = "lblABPositive";
            lblABPositive.Size = new Size(127, 65);
            lblABPositive.TabIndex = 0;
            lblABPositive.Text = "AB+";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Control;
            panel8.Controls.Add(label21);
            panel8.Controls.Add(lblBpositiveCount);
            panel8.Controls.Add(lblBPositive);
            panel8.Location = new Point(17, 277);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 100);
            panel8.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(116, 56);
            label21.Name = "label21";
            label21.Size = new Size(59, 20);
            label21.TabIndex = 2;
            label21.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            lblBpositiveCount.AutoSize = true;
            lblBpositiveCount.BackColor = SystemColors.Control;
            lblBpositiveCount.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBpositiveCount.ForeColor = Color.FromArgb(226, 78, 56);
            lblBpositiveCount.Location = new Point(107, 3);
            lblBpositiveCount.Name = "lblBpositiveCount";
            lblBpositiveCount.Size = new Size(77, 47);
            lblBpositiveCount.TabIndex = 1;
            lblBpositiveCount.Text = "100";
            // 
            // lblBPositive
            // 
            lblBPositive.AutoSize = true;
            lblBPositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBPositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblBPositive.Location = new Point(3, 11);
            lblBPositive.Name = "lblBPositive";
            lblBPositive.Size = new Size(93, 65);
            lblBPositive.TabIndex = 0;
            lblBPositive.Text = "B+";
            // 
            // dgvDoners
            // 
            dgvDoners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoners.Location = new Point(563, 103);
            dgvDoners.Name = "dgvDoners";
            dgvDoners.RowTemplate.Height = 25;
            dgvDoners.Size = new Size(560, 405);
            dgvDoners.TabIndex = 7;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.BackColor = SystemColors.Control;
            lblsearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblsearch.ForeColor = SystemColors.ActiveCaptionText;
            lblsearch.Location = new Point(563, 68);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(109, 21);
            lblsearch.TabIndex = 8;
            lblsearch.Text = "Search Donor";
            // 
            // txtSsearch
            // 
            txtSsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSsearch.Location = new Point(678, 65);
            txtSsearch.Name = "txtSsearch";
            txtSsearch.Size = new Size(379, 29);
            txtSsearch.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1094, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1135, 610);
            Controls.Add(pictureBox1);
            Controls.Add(txtSsearch);
            Controls.Add(lblsearch);
            Controls.Add(dgvDoners);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelFooter);
            Controls.Add(menuStriTtop);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStriTtop;
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Activated += frmHome_Activated;
            Load += frmHome_Load;
            menuStriTtop.ResumeLayout(false);
            menuStriTtop.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoners).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStriTtop;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private Panel panelFooter;
        private Label label1;
        private Panel panel1;
        private Label LBLbLOODgROUP;
        private Label lblOpositiveCount;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label lblANegativeCount;
        private Label lblANegative;
        private Panel panel3;
        private Label label6;
        private Label lblONegativeCount;
        private Label label8;
        private Panel panel4;
        private Label label9;
        private Label lblAPositiveCount;
        private Label lblAPositive;
        private Panel panel5;
        private Label label12;
        private Label lblBNegativeCount;
        private Label lblBNegative;
        private Panel panel6;
        private Label label15;
        private Label lblABNegativecount;
        private Label lblABNegative;
        private Panel panel7;
        private Label label18;
        private Label lblABPositiveCount;
        private Label lblABPositive;
        private Panel panel8;
        private Label label21;
        private Label lblBpositiveCount;
        private Label lblBPositive;
        private DataGridView dgvDoners;
        private Label lblsearch;
        private TextBox txtSsearch;
        private PictureBox pictureBox1;
    }
}