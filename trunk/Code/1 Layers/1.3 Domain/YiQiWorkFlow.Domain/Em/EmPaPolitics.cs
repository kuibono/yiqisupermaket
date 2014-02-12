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
	///表em_pa_politics的实体类(政治面貌编码表)
	///</summary>
	public class EmPaPolitics : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 政治面貌编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="政治面貌编码")]
		public virtual string PoliticsCode{get ; set; }
		
		/// <summary>
		/// 政治面貌名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="政治面貌名称")]
		public virtual string PoliticsName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmPaPolitics Clone()
        {
            return (EmPaPolitics)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmPaPolitics Initial()
        {
            EmPaPolitics m = new EmPaPolitics();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


