/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:30
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_adjust_purchase_detail的实体类(进货成本调整_批次明细)
	///</summary>
	public class OpAdjustPurchaseDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="调整单号")]
		public virtual string AdjustNumber{get ; set; }
		
		/// <summary>
		/// 调整日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="调整日期")]
		public virtual System.DateTime? AdjustDate{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 批次编号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="批次编号")]
		public virtual decimal BatchNumber{get ; set; }
		
		/// <summary>
		/// 入库单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="入库单号")]
		public virtual string PiNumber{get ; set; }
		
		/// <summary>
		/// 入库日期
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDateTime ,Name="入库日期")]
		public virtual System.DateTime PutinDate{get ; set; }
		
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
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
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
		[Validate(ValidateType.IsDecimal ,Name="不含税进价",DefaultValue=0)]
		public virtual decimal NontaxPurchasePrice{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 不含税售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税售价")]
		public virtual decimal NontaxSalePrice{get ; set; }
		
		/// <summary>
		/// 进货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货数量",DefaultValue=0)]
		public virtual decimal PurchaseQty{get ; set; }
		
		/// <summary>
		/// 冲减数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="冲减数量",DefaultValue=0)]
		public virtual decimal StockoutQty{get ; set; }
		
		/// <summary>
		/// 剩余数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="剩余数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 调整数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整数量")]
		public virtual decimal AdjustQty{get ; set; }
		
		/// <summary>
		/// 调整进价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整进价")]
		public virtual decimal AdjustPrice{get ; set; }
		
		/// <summary>
		/// 调整差价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整差价")]
		public virtual decimal AdjustDiff{get ; set; }
		
		/// <summary>
		/// 调整金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整金额")]
		public virtual decimal AdjustMoney{get ; set; }
		
		/// <summary>
		/// 是否允许结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否允许结算",DefaultValue="0")]
		public virtual string IfAblebalance{get ; set; }
		
		/// <summary>
		/// 调整结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整结算金额")]
		public virtual decimal AdjustBaMoney{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算")]
		public virtual string IfBalance{get ; set; }
		
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算金额")]
		public virtual decimal BaMoney{get ; set; }
		
		/// <summary>
		/// 生产日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="生产日期")]
		public virtual System.DateTime? ProduceDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpAdjustPurchaseDetail Clone()
        {
            return (OpAdjustPurchaseDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpAdjustPurchaseDetail Initial()
        {
            OpAdjustPurchaseDetail m = new OpAdjustPurchaseDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
			m.PurchaseQty=0M;
			m.StockoutQty=0M;
			m.StockQty=0M;
			m.IfAblebalance="0";
            return m;
        }
	}
	 
}


