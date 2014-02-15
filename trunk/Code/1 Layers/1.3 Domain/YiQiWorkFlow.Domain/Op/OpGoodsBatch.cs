/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:31
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_goods_batch的实体类(商品库存批次表)
	///</summary>
	public class OpGoodsBatch : EntityBase, IAggregateRoot
	{
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
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
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
		/// 生产日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="生产日期")]
		public virtual System.DateTime? ProduceDate{get ; set; }
		
		/// <summary>
		/// 修改标志
		/// </summary>
		[Validate(ValidateType.IsNumber ,Name="修改标志",DefaultValue=0)]
		public virtual int IfModify{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpGoodsBatch Clone()
        {
            return (OpGoodsBatch)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpGoodsBatch Initial()
        {
            OpGoodsBatch m = new OpGoodsBatch();
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
			m.PurchaseQty=0M;
			m.StockoutQty=0M;
			m.StockQty=0M;
			m.IfModify=0;
            return m;
        }
	}
	 
}


