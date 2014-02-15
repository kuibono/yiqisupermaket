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
	///表op_adjust_detail的实体类(商品调整单_商品明细)
	///</summary>
	public class OpAdjustDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="调整单号")]
		public virtual string AdjustNumber{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 调整数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整数量")]
		public virtual decimal AdjustQty{get ; set; }
		
		/// <summary>
		/// 调整价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整价")]
		public virtual decimal AdjustPrice{get ; set; }
		
		/// <summary>
		/// 调整不含税单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整不含税单价")]
		public virtual decimal NontaxAdjustPrice{get ; set; }
		
		/// <summary>
		/// 调整金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整金额")]
		public virtual decimal AdjustMoney{get ; set; }
		
		/// <summary>
		/// 调整不含税金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="调整不含税金额")]
		public virtual decimal NontaxAdjustMoney{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpAdjustDetail Clone()
        {
            return (OpAdjustDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpAdjustDetail Initial()
        {
            OpAdjustDetail m = new OpAdjustDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


