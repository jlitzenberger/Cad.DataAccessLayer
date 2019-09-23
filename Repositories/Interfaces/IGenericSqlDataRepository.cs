using System.Collections.Generic;

namespace Cad.DataAccessLayer.Repositories.Interfaces
{
    public interface IGenericSqlDataRepository
    {
        IEnumerable<T> RunRawSql<T>(string sql);
        int ExecuteSqlCommand(string query, params object[] parameters);    
        IEnumerable<dynamic> RunRawSqlDynamic(string sql);
    }
}
