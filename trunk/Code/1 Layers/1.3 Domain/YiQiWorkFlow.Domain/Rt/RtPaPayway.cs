/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_pa_payway的实体类(付款方式)
	///</summary>
	public class RtPaPayway : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 付款方式编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="付款方式编码")]
		public virtual string PaywayCode{get ; set; }
		
		/// <summary>
		/// 付款方式名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="付款方式名称")]
		public virtual string PaywayName{get ; set; }
		
		/// <summary>
		/// 付款方式简码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="付款方式简码")]
		public virtual string PaywaySubCode{get ; set; }
		
		/// <summary>
		/// 付款类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="付款类型")]
		public virtual string PaywayType{get ; set; }
		
		/// <summary>
		/// 汇率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="汇率")]
		public virtual decimal ExRate{get ; set; }
		
		/// <summary>
		/// 是否设置找零
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否设置找零")]
		public virtual string IfChange{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPaPayway Clone()
        {
            return (RtPaPayway)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPaPayway Initial()
        {
            RtPaPayway m = new RtPaPayway();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


