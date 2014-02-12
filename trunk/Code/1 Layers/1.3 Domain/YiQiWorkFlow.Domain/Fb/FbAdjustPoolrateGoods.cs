/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_adjust_poolrate_goods的实体类(调商品扣率_商品明细)
	///</summary>
	public class FbAdjustPoolrateGoods : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调整单号")]
		public virtual string AdjustNumber{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 原扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="原扣率")]
		public virtual decimal PoolRateOld{get ; set; }
		
		/// <summary>
		/// 扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="扣率")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbAdjustPoolrateGoods Clone()
        {
            return (FbAdjustPoolrateGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbAdjustPoolrateGoods Initial()
        {
            FbAdjustPoolrateGoods m = new FbAdjustPoolrateGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


