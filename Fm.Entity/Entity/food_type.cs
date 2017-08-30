/*         
*│版权所有：Dream1993
*│创建人：Lee        
*/  
using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Fm.Entity
{
    /// <summary>
    /// food_type：实体类
    /// </summary>
    [Serializable]
    public class food_type
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
        private int _state;
        /// <summary>
        /// 状态值(0不生效，1生效)
        /// </summary>
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _createtime;
        /// <summary>
        /// 添加时间
        /// </summary>
        public string Createtime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }
        private string _updatetime;
        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public string Updatetime
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }

    }
}