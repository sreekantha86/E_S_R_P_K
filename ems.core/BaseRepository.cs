using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ems.core
{
    public class BaseRepository: SQLConnection
    {
        public string sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings["emscon"].ToString();
        protected static void SetIdentity<T>(IDbConnection connection, Action<T> setId)
        {
            dynamic identity = connection.Query("SELECT @@IDENTITY AS Id").Single();
            T newId = (T)identity.Id;
            setId(newId);
        }
    }
}
