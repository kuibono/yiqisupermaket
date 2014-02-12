/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_month_goods_journal_account的实体类(商品进销存月帐)
	///</summary>
	public class AcMonthGoodsJournalAccount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal AcFlowNumber{get ; set; }
		
		/// <summary>
		/// 记账月份
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="记账月份")]
		public virtual string AcMonth{get ; set; }
		
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
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcMonthGoodsJournalAccount Clone()
        {
            return (AcMonthGoodsJournalAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcMonthGoodsJournalAccount Initial()
        {
            AcMonthGoodsJournalAccount m = new AcMonthGoodsJournalAccount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
            return m;
        }
	}
	 
}


