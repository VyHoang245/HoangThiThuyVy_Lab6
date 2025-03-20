using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Exercise2
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(string tableName, Func<SqlDataReader, T> map);

    }
}
