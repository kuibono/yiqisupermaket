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
	///表fb_pa_goods_gl的实体类(细类编码)
	///</summary>
	public class FbPaGoodsGl : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 小类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="小类编码")]
		public virtual string GsCode{get ; set; }
		
		/// <summary>
		/// 细类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="细类编码")]
		public virtual string GlCode{get ; set; }
		
		/// <summary>
		/// 细类名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="细类名称")]
		public virtual string GlName{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaGoodsGl Clone()
        {
            return (FbPaGoodsGl)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaGoodsGl Initial()
        {
            FbPaGoodsGl m = new FbPaGoodsGl();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


