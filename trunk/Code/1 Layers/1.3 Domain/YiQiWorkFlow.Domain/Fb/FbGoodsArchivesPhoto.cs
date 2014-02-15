/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:28
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Fb
{
	///<summary>
	///表fb_goods_archives_photo的实体类(商品视图表)
	///</summary>
	public class FbGoodsArchivesPhoto : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 商品编码
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="商品编码")]
		public virtual string GoodsCode{get ; set; }
		
		/// <summary>
		/// 序号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="序号")]
		public virtual string sNumber{get ; set; }
		
		/// <summary>
		/// 图片
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="图片")]
		public virtual byte[] Photo{get ; set; }
		
		/// <summary>
		/// 图片类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="图片类型")]
		public virtual string PhotoType{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public FbGoodsArchivesPhoto Clone()
        {
            return (FbGoodsArchivesPhoto)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static FbGoodsArchivesPhoto Initial()
        {
            FbGoodsArchivesPhoto m = new FbGoodsArchivesPhoto();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


