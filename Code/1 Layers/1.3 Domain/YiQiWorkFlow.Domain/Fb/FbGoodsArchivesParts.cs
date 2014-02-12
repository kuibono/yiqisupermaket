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
	///表fb_goods_archives_parts的实体类(商品部件)
	///</summary>
	public class FbGoodsArchivesParts : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 部件编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="部件编码")]
		public virtual string GoodsCodePart{get ; set; }
		
		/// <summary>
		/// 部件销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="部件销售码")]
		public virtual string GoodsBarCodePart{get ; set; }
		
		/// <summary>
		/// 部件名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="部件名称")]
		public virtual string GoodsBarName{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 部件数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="部件数量",DefaultValue=1)]
		public virtual decimal PartCoef{get ; set; }
		
		/// <summary>
		/// 是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否审核",DefaultValue="0")]
		public virtual string IfExamine{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsArchivesParts Clone()
        {
            return (FbGoodsArchivesParts)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsArchivesParts Initial()
        {
            FbGoodsArchivesParts m = new FbGoodsArchivesParts();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PartCoef=1M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


