/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_pa_goods_check_unit的实体类(核算单位编码)
	///</summary>
	public class FbPaGoodsCheckUnit : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 核算单位编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="核算单位编码")]
		public virtual string CheckUnitCode{get ; set; }
		
		/// <summary>
		/// 核算单位名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="核算单位名称")]
		public virtual string CheckUnitName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaGoodsCheckUnit Clone()
        {
            return (FbPaGoodsCheckUnit)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaGoodsCheckUnit Initial()
        {
            FbPaGoodsCheckUnit m = new FbPaGoodsCheckUnit();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


