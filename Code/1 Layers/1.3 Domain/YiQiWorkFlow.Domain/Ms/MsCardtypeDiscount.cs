/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_cardtype_discount的实体类(卡折扣)
	///</summary>
	public class MsCardtypeDiscount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
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
		/// 折扣基数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="折扣基数")]
		public virtual decimal DiscountBase{get ; set; }
		
		/// <summary>
		/// 类别折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="类别折扣")]
		public virtual decimal ClassDiscountRate{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsCardtypeDiscount Clone()
        {
            return (MsCardtypeDiscount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsCardtypeDiscount Initial()
        {
            MsCardtypeDiscount m = new MsCardtypeDiscount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


