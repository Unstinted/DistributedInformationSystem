using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CosmeticsLibrary.DAO
{
    class SQLUtility
    {
        //Creating a Connection properties
        private SqlConnection Connection;

        public SqlConnection connection
        {
            get {
                if (this.Connection == null)
                {
                    Connection = new SqlConnection(Properties.Settings.Default.CosmeticsConnectionString);
                }
                if (Connection.State == System.Data.ConnectionState.Closed)
                {
                    Connection.Open();
                }
                return this.Connection; 
            }

        }

        //Retrieving Data from The Database 
        public SqlDataReader ExecuteReader(String query) {
            SqlDataReader sd = null;
            SqlConnection Connection = this.connection;
            SqlCommand cmd = new SqlCommand(query, Connection);
            sd = cmd.ExecuteReader();
            return sd;
        }

        //Inserting Into the Database
        public void ExecuteNonQuery(String query) 
        {
            SqlDataReader sd = null;
            SqlConnection Connection = this.connection;
            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
        
        }

        //get the first result
        public Object ExecuteScalar(String query)
        {
            SqlDataReader sd = null;
            SqlConnection Connection = this.connection;
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteScalar();

        }
        //Closing Connections
        ~SQLUtility()
        {
            try
            {
                Connection.Close();
                Connection = null;
            }
            catch (Exception)
            {
            }

        }
    }
}
