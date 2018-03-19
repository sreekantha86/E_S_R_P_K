using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ems.domain;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace ems.core
{
    public class GSTRepository:BaseRepository
    {
        public int Create(GST model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"INSERT INTO GSTRates(
                                gstName
                                ,gstRate
                                ,gstSgstRate
                                ,gstCgstRate
                                ,gstSpRemarks)
                                select 
                                @gstName
                                ,@gstRate
                                ,@gstSgstRate
                                ,@gstCgstRate
                                ,@gstSpRemarks";
                int rowsAffected = connection.Execute(query, model);
                SetIdentity<int>(connection, id => model.gstId = id);
                return rowsAffected;                
            }
        }
        public List<GST> GetGSTList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select gstId,gstName,gstRate,gstSgstRate,gstCgstRate,gstSpRemarks from GSTRates";
                return connection.Query<GST>(query, commandType: CommandType.Text).ToList();
            }
        }
        public GST GetGSTRate(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select gstId,gstName,gstRate,gstSgstRate,gstCgstRate,gstSpRemarks from GSTRates where gstId=" + Id.ToString();
                return connection.QueryFirstOrDefault<GST>(query, commandType: CommandType.Text);
            }
        }
        public int Edit(GST model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE GSTRates SET
                                gstName = @gstName
                                ,gstRate = @gstRate
                                ,gstSgstRate = @gstSgstRate
                                ,gstCgstRate = @gstCgstRate
                                ,gstSpRemarks = @gstSpRemarks
                                WHERE gstId = @gstId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
    }
}
