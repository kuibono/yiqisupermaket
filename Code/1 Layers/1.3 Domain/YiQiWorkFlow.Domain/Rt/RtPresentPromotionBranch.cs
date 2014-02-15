/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:32
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Rt
{
	///<summary>
	///表rt_present_promotion_branch的实体类(馈赠促销_分店)
	///</summary>
	public class RtPresentPromotionBranch : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 促销单号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="促销单号")]
		public virtual string SpNumber{get ; set; }
		
		/// <summary>
		/// 分店编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="分店编码")]
		public virtual string bCode{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPresentPromotionBranch Clone()
        {
            return (RtPresentPromotionBranch)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPresentPromotionBranch Initial()
        {
            RtPresentPromotionBranch m = new RtPresentPromotionBranch();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


