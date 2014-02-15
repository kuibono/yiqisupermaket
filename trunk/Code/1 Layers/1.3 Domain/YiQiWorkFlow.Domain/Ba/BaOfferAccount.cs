/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ba
{
	///<summary>
	///表ba_offer_account的实体类(代销对账单)
	///</summary>
	public class BaOfferAccount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 对账日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="对账日期")]
		public virtual System.DateTime? AcDate{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 开始时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="开始时间")]
		public virtual System.DateTime? BeginDate{get ; set; }
		
		/// <summary>
		/// 终止时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="终止时间")]
		public virtual System.DateTime? EndDate{get ; set; }
		
		/// <summary>
		/// 对帐金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="对帐金额")]
		public virtual decimal AccountMoney{get ; set; }
		
		/// <summary>
		/// 是否允许结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否允许结算",DefaultValue="0")]
		public virtual string IfAblebalance{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算")]
		public virtual string IfBalance{get ; set; }
		
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算金额")]
		public virtual decimal BaMoney{get ; set; }
		
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
		public BaOfferAccount Clone()
        {
            return (BaOfferAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaOfferAccount Initial()
        {
            BaOfferAccount m = new BaOfferAccount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfAblebalance="0";
			m.IfExamine="0";
            return m;
        }
	}
	 
}


