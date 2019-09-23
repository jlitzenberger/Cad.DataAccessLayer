using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Dynamic;
using Cad.DataAccessLayer.Context;
using Cad.DataAccessLayer.Repositories.Interfaces;

namespace Cad.DataAccessLayer.Repositories
{
    public class GenericSqlDataRepository : IGenericSqlDataRepository
    {
        internal CadEntities Context;

        public GenericSqlDataRepository(CadEntities context)
            
        {
            this.Context = context;
        }

        public IEnumerable<dynamic> RunRawSqlDynamic(string sql)
        {
            using (var cmd = Context.Database.Connection.CreateCommand())
            {
                cmd.CommandText = sql;
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                //var retObject = new List<dynamic>();
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var dataRow = GetDataRow(dataReader);
                        //retObject.Add(dataRow);
                        yield return dataRow;
                    }

                    //return retObject;
                }
            }            
        }

        private static dynamic GetDataRow(DbDataReader dataReader)
        {
            var dataRow = new ExpandoObject() as IDictionary<string, object>;
            for (var fieldCount = 0; fieldCount < dataReader.FieldCount; fieldCount++)
                dataRow.Add(dataReader.GetName(fieldCount), dataReader[fieldCount]);
            return dataRow;
        }

        public IEnumerable<T> RunRawSql<T>(string sql)
        {
            return Context.Database.SqlQuery<T>(sql);
        }

        public int ExecuteSqlCommand(string query, params object[] parameters)
        {
            return Context.Database.ExecuteSqlCommand(query, parameters);
        }
    }
}
