/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_allot_manage_flow的实体类(商品调拨流水帐单)
	///</summary>
	public class OpAllotManageFlow : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal AlFlowNumber{get ; set; }
		
		/// <summary>
		/// 调拨单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="调拨单号")]
		public virtual string AlNumber{get ; set; }
		
		/// <summary>
		/// 调拨类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调拨类型")]
		public virtual string AlType{get ; set; }
		
		/// <summary>
		/// 调出单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调出单位")]
		public virtual string OrganOut{get ; set; }
		
		/// <summary>
		/// 调出单位名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调出单位名称")]
		public virtual string OrganNameOut{get ; set; }
		
		/// <summary>
		/// 调出仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调出仓库")]
		public virtual string WhCodeOut{get ; set; }
		
		/// <summary>
		/// 调入单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调入单位")]
		public virtual string OrganIn{get ; set; }
		
		/// <summary>
		/// 调入单位名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调入单位名称")]
		public virtual string OrganNameIn{get ; set; }
		
		/// <summary>
		/// 调入仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="调入仓库")]
		public virtual string WhCodeIn{get ; set; }
		
		/// <summary>
		/// 调拨日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="调拨日期")]
		public virtual System.DateTime? AlDate{get ; set; }
		
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
		public OpAllotManageFlow Clone()
        {
            return (OpAllotManageFlow)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpAllotManageFlow Initial()
        {
            OpAllotManageFlow m = new OpAllotManageFlow();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}

