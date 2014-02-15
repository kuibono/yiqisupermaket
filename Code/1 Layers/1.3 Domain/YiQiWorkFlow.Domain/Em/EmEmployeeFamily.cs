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
	///表em_employee_family的实体类(人员家庭信息)
	///</summary>
	public class EmEmployeeFamily : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 人员编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="人员编号")]
		public virtual string EmCode{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 成员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="成员姓名")]
		public virtual string MemberName{get ; set; }
		
		/// <summary>
		/// 与本人关系
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="与本人关系")]
		public virtual string Relationship{get ; set; }
		
		/// <summary>
		/// 出生日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="出生日期")]
		public virtual System.DateTime? Birthday{get ; set; }
		
		/// <summary>
		/// 政治面貌编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="政治面貌编码")]
		public virtual string PoliticsCode{get ; set; }
		
		/// <summary>
		/// 职务编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职务编码")]
		public virtual string DutyCode{get ; set; }
		
		/// <summary>
		/// 工作单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="工作单位")]
		public virtual string WorkDepartment{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmEmployeeFamily Clone()
        {
            return (EmEmployeeFamily)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmEmployeeFamily Initial()
        {
            EmEmployeeFamily m = new EmEmployeeFamily();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


