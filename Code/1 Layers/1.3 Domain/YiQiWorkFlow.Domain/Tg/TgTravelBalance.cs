/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tg
{
	///<summary>
	///表tg_travel_balance的实体类(旅行社结算管理)
	///</summary>
	public class TgTravelBalance : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 结算日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="结算日期")]
		public virtual System.DateTime? BaDate{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 付款方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="付款方式")]
		public virtual string PaywayCode{get ; set; }
		
		/// <summary>
		/// 旅行社编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="旅行社编码")]
		public virtual string TaCode{get ; set; }
		
		/// <summary>
		/// 旅行社名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="旅行社名称")]
		public virtual string TaName{get ; set; }
		
		/// <summary>
		/// 结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算金额")]
		public virtual decimal BalanceMoney{get ; set; }
		
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
		public TgTravelBalance Clone()
        {
            return (TgTravelBalance)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgTravelBalance Initial()
        {
            TgTravelBalance m = new TgTravelBalance();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}

