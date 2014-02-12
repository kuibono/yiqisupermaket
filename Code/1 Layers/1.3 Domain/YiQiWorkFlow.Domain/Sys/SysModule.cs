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
	///表sys_module的实体类(功能模块设置)
	///</summary>
	public class SysModule : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 窗口代码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="窗口代码")]
		public virtual string WindowCode{get ; set; }
		
		/// <summary>
		/// 窗口名称
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="窗口名称")]
		public virtual string WindowName{get ; set; }
		
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
		
		/// <summary>
		/// 窗口功能
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="窗口功能")]
		public virtual string FunctionCode{get ; set; }
		
		/// <summary>
		/// open,opensheet
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="open,opensheet")]
		public virtual string OpenMode{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysModule Clone()
        {
            return (SysModule)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysModule Initial()
        {
            SysModule m = new SysModule();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


