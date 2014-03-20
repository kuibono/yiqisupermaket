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
	///表ms_exchange_detail的实体类(赠品兑换明细)
	///</summary>
	public class MsExchangeDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 兑换单号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="兑换单号")]
		public virtual string ExchangeNumber{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="序号")]
		public virtual decimal sNumber{get ; set; }
		
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
		/// 兑换数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="兑换数量")]
		public virtual decimal ExchangeQty{get ; set; }
		
		/// <summary>
		/// 兑换积分
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="兑换积分",DefaultValue=0)]
		public virtual decimal ExchangePoints{get ; set; }
		
		/// <summary>
		/// 积分合计
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="积分合计")]
		public virtual decimal PointsTotal{get ; set; }
		
		/// <summary>
		/// 含税毛利
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="含税毛利")]
		public virtual decimal GrossMoney{get ; set; }
		
		/// <summary>
		/// 不含税毛利
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="不含税毛利")]
		public virtual decimal NontaxGrossMoney{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsExchangeDetail Clone()
        {
            return (MsExchangeDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsExchangeDetail Initial()
        {
            MsExchangeDetail m = new MsExchangeDetail();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.ExchangePoints=0M;
            return m;
        }
	}
	 
}


