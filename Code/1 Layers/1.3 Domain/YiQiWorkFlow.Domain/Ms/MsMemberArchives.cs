/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:30
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_member_archives的实体类(会员信息)
	///</summary>
	public class MsMemberArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 卡号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="卡号")]
		public virtual string CardNumber{get ; set; }
		
		/// <summary>
		/// 会员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="会员姓名")]
		public virtual string MsName{get ; set; }
		
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
		public MsMemberArchives Clone()
        {
            return (MsMemberArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsMemberArchives Initial()
        {
            MsMemberArchives m = new MsMemberArchives();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
}