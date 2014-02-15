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
	///表bs_branch_archives的实体类(分店档案管理)
	///</summary>
	public class BsBranchArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 分店名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店名称")]
		public virtual string bName{get ; set; }
		
		/// <summary>
		/// 拼音码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="拼音码")]
		public virtual string PyCode{get ; set; }
		
		/// <summary>
		/// 分店类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店类型")]
		public virtual string bType{get ; set; }
		
		/// <summary>
		/// 分店状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店状态")]
		public virtual string bState{get ; set; }
		
		/// <summary>
		/// 所属区域
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属区域")]
		public virtual string AreaCode{get ; set; }
		
		/// <summary>
		/// 所属分类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属分类")]
		public virtual string ClassCode{get ; set; }
		
		/// <summary>
		/// 负责人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="负责人")]
		public virtual string Functionary{get ; set; }
		
		/// <summary>
		/// 负责人电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="负责人电话")]
		public virtual string FunctionaryPhone{get ; set; }
		
		/// <summary>
		/// 联系地址
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系地址")]
		public virtual string ContactAddress{get ; set; }
		
		/// <summary>
		/// 办公电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="办公电话")]
		public virtual string OfficePhone{get ; set; }
		
		/// <summary>
		/// 传真
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="传真")]
		public virtual string FaxPhone{get ; set; }
		
		/// <summary>
		/// 邮箱
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="邮箱")]
		public virtual string eMail{get ; set; }
		
		/// <summary>
		/// 邮政编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="邮政编码")]
		public virtual string Postalcode{get ; set; }
		
		/// <summary>
		/// 开户行
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="开户行")]
		public virtual string OpenAccount{get ; set; }
		
		/// <summary>
		/// 帐号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="帐号")]
		public virtual string BankAccount{get ; set; }
		
		/// <summary>
		/// 税号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="税号")]
		public virtual string TaxNumber{get ; set; }
		
		/// <summary>
		/// 1经销，2代销，3联营
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="1经销，2代销，3联营")]
		public virtual string OpCode{get ; set; }
		
		/// <summary>
		/// 普通发票，增殖税发票
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="普通发票，增殖税发票",DefaultValue="增值税发票")]
		public virtual string StockVoucher{get ; set; }
		
		/// <summary>
		/// 进项税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="进项税率",DefaultValue=0.17)]
		public virtual decimal InputTax{get ; set; }
		
		/// <summary>
		/// 预付货款，货到付款，实销实付，扣点结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="预付货款，货到付款，实销实付，扣点结算",DefaultValue="货到付款")]
		public virtual string BalanceMode{get ; set; }
		
		/// <summary>
		/// 现金，支票，汇票
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="现金，支票，汇票",DefaultValue="现金")]
		public virtual string PayMode{get ; set; }
		
		/// <summary>
		/// 月结算，季计算，年结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="月结算，季计算，年结算",DefaultValue="月结算")]
		public virtual string BalancePeriod{get ; set; }
		
		/// <summary>
		/// 31
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="31",DefaultValue=1)]
		public virtual decimal BalanceDay{get ; set; }
		
		/// <summary>
		/// 送货天数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="送货天数",DefaultValue=0)]
		public virtual decimal DeliveryDays{get ; set; }
		
		/// <summary>
		/// 配价方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配价方式")]
		public virtual string SupplyPriceType{get ; set; }
		
		/// <summary>
		/// 加价率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="加价率")]
		public virtual decimal GrossRate{get ; set; }
		
		/// <summary>
		/// 配送仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="配送仓库")]
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
		/// 0否，1是
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0否，1是",DefaultValue="0")]
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
		public BsBranchArchives Clone()
        {
            return (BsBranchArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsBranchArchives Initial()
        {
            BsBranchArchives m = new BsBranchArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.StockVoucher="增值税发票";
			m.InputTax=0.17M;
			m.BalanceMode="货到付款";
			m.PayMode="现金";
			m.BalancePeriod="月结算";
			m.BalanceDay=1M;
			m.DeliveryDays=0M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


