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
	///表rt_pa_saleset的实体类(销售设置)
	///</summary>
	public class RtPaSaleset : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 销售保留位数
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="销售保留位数",DefaultValue=2)]
		public virtual decimal Mantissa{get ; set; }
		
		/// <summary>
		/// 保留方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="保留方式")]
		public virtual string MantissaMode{get ; set; }
		
		/// <summary>
		/// 是否按结算键返回销售
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否按结算键返回销售")]
		public virtual string IfReturnSale{get ; set; }
		
		/// <summary>
		/// 是否零库存销售
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否零库存销售")]
		public virtual string IfNegativeStock{get ; set; }
		
		/// <summary>
		/// 是否退货选择付款方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否退货选择付款方式")]
		public virtual string IfReturnPayway{get ; set; }
		
		/// <summary>
		/// 是否必须录入营业员
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否必须录入营业员")]
		public virtual string IfSalesman{get ; set; }
		
		/// <summary>
		/// 是否必须录入柜台
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否必须录入柜台")]
		public virtual string IfCounter{get ; set; }
		
		/// <summary>
		/// 小票打印方式
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="小票打印方式")]
		public virtual string PrintType{get ; set; }
		
		/// <summary>
		/// 是否捆绑提示
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否捆绑提示")]
		public virtual string IfBind{get ; set; }
		
		/// <summary>
		/// 是否回车代替小计
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否回车代替小计")]
		public virtual string IfEntertopay{get ; set; }
		
		/// <summary>
		/// 是否回车代替RMB付款
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否回车代替RMB付款")]
		public virtual string IfEntertormb{get ; set; }
		
		/// <summary>
		/// 是否支持英文简码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否支持英文简码")]
		public virtual string IfEnglishSale{get ; set; }
		
		/// <summary>
		/// 标题1
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="标题1")]
		public virtual string Title1{get ; set; }
		
		/// <summary>
		/// 标题2
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="标题2")]
		public virtual string Title2{get ; set; }
		
		/// <summary>
		/// 标题3
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="标题3")]
		public virtual string Title3{get ; set; }
		
		/// <summary>
		/// 标题4
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="标题4")]
		public virtual string Title4{get ; set; }
		
		/// <summary>
		/// 标题5
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="标题5")]
		public virtual string Title5{get ; set; }
		
		/// <summary>
		/// 页尾1
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="页尾1")]
		public virtual string Pagefoot1{get ; set; }
		
		/// <summary>
		/// 页尾2
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="页尾2")]
		public virtual string Pagefoot2{get ; set; }
		
		/// <summary>
		/// 页尾3
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="页尾3")]
		public virtual string Pagefoot3{get ; set; }
		
		/// <summary>
		/// 页尾4
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="页尾4")]
		public virtual string Pagefoot4{get ; set; }
		
		/// <summary>
		/// 页尾5
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="页尾5")]
		public virtual string Pagefoot5{get ; set; }
		
		/// <summary>
		/// 是否打印企业名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印企业名称")]
		public virtual string IfEnName{get ; set; }
		
		/// <summary>
		/// 是否打印门店名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印门店名称")]
		public virtual string IfbName{get ; set; }
		
		/// <summary>
		/// 是否打印商品编码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印商品编码")]
		public virtual string IfGoodsCode{get ; set; }
		
		/// <summary>
		/// 是否打印商品销售码
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印商品销售码")]
		public virtual string IfGoodsBarCode{get ; set; }
		
		/// <summary>
		/// 是否打印商品名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印商品名称")]
		public virtual string IfGoodsName{get ; set; }
		
		/// <summary>
		/// 是否打印商品简称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印商品简称")]
		public virtual string IfGoodsSubName{get ; set; }
		
		/// <summary>
		/// 是否打印单位
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印单位")]
		public virtual string IfPackUnit{get ; set; }
		
		/// <summary>
		/// 是否打印储值卡余额
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否打印储值卡余额")]
		public virtual string IfPrepaid{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public RtPaSaleset Clone()
        {
            return (RtPaSaleset)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static RtPaSaleset Initial()
        {
            RtPaSaleset m = new RtPaSaleset();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
			m.Mantissa=2M;
            return m;
        }
	}
	 
}


