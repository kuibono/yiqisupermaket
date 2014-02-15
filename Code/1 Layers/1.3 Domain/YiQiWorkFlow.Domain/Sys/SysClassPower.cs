/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Sys
{
	///<summary>
	///表sys_class_power的实体类(类别权限设置)
	///</summary>
	public class SysClassPower : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="人员编号")]
		public virtual string EmCode{get ; set; }
		
		/// <summary>
		/// 类别编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="类别编码")]
		public virtual string ClassCode{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysClassPower Clone()
        {
            return (SysClassPower)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysClassPower Initial()
        {
            SysClassPower m = new SysClassPower();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


