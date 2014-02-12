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
	///表op_split_com_manage_flow的实体类(组合拆零管理流水单)
	///</summary>
	public class OpSplitComManageFlow : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal ScFlowNumber{get ; set; }
		
		/// <summary>
		/// 处理单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="处理单号")]
		public virtual string ScNumber{get ; set; }
		
		/// <summary>
		/// 处理日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="处理日期")]
		public virtual System.DateTime? ScDate{get ; set; }
		
		/// <summary>
		/// 处理方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="处理方式")]
		public virtual string ScType{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 处理数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="处理数量")]
		public virtual decimal PurchaseQty{get ; set; }
		
		/// <summary>
		/// 含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税金额")]
		public virtual decimal PurchaseMoney{get ; set; }
		
		/// <summary>
		/// 不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税金额")]
		public virtual decimal NontaxPurchaseMoney{get ; set; }
		
		/// <summary>
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价")]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="售价金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 不含税售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税售价金额")]
		public virtual decimal NontaxSaleMoney{get ; set; }
		
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
		public OpSplitComManageFlow Clone()
        {
            return (OpSplitComManageFlow)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpSplitComManageFlow Initial()
        {
            OpSplitComManageFlow m = new OpSplitComManageFlow();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


