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
    public partial class frmDONORS : Form
    {
        public frmDONORS()
        {
            InitializeComponent();
        }

        //create object of donarbll and donardll
        donorBLL d = new donorBLL();
        donarDAL dal = new donarDAL();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureboxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnadddonor_Click(object sender, EventArgs e)
        {
            //get data from managedonorform
            d.first_name = txtdonorfirstname.Text;
            d.last_name = txtldonorlastname.Text;
            // d.last_name = txtldonorlastname.Text;
            d.address = txtdonoraddress.Text;
            d.email = txtdonoremail.Text;
            d.gender = cbgender.Text;
            d.contact = txtdonorcontact.Text;
            d.blood_group = cbbloodgroup.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1;
            // d.image_name =  

            bool success = dal.Insert(d);
            //insert data into database
            if (success == true)
            {
                MessageBox.Show("mew user addes successfully");
                //display user in datagrid view
                DataTable dt = dal.select();
                dataGridViewdonors.DataSource = dt;
                //clear text boxex
                cleardonor();
            }
            else
            {
                MessageBox.Show("dclineded");
            }







        }

        public void cleardonor()
        {
            txtdonorfirstname.Text = "";
            txtldonorlastname.Text = "";
            txtdonoremail.Text = "";
            txtdonoraddress.Text = "";
            txtdonoremail.Text = "";
            cbgender.Text = "";
            cbbloodgroup.Text = "";
            txtdonorcontact.Text = "";
            txtdonoraddress.Text = "";

        }

        private void frmDONORS_Load(object sender, EventArgs e)
        {
            //display data in grid
            DataTable dt = dal.select();
            dataGridViewdonors.DataSource = dt;
        }

        private void dataGridViewdonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //select data from grid to display to update

            //find row selected

            int RowIndex = e.RowIndex;

            txtdonorid.Text = dataGridViewdonors.Rows[RowIndex].Cells[0].Value.ToString();
            txtdonorfirstname.Text = dataGridViewdonors.Rows[RowIndex].Cells[1].Value.ToString();
            txtldonorlastname.Text = dataGridViewdonors.Rows[RowIndex].Cells[2].Value.ToString();
            txtdonoremail.Text = dataGridViewdonors.Rows[RowIndex].Cells[4].Value.ToString();
            cbgender.Text = dataGridViewdonors.Rows[RowIndex].Cells[5].Value.ToString();
            cbbloodgroup.Text = dataGridViewdonors.Rows[RowIndex].Cells[7].Value.ToString();
            txtdonorcontact.Text = dataGridViewdonors.Rows[RowIndex].Cells[6].Value.ToString();
            txtdonoraddress.Text = dataGridViewdonors.Rows[RowIndex].Cells[3].Value.ToString();
        }

        private void btnupdatedonor_Click(object sender, EventArgs e)
        {
            //update doors
            //get the values from
            d.donor_id = int.Parse(txtdonorid.Text);
            d.first_name = txtdonorfirstname.Text;
            d.last_name = txtldonorlastname.Text;
            d.address = txtdonoraddress.Text;
            d.email = txtdonoremail.Text;
            d.contact = txtdonorcontact.Text;
            d.gender = cbgender.Text;
            d.blood_group = cbbloodgroup.Text;
            d.added_date = DateTime.Now;
            d.added_by = 1;

            //create boolean varible
            bool issuccess = dal.update(d);

            if (issuccess == true)
            {
                MessageBox.Show("updated successfully");
                cleardonor();

                //refresh grid
                DataTable dt = dal.select();
                dataGridViewdonors.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed to update");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

                 string keyword = textBox1.Text.Trim();

            if (keyword != null)
            {
                DataTable dt = dal.Search(keyword);
                dataGridViewdonors.DataSource = dt;

            }
            else
            {
                DataTable dt = dal.select();
                dataGridViewdonors.DataSource = dt;
            }
        }
    }

}
