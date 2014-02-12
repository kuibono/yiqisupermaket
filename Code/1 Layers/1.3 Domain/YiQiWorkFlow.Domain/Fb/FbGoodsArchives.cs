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
	///表fb_goods_archives的实体类(商品档案)
	///</summary>
	public class FbGoodsArchives : EntityGUIDBase, IAggregateRootGUID
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
		/// 商品类型
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品类型",DefaultValue="1")]
		public virtual string GoodsType{get ; set; }
		
		/// <summary>
		/// 核算方式
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="核算方式")]
		public virtual string CheckMode{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
		/// <summary>
		/// 扣率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="扣率")]
		public virtual decimal PoolRate{get ; set; }
		
		/// <summary>
		/// 商品名称
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品名称")]
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
		/// 1正常，2淘汰，3禁采销售，4禁采禁销，5废除
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="1正常，2淘汰，3禁采销售，4禁采禁销，5废除",DefaultValue="1")]
		public virtual string GoodsState{get ; set; }
		
		/// <summary>
		/// 产地
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="产地")]
		public virtual string ProducingArea{get ; set; }
		
		/// <summary>
		/// 货号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="货号")]
		public virtual string ArticleNumber{get ; set; }
		
		/// <summary>
		/// 规格
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="规格")]
		public virtual string Specification{get ; set; }
		
		/// <summary>
		/// 保质期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="保质期")]
		public virtual string ShelfLife{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 供货方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="供货方式")]
		public virtual string OfferMode{get ; set; }
		
		/// <summary>
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数",DefaultValue=1)]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 最小订量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="最小订量",DefaultValue=1)]
		public virtual decimal OfferMin{get ; set; }
		
		/// <summary>
		/// 进项税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进项税率",DefaultValue=0.17)]
		public virtual decimal InputTax{get ; set; }
		
		/// <summary>
		/// 销项税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销项税率",DefaultValue=0.17)]
		public virtual decimal OutputTax{get ; set; }
		
		/// <summary>
		/// 库存上限
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存上限",DefaultValue=0)]
		public virtual decimal StockUpperLimit{get ; set; }
		
		/// <summary>
		/// 库存下限
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存下限",DefaultValue=0)]
		public virtual decimal StockLowerLimit{get ; set; }
		
		/// <summary>
		/// 所属楼层
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属楼层")]
		public virtual string UnderFloorCode{get ; set; }
		
		/// <summary>
		/// 所属柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属柜台")]
		public virtual string UnderCounterCode{get ; set; }
		
		/// <summary>
		/// 核算单位
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="核算单位")]
		public virtual string CheckUnitCode{get ; set; }
		
		/// <summary>
		/// 含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="含税进价",DefaultValue=0)]
		public virtual decimal PurchasePrice{get ; set; }
		
		/// <summary>
		/// 不含税进价
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="不含税进价",DefaultValue=0)]
		public virtual decimal NontaxPurchasePrice{get ; set; }
		
		/// <summary>
		/// 平均成本
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="平均成本",DefaultValue=0)]
		public virtual decimal AvgCost{get ; set; }
		
		/// <summary>
		/// 不含税平均成本
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税平均成本",DefaultValue=0)]
		public virtual decimal NontaxAvgCost{get ; set; }
		
		/// <summary>
		/// 毛利率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="毛利率")]
		public virtual decimal GrossRate{get ; set; }
		
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
		/// 创建时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="创建时间")]
		public virtual System.DateTime? CreateDate{get ; set; }
		
		/// <summary>
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 审核人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="审核人")]
		public virtual string Assessor{get ; set; }
		
		/// <summary>
		/// 是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否审核",DefaultValue="0")]
		public virtual string IfExamine{get ; set; }
		
		/// <summary>
		/// 审核时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="审核时间")]
		public virtual System.DateTime? ExamineDate{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsArchives Clone()
        {
            return (FbGoodsArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsArchives Initial()
        {
            FbGoodsArchives m = new FbGoodsArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.GoodsType="1";
			m.GoodsState="1";
			m.PackCoef=1M;
			m.OfferMin=1M;
			m.InputTax=0.17M;
			m.OutputTax=0.17M;
			m.StockUpperLimit=0M;
			m.StockLowerLimit=0M;
			m.PurchasePrice=0M;
			m.NontaxPurchasePrice=0M;
			m.AvgCost=0M;
			m.NontaxAvgCost=0M;
			m.SalePrice=0M;
			m.VipPrice=0M;
			m.TradePrice=0M;
			m.PushRate=0M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


