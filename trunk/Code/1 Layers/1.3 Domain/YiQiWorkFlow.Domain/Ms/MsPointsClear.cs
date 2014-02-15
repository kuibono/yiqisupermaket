/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:30
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_points_clear的实体类(积分清零管理)
	///</summary>
	public class MsPointsClear : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 清零日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="清零日期")]
		public virtual System.DateTime? ClearDate{get ; set; }
		
		/// <summary>
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsPointsClear Clone()
        {
            return (MsPointsClear)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsPointsClear Initial()
        {
            MsPointsClear m = new MsPointsClear();
            return m;
        }
	}
	 
}


