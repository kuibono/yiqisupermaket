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
	///表tg_pa_group的实体类(团队结算设置)
	///</summary>
	public class TgPaGroup : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 开团日期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="开团日期")]
		public virtual string GroupDate{get ; set; }
		
		/// <summary>
		/// 团队编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="团队编号")]
		public virtual string GroupNumber{get ; set; }
		
		/// <summary>
		/// 消费项目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="消费项目")]
		public virtual string GbCode{get ; set; }
		
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
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgPaGroup Clone()
        {
            return (TgPaGroup)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgPaGroup Initial()
        {
            TgPaGroup m = new TgPaGroup();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


