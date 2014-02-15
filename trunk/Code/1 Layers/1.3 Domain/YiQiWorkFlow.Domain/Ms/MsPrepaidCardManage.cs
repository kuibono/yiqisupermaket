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
	///表ms_prepaid_card_manage的实体类(卡充值)
	///</summary>
	public class MsPrepaidCardManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 充值日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="充值日期")]
		public virtual System.DateTime? PrepaidDate{get ; set; }
		
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
		/// 充值金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="充值金额")]
		public virtual decimal PrepaidMoney{get ; set; }
		
		/// <summary>
		/// 累计储值金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="累计储值金额",DefaultValue=0)]
		public virtual decimal TotalPrepaid{get ; set; }
		
		/// <summary>
		/// 当前储值金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前储值金额",DefaultValue=0)]
		public virtual decimal CurrentPrepaid{get ; set; }
		
		/// <summary>
		/// 使用金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="使用金额",DefaultValue=0)]
		public virtual decimal UsePrepaid{get ; set; }
		
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
		public MsPrepaidCardManage Clone()
        {
            return (MsPrepaidCardManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsPrepaidCardManage Initial()
        {
            MsPrepaidCardManage m = new MsPrepaidCardManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.TotalPrepaid=0M;
			m.CurrentPrepaid=0M;
			m.UsePrepaid=0M;
            return m;
        }
	}
	 
}


