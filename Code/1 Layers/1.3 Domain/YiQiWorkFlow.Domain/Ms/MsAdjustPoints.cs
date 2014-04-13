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
    ///表ms_adjust_points的实体类(积分调整管理)
    ///</summary>
    public class MsAdjustPoints : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// 调整日期
        /// </summary>
        [Validate(ValidateType.IsDateTime, Name = "调整日期")]
        public virtual System.DateTime? AdjustDate { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [Validate(ValidateType.IsEmpty, Name = "卡号")]
        public virtual string CardNumber { get; set; }

        /// <summary>
        /// 卡面明码
        /// </summary>
        [Validate(ValidateType.IsEmpty, Name = "卡面明码")]
        public virtual string SurfaceNumber { get; set; }

        /// <summary>
        /// 会员编码
        /// </summary>
        [Validate(ValidateType.IsEmpty, Name = "会员编码")]
        public virtual string MsCode { get; set; }

        /// <summary>
        /// 会员姓名
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "会员姓名")]
        public virtual string MsName { get; set; }

        /// <summary>
        /// 卡类型编码
        /// </summary>
        [Validate(ValidateType.IsEmpty, Name = "卡类型编码")]
        public virtual string CardCode { get; set; }

        /// <summary>
        /// 卡类型名称
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "卡类型名称")]
        public virtual string CardName { get; set; }

        /// <summary>
        /// 当前积分
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "当前积分", DefaultValue = 0)]
        public virtual decimal CurrentPoints { get; set; }

        /// <summary>
        /// 调整积分
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "调整积分", DefaultValue = 0)]
        public virtual decimal AdjustPoints { get; set; }

        /// <summary>
        /// 剩余积分
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "剩余积分")]
        public virtual decimal SurplusPoints { get; set; }

        /// <summary>
        /// 当前金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "当前金额")]
        public virtual decimal CurrentMoney { get; set; }

        /// <summary>
        /// 调整金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "调整金额")]
        public virtual decimal AdjustMoney { get; set; }

        /// <summary>
        /// 剩余金额
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "剩余金额")]
        public virtual decimal SurplusMoney { get; set; }

        /// <summary>
        /// 是否修改密码
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "是否修改密码")]
        public virtual string IfModifyPw { get; set; }

        /// <summary>
        /// 原密码
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "原密码")]
        public virtual string OldPassword { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "原密码")]
        public virtual string NewPassword { get; set; }

        /// <summary>
        /// 当前次数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "当前金额")]
        public virtual decimal CurrentTimes { get; set; }

        /// <summary>
        /// 调整次数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "调整次数")]
        public virtual decimal AdjustTimes { get; set; }

        /// <summary>
        /// 剩余次数
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "剩余金额")]
        public virtual decimal SurplusTimes { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "操作员")]
        public virtual string Operator { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Validate(ValidateType.IsDateTime, Name = "操作时间")]
        public virtual System.DateTime? OperatorDate { get; set; }

        protected override void Validate()
        {
        }
        ///实体复制
        public MsAdjustPoints Clone()
        {
            return (MsAdjustPoints)this.MemberwiseClone();
        }
        /// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsAdjustPoints Initial()
        {
            MsAdjustPoints m = new MsAdjustPoints();
            m.CurrentPoints = 0M;
            m.AdjustPoints = 0M;
            return m;
        }
    }
}