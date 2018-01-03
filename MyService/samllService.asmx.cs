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
        public Fm.BusinessRules.LifeUserAuthenticationDy myHeaderUserAuthDy = new Fm.BusinessRules.LifeUserAuthenticationDy();
        #endregion

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
            string strJson = myhandle.GetProductinfo();
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write(strJson);
            Context.Response.Flush();
            Context.Response.End();
        }

    }
}
