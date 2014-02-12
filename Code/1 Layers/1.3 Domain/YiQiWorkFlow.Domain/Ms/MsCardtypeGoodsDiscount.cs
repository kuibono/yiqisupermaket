/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_cardtype_goods_discount的实体类(商品折扣)
	///</summary>
	public class MsCardtypeGoodsDiscount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品名称")]
		public virtual string GoodsName{get ; set; }
		
		/// <summary>
		/// 折扣基数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="折扣基数")]
		public virtual decimal DiscountBase{get ; set; }
		
		/// <summary>
		/// 商品折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="商品折扣")]
		public virtual decimal GoodsDiscountRate{get ; set; }
		
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
		public MsCardtypeGoodsDiscount Clone()
        {
            return (MsCardtypeGoodsDiscount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsCardtypeGoodsDiscount Initial()
        {
            MsCardtypeGoodsDiscount m = new MsCardtypeGoodsDiscount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


