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
	///表tg_group_balance_detail的实体类(团队结算明细)
	///</summary>
	public class TgGroupBalanceDetail : EntityGUIDBase, IAggregateRootGUID
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
		/// 结算项目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算项目")]
		public virtual string BaItems{get ; set; }
		
		/// <summary>
		/// 团队编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队编号")]
		public virtual string GroupNumber{get ; set; }
		
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员编号")]
		public virtual string GuideCode{get ; set; }
		
		/// <summary>
		/// 人员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员姓名")]
		public virtual string GuideName{get ; set; }
		
		/// <summary>
		/// 消费项目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="消费项目")]
		public virtual string GbCode{get ; set; }
		
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
		/// 结算状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算状态")]
		public virtual string BaState{get ; set; }
		
		/// <summary>
		/// 结算方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算方式")]
		public virtual string BaType{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算",DefaultValue="0")]
		public virtual string IfBalance{get ; set; }
		
		/// <summary>
		/// 是否打印
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印")]
		public virtual string IfPrint{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgGroupBalanceDetail Clone()
        {
            return (TgGroupBalanceDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgGroupBalanceDetail Initial()
        {
            TgGroupBalanceDetail m = new TgGroupBalanceDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PushRate=0M;
			m.IfBalance="0";
            return m;
        }
	}
	 
}


