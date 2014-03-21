/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/3/21 21:48:20
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Sys
{
    ///<summary>
    ///表sys_SerialNumber的实体类()
    ///</summary>
    public class SysSerialnumber : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// 
        /// </summary>
        [Validate(ValidateType.MaxLength, MaxLength = 50, Name = "")]
        public virtual string Tablename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Validate(ValidateType.IsNumber, Name = "")]
        public virtual long SerialNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Validate(ValidateType.MaxLength, MaxLength = 50, Name = "")]
        public virtual string SeriaColumn { get; set; }

        protected override void Validate()
        {
        }
        ///实体复制
        public SysSerialnumber Clone()
        {
            return (SysSerialnumber)this.MemberwiseClone();
        }
        /// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static SysSerialnumber Initial()
        {
            SysSerialnumber m = new SysSerialnumber();
            return m;
        }
    }

}


