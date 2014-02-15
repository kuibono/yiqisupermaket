/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:31
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Pc
{
	///<summary>
	///表pc_return_manage的实体类(商品返货单)
	///</summary>
	public class PcReturnManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 采购单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="采购单号")]
		public virtual string PcNumber{get ; set; }
		
		/// <summary>
		/// 供货商编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="供货商编码")]
		public virtual string SupCode{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 采购形式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="采购形式",DefaultValue="1")]
		public virtual string PcForm{get ; set; }
		
		/// <summary>
		/// 部门编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="部门编码")]
		public virtual string dCode{get ; set; }
		
		/// <summary>
		/// 门店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="门店编码",DefaultValue="0000")]
		public virtual string bCode{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 返货日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="返货日期")]
		public virtual System.DateTime? ReturnDate{get ; set; }
		
		/// <summary>
		/// 是否出库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否出库",DefaultValue="0")]
		public virtual string IfPutout{get ; set; }
		
		/// <summary>
		/// 出库日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="出库日期")]
		public virtual System.DateTime? PutoutDate{get ; set; }
		
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
		public PcReturnManage Clone()
        {
            return (PcReturnManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static PcReturnManage Initial()
        {
            PcReturnManage m = new PcReturnManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PcForm="1";
			m.bCode="0000";
			m.IfPutout="0";
			m.IfExamine="0";
            return m;
        }
	}
	 
}


