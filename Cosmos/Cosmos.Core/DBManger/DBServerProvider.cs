using Cosmos.Core.Configuration;
using Cosmos.Core.Const;
using Cosmos.Core.Dapper;
using Cosmos.Core.Enums;
using Cosmos.Core.Extension;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cosmos.Core.DBManger
{
    /// <summary>
    /// 从配置文件获取数据库连接字符串
    /// </summary>
    public class DBServerProvider
    {
        private static Dictionary<string, string> DBConnectionPool = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private static readonly string DefaultConnectionName = "default";


        #region Constroctor
        public DBServerProvider()
        {
            // Initialization Connection Pool
            SetConnectionString(DefaultConnectionName, AppSetting.DbConnectionString);
        }
        #endregion

        #region Set Connection String, push connection string into connection pool
        public static void SetConnectionString(string key, string value)
        {
            if (DBConnectionPool.ContainsKey(key))
            {
                DBConnectionPool[key] = value;
                return;
            }
            DBConnectionPool.Add(key, value);
        }
        #endregion


        #region Get Connection String
        public static string GetConnectionString(string key)
        {
            key = key ?? DefaultConnectionName;
            if (DBConnectionPool.ContainsKey(key))
            {
                return DBConnectionPool[key];
            }
            return key;
        }
        public static string GetConnectionString()
        {
            return DBConnectionPool[DefaultConnectionName];
        }
        #endregion


        #region Get DB Connection Object
        public static IDbConnection GetDbConnection(string connectionString = null)
        {
            if (connectionString == null)
            {
                connectionString = DBConnectionPool[DefaultConnectionName];
            }
            else if (DBType.Name == DbCurrentType.MySql.ToString())
            {
                return new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            }
            if (DBType.Name == DbCurrentType.PgSql.ToString())
            {
                return new NpgsqlConnection(connectionString);
            }

            return new Microsoft.Data.SqlClient.SqlConnection(connectionString);
        }
        #endregion

        #region Get Dapper Object
        public static ISqlDapper SqlDapper
        { 
            get {
                return new SqlDapper(DefaultConnectionName);
            }
        }

        public static ISqlDapper GetSqlDapper (string dbName = null)
        {
            return new SqlDapper(dbName ?? DefaultConnectionName);
        }

        public static ISqlDapper GetSqlDapper<TEntity>()
        {
            string dbName = typeof(TEntity).GetTypeCustomValue<DBConnectionAttribute>(x => x.DBName) ?? DefaultConnectionName;
            return GetSqlDapper(dbName);
        }
        #endregion



    }
}
