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
	///表ba_charge_detail的实体类(费用费用_费用明细)
	///</summary>
	public class BaChargeDetail : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 收费单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="收费单号")]
		public virtual string ChargeNumber{get ; set; }
		
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
		
		/// <summary>
		/// 备注
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="备注")]
		public virtual string Comment{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaChargeDetail Clone()
        {
            return (BaChargeDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaChargeDetail Initial()
        {
            BaChargeDetail m = new BaChargeDetail();
            return m;
        }
	}
	 
}


