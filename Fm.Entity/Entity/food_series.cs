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
    /// food_series：实体类
    /// </summary>
	[Serializable]
	public class food_series
	{   
      			private string _seriescode;
		/// <summary>
		/// 系列菜品编号
        /// </summary>
        public string SeriesCode
        {
            get{ return _seriescode; }
            set{ _seriescode = value; }
        }        
				private string _seriesname;
		/// <summary>
		/// 系列名
        /// </summary>
        public string SeriesName
        {
            get{ return _seriesname; }
            set{ _seriesname = value; }
        }        
		   
	}
}