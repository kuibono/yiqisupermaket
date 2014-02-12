/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tg
{
	///<summary>
	///表tg_pa_group_type的实体类(团队类别)
	///</summary>
	public class TgPaGroupType : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 团队类型编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队类型编码")]
		public virtual string GroupTypeCode{get ; set; }
		
		/// <summary>
		/// 团队类型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队类型名称")]
		public virtual string GroupTypeName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgPaGroupType Clone()
        {
            return (TgPaGroupType)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgPaGroupType Initial()
        {
            TgPaGroupType m = new TgPaGroupType();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


