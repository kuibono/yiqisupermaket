/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:34
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ws
{
	///<summary>
	///表ws_wholesale_detail的实体类(批发销售_商品明细)
	///</summary>
	public class WsWholesaleDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 批发单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="批发单号")]
		public virtual string WsNumber{get ; set; }
		
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
		/// 整件数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="整件数量",DefaultValue=0)]
		public virtual decimal PackQty{get ; set; }
		
		/// <summary>
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数",DefaultValue=1)]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 单品数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="单品数量",DefaultValue=0)]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="批发价")]
		public virtual decimal TradePrice{get ; set; }
		
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
		/// 不含税售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税售价")]
		public virtual decimal NontaxSalePrice{get ; set; }
		
		/// <summary>
		/// 不含税销售
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税销售")]
		public virtual decimal NontaxSaleMoney{get ; set; }
		
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
		/// 销售状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售状态")]
		public virtual string SaleType{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public WsWholesaleDetail Clone()
        {
            return (WsWholesaleDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static WsWholesaleDetail Initial()
        {
            WsWholesaleDetail m = new WsWholesaleDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PackQty=0M;
			m.PackCoef=1M;
			m.SaleQty=0M;
            return m;
        }
	}
	 
}


