/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_adjust_supplier的实体类(调商品供货商)
	///</summary>
	public class FbAdjustSupplier : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="调整单号")]
		public virtual string AdjustNumber{get ; set; }
		
		/// <summary>
		/// 调整日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="调整日期")]
		public virtual System.DateTime? AdjustDate{get ; set; }
		
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
		public FbAdjustSupplier Clone()
        {
            return (FbAdjustSupplier)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbAdjustSupplier Initial()
        {
            FbAdjustSupplier m = new FbAdjustSupplier();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


