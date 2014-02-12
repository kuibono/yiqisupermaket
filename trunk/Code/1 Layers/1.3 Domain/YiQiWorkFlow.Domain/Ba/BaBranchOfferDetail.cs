/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ba
{
	///<summary>
	///表ba_branch_offer_detail的实体类(分店代销对帐_明细)
	///</summary>
	public class BaBranchOfferDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 对帐单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="对帐单号")]
		public virtual string AcNumber{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="销售时间")]
		public virtual string RtDate{get ; set; }
		
		/// <summary>
		/// 数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="数量")]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 配送单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送单价",DefaultValue=0)]
		public virtual decimal SupplyPrice{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 配送金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送金额")]
		public virtual decimal SupplyMoney{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaBranchOfferDetail Clone()
        {
            return (BaBranchOfferDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaBranchOfferDetail Initial()
        {
            BaBranchOfferDetail m = new BaBranchOfferDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.SupplyPrice=0M;
            return m;
        }
	}
	 
}


