/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:30
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_adjust_manage_flow的实体类(商品调整流水帐单)
	///</summary>
	public class OpAdjustManageFlow : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 调整日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="调整日期")]
		public virtual System.DateTime? AdjustDate{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 调整类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调整类型")]
		public virtual string AdjustType{get ; set; }
		
		/// <summary>
		/// 调整业务
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调整业务")]
		public virtual string AdjustOperat{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 调整原因
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调整原因")]
		public virtual string AdjustReason{get ; set; }
		
		/// <summary>
		/// 创建时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="创建时间")]
		public virtual System.DateTime? CreateDate{get ; set; }
		
		/// <summary>
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 审核人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="审核人")]
		public virtual string Assessor{get ; set; }
		
		/// <summary>
		/// 是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否审核",DefaultValue="0")]
		public virtual string IfExamine{get ; set; }
		
		/// <summary>
		/// 审核时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="审核时间")]
		public virtual System.DateTime? ExamineDate{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpAdjustManageFlow Clone()
        {
            return (OpAdjustManageFlow)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpAdjustManageFlow Initial()
        {
            OpAdjustManageFlow m = new OpAdjustManageFlow();
			m.IfExamine="0";
            return m;
        }
	}
	 
}


