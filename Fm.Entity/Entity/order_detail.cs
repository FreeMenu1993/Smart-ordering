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
    /// order_detail：实体类
    /// </summary>
	[Serializable]
	public class order_detail
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
				private string _food_code;
		/// <summary>
		/// 菜品编码
        /// </summary>
        public string Food_Code
        {
            get{ return _food_code; }
            set{ _food_code = value; }
        }        
				private int _state;
		/// <summary>
		/// 状态值（0撤销，1正常）
        /// </summary>
        public int State
        {
            get{ return _state; }
            set{ _state = value; }
        }        
				private string _createtime;
		/// <summary>
		/// 添加时间
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