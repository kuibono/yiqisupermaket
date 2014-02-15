/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_pa_area的实体类(分店区域)
	///</summary>
	public class BsPaArea : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 区域编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="区域编码")]
		public virtual string AreaCode{get ; set; }
		
		/// <summary>
		/// 区域名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="区域名称")]
		public virtual string AreaName{get ; set; }
		
		/// <summary>
		/// 负责人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="负责人")]
		public virtual string Functionary{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsPaArea Clone()
        {
            return (BsPaArea)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsPaArea Initial()
        {
            BsPaArea m = new BsPaArea();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


