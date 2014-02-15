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
	///表op_check_stock的实体类(盘点库存)
	///</summary>
	public class OpCheckStock : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 盘点单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="盘点单号")]
		public virtual string CkNumber{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量",DefaultValue=0)]
		public virtual decimal StockQty{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpCheckStock Clone()
        {
            return (OpCheckStock)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpCheckStock Initial()
        {
            OpCheckStock m = new OpCheckStock();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.StockQty=0M;
            return m;
        }
	}
	 
}


