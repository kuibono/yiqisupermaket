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
	///表ac_day_branchclass_journal_account的实体类(分店类别进销存)
	///</summary>
	public class AcDayBranchclassJournalAccount : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 记账日期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="记账日期")]
		public virtual string AcDate{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 商品类别
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品类别")]
		public virtual string GoodsClassCode{get ; set; }
		
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
		/// 期初不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="期初不含税金额")]
		public virtual decimal NontaxInitMoney{get ; set; }
		
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
		/// 进货不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货不含税金额")]
		public virtual decimal NontaxPurchaseMoney{get ; set; }
		
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
		/// 返货不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货不含税金额")]
		public virtual decimal NontaxReturnMoney{get ; set; }
		
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
		/// 配送不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送不含税金额")]
		public virtual decimal NontaxSupplyMoney{get ; set; }
		
		/// <summary>
		/// 配返数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配返数量")]
		public virtual decimal SpReturnQty{get ; set; }
		
		/// <summary>
		/// 配返金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配返金额")]
		public virtual decimal SpReturnMoney{get ; set; }
		
		/// <summary>
		/// 配返不含税进入
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配返不含税进入")]
		public virtual decimal NontaxSpReturnMoney{get ; set; }
		
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
		/// 调入数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调入数量")]
		public virtual decimal AlinQty{get ; set; }
		
		/// <summary>
		/// 调入金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调入金额")]
		public virtual decimal AlinMoney{get ; set; }
		
		/// <summary>
		/// 调入不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调入不含税金额")]
		public virtual decimal NontaxAlinMoney{get ; set; }
		
		/// <summary>
		/// 调出数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调出数量")]
		public virtual decimal AloutQty{get ; set; }
		
		/// <summary>
		/// 调出金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调出金额")]
		public virtual decimal AloutMoney{get ; set; }
		
		/// <summary>
		/// 调出不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调出不含税金额")]
		public virtual decimal NontaxAloutMoney{get ; set; }
		
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
		/// 损溢不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢不含税金额")]
		public virtual decimal NontaxLossMoney{get ; set; }
		
		/// <summary>
		/// 库存调整金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存调整金额")]
		public virtual decimal AdjustMoney{get ; set; }
		
		/// <summary>
		/// 库存调整不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存调整不含税金额")]
		public virtual decimal NontaxAdjustMoney{get ; set; }
		
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
		/// 库存不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存不含税金额")]
		public virtual decimal NontaxStockMoney{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcDayBranchclassJournalAccount Clone()
        {
            return (AcDayBranchclassJournalAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcDayBranchclassJournalAccount Initial()
        {
            AcDayBranchclassJournalAccount m = new AcDayBranchclassJournalAccount();
            return m;
        }
	}
	 
}


