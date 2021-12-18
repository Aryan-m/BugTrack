using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        // dependency injection
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            this._config = config;
        }

        /****************************************************************
         * Executes a stored procedure for loading
         * **************************************************************/
        public async Task<IEnumerable<T>> LoadData<T, U>(
            string sprocName,
            U parameters,
            string connectionString = "Default")
        {
            using IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString(connectionString));
            return await dbConnection.QueryAsync<T>(
                    sprocName, parameters, commandType: CommandType.StoredProcedure);
        }

        /****************************************************************
         * Executes a stored procedure for inserting
         * 
         * returns number of rows changed
         * **************************************************************/
        public async Task<int> SaveData<T>(
            string sprocName,
            T parameters,
            string connectionID = "Default")
        {
            try
            {
                using IDbConnection dbConnection = new SqlConnection(_config.GetConnectionString(connectionID));
                return await dbConnection.QuerySingleAsync<int>(sprocName, parameters, commandType: CommandType.StoredProcedure);
            } catch (Exception e)
            {
                return 0;
            }
        }
    }
}
