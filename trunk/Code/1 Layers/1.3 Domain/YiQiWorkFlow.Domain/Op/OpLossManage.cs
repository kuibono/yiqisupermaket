/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:31
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_loss_manage的实体类(商品损溢)
	///</summary>
	public class OpLossManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 损溢日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="损溢日期")]
		public virtual System.DateTime? LoDate{get ; set; }
		
		/// <summary>
		/// 盘点单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="盘点单号")]
		public virtual string CkNumber{get ; set; }
		
		/// <summary>
		/// 损溢方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="损溢方式")]
		public virtual string LoType{get ; set; }
		
		/// <summary>
		/// 损溢单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="损溢单位")]
		public virtual string LoOrgan{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
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
		public OpLossManage Clone()
        {
            return (OpLossManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpLossManage Initial()
        {
            OpLossManage m = new OpLossManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


