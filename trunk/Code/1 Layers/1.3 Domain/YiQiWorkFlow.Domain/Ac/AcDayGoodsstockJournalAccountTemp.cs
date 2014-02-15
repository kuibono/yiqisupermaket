/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:26
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ac
{
	///<summary>
	///表ac_day_goodsstock_journal_account_temp的实体类(总部商品进销存日帐临时表)
	///</summary>
	public class AcDayGoodsstockJournalAccountTemp : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 记账日期
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="记账日期")]
		public virtual string AcDate{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 库存数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存数量")]
		public virtual decimal StockQty{get ; set; }
		
		/// <summary>
		/// 库存金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存金额")]
		public virtual decimal StockMoney{get ; set; }
		
		/// <summary>
		/// 库存售价金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="库存售价金额")]
		public virtual decimal StockSaleMoney{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public AcDayGoodsstockJournalAccountTemp Clone()
        {
            return (AcDayGoodsstockJournalAccountTemp)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static AcDayGoodsstockJournalAccountTemp Initial()
        {
            AcDayGoodsstockJournalAccountTemp m = new AcDayGoodsstockJournalAccountTemp();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


