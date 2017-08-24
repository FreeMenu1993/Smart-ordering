using System;
using System.Configuration;
using System.Text;
using Fm.Core.DEncrypt;

namespace Fm.WebCommon
{
    
    public class MySQLConfig
    {

        private static readonly string strSQLServerIp = ConfigurationManager.AppSettings["strSQLServerIp"].ToString().Trim();
        private static readonly string strSQLDBUserName = ConfigurationManager.AppSettings["strSQLDBUserName"].ToString().Trim();
        private static readonly string strSQLDBPassword = ConfigurationManager.AppSettings["strSQLDBPassword"].ToString().Trim();
        private static readonly string strSQLDBName = ConfigurationManager.AppSettings["strSQLDBName"].ToString().Trim();
        private const int MaxPool = 10;//最大连接数
        private const int MinPool = 5;//最小连接数        
        private const int Conn_Timeout = 15;//设置连接等待时间
        private const int Conn_Lifetime = 15;//设置连接的生命周期
        private const bool Asyn_Process = true;//设置异步访问数据库

        /// <summary>
        /// 中心库(连接池)
        /// </summary>
        public static string ConnStringCenter
        {           
            get 
            {
                StringBuilder strConn = new StringBuilder();
                if (ConfigurationManager.AppSettings["ConStringEncrypt"] == "true")
                {
                    strConn.Append(DESEncrypt.Decrypt(strSQLServerIp));
                    strConn.Append(DESEncrypt.Decrypt(strSQLDBUserName));
                    strConn.Append(DESEncrypt.Decrypt(strSQLDBPassword));
                    strConn.Append(DESEncrypt.Decrypt(strSQLDBName));
                }
                else
                {
                    strConn.Append(strSQLServerIp);
                    strConn.Append(strSQLDBUserName);
                    strConn.Append(strSQLDBPassword);
                    strConn.Append(strSQLDBName);
                }
                strConn.Append("MaxPoolSize=" + MaxPool + ";");
                strConn.Append("MinPoolSize=" + MinPool + ";");
                strConn.Append("ConnectTimeout=" + Conn_Timeout + ";");
                strConn.Append("ConnectionLifetime=" + Conn_Lifetime + ";");
                strConn.Append("AsynchronousProcessing=" + Asyn_Process + ";");
                return strConn.ToString();
            }
        }


    }
}
