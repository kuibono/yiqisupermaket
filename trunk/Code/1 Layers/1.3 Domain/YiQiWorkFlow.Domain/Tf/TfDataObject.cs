/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:33
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Tf
{
	///<summary>
	///表tf_data_object的实体类(通讯配置表_表名)
	///</summary>
	public class TfDataObject : EntityGUIDBase, IAggregateRootGUID
	{
		/// <summary>
		/// 对象编号
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="对象编号")]
		public virtual string ObjectId{get ; set; }
		
		/// <summary>
		/// 对象名称
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="对象名称")]
		public virtual string ObjectName{get ; set; }
		
		/// <summary>
		/// 对象主表
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 100 ,Name="对象主表")]
		public virtual string ObjectMain{get ; set; }
		
		/// <summary>
		/// 主表主键
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 100 ,Name="主表主键")]
		public virtual string ObjectMaincolumn{get ; set; }
		
		/// <summary>
		/// 主表外键
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 50 ,Name="主表外键")]
		public virtual string ObjectForeigncolumn{get ; set; }
		
		/// <summary>
		/// 是否插入
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否插入")]
		public virtual bool ObjectIsinsert{get ; set; }
		
		/// <summary>
		/// 是否删除
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否删除")]
		public virtual bool ObjectIsdelete{get ; set; }
		
		/// <summary>
		/// 是否更新
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否更新")]
		public virtual bool ObjectIsupdate{get ; set; }
		
		/// <summary>
		/// 冗余对象
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 100 ,Name="冗余对象")]
		public virtual string ObjectDump{get ; set; }
		
		/// <summary>
		/// 冗余对象主掀
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 50 ,Name="冗余对象主掀")]
		public virtual string ObjectKeycolumn{get ; set; }
		
		/// <summary>
		/// 冗余分店字段
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 50 ,Name="冗余分店字段")]
		public virtual string ObjectBranchcodecolumn{get ; set; }
		
		/// <summary>
		/// 是否删除冗余
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否删除冗余")]
		public virtual bool ObjectIsdeletedump{get ; set; }
		
		/// <summary>
		/// 传输对象描述
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 200 ,Name="传输对象描述")]
		public virtual string ObjectDescription{get ; set; }
		
		/// <summary>
		/// 传输方向
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="传输方向")]
		public virtual string ObjectDirection{get ; set; }
		
		/// <summary>
		/// 是否传输
		/// </summary>
		[Validate(ValidateType.NoValidate,Name="是否传输")]
		public virtual bool ObjectIstransfer{get ; set; }
		
		/// <summary>
		/// 传输条件
		/// </summary>
		[Validate(ValidateType.MaxLength , MaxLength = 200 ,Name="传输条件")]
		public virtual string ObjectCondition{get ; set; }
		
		/// <summary>
		/// 传输顺序
		/// </summary>
		[Validate(ValidateType.IsNumber ,Name="传输顺序")]
		public virtual int ObjectOrder{get ; set; }
		
		protected override void Validate()
        {
        }
		///实体复制
		public TfDataObject Clone()
        {
            return (TfDataObject)this.MemberwiseClone();
        }
		/// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static TfDataObject Initial()
        {
            TfDataObject m = new TfDataObject();
            m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            return m;
        }
	}
	 
}


