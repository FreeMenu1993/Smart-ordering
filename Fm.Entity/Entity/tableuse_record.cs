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
    /// tableuse_record：实体类
    /// </summary>
	[Serializable]
	public class tableuse_record
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
				private int _tablecode;
		/// <summary>
		/// 桌号
        /// </summary>
        public int TableCode
        {
            get{ return _tablecode; }
            set{ _tablecode = value; }
        }        
				private DateTime _starttime;
		/// <summary>
		/// 开始时间
        /// </summary>
        public DateTime Starttime
        {
            get{ return _starttime; }
            set{ _starttime = value; }
        }        
				private DateTime _stoptime;
		/// <summary>
		/// 结束时间
        /// </summary>
        public DateTime Stoptime
        {
            get{ return _stoptime; }
            set{ _stoptime = value; }
        }        
		   
	}
}