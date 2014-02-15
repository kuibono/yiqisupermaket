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
	///表op_dynamic_stock的实体类(商品实时库存)
	///</summary>
	public class OpDynamicStock : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 在途数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="在途数量",DefaultValue=0)]
		public virtual decimal OrderQty{get ; set; }
		
		/// <summary>
		/// 修改标志
		/// </summary>
		[Validate(ValidateType.IsNumber ,Name="修改标志",DefaultValue=0)]
		public virtual int IfModify{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpDynamicStock Clone()
        {
            return (OpDynamicStock)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpDynamicStock Initial()
        {
            OpDynamicStock m = new OpDynamicStock();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.StockQty=0M;
			m.OrderQty=0M;
			m.IfModify=0;
            return m;
        }
	}
	 
}


