/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:26
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_stock_account的实体类(商品帐务库存)
	///</summary>
	public class AcStockAccount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
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
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 库存金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存金额")]
		public virtual decimal StockMoney{get ; set; }
		
		/// <summary>
		/// 库存不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存不含税金额")]
		public virtual decimal NontaxStockMoney{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcStockAccount Clone()
        {
            return (AcStockAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcStockAccount Initial()
        {
            AcStockAccount m = new AcStockAccount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.StockQty=0M;
            return m;
        }
	}
	 
}


