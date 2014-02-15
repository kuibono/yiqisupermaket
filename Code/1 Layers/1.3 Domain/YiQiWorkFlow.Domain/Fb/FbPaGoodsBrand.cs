/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_pa_goods_brand的实体类(品牌编码)
	///</summary>
	public class FbPaGoodsBrand : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 品牌编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="品牌编码")]
		public virtual string BrandCode{get ; set; }
		
		/// <summary>
		/// 品牌名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="品牌名称")]
		public virtual string BrandName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaGoodsBrand Clone()
        {
            return (FbPaGoodsBrand)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaGoodsBrand Initial()
        {
            FbPaGoodsBrand m = new FbPaGoodsBrand();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


