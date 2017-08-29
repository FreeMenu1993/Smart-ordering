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

    #region 菜单详情
    [Serializable]
    public class DataResponse_FoodDetail : BaseDataResponse
    {
        public List<Entity.food_menu> Rlist { get; set; }
    }
    #endregion

    #region 订单
    [Serializable]
    public class Request_order
    {
        /// <summary>
        /// 订单详情列表
        /// </summary>
        public List<Entity.order_detail> Dlist { get; set; }

        private string _orderid;
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderID
        {
            get { return _orderid; }
            set { _orderid = value; }
        }
        private string _userid;
        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        private int _tablecode;
        /// <summary>
        /// 桌号
        /// </summary>
        public int TableCode
        {
            get { return _tablecode; }
            set { _tablecode = value; }
        }
        private decimal _amount;
        /// <summary>
        /// 总价
        /// </summary>
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private decimal _discount;
        /// <summary>
        /// 折扣价
        /// </summary>
        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        private decimal _mymoney;
        /// <summary>
        /// 实际收款
        /// </summary>
        public decimal Mymoney
        {
            get { return _mymoney; }
            set { _mymoney = value; }
        }
        private int _state;
        /// <summary>
        /// 状态（0 未完成，1已完成）
        /// </summary>
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _createtime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public string Createtime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }
        private string _updatetime;
        /// <summary>
        /// 更新时间
        /// </summary>
        public string Updatetime
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }
    }
    #endregion

    #region 菜单类型
    [Serializable]
    public class DataList_food_type
    {
        private string _foodtype_code;
        /// <summary>
        /// 种类编码
        /// </summary>
        public string FoodType_Code
        {
            get { return _foodtype_code; }
            set { _foodtype_code = value; }
        }
        private string _foodtype_name;
        /// <summary>
        /// 种类名称
        /// </summary>
        public string FoodType_Name
        {
            get { return _foodtype_name; }
            set { _foodtype_name = value; }
        }
        private int _sort;
        /// <summary>
        /// 序号（按次序显示）
        /// </summary>
        public int Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
    }
    [Serializable]
    public class DataResponse_food_type : BaseDataResponse
    {
       public List<DataList_food_type> Rlist { get; set; }
    }
    #endregion
}
