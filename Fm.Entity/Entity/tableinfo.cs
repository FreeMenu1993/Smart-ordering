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
    /// tableinfo：实体类
    /// </summary>
	[Serializable]
	public class tableinfo
	{   
      			private int _tablecode;
		/// <summary>
		/// 桌号
        /// </summary>
        public int TableCode
        {
            get{ return _tablecode; }
            set{ _tablecode = value; }
        }        
				private int _chairnum;
		/// <summary>
		/// 椅子数量
        /// </summary>
        public int ChairNum
        {
            get{ return _chairnum; }
            set{ _chairnum = value; }
        }        
				private string _tablename;
		/// <summary>
		/// 餐桌备注名
        /// </summary>
        public string TableName
        {
            get{ return _tablename; }
            set{ _tablename = value; }
        }        
		   
	}
}