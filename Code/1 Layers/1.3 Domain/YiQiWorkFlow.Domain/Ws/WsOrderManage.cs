/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ws
{
	///<summary>
	///表ws_order_manage的实体类(批发订单)
	///</summary>
	public class WsOrderManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 订货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="订货日期")]
		public virtual System.DateTime? OrderDate{get ; set; }
		
		/// <summary>
		/// 客户编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="客户编码")]
		public virtual string CustCode{get ; set; }
		
		/// <summary>
		/// 批发单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="批发单位")]
		public virtual string WsOrgan{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 业务员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务员")]
		public virtual string Salesman{get ; set; }
		
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
		public WsOrderManage Clone()
        {
            return (WsOrderManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static WsOrderManage Initial()
        {
            WsOrderManage m = new WsOrderManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


