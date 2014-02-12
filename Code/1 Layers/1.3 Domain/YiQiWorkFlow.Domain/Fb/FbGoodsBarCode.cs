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
	///表fb_goods_bar_code的实体类(销售编码表)
	///</summary>
	public class FbGoodsBarCode : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 商品简码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品简码")]
		public virtual string GoodsSubCode{get ; set; }
		
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
		/// 拼音码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="拼音码")]
		public virtual string PyCode{get ; set; }
		
		/// <summary>
		/// 大类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="大类")]
		public virtual string GbCode{get ; set; }
		
		/// <summary>
		/// 中类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="中类")]
		public virtual string GmCode{get ; set; }
		
		/// <summary>
		/// 小类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="小类")]
		public virtual string GsCode{get ; set; }
		
		/// <summary>
		/// 细类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="细类")]
		public virtual string GlCode{get ; set; }
		
		/// <summary>
		/// 从属类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="从属类型")]
		public virtual string OwnerType{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
		/// <summary>
		/// 扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="扣率")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数")]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 计重，计数
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="计重，计数")]
		public virtual string QtyType{get ; set; }
		
		/// <summary>
		/// 档案价，自定义价格
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="档案价，自定义价格")]
		public virtual string PriceType{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="会员价")]
		public virtual decimal VipPrice{get ; set; }
		
		/// <summary>
		/// 批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="批发价")]
		public virtual decimal TradePrice{get ; set; }
		
		/// <summary>
		/// 正常，淘汰，禁采销售，禁采禁销
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="正常，淘汰，禁采销售，禁采禁销")]
		public virtual string GoodsState{get ; set; }
		
		/// <summary>
		/// 修改时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="修改时间")]
		public virtual System.DateTime? ModifyDate{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsBarCode Clone()
        {
            return (FbGoodsBarCode)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsBarCode Initial()
        {
            FbGoodsBarCode m = new FbGoodsBarCode();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


