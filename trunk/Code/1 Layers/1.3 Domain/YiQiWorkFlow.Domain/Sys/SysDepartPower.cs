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
	///表sys_depart_power的实体类(岗位权限)
	///</summary>
	public class SysDepartPower : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 部门编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="部门编码")]
		public virtual string dCode{get ; set; }
		
		/// <summary>
		/// 窗口名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="窗口名称")]
		public virtual string WindowName{get ; set; }
		
		/// <summary>
		/// 窗口功能
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="窗口功能")]
		public virtual string FunctionCode{get ; set; }
		
		/// <summary>
		/// 选择
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="选择")]
		public virtual string Selection{get ; set; }
		
		/// <summary>
		/// 模块代码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="模块代码")]
		public virtual string ModuleCode{get ; set; }
		
		/// <summary>
		/// 模块名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="模块名称")]
		public virtual string ModuleName{get ; set; }
		
		/// <summary>
		/// 主营业务，参数设置，查询分析
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="主营业务，参数设置，查询分析")]
		public virtual string ModuleChild{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysDepartPower Clone()
        {
            return (SysDepartPower)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysDepartPower Initial()
        {
            SysDepartPower m = new SysDepartPower();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}

