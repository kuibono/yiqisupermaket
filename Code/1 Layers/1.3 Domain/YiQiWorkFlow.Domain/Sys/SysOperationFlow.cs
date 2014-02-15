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
	///表sys_operation_flow的实体类(业务流程)
	///</summary>
	public class SysOperationFlow : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 窗口名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="窗口名称")]
		public virtual string WindowName{get ; set; }
		
		/// <summary>
		/// 窗口功能
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="窗口功能")]
		public virtual string FunctionCode{get ; set; }
		
		/// <summary>
		/// 回置序号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="回置序号")]
		public virtual string TurnsNumber{get ; set; }
		
		/// <summary>
		/// 业务功能
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务功能")]
		public virtual string Operation{get ; set; }
		
		/// <summary>
		/// 符号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="符号")]
		public virtual string Condition{get ; set; }
		
		/// <summary>
		/// 内容
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="内容")]
		public virtual decimal Content{get ; set; }
		
		/// <summary>
		/// 语句
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="语句")]
		public virtual string Statement{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysOperationFlow Clone()
        {
            return (SysOperationFlow)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysOperationFlow Initial()
        {
            SysOperationFlow m = new SysOperationFlow();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


