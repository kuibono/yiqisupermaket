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
	///表tg_pa_cars_charge的实体类(车停策略设置)
	///</summary>
	public class TgPaCarsCharge : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 车型编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车型编号")]
		public virtual string CarsTypeCode{get ; set; }
		
		/// <summary>
		/// 人数下限
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="人数下限")]
		public virtual decimal PersonLower{get ; set; }
		
		/// <summary>
		/// 人数上限
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="人数上限")]
		public virtual decimal PersonUpper{get ; set; }
		
		/// <summary>
		/// 停车费
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="停车费")]
		public virtual decimal StopCharge{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgPaCarsCharge Clone()
        {
            return (TgPaCarsCharge)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgPaCarsCharge Initial()
        {
            TgPaCarsCharge m = new TgPaCarsCharge();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


