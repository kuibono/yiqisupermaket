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
	///表ws_customer_archives的实体类(客户档案)
	///</summary>
	public class WsCustomerArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 客户名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="客户名称")]
		public virtual string CustName{get ; set; }
		
		/// <summary>
		/// 拼音码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="拼音码")]
		public virtual string PyCode{get ; set; }
		
		/// <summary>
		/// 客户类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="客户类型")]
		public virtual string CustTypeCode{get ; set; }
		
		/// <summary>
		/// 联系人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系人")]
		public virtual string Linkman{get ; set; }
		
		/// <summary>
		/// 联系电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系电话")]
		public virtual string ContactPhone{get ; set; }
		
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
		/// 现金，支票，汇票
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="现金，支票，汇票",DefaultValue="现金")]
		public virtual string PayMode{get ; set; }
		
		/// <summary>
		/// 预付货款，货到付款，实销实付，扣点结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="预付货款，货到付款，实销实付，扣点结算",DefaultValue="货到付款")]
		public virtual string BalanceMode{get ; set; }
		
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
		/// 销售帐期
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售帐期")]
		public virtual string SalePeriod{get ; set; }
		
		/// <summary>
		/// 备注
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="备注")]
		public virtual string Comment{get ; set; }
		
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
		public WsCustomerArchives Clone()
        {
            return (WsCustomerArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static WsCustomerArchives Initial()
        {
            WsCustomerArchives m = new WsCustomerArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PayMode="现金";
			m.BalanceMode="货到付款";
			m.BalancePeriod="月结算";
			m.BalanceDay=1M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


