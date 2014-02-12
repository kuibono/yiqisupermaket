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
	///表fb_adjust_saleprice_goods的实体类(调商品售价_商品明细)
	///</summary>
	public class FbAdjustSalepriceGoods : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="调整单号")]
		public virtual string AdjustNumber{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 原销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原销售价",DefaultValue=0)]
		public virtual decimal SalePriceOld{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 原会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原会员价",DefaultValue=0)]
		public virtual decimal VipPriceOld{get ; set; }
		
		/// <summary>
		/// 会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="会员价",DefaultValue=0)]
		public virtual decimal VipPrice{get ; set; }
		
		/// <summary>
		/// 原批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原批发价",DefaultValue=0)]
		public virtual decimal TradePriceOld{get ; set; }
		
		/// <summary>
		/// 批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="批发价",DefaultValue=0)]
		public virtual decimal TradePrice{get ; set; }
		
		/// <summary>
		/// 剩余数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="剩余数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 损溢金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢金额")]
		public virtual decimal LossMoney{get ; set; }
		
		/// <summary>
		/// 不含税损溢金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税损溢金额")]
		public virtual decimal NontaxLossMoney{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbAdjustSalepriceGoods Clone()
        {
            return (FbAdjustSalepriceGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbAdjustSalepriceGoods Initial()
        {
            FbAdjustSalepriceGoods m = new FbAdjustSalepriceGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.SalePriceOld=0M;
			m.SalePrice=0M;
			m.VipPriceOld=0M;
			m.VipPrice=0M;
			m.TradePriceOld=0M;
			m.TradePrice=0M;
			m.StockQty=0M;
            return m;
        }
	}
	 
}


