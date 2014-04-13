/*
*本代码由代码生成器自动生成，请不要更改此文件的任何代码。
*生成时间：2014/2/15 18:06:34
*/
using System;
using NSH.Core.Domain;
using YiQiWorkFlow.Domain.Basement;
namespace YiQiWorkFlow.Domain.Ws
{
    ///<summary>
    ///表ws_pa_customer_type的实体类(客户类型)
    ///</summary>
    public class WsPaCustomerType : EntityGUIDBase, IAggregateRootGUID
    {
        /// <summary>
        /// 类型编码
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "类型编码")]
        public virtual string CustTypeCode { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "类型名称")]
        public virtual string CustTypeName { get; set; }

        /// <summary>
        /// 批价方式
        /// </summary>
        [Validate(ValidateType.NoValidate, Name = "批价方式")]
        public virtual string WsType { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [Validate(ValidateType.IsDecimal, Name = "折扣")]
        public virtual decimal DiscountRate { get; set; }

        protected override void Validate()
        {
        }
        ///实体复制
        public WsPaCustomerType Clone()
        {
            return (WsPaCustomerType)this.MemberwiseClone();
        }
        /// <summary>
        /// 初始化实体
        /// </summary>
        /// <returns></returns>
        public static WsPaCustomerType Initial()
        {
            WsPaCustomerType m = new WsPaCustomerType();
            //m.Id = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000).ToString() ;
            m.WsType = "1";
            m.DiscountRate = 1;
            return m;
        }
    }
}