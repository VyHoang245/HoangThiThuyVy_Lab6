using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Exercise2
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public GenericRepository(SqlConnection connection)
        {
            _connection = connection;
        }
        public List<T> GetAll(string tableName, Func<SqlDataReader, T> map)
        {
            var items = new List<T>();
            using (var command = new SqlCommand($"SELECT * FROM {tableName}", _connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(map(reader)); // Map each record to an object
                    }
                }
            }
            return items;
        }
    }
}
