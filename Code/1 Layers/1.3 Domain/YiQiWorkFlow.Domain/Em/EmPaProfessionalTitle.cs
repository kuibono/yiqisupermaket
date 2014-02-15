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
	///表em_pa_Professional_title的实体类(职称编码表)
	///</summary>
	public class EmPaProfessionalTitle : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 职称编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职称编码")]
		public virtual string ProfessionalTitleCode{get ; set; }
		
		/// <summary>
		/// 职称名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职称名称")]
		public virtual string ProfessionalTitleName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmPaProfessionalTitle Clone()
        {
            return (EmPaProfessionalTitle)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmPaProfessionalTitle Initial()
        {
            EmPaProfessionalTitle m = new EmPaProfessionalTitle();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


