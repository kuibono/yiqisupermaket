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
	///表tg_pa_cars_type的实体类(车型设置)
	///</summary>
	public class TgPaCarsType : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 车型编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车型编号")]
		public virtual string CarsTypeCode{get ; set; }
		
		/// <summary>
		/// 车型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车型名称")]
		public virtual string CarsTypeName{get ; set; }
		
		/// <summary>
		/// 停车费
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="停车费")]
		public virtual decimal StopCharge{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgPaCarsType Clone()
        {
            return (TgPaCarsType)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgPaCarsType Initial()
        {
            TgPaCarsType m = new TgPaCarsType();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


