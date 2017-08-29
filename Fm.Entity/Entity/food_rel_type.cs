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
    /// food_rel_type：实体类
    /// </summary>
	[Serializable]
	public class food_rel_type
	{   
      			private string _foodid;
		/// <summary>
		/// 菜品编码
        /// </summary>
        public string FoodID
        {
            get{ return _foodid; }
            set{ _foodid = value; }
        }        
				private string _foodtype_code;
		/// <summary>
		/// 菜品种类编码
        /// </summary>
        public string FoodType_Code
        {
            get{ return _foodtype_code; }
            set{ _foodtype_code = value; }
        }        
				private int _sort;
		/// <summary>
		/// 序号（菜品在一类型中显示顺序）
        /// </summary>
        public int Sort
        {
            get{ return _sort; }
            set{ _sort = value; }
        }        
				private int _state;
		/// <summary>
		/// 状态(0不生效，1生效)
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
		/// 更改时间
        /// </summary>
        public string Updatetime
        {
            get{ return _updatetime; }
            set{ _updatetime = value; }
        }        
		   
	}
}