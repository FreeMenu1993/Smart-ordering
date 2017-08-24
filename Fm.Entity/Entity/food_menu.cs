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
    /// food_menu：实体类
    /// </summary>
	[Serializable]
	public class food_menu
	{   
      			private string _food_code;
		/// <summary>
		/// 菜品编码
        /// </summary>
        public string Food_Code
        {
            get{ return _food_code; }
            set{ _food_code = value; }
        }        
				private string _food_name;
		/// <summary>
		/// 名称
        /// </summary>
        public string Food_Name
        {
            get{ return _food_name; }
            set{ _food_name = value; }
        }        
				private decimal _price;
		/// <summary>
		/// 售价
        /// </summary>
        public decimal Price
        {
            get{ return _price; }
            set{ _price = value; }
        }        
				private string _image_src;
		/// <summary>
		/// 图片地址
        /// </summary>
        public string Image_Src
        {
            get{ return _image_src; }
            set{ _image_src = value; }
        }        
				private string _food_summary;
		/// <summary>
		/// 菜品简介
        /// </summary>
        public string Food_Summary
        {
            get{ return _food_summary; }
            set{ _food_summary = value; }
        }        
				private int _is_series;
		/// <summary>
		/// 是否为系列商品
        /// </summary>
        public int Is_Series
        {
            get{ return _is_series; }
            set{ _is_series = value; }
        }        
				private string _seriescode;
		/// <summary>
		/// 系列菜品编号
        /// </summary>
        public string SeriesCode
        {
            get{ return _seriescode; }
            set{ _seriescode = value; }
        }        
				private int _is_feature;
		/// <summary>
		/// 是否为特色、热销（0否，1是）
        /// </summary>
        public int Is_Feature
        {
            get{ return _is_feature; }
            set{ _is_feature = value; }
        }        
				private int _state;
		/// <summary>
		/// 菜品状态码（0下架，1正常）
        /// </summary>
        public int State
        {
            get{ return _state; }
            set{ _state = value; }
        }        
				private DateTime _createtime;
		/// <summary>
		/// 添加时间
        /// </summary>
        public DateTime Createtime
        {
            get{ return _createtime; }
            set{ _createtime = value; }
        }        
				private DateTime _updatetime;
		/// <summary>
		/// 更新时间
        /// </summary>
        public DateTime Updatetime
        {
            get{ return _updatetime; }
            set{ _updatetime = value; }
        }        
		   
	}
}