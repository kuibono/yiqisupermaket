/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:32
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_sheet_promotion的实体类(整单促销)
	///</summary>
	public class RtSheetPromotion : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 促销开始日期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销开始日期")]
		public virtual string SpBeginDate{get ; set; }
		
		/// <summary>
		/// 促销终止日期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销终止日期")]
		public virtual string SpEndDate{get ; set; }
		
		/// <summary>
		/// 促销开始时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销开始时间")]
		public virtual string SpBeginTime{get ; set; }
		
		/// <summary>
		/// 促销终止时间
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销终止时间")]
		public virtual string SpEndTime{get ; set; }
		
		/// <summary>
		/// 星期1
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期1")]
		public virtual string SpW1{get ; set; }
		
		/// <summary>
		/// 星期2
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期2")]
		public virtual string SpW2{get ; set; }
		
		/// <summary>
		/// 星期3
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期3")]
		public virtual string SpW3{get ; set; }
		
		/// <summary>
		/// 星期4
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期4")]
		public virtual string SpW4{get ; set; }
		
		/// <summary>
		/// 星期5
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期5")]
		public virtual string SpW5{get ; set; }
		
		/// <summary>
		/// 星期6
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期6")]
		public virtual string SpW6{get ; set; }
		
		/// <summary>
		/// 星期7
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="星期7")]
		public virtual string SpW7{get ; set; }
		
		/// <summary>
		/// 促销原因
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="促销原因")]
		public virtual string AdjustReason{get ; set; }
		
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
		public RtSheetPromotion Clone()
        {
            return (RtSheetPromotion)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtSheetPromotion Initial()
        {
            RtSheetPromotion m = new RtSheetPromotion();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


