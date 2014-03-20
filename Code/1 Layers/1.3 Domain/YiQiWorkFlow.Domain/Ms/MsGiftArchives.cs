/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_gift_archives的实体类(赠品档案管理)
	///</summary>
	public class MsGiftArchives : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品名称
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品名称")]
		public virtual string GoodsName{get ; set; }
		
		/// <summary>
		/// 兑换积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="兑换积分",DefaultValue=0)]
		public virtual decimal ExchangePoints{get ; set; }
		
		/// <summary>
		/// 有效期始
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="有效期始")]
		public virtual System.DateTime? BeginDate{get ; set; }
		
		/// <summary>
		/// 有效期止
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="有效期止")]
		public virtual System.DateTime? EndDate{get ; set; }
		
		/// <summary>
		/// 仓库编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="仓库编码")]
		public virtual string WhCode{get ; set; }
		
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
		public MsGiftArchives Clone()
        {
            return (MsGiftArchives)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsGiftArchives Initial()
        {
            MsGiftArchives m = new MsGiftArchives();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.ExchangePoints=0M;
            return m;
        }
	}
	 
}


