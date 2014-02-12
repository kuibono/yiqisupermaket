/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Pc
{
	///<summary>
	///表pc_putout_manage的实体类(商品出库单)
	///</summary>
	public class PcPutoutManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal PoFlowNumber{get ; set; }
		
		/// <summary>
		/// 出库单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="出库单号")]
		public virtual string PoNumber{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 采购形式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="采购形式",DefaultValue="1")]
		public virtual string PcForm{get ; set; }
		
		/// <summary>
		/// 部门编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="部门编码")]
		public virtual string dCode{get ; set; }
		
		/// <summary>
		/// 门店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="门店编码",DefaultValue="0000")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 返货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="返货日期")]
		public virtual System.DateTime? ReturnDate{get ; set; }
		
		/// <summary>
		/// 出库日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="出库日期")]
		public virtual System.DateTime? PutoutDate{get ; set; }
		
		/// <summary>
		/// 返货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货金额")]
		public virtual decimal ReturnMoney{get ; set; }
		
		/// <summary>
		/// 是否允许结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否允许结算",DefaultValue="0")]
		public virtual string IfAblebalance{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算")]
		public virtual string IfBalance{get ; set; }
		
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算金额")]
		public virtual decimal BaMoney{get ; set; }
		
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
		public PcPutoutManage Clone()
        {
            return (PcPutoutManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static PcPutoutManage Initial()
        {
            PcPutoutManage m = new PcPutoutManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PcForm="1";
			m.bCode="0000";
			m.IfAblebalance="0";
			m.IfExamine="0";
            return m;
        }
	}
	 
}


