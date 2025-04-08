namespace Blood_Bank_Management.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTop = new Panel();
            pictureboxClose = new PictureBox();
            labelTitle = new Label();
            lblProfilePicture = new Label();
            ProfilePicture = new PictureBox();
            btnSelectImage = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUserid = new TextBox();
            txtContact = new TextBox();
            txtPasswrd = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            txtSearchUser = new TextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panelTop.Size = new Size(1100, 51);
            panelTop.TabIndex = 0;
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
            labelTitle.Size = new Size(137, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Manage Users";
            // 
            // lblProfilePicture
            // 
            lblProfilePicture.AutoSize = true;
            lblProfilePicture.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfilePicture.Location = new Point(42, 64);
            lblProfilePicture.Name = "lblProfilePicture";
            lblProfilePicture.Size = new Size(78, 13);
            lblProfilePicture.TabIndex = 1;
            lblProfilePicture.Text = "Profile Picture";
            // 
            // ProfilePicture
            // 
            ProfilePicture.Location = new Point(158, 60);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(100, 90);
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePicture.TabIndex = 2;
            ProfilePicture.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectImage.Location = new Point(264, 123);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(95, 27);
            btnSelectImage.TabIndex = 3;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 166);
            label1.Name = "label1";
            label1.Size = new Size(43, 13);
            label1.TabIndex = 4;
            label1.Text = "User Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 354);
            label2.Name = "label2";
            label2.Size = new Size(47, 13);
            label2.TabIndex = 5;
            label2.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 312);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 274);
            label4.Name = "label4";
            label4.Size = new Size(62, 13);
            label4.TabIndex = 7;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 240);
            label5.Name = "label5";
            label5.Size = new Size(34, 13);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 202);
            label6.Name = "label6";
            label6.Size = new Size(58, 13);
            label6.TabIndex = 9;
            label6.Text = "Full Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(40, 392);
            label7.Name = "label7";
            label7.Size = new Size(48, 13);
            label7.TabIndex = 10;
            label7.Text = "Address";
            // 
            // txtUserid
            // 
            txtUserid.Location = new Point(158, 165);
            txtUserid.Name = "txtUserid";
            txtUserid.Size = new Size(301, 23);
            txtUserid.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(158, 344);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(301, 23);
            txtContact.TabIndex = 12;
            // 
            // txtPasswrd
            // 
            txtPasswrd.Location = new Point(158, 305);
            txtPasswrd.Name = "txtPasswrd";
            txtPasswrd.PasswordChar = 'X';
            txtPasswrd.Size = new Size(301, 23);
            txtPasswrd.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(158, 270);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 23);
            txtUsername.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(158, 199);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(301, 23);
            txtFullName.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 385);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(301, 23);
            txtAddress.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(57, 439);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 49);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gold;
            btnClear.Location = new Point(399, 439);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 49);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(283, 439);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 49);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(168, 438);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 49);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(495, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(579, 364);
            dataGridView1.TabIndex = 22;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(509, 88);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 23;
            label8.Text = "Search";
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(563, 86);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(369, 23);
            txtSearchUser.TabIndex = 24;
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 500);
            Controls.Add(txtSearchUser);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtPasswrd);
            Controls.Add(txtContact);
            Controls.Add(txtUserid);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Label lblProfilePicture;
        private PictureBox ProfilePicture;
        private Button btnSelectImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUserid;
        private TextBox txtContact;
        private TextBox txtPasswrd;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox txtSearchUser;
        private PictureBox pictureboxClose;
    }
}