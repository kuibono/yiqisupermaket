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
	///表op_dynamic_stock_wh的实体类(商品仓储实时库存)
	///</summary>
	public class OpDynamicStockWh : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpDynamicStockWh Clone()
        {
            return (OpDynamicStockWh)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpDynamicStockWh Initial()
        {
            OpDynamicStockWh m = new OpDynamicStockWh();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.StockQty=0M;
            return m;
        }
	}
	 
}


