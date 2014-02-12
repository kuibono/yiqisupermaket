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
	///表sys_module_pic的实体类(系统模块图片)
	///</summary>
	public class SysModulePic : EntityGUIDBase, IAggregateRootGUID
	{
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
		/// 图片路径
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="图片路径")]
		public virtual string PicName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysModulePic Clone()
        {
            return (SysModulePic)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysModulePic Initial()
        {
            SysModulePic m = new SysModulePic();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


