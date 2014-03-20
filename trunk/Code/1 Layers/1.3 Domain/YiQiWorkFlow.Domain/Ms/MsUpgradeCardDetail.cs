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
	///表ms_upgrade_card_detail的实体类(卡升级信息)
	///</summary>
	public class MsUpgradeCardDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 升级单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="升级单号")]
		public virtual string UpgradeNumber{get ; set; }
		
		/// <summary>
		/// 卡号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡号")]
		public virtual string CardNumber{get ; set; }
		
		/// <summary>
		/// 卡面明码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡面明码")]
		public virtual string SurfaceNumber{get ; set; }
		
		/// <summary>
		/// 原卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="原卡类型编码")]
		public virtual string CardCodeOld{get ; set; }
		
		/// <summary>
		/// 原卡类型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原卡类型名称")]
		public virtual string CardNameOld{get ; set; }
		
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
		/// <summary>
		/// 卡类型名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="卡类型名称")]
		public virtual string CardName{get ; set; }
		
		/// <summary>
		/// 当前可设
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前可设")]
		public virtual decimal DeductPoints{get ; set; }
		
		/// <summary>
		/// 累计积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="累计积分",DefaultValue=0)]
		public virtual decimal TotalPoints{get ; set; }
		
		/// <summary>
		/// 兑换积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="兑换积分",DefaultValue=0)]
		public virtual decimal ExchangePoints{get ; set; }
		
		/// <summary>
		/// 当前积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="当前积分",DefaultValue=0)]
		public virtual decimal CurrentPoints{get ; set; }
		
		/// <summary>
		/// 清零积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="清零积分")]
		public virtual decimal ClearPoints{get ; set; }
		
		/// <summary>
		/// 0待发1正常2挂失3废除
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="0待发1正常2挂失3废除")]
		public virtual string CardState{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsUpgradeCardDetail Clone()
        {
            return (MsUpgradeCardDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsUpgradeCardDetail Initial()
        {
            MsUpgradeCardDetail m = new MsUpgradeCardDetail();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.TotalPoints=0M;
			m.ExchangePoints=0M;
			m.CurrentPoints=0M;
            return m;
        }
	}
	 
}


