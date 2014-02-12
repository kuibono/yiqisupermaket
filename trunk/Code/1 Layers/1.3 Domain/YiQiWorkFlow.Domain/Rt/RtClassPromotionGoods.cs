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
	///表rt_class_promotion_goods的实体类(类别促销_商品明细)
	///</summary>
	public class RtClassPromotionGoods : EntityGUIDBase, IAggregateRootGUID
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
		/// 商品类别
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品类别")]
		public virtual string GoodsClassCode{get ; set; }
		
		/// <summary>
		/// 类别名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="类别名称")]
		public virtual string GoodsClassName{get ; set; }
		
		/// <summary>
		/// 销售折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售折扣")]
		public virtual decimal SaleDiscountRate{get ; set; }
		
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
		public RtClassPromotionGoods Clone()
        {
            return (RtClassPromotionGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtClassPromotionGoods Initial()
        {
            RtClassPromotionGoods m = new RtClassPromotionGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


