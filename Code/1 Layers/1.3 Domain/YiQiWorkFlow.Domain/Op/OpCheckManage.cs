/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:30
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_check_manage的实体类(商品盘点单)
	///</summary>
	public class OpCheckManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 盘点日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="盘点日期")]
		public virtual System.DateTime? CkDate{get ; set; }
		
		/// <summary>
		/// 盘点方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="盘点方式")]
		public virtual string CkType{get ; set; }
		
		/// <summary>
		/// 盘点单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="盘点单位")]
		public virtual string CkOrgan{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 盘点范围
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="盘点范围")]
		public virtual string CkArea{get ; set; }
		
		/// <summary>
		/// 是否结转
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结转",DefaultValue="0")]
		public virtual string IfTransfer{get ; set; }
		
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
		public OpCheckManage Clone()
        {
            return (OpCheckManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpCheckManage Initial()
        {
            OpCheckManage m = new OpCheckManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfTransfer="0";
			m.IfExamine="0";
            return m;
        }
	}
	 
}


