/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_salesman_summary的实体类(营业员销售汇总)
	///</summary>
	public class AcSalesmanSummary : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水号")]
		public virtual decimal RtFlowNumber{get ; set; }
		
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售时间")]
		public virtual string RtDate{get ; set; }
		
		/// <summary>
		/// 营业员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="营业员")]
		public virtual string Salesman{get ; set; }
		
		/// <summary>
		/// 销售方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售方式")]
		public virtual string RtType{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
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
		/// 数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="数量")]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 营业员提成
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="营业员提成",DefaultValue=0)]
		public virtual decimal PushRate{get ; set; }
		
		/// <summary>
		/// 提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成金额")]
		public virtual decimal PushMoney{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcSalesmanSummary Clone()
        {
            return (AcSalesmanSummary)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcSalesmanSummary Initial()
        {
            AcSalesmanSummary m = new AcSalesmanSummary();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PushRate=0M;
            return m;
        }
	}
	 
}


