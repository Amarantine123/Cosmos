using Cosmos.Core.Const;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.Configuration
{
    public class AppSetting
    {
        public static IConfiguration Configuration{ get; set; }
        private static Connection _connection;

        #region OnlyRead Properties
        // Get Datanase connection string
        public static string DbConnectionString {
            get { return _connection.DbCinnectionString; }    
        }
        // Get Redis connection string
        public static string RedisConnectionString {
            get { return _connection.RedisConnectionString; }
        }
        // Judge if use Redis
        public static bool UseRedis
        {
            get { return _connection.UseRedis; }
        }
        #endregion

        #region Properties
        public static Secret Secret { get; set; }
        public static  ModifyMember ModifyMember { get; set; }
        public static CreateMember CreateMember { get; set; }

        public static string TokenHeaderName = "Authorization";
        

        // Action 权限过滤
        public static GlobalFilter GlobalFilter { get; set; }

        // Set JWT of expire time
        public static int ExpMinutes { get; private set; } = 120;

        // Set current path
        public static string CurrentPath { get; private set; } = null;
        // Set DownLoad path
        public static string DownLoadPath { get { return CurrentPath + "\\DownLoad\\"; } }
        #endregion

        #region Action
        public static void Init(IServiceCollection services,IConfiguration configuration)
        {
            Configuration = configuration;

            //services.Configure<Secret>()
        }
        #endregion

    }



}
