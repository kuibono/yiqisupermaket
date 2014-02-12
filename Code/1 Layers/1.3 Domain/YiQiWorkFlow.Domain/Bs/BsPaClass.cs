/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_pa_class的实体类(分店分类)
	///</summary>
	public class BsPaClass : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 分类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分类编码")]
		public virtual string ClassCode{get ; set; }
		
		/// <summary>
		/// 分类名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分类名称")]
		public virtual string ClassName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsPaClass Clone()
        {
            return (BsPaClass)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsPaClass Initial()
        {
            BsPaClass m = new BsPaClass();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


