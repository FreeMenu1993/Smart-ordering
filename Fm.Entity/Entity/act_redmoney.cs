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
    /// act_redmoney：实体类
    /// </summary>
	[Serializable]
	public class act_redmoney
	{   
      			private string _red_envelope_code;
		/// <summary>
		/// 红包编码
        /// </summary>
        public string Red_Envelope_Code
        {
            get{ return _red_envelope_code; }
            set{ _red_envelope_code = value; }
        }        
				private string _red_envelope_title;
		/// <summary>
		/// 红包标题
        /// </summary>
        public string Red_Envelope_Title
        {
            get{ return _red_envelope_title; }
            set{ _red_envelope_title = value; }
        }        
				private string _red_envelope_detail;
		/// <summary>
		/// 红包详情
        /// </summary>
        public string Red_Envelope_Detail
        {
            get{ return _red_envelope_detail; }
            set{ _red_envelope_detail = value; }
        }        
				private decimal _red_envelope_money;
		/// <summary>
		/// Red_Envelope_Money
        /// </summary>
        public decimal Red_Envelope_Money
        {
            get{ return _red_envelope_money; }
            set{ _red_envelope_money = value; }
        }        
				private decimal _filled;
		/// <summary>
		/// 满多少发放
        /// </summary>
        public decimal Filled
        {
            get{ return _filled; }
            set{ _filled = value; }
        }        
				private int _amount;
		/// <summary>
		/// 发放数量
        /// </summary>
        public int Amount
        {
            get{ return _amount; }
            set{ _amount = value; }
        }        
				private string _start_date;
		/// <summary>
		/// 开始时间
        /// </summary>
        public string Start_Date
        {
            get{ return _start_date; }
            set{ _start_date = value; }
        }        
				private string _end_date;
		/// <summary>
		/// 结束时间
        /// </summary>
        public string End_Date
        {
            get{ return _end_date; }
            set{ _end_date = value; }
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
		/// 更改时间
        /// </summary>
        public string Updatetime
        {
            get{ return _updatetime; }
            set{ _updatetime = value; }
        }        
		   
	}
}