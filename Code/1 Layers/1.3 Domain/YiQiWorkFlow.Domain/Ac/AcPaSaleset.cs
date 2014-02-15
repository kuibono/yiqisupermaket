/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:26
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_pa_saleset的实体类(销售记账设置)
	///</summary>
	public class AcPaSaleset : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 上次记账时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="上次记账时间")]
		public virtual System.DateTime? LastTyDate{get ; set; }
		
		/// <summary>
		/// 上次记账流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="上次记账流水")]
		public virtual decimal LastSaFlowNumber{get ; set; }
		
		/// <summary>
		/// 当前销售流水
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前销售流水")]
		public virtual decimal CurrentSaFlowNumber{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcPaSaleset Clone()
        {
            return (AcPaSaleset)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcPaSaleset Initial()
        {
            AcPaSaleset m = new AcPaSaleset();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


