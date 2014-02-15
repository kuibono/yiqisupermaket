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
	///表ac_day_goodsstock_journal_account的实体类(总部商品进销存日帐)
	///</summary>
	public class AcDayGoodsstockJournalAccount : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 记账日期
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="记账日期")]
		public virtual string AcDate{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
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
		/// 零售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="零售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 期初数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="期初数量")]
		public virtual decimal InitQty{get ; set; }
		
		/// <summary>
		/// 期初金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="期初金额")]
		public virtual decimal InitMoney{get ; set; }
		
		/// <summary>
		/// 期初售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="期初售价金额")]
		public virtual decimal InitSaleMoney{get ; set; }
		
		/// <summary>
		/// 进货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货数量")]
		public virtual decimal PurchaseQty{get ; set; }
		
		/// <summary>
		/// 进货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货金额")]
		public virtual decimal PurchaseMoney{get ; set; }
		
		/// <summary>
		/// 进货售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货售价金额")]
		public virtual decimal PurchaseSaleMoney{get ; set; }
		
		/// <summary>
		/// 返货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货数量")]
		public virtual decimal ReturnQty{get ; set; }
		
		/// <summary>
		/// 返货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货金额")]
		public virtual decimal ReturnMoney{get ; set; }
		
		/// <summary>
		/// 返货售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货售价金额")]
		public virtual decimal ReturnSaleMoney{get ; set; }
		
		/// <summary>
		/// 销售数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售数量")]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 销售不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售不含税金额")]
		public virtual decimal NontaxSaleMoney{get ; set; }
		
		/// <summary>
		/// 配送数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送数量")]
		public virtual decimal SupplyQty{get ; set; }
		
		/// <summary>
		/// 配送金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送金额")]
		public virtual decimal SupplyMoney{get ; set; }
		
		/// <summary>
		/// 配送售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送售价金额")]
		public virtual decimal SupplySaleMoney{get ; set; }
		
		/// <summary>
		/// 配返数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配返数量")]
		public virtual decimal SreturnQty{get ; set; }
		
		/// <summary>
		/// 配返金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配返金额")]
		public virtual decimal SreturnMoney{get ; set; }
		
		/// <summary>
		/// 配返售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配返售价金额")]
		public virtual decimal SreturnSaleMoney{get ; set; }
		
		/// <summary>
		/// 损溢数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢数量")]
		public virtual decimal LossQty{get ; set; }
		
		/// <summary>
		/// 损溢金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢金额")]
		public virtual decimal LossMoney{get ; set; }
		
		/// <summary>
		/// 损溢售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢售价金额")]
		public virtual decimal LossSaleMoney{get ; set; }
		
		/// <summary>
		/// 库存调整数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存调整数量")]
		public virtual decimal AdjustQty{get ; set; }
		
		/// <summary>
		/// 库存调整金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存调整金额")]
		public virtual decimal AdjustMoney{get ; set; }
		
		/// <summary>
		/// 库存售价调整金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存售价调整金额")]
		public virtual decimal AdjustSaleMoney{get ; set; }
		
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
		/// 库存售价调整
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存售价调整")]
		public virtual decimal AdjustsaleMoney{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量")]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 库存金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存金额")]
		public virtual decimal StockMoney{get ; set; }
		
		/// <summary>
		/// 库存售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存售价金额")]
		public virtual decimal StockSaleMoney{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcDayGoodsstockJournalAccount Clone()
        {
            return (AcDayGoodsstockJournalAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcDayGoodsstockJournalAccount Initial()
        {
            AcDayGoodsstockJournalAccount m = new AcDayGoodsstockJournalAccount();
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
            return m;
        }
	}
	 
}


