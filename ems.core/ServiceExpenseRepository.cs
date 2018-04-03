using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ems.domain;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using ems.domain.ViewModels;

namespace ems.core
{
    public class ServiceExpenseRepository : BaseRepository
    {
        public List<ServiceExpenseViewModel> GetSeviceExpenseList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT A.[SerId]
                                  ,A.[SerSAC]
                                  ,A.[SerName]
                                  ,A.[gstId]
                                  ,A.[SerOrExp]
                                  ,A.[SerRemarks]
	                              ,B.[gstName]
                              FROM [dbo].[ServiceExpense] A
                              INNER JOIN [GSTRates] B on A.[gstId] = B.[gstId]
                              ORDER BY A.[SerName]";

                return connection.Query<ServiceExpenseViewModel>(query, commandType: CommandType.Text).ToList();
            }
        }
        public int Create(ServiceExpense model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"INSERT INTO ServiceExpense(
                                SerSAC
                                ,SerName
                                ,gstId
                                ,SerOrExp
                                ,SerRemarks
                                )
                                select 
                                @SerSAC
                                ,@SerName
                                ,@gstId
                                ,@SerOrExp
                                ,@SerRemarks";
                int rowsAffected = connection.Execute(query, model);
                SetIdentity<int>(connection, id => model.SerId = id);
                return rowsAffected;
            }
        }
        public int Edit(ServiceExpense model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE ServiceExpense SET
                                SerSAC = @SerSAC
                                ,SerName = @SerName
                                ,gstId = @gstId
                                ,SerOrExp = @SerOrExp
                                ,SerRemarks = @SerRemarks
                                WHERE SerId=@SerId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
        public ServiceExpense GetServiceExpense(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [SerId]
                              ,[SerSAC]
                              ,[SerName]
                              ,[gstId]
                              ,[SerOrExp]
                              ,[SerRemarks]
                            FROM [dbo].[ServiceExpense]
                            WHERE [SerId] = " + Id.ToString();

                return connection.QuerySingleOrDefault<ServiceExpense>(query, commandType: CommandType.Text);
            }
        }
    }
}
