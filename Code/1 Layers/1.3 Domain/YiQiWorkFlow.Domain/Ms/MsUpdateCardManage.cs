/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:30
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_update_card_manage的实体类(卡更新)
	///</summary>
	public class MsUpdateCardManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 更新单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="更新单号")]
		public virtual string UpdateNumber{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 更新日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="更新日期")]
		public virtual System.DateTime? UpdateDate{get ; set; }
		
		/// <summary>
		/// 更新原因
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="更新原因")]
		public virtual string UpdateReason{get ; set; }
		
		/// <summary>
		/// 原卡号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="原卡号")]
		public virtual string CardNumberOld{get ; set; }
		
		/// <summary>
		/// 原卡面明码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="原卡面明码")]
		public virtual string SurfaceNumberOld{get ; set; }
		
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
		public MsUpdateCardManage Clone()
        {
            return (MsUpdateCardManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsUpdateCardManage Initial()
        {
            MsUpdateCardManage m = new MsUpdateCardManage();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


