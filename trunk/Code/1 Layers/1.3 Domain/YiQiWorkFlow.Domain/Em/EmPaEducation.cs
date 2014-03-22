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
	///表em_pa_education的实体类(学历编码表)
	///</summary>
	public class EmPaEducation : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 学历编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="学历编码")]
		public virtual string EducationCode{get ; set; }
		
		/// <summary>
		/// 学历名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="学历名称")]
		public virtual string EducationName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmPaEducation Clone()
        {
            return (EmPaEducation)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmPaEducation Initial()
        {
            EmPaEducation m = new EmPaEducation();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


