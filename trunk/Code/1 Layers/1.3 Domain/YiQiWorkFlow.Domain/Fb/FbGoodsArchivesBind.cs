/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:28
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_goods_archives_bind的实体类(商品捆绑)
	///</summary>
	public class FbGoodsArchivesBind : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 捆绑商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="捆绑商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 捆绑商品销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="捆绑商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品编码")]
		public virtual string GoodsCodeBind{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品销售码")]
		public virtual string GoodsBarCodeBind{get ; set; }
		
		/// <summary>
		/// 销售名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售名称")]
		public virtual string GoodsBarName{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 捆绑系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="捆绑系数",DefaultValue=1)]
		public virtual decimal BindCoef{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 捆绑销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="捆绑销售价",DefaultValue=0)]
		public virtual decimal BindSalePrice{get ; set; }
		
		/// <summary>
		/// 是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否审核",DefaultValue="0")]
		public virtual string IfExamine{get ; set; }
		
		/// <summary>
		/// 捆绑商品销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="捆绑商品销售价")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsArchivesBind Clone()
        {
            return (FbGoodsArchivesBind)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsArchivesBind Initial()
        {
            FbGoodsArchivesBind m = new FbGoodsArchivesBind();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.BindCoef=1M;
			m.SalePrice=0M;
			m.BindSalePrice=0M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


