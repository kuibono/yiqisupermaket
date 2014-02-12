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
	///表sys_operation_worker的实体类(业务流程_人员权限)
	///</summary>
	public class SysOperationWorker : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流程名称
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="流程名称")]
		public virtual string OperationName{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员编号")]
		public virtual string EmCode{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysOperationWorker Clone()
        {
            return (SysOperationWorker)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysOperationWorker Initial()
        {
            SysOperationWorker m = new SysOperationWorker();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


