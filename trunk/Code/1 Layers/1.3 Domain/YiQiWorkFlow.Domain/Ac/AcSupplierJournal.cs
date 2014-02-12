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
	///表ac_supplier_journal的实体类(供货商流水帐)
	///</summary>
	public class AcSupplierJournal : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal SupFlowNumber{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 业务日期
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="业务日期")]
		public virtual string AcDate{get ; set; }
		
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
		/// 进货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货数量",DefaultValue=0)]
		public virtual decimal PurchaseQty{get ; set; }
		
		/// <summary>
		/// 进货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货金额",DefaultValue=0)]
		public virtual decimal PurchaseMoney{get ; set; }
		
		/// <summary>
		/// 进货不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进货不含税金额",DefaultValue=0)]
		public virtual decimal NontaxPurchaseMoney{get ; set; }
		
		/// <summary>
		/// 返货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货数量",DefaultValue=0)]
		public virtual decimal ReturnQty{get ; set; }
		
		/// <summary>
		/// 返货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货金额",DefaultValue=0)]
		public virtual decimal ReturnMoney{get ; set; }
		
		/// <summary>
		/// 返货不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货不含税金额",DefaultValue=0)]
		public virtual decimal NontaxReturnMoney{get ; set; }
		
		/// <summary>
		/// 销售数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售数量",DefaultValue=0)]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额",DefaultValue=0)]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 销售不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售不含税金额",DefaultValue=0)]
		public virtual decimal NontaxSaleMoney{get ; set; }
		
		/// <summary>
		/// 调入数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调入数量",DefaultValue=0)]
		public virtual decimal AlinQty{get ; set; }
		
		/// <summary>
		/// 调入金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调入金额",DefaultValue=0)]
		public virtual decimal AlinMoney{get ; set; }
		
		/// <summary>
		/// 调入不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调入不含税金额",DefaultValue=0)]
		public virtual decimal NontaxAlinMoney{get ; set; }
		
		/// <summary>
		/// 调出数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调出数量",DefaultValue=0)]
		public virtual decimal AloutQty{get ; set; }
		
		/// <summary>
		/// 调出金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调出金额",DefaultValue=0)]
		public virtual decimal AloutMoney{get ; set; }
		
		/// <summary>
		/// 调出不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调出不含税金额",DefaultValue=0)]
		public virtual decimal NontaxAloutMoney{get ; set; }
		
		/// <summary>
		/// 损溢数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢数量",DefaultValue=0)]
		public virtual decimal LossQty{get ; set; }
		
		/// <summary>
		/// 损溢金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢金额",DefaultValue=0)]
		public virtual decimal LossMoney{get ; set; }
		
		/// <summary>
		/// 损溢不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="损溢不含税金额",DefaultValue=0)]
		public virtual decimal NontaxLossMoney{get ; set; }
		
		/// <summary>
		/// 含税毛利
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税毛利",DefaultValue=0)]
		public virtual decimal GrossMoney{get ; set; }
		
		/// <summary>
		/// 不含税毛利
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税毛利",DefaultValue=0)]
		public virtual decimal NontaxGrossMoney{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcSupplierJournal Clone()
        {
            return (AcSupplierJournal)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcSupplierJournal Initial()
        {
            AcSupplierJournal m = new AcSupplierJournal();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchaseQty=0M;
			m.PurchaseMoney=0M;
			m.NontaxPurchaseMoney=0M;
			m.ReturnQty=0M;
			m.ReturnMoney=0M;
			m.NontaxReturnMoney=0M;
			m.SaleQty=0M;
			m.SaleMoney=0M;
			m.NontaxSaleMoney=0M;
			m.AlinQty=0M;
			m.AlinMoney=0M;
			m.NontaxAlinMoney=0M;
			m.AloutQty=0M;
			m.AloutMoney=0M;
			m.NontaxAloutMoney=0M;
			m.LossQty=0M;
			m.LossMoney=0M;
			m.NontaxLossMoney=0M;
			m.GrossMoney=0M;
			m.NontaxGrossMoney=0M;
            return m;
        }
	}
	 
}


