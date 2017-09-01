using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using Fm.BLL;

namespace MyService
{
    /// <summary>
    /// samllService (小程序接口)
    /// </summary>
    [WebService(Namespace = "https://www.bambooego.com/Smart/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class samllService : System.Web.Services.WebService
    {

        #region 声明Soap头实例
        //静态验证头
        public Fm.BusinessRules.LifeUserAuthentication myHeaderUserAuth = new Fm.BusinessRules.LifeUserAuthentication();
        //动态验证头
        public Fm.BusinessRules.LifeUserAuthenticationDy myHeaderUserAuthDy = new Fm.BusinessRules.LifeUserAuthenticationDy();
        #endregion

        /// <summary>
        /// 展示菜品类型
        /// </summary>
        /// <returns>
        ///{
        ///    "Rlist": [
        ///        {
        ///            "FoodType_Code": "1",        类型编号
        ///            "FoodType_Name": "肉菜",       类型名
        ///            "Sort": 1                    排序序号
        ///        },
        ///        {
        ///            "FoodType_Code": "2",
        ///            "FoodType_Name": "凉菜",
        ///            "Sort": 1
        ///        }
        ///    ],
        ///    "Result": true,
        ///    "Msg": ""
        ///}
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public void ShowFoodType()
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.ShowFoodType();
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write(strJson);
            Context.Response.Flush();
            Context.Response.End();
        }

        /// <summary>
        /// 根据菜品类型，获取菜单
        /// </summary>
        /// <param name="typecode">菜品类型编号</param>
        /// <param name="pageSize"></param>
        /// <param name="pageNo"></param>
        /// <returns>
        /// 返回数据JSON格式
        ///{
        ///    "mylist": [
        ///        {
        ///             "Tlist": [
        ///                 {
        ///                     "FoodType_Code": "1"    --菜品类型编号
        ///                 }
        ///             ],
        ///            "FoodID": "1011",        --菜品编号
        ///            "Food_Name": "鱼香肉丝",     --菜名
        ///            "Price": 20,                 --售价
        ///            "Image_Src": "img.123.com",  --商品图
        ///            "Food_Summary": "100",   --菜品简介
        ///            "Is_Series": 0,          --是否为系列商品 1是，0否
        ///            "SeriesCode": "",        --系列商品编号
        ///            "Is_Feature": 1,         --是否为热销商品 1是，0否
        ///        }
        ///    ],
        ///    "Result": true,  --返回状态
        ///    "Msg": "",       --错误信息
        ///}
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public void MenuList()
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.ViewMenu();
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write(strJson);
            Context.Response.Flush();
            Context.Response.End();
        }

        /// <summary>
        /// 根据菜品id获取商品详情
        /// </summary>
        /// <param name="FoodID"></param>
        /// <returns>
        ///{
        ///    "Rlist": [
        ///        {
        ///            "FoodID": "1011",
        ///            "Food_Name": "鱼香肉丝",
        ///            "Price": 20.00,
        ///            "Image_Src": "img.123.com",
        ///            "Food_Summary": "100",                   菜品简介
        ///            "Is_Series": 0,                          是否为系列商品（1是0否）
        ///            "SeriesCode": "",                        系列商品编号
        ///            "Is_Feature": 1,                         是否为热销商品（1是0否）
        ///            "State": 0,                              商品状态
        ///            "Createtime": "0001-01-01 00:00:00",
        ///            "Updatetime": "0001-01-01 00:00:00"
        ///        }
        ///    ],
        ///    "Result": true,
        ///    "Msg": ""
        ///}
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public void FoodDetail(string FoodID)
        {
            string strJson = "";
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                strJson = "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            LzHandle myhandle = new LzHandle();
            strJson = myhandle.FoodDetail(FoodID);
            
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write(strJson);
            Context.Response.Flush();
            Context.Response.End();
        }

        /// <summary>
        /// 创建预订单
        /// </summary>
        /// <param name="json">
        ///{
        ///    "Dlist": [
        ///        {
        ///            "OrderID": "",       订单编号
        ///            "Food_Code": "",     菜品编号
        ///            "State": 0,          订单状态（0）
        ///            "Createtime": "",
        ///            "Updatetime": ""
        ///        }
        ///    ],
        ///    "UserID": "2688",            用户编号
        ///    "TableCode": "1",            桌子编号    
        ///    "Amount": 100,               应收款
        ///    "Discount": "0.98",          折扣
        ///    "Mymoney": "98"              实收款
        ///}
        /// </param>
        /// <returns>
        ///    "Result": true,
        ///    "Msg": ""
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public void CreateOrder(string json)
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.CreateOrder(json);
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write(strJson);
            Context.Response.Flush();
            Context.Response.End();
        }

        /// <summary>
        /// 支付完成，生成结账单，修改订单状态
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns>
        /// "Result": true,
        /// "Msg": ""
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public void updateorder(string OrderID)
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.updateorder(OrderID);
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write(strJson);
            Context.Response.Flush();
            Context.Response.End();
        }
    }
}
