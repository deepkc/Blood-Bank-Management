using Blood_Bank_Management.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management.DAL
{
    internal class donarDAL
    {
        //create a static string to connect database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private bool isSuccess;
        #region select data in grid
        public DataTable select()
        {

     
        //create object of database to hosd the data
        DataTable dt = new DataTable();
            
            //create sql connection
            SqlConnection conn =  new SqlConnection(myconnstring);

            try
            {

                //query to select data from database
                string sql = "select * from table_donor";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sqldataadapter to hold the data 

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                // pass data from adapter to database
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            finally 
            {
            }


            return dt;

        }

        #endregion


        #region insert into donor table
        public bool Insert(donorBLL d)
        {
            //create boolean variable and set its default value false
            bool isSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //add code to insert
            try
            {
                //query to insert data into database
                string sql = "insert into table_donor (first_name,last_name,address,email,gender,contact,blood_group,added_date,added_by) VALUES (@first_name,@last_name,@address,@email,@gender,@contact,@blood_group,@added_date,@added_by)";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //pass value to query

                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
             //   cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                
                //open database connnection
                conn.Open();

                //create integer to check query was executed successfully or not

                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }

                return isSuccess;


            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);   
            }
            finally
            {
              conn.Close(); 
            }

            return isSuccess;

        }



        #endregion

        #region update donor table

        public bool update(donorBLL d) 
        {
            //create boolean variable and set its default value false
            bool isSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //add code to update

            try
            {
                //query to update donor
                string sql = "update table_donor  SET first_name=@first_name,last_name=@last_name,address=@address,email=@email,gender=@gender,contact=@contact,blood_group=@blood_group,added_date=@added_date,added_by=@added_by where donor_id=@donor_id";
                //create sql command 
                SqlCommand cmd=new SqlCommand(sql, conn);
                //pass value

                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
               // cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                // cmd.Parameters.AddWithValue("@image", u.image);
                // open dataconnection
                conn.Open();
                //create integer variable to hold value
                int rows = cmd.ExecuteNonQuery();

                //if the value of row is >0 is the query is execued successfully
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally { 
            conn.Close();   
            }

            return isSuccess;


        }



        #endregion
        #region delete from donor

        public bool Delete(donorBLL u)
        {
            ///create a boolean varible
            bool isSuccess = false;

            //create object for database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //create a string variable to delete data
                String sql = "DELETE from table_donor WHERE donor_id=@donor_id";



                //create sqlcommand to pass to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@donor_id", u.donor_id);

                conn.Open();
                //create integer variable 
                int rows = cmd.ExecuteNonQuery();


                //if the value of rows is greater then 0
                if (rows > 0)
                {

                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }


        #endregion

        #region to display donor in dashboard

        public string countDonors(string blood_group)
        {
            //create database connection
            SqlConnection conn = new SqlConnection(myconnstring);
            //create string variable for donot count 

            string donors = "0";


            try
            {
                //sql to count donors for specific blood group
                string sql = "select * from table_donor where blood_group='" + blood_group + "'";

                //sql command to execute the query

                SqlCommand cmd = new SqlCommand (sql, conn);

                //sql adapter to hold data

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //data table to hold data temp

                DataTable dt = new DataTable();

                //pass value to data adapter 
                adapter.Fill(dt);

                //get no of donors based on bloodgroup
                donors = dt.Rows.Count.ToString();  




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { 
            conn.Close ();
            }
            return donors;

        }


        #endregion

        #region search

        public DataTable Search(string keywords)
        {

            SqlConnection conn = new SqlConnection(myconnstring);

            //create datatable to hold data
            DataTable dt = new DataTable();
            //code to serch users

            try
            {
                //sql query to search user from database

                string sql = "Select * from table_donor where donor_id like '%" + keywords + "%' or  first_name like '%" + keywords + "%' or blood_group like '%" + keywords + "%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();

                //pass the data from adapter to datatable
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                conn.Close();
            }


            return dt;



        }



        #endregion

    }
}
