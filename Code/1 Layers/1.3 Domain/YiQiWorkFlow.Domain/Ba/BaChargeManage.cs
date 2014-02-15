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
	///表ba_charge_manage的实体类(费用管理)
	///</summary>
	public class BaChargeManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 收费日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="收费日期")]
		public virtual System.DateTime? ChargeDate{get ; set; }
		
		/// <summary>
		/// 收费对象
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收费对象")]
		public virtual string ChargeObject{get ; set; }
		
		/// <summary>
		/// 对象编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="对象编码")]
		public virtual string ObjectCode{get ; set; }
		
		/// <summary>
		/// 对象名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="对象名称")]
		public virtual string ObjectName{get ; set; }
		
		/// <summary>
		/// 收费类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收费类型")]
		public virtual string ChargeType{get ; set; }
		
		/// <summary>
		/// 费用金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="费用金额")]
		public virtual decimal ChargeMoney{get ; set; }
		
		/// <summary>
		/// 是否允许结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否允许结算",DefaultValue="0")]
		public virtual string IfAblebalance{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算",DefaultValue="0")]
		public virtual string IfBalance{get ; set; }
		
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算金额",DefaultValue=0)]
		public virtual decimal BaMoney{get ; set; }
		
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
		public BaChargeManage Clone()
        {
            return (BaChargeManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaChargeManage Initial()
        {
            BaChargeManage m = new BaChargeManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfAblebalance="0";
			m.IfBalance="0";
			m.BaMoney=0M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


