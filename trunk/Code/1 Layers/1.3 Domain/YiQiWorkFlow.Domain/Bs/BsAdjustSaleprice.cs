/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_adjust_saleprice的实体类(分店商品调价)
	///</summary>
	public class BsAdjustSaleprice : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="调整日期")]
		public virtual System.DateTime? AdjustDate{get ; set; }
		
		/// <summary>
		/// 调整原因
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调整原因")]
		public virtual string AdjustReason{get ; set; }
		
		/// <summary>
		/// 调价方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调价方式")]
		public virtual string AdjustType{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 调整分类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调整分类")]
		public virtual string ClassCode{get ; set; }
		
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
		public BsAdjustSaleprice Clone()
        {
            return (BsAdjustSaleprice)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsAdjustSaleprice Initial()
        {
            BsAdjustSaleprice m = new BsAdjustSaleprice();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}

