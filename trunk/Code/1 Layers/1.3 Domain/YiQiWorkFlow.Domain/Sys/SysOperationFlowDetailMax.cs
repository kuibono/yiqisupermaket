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
	///表sys_operation_flow_detail_max的实体类(流程最大编号表)
	///</summary>
	public class SysOperationFlowDetailMax : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流程编号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流程编号")]
		public virtual decimal OperationNumber{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysOperationFlowDetailMax Clone()
        {
            return (SysOperationFlowDetailMax)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysOperationFlowDetailMax Initial()
        {
            SysOperationFlowDetailMax m = new SysOperationFlowDetailMax();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


