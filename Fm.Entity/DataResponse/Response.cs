using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fm.Entity
{
    #region 商品列表信息响应类
    public class DataResponse_Productinfo : BaseDataResponseByPage
    {
        public List<DataList_Productinfo> mylist { get; set; }
    }
    public class DataList_Productinfo
    {
        /// <summary>
        /// 商品编号
        /// </summary>		
        private string _productid;
        public string ProductId
        {
            get { return _productid; }
            set { _productid = value; }
        }
        /// <summary>
        /// 商品名称
        /// </summary>		
        private string _productname;
        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }
        ///<summary>
        ///商品价格
        ///</summary>
        private decimal _productprice;
        public decimal ProductPrice
        {
            get { return _productprice; }
            set { _productprice = value; }
        }
        ///<summary>
        ///商品图片
        ///</summary>
        private string _productimage;
        public string ProductImage
        {
            get { return _productimage; }
            set { _productimage = value; }
        }

    }
    #endregion

    #region 商品详细信息响应类
    public class DataResponse_info : BaseDataResponse
    {
        /// <summary>
        /// 商品编号
        /// </summary>		
        private string _productid;
        public string ProductId
        {
            get { return _productid; }
            set { _productid = value; }
        }
        /// <summary>
        /// 商品名称
        /// </summary>		
        private string _productname;
        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }
        /// <summary>
        /// 标价
        /// </summary>		
        private decimal _productprice;
        public decimal ProductPrice
        {
            get { return _productprice; }
            set { _productprice = value; }
        }
        /// <summary>
        /// 商品图片
        /// </summary>		
        private string _mainimgurl;
        public string MainImgUrl
        {
            get { return _mainimgurl; }
            set { _mainimgurl = value; }
        }
        /// <summary>
        /// 商品库存
        /// </summary>		
        private int _storenum;
        public int StoreNum
        {
            get { return _storenum; }
            set { _storenum = value; }
        }
        /// <summary>
        /// 商品销量
        /// </summary>		
        private int _salesnum;
        public int SalesNum
        {
            get { return _salesnum; }
            set { _salesnum = value; }
        }
        /// <summary>
        /// 商品类型Id
        /// </summary>		
        private int _typeid;
        public int TypeId
        {
            get { return _typeid; }
            set { _typeid = value; }
        }
        /// <summary>
        /// 商品规格  
        /// </summary>		
        private string _specifications;
        public string Specifications
        {
            get { return _specifications; }
            set { _specifications = value; }
        }
        /// <summary>
        /// 商品单位重量(kg）
        /// </summary>		
        private decimal _productweight;
        public decimal ProductWeight
        {
            get { return _productweight; }
            set { _productweight = value; }
        }
        /// <summary>
        /// 商品描述
        /// </summary>		
        private string _productdetail;
        public string ProductDetail
        {
            get { return _productdetail; }
            set { _productdetail = value; }
        }
        /// <summary>
        /// 所属公司
        /// </summary>		
        private string _madefactor;
        public string MadeFactor
        {
            get { return _madefactor; }
            set { _madefactor = value; }
        }
        /// <summary>
        /// 商品产地
        /// </summary>		
        private string _madehome;
        public string MadeHome
        {
            get { return _madehome; }
            set { _madehome = value; }
        }
        /// <summary>
        /// 用户状态（默认为1）
        /// </summary>		
        private int _stateid;
        public int StateId
        {
            get { return _stateid; }
            set { _stateid = value; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>		
        private string _refreshdate;
        public string RefreshDate
        {
            get { return _refreshdate; }
            set { _refreshdate = value; }
        }        
    }
    #endregion

    #region 收货地址信息响应类
    public class DataResponse_useraddress : BaseDataResponse
    {
        public List<DataList_useraddress> mylist { get; set; }
    }
    public class DataList_useraddress
    {
        /// <summary>
        /// 地址编号
        /// </summary>		
        private int _addressid;
        public int AddressId
        {
            get { return _addressid; }
            set { _addressid = value; }
        }
        /// <summary>
        /// 收货人
        /// </summary>		
        private string _pername;
        public string PerName
        {
            get { return _pername; }
            set { _pername = value; }
        }
        ///<summary>
        ///收货手机号
        ///</summary>
        private string _permobile;
        public string PerMobile
        {
            get { return _permobile; }
            set { _permobile = value; }
        }
        ///<summary>
        ///收货地址
        ///</summary>
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
    #endregion
}
