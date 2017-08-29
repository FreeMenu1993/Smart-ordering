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
    /// act_filled：实体类
    /// </summary>
    [Serializable]
    public class act_filled
    {
        private string _filledid;
        /// <summary>
        /// 满额券编号
        /// </summary>
        public string FilledID
        {
            get { return _filledid; }
            set { _filledid = value; }
        }
        private string _ticket_type;
        /// <summary>
        /// 满额券类型
        /// </summary>
        public string Ticket_Type
        {
            get { return _ticket_type; }
            set { _ticket_type = value; }
        }
        private string _title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _detail;
        /// <summary>
        /// 详情
        /// </summary>
        public string Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }
        private string _receive_full;
        /// <summary>
        /// 领取满额
        /// </summary>
        public string Receive_Full
        {
            get { return _receive_full; }
            set { _receive_full = value; }
        }
        private string _use_full;
        /// <summary>
        /// 使用满额
        /// </summary>
        public string Use_Full
        {
            get { return _use_full; }
            set { _use_full = value; }
        }
        private string _use_derate;
        /// <summary>
        /// 使用减额
        /// </summary>
        public string Use_Derate
        {
            get { return _use_derate; }
            set { _use_derate = value; }
        }
        private string _start_date;
        /// <summary>
        /// 开始时间
        /// </summary>
        public string Start_Date
        {
            get { return _start_date; }
            set { _start_date = value; }
        }
        private string _end_date;
        /// <summary>
        /// 结束时间
        /// </summary>
        public string End_Date
        {
            get { return _end_date; }
            set { _end_date = value; }
        }
        private int _amount;
        /// <summary>
        /// 发放数量
        /// </summary>
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private int _state;
        /// <summary>
        /// 状态码（0未开启，1正常）
        /// </summary>
        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _createtime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public string Createtime
        {
            get { return _createtime; }
            set { _createtime = value; }
        }
        private string _updatetime;
        /// <summary>
        /// 更改时间
        /// </summary>
        public string Updatetime
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }

    }
}