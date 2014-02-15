/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:28
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Em
{
	///<summary>
	///表em_pa_duty的实体类(职务编码表)
	///</summary>
	public class EmPaDuty : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 职务编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职务编码")]
		public virtual string DutyCode{get ; set; }
		
		/// <summary>
		/// 职务名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职务名称")]
		public virtual string DutyName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmPaDuty Clone()
        {
            return (EmPaDuty)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmPaDuty Initial()
        {
            EmPaDuty m = new EmPaDuty();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


