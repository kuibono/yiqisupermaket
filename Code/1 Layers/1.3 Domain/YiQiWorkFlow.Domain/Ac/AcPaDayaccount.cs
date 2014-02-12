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
	///表ac_pa_dayaccount的实体类(日帐设置)
	///</summary>
	public class AcPaDayaccount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 上次记账时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="上次记账时间")]
		public virtual System.DateTime? LastTyDate{get ; set; }
		
		/// <summary>
		/// 上次销售流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次销售流水")]
		public virtual decimal LastRtFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前销售流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前销售流水")]
		public virtual decimal CurrentRtFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次批发流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次批发流水")]
		public virtual decimal LastWsFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前批发流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前批发流水")]
		public virtual decimal CurrentWsFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次进货流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次进货流水")]
		public virtual decimal LastPiFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前进货流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前进货流水")]
		public virtual decimal CurrentPiFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次返货流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次返货流水")]
		public virtual decimal LastPoFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前返货流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前返货流水")]
		public virtual decimal CurrentPoFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次调拨流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次调拨流水")]
		public virtual decimal LastAlFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前调拨流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前调拨流水")]
		public virtual decimal CurrentAlFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次损溢流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次损溢流水")]
		public virtual decimal LastLoFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前损溢流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前损溢流水")]
		public virtual decimal CurrentLoFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次调整流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次调整流水")]
		public virtual decimal LastAdFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前调整流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前调整流水")]
		public virtual decimal CurrentAdFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次兑换流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次兑换流水",DefaultValue=0)]
		public virtual decimal LastExFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前兑换流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前兑换流水",DefaultValue=0)]
		public virtual decimal CurrentExFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次拆零流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次拆零流水",DefaultValue=0)]
		public virtual decimal LastScFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前拆零流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前拆零流水",DefaultValue=0)]
		public virtual decimal CurrentScFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次配送流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次配送流水")]
		public virtual decimal LastSpFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前配送流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前配送流水")]
		public virtual decimal CurrentSpFlowNumber{get ; set; }
		
		/// <summary>
		/// 上次配返流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次配返流水")]
		public virtual decimal LastReFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前配返流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前配返流水")]
		public virtual decimal CurrentReFlowNumber{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcPaDayaccount Clone()
        {
            return (AcPaDayaccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcPaDayaccount Initial()
        {
            AcPaDayaccount m = new AcPaDayaccount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.LastExFlowNumber=0M;
			m.CurrentExFlowNumber=0M;
			m.LastScFlowNumber=0M;
			m.CurrentScFlowNumber=0M;
            return m;
        }
	}
	 
}


