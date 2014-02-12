/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_split_com_detail的实体类(组合拆零管理_商品明细)
	///</summary>
	public class OpSplitComDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 处理单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="处理单号")]
		public virtual string ScNumber{get ; set; }
		
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
		/// 规格
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="规格")]
		public virtual string Specification{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 处理数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="处理数量")]
		public virtual decimal PurchaseQty{get ; set; }
		
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
		
		/// <summary>
		/// 含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税金额",DefaultValue=0)]
		public virtual decimal PurchaseMoney{get ; set; }
		
		/// <summary>
		/// 不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税金额",DefaultValue=0)]
		public virtual decimal NontaxPurchaseMoney{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="售价金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 不含税售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税售价金额")]
		public virtual decimal NontaxSaleMoney{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpSplitComDetail Clone()
        {
            return (OpSplitComDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpSplitComDetail Initial()
        {
            OpSplitComDetail m = new OpSplitComDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
			m.PurchaseMoney=0M;
			m.NontaxPurchaseMoney=0M;
            return m;
        }
	}
	 
}


