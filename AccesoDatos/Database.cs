using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Database
    {
        private SqlConnection connection;
        private SqlCommand command;
        public SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public Database()
        {
            connection = new SqlConnection("Data Source=localhost,15000;Initial Catalog=CATALOGO_P3_DB;User Id=sa; Password=Password@1234");
            command = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void SetProcedure(string sp)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sp;
        }

        public void SetParameter(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }

        public void ReadData()
        {
            command.Connection = connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open) connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public void ExecuteNonQuery()
        {
            command.Connection = connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public int ExecuteScalar()
        {
            command.Connection = connection;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }


        public void CloseConnection()
        {
            if (reader != null) reader.Close();
            connection.Close();
        }
    }
}