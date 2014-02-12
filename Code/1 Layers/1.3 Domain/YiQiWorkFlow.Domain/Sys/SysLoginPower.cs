/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Sys
{
	///<summary>
	///表sys_login_power的实体类(登录权限设置)
	///</summary>
	public class SysLoginPower : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="人员编号")]
		public virtual string EmCode{get ; set; }
		
		/// <summary>
		/// 人员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员姓名")]
		public virtual string EmName{get ; set; }
		
		/// <summary>
		/// 用户名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="用户名")]
		public virtual string UserName{get ; set; }
		
		/// <summary>
		/// 密码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="密码")]
		public virtual string UserPw{get ; set; }
		
		/// <summary>
		/// 是否收银
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否收银")]
		public virtual string IfCash{get ; set; }
		
		/// <summary>
		/// 收银功能
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银功能")]
		public virtual string CashFunction{get ; set; }
		
		/// <summary>
		/// 当前状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="当前状态")]
		public virtual string UserState{get ; set; }
		
		/// <summary>
		/// 最大折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="最大折扣")]
		public virtual decimal MaxDiscount{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysLoginPower Clone()
        {
            return (SysLoginPower)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysLoginPower Initial()
        {
            SysLoginPower m = new SysLoginPower();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


