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
	///表ba_pa_charge的实体类(费用设置)
	///</summary>
	public class BaPaCharge : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 费用编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="费用编码")]
		public virtual string ChargeCode{get ; set; }
		
		/// <summary>
		/// 费用名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="费用名称")]
		public virtual string ChargeName{get ; set; }
		
		/// <summary>
		/// 收费标准
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="收费标准")]
		public virtual decimal ChargeStandard{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaPaCharge Clone()
        {
            return (BaPaCharge)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaPaCharge Initial()
        {
            BaPaCharge m = new BaPaCharge();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


