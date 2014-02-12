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
	///表rt_pa_function的实体类(收银功能表)
	///</summary>
	public class RtPaFunction : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 功能编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="功能编码")]
		public virtual string FuncCode{get ; set; }
		
		/// <summary>
		/// 功能名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="功能名称")]
		public virtual string FuncName{get ; set; }
		
		/// <summary>
		/// 功能键值
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="功能键值")]
		public virtual string FuncValue{get ; set; }
		
		/// <summary>
		/// 是否可用
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否可用",DefaultValue="1")]
		public virtual string IfAble{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPaFunction Clone()
        {
            return (RtPaFunction)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPaFunction Initial()
        {
            RtPaFunction m = new RtPaFunction();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfAble="1";
            return m;
        }
	}
	 
}


