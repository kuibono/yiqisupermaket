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
	///表op_split_com_goods的实体类(组合拆零商品)
	///</summary>
	public class OpSplitComGoods : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 子商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="子商品编码")]
		public virtual string GoodsCodeChild{get ; set; }
		
		/// <summary>
		/// 商品数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="商品数量")]
		public virtual decimal GoodsQty{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpSplitComGoods Clone()
        {
            return (OpSplitComGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpSplitComGoods Initial()
        {
            OpSplitComGoods m = new OpSplitComGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


