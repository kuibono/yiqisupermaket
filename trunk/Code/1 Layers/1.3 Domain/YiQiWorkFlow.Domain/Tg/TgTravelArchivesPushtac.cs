/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/12 22:55:24
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tg
{
	///<summary>
	///表tg_travel_archives_pushtac的实体类(旅行社提成策略)
	///</summary>
	public class TgTravelArchivesPushtac : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 旅行社编号
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="旅行社编号")]
		public virtual string TaCode{get ; set; }
		
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
		/// 结算比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="结算比率",DefaultValue=0)]
		public virtual decimal PushRate{get ; set; }
		
		/// <summary>
		/// 挂帐比率
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="挂帐比率")]
		public virtual decimal AccountRate{get ; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[Validate(ValidateType.IsEmpty |ValidateType.MaxLength , MaxLength = 20 ,Name="")]
		public virtual string Id{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TgTravelArchivesPushtac Clone()
        {
            return (TgTravelArchivesPushtac)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TgTravelArchivesPushtac Initial()
        {
            TgTravelArchivesPushtac m = new TgTravelArchivesPushtac();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.PushRate=0M;
            return m;
        }
	}
	 
}


