using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fm.Core;

namespace Fm.BLL
{
    public class LzHandle
    {
        #region 展示菜品类型
        public string ShowFoodType(int state)
        {
            string strJson = "";
            Entity.DataResponse_food_type Response = new Entity.DataResponse_food_type();
            Entity.DataList_food_type model = new Entity.DataList_food_type();
            food_type Bfood_type = new food_type();
            try
            {
                List<Entity.food_type> mylist = Bfood_type.GetListAll(state);
                foreach (var m in mylist)
                {
                    model.FoodType_Code = m.FoodType_Code;
                    model.FoodType_Name = m.FoodType_Name;
                    model.Sort = m.Sort;
                    Response.Rlist.Add(model);
                }
                Response.Result = true;
                Response.Msg = "";
            }
            catch
            {
                Response.Result = false;
                Response.Msg = "数据异常！";
            }
            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(Response);
            return strJson;
        }
        #endregion

        #region 根据菜品类型，获取菜单
        public string ViewMenu(string typecode,int pageSize,int pageNo)
        {
            string strJson = "";
            #region 响应类
            Entity.DataResponse_MenuList Response = new Entity.DataResponse_MenuList();
            #endregion
            food_menu Bfood_menu = new food_menu();
            food_rel_type Bfood_rel_type = new food_rel_type();
            try
            {
                List<Entity.food_rel_type> Typelist = Bfood_rel_type.GetFoodIDByTypeCode(typecode);
                List<Entity.food_menu> Foodlist = new List<Entity.food_menu>();
                foreach (var m1 in Typelist)
                {
                    Foodlist = Bfood_menu.GetDetailByid(m1.FoodID);
                }
                PagingUtil<Entity.food_menu> mypage = new PagingUtil<Entity.food_menu>(Foodlist, pageSize, pageNo);
                Response.mylist = mypage;
                Response.pageCount = mypage.PageCount;
                Response.recordCount = Foodlist.Count;
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(Response);
            return strJson;
        }
        #endregion

        #region 根据菜品id获取商品详情
        public string FoodDetail(string FoodID)
        {
            string strJson = "";
            Entity.DataResponse_FoodDetail Response = new Entity.DataResponse_FoodDetail();
            Entity.food_menu model = new Entity.food_menu();
            food_menu Bfood_menu = new food_menu();
            List<Entity.food_menu> mylist = new List<Entity.food_menu>();
            try
            {
                mylist = Bfood_menu.GetDetailByid(FoodID);
                if (mylist[0].Is_Series == 1)
                {
                    //如果是系列商品，返回同系列所有商品list
                    Response.Rlist = Bfood_menu.GetDetailBySeries(mylist[0].SeriesCode);
                }
                else
                {
                    //如果是非系列商品，返回单个商品list
                    Response.Rlist = Bfood_menu.GetDetailByid(FoodID);
                }
                Response.Result = true;
                Response.Msg = "";
            }
            catch
            {
                Response.Result = true;
                Response.Msg = "";
            }

            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(Response);
            return strJson;
        }
        #endregion

        #region 创建预订单
        public string CreateOrder(string json)
        {
            string strJson = "";
            Entity.BaseDataResponse Response = new Entity.BaseDataResponse();
            order_record Border_record = new order_record();
            order_detail Border_detail = new order_detail();
            Entity.order_record Morder_record = new Entity.order_record();
            Entity.Request_order jsonMode = new Entity.Request_order();
            jsonMode = Newtonsoft.Json.JsonConvert.DeserializeObject<Entity.Request_order>(json);
            try
            {
                Morder_record.UserID = jsonMode.UserID;
                Morder_record.TableCode = jsonMode.TableCode;
                Morder_record.Amount = jsonMode.Amount;
                Morder_record.Discount = jsonMode.Discount;
                Morder_record.Mymoney = jsonMode.Mymoney;
                Morder_record.State = 0;
                Morder_record.Createtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Morder_record.Updatetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Border_record.Add(Morder_record);

                foreach (var m1 in jsonMode.Dlist)
                {
                    Border_detail.Add(m1);
                }
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(Response);
            return strJson;
        }
        #endregion

        #region 支付完成，生成结账单，修改订单状态
        public string updateorder(string OrderID, int State)
        {
            string strJson = "";
            Entity.BaseDataResponse Response = new Entity.BaseDataResponse();
            order_record Border_record = new order_record();
            try
            {
                Border_record.UpdateState(OrderID, State);
                Response.Msg = "";
                Response.Result = true;
            }
            catch
            {
                Response.Msg = "数据异常！";
                Response.Result = false;
            }
            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(Response);
            return strJson;
        }
        #endregion




        #region Redis
        //public string setRedis()
        //{
        //    string strJson = "";
        //    food_menu Bfood_menu = new food_menu();
        //    food_rel_type Bfood_rel_type = new food_rel_type();
        //    food_type Bfood_type = new food_type();
        //    List<Entity.food_type> list = Bfood_type.GetTypeCode(1);
        //    foreach (var m1 in list)
        //    {
        //        List<Entity.food_rel_type> foodlist = Bfood_rel_type.GetFoodIDByTypeCode(m1.FoodType_Code);
        //        List<Entity.food_menu> menulist = Bfood_menu.GetDetailByid(foodlist[0].FoodID);

        //        WebCommon.WebRedis.DoRedisList redis_set_list = new WebCommon.WebRedis.DoRedisList();

        //        //redis_set_list.Add(m1.FoodType_Code, menulist);

        //    }
        //    return strJson;
        //}
        #endregion


    }
}
