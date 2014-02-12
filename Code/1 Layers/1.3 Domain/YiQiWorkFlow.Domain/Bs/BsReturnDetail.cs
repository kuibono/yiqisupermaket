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
	///表bs_return_detail的实体类(分店商品返货单_明细)
	///</summary>
	public class BsReturnDetail : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 返货单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="返货单号")]
		public virtual string ReNumber{get ; set; }
		
		/// <summary>
		/// 商品销售码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品销售码")]
		public virtual string GoodsBarCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 规格
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="规格")]
		public virtual string Specification{get ; set; }
		
		/// <summary>
		/// 包装单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="包装单位")]
		public virtual string PackUnitCode{get ; set; }
		
		/// <summary>
		/// 整件数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="整件数量",DefaultValue=0)]
		public virtual decimal PackQty{get ; set; }
		
		/// <summary>
		/// 包装系数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="包装系数",DefaultValue=1)]
		public virtual decimal PackCoef{get ; set; }
		
		/// <summary>
		/// 返货数量
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货数量",DefaultValue=0)]
		public virtual decimal ReturnQty{get ; set; }
		
		/// <summary>
		/// 返货单价
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货单价",DefaultValue=0)]
		public virtual decimal SupplyPrice{get ; set; }
		
		/// <summary>
		/// 返货金额
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="返货金额",DefaultValue=0)]
		public virtual decimal SupplyMoney{get ; set; }
		
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
		public BsReturnDetail Clone()
        {
            return (BsReturnDetail)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static BsReturnDetail Initial()
        {
            BsReturnDetail m = new BsReturnDetail();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PackQty=0M;
			m.PackCoef=1M;
			m.ReturnQty=0M;
			m.SupplyPrice=0M;
			m.SupplyMoney=0M;
            return m;
        }
	}
	 
}


