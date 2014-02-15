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
	///表ac_counter_summary的实体类(柜组销售汇总)
	///</summary>
	public class AcCounterSummary : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售时间")]
		public virtual string RtDate{get ; set; }
		
		/// <summary>
		/// 柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="柜台")]
		public virtual string UnderCounterCode{get ; set; }
		
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
		public AcCounterSummary Clone()
        {
            return (AcCounterSummary)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcCounterSummary Initial()
        {
            AcCounterSummary m = new AcCounterSummary();
            return m;
        }
	}
	 
}


