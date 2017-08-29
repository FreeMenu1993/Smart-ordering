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

namespace Fm.DAL {
    /// <summary>
    /// act_filled数据访问层类
    /// </summary>
    public partial class act_filled
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(DBHelper myHelperMySQL, Fm.Entity.act_filled model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into act_filled(");
            strSql.Append("FilledID,Ticket_Type,Title,Detail,Receive_Full,Use_Full,Use_Derate,Start_Date,End_Date,Amount,State,Createtime,Updatetime");
            strSql.Append(") values (");
            strSql.Append("@FilledID,@Ticket_Type,@Title,@Detail,@Receive_Full,@Use_Full,@Use_Derate,@Start_Date,@End_Date,@Amount,@State,@Createtime,@Updatetime");
            strSql.Append(") ");

            MySqlParameter[] parameters = {
                        new MySqlParameter("@FilledID", model.FilledID)  ,
                                    new MySqlParameter("@Ticket_Type", model.Ticket_Type)  ,
                                    new MySqlParameter("@Title", model.Title)  ,
                                    new MySqlParameter("@Detail", model.Detail)  ,
                                    new MySqlParameter("@Receive_Full", model.Receive_Full)  ,
                                    new MySqlParameter("@Use_Full", model.Use_Full)  ,
                                    new MySqlParameter("@Use_Derate", model.Use_Derate)  ,
                                    new MySqlParameter("@Start_Date", model.Start_Date)  ,
                                    new MySqlParameter("@End_Date", model.End_Date)  ,
                                    new MySqlParameter("@Amount", model.Amount)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)
            };

            myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据(所有字段)
        /// </summary>
        public int Update(DBHelper myHelperMySQL, Fm.Entity.act_filled model, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update act_filled set ");

            strSql.Append(" FilledID = @FilledID , ");
            strSql.Append(" Ticket_Type = @Ticket_Type , ");
            strSql.Append(" Title = @Title , ");
            strSql.Append(" Detail = @Detail , ");
            strSql.Append(" Receive_Full = @Receive_Full , ");
            strSql.Append(" Use_Full = @Use_Full , ");
            strSql.Append(" Use_Derate = @Use_Derate , ");
            strSql.Append(" Start_Date = @Start_Date , ");
            strSql.Append(" End_Date = @End_Date , ");
            strSql.Append(" Amount = @Amount , ");
            strSql.Append(" State = @State , ");
            strSql.Append(" Createtime = @Createtime , ");
            strSql.Append(" Updatetime = @Updatetime  ");
            MySqlParameter[] parameters = {
                        new MySqlParameter("@FilledID", model.FilledID)  ,
                                    new MySqlParameter("@Ticket_Type", model.Ticket_Type)  ,
                                    new MySqlParameter("@Title", model.Title)  ,
                                    new MySqlParameter("@Detail", model.Detail)  ,
                                    new MySqlParameter("@Receive_Full", model.Receive_Full)  ,
                                    new MySqlParameter("@Use_Full", model.Use_Full)  ,
                                    new MySqlParameter("@Use_Derate", model.Use_Derate)  ,
                                    new MySqlParameter("@Start_Date", model.Start_Date)  ,
                                    new MySqlParameter("@End_Date", model.End_Date)  ,
                                    new MySqlParameter("@Amount", model.Amount)  ,
                                    new MySqlParameter("@State", model.State)  ,
                                    new MySqlParameter("@Createtime", model.Createtime)  ,
                                    new MySqlParameter("@Updatetime", model.Updatetime)
            };

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            int rows = myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);

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
            strSql.Append("update act_filled set ");
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
        public int Delete(DBHelper myHelperMySQL, string strWhere, MySqlParameter[] parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from act_filled ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }

            int rows = myHelperMySQL.ExecuteNonQuery(strSql.ToString(), parameters);
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
            strSql.Append("  FROM act_filled  ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            List<Fm.Entity.act_filled> myList = new List<Fm.Entity.act_filled>();
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
        public List<Fm.Entity.act_filled> GetList(DBHelper myHelperMySQL, int Top, string strWhere, string filedOrder, MySqlParameter[] parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" a.FilledID, a.Ticket_Type, a.Title, a.Detail, a.Receive_Full, a.Use_Full, a.Use_Derate, a.Start_Date, a.End_Date, a.Amount, a.State, a.Createtime, a.Updatetime  ");
            strSql.Append("  FROM act_filled a ");
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
            List<Fm.Entity.act_filled> myList = new List<Fm.Entity.act_filled>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.act_filled model = new Fm.Entity.act_filled();

                    model.FilledID = dr["FilledID"].ToString();
                    model.Ticket_Type = dr["Ticket_Type"].ToString();
                    model.Title = dr["Title"].ToString();
                    model.Detail = dr["Detail"].ToString();
                    model.Receive_Full = dr["Receive_Full"].ToString();
                    model.Use_Full = dr["Use_Full"].ToString();
                    model.Use_Derate = dr["Use_Derate"].ToString();
                    if (dr["Start_Date"].ToString() != "")
                    {
                        model.Start_Date = dr["Start_Date"].ToString();
                    }
                    if (dr["End_Date"].ToString() != "")
                    {
                        model.End_Date = dr["End_Date"].ToString();
                    }
                    if (dr["Amount"].ToString() != "")
                    {
                        model.Amount = int.Parse(dr["Amount"].ToString());
                    }
                    if (dr["State"].ToString() != "")
                    {
                        model.State = int.Parse(dr["State"].ToString());
                    }
                    model.Createtime = dr["Createtime"].ToString();
                    model.Updatetime = dr["Updatetime"].ToString();

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
        public List<Fm.Entity.act_filled> GetList(DBHelper myHelperMySQL, int Top, string filedSelect, string strWhere, string filedOrder, MySqlParameter[] parameters)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            //自定义字段
            strSql.Append(" " + filedSelect);
            strSql.Append("  FROM act_filled a  ");
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
            List<Fm.Entity.act_filled> myList = new List<Fm.Entity.act_filled>();
            using (MySqlDataReader dr = myHelperMySQL.ExecuteReader(strSql.ToString(), parameters))
            {
                while (dr.Read())
                {
                    Fm.Entity.act_filled model = new Fm.Entity.act_filled();

                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.filledid").Count() > 0)
                    {
                        model.FilledID = dr["FilledID"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.ticket_type").Count() > 0)

                    {
                        model.Ticket_Type = dr["Ticket_Type"].ToString();

                                                                                                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.title").Count() > 0)
                    {
                        model.Title = dr["Title"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.detail").Count() > 0)
                    {
                        model.Detail = dr["Detail"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.receive_full").Count() > 0)
                    {
                        model.Receive_Full = dr["Receive_Full"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.use_full").Count() > 0)
                    {
                        model.Use_Full = dr["Use_Full"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.use_derate").Count() > 0)
                    {
                        model.Use_Derate = dr["Use_Derate"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.start_date").Count() > 0)
                    {
                        if (dr["Start_Date"].ToString() != "")
                        {
                            model.Start_Date = dr["Start_Date"].ToString();
                        }
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.end_date").Count() > 0)
                    {
                        if (dr["End_Date"].ToString() != "")
                        {
                            model.End_Date = dr["End_Date"].ToString();
                        }
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.amount").Count() > 0)
                    {
                        if (dr["Amount"].ToString() != "")
                        {
                            model.Amount = int.Parse(dr["Amount"].ToString());
                        }
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.state").Count() > 0)
                    {
                        if (dr["State"].ToString() != "")
                        {
                            model.State = int.Parse(dr["State"].ToString());
                        }
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.createtime").Count() > 0)
                    {
                        model.Createtime = dr["Createtime"].ToString();
                    }
                    if (filedSelect.ToLower().Split(',').Where(x => x.Trim() == "a.updatetime").Count() > 0)
                    {
                        model.Updatetime = dr["Updatetime"].ToString();
                    }

                    myList.Add(model);
                }
                dr.Close();
            }
            return myList;
        }

    }
}