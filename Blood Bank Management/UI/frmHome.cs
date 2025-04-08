using Blood_Bank_Management.DAL;
using Blood_Bank_Management.UI;

namespace Blood_Bank_Management
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        donarDAL dal = new donarDAL();

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //  private void Form1_Load(object sender, EventArgs e)
        //{
        //  Form1 users = new Form1();
        // users.Show();
        // }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code.close application
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 users = new Form1();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDONORS donors = new frmDONORS();
            donors.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //load all the blood donors cound when form is loaded
            allDonorCout();

        }

        public void allDonorCout()
        {
            // get donor count and set in respective label
            lblOpositiveCount.Text = dal.countDonors("O+");
            lblONegativeCount.Text = dal.countDonors("O-");
            lblAPositiveCount.Text = dal.countDonors("A+");
            lblANegativeCount.Text = dal.countDonors("A-");

            lblBpositiveCount.Text = dal.countDonors("B+");
            lblBNegativeCount.Text = dal.countDonors("B-");
            lblABPositiveCount.Text = dal.countDonors("AB+");
            lblABNegativecount.Text = dal.countDonors("AB-");


        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            allDonorCout();
        }



    }
}