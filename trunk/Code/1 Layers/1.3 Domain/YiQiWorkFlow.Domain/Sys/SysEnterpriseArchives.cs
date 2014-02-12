/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Sys
{
	///<summary>
	///表sys_enterprise_archives的实体类(企业设置)
	///</summary>
	public class SysEnterpriseArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 企业编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业编码")]
		public virtual string EnCode{get ; set; }
		
		/// <summary>
		/// 企业名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业名称")]
		public virtual string EnName{get ; set; }
		
		/// <summary>
		/// 企业简称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业简称")]
		public virtual string EnComName{get ; set; }
		
		/// <summary>
		/// 企业类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业类型",DefaultValue="1")]
		public virtual string EnType{get ; set; }
		
		/// <summary>
		/// 企业性质
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="企业性质")]
		public virtual string EnCharacter{get ; set; }
		
		/// <summary>
		/// 经营面积
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="经营面积")]
		public virtual decimal DealArea{get ; set; }
		
		/// <summary>
		/// 注册地址
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="注册地址")]
		public virtual string RegisterAddress{get ; set; }
		
		/// <summary>
		/// 系统版本
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统版本")]
		public virtual string CurrentVersion{get ; set; }
		
		/// <summary>
		/// 最后更新版本
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="最后更新版本")]
		public virtual string LastVersion{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysEnterpriseArchives Clone()
        {
            return (SysEnterpriseArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysEnterpriseArchives Initial()
        {
            SysEnterpriseArchives m = new SysEnterpriseArchives();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.EnType="1";
            return m;
        }
	}
	 
}


