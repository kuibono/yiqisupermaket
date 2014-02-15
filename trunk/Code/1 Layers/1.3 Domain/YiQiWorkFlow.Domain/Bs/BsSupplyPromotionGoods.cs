/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:28
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_supply_promotion_goods的实体类(配价促销_商品明细)
	///</summary>
	public class BsSupplyPromotionGoods : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 促销单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="促销单号")]
		public virtual string SpNumber{get ; set; }
		
		/// <summary>
		/// 促销开始日期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销开始日期")]
		public virtual string SpBeginDate{get ; set; }
		
		/// <summary>
		/// 促销终止日期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销终止日期")]
		public virtual string SpEndDate{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 是否销售价
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否销售价")]
		public virtual string IfSalePrice{get ; set; }
		
		/// <summary>
		/// 原配送价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原配送价")]
		public virtual decimal SupplyPriceOld{get ; set; }
		
		/// <summary>
		/// 配送价折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送价折扣")]
		public virtual decimal SupplyPriceDiscount{get ; set; }
		
		/// <summary>
		/// 新配送价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="新配送价")]
		public virtual decimal SupplyPrice{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsSupplyPromotionGoods Clone()
        {
            return (BsSupplyPromotionGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsSupplyPromotionGoods Initial()
        {
            BsSupplyPromotionGoods m = new BsSupplyPromotionGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


