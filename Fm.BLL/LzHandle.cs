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
        #region 菜单展示
        public string ViewMenu(int state,int pageSize,int pageNo)
        {
            string strJson = "";
            #region 响应类
            Entity.DataResponse_MenuList Response = new Entity.DataResponse_MenuList();
            #endregion
            food_menu Bfood_menu = new food_menu();
            try
            {
                List<Entity.food_menu> list = Bfood_menu.GetListByState(state);
                PagingUtil<Entity.food_menu> mypage = new PagingUtil<Entity.food_menu>(list, pageSize, pageNo);
                Response.mylist = mypage;
                Response.pageCount = mypage.PageCount;
                Response.recordCount = list.Count;
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

        #region 餐品详情
        public string FoodDetail(string FoodID)
        {
            string strJson = "";
            Entity.food_menu model = new Entity.food_menu();
            food_menu Bfood_menu = new food_menu();
            List<Entity.food_menu> mylist = new List<Entity.food_menu>();
            mylist = Bfood_menu.GetDetailByid(FoodID);
            
            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(mylist);
            return strJson;
        }
        #endregion
    }
}
