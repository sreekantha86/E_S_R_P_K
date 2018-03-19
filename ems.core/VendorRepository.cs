using ems.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ems.core
{
    public class VendorRepository: BaseRepository
    {
        public List<Country> GetCountryList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [CountryId]
                                  ,[CountryName]
                                  ,[Region]
                              FROM [dbo].[Country]";

                return connection.Query<Country>(query, commandType: CommandType.Text).ToList();
            }
        }
        public List<VendorType> GetVendorTypeList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [VendorTypeId]
                                  ,[VendorTypeName]
                              FROM [dbo].[VendorType]";

                return connection.Query<VendorType>(query, commandType: CommandType.Text).ToList();
            }
        }
        public List<Vendor> GetVendorList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select A.VendorId, A.VendorCode, A.VendorName, A.Email, A.PhoneNumber, A.ContactPerson, A.GSTRegNo
                from vendor A";

                return connection.Query<Vendor>(query, commandType: CommandType.Text).ToList();
            }
        }
        public Vendor GetVendorDetails(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"SELECT [VendorId]
                                  ,[VendorCode]
                                  ,[VendorName]
                                  ,[Address]
                                  ,[PhoneNumber]
                                  ,[City]
                                  ,[District]
                                  ,[PAN]
                                  ,[ContactPerson]
                                  ,[Email]
                                  ,[VendorTypeId]
                                  ,[CountryId]
                                  ,[GSTRegistered]
                                  ,[GSTRegNo]
                              FROM [dbo].[Vendor] WHERE [VendorId]=" + Id.ToString();

                return connection.QuerySingleOrDefault<Vendor>(query, commandType: CommandType.Text);
            }
        }
        public int Create(Vendor model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[Vendor]
                                   ([VendorCode]
                                   ,[VendorName]
                                   ,[Address]
                                   ,[PhoneNumber]
                                   ,[City]
                                   ,[District]
                                   ,[PAN]
                                   ,[ContactPerson]
                                   ,[Email]
                                   ,[VendorTypeId]
                                   ,[CountryId]
                                   ,[GSTRegistered]
                                   ,[GSTRegNo])
                             VALUES
                                   (@VendorCode
                                   ,@VendorName
                                   ,@Address
                                   ,@PhoneNumber
                                   ,@City
                                   ,@District
                                   ,@PAN
                                   ,@ContactPerson
                                   ,@Email
                                   ,@VendorTypeId
                                   ,@CountryId
                                   ,@GSTRegistered
                                   ,@GSTRegNo)";
                    int rowsAffected = connection.Execute(query, model);
                    SetIdentity<int>(connection, id => model.VendorId = id);
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public int Edit(Vendor model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                try
                {
                    string query = @"UPDATE [dbo].[Vendor] SET
                                   [VendorCode]=@VendorCode
                                   ,[VendorName]=@VendorName
                                   ,[Address]=@Address
                                   ,[PhoneNumber]=@PhoneNumber
                                   ,[City]=@City
                                   ,[District]=@District
                                   ,[PAN]=@PAN
                                   ,[ContactPerson]=@ContactPerson
                                   ,[Email]=@Email
                                   ,[VendorTypeId]=@VendorTypeId
                                   ,[CountryId]=@CountryId
                                   ,[GSTRegistered]=@GSTRegistered
                                   ,[GSTRegNo]=@GSTRegNo
                                   WHERE [VendorId]=@VendorId";
                    int rowsAffected = connection.Execute(query, model);
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
