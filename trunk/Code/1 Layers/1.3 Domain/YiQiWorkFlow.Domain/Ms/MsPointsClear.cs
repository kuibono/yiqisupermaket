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
	///表ms_points_clear的实体类(积分清零管理)
	///</summary>
	public class MsPointsClear : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// 清零日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="清零日期")]
		public virtual System.DateTime? ClearDate{get ; set; }

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
		/// 操作员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="操作员")]
		public virtual string Operator{get ; set; }
		
		/// <summary>
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsPointsClear Clone()
        {
            return (MsPointsClear)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsPointsClear Initial()
        {
            MsPointsClear m = new MsPointsClear();
            return m;
        }
	}
	 
}