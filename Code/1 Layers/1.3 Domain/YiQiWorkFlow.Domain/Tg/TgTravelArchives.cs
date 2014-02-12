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
	///表tg_travel_archives的实体类(旅行社档案)
	///</summary>
	public class TgTravelArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 旅行社编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="旅行社编号")]
		public virtual string TaCode{get ; set; }
		
		/// <summary>
		/// 旅行社名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="旅行社名称")]
		public virtual string TaName{get ; set; }
		
		/// <summary>
		/// 拼音码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="拼音码")]
		public virtual string PyCode{get ; set; }
		
		/// <summary>
		/// 旅行社类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="旅行社类型")]
		public virtual string TaTypeCode{get ; set; }
		
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
		
		/// <summary>
		/// 人次挂帐金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="人次挂帐金额")]
		public virtual decimal PushMoneyAccount{get ; set; }
		
		/// <summary>
		/// 旅行社返利比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="旅行社返利比率")]
		public virtual decimal TaReturnsRate{get ; set; }
		
		/// <summary>
		/// 负责人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="负责人")]
		public virtual string Functionary{get ; set; }
		
		/// <summary>
		/// 负责人电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="负责人电话")]
		public virtual string FunctionaryPhone{get ; set; }
		
		/// <summary>
		/// 联系人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系人")]
		public virtual string Linkman{get ; set; }
		
		/// <summary>
		/// 联系人电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系人电话")]
		public virtual string ContactPhone{get ; set; }
		
		/// <summary>
		/// 联系地址
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系地址")]
		public virtual string ContactAddress{get ; set; }
		
		/// <summary>
		/// 办公电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="办公电话")]
		public virtual string OfficePhone{get ; set; }
		
		/// <summary>
		/// 传真
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="传真")]
		public virtual string FaxPhone{get ; set; }
		
		/// <summary>
		/// 邮箱
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="邮箱")]
		public virtual string eMail{get ; set; }
		
		/// <summary>
		/// 邮政编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="邮政编码")]
		public virtual string Postalcode{get ; set; }
		
		/// <summary>
		/// 开户行
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="开户行")]
		public virtual string OpenAccount{get ; set; }
		
		/// <summary>
		/// 帐号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="帐号")]
		public virtual string BankAccount{get ; set; }
		
		/// <summary>
		/// 税号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="税号")]
		public virtual string TaxNumber{get ; set; }
		
		/// <summary>
		/// 打印方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="打印方式")]
		public virtual string PrintType{get ; set; }
		
		/// <summary>
		/// 是否打印
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印")]
		public virtual string IfPrint{get ; set; }
		
		/// <summary>
		/// 车停结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车停结算")]
		public virtual string CarsType{get ; set; }
		
		/// <summary>
		/// 备注
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="备注")]
		public virtual string Comment{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgTravelArchives Clone()
        {
            return (TgTravelArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgTravelArchives Initial()
        {
            TgTravelArchives m = new TgTravelArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PushRate=0M;
            return m;
        }
	}
	 
}


