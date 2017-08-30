using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fm.Entity
{
    #region 菜单展示
    [Serializable]
    public class DataResponse_MenuList : BaseDataResponse
    {
        public List<Entity.DataList_food_menu> mylist { get; set; }
    }
    [Serializable]
    public class DataList_food_menu
    {
        /// <summary>
        /// 类型列表
        /// </summary>
        public List<Entity.DataList_Typecode> Tlist { get; set; }

        private string _foodid;
        /// <summary>
        /// 菜品编码
        /// </summary>
        public string FoodID
        {
            get { return _foodid; }
            set { _foodid = value; }
        }
        private string _food_name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Food_Name
        {
            get { return _food_name; }
            set { _food_name = value; }
        }
        private decimal _price;
        /// <summary>
        /// 售价
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private string _image_src;
        /// <summary>
        /// 图片地址
        /// </summary>
        public string Image_Src
        {
            get { return _image_src; }
            set { _image_src = value; }
        }
        private string _food_summary;
        /// <summary>
        /// 菜品简介
        /// </summary>
        public string Food_Summary
        {
            get { return _food_summary; }
            set { _food_summary = value; }
        }
        private int _is_series;
        /// <summary>
        /// 是否为系列商品
        /// </summary>
        public int Is_Series
        {
            get { return _is_series; }
            set { _is_series = value; }
        }
        private string _seriescode;
        /// <summary>
        /// 系列菜品编号
        /// </summary>
        public string SeriesCode
        {
            get { return _seriescode; }
            set { _seriescode = value; }
        }
        private int _is_feature;
        /// <summary>
        /// 是否为特色、热销（0否，1是）
        /// </summary>
        public int Is_Feature
        {
            get { return _is_feature; }
            set { _is_feature = value; }
        }
    }

    [Serializable]
    public class DataList_Typecode
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
