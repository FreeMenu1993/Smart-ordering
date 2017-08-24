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

        #region 示例

        /// <summary>
        /// 动态头
        /// </summary>
        /// <returns>
        /// 返回数据JSON格式
        /// {
        /// 
        /// }
        /// </returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string HelloWorld()
        {
            string Msg = "";
            if (!myHeaderUserAuthDy.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }

        /// <summary>
        /// 静态头
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        [SoapHeader("myHeaderUserAuth")]
        public string HelloWorld2()
        {
            string Msg = "";
            if (!myHeaderUserAuth.IsValid(out Msg))
            {
                return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            }
            string strJson = "Hello World";
            return strJson;
        }

        #endregion

        [WebMethod]
        [SoapHeader("myHeaderUserAuthDy")]
        public string MenuList()
        {
            //string Msg = "";
            //if (!myHeaderUserAuthDy.IsValid(out Msg))
            //{
            //    return "{\"MemberEncryption\":null,\"Result\":false,\"Msg\":\"非法连接.\"}";
            //}
            LzHandle myhandle = new LzHandle();
            myhandle.ViewMenu();
            string strJson = "Hello World";
            return strJson;
        }

    }
}
