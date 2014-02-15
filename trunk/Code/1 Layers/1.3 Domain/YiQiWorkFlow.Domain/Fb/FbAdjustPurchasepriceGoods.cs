/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:28
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_adjust_purchaseprice_goods的实体类(调商品进价_商品明细)
	///</summary>
	public class FbAdjustPurchasepriceGoods : EntityGUIDBase, IAggregateRootGUID
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
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 进项税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进项税率")]
		public virtual decimal InputTax{get ; set; }
		
		/// <summary>
		/// 原含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="原含税进价",DefaultValue=0)]
		public virtual decimal PurchasePriceOld{get ; set; }
		
		/// <summary>
		/// 原不含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="原不含税进价",DefaultValue=0)]
		public virtual decimal NontaxPurchasePriceOld{get ; set; }
		
		/// <summary>
		/// 含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="含税进价",DefaultValue=0)]
		public virtual decimal PurchasePrice{get ; set; }
		
		/// <summary>
		/// 不含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="不含税进价",DefaultValue=0)]
		public virtual decimal NontaxPurchasePrice{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbAdjustPurchasepriceGoods Clone()
        {
            return (FbAdjustPurchasepriceGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbAdjustPurchasepriceGoods Initial()
        {
            FbAdjustPurchasepriceGoods m = new FbAdjustPurchasepriceGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchasePriceOld=0M;
			m.NontaxPurchasePriceOld=0M;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
            return m;
        }
	}
	 
}


