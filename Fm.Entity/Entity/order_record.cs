/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/  
using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Fm.Entity{
	/// <summary>
    /// order_record：实体类
    /// </summary>
	[Serializable]
	public class order_record
	{   
      			private string _orderid;
		/// <summary>
		/// 订单编号
        /// </summary>
        public string OrderID
        {
            get{ return _orderid; }
            set{ _orderid = value; }
        }        
				private string _userid;
		/// <summary>
		/// 用户编号
        /// </summary>
        public string UserID
        {
            get{ return _userid; }
            set{ _userid = value; }
        }        
				private int _tablecode;
		/// <summary>
		/// 桌号
        /// </summary>
        public int TableCode
        {
            get{ return _tablecode; }
            set{ _tablecode = value; }
        }        
				private decimal _amount;
		/// <summary>
		/// 总价
        /// </summary>
        public decimal Amount
        {
            get{ return _amount; }
            set{ _amount = value; }
        }        
				private decimal _discount;
		/// <summary>
		/// 折扣价
        /// </summary>
        public decimal Discount
        {
            get{ return _discount; }
            set{ _discount = value; }
        }        
				private decimal _mymoney;
		/// <summary>
		/// 实际收款
        /// </summary>
        public decimal Mymoney
        {
            get{ return _mymoney; }
            set{ _mymoney = value; }
        }        
				private int _state;
		/// <summary>
		/// 状态（0 未完成，1已完成）
        /// </summary>
        public int State
        {
            get{ return _state; }
            set{ _state = value; }
        }        
				private string _createtime;
		/// <summary>
		/// 创建时间
        /// </summary>
        public string Createtime
        {
            get{ return _createtime; }
            set{ _createtime = value; }
        }        
				private string _updatetime;
		/// <summary>
		/// 更新时间
        /// </summary>
        public string Updatetime
        {
            get{ return _updatetime; }
            set{ _updatetime = value; }
        }        
		   
	}
}