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
	///表op_check_transfer的实体类(商品盘点接转单_商品汇总明细)
	///</summary>
	public class OpCheckTransfer : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
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
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数",DefaultValue=1)]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 整件数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="整件数量",DefaultValue=0)]
		public virtual decimal PackQty{get ; set; }
		
		/// <summary>
		/// 盘点数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="盘点数量",DefaultValue=0)]
		public virtual decimal CheckQty{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 差异数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="差异数量",DefaultValue=0)]
		public virtual decimal DifferQty{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpCheckTransfer Clone()
        {
            return (OpCheckTransfer)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpCheckTransfer Initial()
        {
            OpCheckTransfer m = new OpCheckTransfer();
			m.PurchasePrice=0M;
			m.SalePrice=0M;
			m.PackCoef=1M;
			m.PackQty=0M;
			m.CheckQty=0M;
			m.StockQty=0M;
			m.DifferQty=0M;
            return m;
        }
	}
	 
}


