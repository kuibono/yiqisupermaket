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
	///表sys_module_content的实体类(模块相关信息)
	///</summary>
	public class SysModuleContent : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 窗口名称
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="窗口名称")]
		public virtual string WindowName{get ; set; }
		
		/// <summary>
		/// 字段编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="字段编码")]
		public virtual string ColumnCode{get ; set; }
		
		/// <summary>
		/// 打开窗口
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="打开窗口")]
		public virtual string OpenWindowName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysModuleContent Clone()
        {
            return (SysModuleContent)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysModuleContent Initial()
        {
            SysModuleContent m = new SysModuleContent();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


