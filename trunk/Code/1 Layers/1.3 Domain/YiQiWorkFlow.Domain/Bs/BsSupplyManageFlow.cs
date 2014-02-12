/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_supply_manage_flow的实体类(分店商品订货配送单_流水)
	///</summary>
	public class BsSupplyManageFlow : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal SpFlowNumber{get ; set; }
		
		/// <summary>
		/// 配送单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="配送单号")]
		public virtual string SpNumber{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 总部仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="总部仓库")]
		public virtual string WhCodeOut{get ; set; }
		
		/// <summary>
		/// 配送方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配送方式")]
		public virtual string SpType{get ; set; }
		
		/// <summary>
		/// 配送状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配送状态")]
		public virtual string SpState{get ; set; }
		
		/// <summary>
		/// 订货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="订货日期")]
		public virtual System.DateTime? PurchaseDate{get ; set; }
		
		/// <summary>
		/// 预计送货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="预计送货日期")]
		public virtual System.DateTime? ExpectArriveDate{get ; set; }
		
		/// <summary>
		/// 配送日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="配送日期")]
		public virtual System.DateTime? SupplyDate{get ; set; }
		
		/// <summary>
		/// 收货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="收货日期")]
		public virtual System.DateTime? PutinDate{get ; set; }
		
		/// <summary>
		/// 配送金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="配送金额",DefaultValue=0)]
		public virtual decimal SupplyMoney{get ; set; }
		
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
		[Validate(ValidateType.IsDecimal ,Name="结算金额",DefaultValue=0)]
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
		/// 订货审核人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="订货审核人")]
		public virtual string PurchaseAssessor{get ; set; }
		
		/// <summary>
		/// 订货是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="订货是否审核",DefaultValue="0")]
		public virtual string PurchaseIfExamine{get ; set; }
		
		/// <summary>
		/// 订货审核时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="订货审核时间")]
		public virtual System.DateTime? PurchaseExamineDate{get ; set; }
		
		/// <summary>
		/// 配送审核人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配送审核人")]
		public virtual string SupplyAssessor{get ; set; }
		
		/// <summary>
		/// 配送是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配送是否审核",DefaultValue="0")]
		public virtual string SupplyIfExamine{get ; set; }
		
		/// <summary>
		/// 配送审核时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="配送审核时间")]
		public virtual System.DateTime? SupplyExamineDate{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsSupplyManageFlow Clone()
        {
            return (BsSupplyManageFlow)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsSupplyManageFlow Initial()
        {
            BsSupplyManageFlow m = new BsSupplyManageFlow();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.SupplyMoney=0M;
			m.BaMoney=0M;
			m.PurchaseIfExamine="0";
			m.SupplyIfExamine="0";
            return m;
        }
	}
	 
}


