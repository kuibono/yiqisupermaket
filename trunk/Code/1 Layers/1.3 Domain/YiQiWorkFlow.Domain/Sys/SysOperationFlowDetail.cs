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
	///表sys_operation_flow_detail的实体类(业务流程明细)
	///</summary>
	public class SysOperationFlowDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流程编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="流程编号")]
		public virtual string OperationNumber{get ; set; }
		
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
		/// 窗口名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="窗口名称")]
		public virtual string WindowName{get ; set; }
		
		/// <summary>
		/// 当前序号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="当前序号")]
		public virtual string CurrentsNumber{get ; set; }
		
		/// <summary>
		/// 上次功能
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="上次功能")]
		public virtual string FunctionCode{get ; set; }
		
		/// <summary>
		/// 当前功能
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="当前功能")]
		public virtual string CurrentFunctionCode{get ; set; }
		
		/// <summary>
		/// 字段内容
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="字段内容")]
		public virtual string ColumnName{get ; set; }
		
		/// <summary>
		/// 0 为执行完成
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0 为执行完成")]
		public virtual string NextsNumber{get ; set; }
		
		/// <summary>
		/// 0 操作未提交，1提交
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0 操作未提交，1提交")]
		public virtual string CurrentState{get ; set; }
		
		/// <summary>
		/// 一般，紧急
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="一般，紧急")]
		public virtual string OperationState{get ; set; }
		
		/// <summary>
		/// 通过，不通过
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="通过，不通过")]
		public virtual string OperationResult{get ; set; }
		
		/// <summary>
		/// 业务意见
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务意见")]
		public virtual string OperationOpinion{get ; set; }
		
		/// <summary>
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		/// <summary>
		/// 语句
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="语句")]
		public virtual string Statement{get ; set; }
		
		/// <summary>
		/// 语句执行
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="语句执行")]
		public virtual string StatementState{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysOperationFlowDetail Clone()
        {
            return (SysOperationFlowDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysOperationFlowDetail Initial()
        {
            SysOperationFlowDetail m = new SysOperationFlowDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


