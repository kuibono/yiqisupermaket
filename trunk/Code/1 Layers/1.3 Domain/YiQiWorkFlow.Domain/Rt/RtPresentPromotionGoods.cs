/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_present_promotion_goods的实体类(馈赠促销_商品明细)
	///</summary>
	public class RtPresentPromotionGoods : EntityGUIDBase, IAggregateRootGUID
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
		/// 销售数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售数量")]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 促销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="促销售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 送购商品销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="送购商品销售码")]
		public virtual string GoodsBarCodePresent{get ; set; }
		
		/// <summary>
		/// 送购商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="送购商品编码")]
		public virtual string GoodsCodePresent{get ; set; }
		
		/// <summary>
		/// 送购数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="送购数量")]
		public virtual decimal PresentQty{get ; set; }
		
		/// <summary>
		/// 送购金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="送购金额")]
		public virtual decimal PresentMoney{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPresentPromotionGoods Clone()
        {
            return (RtPresentPromotionGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPresentPromotionGoods Initial()
        {
            RtPresentPromotionGoods m = new RtPresentPromotionGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


