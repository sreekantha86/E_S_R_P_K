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
    public class DropDownRepository: BaseRepository
    {
        public List<ProductType> GetProductTypes()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select prdTypeId, prdTypeName from ProductType";
                return connection.Query<ProductType>(query, commandType: CommandType.Text).ToList();
            }
        }
        public List<ProductMainGroup> GetProductMainGroup()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [prdMGId]
                                  ,[prdMGHSN]
                                  ,[prdMGName]
                                  ,[prdTypeId]
                                  ,[prdMGRemarks]
                              FROM [dbo].[ProductMainGroup]";
                return connection.Query<ProductMainGroup>(query, commandType: CommandType.Text).ToList();
            }
        }
        public List<GST> GetGSTRate()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [gstId]
                                      ,[gstName]
                                      ,[gstRate]
                                      ,[gstSgstRate]
                                      ,[gstCgstRate]
                                      ,[gstSpRemarks]
                                  FROM [dbo].[GSTRates]";
                return connection.Query<GST>(query, commandType: CommandType.Text).ToList();
            }
        }
    }
}
