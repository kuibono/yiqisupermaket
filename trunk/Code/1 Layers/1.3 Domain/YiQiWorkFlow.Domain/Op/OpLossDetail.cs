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
	///表op_loss_detail的实体类(商品损溢_商品明细)
	///</summary>
	public class OpLossDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 损溢单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="损溢单号")]
		public virtual string LoNumber{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
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
		/// 含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="含税进价",DefaultValue=0)]
		public virtual decimal PurchasePrice{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 差异数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="差异数量")]
		public virtual decimal DifferQty{get ; set; }
		
		/// <summary>
		/// 含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税金额")]
		public virtual decimal PurchaseMoney{get ; set; }
		
		/// <summary>
		/// 不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税金额")]
		public virtual decimal NontaxPurchaseMoney{get ; set; }
		
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
		public OpLossDetail Clone()
        {
            return (OpLossDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpLossDetail Initial()
        {
            OpLossDetail m = new OpLossDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchasePrice=0M;
			m.SalePrice=0M;
			m.StockQty=0M;
            return m;
        }
	}
	 
}


