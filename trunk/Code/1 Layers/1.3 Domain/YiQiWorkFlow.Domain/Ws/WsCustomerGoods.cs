/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ws
{
	///<summary>
	///表ws_customer_goods的实体类(客户商品)
	///</summary>
	public class WsCustomerGoods : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 客户编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="客户编码")]
		public virtual string CustCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="批发价")]
		public virtual decimal TradePrice{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public WsCustomerGoods Clone()
        {
            return (WsCustomerGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static WsCustomerGoods Initial()
        {
            WsCustomerGoods m = new WsCustomerGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


