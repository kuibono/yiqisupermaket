/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_supplier_lease的实体类(供货商租赁合同)
	///</summary>
	public class FbSupplierLease : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 合同编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="合同编号")]
		public virtual string LeNumber{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 所属柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属柜台")]
		public virtual string UnderCounterCode{get ; set; }
		
		/// <summary>
		/// 租赁开始日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="租赁开始日期")]
		public virtual System.DateTime? LeaseBeginDate{get ; set; }
		
		/// <summary>
		/// 租赁终止日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="租赁终止日期")]
		public virtual System.DateTime? LeaseEndDate{get ; set; }
		
		/// <summary>
		/// 租金金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="租金金额")]
		public virtual decimal RentalMoney{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 保底金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="保底金额")]
		public virtual decimal FloorsMoney{get ; set; }
		
		/// <summary>
		/// 抽成比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="抽成比率")]
		public virtual decimal RentRate{get ; set; }
		
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
		/// 0否，1是
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0否，1是",DefaultValue="0")]
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
		public FbSupplierLease Clone()
        {
            return (FbSupplierLease)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbSupplierLease Initial()
        {
            FbSupplierLease m = new FbSupplierLease();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


