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
	///表tg_group_balance的实体类(团队结算管理)
	///</summary>
	public class TgGroupBalance : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 结算日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="结算日期")]
		public virtual System.DateTime? BaDate{get ; set; }
		
		/// <summary>
		/// 付款方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="付款方式")]
		public virtual string PaywayCode{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 开始日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="开始日期")]
		public virtual System.DateTime? BeginDate{get ; set; }
		
		/// <summary>
		/// 终止日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="终止日期")]
		public virtual System.DateTime? EndDate{get ; set; }
		
		/// <summary>
		/// 团队编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队编号")]
		public virtual string GroupNumber{get ; set; }
		
		/// <summary>
		/// 所属旅行社
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属旅行社")]
		public virtual string TaCode{get ; set; }
		
		/// <summary>
		/// 团队人数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="团队人数")]
		public virtual decimal PersonTimes{get ; set; }
		
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
		/// 旅行社返利金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="旅行社返利金额")]
		public virtual decimal TaReturnsMoney{get ; set; }
		
		/// <summary>
		/// 导游编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="导游编号")]
		public virtual string GuideCode{get ; set; }
		
		/// <summary>
		/// 联系人电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系人电话")]
		public virtual string ContactPhone{get ; set; }
		
		/// <summary>
		/// 导游提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="导游提成金额")]
		public virtual decimal GuidePushMoney{get ; set; }
		
		/// <summary>
		/// 讲解员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="讲解员")]
		public virtual string Expostor{get ; set; }
		
		/// <summary>
		/// 讲解员提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="讲解员提成金额")]
		public virtual decimal ExpostorPushMoney{get ; set; }
		
		/// <summary>
		/// 司机
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="司机")]
		public virtual string Driver{get ; set; }
		
		/// <summary>
		/// 停车费
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="停车费")]
		public virtual decimal StopCharge{get ; set; }
		
		/// <summary>
		/// 未结金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="未结金额")]
		public virtual decimal NopayMoney{get ; set; }
		
		/// <summary>
		/// 补单原因
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="补单原因")]
		public virtual string RebalanceCause{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算",DefaultValue="0")]
		public virtual string IfBalance{get ; set; }
		
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
		public TgGroupBalance Clone()
        {
            return (TgGroupBalance)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgGroupBalance Initial()
        {
            TgGroupBalance m = new TgGroupBalance();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfBalance="0";
			m.IfExamine="0";
            return m;
        }
	}
	 
}


