using Cosmos.Core.Configuration;
using Cosmos.Entity.DomainModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core.Services
{
    // 通过内置队列异步定时写日志
  public static class Logger
    {
        static Logger()
        {
            Task.Run(() => { Start(); });
        }
        public static readonly object _logger = new object();
        public static Queue<Sys_LogEntity> loggerQueueData = new Queue<Sys_LogEntity>();
        private static DateTime lastClearFileDT = DateTime.Now.AddDays(-1);
        private static string _loggerPath=AppSetting.DownLoadPath+"Logger\\Queue\\";

        public static void Start()
        {
            DataTable queueTable = CreateEmpptyTable();
            while (true)
            {
                try
                {
                    if (loggerQueueData.Count()>0 && queueTable.Rows.Count<500)
                    {

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// Create Empty Log Table
        /// </summary>
        /// <returns></returns>
        private static DataTable CreateEmpptyTable()
        {
            DataTable queueTable = new DataTable();
            queueTable.Columns.Add("LogType", typeof(string));
            queueTable.Columns.Add("RequestParameter", typeof(string));
            queueTable.Columns.Add("ResponseParameter", typeof(string));
            queueTable.Columns.Add("ExceptionInfo", typeof(string));
            queueTable.Columns.Add("Success", Type.GetType("System.Int32"));
            queueTable.Columns.Add("BeginDate", Type.GetType("System.DateTime"));
            queueTable.Columns.Add("EndDate", Type.GetType("System.DateTime"));
            queueTable.Columns.Add("ElapsedTime", Type.GetType("System.Int32"));
            queueTable.Columns.Add("UserIP", typeof(string));
            queueTable.Columns.Add("ServiceIP", typeof(string));
            queueTable.Columns.Add("BrowserType", typeof(string));
            queueTable.Columns.Add("Url", typeof(string));
            queueTable.Columns.Add("User_Id", Type.GetType("System.Int32"));
            queueTable.Columns.Add("UserName", typeof(string));
            queueTable.Columns.Add("Role_Id", Type.GetType("System.Int32"));

            return queueTable;
        }

        /// <summary>
        /// Dequeue to Data Table
        /// </summary>
        /// <param name="queueTable"></param>
        private static void DequeueToTable(DataTable queueTable)
        {
            Sys_LogEntity log = loggerQueueData.Dequeue();// 出列
            DataRow row = queueTable.NewRow();


        }

    }

    public enum LoggerStatus
    {
        Success=1,
        Error,
        Info
    }
}
