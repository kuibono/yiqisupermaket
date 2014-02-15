/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:27
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_pa_branch_warehouse的实体类(分店仓库设置)
	///</summary>
	public class BsPaBranchWarehouse : EntityGUIDBase, IAggregateRootGUID
	{
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
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsPaBranchWarehouse Clone()
        {
            return (BsPaBranchWarehouse)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsPaBranchWarehouse Initial()
        {
            BsPaBranchWarehouse m = new BsPaBranchWarehouse();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.WhArea=0M;
            return m;
        }
	}
	 
}


