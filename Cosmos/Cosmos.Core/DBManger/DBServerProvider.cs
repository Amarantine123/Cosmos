using Cosmos.Core.Configuration;
using Cosmos.Core.Const;
using Cosmos.Core.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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




        public DBServerProvider()
        {
            // Initialization Connection Pool
            SetConnectionString(DefaultConnectionName, AppSetting.DbConnectionString);
        }


        /// <summary>
        /// Set Connection String, push connection string into connection pool
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetConnectionString(string key, string value)
        {
            if (DBConnectionPool.ContainsKey(key))
            {
                DBConnectionPool[key] = value;
                return;
            }
            DBConnectionPool.Add(key, value);
        }


        public static string  GetConnectionString(string key)
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


        public IDbConnection GetDbConnection(string connectionString=null)
        {
            if (connectionString==null)
            {
                connectionString = DBConnectionPool[DefaultConnectionName];
            }
            else if (DBType.Name== DbCurrentType.MySql.ToString())
            {
                //return new MySql
            }


            return new SqlConnection(connectionString);
        }
    }
}
