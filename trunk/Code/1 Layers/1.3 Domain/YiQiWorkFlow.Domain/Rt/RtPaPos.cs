/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:32
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_pa_pos的实体类(POS机设置)
	///</summary>
	public class RtPaPos : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// Pos名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="Pos名称")]
		public virtual string PosName{get ; set; }
		
		/// <summary>
		/// PosIP
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="PosIP")]
		public virtual string PosIp{get ; set; }
		
		/// <summary>
		/// Pos状态
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="Pos状态")]
		public virtual string PosState{get ; set; }
		
		/// <summary>
		/// 销售仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="销售仓库")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 客显型号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="客显型号")]
		public virtual string CdType{get ; set; }
		
		/// <summary>
		/// 客显端口
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="客显端口")]
		public virtual string CdPort{get ; set; }
		
		/// <summary>
		/// 打印机型号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="打印机型号")]
		public virtual string pType{get ; set; }
		
		/// <summary>
		/// 打印端口
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="打印端口")]
		public virtual string pPort{get ; set; }
		
		/// <summary>
		/// 打印宽度
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="打印宽度")]
		public virtual decimal pWidth{get ; set; }
		
		/// <summary>
		/// 打印机型号1
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="打印机型号1")]
		public virtual string pType1{get ; set; }
		
		/// <summary>
		/// 打印端口1
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="打印端口1")]
		public virtual string pPort1{get ; set; }
		
		/// <summary>
		/// 打印宽度1
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="打印宽度1")]
		public virtual decimal pWidth1{get ; set; }
		
		/// <summary>
		/// 钱箱型号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="钱箱型号")]
		public virtual string CbType{get ; set; }
		
		/// <summary>
		/// 钱箱端口
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="钱箱端口")]
		public virtual string CbPort{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPaPos Clone()
        {
            return (RtPaPos)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPaPos Initial()
        {
            RtPaPos m = new RtPaPos();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


