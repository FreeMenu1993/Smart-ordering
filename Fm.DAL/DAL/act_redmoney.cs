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
    /// act_redmoney数据访问层类
    /// </summary>
	public partial class act_redmoney
	{ 
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(DBHelper myHelperMySQL ,Fm.Entity.act_redmoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into act_redmoney(");			
            strSql.Append("Red_Envelope_Code,Red_Envelope_Title,Red_Envelope_Detail,Red_Envelope_Money,Filled,Amount,Start_Date,End_Date,State,Createtime,Updatetime");
			strSql.Append(") values (");
            strSql.Append("@Red_Envelope_Code,@Red_Envelope_Title,@Red_Envelope_Detail,@Red_Envelope_Money,@Filled,@Amount,@Start_Date,@End_Date,@State,@Createtime,@Updatetime");            
            strSql.Append(") ");            
            	
			MySqlParameter[] parameters = {
			            new MySqlParameter("@Red_Envelope_Code", model.Red_Envelope_Code)  ,
                                    new MySqlParameter("@Red_Envelope_Title", model.Red_Envelope_Title)  ,
                                    new MySqlParameter("@Red_Envelope_Detail", model.Red_Envelope_Detail)  ,
                                    new MySqlParameter("@Red_Envelope_Money", model.Red_Envelope_Money)  ,
                                    new MySqlParameter("@Filled", model.Filled)  ,
                                    new MySqlParameter("@Amount", model.Amount)  ,
                                    new MySqlParameter("@Start_Date", model.Start_Date)  ,
                                    new MySqlParameter("@End_Date", model.End_Date)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)              
            };
            
            myHelperMySQL.ExecuteNonQuery(strSql.ToString(),parameters);		
		}
		
		/// <summary>
		/// 更新一条数据(所有字段)
		/// </summary>
		public int Update(DBHelper myHelperMySQL ,Fm.Entity.act_redmoney model,string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update act_redmoney set ");
			                        
            strSql.Append(" Red_Envelope_Code = @Red_Envelope_Code , ");                                    
            strSql.Append(" Red_Envelope_Title = @Red_Envelope_Title , ");                                    
            strSql.Append(" Red_Envelope_Detail = @Red_Envelope_Detail , ");                                    
            strSql.Append(" Red_Envelope_Money = @Red_Envelope_Money , ");                                    
            strSql.Append(" Filled = @Filled , ");                                    
            strSql.Append(" Amount = @Amount , ");                                    
            strSql.Append(" Start_Date = @Start_Date , ");                                    
            strSql.Append(" End_Date = @End_Date , ");                                    
            strSql.Append(" State = @State , ");                                    
            strSql.Append(" Createtime = @Createtime , ");                                    
            strSql.Append(" Updatetime = @Updatetime  ");                        			
			MySqlParameter[] parameters = {
			            new MySqlParameter("@Red_Envelope_Code", model.Red_Envelope_Code)  ,
                                    new MySqlParameter("@Red_Envelope_Title", model.Red_Envelope_Title)  ,
                                    new MySqlParameter("@Red_Envelope_Detail", model.Red_Envelope_Detail)  ,
                                    new MySqlParameter("@Red_Envelope_Money", model.Red_Envelope_Money)  ,
                                    new MySqlParameter("@Filled", model.Filled)  ,
                                    new MySqlParameter("@Amount", model.Amount)  ,
                                    new MySqlParameter("@Start_Date", model.Start_Date)  ,
                                    new MySqlParameter("@End_Date", model.End_Date)  ,
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
            strSql.Append("update act_redmoney set ");
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
			strSql.Append("delete from act_redmoney ");
			
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
			strSql.Append("  FROM act_redmoney  ");
			
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<Fm.Entity.act_redmoney> myList = new List<Fm.Entity.act_redmoney>();
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
		public List<Fm.Entity.act_redmoney> GetList(DBHelper myHelperMySQL ,int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" a.Red_Envelope_Code, a.Red_Envelope_Title, a.Red_Envelope_Detail, a.Red_Envelope_Money, a.Filled, a.Amount, a.Start_Date, a.End_Date, a.State, a.Createtime, a.Updatetime  ");			
			strSql.Append("  FROM act_redmoney a ");
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
            List<Fm.Entity.act_redmoney> myList = new List<Fm.Entity.act_redmoney>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.act_redmoney model = new Fm.Entity.act_redmoney();
                    
                    															model.Red_Envelope_Code= dr["Red_Envelope_Code"].ToString();
																																								model.Red_Envelope_Title= dr["Red_Envelope_Title"].ToString();
																																								model.Red_Envelope_Detail= dr["Red_Envelope_Detail"].ToString();
																																			if(dr["Red_Envelope_Money"].ToString()!="")
					{
						model.Red_Envelope_Money=decimal.Parse(dr["Red_Envelope_Money"].ToString());
					}
																																								if(dr["Filled"].ToString()!="")
					{
						model.Filled=decimal.Parse(dr["Filled"].ToString());
					}
																																								if(dr["Amount"].ToString()!="")
					{
						model.Amount=int.Parse(dr["Amount"].ToString());
					}
																																													model.Start_Date= dr["Start_Date"].ToString();
																																								model.End_Date= dr["End_Date"].ToString();
																																			if(dr["State"].ToString()!="")
					{
						model.State=int.Parse(dr["State"].ToString());
					}
																																													model.Createtime= dr["Createtime"].ToString();
																																								model.Updatetime= dr["Updatetime"].ToString();
																									
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
		public List<Fm.Entity.act_redmoney> GetList(DBHelper myHelperMySQL ,int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			//自定义字段
            strSql.Append(" " + filedSelect);
			strSql.Append("  FROM act_redmoney a  ");			
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
            List<Fm.Entity.act_redmoney> myList = new List<Fm.Entity.act_redmoney>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.act_redmoney model = new Fm.Entity.act_redmoney();
                    
                    	                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.red_envelope_code").Count() > 0)
	                {
															model.Red_Envelope_Code= dr["Red_Envelope_Code"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.red_envelope_title").Count() > 0)
	                {
															model.Red_Envelope_Title= dr["Red_Envelope_Title"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.red_envelope_detail").Count() > 0)
	                {
															model.Red_Envelope_Detail= dr["Red_Envelope_Detail"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.red_envelope_money").Count() > 0)
	                {
										if(dr["Red_Envelope_Money"].ToString()!="")
					{
						model.Red_Envelope_Money=decimal.Parse(dr["Red_Envelope_Money"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.filled").Count() > 0)
	                {
										if(dr["Filled"].ToString()!="")
					{
						model.Filled=decimal.Parse(dr["Filled"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.amount").Count() > 0)
	                {
										if(dr["Amount"].ToString()!="")
					{
						model.Amount=int.Parse(dr["Amount"].ToString());
					}
																														} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.start_date").Count() > 0)
	                {
															model.Start_Date= dr["Start_Date"].ToString();
																									} 
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.end_date").Count() > 0)
	                {
															model.End_Date= dr["End_Date"].ToString();
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
						                if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.updatetime").Count() > 0)
	                {
															model.Updatetime= dr["Updatetime"].ToString();
																									} 
					
                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
		}

	}
}