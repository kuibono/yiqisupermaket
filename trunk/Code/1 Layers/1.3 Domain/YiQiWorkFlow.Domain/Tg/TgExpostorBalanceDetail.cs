/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tg
{
	///<summary>
	///表tg_expostor_balance_detail的实体类(讲解员结算明细)
	///</summary>
	public class TgExpostorBalanceDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 团队编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队编号")]
		public virtual string GroupNumber{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 团购日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="团购日期")]
		public virtual System.DateTime? SaleDate{get ; set; }
		
		/// <summary>
		/// 团队购物金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="团队购物金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 提成比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成比率",DefaultValue=0)]
		public virtual decimal PushRate{get ; set; }
		
		/// <summary>
		/// 提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成金额")]
		public virtual decimal PushMoney{get ; set; }
		
		/// <summary>
		/// 人次提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="人次提成金额")]
		public virtual decimal PtimesMoney{get ; set; }
		
		/// <summary>
		/// 提成总额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成总额")]
		public virtual decimal TotalPushMoney{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgExpostorBalanceDetail Clone()
        {
            return (TgExpostorBalanceDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgExpostorBalanceDetail Initial()
        {
            TgExpostorBalanceDetail m = new TgExpostorBalanceDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PushRate=0M;
            return m;
        }
	}
	 
}


