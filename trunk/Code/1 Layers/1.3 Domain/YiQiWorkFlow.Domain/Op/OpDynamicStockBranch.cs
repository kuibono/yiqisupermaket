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
	///表op_dynamic_stock_branch的实体类(商品分店实时库存)
	///</summary>
	public class OpDynamicStockBranch : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpDynamicStockBranch Clone()
        {
            return (OpDynamicStockBranch)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpDynamicStockBranch Initial()
        {
            OpDynamicStockBranch m = new OpDynamicStockBranch();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.StockQty=0M;
            return m;
        }
	}
	 
}


