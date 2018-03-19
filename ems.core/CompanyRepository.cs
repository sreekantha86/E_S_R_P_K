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
    public class CompanyRepository:BaseRepository
    {
        public Company GetCompanyDetails()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select
                                ComanyId
                                ,CompanyName
                                ,CompanyWebsite
                                ,ContactNumbers
                                ,CompanyMailId
                                ,CompanyAddress1
                                ,CompanyAddress2
                                ,CompanyAddress3
                                ,TIN
                                ,PAN
                                ,IECode
                                ,GSTRegistered
                                ,GSTNo
                                from Company";

                return connection.QuerySingleOrDefault<Company>(query, commandType: CommandType.Text);
            }
        }
        public int Edit(Company model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE Company SET
                CompanyName=@CompanyName
                ,CompanyWebsite=@CompanyWebsite
                ,ContactNumbers=@ContactNumbers
                ,CompanyMailId=@CompanyMailId
                ,CompanyAddress1=@CompanyAddress1
                ,CompanyAddress2=@CompanyAddress2
                ,CompanyAddress3=@CompanyAddress3
                ,TIN=@TIN
                ,PAN=@PAN
                ,IECode=@IECode
                ,GSTRegistered=@GSTRegistered
                ,GSTNo=@GSTNo
                WHERE ComanyId=@ComanyId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
    }
}
