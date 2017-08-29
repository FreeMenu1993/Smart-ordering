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
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
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
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string ShowFoodType()
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.ShowFoodType(1);
            return strJson;
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
        ///            "FoodID": "1011",
        ///            "Food_Name": "鱼香肉丝",
        ///            "Price": 20,
        ///            "Image_Src": "img.123.com",
        ///            "Food_Summary": "100",   --菜品简介
        ///            "Is_Series": 0,          --是否为系列商品 1是，0否
        ///            "SeriesCode": "",        --系列商品编号
        ///            "Is_Feature": 1,         --是否为热销商品 1是，0否
        ///            "State": 0,              --状态 0下架，1上架，2删除
        ///            "Createtime": "0001-01-01 00:00:00",
        ///            "Updatetime": "0001-01-01 00:00:00"
        ///        }
        ///    ],
        ///    "Result": true,
        ///    "Msg": "",
        ///    "pageCount": 1,
        ///    "recordCount": 1
        ///}
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string MenuList(string typecode, int pageSize, int pageNo)
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.ViewMenu(typecode, pageSize,pageNo);
            return strJson;
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
        ///            "Food_Summary": "100",
        ///            "Is_Series": 0,
        ///            "SeriesCode": "",
        ///            "Is_Feature": 1,
        ///            "State": 0,
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
        public string FoodDetail(string FoodID)
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.FoodDetail(FoodID);
            return strJson;
        }

        /// <summary>
        /// 创建预订单
        /// </summary>
        /// <param name="json">
        ///{
        ///    "Dlist": [
        ///        {
        ///            "OrderID": "",
        ///            "Food_Code": "",
        ///            "State": 0,
        ///            "Createtime": "",
        ///            "Updatetime": ""
        ///        }
        ///    ],
        ///    "UserID": "2688",
        ///    "TableCode": "1",
        ///    "Amount": 100,
        ///    "Discount": "0.98",
        ///    "Mymoney": "98"
        ///}
        /// </param>
        /// <returns>
        ///    "Result": true,
        ///    "Msg": ""
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string CreateOrder(string json)
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.CreateOrder(json);
            return strJson;
        }

        /// <summary>
        /// 支付完成，生成结账单，修改订单状态
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string updateorder(string OrderID, int State)
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            LzHandle myhandle = new LzHandle();
            string strJson = myhandle.updateorder(OrderID, State);
            return strJson;
        }
    }
}
