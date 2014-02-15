/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_supply_detail的实体类(分店订货配送单_明细)
	///</summary>
	public class BsSupplyDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 配送单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="配送单号")]
		public virtual string SpNumber{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 配送状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配送状态")]
		public virtual string SpState{get ; set; }
		
		/// <summary>
		/// 总部仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="总部仓库")]
		public virtual string WhCodeOut{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
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
		/// 整件订货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="整件订货数量",DefaultValue=0)]
		public virtual decimal PurchasePackQty{get ; set; }
		
		/// <summary>
		/// 整件配送数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="整件配送数量",DefaultValue=0)]
		public virtual decimal SupplyPackQty{get ; set; }
		
		/// <summary>
		/// 整件实收数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="整件实收数量",DefaultValue=0)]
		public virtual decimal PutinPackQty{get ; set; }
		
		/// <summary>
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数",DefaultValue=1)]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 订货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="订货数量",DefaultValue=0)]
		public virtual decimal PurchaseQty{get ; set; }
		
		/// <summary>
		/// 配送数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送数量",DefaultValue=0)]
		public virtual decimal SupplyQty{get ; set; }
		
		/// <summary>
		/// 实收数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="实收数量",DefaultValue=0)]
		public virtual decimal PutinQty{get ; set; }
		
		/// <summary>
		/// 配送单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送单价",DefaultValue=0)]
		public virtual decimal SupplyPrice{get ; set; }
		
		/// <summary>
		/// 配送金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送金额",DefaultValue=0)]
		public virtual decimal SupplyMoney{get ; set; }
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="折扣金额")]
		public virtual decimal DiscountMoney{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsSupplyDetail Clone()
        {
            return (BsSupplyDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsSupplyDetail Initial()
        {
            BsSupplyDetail m = new BsSupplyDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PurchasePackQty=0M;
			m.SupplyPackQty=0M;
			m.PutinPackQty=0M;
			m.PackCoef=1M;
			m.PurchaseQty=0M;
			m.SupplyQty=0M;
			m.PutinQty=0M;
			m.SupplyPrice=0M;
			m.SupplyMoney=0M;
            return m;
        }
	}
	 
}


