/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_card_archives的实体类(卡信息)
	///</summary>
	public class MsCardArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 卡面明码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡面明码")]
		public virtual string SurfaceNumber{get ; set; }
		
		/// <summary>
		/// 会员编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="会员编码")]
		public virtual string MsCode{get ; set; }
		
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
		/// <summary>
		/// 卡类型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="卡类型名称")]
		public virtual string CardName{get ; set; }
		
		/// <summary>
		/// 会员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="会员姓名")]
		public virtual string MsName{get ; set; }
		
		/// <summary>
		/// 0待发1正常2挂失3冻结4废除
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0待发1正常2挂失3冻结4废除")]
		public virtual string CardState{get ; set; }
		
		/// <summary>
		/// 制卡日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="制卡日期")]
		public virtual System.DateTime? CreateDate{get ; set; }
		
		/// <summary>
		/// 发卡日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="发卡日期")]
		public virtual System.DateTime? GrantDate{get ; set; }
		
		/// <summary>
		/// 生效日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="生效日期")]
		public virtual System.DateTime? EffectiveDate{get ; set; }
		
		/// <summary>
		/// 积分有效期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="积分有效期")]
		public virtual System.DateTime? PointsUsefulLifeDate{get ; set; }
		
		/// <summary>
		/// 卡有效期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="卡有效期")]
		public virtual System.DateTime? CardUsefulLifeDate{get ; set; }
		
		/// <summary>
		/// 办卡费用
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="办卡费用")]
		public virtual decimal TransactCharge{get ; set; }
		
		/// <summary>
		/// 押金金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="押金金额")]
		public virtual decimal DepositMoney{get ; set; }
		
		/// <summary>
		/// 累计消费金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="累计消费金额",DefaultValue=0)]
		public virtual decimal TotalMoney{get ; set; }
		
		/// <summary>
		/// 累计消费次数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="累计消费次数",DefaultValue=0)]
		public virtual decimal TotalExpendTimes{get ; set; }
		
		/// <summary>
		/// 上次消费金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次消费金额",DefaultValue=0)]
		public virtual decimal LastExpendMoney{get ; set; }
		
		/// <summary>
		/// 累计积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="累计积分",DefaultValue=0)]
		public virtual decimal TotalPoints{get ; set; }
		
		/// <summary>
		/// 兑换积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="兑换积分",DefaultValue=0)]
		public virtual decimal ExchangePoints{get ; set; }
		
		/// <summary>
		/// 当前积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前积分",DefaultValue=0)]
		public virtual decimal CurrentPoints{get ; set; }
		
		/// <summary>
		/// 清零积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="清零积分",DefaultValue=0)]
		public virtual decimal ClearPoints{get ; set; }
		
		/// <summary>
		/// 储值密码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="储值密码")]
		public virtual string PrepaidPassword{get ; set; }
		
		/// <summary>
		/// 累计储值金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="累计储值金额",DefaultValue=0)]
		public virtual decimal TotalPrepaid{get ; set; }
		
		/// <summary>
		/// 当前储值金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前储值金额",DefaultValue=0)]
		public virtual decimal CurrentPrepaid{get ; set; }
		
		/// <summary>
		/// 当前金额
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="当前金额")]
		public virtual string CurrentPrepaidEncrypt{get ; set; }
		
		/// <summary>
		/// 使用金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="使用金额",DefaultValue=30)]
		public virtual decimal UsePrepaid{get ; set; }
		
		/// <summary>
		/// 限制次数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="限制次数",DefaultValue=0)]
		public virtual decimal LimitTimes{get ; set; }
		
		/// <summary>
		/// 消费次数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="消费次数",DefaultValue=0)]
		public virtual decimal SaleTimes{get ; set; }
		
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
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsCardArchives Clone()
        {
            return (MsCardArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsCardArchives Initial()
        {
            MsCardArchives m = new MsCardArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.TotalMoney=0M;
			m.TotalExpendTimes=0M;
			m.LastExpendMoney=0M;
			m.TotalPoints=0M;
			m.ExchangePoints=0M;
			m.CurrentPoints=0M;
			m.ClearPoints=0M;
			m.TotalPrepaid=0M;
			m.CurrentPrepaid=0M;
			m.UsePrepaid=30M;
			m.LimitTimes=0M;
			m.SaleTimes=0M;
            return m;
        }
	}
	 
}


