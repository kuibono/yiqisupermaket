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
	///表ms_exchange_manage的实体类(赠品兑换管理)
	///</summary>
	public class MsExchangeManage : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 兑换单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="兑换单号")]
		public virtual string ExchangeNumber{get ; set; }
		
		/// <summary>
		/// 兑换日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="兑换日期")]
		public virtual System.DateTime? ExchangeDate{get ; set; }
		
		/// <summary>
		/// 卡号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡号")]
		public virtual string CardNumber{get ; set; }
		
		/// <summary>
		/// 会员编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="会员编码")]
		public virtual string MsCode{get ; set; }
		
		/// <summary>
		/// 会员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="会员姓名")]
		public virtual string MsName{get ; set; }
		
		/// <summary>
		/// 当前积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前积分",DefaultValue=0)]
		public virtual decimal CurrentPoints{get ; set; }
		
		/// <summary>
		/// 兑换积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="兑换积分",DefaultValue=0)]
		public virtual decimal ExchangePoints{get ; set; }
		
		/// <summary>
		/// 剩余积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="剩余积分")]
		public virtual decimal SurplusPoints{get ; set; }
		
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
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsExchangeManage Clone()
        {
            return (MsExchangeManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsExchangeManage Initial()
        {
            MsExchangeManage m = new MsExchangeManage();
			m.CurrentPoints=0M;
			m.ExchangePoints=0M;
            return m;
        }
	}
	 
}


