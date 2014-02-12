/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_pointtoprepaid_manage的实体类(积分转储值)
	///</summary>
	public class MsPointtoprepaidManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水号")]
		public virtual decimal NumberFlow{get ; set; }
		
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
		/// 卡面明码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡面明码")]
		public virtual string SurfaceNumber{get ; set; }
		
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
		/// 储值金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="储值金额")]
		public virtual decimal PrepaidMoney{get ; set; }
		
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
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsPointtoprepaidManage Clone()
        {
            return (MsPointtoprepaidManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsPointtoprepaidManage Initial()
        {
            MsPointtoprepaidManage m = new MsPointtoprepaidManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.CurrentPoints=0M;
			m.ExchangePoints=0M;
            return m;
        }
	}
	 
}


