/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:31
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Op
{
	///<summary>
	///表op_pa_warehouse的实体类(仓库参数维护)
	///</summary>
	public class OpPaWarehouse : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
		/// <summary>
		/// 仓库名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库名称")]
		public virtual string WhName{get ; set; }
		
		/// <summary>
		/// 仓库面积
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="仓库面积",DefaultValue=0)]
		public virtual decimal WhArea{get ; set; }
		
		/// <summary>
		/// 是否主仓库
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否主仓库",DefaultValue="0")]
		public virtual string IfMainWh{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public OpPaWarehouse Clone()
        {
            return (OpPaWarehouse)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static OpPaWarehouse Initial()
        {
            OpPaWarehouse m = new OpPaWarehouse();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.WhArea=0M;
			m.IfMainWh="0";
            return m;
        }
	}
	 
}


