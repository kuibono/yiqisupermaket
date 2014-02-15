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
	///表rt_retail_log的实体类(收银日志)
	///</summary>
	public class RtRetailLog : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 收银员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银员")]
		public virtual string Cashier{get ; set; }
		
		/// <summary>
		/// 收银员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="收银员姓名")]
		public virtual string EmName{get ; set; }
		
		/// <summary>
		/// 操作方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作方式")]
		public virtual string OperatType{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? RtDate{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 销售名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售名称")]
		public virtual string GoodsBarName{get ; set; }
		
		/// <summary>
		/// 销售单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售单价")]
		public virtual decimal RealPrice{get ; set; }
		
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
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtRetailLog Clone()
        {
            return (RtRetailLog)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtRetailLog Initial()
        {
            RtRetailLog m = new RtRetailLog();
            return m;
        }
	}
	 
}


