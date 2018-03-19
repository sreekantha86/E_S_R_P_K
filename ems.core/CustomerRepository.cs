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
    public class CustomerRepository: BaseRepository
    {
        public List<Customer> GetCustomerList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [CusId]
                                  ,[CusCode]
                                  ,[CusName]
                                  ,[Phone]
                                  ,[Fax]
                                  ,[Email]
                                  ,[ContactPerson]
                                  ,[Address]
                                  ,[GSTNo]
                              FROM [dbo].[Customer] ORDER BY [CusName]";

                return connection.Query<Customer>(query, commandType: CommandType.Text).ToList();
            }
        }
        public int Create(Customer model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"INSERT INTO Customer(
                                CusCode
                                ,CusName
                                ,Phone
                                ,Fax
                                ,Email
                                ,ContactPerson
                                ,Address
                                ,GSTNo
                                )
                                select 
                                 @CusCode
                                ,@CusName
                                ,@Phone
                                ,@Fax
                                ,@Email
                                ,@ContactPerson
                                ,@Address
                                ,@GSTNo";
                int rowsAffected = connection.Execute(query, model);
                SetIdentity<int>(connection, id => model.CusId = id);
                return rowsAffected;
            }
        }
        public int Edit(Customer model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE Customer SET
                                CusCode=@CusCode
                                ,CusName=@CusName
                                ,Phone=@Phone
                                ,Fax=@Fax
                                ,Email=@Email
                                ,ContactPerson=@ContactPerson
                                ,Address=@Address
                                ,GSTNo=@GSTNo
                                WHERE CusId = @CusId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
        public Customer GetCustomer(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [CusId]
                                  ,[CusCode]
                                  ,[CusName]
                                  ,[Phone]
                                  ,[Fax]
                                  ,[Email]
                                  ,[ContactPerson]
                                  ,[Address]
                                  ,[GSTNo]
                              FROM [dbo].[Customer] WHERE [CusId]="+Id.ToString();

                return connection.QuerySingleOrDefault<Customer>(query, commandType: CommandType.Text);
            }
        }
    }
}
