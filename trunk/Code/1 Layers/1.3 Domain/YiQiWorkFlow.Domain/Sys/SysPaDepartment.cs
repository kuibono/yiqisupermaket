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
	///表sys_pa_department的实体类(部门编码表)
	///</summary>
	public class SysPaDepartment : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 部门名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="部门名称")]
		public virtual string dName{get ; set; }
		
		/// <summary>
		/// 上级部门
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="上级部门")]
		public virtual string Higher{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysPaDepartment Clone()
        {
            return (SysPaDepartment)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysPaDepartment Initial()
        {
            SysPaDepartment m = new SysPaDepartment();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


