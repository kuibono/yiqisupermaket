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
	///表fb_adjust_supplier_goods的实体类(调商品供货商_商品明细)
	///</summary>
	public class FbAdjustSupplierGoods : EntityGUIDBase, IAggregateRootGUID
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
		/// 原供货商编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原供货商编码")]
		public virtual string SupCodeOld{get ; set; }
		
		/// <summary>
		/// 原经营方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原经营方式")]
		public virtual string OpCodeOld{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 供货商名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货商名称")]
		public virtual string SupName{get ; set; }
		
		/// <summary>
		/// 拼音码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="拼音码")]
		public virtual string PyCode{get ; set; }
		
		/// <summary>
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
		/// <summary>
		/// 扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="扣率")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 供货方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货方式")]
		public virtual string OfferMode{get ; set; }
		
		/// <summary>
		/// 最小订量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="最小订量",DefaultValue=1)]
		public virtual decimal OfferMin{get ; set; }
		
		/// <summary>
		/// 进项税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进项税率")]
		public virtual decimal InputTax{get ; set; }
		
		/// <summary>
		/// 含税进价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税进价",DefaultValue=0)]
		public virtual decimal PurchasePrice{get ; set; }
		
		/// <summary>
		/// 不含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="不含税进价")]
		public virtual decimal NontaxPurchasePrice{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbAdjustSupplierGoods Clone()
        {
            return (FbAdjustSupplierGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbAdjustSupplierGoods Initial()
        {
            FbAdjustSupplierGoods m = new FbAdjustSupplierGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.OfferMin=1M;
			m.PurchasePrice=0M;
            return m;
        }
	}
	 
}


