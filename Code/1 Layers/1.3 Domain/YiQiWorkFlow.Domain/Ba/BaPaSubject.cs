/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ba
{
	///<summary>
	///表ba_pa_subject的实体类(财务科目设置)
	///</summary>
	public class BaPaSubject : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 业务类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="业务类型")]
		public virtual string OperatType{get ; set; }
		
		/// <summary>
		/// 经营方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="经营方式")]
		public virtual string OpCode{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 借贷选择
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="借贷选择")]
		public virtual string DebitCredit{get ; set; }
		
		/// <summary>
		/// 税率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="税率")]
		public virtual decimal InputTax{get ; set; }
		
		/// <summary>
		/// 科目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="科目")]
		public virtual string SubjectCode{get ; set; }
		
		/// <summary>
		/// 是否含税
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否含税")]
		public virtual string IfTax{get ; set; }
		
		/// <summary>
		/// 是否部门
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否部门")]
		public virtual string IfDept{get ; set; }
		
		/// <summary>
		/// 是否供货商
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否供货商")]
		public virtual string IfSupplier{get ; set; }
		
		/// <summary>
		/// 是否项目
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否项目")]
		public virtual string IfKind{get ; set; }
		
		/// <summary>
		/// 是否税率
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否税率")]
		public virtual string IfRate{get ; set; }
		
		/// <summary>
		/// 是否金额反写
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否金额反写")]
		public virtual string IfAntitone{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BaPaSubject Clone()
        {
            return (BaPaSubject)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BaPaSubject Initial()
        {
            BaPaSubject m = new BaPaSubject();
            return m;
        }
	}
	 
}


