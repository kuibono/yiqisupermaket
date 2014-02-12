/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_pa_dayaccount_stock的实体类(总部日帐设置)
	///</summary>
	public class AcPaDayaccountStock : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 上次记账时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="上次记账时间")]
		public virtual System.DateTime? LastTyDate{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcPaDayaccountStock Clone()
        {
            return (AcPaDayaccountStock)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcPaDayaccountStock Initial()
        {
            AcPaDayaccountStock m = new AcPaDayaccountStock();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


