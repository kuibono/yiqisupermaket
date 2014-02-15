/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tg
{
	///<summary>
	///表tg_travel_balance_detail的实体类(旅行社结算明细)
	///</summary>
	public class TgTravelBalanceDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 未结算单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="未结算单号")]
		public virtual string BaNopayNumber{get ; set; }
		
		/// <summary>
		/// 团队编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队编号")]
		public virtual string GroupNumber{get ; set; }
		
		/// <summary>
		/// 团购日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="团购日期")]
		public virtual System.DateTime? SaleDate{get ; set; }
		
		/// <summary>
		/// 结算项目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算项目")]
		public virtual string BaItems{get ; set; }
		
		/// <summary>
		/// 消费项目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="消费项目")]
		public virtual string GbCode{get ; set; }
		
		/// <summary>
		/// 导游编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="导游编号")]
		public virtual string GuideCode{get ; set; }
		
		/// <summary>
		/// 团队购物金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="团队购物金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成金额")]
		public virtual decimal PushMoney{get ; set; }
		
		/// <summary>
		/// 奖励金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="奖励金额")]
		public virtual decimal AdjustMoney{get ; set; }
		
		/// <summary>
		/// 提成总额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成总额")]
		public virtual decimal TotalPushMoney{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgTravelBalanceDetail Clone()
        {
            return (TgTravelBalanceDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgTravelBalanceDetail Initial()
        {
            TgTravelBalanceDetail m = new TgTravelBalanceDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


