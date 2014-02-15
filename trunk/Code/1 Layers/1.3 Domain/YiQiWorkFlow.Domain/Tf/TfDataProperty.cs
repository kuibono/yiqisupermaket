/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tf
{
	///<summary>
	///表tf_data_property的实体类(通讯配置表_字段)
	///</summary>
	public class TfDataProperty : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 属性编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="属性编号")]
		public virtual string PropertyId{get ; set; }
		
		/// <summary>
		/// 对象编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="对象编号")]
		public virtual string PropertyObject{get ; set; }
		
		/// <summary>
		/// 属性名称
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 100 ,Name="属性名称")]
		public virtual string PropertyName{get ; set; }
		
		/// <summary>
		/// 属性类型
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 100 ,Name="属性类型")]
		public virtual string PropertyType{get ; set; }
		
		/// <summary>
		/// 是否主键
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否主键")]
		public virtual bool PropertyIskey{get ; set; }
		
		/// <summary>
		/// 是否为空
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否为空")]
		public virtual bool PropertyIsnullable{get ; set; }
		
		/// <summary>
		/// 是否唯一
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否唯一")]
		public virtual bool PropertyIsunqueindex{get ; set; }
		
		/// <summary>
		/// 是否传输
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否传输")]
		public virtual bool PropertyIstransfer{get ; set; }
		
		/// <summary>
		/// 属性描述
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 200 ,Name="属性描述")]
		public virtual string PropertyDescription{get ; set; }
		
		/// <summary>
		/// 传输条件
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 200 ,Name="传输条件")]
		public virtual string PropertyCondition{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TfDataProperty Clone()
        {
            return (TfDataProperty)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TfDataProperty Initial()
        {
            TfDataProperty m = new TfDataProperty();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


