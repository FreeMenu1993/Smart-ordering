/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/  
using System;
using System.Text;
using System.Data;
using System.Linq;
using Fm.WebCommon;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Fm.DAL{
	/// <summary>
    /// order_record数据访问层类
    /// </summary>
	public partial class order_record
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DBHelper myHelperMySQL ,Fm.Entity.order_record model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into order_record(");			
            strSql.Append("OrderID,UserID,TableCode,Amount,Discount,Mymoney,State,Createtime,Updatetime");
			strSql.Append(") values (");
            strSql.Append("@OrderID,@UserID,@TableCode,@Amount,@Discount,@Mymoney,@State,@Createtime,@Updatetime");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
			            new MySqlParameter("@OrderID", model.OrderID)  ,
                                    new MySqlParameter("@UserID", model.UserID)  ,
                                    new MySqlParameter("@TableCode", model.TableCode)  ,
                                    new MySqlParameter("@Amount", model.Amount)  ,
                                    new MySqlParameter("@Discount", model.Discount)  ,
                                    new MySqlParameter("@Mymoney", model.Mymoney)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据(所有字段)
		/// </summary>
		public int Update(DBHelper myHelperMySQL ,Fm.Entity.order_record model,string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update order_record set ");
			                        
            strSql.Append(" OrderID = @OrderID , ");                                    
            strSql.Append(" UserID = @UserID , ");                                    
            strSql.Append(" TableCode = @TableCode , ");                                    
            strSql.Append(" Amount = @Amount , ");                                    
            strSql.Append(" Discount = @Discount , ");                                    
            strSql.Append(" Mymoney = @Mymoney , ");                                    
            strSql.Append(" State = @State , ");                                    
            strSql.Append(" Createtime = @Createtime , ");                                    
            strSql.Append(" Updatetime = @Updatetime  ");                        			
			MySqlParameter[] parameters = {
			            new MySqlParameter("@OrderID", model.OrderID)  ,
                                    new MySqlParameter("@UserID", model.UserID)  ,
                                    new MySqlParameter("@TableCode", model.TableCode)  ,
                                    new MySqlParameter("@Amount", model.Amount)  ,
                                    new MySqlParameter("@Discount", model.Discount)  ,
                                    new MySqlParameter("@Mymoney", model.Mymoney)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)               
            };
            
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            
            int rows=myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);

			return rows;
		}
		
		 /// <summary>
        /// 更新一条数据，自定义条件和字段
        /// </summary>
        /// <param name="myDbHelperC">DbHelperC实例（数据访问类）.</param>
        /// <param name="strWhere">条件（重要）</param>
        /// <param name="filedUpdate">更新字段</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public int Update(DBHelper myHelperMySQL, string strWhere, string filedUpdate, MySqlParameter[] parameters)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update order_record set ");
            if (filedUpdate != "")
            {
                strSql.Append(filedUpdate);

                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                }
                int rows = myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);
                return rows;

            }
            else
            {
                return 0;
            }
        }
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(DBHelper myHelperMySQL ,string strWhere, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from order_record ");
			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }

			int rows=myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);
			return rows;
		}
	
		/// <summary>
        /// 得到一个对象实体(List类型)中指定条件记录数，数据连接类用DbHelperC（非静态）
        /// 表：PFWebSpecialityShop a
        ///     <param name="myHelperMySQL">myHelperMySQL实例（数据访问类）.</param>
        ///     <param name="strWhere">条件.</param>
        ///     <param name="dbParameters">参数(若条件中未使用参数可为null).</param>
        /// </summary>
        public int GetListNum(DBHelper myHelperMySQL, string strWhere, MySqlParameter[] parameters)
        {
            int Num = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" count(1) as Num ");
			strSql.Append("  FROM order_record  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<Fm.Entity.order_record> myList = new List<Fm.Entity.order_record>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    if (dr["Num"].ToString().Trim() != "")
                    {
                        Num = int.Parse(dr["Num"].ToString().Trim());
                    }
                }
                dr.Close();
            }
            return Num;
        }
		/// <summary>
        /// 得到一个对象实体(List类型)，数据连接类用myHelperMySQL（非静态）,查询全部数据
        /// 表：MessageBoard 
        /// <param name="myHelperMySQL">myHelperMySQL实例（数据访问类）.</param>
        /// <param name="Top">记录数.</param>
        /// <param name="strWhere">条件.</param>
        /// <param name="filedOrder">排序字段.</param>
        /// <param name="parameters">参数(若条件中未使用参数可为null).</param>
        /// </summary>
		public List<Fm.Entity.order_record> GetList(DBHelper myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" a.OrderID, a.UserID, a.TableCode, a.Amount, a.Discount, a.Mymoney, a.State, a.Createtime, a.Updatetime  ");			
			strSql.Append("  FROM order_record a ");
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            List<Fm.Entity.order_record> myList = new List<Fm.Entity.order_record>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.order_record model = new Fm.Entity.order_record();
                    
                    															model.OrderID= dr["OrderID"].ToString();
																																								model.UserID= dr["UserID"].ToString();
																																			if(dr["TableCode"].ToString()!="")
					{
						model.TableCode=int.Parse(dr["TableCode"].ToString());
					}
																																								if(dr["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dr["Amount"].ToString());
					}
																																								if(dr["Discount"].ToString()!="")
					{
						model.Discount=decimal.Parse(dr["Discount"].ToString());
					}
																																								if(dr["Mymoney"].ToString()!="")
					{
						model.Mymoney=decimal.Parse(dr["Mymoney"].ToString());
					}
																																								if(dr["State"].ToString()!="")
					{
						model.State=int.Parse(dr["State"].ToString());
					}
																																								if(dr["Createtime"].ToString()!="")
					{
						model.Createtime=DateTime.Parse(dr["Createtime"].ToString());
					}
																																								if(dr["Updatetime"].ToString()!="")
					{
						model.Updatetime=DateTime.Parse(dr["Updatetime"].ToString());
					}
																														
                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
		}
		
		 /// <summary>
        /// 得到一个对象实体(List类型)，数据连接类用myHelperMySQL（非静态）
        /// 表：MessageBoard 
        /// <param name="myHelperMySQL">myHelperMySQL实例（数据访问类）.</param>
        /// <param name="Top">记录数.</param>
        /// <param name="filedSelect">自定义字段.</param> 
        /// <param name="strWhere">条件.</param>
        /// <param name="filedOrder">排序字段.</param>
        /// <param name="parameters">参数(若条件中未使用参数可为null).</param>
        /// </summary>
		public List<Fm.Entity.order_record> GetList(DBHelper myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM order_record a  ");			
			if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            if (filedOrder.Trim() != "")
            {
                strSql.Append(" ORDER BY " + filedOrder);
            }
            if (Top > 0)
            {
                strSql.Append(" limit " + Top.ToString());
            }
            List<Fm.Entity.order_record> myList = new List<Fm.Entity.order_record>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.order_record model = new Fm.Entity.order_record();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.orderid").Count() > 0)
	                {
															model.OrderID= dr["OrderID"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.userid").Count() > 0)
	                {
															model.UserID= dr["UserID"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.tablecode").Count() > 0)
	                {
										if(dr["TableCode"].ToString()!="")
					{
						model.TableCode=int.Parse(dr["TableCode"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.amount").Count() > 0)
	                {
										if(dr["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dr["Amount"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.discount").Count() > 0)
	                {
										if(dr["Discount"].ToString()!="")
					{
						model.Discount=decimal.Parse(dr["Discount"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.mymoney").Count() > 0)
	                {
										if(dr["Mymoney"].ToString()!="")
					{
						model.Mymoney=decimal.Parse(dr["Mymoney"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.state").Count() > 0)
	                {
										if(dr["State"].ToString()!="")
					{
						model.State=int.Parse(dr["State"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.createtime").Count() > 0)
	                {
										if(dr["Createtime"].ToString()!="")
					{
						model.Createtime=DateTime.Parse(dr["Createtime"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.updatetime").Count() > 0)
	                {
										if(dr["Updatetime"].ToString()!="")
					{
						model.Updatetime=DateTime.Parse(dr["Updatetime"].ToString());
					}
																														} 
					
                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
		}

	}
}