using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Services.Protocols;

namespace Fm.BusinessRules
{
    public class LifeUserAuthenticationDy : SoapHeader
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public LifeUserAuthenticationDy()
        {
        }
        /// <summary>
        /// 构造函数，初始化用户名密码
        /// </summary>
        /// <param name="iUserId">用户名</param>
        /// <param name="iPassWord">密码</param>
        public LifeUserAuthenticationDy(string iUserId, string iPassWord)
        {
            Initial(iUserId, iPassWord);
        }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 初始化用户名密码
        /// </summary>
        /// <param name="iUserId">用户名</param>
        /// <param name="iPassWord">密码</param>
        private void Initial(string iUserId, string iPassWord)
        {
            UserId = iUserId;
            PassWord = iPassWord;
        }

        /// <summary>
        /// 验证用户身份公用方法
        /// </summary>
        /// <param name="iMsg">提示信息</param>
        /// <returns>是否合法</returns>
        public bool IsValid(out string iMsg)
        {
            return IsValid(UserId, PassWord, out iMsg);
        }

        private bool IsValid(string iUserId, string iPassWord, out string iMsg)
        {
            iMsg = "";
            try
            {
                //判断用户名密码
                if ((iUserId == Fm.BLL.Base.SoapConfig.APIUserId && iPassWord == Fm.BLL.Base.SoapConfig.APISecret))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                iMsg = "对不起，异常错误，请稍后再试！";
                return false;
            }
        }

 
    }
}
