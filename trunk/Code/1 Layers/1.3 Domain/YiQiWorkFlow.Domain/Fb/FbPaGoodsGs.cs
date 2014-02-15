/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:29
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_pa_goods_gs的实体类(小类编码)
	///</summary>
	public class FbPaGoodsGs : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 中类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="中类编码")]
		public virtual string GmCode{get ; set; }
		
		/// <summary>
		/// 小类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="小类编码")]
		public virtual string GsCode{get ; set; }
		
		/// <summary>
		/// 小类名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="小类名称")]
		public virtual string GsName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaGoodsGs Clone()
        {
            return (FbPaGoodsGs)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaGoodsGs Initial()
        {
            FbPaGoodsGs m = new FbPaGoodsGs();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


