/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tg
{
	///<summary>
	///表tg_pa_ta_type的实体类(旅行社类型)
	///</summary>
	public class TgPaTaType : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 类型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="类型名称")]
		public virtual string TaTypeName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgPaTaType Clone()
        {
            return (TgPaTaType)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgPaTaType Initial()
        {
            TgPaTaType m = new TgPaTaType();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


