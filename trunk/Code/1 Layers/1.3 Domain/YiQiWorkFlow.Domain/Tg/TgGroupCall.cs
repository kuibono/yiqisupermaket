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
	///表tg_group_call的实体类(团队策略提醒)
	///</summary>
	public class TgGroupCall : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 流水单号
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.IsDecimal ,Name="流水单号")]
		public virtual decimal TgFlowNumber{get ; set; }
		
		/// <summary>
		/// 提醒类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="提醒类型")]
		public virtual string CallType{get ; set; }
		
		/// <summary>
		/// 编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="编码")]
		public virtual string ItemsCode{get ; set; }
		
		/// <summary>
		/// 名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="名称")]
		public virtual string ItemsName{get ; set; }
		
		/// <summary>
		/// 提醒内容
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="提醒内容")]
		public virtual string CallContent{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgGroupCall Clone()
        {
            return (TgGroupCall)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgGroupCall Initial()
        {
            TgGroupCall m = new TgGroupCall();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


