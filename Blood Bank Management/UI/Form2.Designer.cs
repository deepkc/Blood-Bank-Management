namespace Blood_Bank_Management.UI
{
    partial class frmDONORS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDONORS));
            panelTop = new Panel();
            pictureboxClose = new PictureBox();
            labelTitle = new Label();
            txtSearchUser = new TextBox();
            label8 = new Label();
            dataGridViewdonors = new DataGridView();
            btnupdatedonor = new Button();
            btndeletedonor = new Button();
            btncleardonor = new Button();
            btnadddonor = new Button();
            txtdonoraddress = new TextBox();
            txtdonorfirstname = new TextBox();
            txtldonorlastname = new TextBox();
            txtdonoremail = new TextBox();
            txtdonorcontact = new TextBox();
            txtdonorid = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSelectImage = new Button();
            ProfilePicture = new PictureBox();
            lblProfilePicture = new Label();
            cbgender = new ComboBox();
            label9 = new Label();
            cbbloodgroup = new ComboBox();
            textBox1 = new TextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdonors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Salmon;
            panelTop.Controls.Add(pictureboxClose);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 53);
            panelTop.TabIndex = 1;
            // 
            // pictureboxClose
            // 
            pictureboxClose.BackColor = Color.White;
            pictureboxClose.Image = (Image)resources.GetObject("pictureboxClose.Image");
            pictureboxClose.Location = new Point(1052, 1);
            pictureboxClose.Name = "pictureboxClose";
            pictureboxClose.Size = new Size(48, 50);
            pictureboxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxClose.TabIndex = 1;
            pictureboxClose.TabStop = false;
            pictureboxClose.Click += pictureboxClose_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(447, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(155, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Manage Donors";
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(0, 0);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(100, 23);
            txtSearchUser.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(502, 105);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 47;
            label8.Text = "Search";
            // 
            // dataGridViewdonors
            // 
            dataGridViewdonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdonors.Location = new Point(502, 141);
            dataGridViewdonors.Name = "dataGridViewdonors";
            dataGridViewdonors.RowTemplate.Height = 25;
            dataGridViewdonors.Size = new Size(579, 404);
            dataGridViewdonors.TabIndex = 46;
            dataGridViewdonors.RowHeaderMouseClick += dataGridViewdonors_RowHeaderMouseClick;
            // 
            // btnupdatedonor
            // 
            btnupdatedonor.BackColor = Color.CornflowerBlue;
            btnupdatedonor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnupdatedonor.Location = new Point(151, 473);
            btnupdatedonor.Name = "btnupdatedonor";
            btnupdatedonor.Size = new Size(90, 52);
            btnupdatedonor.TabIndex = 45;
            btnupdatedonor.Text = "Update";
            btnupdatedonor.UseVisualStyleBackColor = false;
            btnupdatedonor.Click += btnupdatedonor_Click;
            // 
            // btndeletedonor
            // 
            btndeletedonor.BackColor = Color.IndianRed;
            btndeletedonor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btndeletedonor.Location = new Point(262, 473);
            btndeletedonor.Name = "btndeletedonor";
            btndeletedonor.Size = new Size(90, 52);
            btndeletedonor.TabIndex = 44;
            btndeletedonor.Text = "Delete";
            btndeletedonor.UseVisualStyleBackColor = false;
            // 
            // btncleardonor
            // 
            btncleardonor.BackColor = Color.Gold;
            btncleardonor.Location = new Point(371, 473);
            btncleardonor.Name = "btncleardonor";
            btncleardonor.Size = new Size(90, 52);
            btncleardonor.TabIndex = 43;
            btncleardonor.Text = "Clear";
            btncleardonor.UseVisualStyleBackColor = false;
            // 
            // btnadddonor
            // 
            btnadddonor.BackColor = Color.SeaGreen;
            btnadddonor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnadddonor.Location = new Point(51, 473);
            btnadddonor.Name = "btnadddonor";
            btnadddonor.Size = new Size(90, 52);
            btnadddonor.TabIndex = 42;
            btnadddonor.Text = "Add";
            btnadddonor.UseVisualStyleBackColor = false;
            btnadddonor.Click += btnadddonor_Click;
            // 
            // txtdonoraddress
            // 
            txtdonoraddress.Location = new Point(151, 412);
            txtdonoraddress.Name = "txtdonoraddress";
            txtdonoraddress.Size = new Size(301, 23);
            txtdonoraddress.TabIndex = 41;
            // 
            // txtdonorfirstname
            // 
            txtdonorfirstname.Location = new Point(151, 210);
            txtdonorfirstname.Name = "txtdonorfirstname";
            txtdonorfirstname.Size = new Size(301, 23);
            txtdonorfirstname.TabIndex = 40;
            // 
            // txtldonorlastname
            // 
            txtldonorlastname.Location = new Point(151, 243);
            txtldonorlastname.Name = "txtldonorlastname";
            txtldonorlastname.Size = new Size(301, 23);
            txtldonorlastname.TabIndex = 39;
            // 
            // txtdonoremail
            // 
            txtdonoremail.Location = new Point(151, 275);
            txtdonoremail.Name = "txtdonoremail";
            txtdonoremail.Size = new Size(301, 23);
            txtdonoremail.TabIndex = 38;
            // 
            // txtdonorcontact
            // 
            txtdonorcontact.Location = new Point(151, 379);
            txtdonorcontact.Name = "txtdonorcontact";
            txtdonorcontact.Size = new Size(301, 23);
            txtdonorcontact.TabIndex = 36;
            // 
            // txtdonorid
            // 
            txtdonorid.Location = new Point(151, 180);
            txtdonorid.Name = "txtdonorid";
            txtdonorid.Size = new Size(301, 23);
            txtdonorid.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 416);
            label7.Name = "label7";
            label7.Size = new Size(48, 13);
            label7.TabIndex = 34;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 214);
            label6.Name = "label6";
            label6.Size = new Size(61, 13);
            label6.TabIndex = 33;
            label6.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 247);
            label5.Name = "label5";
            label5.Size = new Size(59, 13);
            label5.TabIndex = 32;
            label5.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 280);
            label4.Name = "label4";
            label4.Size = new Size(34, 13);
            label4.TabIndex = 31;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 308);
            label3.Name = "label3";
            label3.Size = new Size(45, 13);
            label3.TabIndex = 30;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 384);
            label2.Name = "label2";
            label2.Size = new Size(47, 13);
            label2.TabIndex = 29;
            label2.Text = "Contact";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 183);
            label1.Name = "label1";
            label1.Size = new Size(53, 13);
            label1.TabIndex = 28;
            label1.Text = "Donor Id";
            // 
            // btnSelectImage
            // 
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectImage.Location = new Point(274, 127);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(95, 28);
            btnSelectImage.TabIndex = 27;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Location = new Point(151, 70);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(100, 91);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 26;
            ProfilePicture.TabStop = false;
            // 
            // lblProfilePicture
            // 
            lblProfilePicture.AutoSize = true;
            lblProfilePicture.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfilePicture.Location = new Point(33, 141);
            lblProfilePicture.Name = "lblProfilePicture";
            lblProfilePicture.Size = new Size(78, 13);
            lblProfilePicture.TabIndex = 25;
            lblProfilePicture.Text = "Profile Picture";
            // 
            // cbgender
            // 
            cbgender.FormattingEnabled = true;
            cbgender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbgender.Location = new Point(151, 307);
            cbgender.Name = "cbgender";
            cbgender.Size = new Size(301, 23);
            cbgender.TabIndex = 49;
            cbgender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 346);
            label9.Name = "label9";
            label9.Size = new Size(73, 13);
            label9.TabIndex = 50;
            label9.Text = "Blood Group";
            // 
            // cbbloodgroup
            // 
            cbbloodgroup.FormattingEnabled = true;
            cbbloodgroup.Items.AddRange(new object[] { "O+", "O+", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            cbbloodgroup.Location = new Point(151, 341);
            cbbloodgroup.Name = "cbbloodgroup";
            cbbloodgroup.Size = new Size(301, 23);
            cbbloodgroup.TabIndex = 51;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 23);
            textBox1.TabIndex = 53;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // frmDONORS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 557);
            Controls.Add(textBox1);
            Controls.Add(cbbloodgroup);
            Controls.Add(label9);
            Controls.Add(cbgender);
            Controls.Add(txtSearchUser);
            Controls.Add(label8);
            Controls.Add(dataGridViewdonors);
            Controls.Add(btnupdatedonor);
            Controls.Add(btndeletedonor);
            Controls.Add(btncleardonor);
            Controls.Add(btnadddonor);
            Controls.Add(txtdonoraddress);
            Controls.Add(txtdonorfirstname);
            Controls.Add(txtldonorlastname);
            Controls.Add(txtdonoremail);
            Controls.Add(txtdonorcontact);
            Controls.Add(txtdonorid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSelectImage);
            Controls.Add(ProfilePicture);
            Controls.Add(lblProfilePicture);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDONORS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donor";
            Load += frmDONORS_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdonors).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureboxClose;
        private Label labelTitle;
        private TextBox txtSearchUser;
        private Label label8;
        private DataGridView dataGridViewdonors;
        private Button btnupdatedonor;
        private Button btndeletedonor;
        private Button btncleardonor;
        private Button btnadddonor;
        private TextBox txtdonoraddress;
        private TextBox txtdonorfirstname;
        private TextBox txtldonorlastname;
        private TextBox txtdonoremail;
        private TextBox txtdonorcontact;
        private TextBox txtdonorid;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSelectImage;
        private PictureBox ProfilePicture;
        private Label lblProfilePicture;
        private ComboBox cbgender;
        private Label label9;
        private ComboBox cbbloodgroup;
        private TextBox textBox1;
    }
}