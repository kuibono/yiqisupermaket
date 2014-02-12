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
	///表sys_login_power_function的实体类(人员收银功能)
	///</summary>
	public class SysLoginPowerFunction : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="人员编号")]
		public virtual string EmCode{get ; set; }
		
		/// <summary>
		/// 功能编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="功能编码")]
		public virtual string FuncCode{get ; set; }
		
		/// <summary>
		/// 是否可用
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否可用",DefaultValue="1")]
		public virtual string IfAble{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysLoginPowerFunction Clone()
        {
            return (SysLoginPowerFunction)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysLoginPowerFunction Initial()
        {
            SysLoginPowerFunction m = new SysLoginPowerFunction();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfAble="1";
            return m;
        }
	}
	 
}


