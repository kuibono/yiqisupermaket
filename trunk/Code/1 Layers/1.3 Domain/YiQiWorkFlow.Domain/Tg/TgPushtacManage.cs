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
	///表tg_pushtac_manage的实体类(人员提成策略)
	///</summary>
	public class TgPushtacManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 策略名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="策略名称")]
		public virtual string TacName{get ; set; }
		
		/// <summary>
		/// 提成比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="提成比率",DefaultValue=0)]
		public virtual decimal PushRate{get ; set; }
		
		/// <summary>
		/// 人次提成金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="人次提成金额")]
		public virtual decimal PushMoney{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgPushtacManage Clone()
        {
            return (TgPushtacManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgPushtacManage Initial()
        {
            TgPushtacManage m = new TgPushtacManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PushRate=0M;
            return m;
        }
	}
	 
}


