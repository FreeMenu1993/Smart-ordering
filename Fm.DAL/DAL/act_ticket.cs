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
    /// act_ticket数据访问层类
    /// </summary>
	public partial class act_ticket
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DBHelper myHelperMySQL ,Fm.Entity.act_ticket model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into act_ticket(");			
            strSql.Append("UserID,Ticket_Code,Ticket_Type,State,Createtime,Updatetime");
			strSql.Append(") values (");
            strSql.Append("@UserID,@Ticket_Code,@Ticket_Type,@State,@Createtime,@Updatetime");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
			            new MySqlParameter("@UserID", model.UserID)  ,
                                    new MySqlParameter("@Ticket_Code", model.Ticket_Code)  ,
                                    new MySqlParameter("@Ticket_Type", model.Ticket_Type)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据(所有字段)
		/// </summary>
		public int Update(DBHelper myHelperMySQL ,Fm.Entity.act_ticket model,string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update act_ticket set ");
			                        
            strSql.Append(" UserID = @UserID , ");                                    
            strSql.Append(" Ticket_Code = @Ticket_Code , ");                                    
            strSql.Append(" Ticket_Type = @Ticket_Type , ");                                    
            strSql.Append(" State = @State , ");                                    
            strSql.Append(" Createtime = @Createtime , ");                                    
            strSql.Append(" Updatetime = @Updatetime  ");                        			
			MySqlParameter[] parameters = {
			            new MySqlParameter("@UserID", model.UserID)  ,
                                    new MySqlParameter("@Ticket_Code", model.Ticket_Code)  ,
                                    new MySqlParameter("@Ticket_Type", model.Ticket_Type)  ,
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
            strSql.Append("update act_ticket set ");
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
			strSql.Append("delete from act_ticket ");
			
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
			strSql.Append("  FROM act_ticket  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<Fm.Entity.act_ticket> myList = new List<Fm.Entity.act_ticket>();
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
		public List<Fm.Entity.act_ticket> GetList(DBHelper myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" a.UserID, a.Ticket_Code, a.Ticket_Type, a.State, a.Createtime, a.Updatetime  ");			
			strSql.Append("  FROM act_ticket a ");
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
            List<Fm.Entity.act_ticket> myList = new List<Fm.Entity.act_ticket>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.act_ticket model = new Fm.Entity.act_ticket();
                    
                    															model.UserID= dr["UserID"].ToString();
																																								model.Ticket_Code= dr["Ticket_Code"].ToString();
																																								model.Ticket_Type= dr["Ticket_Type"].ToString();
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
		public List<Fm.Entity.act_ticket> GetList(DBHelper myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM act_ticket a  ");			
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
            List<Fm.Entity.act_ticket> myList = new List<Fm.Entity.act_ticket>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.act_ticket model = new Fm.Entity.act_ticket();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.userid").Count() > 0)
	                {
															model.UserID= dr["UserID"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.ticket_code").Count() > 0)
	                {
															model.Ticket_Code= dr["Ticket_Code"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.ticket_type").Count() > 0)
	                {
															model.Ticket_Type= dr["Ticket_Type"].ToString();
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