using System;
using System.Configuration;
using System.Text;
using Fm.Core.DEncrypt;

namespace Fm.WebCommon
{
    
    public class MySQLConfig
    {
        private static readonly string ConStringEncrypt = "flase";
        private static readonly string strSQLServerIp = "server=180.76.171.127;";
        private static readonly string strSQLDBUserName = "database=bookdinner;";
        private static readonly string strSQLDBPassword = "uid=sa;";
        private static readonly string strSQLDBName = "pwd=lz2688;";
        private static readonly int MaxPool = 10;//最大连接数
        private static readonly int MinPool = 5;//最小连接数        
        private static readonly int Conn_Timeout = 15;//设置连接等待时间
        private static readonly int Conn_Lifetime = 15;//设置连接的生命周期
        private static readonly bool Asyn_Process = true;//设置异步访问数据库
        private static readonly string str = "server=180.76.171.127;user id=sa;password=lz2688;database=bookdinner;maxpoolsize=10;minpoolsize=5;connectiontimeout=15;connectionlifetime=15";
        /// <summary>
        /// 中心库(连接池)
        /// </summary>
        public static string ConnStringCenter
        {           
            get 
            {
                StringBuilder strConn = new StringBuilder();
                //if (ConStringEncrypt == "true")
                //{
                //    strConn.Append(DESEncrypt.Decrypt(strSQLServerIp));
                //    strConn.Append(DESEncrypt.Decrypt(strSQLDBUserName));
                //    strConn.Append(DESEncrypt.Decrypt(strSQLDBPassword));
                //    strConn.Append(DESEncrypt.Decrypt(strSQLDBName));
                //}
                //else
                //{
                //    strConn.Append(strSQLServerIp);
                //    strConn.Append(strSQLDBUserName);
                //    strConn.Append(strSQLDBPassword);
                //    strConn.Append(strSQLDBName);
                //}
                //strConn.Append("MaxPoolSize=" + MaxPool + ";");
                //strConn.Append("MinPoolSize=" + MinPool + ";");
                //strConn.Append("ConnectTimeout=" + Conn_Timeout + ";");
                //strConn.Append("ConnectionLifetime=" + Conn_Lifetime + ";");
                //strConn.Append("AsynchronousProcessing=" + Asyn_Process + ";");
                //return strConn.ToString();
                return str;
            }
        }


    }
}
