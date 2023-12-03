using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14_Database_Example_1
{
    internal class DatabaseHelper
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DataTable currentDataTable;
        //string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bin\Debug\MetalRecycle.mdf;Integrated Security=True;Connect Timeout=30";
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MetalRecycle.mdf;Integrated Security=True;Connect Timeout=30";
        
        //Constructor: default
        public DatabaseHelper()
        {
            conn = new SqlConnection(connectionstring);
            cmd = new SqlCommand();
            cmd.Connection = conn;//set the property Connection as the conn object.
        }
        //Constructor with connection string parameter
        public DatabaseHelper(string connection_string)
        {
            conn = new SqlConnection(connection_string);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        //string query = $"insert into product values('{txtid.Text.ToString()}','{txtEnglishName.Text}','{txtChineseName.Text}','{txtPrice.Text.ToString()}')";
        public void insert(string query)
        {
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            //cleardata();
            conn.Close();
            displaydata();
        }
        //string query = "update product set EnglishName='" + txtEnglishName.Text + "',ChineaseName='" + txtChineseName.Text + "',Price='" + txtPrice.Text.ToString() + "' where id='" + txtid.Text.ToString() + "' ";
        public void update(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                conn.Close();//close the database no matter what happened, even exception
            }
            
            
            displaydata();
            //cleardata();
        }

        public void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            currentDataTable = dt;
            conn.Close();
        }
        public void RetriveDataTable(string query)
        {
            try { 
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                //dataGridView1.DataSource = dt;
                currentDataTable = dt;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
        //string query = $"delete product where id='{txtid.Text.ToString()}'";
        public void delete(string query)
        {
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            //dataGridView1.DataSource = query;
            //cleardata();
            conn.Close();
            //displaydata();
        }
        //string query = "select * from product where id='" + txtsearch.Text + "'";
        private void find_data(string query)
        {
            conn.Open();//opent the database connection
            SqlCommand cmd = conn.CreateCommand();//create a command object
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            currentDataTable = dt;
            conn.Close();
        }
    }
}
