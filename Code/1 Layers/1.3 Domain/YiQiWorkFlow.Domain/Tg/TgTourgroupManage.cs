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
	///表tg_tourgroup_manage的实体类(团队购物管理)
	///</summary>
	public class TgTourgroupManage : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 团队编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队编号")]
		public virtual string GroupNumber{get ; set; }
		
		/// <summary>
		/// 开团日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="开团日期")]
		public virtual System.DateTime? GroupDate{get ; set; }
		
		/// <summary>
		/// 团队类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="团队类型")]
		public virtual string GroupTypeCode{get ; set; }
		
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
		/// 旅行社类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="旅行社类型")]
		public virtual string TaTypeCode{get ; set; }
		
		/// <summary>
		/// 导游编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="导游编号")]
		public virtual string GuideCode{get ; set; }
		
		/// <summary>
		/// 导游名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="导游名称")]
		public virtual string GuideName{get ; set; }
		
		/// <summary>
		/// 导游策略编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="导游策略编码")]
		public virtual string GuideTacCode{get ; set; }
		
		/// <summary>
		/// 导游提成比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="导游提成比率",DefaultValue=0)]
		public virtual decimal GuidePushRate{get ; set; }
		
		/// <summary>
		/// 导游人次提成
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="导游人次提成")]
		public virtual decimal GuidePushMoney{get ; set; }
		
		/// <summary>
		/// 团队人数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="团队人数")]
		public virtual decimal PersonTimes{get ; set; }
		
		/// <summary>
		/// 购物折扣
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="购物折扣")]
		public virtual decimal DiscountRate{get ; set; }
		
		/// <summary>
		/// 讲解员策略编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="讲解员策略编码")]
		public virtual string ExpostorTacCode{get ; set; }
		
		/// <summary>
		/// 讲解员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="讲解员")]
		public virtual string Expostor{get ; set; }
		
		/// <summary>
		/// 讲解员提成
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="讲解员提成")]
		public virtual decimal ExpostorPushRate{get ; set; }
		
		/// <summary>
		/// 讲解员人次提成
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="讲解员人次提成")]
		public virtual decimal ExpostorPushMoney{get ; set; }
		
		/// <summary>
		/// 司机
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="司机")]
		public virtual string Driver{get ; set; }
		
		/// <summary>
		/// 车牌号码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车牌号码")]
		public virtual string LicensePlate{get ; set; }
		
		/// <summary>
		/// 车队
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="车队")]
		public virtual string CarsGroup{get ; set; }
		
		/// <summary>
		/// 汽车型号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="汽车型号")]
		public virtual string CarsTypeCode{get ; set; }
		
		/// <summary>
		/// 停车费
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="停车费")]
		public virtual decimal StopCharge{get ; set; }
		
		/// <summary>
		/// 顾客来源
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="顾客来源")]
		public virtual string CustomerFrom{get ; set; }
		
		/// <summary>
		/// 备注
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="备注")]
		public virtual string Comment{get ; set; }
		
		/// <summary>
		/// 创建时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="创建时间")]
		public virtual System.DateTime? CreateDate{get ; set; }
		
		/// <summary>
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 审核人
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="审核人")]
		public virtual string Assessor{get ; set; }
		
		/// <summary>
		/// 是否审核
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否审核",DefaultValue="0")]
		public virtual string IfExamine{get ; set; }
		
		/// <summary>
		/// 审核时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="审核时间")]
		public virtual System.DateTime? ExamineDate{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgTourgroupManage Clone()
        {
            return (TgTourgroupManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgTourgroupManage Initial()
        {
            TgTourgroupManage m = new TgTourgroupManage();
			m.GuidePushRate=0M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


