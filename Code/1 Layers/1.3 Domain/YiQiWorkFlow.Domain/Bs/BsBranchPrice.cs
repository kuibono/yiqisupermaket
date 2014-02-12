/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Bs
{
	///<summary>
	///表bs_branch_price的实体类(分店商品价格)
	///</summary>
	public class BsBranchPrice : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
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
		/// 销售价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售价",DefaultValue=0)]
		public virtual decimal SalePrice{get ; set; }
		
		/// <summary>
		/// 会员价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="会员价",DefaultValue=0)]
		public virtual decimal VipPrice{get ; set; }
		
		/// <summary>
		/// 批发价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="批发价",DefaultValue=0)]
		public virtual decimal TradePrice{get ; set; }
		
		/// <summary>
		/// 修改时间
		/// </summary>
		[Validate(ValidateType.IsDateTime ,Name="修改时间")]
		public virtual System.DateTime? ModifyDate{get ; set; }
		
		/// <summary>
		/// 系统标识
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="系统标识")]
		public virtual string SysGuid{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public BsBranchPrice Clone()
        {
            return (BsBranchPrice)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsBranchPrice Initial()
        {
            BsBranchPrice m = new BsBranchPrice();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.SalePrice=0M;
			m.VipPrice=0M;
			m.TradePrice=0M;
            return m;
        }
	}
	 
}


