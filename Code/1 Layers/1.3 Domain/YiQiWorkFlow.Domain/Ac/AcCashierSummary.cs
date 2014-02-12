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
	///表ac_cashier_summary的实体类(收银员销售汇总)
	///</summary>
	public class AcCashierSummary : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
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
		/// 收银员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银员")]
		public virtual string Cashier{get ; set; }
		
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
		/// 付款方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="付款方式")]
		public virtual string PaywayCode{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 汇率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="汇率")]
		public virtual decimal ExRate{get ; set; }
		
		/// <summary>
		/// 付款金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="付款金额")]
		public virtual decimal PayMoney{get ; set; }
		
		/// <summary>
		/// 收银损溢
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="收银损溢")]
		public virtual decimal PayLoss{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcCashierSummary Clone()
        {
            return (AcCashierSummary)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcCashierSummary Initial()
        {
            AcCashierSummary m = new AcCashierSummary();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}

