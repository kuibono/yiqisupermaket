/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:26
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_goodssale_account的实体类(商品销售帐表)
	///</summary>
	public class AcGoodssaleAccount : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="销售时间")]
		public virtual string RtDate{get ; set; }
		
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
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="数量")]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="折扣金额")]
		public virtual decimal DiscountMoney{get ; set; }
		
		/// <summary>
		/// 不含税销售
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税销售")]
		public virtual decimal NontaxSaleMoney{get ; set; }
		
		/// <summary>
		/// 含税进价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税进价",DefaultValue=0)]
		public virtual decimal PurchasePrice{get ; set; }
		
		/// <summary>
		/// 不含税进价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税进价",DefaultValue=0)]
		public virtual decimal NontaxPurchasePrice{get ; set; }
		
		/// <summary>
		/// 含税成本
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税成本")]
		public virtual decimal CostMoney{get ; set; }
		
		/// <summary>
		/// 不含税成本
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税成本")]
		public virtual decimal NontaxCostMoney{get ; set; }
		
		/// <summary>
		/// 含税毛利
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税毛利")]
		public virtual decimal GrossMoney{get ; set; }
		
		/// <summary>
		/// 不含税毛利
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税毛利")]
		public virtual decimal NontaxGrossMoney{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="扣率")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 销项税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销项税率",DefaultValue=0.17)]
		public virtual decimal OutputTax{get ; set; }
		
		/// <summary>
		/// 是否促销
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否促销")]
		public virtual string IfPromotion{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcGoodssaleAccount Clone()
        {
            return (AcGoodssaleAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcGoodssaleAccount Initial()
        {
            AcGoodssaleAccount m = new AcGoodssaleAccount();
			m.SalePrice=0M;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
			m.OutputTax=0.17M;
            return m;
        }
	}
	 
}


