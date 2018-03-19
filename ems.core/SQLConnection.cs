using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ems.core
{
    public abstract class SQLConnection
    {
        public static string GetConnectionString(string connStrName)
        {
            try
            {

                return ConfigurationManager.ConnectionStrings[connStrName].ConnectionString;
            }
            catch (Exception ex)
            {
                string Error = ex.Message.ToString();
                throw new Exception(Error, ex);
            }
        }

        public static IDbConnection OpenConnection(string connStrName)
        {
            try
            {
                IDbConnection connection = new SqlConnection(connStrName);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                return connection;
            }
            catch (Exception ex)
            {
                string Error = ex.Message.ToString();
                throw new Exception(Error, ex);
            }

        }
    }
}
