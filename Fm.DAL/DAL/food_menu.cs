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
    /// food_menu数据访问层类
    /// </summary>
	public partial class food_menu
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DBHelper myHelperMySQL ,Fm.Entity.food_menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into food_menu(");			
            strSql.Append("Food_Code,Food_Name,Price,Image_Src,Food_Summary,Is_Series,SeriesCode,Is_Feature,State,Createtime,Updatetime");
			strSql.Append(") values (");
            strSql.Append("@Food_Code,@Food_Name,@Price,@Image_Src,@Food_Summary,@Is_Series,@SeriesCode,@Is_Feature,@State,@Createtime,@Updatetime");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
			            new MySqlParameter("@Food_Code", model.Food_Code)  ,
                                    new MySqlParameter("@Food_Name", model.Food_Name)  ,
                                    new MySqlParameter("@Price", model.Price)  ,
                                    new MySqlParameter("@Image_Src", model.Image_Src)  ,
                                    new MySqlParameter("@Food_Summary", model.Food_Summary)  ,
                                    new MySqlParameter("@Is_Series", model.Is_Series)  ,
                                    new MySqlParameter("@SeriesCode", model.SeriesCode)  ,
                                    new MySqlParameter("@Is_Feature", model.Is_Feature)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据(所有字段)
		/// </summary>
		public int Update(DBHelper myHelperMySQL ,Fm.Entity.food_menu model,string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update food_menu set ");
			                        
            strSql.Append(" Food_Code = @Food_Code , ");                                    
            strSql.Append(" Food_Name = @Food_Name , ");                                    
            strSql.Append(" Price = @Price , ");                                    
            strSql.Append(" Image_Src = @Image_Src , ");                                    
            strSql.Append(" Food_Summary = @Food_Summary , ");                                    
            strSql.Append(" Is_Series = @Is_Series , ");                                    
            strSql.Append(" SeriesCode = @SeriesCode , ");                                    
            strSql.Append(" Is_Feature = @Is_Feature , ");                                    
            strSql.Append(" State = @State , ");                                    
            strSql.Append(" Createtime = @Createtime , ");                                    
            strSql.Append(" Updatetime = @Updatetime  ");                        			
			MySqlParameter[] parameters = {
			            new MySqlParameter("@Food_Code", model.Food_Code)  ,
                                    new MySqlParameter("@Food_Name", model.Food_Name)  ,
                                    new MySqlParameter("@Price", model.Price)  ,
                                    new MySqlParameter("@Image_Src", model.Image_Src)  ,
                                    new MySqlParameter("@Food_Summary", model.Food_Summary)  ,
                                    new MySqlParameter("@Is_Series", model.Is_Series)  ,
                                    new MySqlParameter("@SeriesCode", model.SeriesCode)  ,
                                    new MySqlParameter("@Is_Feature", model.Is_Feature)  ,
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
            strSql.Append("update food_menu set ");
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
			strSql.Append("delete from food_menu ");
			
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
			strSql.Append("  FROM food_menu  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<Fm.Entity.food_menu> myList = new List<Fm.Entity.food_menu>();
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
		public List<Fm.Entity.food_menu> GetList(DBHelper myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" a.Food_Code, a.Food_Name, a.Price, a.Image_Src, a.Food_Summary, a.Is_Series, a.SeriesCode, a.Is_Feature, a.State, a.Createtime, a.Updatetime  ");			
			strSql.Append("  FROM food_menu a ");
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
            List<Fm.Entity.food_menu> myList = new List<Fm.Entity.food_menu>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.food_menu model = new Fm.Entity.food_menu();
                    
                    															model.Food_Code= dr["Food_Code"].ToString();
																																								model.Food_Name= dr["Food_Name"].ToString();
																																			if(dr["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(dr["Price"].ToString());
					}
																																													model.Image_Src= dr["Image_Src"].ToString();
																																								model.Food_Summary= dr["Food_Summary"].ToString();
																																			if(dr["Is_Series"].ToString()!="")
					{
						model.Is_Series=int.Parse(dr["Is_Series"].ToString());
					}
																																													model.SeriesCode= dr["SeriesCode"].ToString();
																																			if(dr["Is_Feature"].ToString()!="")
					{
						model.Is_Feature=int.Parse(dr["Is_Feature"].ToString());
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
		public List<Fm.Entity.food_menu> GetList(DBHelper myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM food_menu a  ");			
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
            List<Fm.Entity.food_menu> myList = new List<Fm.Entity.food_menu>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.food_menu model = new Fm.Entity.food_menu();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.food_code").Count() > 0)
	                {
															model.Food_Code= dr["Food_Code"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.food_name").Count() > 0)
	                {
															model.Food_Name= dr["Food_Name"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.price").Count() > 0)
	                {
										if(dr["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(dr["Price"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.image_src").Count() > 0)
	                {
															model.Image_Src= dr["Image_Src"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.food_summary").Count() > 0)
	                {
															model.Food_Summary= dr["Food_Summary"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.is_series").Count() > 0)
	                {
										if(dr["Is_Series"].ToString()!="")
					{
						model.Is_Series=int.Parse(dr["Is_Series"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.seriescode").Count() > 0)
	                {
															model.SeriesCode= dr["SeriesCode"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.is_feature").Count() > 0)
	                {
										if(dr["Is_Feature"].ToString()!="")
					{
						model.Is_Feature=int.Parse(dr["Is_Feature"].ToString());
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