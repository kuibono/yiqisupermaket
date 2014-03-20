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
	///表ms_madecard_manage的实体类(卡制作)
	///</summary>
	public class MsMadecardManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 制作日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="制作日期")]
		public virtual System.DateTime? MdDate{get ; set; }
		
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
		/// <summary>
		/// 开始卡号
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="开始卡号")]
		public virtual decimal BeginCardNumber{get ; set; }
		
		/// <summary>
		/// 终止卡号
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="终止卡号")]
		public virtual decimal EndCardNumber{get ; set; }
		
		/// <summary>
		/// 制作数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="制作数量")]
		public virtual decimal MadeQty{get ; set; }
		
		/// <summary>
		/// 生效方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="生效方式")]
		public virtual string EffectiveType{get ; set; }
		
		/// <summary>
		/// 生效日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="生效日期")]
		public virtual System.DateTime? EffectiveDate{get ; set; }
		
		/// <summary>
		/// 是否制卡
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否制卡")]
		public virtual string IfMade{get ; set; }
		
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
		public MsMadecardManage Clone()
        {
            return (MsMadecardManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsMadecardManage Initial()
        {
            MsMadecardManage m = new MsMadecardManage();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


