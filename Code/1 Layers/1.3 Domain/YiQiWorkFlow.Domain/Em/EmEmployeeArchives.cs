/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:28
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Em
{
	///<summary>
	///表em_employee_archives的实体类(人员档案)
	///</summary>
	public class EmEmployeeArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 人员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员姓名")]
		public virtual string EmName{get ; set; }
		
		/// <summary>
		/// 曾用名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="曾用名")]
		public virtual string NameUsed{get ; set; }
		
		/// <summary>
		/// 出生日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="出生日期")]
		public virtual System.DateTime? Birthday{get ; set; }
		
		/// <summary>
		/// 性别
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="性别")]
		public virtual string Sex{get ; set; }
		
		/// <summary>
		/// 政治面貌编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="政治面貌编码")]
		public virtual string PoliticsCode{get ; set; }
		
		/// <summary>
		/// 民族编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="民族编码")]
		public virtual string NationCode{get ; set; }
		
		/// <summary>
		/// 学历编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="学历编码")]
		public virtual string EducationCode{get ; set; }
		
		/// <summary>
		/// 职称编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职称编码")]
		public virtual string ProfessionalTitleCode{get ; set; }
		
		/// <summary>
		/// 婚否
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="婚否")]
		public virtual string IfMarried{get ; set; }
		
		/// <summary>
		/// 籍贯
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="籍贯")]
		public virtual string NativePlace{get ; set; }
		
		/// <summary>
		/// 身份证号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="身份证号")]
		public virtual string Idcard{get ; set; }
		
		/// <summary>
		/// 就职日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="就职日期")]
		public virtual System.DateTime? AccedeDay{get ; set; }
		
		/// <summary>
		/// 家庭电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="家庭电话")]
		public virtual string FamilyPhone{get ; set; }
		
		/// <summary>
		/// 手机
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="手机")]
		public virtual string Handset{get ; set; }
		
		/// <summary>
		/// E-mail
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="E-mail")]
		public virtual string eMail{get ; set; }
		
		/// <summary>
		/// 家庭住址
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="家庭住址")]
		public virtual string FamilyAddress{get ; set; }
		
		/// <summary>
		/// 邮政编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="邮政编码")]
		public virtual string Postalcode{get ; set; }
		
		/// <summary>
		/// 毕业院校
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="毕业院校")]
		public virtual string GraduateAcademy{get ; set; }
		
		/// <summary>
		/// 毕业时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="毕业时间")]
		public virtual System.DateTime? GraduateDay{get ; set; }
		
		/// <summary>
		/// 部门编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="部门编码")]
		public virtual string dCode{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 职务编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="职务编码")]
		public virtual string DutyCode{get ; set; }
		
		/// <summary>
		/// 银行帐号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="银行帐号")]
		public virtual string BankAccount{get ; set; }
		
		/// <summary>
		/// 养老保险帐号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="养老保险帐号")]
		public virtual string PensionAccount{get ; set; }
		
		/// <summary>
		/// 状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="状态")]
		public virtual string EmState{get ; set; }
		
		/// <summary>
		/// 身高
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="身高")]
		public virtual decimal Stature{get ; set; }
		
		/// <summary>
		/// 体重
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="体重")]
		public virtual decimal Width{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public EmEmployeeArchives Clone()
        {
            return (EmEmployeeArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static EmEmployeeArchives Initial()
        {
            EmEmployeeArchives m = new EmEmployeeArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


