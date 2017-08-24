using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fm.BLL
{
    public class LzHandle
    {
        #region menu view
        public string ViewMenu()
        {
            string strJson = "";
            food_menu Bfood_menu = new food_menu();
            Bfood_menu.GetListByState(1);
            return strJson;
        }
        #endregion
    }
}
