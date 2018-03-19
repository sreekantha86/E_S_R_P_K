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
    public class ProductMainGroupRepository : BaseRepository
    {
        public List<ProductMainGroupViewModel> GetProductMainGroupList()
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select A.prdMGId, A.prdMGHSN, A.prdMGName, A.prdTypeId, A.prdMGRemarks, B.prdTypeName
                from ProductMainGroup A inner join ProductType B on A.prdTypeId = B.prdTypeId";

                return connection.Query<ProductMainGroupViewModel>(query, commandType: CommandType.Text).ToList();
            }
        }
        public int Create(ProductMainGroup model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"INSERT INTO ProductMainGroup(
                                prdMGHSN
                                ,prdMGName
                                ,prdTypeId
                                ,prdMGRemarks
                                )
                                select 
                                @prdMGHSN
                                ,@prdMGName
                                ,@prdTypeId
                                ,@prdMGRemarks";
                int rowsAffected = connection.Execute(query, model);
                SetIdentity<int>(connection, id => model.prdMGId = id);
                return rowsAffected;
            }
        }
        public int Edit(ProductMainGroup model)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"UPDATE ProductMainGroup SET
                                prdMGHSN = @prdMGHSN
                                ,prdMGName = @prdMGName
                                ,prdTypeId = @prdTypeId
                                ,prdMGRemarks = @prdMGRemarks
                                WHERE prdMGId = @prdMGId";
                int rowsAffected = connection.Execute(query, model);
                return rowsAffected;
            }
        }
        public ProductMainGroup GetProductMainGroup(int Id)
        {
            using (IDbConnection connection = OpenConnection(sqlConnString))
            {
                string query = @"select A.prdMGId, A.prdMGHSN, A.prdMGName, A.prdTypeId, A.prdMGRemarks
                from ProductMainGroup A Where A.prdMGId = " + Id.ToString();

                return connection.QuerySingleOrDefault<ProductMainGroup>(query, commandType: CommandType.Text);
            }
        }
    }
}
