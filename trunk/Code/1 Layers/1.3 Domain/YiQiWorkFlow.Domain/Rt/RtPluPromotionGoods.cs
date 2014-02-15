/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:32
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_plu_promotion_goods的实体类(单品促销_商品明细)
	///</summary>
	public class RtPluPromotionGoods : EntityGUIDBase, IAggregateRootGUID
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
		/// 促销开始时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销开始时间")]
		public virtual string SpBeginTime{get ; set; }
		
		/// <summary>
		/// 促销终止时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销终止时间")]
		public virtual string SpEndTime{get ; set; }
		
		/// <summary>
		/// 星期1
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期1")]
		public virtual string SpW1{get ; set; }
		
		/// <summary>
		/// 星期2
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期2")]
		public virtual string SpW2{get ; set; }
		
		/// <summary>
		/// 星期3
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期3")]
		public virtual string SpW3{get ; set; }
		
		/// <summary>
		/// 星期4
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期4")]
		public virtual string SpW4{get ; set; }
		
		/// <summary>
		/// 星期5
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期5")]
		public virtual string SpW5{get ; set; }
		
		/// <summary>
		/// 星期6
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期6")]
		public virtual string SpW6{get ; set; }
		
		/// <summary>
		/// 星期7
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期7")]
		public virtual string SpW7{get ; set; }
		
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
		/// 原销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原销售价")]
		public virtual decimal SalePriceOld{get ; set; }
		
		/// <summary>
		/// 销售价折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价折扣")]
		public virtual decimal SalePriceDiscount{get ; set; }
		
		/// <summary>
		/// 新销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="新销售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 是否限量
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否限量")]
		public virtual string IfLimit{get ; set; }
		
		/// <summary>
		/// 总限量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="总限量")]
		public virtual decimal TotalLimit{get ; set; }
		
		/// <summary>
		/// 总已销量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="总已销量",DefaultValue=0)]
		public virtual decimal TotalLimitSale{get ; set; }
		
		/// <summary>
		/// 日限量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="日限量")]
		public virtual decimal DayLimit{get ; set; }
		
		/// <summary>
		/// 日限日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="日限日期")]
		public virtual System.DateTime? DayLimitDate{get ; set; }
		
		/// <summary>
		/// 日已销量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="日已销量",DefaultValue=0)]
		public virtual decimal DayLimitSale{get ; set; }
		
		/// <summary>
		/// 单笔限量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="单笔限量")]
		public virtual decimal SheetLimit{get ; set; }
		
		/// <summary>
		/// 是否扣率
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否扣率")]
		public virtual string IfPool{get ; set; }
		
		/// <summary>
		/// 原扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原扣率")]
		public virtual decimal PoolRateOld{get ; set; }
		
		/// <summary>
		/// 新扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="新扣率")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 是否会员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否会员")]
		public virtual string IfVip{get ; set; }
		
		/// <summary>
		/// 原会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原会员价")]
		public virtual decimal VipPriceOld{get ; set; }
		
		/// <summary>
		/// 新会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="新会员价")]
		public virtual decimal VipPrice{get ; set; }
		
		/// <summary>
		/// 会员单笔限量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="会员单笔限量")]
		public virtual decimal VipSheetLimit{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPluPromotionGoods Clone()
        {
            return (RtPluPromotionGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPluPromotionGoods Initial()
        {
            RtPluPromotionGoods m = new RtPluPromotionGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.TotalLimitSale=0M;
			m.DayLimitSale=0M;
            return m;
        }
	}
	 
}


