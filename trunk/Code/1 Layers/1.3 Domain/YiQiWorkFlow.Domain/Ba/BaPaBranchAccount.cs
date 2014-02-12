/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ba
{
	///<summary>
	///表ba_pa_branch_account的实体类(分店对帐设置)
	///</summary>
	public class BaPaBranchAccount : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 上次销售流水_代销
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次销售流水_代销")]
		public virtual decimal LastRtFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前销售流水_代销
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前销售流水_代销")]
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
		public BaPaBranchAccount Clone()
        {
            return (BaPaBranchAccount)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaPaBranchAccount Initial()
        {
            BaPaBranchAccount m = new BaPaBranchAccount();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


