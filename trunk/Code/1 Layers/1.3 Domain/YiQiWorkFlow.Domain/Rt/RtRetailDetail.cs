/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_retail_detail的实体类(销售表_商品明细)
	///</summary>
	public class RtRetailDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水号")]
		public virtual decimal SaFlowNumber{get ; set; }
		
		/// <summary>
		/// 销售单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="销售单号")]
		public virtual string RtNumber{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="销售时间")]
		public virtual System.DateTime? RtDate{get ; set; }
		
		/// <summary>
		/// 销售方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售方式")]
		public virtual string RtType{get ; set; }
		
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
		/// Pos机号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="Pos机号")]
		public virtual string Posid{get ; set; }
		
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
		/// 原销售单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原销售单价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 销售单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售单价")]
		public virtual decimal RealPrice{get ; set; }
		
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
		/// 单品数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="单品数量")]
		public virtual decimal PurchaseQty{get ; set; }
		
		/// <summary>
		/// 单品单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="单品单价")]
		public virtual decimal pSalePrice{get ; set; }
		
		/// <summary>
		/// 单品金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="单品金额")]
		public virtual decimal pSaleMoney{get ; set; }
		
		/// <summary>
		/// 单品折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="单品折扣")]
		public virtual decimal pDiscountMoney{get ; set; }
		
		/// <summary>
		/// 收银员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银员")]
		public virtual string Cashier{get ; set; }
		
		/// <summary>
		/// 营业员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="营业员")]
		public virtual string Salesman{get ; set; }
		
		/// <summary>
		/// 柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="柜台")]
		public virtual string UnderCounterCode{get ; set; }
		
		/// <summary>
		/// 促销扣率 
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="促销扣率 ")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 班次时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="班次时间")]
		public virtual System.DateTime? ShiftDate{get ; set; }
		
		/// <summary>
		/// 是否促销
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否促销")]
		public virtual string IfPromotion{get ; set; }
		
		/// <summary>
		/// 从属类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="从属类型")]
		public virtual string OwnerType{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtRetailDetail Clone()
        {
            return (RtRetailDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtRetailDetail Initial()
        {
            RtRetailDetail m = new RtRetailDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


