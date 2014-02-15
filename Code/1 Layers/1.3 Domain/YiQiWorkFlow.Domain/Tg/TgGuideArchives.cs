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
	///表tg_guide_archives的实体类(导游人员信息)
	///</summary>
	public class TgGuideArchives : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 人员姓名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员姓名")]
		public virtual string GuideName{get ; set; }
		
		/// <summary>
		/// 拼音码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="拼音码")]
		public virtual string PyCode{get ; set; }
		
		/// <summary>
		/// 人员职业
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员职业")]
		public virtual string GuideType{get ; set; }
		
		/// <summary>
		/// 人员证件
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="人员证件")]
		public virtual string GuideId{get ; set; }
		
		/// <summary>
		/// 联系人电话
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="联系人电话")]
		public virtual string ContactPhone{get ; set; }
		
		/// <summary>
		/// 所属旅行社
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="所属旅行社")]
		public virtual string TaCode{get ; set; }
		
		/// <summary>
		/// 旅行社名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="旅行社名称")]
		public virtual string TaName{get ; set; }
		
		/// <summary>
		/// 策略编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="策略编码")]
		public virtual string TacCode{get ; set; }
		
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
		/// 车牌号码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车牌号码")]
		public virtual string LicensePlate{get ; set; }
		
		/// <summary>
		/// 备注
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="备注")]
		public virtual string Comment{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgGuideArchives Clone()
        {
            return (TgGuideArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgGuideArchives Initial()
        {
            TgGuideArchives m = new TgGuideArchives();
			m.PushRate=0M;
            return m;
        }
	}
	 
}


