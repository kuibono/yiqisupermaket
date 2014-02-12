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
	///表fb_goods_archives_bar的实体类(商品销售码)
	///</summary>
	public class FbGoodsArchivesBar : EntityGUIDBase, IAggregateRootGUID
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
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数",DefaultValue=1)]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 计量方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="计量方式",DefaultValue="1")]
		public virtual string QtyType{get ; set; }
		
		/// <summary>
		/// 计价方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="计价方式",DefaultValue="1")]
		public virtual string PriceType{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="会员价",DefaultValue=0)]
		public virtual decimal VipPrice{get ; set; }
		
		/// <summary>
		/// 批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="批发价",DefaultValue=0)]
		public virtual decimal TradePrice{get ; set; }
		
		/// <summary>
		/// 营业员提成
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="营业员提成",DefaultValue=0)]
		public virtual decimal PushRate{get ; set; }
		
		/// <summary>
		/// 是否主销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否主销售码",DefaultValue="1")]
		public virtual string IfMainBar{get ; set; }
		
		/// <summary>
		/// 是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否审核",DefaultValue="0")]
		public virtual string IfExamine{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsArchivesBar Clone()
        {
            return (FbGoodsArchivesBar)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsArchivesBar Initial()
        {
            FbGoodsArchivesBar m = new FbGoodsArchivesBar();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PackCoef=1M;
			m.QtyType="1";
			m.PriceType="1";
			m.SalePrice=0M;
			m.VipPrice=0M;
			m.TradePrice=0M;
			m.PushRate=0M;
			m.IfMainBar="1";
			m.IfExamine="0";
            return m;
        }
	}
	 
}


