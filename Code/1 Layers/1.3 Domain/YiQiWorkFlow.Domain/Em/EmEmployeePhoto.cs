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
	///表em_employee_photo的实体类(人员照片)
	///</summary>
	public class EmEmployeePhoto : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="人员编号")]
		public virtual string EmCode{get ; set; }
		
		/// <summary>
		/// 人员照片
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员照片")]
		public virtual byte[] EmPhoto{get ; set; }
		
		/// <summary>
		/// 照片类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="照片类型")]
		public virtual string PhotoType{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmEmployeePhoto Clone()
        {
            return (EmEmployeePhoto)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmEmployeePhoto Initial()
        {
            EmEmployeePhoto m = new EmEmployeePhoto();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


