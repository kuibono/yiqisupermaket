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
	///表ms_cardtype_goods_points的实体类(商品积分)
	///</summary>
	public class MsCardtypeGoodsPoints : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 商品名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品名称")]
		public virtual string GoodsName{get ; set; }
		
		/// <summary>
		/// 消费基数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="消费基数")]
		public virtual decimal ExpendBase{get ; set; }
		
		/// <summary>
		/// 积分分值
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="积分分值")]
		public virtual decimal PointsValues{get ; set; }
		
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
		public MsCardtypeGoodsPoints Clone()
        {
            return (MsCardtypeGoodsPoints)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsCardtypeGoodsPoints Initial()
        {
            MsCardtypeGoodsPoints m = new MsCardtypeGoodsPoints();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


