/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tf
{
	///<summary>
	///表tf_data_download的实体类(通讯临时表)
	///</summary>
	public class TfDataDownload : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 表名
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="表名")]
		public virtual string DownloadTablename{get ; set; }
		
		/// <summary>
		/// 店号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="店号")]
		public virtual string DownloadBranchcode{get ; set; }
		
		/// <summary>
		/// 键值
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="键值")]
		public virtual string DownloadKeyvalue{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TfDataDownload Clone()
        {
            return (TfDataDownload)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TfDataDownload Initial()
        {
            TfDataDownload m = new TfDataDownload();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


