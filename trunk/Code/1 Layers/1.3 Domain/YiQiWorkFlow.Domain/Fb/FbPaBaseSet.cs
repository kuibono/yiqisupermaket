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
	///表fb_pa_base_set的实体类(基础参数设置)
	///</summary>
	public class FbPaBaseSet : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 大类位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="大类位数")]
		public virtual decimal GoodsGbLen{get ; set; }
		
		/// <summary>
		/// 中类位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="中类位数")]
		public virtual decimal GoodsGmLen{get ; set; }
		
		/// <summary>
		/// 小类位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="小类位数")]
		public virtual decimal GoodsGsLen{get ; set; }
		
		/// <summary>
		/// 细类位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="细类位数")]
		public virtual decimal GoodsGlLen{get ; set; }
		
		/// <summary>
		/// 1，2，3，4
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="1，2，3，4",DefaultValue=2)]
		public virtual decimal GoodsClassLevel{get ; set; }
		
		/// <summary>
		/// 商品流水码位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="商品流水码位数",DefaultValue=4)]
		public virtual decimal GoodsLen{get ; set; }
		
		/// <summary>
		/// 大中小细
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="大中小细",DefaultValue="中类")]
		public virtual string GoodsPrefix{get ; set; }
		
		/// <summary>
		/// 供货商流水码位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="供货商流水码位数",DefaultValue=6)]
		public virtual decimal SupLen{get ; set; }
		
		/// <summary>
		/// 无，经营方式，指定
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="无，经营方式，指定",DefaultValue="无")]
		public virtual string SupPrefixType{get ; set; }
		
		/// <summary>
		/// 前缀内容
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="前缀内容")]
		public virtual string SupPrefixContent{get ; set; }
		
		/// <summary>
		/// 进价小数位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进价小数位数",DefaultValue=2)]
		public virtual decimal PurchasePreciseLen{get ; set; }
		
		/// <summary>
		/// 销售价小数位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价小数位数",DefaultValue=2)]
		public virtual decimal SalePreciseLen{get ; set; }
		
		/// <summary>
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaBaseSet Clone()
        {
            return (FbPaBaseSet)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaBaseSet Initial()
        {
            FbPaBaseSet m = new FbPaBaseSet();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.GoodsClassLevel=2M;
			m.GoodsLen=4M;
			m.GoodsPrefix="中类";
			m.SupLen=6M;
			m.SupPrefixType="无";
			m.PurchasePreciseLen=2M;
			m.SalePreciseLen=2M;
            return m;
        }
	}
	 
}


