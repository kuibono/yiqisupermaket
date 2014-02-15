/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:31
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Pc
{
	///<summary>
	///表pc_putout_detail的实体类(商品出库单_商品明细)
	///</summary>
	public class PcPutoutDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 出库单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="出库单号")]
		public virtual string PoNumber{get ; set; }
		
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
		public virtual decimal ReturnQty{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="含税进价",DefaultValue=0)]
		public virtual decimal PurchasePrice{get ; set; }
		
		/// <summary>
		/// 不含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="不含税进价",DefaultValue=0)]
		public virtual decimal NontaxPurchasePrice{get ; set; }
		
		/// <summary>
		/// 含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税金额",DefaultValue=0)]
		public virtual decimal ReturnMoney{get ; set; }
		
		/// <summary>
		/// 不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税金额",DefaultValue=0)]
		public virtual decimal NontaxReturnMoney{get ; set; }
		
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
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public PcPutoutDetail Clone()
        {
            return (PcPutoutDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static PcPutoutDetail Initial()
        {
            PcPutoutDetail m = new PcPutoutDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PackQty=0M;
			m.PackCoef=1M;
			m.ReturnQty=0M;
			m.SalePrice=0M;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
			m.ReturnMoney=0M;
			m.NontaxReturnMoney=0M;
            return m;
        }
	}
	 
}


