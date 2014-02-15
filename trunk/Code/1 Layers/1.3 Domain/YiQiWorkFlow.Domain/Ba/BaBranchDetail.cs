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
	///表ba_branch_detail的实体类(分店结算_明细)
	///</summary>
	public class BaBranchDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 业务单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="业务单号")]
		public virtual string OperatNumber{get ; set; }
		
		/// <summary>
		/// 业务类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务类型")]
		public virtual string OperatType{get ; set; }
		
		/// <summary>
		/// 应收金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="应收金额")]
		public virtual decimal ReceivableMoney{get ; set; }
		
		/// <summary>
		/// 已收金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="已收金额")]
		public virtual decimal ReceivedMoney{get ; set; }
		
		/// <summary>
		/// 未付金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="未付金额")]
		public virtual decimal UnreceivedMoney{get ; set; }
		
		/// <summary>
		/// 收款金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="收款金额")]
		public virtual decimal PayMoney{get ; set; }
		
		/// <summary>
		/// 收款差额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="收款差额")]
		public virtual decimal PayMargin{get ; set; }
		
		/// <summary>
		/// 结转，优惠
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结转，优惠")]
		public virtual string MarginDeal{get ; set; }
		
		/// <summary>
		/// 业务表名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务表名")]
		public virtual string TableName{get ; set; }
		
		/// <summary>
		/// 业务主键
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务主键")]
		public virtual string ColumnName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaBranchDetail Clone()
        {
            return (BaBranchDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaBranchDetail Initial()
        {
            BaBranchDetail m = new BaBranchDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


