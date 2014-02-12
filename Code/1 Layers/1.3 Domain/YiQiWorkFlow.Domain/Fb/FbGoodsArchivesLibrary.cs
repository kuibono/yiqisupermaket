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
	///表fb_goods_archives_library的实体类(商品条码库)
	///</summary>
	public class FbGoodsArchivesLibrary : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 商品名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品名称")]
		public virtual string GoodsName{get ; set; }
		
		/// <summary>
		/// 商品简称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品简称")]
		public virtual string GoodsSubName{get ; set; }
		
		/// <summary>
		/// 产地
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="产地")]
		public virtual string ProducingArea{get ; set; }
		
		/// <summary>
		/// 规格
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="规格")]
		public virtual string Specification{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 从属类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="从属类型")]
		public virtual string OwnerType{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsArchivesLibrary Clone()
        {
            return (FbGoodsArchivesLibrary)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsArchivesLibrary Initial()
        {
            FbGoodsArchivesLibrary m = new FbGoodsArchivesLibrary();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


