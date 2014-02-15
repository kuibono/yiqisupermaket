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
	///表ms_loss_card_manage的实体类(卡挂失)
	///</summary>
	public class MsLossCardManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 挂失日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="挂失日期")]
		public virtual System.DateTime? LossDate{get ; set; }
		
		/// <summary>
		/// 挂失方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="挂失方式")]
		public virtual string LossType{get ; set; }
		
		/// <summary>
		/// 挂失原因
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="挂失原因")]
		public virtual string LossReason{get ; set; }
		
		/// <summary>
		/// 挂失人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="挂失人")]
		public virtual string LossPerson{get ; set; }
		
		/// <summary>
		/// 卡号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡号")]
		public virtual string CardNumber{get ; set; }
		
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
		/// 0待发1正常2挂失3废除
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0待发1正常2挂失3废除")]
		public virtual string CardState{get ; set; }
		
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
		public MsLossCardManage Clone()
        {
            return (MsLossCardManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsLossCardManage Initial()
        {
            MsLossCardManage m = new MsLossCardManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


