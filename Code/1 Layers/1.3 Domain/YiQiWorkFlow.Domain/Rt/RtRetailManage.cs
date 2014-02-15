/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:32
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_retail_manage的实体类(销售主表)
	///</summary>
	public class RtRetailManage : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 销售时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="销售时间")]
		public virtual System.DateTime? RtDate{get ; set; }
		
		/// <summary>
		/// 销售方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售方式")]
		public virtual string RtType{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// Pos机号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="Pos机号")]
		public virtual string Posid{get ; set; }
		
		/// <summary>
		/// 数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="数量")]
		public virtual decimal SaleQty{get ; set; }
		
		/// <summary>
		/// 销售金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售金额")]
		public virtual decimal SaleMoney{get ; set; }
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="折扣金额")]
		public virtual decimal DiscountMoney{get ; set; }
		
		/// <summary>
		/// 会员卡号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="会员卡号")]
		public virtual string CardNumber{get ; set; }
		
		/// <summary>
		/// 收银员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银员")]
		public virtual string Cashier{get ; set; }
		
		/// <summary>
		/// 授权人员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="授权人员")]
		public virtual string CashierHigher{get ; set; }
		
		/// <summary>
		/// 营业员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="营业员")]
		public virtual string Salesman{get ; set; }
		
		/// <summary>
		/// 柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="柜台")]
		public virtual string UnderCounterCode{get ; set; }
		
		/// <summary>
		/// 班次时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="班次时间")]
		public virtual System.DateTime? ShiftDate{get ; set; }
		
		/// <summary>
		/// 返货单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="返货单号")]
		public virtual string ReturnNumber{get ; set; }
		
		/// <summary>
		/// 备注
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="备注")]
		public virtual string Comment{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtRetailManage Clone()
        {
            return (RtRetailManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtRetailManage Initial()
        {
            RtRetailManage m = new RtRetailManage();
            return m;
        }
	}
	 
}


