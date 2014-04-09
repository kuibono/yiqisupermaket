/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
    ///<summary>
    ///表ms_cardtype_manage的实体类(卡类型)
    ///</summary>
    public class MsCardtypeManage : EntityGUIDBase, IAggregateRootGUID
    {
        /// <summary>
        /// 卡类型名称
        /// </summary>
        [Validate(ValidateType.IsEmpty, Name = "卡类型名称")]
        public virtual string CardName { get; set; }

        /// <summary>
        /// 卡范围
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "卡范围")]
        public virtual string CardType { get; set; }

        /// <summary>
        /// 卡介质
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "卡介质")]
        public virtual string CardMedium { get; set; }

        /// <summary>
        /// 卡有效期
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "卡有效期")]
        public virtual decimal CardUsefulLife { get; set; }

        /// <summary>
        /// 积分有效期
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "积分有效期")]
        public virtual decimal PointsUsefulLife { get; set; }

        /// <summary>
        /// 办卡费用
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "办卡费用")]
        public virtual decimal TransactCharge { get; set; }

        /// <summary>
        /// 押金金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "押金金额")]
        public virtual decimal DepositMoney { get; set; }

        /// <summary>
        /// 是否会员价
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否会员价")]
        public virtual string IfVip { get; set; }

        /// <summary>
        /// 是否折扣
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否折扣")]
        public virtual string IfDiscount { get; set; }

        /// <summary>
        /// 折扣基数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "折扣基数")]
        public virtual decimal DiscountBase { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "折扣率")]
        public virtual decimal DiscountRate { get; set; }

        /// <summary>
        /// 是否积分
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否积分")]
        public virtual string IfPoints { get; set; }

        /// <summary>
        /// 消费基数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "消费基数")]
        public virtual decimal ExpendBase { get; set; }

        /// <summary>
        /// 积分分值
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "积分分值")]
        public virtual decimal PointsValues { get; set; }

        /// <summary>
        /// 会员生日积分
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "会员生日积分")]
        public virtual decimal BirthdayPoints { get; set; }

        /// <summary>
        /// 是否储值
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否储值")]
        public virtual string IfPrepaid { get; set; }

        /// <summary>
        /// 是否管理密码
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否管理密码")]
        public virtual string IfPrepaidPassword { get; set; }

        /// <summary>
        /// 限制次数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "限制次数", DefaultValue = -1)]
        public virtual decimal LimitTimes { get; set; }

        /// <summary>
        /// 预存金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "预存金额")]
        public virtual decimal PrestoreMoney { get; set; }

        /// <summary>
        /// 预设密码
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "预设密码")]
        public virtual string PrestorePw { get; set; }

        /// <summary>
        /// 最低充值金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "最低充值金额", DefaultValue = 0)]
        public virtual decimal PrepaidMin { get; set; }

        /// <summary>
        /// 最高充值金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "最高充值金额", DefaultValue = 0)]
        public virtual decimal PrepaidMax { get; set; }

        /// <summary>
        /// 是否积分转储值
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否积分转储值")]
        public virtual string IfPointToPrepaid { get; set; }

        /// <summary>
        /// 积分基数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "积分基数", DefaultValue = 0)]
        public virtual decimal PointsBase { get; set; }

        /// <summary>
        /// 转储值金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "转储值金额", DefaultValue = 0)]
        public virtual decimal PrepaidMoney { get; set; }

        /// <summary>
        /// 卡号前缀
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "卡号前缀")]
        public virtual string CardNumberPrefix { get; set; }

        /// <summary>
        /// 卡流水位数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "卡流水位数")]
        public virtual decimal CardNumberLen { get; set; }

        /// <summary>
        /// 随机位数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "随机位数", DefaultValue = 2)]
        public virtual decimal RandLen { get; set; }

        /// <summary>
        /// 累计积分，当前积分
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "累计积分，当前积分")]
        public virtual string UpgradeType { get; set; }

        /// <summary>
        /// 所需积分
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "所需积分", DefaultValue = 0)]
        public virtual decimal PointsNeeds { get; set; }

        /// <summary>
        /// 当前时可设
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "当前时可设", DefaultValue = "0")]
        public virtual string IfDeductPoints { get; set; }

        /// <summary>
        /// 是否自动升级
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否自动升级", DefaultValue = "0")]
        public virtual string IfAutoup { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Validate(ValidateType.IsDateTime, Name = "创建时间")]
        public virtual System.DateTime? CreateDate { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "操作员")]
        public virtual string Operator { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "审核人")]
        public virtual string Assessor { get; set; }

        /// <summary>
        /// 是否审核
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否审核", DefaultValue = "0")]
        public virtual string IfExamine { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [Validate(ValidateType.IsDateTime, Name = "审核时间")]
        public virtual System.DateTime? ExamineDate { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Validate(ValidateType.IsDateTime, Name = "操作时间")]
        public virtual System.DateTime? OperatorDate { get; set; }

        protected override void Validate()
        {
        }
        ///实体复制
        public MsCardtypeManage Clone()
        {
            return (MsCardtypeManage)this.MemberwiseClone();
        }
        /// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsCardtypeManage Initial()
        {
            MsCardtypeManage m = new MsCardtypeManage();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString();
            m.LimitTimes = -1M;
            m.PrepaidMin = 0M;
            m.PrepaidMax = 0M;
            m.PointsBase = 0M;
            m.PrepaidMoney = 0M;
            m.RandLen = 0M;
            m.PointsNeeds = 0M;
            m.IfDeductPoints = "0";
            m.IfAutoup = "0";
            m.IfExamine = "0";
            return m;
        }
    }
}