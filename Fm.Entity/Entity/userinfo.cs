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
    /// userinfo：实体类
    /// </summary>
	[Serializable]
	public class userinfo
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
				private string _nickname;
		/// <summary>
		/// 用户昵称
        /// </summary>
        public string NickName
        {
            get{ return _nickname; }
            set{ _nickname = value; }
        }        
				private string _avatarurl;
		/// <summary>
		/// 用户头像地址
        /// </summary>
        public string AvatarUrl
        {
            get{ return _avatarurl; }
            set{ _avatarurl = value; }
        }        
				private int _sex;
		/// <summary>
		/// 用户性别
        /// </summary>
        public int Sex
        {
            get{ return _sex; }
            set{ _sex = value; }
        }        
				private string _country;
		/// <summary>
		/// 国家
        /// </summary>
        public string Country
        {
            get{ return _country; }
            set{ _country = value; }
        }        
				private string _province;
		/// <summary>
		/// 省份
        /// </summary>
        public string Province
        {
            get{ return _province; }
            set{ _province = value; }
        }        
				private string _city;
		/// <summary>
		/// 城市
        /// </summary>
        public string City
        {
            get{ return _city; }
            set{ _city = value; }
        }        
				private string _mobile;
		/// <summary>
		/// 手机号
        /// </summary>
        public string Mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
        }        
				private int _rank;
		/// <summary>
		/// 会员等级（0未开通）
        /// </summary>
        public int Rank
        {
            get{ return _rank; }
            set{ _rank = value; }
        }        
				private int _state;
		/// <summary>
		/// 用户状态（0已删除，1激活）
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
				private string _refreshtime;
		/// <summary>
		/// 更新时间
        /// </summary>
        public string Refreshtime
        {
            get{ return _refreshtime; }
            set{ _refreshtime = value; }
        }        
		   
	}
}