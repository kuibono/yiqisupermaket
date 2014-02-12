/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_return_manage的实体类(分店商品返货单)
	///</summary>
	public class BsReturnManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 返货单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="返货单号")]
		public virtual string ReNumber{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 总部仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="总部仓库")]
		public virtual string WhCodeIn{get ; set; }
		
		/// <summary>
		/// 返货方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="返货方式")]
		public virtual string SpType{get ; set; }
		
		/// <summary>
		/// 返货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="返货日期")]
		public virtual System.DateTime? ReturnDate{get ; set; }
		
		/// <summary>
		/// 返货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货金额",DefaultValue=0)]
		public virtual decimal ReturnMoney{get ; set; }
		
		/// <summary>
		/// 是否结算
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否结算")]
		public virtual string IfBalance{get ; set; }
		
		/// <summary>
		/// 结算单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="结算单号")]
		public virtual string BaNumber{get ; set; }
		
		/// <summary>
		/// 结算金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算金额",DefaultValue=0)]
		public virtual decimal BaMoney{get ; set; }
		
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
		public BsReturnManage Clone()
        {
            return (BsReturnManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsReturnManage Initial()
        {
            BsReturnManage m = new BsReturnManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.ReturnMoney=0M;
			m.BaMoney=0M;
			m.IfExamine="0";
            return m;
        }
	}
	 
}


