using Blood_Bank_Management.BLL;
using Blood_Bank_Management.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management.DAL
{
    internal class userDAL
    {

        //create a static string to connect database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private bool isSuccess;
        #region SELECT data from database
        public DataTable Select()
        {
            //create an object to create database
            SqlConnection conn = new SqlConnection(myconnstring);

            //create a table to hold data from database
            DataTable dt = new DataTable();

            try
            {
                //write sql query to write fromdatebase
                string sql = "select * from table_users";

                //create sql command to excuet query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create a sql data adapter to hold data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();
                // transfer data from sqldata adapter to datafile
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

        #region Inseret Data into Database for User Modue
        public bool Insert(userBLL u)
        {
            //create a boolean variable
            bool IsSuccess = false;

            //create an object of sql connection to connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //create a string variable to store a insert query
                String sql = "INSERT into table_users(username,email,password,contact,address,full_name,added_date)values(@username,@email,@password,@contact,@address,@full_name,@added_date)";

                //create sqlcommand to pass to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create paramater to get value
                cmd.Parameters.AddWithValue("@username",u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
               // cmd.Parameters.AddWithValue("@image", u.image);
                // open dataconnection
                conn.Open();
                //create integer variable to hold value
                int rows = cmd.ExecuteNonQuery();

                //the value of row is >0 is the query is xecued successfully
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

        #region Update data into database (User Module)
        public bool Update(userBLL u)
        {
            ///create a boolean varible
            bool isSuccess = false;

            //create object for database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //create a string variable to store a update query
                String sql = "UPDATE  table_users SET username=@username,email=@email,password=@password,contact=@contact,address=@address,full_name=@full_name,added_date=@added_date WHERE user_id=@user_id";



                //create sqlcommand to pass to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);


                //create paramater to get value
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
              //  cmd.Parameters.AddWithValue("@image", u.image);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                conn.Open();
                //the value of row is >0 is the query is xecued successfully

                int rows = cmd.ExecuteNonQuery();
                //if the value of rows is greater then 0
                if (rows > 0)
                {

                    isSuccess = true;

                }
                else {
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

        #region DELETE DATA from Database (User Module) 

        public bool Delete(userBLL u)
        {
            ///create a boolean varible
            bool isSuccess = false;

            //create object for database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //create a string variable to delete data
                String sql = "DELETE from table_users WHERE user_id=@user_id";



                //create sqlcommand to pass to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

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

        //internal static bool Insert(userDLL u)
        //{
        //    throw new NotImplementedException();
        //}








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

                string sql = "Select * from table_users where user_id like '%"+keywords+"%' or  full_name like '%"+keywords+"%' or address like '%"+keywords+"%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();

                //pass the data from adapter to datatable
                adapter.Fill(dt);   

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            }
            finally { 
            
            conn.Close();
            }


            return dt;



        }



        #endregion




    }


}
      
    

