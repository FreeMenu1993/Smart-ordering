using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fm.Entity
{
    #region 菜单展示
    [Serializable]
    public class DataResponse_MenuList : BaseDataResponseByPage
    {
        public List<Entity.food_menu> mylist { get; set; }
    }
    #endregion
}
