/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_upgrade_card_manage的实体类(卡升级)
	///</summary>
	public class MsUpgradeCardManage : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 升级单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="升级单号")]
		public virtual string UpgradeNumber{get ; set; }
		
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 升级日期
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="升级日期")]
		public virtual System.DateTime? UpgradeDate{get ; set; }
		
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
		/// 操作时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="操作时间")]
		public virtual System.DateTime? OperatorDate{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsUpgradeCardManage Clone()
        {
            return (MsUpgradeCardManage)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsUpgradeCardManage Initial()
        {
            MsUpgradeCardManage m = new MsUpgradeCardManage();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


