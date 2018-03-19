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
    public class ProductSubGroupRepository : BaseRepository
    {
        public List<ProductSubGroupViewModel> GetProductSubGroupList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select A.prdSGId, A.prdSGCode, A.prdSGName, A.prdMGId, A.gstId, A.prdSGRemarks,
                B.prdMGName, C.gstName
                from ProductSubGroup A
                inner join ProductMainGroup B on A.prdMGId = B.prdMGId
                inner join GSTRates C on A.gstId = C.gstId";

                return connection.Query<ProductSubGroupViewModel>(query, commandType: CommandType.Text).ToList();
            }
        }

        public int Create(ProductSubGroup model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"INSERT INTO ProductSubGroup(
                                prdSGCode
                                ,prdSGName
                                ,prdMGId
                                ,gstId
                                ,prdSGRemarks
                                )
                                select 
                                @prdSGCode
                                ,@prdSGName
                                ,@prdMGId
                                ,@gstId
                                ,@prdSGRemarks";
                int rowsAffected = connection.Execute(query, model);
                SetIdentity<int>(connection, id => model.prdSGId = id);
                return rowsAffected;
            }
        }
        public int Edit(ProductSubGroup model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE ProductSubGroup SET
                                prdSGCode=@prdSGCode
                                ,prdSGName=@prdSGName
                                ,prdMGId=@prdMGId
                                ,gstId=@gstId
                                ,prdSGRemarks=@prdSGRemarks
                                WHERE prdSGId=@prdSGId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
        public ProductSubGroup GetProductSubGroup(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select A.prdSGId, A.prdSGCode, A.prdSGName, A.prdMGId, A.gstId, A.prdSGRemarks
                from ProductSubGroup A
                WHERE A.prdSGId=" + Id.ToString();

                return connection.QuerySingleOrDefault<ProductSubGroup>(query, commandType: CommandType.Text);
            }
        }
    }
}
