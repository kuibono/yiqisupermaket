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
	///表fb_pa_goods_gm的实体类(中类编码)
	///</summary>
	public class FbPaGoodsGm : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 大类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="大类编码")]
		public virtual string GbCode{get ; set; }
		
		/// <summary>
		/// 中类编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="中类编码")]
		public virtual string GmCode{get ; set; }
		
		/// <summary>
		/// 中类名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="中类名称")]
		public virtual string GmName{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbPaGoodsGm Clone()
        {
            return (FbPaGoodsGm)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbPaGoodsGm Initial()
        {
            FbPaGoodsGm m = new FbPaGoodsGm();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
        public int GetTableSerialNumber()
        {
            return GetTableSerialNumber("fb_pa_goods_gm");
        }
	}
	 
}


