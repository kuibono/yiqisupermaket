using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEWorkFlow.Domain.Basement
{
    /// <summary>
    /// 验证类型
    /// </summary>
    [Flags]
    public enum ValidateType
    {
        /// <summary>
        /// 字段或属性是否为空字串
        /// </summary>
        IsEmpty = 0x0001,
        /// <summary>
        /// 字段或属性的最小长度
        /// </summary>
        MinLength = 0x0002,
        /// <summary>
        /// 字段或属性的最大长度
        /// </summary>
        MaxLength = 0x0004,
        /// <summary>
        /// 字段或属性的值是否为数值型
        /// </summary>
        IsNumber = 0x0008,
        /// <summary>
        /// 字段或属性的值是否为时间类型
        /// </summary>
        IsDateTime = 0x0010,
        /// <summary>
        /// 字段或属性的值是否为正确的浮点类型
        /// </summary>
        IsDecimal = 0x0020,
        /// <summary>
        /// 字段或属性的值是否包含在指定的数据源数组中
        /// </summary>
        IsInCustomArray = 0x0040,
        /// <summary>
        /// 字段或属性的值是否为固定电话号码格式
        /// </summary>
        IsTelphone = 0x0080,
        /// <summary>
        /// 字段或属性的值是否为手机号码格式
        /// </summary>
        IsMobile = 0x0100
    }


    /// <summary>
    /// 为元素添加验证信息的特性类
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class ValidateAttribute : Attribute
    {
        /// <summary>
        /// 验证类型
        /// </summary>
        private ValidateType _validateType;
        /// <summary>
        /// 最小长度
        /// </summary>
        private int _minLength;
        /// <summary>
        /// 最大长度
        /// </summary>
        private int _maxLength;
        /// <summary>
        /// 自定义数据源 
        /// </summary>
        private string[] _customArray;



        /// <summary>
        /// 验证类型
        /// </summary>
        public ValidateType ValidateType
        {
            get { return this._validateType; }
        }

        /// <summary>
        /// 最小长度
        /// </summary>
        public int MinLength
        {
            get { return this._minLength; }
            set { this._minLength = value; }
        }

        /// <summary>
        /// 最大长度
        /// </summary>
        public int MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        private string _Name="";
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        /// <summary>
        /// 自定义数据源
        /// </summary>
        public string[] CustomArray
        {
            get { return this._customArray; }
            set { this._customArray = value; }
        }




        /// <summary>
        /// 指定采取何种验证方式来验证元素的有效性
        /// </summary>
        /// <param name="validateType"></param>
        public ValidateAttribute(ValidateType validateType)
        {
            this._validateType = validateType;
        }
    }

}
