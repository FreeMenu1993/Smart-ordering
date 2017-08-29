/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/  
using System.Text;
using System.Data;
using System.Linq;
using Fm.WebCommon;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Fm.DAL{
	/// <summary>
    /// userinfo数据访问层类
    /// </summary>
	public partial class userinfo
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DBHelper myHelperMySQL ,Fm.Entity.userinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userinfo(");			
            strSql.Append("UserID,NickName,AvatarUrl,Sex,Country,Province,City,Mobile,Rank,State,Createtime,Refreshtime");
			strSql.Append(") values (");
            strSql.Append("@UserID,@NickName,@AvatarUrl,@Sex,@Country,@Province,@City,@Mobile,@Rank,@State,@Createtime,@Refreshtime");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
			            new MySqlParameter("@UserID", model.UserID)  ,
                                    new MySqlParameter("@NickName", model.NickName)  ,
                                    new MySqlParameter("@AvatarUrl", model.AvatarUrl)  ,
                                    new MySqlParameter("@Sex", model.Sex)  ,
                                    new MySqlParameter("@Country", model.Country)  ,
                                    new MySqlParameter("@Province", model.Province)  ,
                                    new MySqlParameter("@City", model.City)  ,
                                    new MySqlParameter("@Mobile", model.Mobile)  ,
                                    new MySqlParameter("@Rank", model.Rank)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Refreshtime", model.Refreshtime)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据(所有字段)
		/// </summary>
		public int Update(DBHelper myHelperMySQL ,Fm.Entity.userinfo model,string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userinfo set ");
			                        
            strSql.Append(" UserID = @UserID , ");                                    
            strSql.Append(" NickName = @NickName , ");                                    
            strSql.Append(" AvatarUrl = @AvatarUrl , ");                                    
            strSql.Append(" Sex = @Sex , ");                                    
            strSql.Append(" Country = @Country , ");                                    
            strSql.Append(" Province = @Province , ");                                    
            strSql.Append(" City = @City , ");                                    
            strSql.Append(" Mobile = @Mobile , ");                                    
            strSql.Append(" Rank = @Rank , ");                                    
            strSql.Append(" State = @State , ");                                    
            strSql.Append(" Createtime = @Createtime , ");                                    
            strSql.Append(" Refreshtime = @Refreshtime  ");                        			
			MySqlParameter[] parameters = {
			            new MySqlParameter("@UserID", model.UserID)  ,
                                    new MySqlParameter("@NickName", model.NickName)  ,
                                    new MySqlParameter("@AvatarUrl", model.AvatarUrl)  ,
                                    new MySqlParameter("@Sex", model.Sex)  ,
                                    new MySqlParameter("@Country", model.Country)  ,
                                    new MySqlParameter("@Province", model.Province)  ,
                                    new MySqlParameter("@City", model.City)  ,
                                    new MySqlParameter("@Mobile", model.Mobile)  ,
                                    new MySqlParameter("@Rank", model.Rank)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Refreshtime", model.Refreshtime)               
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
            strSql.Append("update userinfo set ");
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
			strSql.Append("delete from userinfo ");
			
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
			strSql.Append("  FROM userinfo  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<Fm.Entity.userinfo> myList = new List<Fm.Entity.userinfo>();
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
		public List<Fm.Entity.userinfo> GetList(DBHelper myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" a.UserID, a.NickName, a.AvatarUrl, a.Sex, a.Country, a.Province, a.City, a.Mobile, a.Rank, a.State, a.Createtime, a.Refreshtime  ");			
			strSql.Append("  FROM userinfo a ");
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
            List<Fm.Entity.userinfo> myList = new List<Fm.Entity.userinfo>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.userinfo model = new Fm.Entity.userinfo();
                    
                    															model.UserID= dr["UserID"].ToString();
																																								model.NickName= dr["NickName"].ToString();
																																								model.AvatarUrl= dr["AvatarUrl"].ToString();
																																			if(dr["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dr["Sex"].ToString());
					}
																																													model.Country= dr["Country"].ToString();
																																								model.Province= dr["Province"].ToString();
																																								model.City= dr["City"].ToString();
																																								model.Mobile= dr["Mobile"].ToString();
																																			if(dr["Rank"].ToString()!="")
					{
						model.Rank=int.Parse(dr["Rank"].ToString());
					}
																																								if(dr["State"].ToString()!="")
					{
						model.State=int.Parse(dr["State"].ToString());
					}
																																													model.Createtime= dr["Createtime"].ToString();
																																								model.Refreshtime= dr["Refreshtime"].ToString();
																									
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
		public List<Fm.Entity.userinfo> GetList(DBHelper myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM userinfo a  ");			
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
            List<Fm.Entity.userinfo> myList = new List<Fm.Entity.userinfo>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.userinfo model = new Fm.Entity.userinfo();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.userid").Count() > 0)
	                {
															model.UserID= dr["UserID"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.nickname").Count() > 0)
	                {
															model.NickName= dr["NickName"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.avatarurl").Count() > 0)
	                {
															model.AvatarUrl= dr["AvatarUrl"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.sex").Count() > 0)
	                {
										if(dr["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dr["Sex"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.country").Count() > 0)
	                {
															model.Country= dr["Country"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.province").Count() > 0)
	                {
															model.Province= dr["Province"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.city").Count() > 0)
	                {
															model.City= dr["City"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.mobile").Count() > 0)
	                {
															model.Mobile= dr["Mobile"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.rank").Count() > 0)
	                {
										if(dr["Rank"].ToString()!="")
					{
						model.Rank=int.Parse(dr["Rank"].ToString());
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
															model.Createtime= dr["Createtime"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.refreshtime").Count() > 0)
	                {
															model.Refreshtime= dr["Refreshtime"].ToString();
																									} 
					
                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
		}

	}
}