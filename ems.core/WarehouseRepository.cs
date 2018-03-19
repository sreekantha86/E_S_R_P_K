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
    public class WarehouseRepository : BaseRepository
    {
        public int Create(Warehouse model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"INSERT INTO Warehouse(
                                whCode
                                ,whName
                                ,whAddress
                                ,whTel
                                ,whMob
                                ,whEmail
                                ,whContactPerson)
                                select 
                                @whCode
                                ,@whName
                                ,@whAddress
                                ,@whTel
                                ,@whMob
                                ,@whEmail
                                ,@whContactPerson";
                int rowsAffected = connection.Execute(query, model);
                SetIdentity<int>(connection, id => model.whId = id);
                return rowsAffected;
            }
        }
        public List<Warehouse> GetWarehouseList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [whId]
                                      ,[whCode]
                                      ,[whName]
                                      ,[whTel]
                                      ,[whMob]
                                      ,[whEmail]
                                      ,[whContactPerson]
                                  FROM [dbo].[Warehouse]";
                return connection.Query<Warehouse>(query, commandType: CommandType.Text).ToList();
            }
        }
        public Warehouse GetWarehouse(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [whId]
                                      ,[whCode]
                                      ,[whName]
                                      ,[whAddress]
                                      ,[whTel]
                                      ,[whMob]
                                      ,[whEmail]
                                      ,[whContactPerson]
                                  FROM [dbo].[Warehouse]
                                    WHERE [whId] = " + Id.ToString();
                return connection.QueryFirstOrDefault<Warehouse>(query, commandType: CommandType.Text);
            }
        }
        public int Edit(Warehouse model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE Warehouse SET
                                whCode=@whCode
                                ,whName=@whName
                                ,whAddress=@whAddress
                                ,whTel=@whTel
                                ,whMob=@whMob
                                ,whEmail=@whEmail
                                ,whContactPerson=@whContactPerson
                                WHERE whId=@whId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
    }
}
