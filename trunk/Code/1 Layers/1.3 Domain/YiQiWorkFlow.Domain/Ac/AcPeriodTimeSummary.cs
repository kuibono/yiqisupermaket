/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:26
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_period_time_summary的实体类(客流销售汇总)
	///</summary>
	public class AcPeriodTimeSummary : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售时间")]
		public virtual string RtDate{get ; set; }
		
		/// <summary>
		/// 时段
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="时段")]
		public virtual string PeriodTime{get ; set; }
		
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
		/// 客流量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="客流量")]
		public virtual decimal PassengerFlow{get ; set; }
		
		/// <summary>
		/// 平均客单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="平均客单价")]
		public virtual decimal AvgSalePrice{get ; set; }
		
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
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcPeriodTimeSummary Clone()
        {
            return (AcPeriodTimeSummary)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcPeriodTimeSummary Initial()
        {
            AcPeriodTimeSummary m = new AcPeriodTimeSummary();
            return m;
        }
	}
	 
}


