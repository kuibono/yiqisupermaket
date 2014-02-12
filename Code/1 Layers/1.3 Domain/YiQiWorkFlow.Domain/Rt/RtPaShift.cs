/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_pa_shift的实体类(销售班次)
	///</summary>
	public class RtPaShift : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 班次编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="班次编码")]
		public virtual string ShiftCode{get ; set; }
		
		/// <summary>
		/// 班次名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="班次名称")]
		public virtual string ShiftName{get ; set; }
		
		/// <summary>
		/// 开始时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="开始时间")]
		public virtual System.DateTime? BeginDate{get ; set; }
		
		/// <summary>
		/// 终止时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="终止时间")]
		public virtual System.DateTime? EndDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPaShift Clone()
        {
            return (RtPaShift)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPaShift Initial()
        {
            RtPaShift m = new RtPaShift();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


