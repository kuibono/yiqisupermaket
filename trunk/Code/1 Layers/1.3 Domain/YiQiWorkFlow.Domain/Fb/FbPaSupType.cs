/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_pa_sup_type的实体类(供货商类型)
	///</summary>
	public class FbPaSupType : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 类型编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="类型编码")]
		public virtual string SupTypeCode{get ; set; }
		
		/// <summary>
		/// 类型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="类型名称")]
		public virtual string SupTypeName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaSupType Clone()
        {
            return (FbPaSupType)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaSupType Initial()
        {
            FbPaSupType m = new FbPaSupType();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


