/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Sys
{
	///<summary>
	///表sys_print_design的实体类(打印模板设计)
	///</summary>
	public class SysPrintDesign : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 打印数据窗口
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="打印数据窗口")]
		public virtual string DwObject{get ; set; }
		
		/// <summary>
		/// 模板名称
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="模板名称")]
		public virtual string TemplateName{get ; set; }
		
		/// <summary>
		/// 是否主模板
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否主模板")]
		public virtual string IfMain{get ; set; }
		
		/// <summary>
		/// 数据对象
		/// </summary>
		[Validate(ValidateType.IsEmpty ,Name="数据对象")]
		public virtual string DataObject{get ; set; }
		
		/// <summary>
		/// 文本内容
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="文本内容")]
		public virtual string ObContent{get ; set; }
		
		/// <summary>
		/// 字体类型
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="字体类型")]
		public virtual string ObFontFace{get ; set; }
		
		/// <summary>
		/// 字体高度
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="字体高度")]
		public virtual decimal ObFontHeight{get ; set; }
		
		/// <summary>
		/// 字体粗细
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="字体粗细")]
		public virtual decimal ObFontWeight{get ; set; }
		
		/// <summary>
		/// 是否斜体
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否斜体")]
		public virtual string ObFontItalic{get ; set; }
		
		/// <summary>
		/// 是否下划线
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否下划线")]
		public virtual string ObFontUnderline{get ; set; }
		
		/// <summary>
		/// 字体颜色
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="字体颜色")]
		public virtual decimal ObColor{get ; set; }
		
		/// <summary>
		/// 是否隐藏
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否隐藏")]
		public virtual string IfVisible{get ; set; }
		
		/// <summary>
		/// x
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="x")]
		public virtual decimal Obx{get ; set; }
		
		/// <summary>
		/// y
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="y")]
		public virtual decimal Oby{get ; set; }
		
		/// <summary>
		/// 宽
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="宽")]
		public virtual decimal ObWidth{get ; set; }
		
		/// <summary>
		/// 高
		/// </summary>
		[Validate(ValidateType.IsDecimal ,Name="高")]
		public virtual decimal ObHeight{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public SysPrintDesign Clone()
        {
            return (SysPrintDesign)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysPrintDesign Initial()
        {
            SysPrintDesign m = new SysPrintDesign();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


