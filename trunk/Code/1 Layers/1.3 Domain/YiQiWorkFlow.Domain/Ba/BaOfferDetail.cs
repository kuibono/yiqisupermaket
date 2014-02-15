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
	///表ba_offer_detail的实体类(代销对账单_商品明细)
	///</summary>
	public class BaOfferDetail : EntityGUIDBase, IAggregateRootGUID
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
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 应付金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="应付金额")]
		public virtual decimal PayableMoney{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaOfferDetail Clone()
        {
            return (BaOfferDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaOfferDetail Initial()
        {
            BaOfferDetail m = new BaOfferDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


