/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_pa_goods_pack_unit的实体类(包装单位编码)
	///</summary>
	public class FbPaGoodsPackUnit : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 包装单位编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位编码")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 包装单位名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位名称")]
		public virtual string PackUnitName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaGoodsPackUnit Clone()
        {
            return (FbPaGoodsPackUnit)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaGoodsPackUnit Initial()
        {
            FbPaGoodsPackUnit m = new FbPaGoodsPackUnit();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


