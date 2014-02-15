/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ba
{
	///<summary>
	///表ba_pa_account的实体类(结算对账设置)
	///</summary>
	public class BaPaAccount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
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
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaPaAccount Clone()
        {
            return (BaPaAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaPaAccount Initial()
        {
            BaPaAccount m = new BaPaAccount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


