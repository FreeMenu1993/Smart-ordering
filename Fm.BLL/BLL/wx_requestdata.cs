﻿/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/  
using System;
using System.Web;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Fm.WebCommon;

namespace Fm.BLL{
	public partial class wx_requestdata
	{	     
		private readonly Fm.DAL.wx_requestdata dal = new Fm.DAL.wx_requestdata();
		
		#region GetListCustomByXxx 方法，根据Xxx取出  信息(自定义字段)
        /// <summary>
        /// 获得wx_requestdata数据列表(独立连接)
        /// <param name="Xxx"></param>
        /// </summary>
        public List<Fm.Entity.wx_requestdata> GetListCustomByXxx(string Xxx)
        {
            List<Fm.Entity.wx_requestdata> myList = new List<Fm.Entity.wx_requestdata>();
            DBHelper myHelperMySQL = new DBHelper();
            myHelperMySQL.connectionStr = MySQLConfig.ConnStringCenter;
            try
            {
                myList = this.GetListCustomByXxx(myHelperMySQL, Xxx);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + 
					((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return myList;
        }
        /// <summary>
        /// 获得wx_requestdata数据列表，(方法外传入连接对象，需要人工关闭连接)
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx"></param>
        /// </summary>
        public List<Fm.Entity.wx_requestdata> GetListCustomByXxx(DBHelper myHelperMySQL, string Xxx)
        {
            List<Fm.Entity.wx_requestdata> myList = new List<Fm.Entity.wx_requestdata>();

            //字段
            string fieldSelect = "";
            fieldSelect = "a.Xxx, a.Yyy ";

            //条件
            string strWhere = "Xxx=@Xxx";
            //排序
            string fieldOrder = "createdate desc";
            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("Xxx", Xxx)
            };

            myList = dal.GetList(myHelperMySQL, 0, fieldSelect, strWhere, fieldOrder, parms);

            return myList;
        }
        #endregion

        #region GetListNumByXxx 方法，根据Xxx取出符合条件记录数量(自定义字段)
        /// <summary>
        /// 获得wx_requestdata数据列表记录数(独立连接)
        /// <param name="Xxx"></param>
        /// </summary>
        public int GetListNumByXxx(string Xxx)
        {
            int Num = 0;
            DBHelper myHelperMySQL = new DBHelper();
            myHelperMySQL.connectionStr = MySQLConfig.ConnStringCenter;
            try
            {
                Num = this.GetListNumByXxx(myHelperMySQL, Xxx);
            }
            catch (Exception errorStr)
            {
               #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + 
					((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return Num;
        }
        /// <summary>
        /// 获得wx_requestdata数据列表记录数，(方法外传入连接对象，需要人工关闭连接)
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx"></param>
        /// </summary>
        public int GetListNumByXxx(DBHelper myHelperMySQL, string Xxx)
        {
            int Num = 0;


            //条件
            string strWhere = "Xxx=@Xxx";

            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("Xxx", Xxx)
            };

            Num = dal.GetListNum(myHelperMySQL, strWhere, parms);

            return Num;
        }
        #endregion

        #region UpdateCustom 方法，更新指定字段
        /// <summary>
        /// 更新wx_requestdata指定字段(独立连接)
        /// </summary>
        /// <param name="Xxx">条件</param>
        /// <param name="Vvv1">值1</param>
        /// <param name="Vvv2">值2</param>
        /// <returns>生效记录数</returns>
        public int UpdateCustom(string Xxx, string Vvv1, string Vvv2)
        {
            int iNum = 0;
            DBHelper myHelperMySQL = new DBHelper();
            myHelperMySQL.connectionStr = MySQLConfig.ConnStringCenter;
            try
            {
                iNum = this.UpdateCustom(myHelperMySQL, Xxx, Vvv1, Vvv2);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + 
					((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 更新wx_requestdata指定字段，(方法外传入连接对象，需要人工关闭连接)
        /// </summary>
        /// <param name="myDbHelperC">自定义数据连接对象实例</param>
        /// <param name="Xxx">条件</param>
        /// <param name="Vvv1">值1</param>
        /// <param name="Vvv2">值2</param>
        /// <returns>生效记录数</returns>
        public int UpdateCustom(DBHelper myHelperMySQL, string Xxx, string Vvv1, string Vvv2)
        {
            int iNum = 0;
            List<Fm.Entity.wx_requestdata> myList = new List<Fm.Entity.wx_requestdata>();

            //条件
            string strWhere = "Xxx=@Xxx";

            //字段
            string fieldUpdate = "Field1=@Vvv1,Field2=@Vvv2 ";
            //参数

            MySqlParameter[] parms = 
			{
                new MySqlParameter("Xxx",Xxx),
                new MySqlParameter("Field1",Vvv1),
                new MySqlParameter("Field2",Vvv2)
			};

            iNum = dal.Update(myHelperMySQL, strWhere, fieldUpdate, parms);
            return iNum;


        }
        #endregion

        #region DeleteByXxx 方法，删除指定条件记录
        /// <summary>
        /// 删除wx_requestdata指定条件记录(独立连接)
        /// </summary>
        /// <param name="Xxx">条件</param>
        /// <returns>生效记录数</returns>
        public int DeleteByXxx(string Xxx)
        {
            int iNum = 0;
            DBHelper myHelperMySQL = new DBHelper();
            myHelperMySQL.connectionStr = MySQLConfig.ConnStringCenter;
            try
            {
                iNum = this.DeleteByXxx(myHelperMySQL, Xxx);
            }
            catch (Exception errorStr)
            {
                #region 出错打印日志
                //打印日志-----------------------------------------------------------------

                string MailContent = "服务器出现错误!" + ((char)13).ToString() + ((char)10).ToString() +
                    "地址：" + HttpContext.Current.Request.ServerVariables.Get("LOCAL_ADDR").ToString() + ((char)13).ToString() + 
					((char)10).ToString() +
                    "时间：" + DateTime.Now.ToString("yyyy-MM-dd") + ((char)13).ToString() + ((char)10).ToString() +
                    "内容：" + errorStr.ToString() + ((char)13).ToString() + ((char)10).ToString() + " ";

                //-------------------------------------------------------------------------------
                #endregion
            }
            return iNum;
        }
        /// <summary>
        /// 删除wx_requestdata指定条件记录，(方法外传入连接对象，需要人工关闭连接)
        /// </summary>
        /// <param name="myHelperMySQL">自定义数据连接对象实例</param>
        /// <param name="Xxx">条件</param>
        /// <returns>生效记录数</returns>
        public int DeleteByXxx(DBHelper myHelperMySQL, string Xxx)
        {
            int iNum = 0;
            List<Fm.Entity.wx_requestdata> myList = new List<Fm.Entity.wx_requestdata>();

            //条件
            string strWhere = "Xxx=@Xxx";

            //参数
            MySqlParameter[] parms =
            {
                new MySqlParameter("Xxx", Xxx)
            };

            iNum = dal.Delete(myHelperMySQL, strWhere, parms);
            return iNum;


        }
        #endregion

	}
}