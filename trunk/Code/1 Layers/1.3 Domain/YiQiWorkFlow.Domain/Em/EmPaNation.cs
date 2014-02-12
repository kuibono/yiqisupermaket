/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Em
{
	///<summary>
	///表em_pa_nation的实体类(民族编码表)
	///</summary>
	public class EmPaNation : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 民族编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="民族编码")]
		public virtual string NationCode{get ; set; }
		
		/// <summary>
		/// 民族名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="民族名称")]
		public virtual string NationName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmPaNation Clone()
        {
            return (EmPaNation)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmPaNation Initial()
        {
            EmPaNation m = new EmPaNation();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


