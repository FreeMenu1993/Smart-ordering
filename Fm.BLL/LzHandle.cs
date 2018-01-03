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

        public string GetProductinfo()
        {
            string strJson = "";
            List<Fm.Entity.product_info> myList = new List<Fm.Entity.product_info>();
            BLL.product_info product_info_BLL = new product_info();
            myList = product_info_BLL.GetList("1");
            strJson = Newtonsoft.Json.JsonConvert.SerializeObject(myList);
            return strJson;
        }

    }
}
