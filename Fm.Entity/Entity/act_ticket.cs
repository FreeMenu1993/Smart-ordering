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
    /// act_ticket：实体类
    /// </summary>
	[Serializable]
	public class act_ticket
	{   
      			private string _userid;
		/// <summary>
		/// 用户编号
        /// </summary>
        public string UserID
        {
            get{ return _userid; }
            set{ _userid = value; }
        }        
				private string _ticket_code;
		/// <summary>
		/// 券编号
        /// </summary>
        public string Ticket_Code
        {
            get{ return _ticket_code; }
            set{ _ticket_code = value; }
        }        
				private string _ticket_type;
		/// <summary>
		/// 券类型
        /// </summary>
        public string Ticket_Type
        {
            get{ return _ticket_type; }
            set{ _ticket_type = value; }
        }        
				private int _state;
		/// <summary>
		/// 状态（0异常，1正常）
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