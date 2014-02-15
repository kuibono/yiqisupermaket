/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:32
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_retail_pay的实体类(销售表_付款表)
	///</summary>
	public class RtRetailPay : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 销售单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="销售单号")]
		public virtual string RtNumber{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="销售时间")]
		public virtual System.DateTime? RtDate{get ; set; }
		
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
		[Validate(ValidateType.IsEmpty ,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// Pos机号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="Pos机号")]
		public virtual string Posid{get ; set; }
		
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
		
		/// <summary>
		/// 银行卡号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="银行卡号")]
		public virtual string BankcardNumber{get ; set; }
		
		/// <summary>
		/// 会员卡号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="会员卡号")]
		public virtual string CardNumber{get ; set; }
		
		/// <summary>
		/// 收银员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银员")]
		public virtual string Cashier{get ; set; }
		
		/// <summary>
		/// 营业员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="营业员")]
		public virtual string Salesman{get ; set; }
		
		/// <summary>
		/// 柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="柜台")]
		public virtual string UnderCounterCode{get ; set; }
		
		/// <summary>
		/// 班次时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="班次时间")]
		public virtual System.DateTime? ShiftDate{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtRetailPay Clone()
        {
            return (RtRetailPay)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtRetailPay Initial()
        {
            RtRetailPay m = new RtRetailPay();
            return m;
        }
	}
	 
}


