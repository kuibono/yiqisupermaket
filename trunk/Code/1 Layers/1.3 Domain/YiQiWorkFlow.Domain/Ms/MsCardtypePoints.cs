/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
using System.Collections.Generic;
namespace YiQiWorkFlow.Domain.Ms
{
	///<summary>
	///表ms_cardtype_points的实体类(卡积分)
	///</summary>
	public class MsCardtypePoints : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 卡类型编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="卡类型编码")]
		public virtual string CardCode{get ; set; }
		
		/// <summary>
		/// 商品类别
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="商品类别")]
		public virtual string GoodsClassCode{get ; set; }
		
		/// <summary>
		/// 类别名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="类别名称")]
		public virtual string GoodsClassName{get ; set; }
		
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
		
		protected override void Validate()
        {
        }
		///实体复制
		public MsCardtypePoints Clone()
        {
            return (MsCardtypePoints)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static MsCardtypePoints Initial()
        {
            MsCardtypePoints m = new MsCardtypePoints();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}

    public class MsCardtypePointsWithGoodsClassCodeEqualityCompare : IEqualityComparer<MsCardtypePoints>
    {
        public bool Equals(MsCardtypePoints x, MsCardtypePoints y)
        {
            return x.GoodsClassCode.Equals(y.GoodsClassCode);
        }

        public int GetHashCode(MsCardtypePoints obj)
        {
            int hCode = obj.CardCode.GetHashCode();
            return hCode.GetHashCode();
        }
    }
}