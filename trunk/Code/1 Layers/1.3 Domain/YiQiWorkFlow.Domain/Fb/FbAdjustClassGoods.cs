/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:23
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_adjust_class_goods的实体类(调商品所属类别_商品明细)
	///</summary>
	public class FbAdjustClassGoods : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 调整单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="调整单号")]
		public virtual string AdjustNumber{get ; set; }
		
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 原大类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原大类")]
		public virtual string GbCodeOld{get ; set; }
		
		/// <summary>
		/// 原中类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原中类")]
		public virtual string GmCodeOld{get ; set; }
		
		/// <summary>
		/// 原小类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原小类")]
		public virtual string GsCodeOld{get ; set; }
		
		/// <summary>
		/// 原细类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="原细类")]
		public virtual string GlCodeOld{get ; set; }
		
		/// <summary>
		/// 大类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="大类")]
		public virtual string GbCode{get ; set; }
		
		/// <summary>
		/// 中类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="中类")]
		public virtual string GmCode{get ; set; }
		
		/// <summary>
		/// 小类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="小类")]
		public virtual string GsCode{get ; set; }
		
		/// <summary>
		/// 细类
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="细类")]
		public virtual string GlCode{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbAdjustClassGoods Clone()
        {
            return (FbAdjustClassGoods)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbAdjustClassGoods Initial()
        {
            FbAdjustClassGoods m = new FbAdjustClassGoods();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


