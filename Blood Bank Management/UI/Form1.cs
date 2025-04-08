using Blood_Bank_Management.BLL;
using Blood_Bank_Management.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create object of userBLL and userDAL
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        private object imageName;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get values from UI
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPasswrd.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            // u.image = (string)imageName;
            //check
            bool success = dal.Insert(u);

            //check insert
            if (success == true)
            {
                MessageBox.Show("mew user addes successfully");
                //display user in datagrid view
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
                //clear text boxex
                clear();
            }
            else
            {
                MessageBox.Show("dclineded");
            }


        }
        public void clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPasswrd.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtUserid.Text = "";


        }

        private void pictureboxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //find the tow index of row clicked on users data view
            int RowIndex = e.RowIndex;
            txtUserid.Text = dataGridView1.Rows[RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString();
            txtPasswrd.Text = dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dataGridView1.Rows[RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[RowIndex].Cells[5].Value.ToString();
            txtFullName.Text = dataGridView1.Rows[RowIndex].Cells[6].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///display users in datagid  view#
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the values from ui
            u.user_id = int.Parse(txtUserid.Text);
            u.full_name = txtFullName.Text;
            u.username = txtUsername.Text;
            u.email = txtEmail.Text;
            u.password = txtPasswrd.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            //u.image = ProfilePicture;

            bool success = dal.Update(u);
            if (success)
            {
                MessageBox.Show("user updated successfully");
                //refresh  grid
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
                //clear text box after update
                clear();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {// for delete get user id from text box to delete user
            u.user_id = int.Parse(txtUserid.Text.Trim());

            //create a bool value to check

            bool success = dal.Delete(u);

            if (success == true)
            {
                MessageBox.Show("user deleted successfully");

                //refresh grid
                DataTable dt = dal.Select();

                dataGridView1.DataSource = dt;
                clear();

            }



        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            // code to get user based on keywords
            //get the key words from the text box
            string keyword=txtSearchUser.Text.Trim();

            if (keyword != null)
            {
            DataTable dt = dal.Search(keyword);
                dataGridView1.DataSource = dt;    

            }
            else
            { 
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
