using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSH.Core.Domain;
using System.Collections.ObjectModel;
using NSH.Core.Domain.Validate;
using System.Reflection;

namespace NSH.Core.Domain
{
    public abstract class EntityBase : IEntity
    {
        private int _id;
        private List<BrokenRule> brokenRules;



        protected EntityBase()
        {
            this.brokenRules = new List<BrokenRule>();
        }

        public virtual int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        #region miniui 数据行状态
        public virtual string _state { get; set; }

        public virtual bool IsDelete
        {
            get
            {
                return _state == "removed";
            }
        }
        public virtual bool IsAdded
        {
            get
            {
                return _state == "added";
            }
        }
        public virtual bool IsUpdated
        {
            get
            {
                return _state == "modified";
            }
        }
        #endregion

        #region Validation and Broken Rules

        protected abstract void Validate();

        protected List<BrokenRule> BrokenRules
        {
            get { return this.brokenRules; }
        }
        public bool HaveId
        {
            get { return Id > 0; }
        }
        public ReadOnlyCollection<BrokenRule> GetBrokenRules()
        {
            this.brokenRules.Clear();
            this.Validate();
            return this.brokenRules.AsReadOnly();
        }

        protected void AddBrokenRule(string propertyName, string message)
        {
            this.brokenRules.Add(new BrokenRule(propertyName, message));
        }

        #endregion

        #region Equality Tests


        public override bool Equals(object entity)
        {
            return entity != null
                && entity is EntityBase
                && this == (EntityBase)entity;
        }


        public static bool operator ==(EntityBase base1,
            EntityBase base2)
        {
            if ((object)base1 == null && (object)base2 == null)
            {
                return true;
            }

            if ((object)base1 == null || (object)base2 == null)
            {
                return false;
            }

            if (base1.Id != base2.Id)
            {
                return false;
            }

            return true;
        }

        public static bool operator !=(EntityBase base1,
            EntityBase base2)
        {
            return (!(base1 == base2));
        }


        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        #endregion

        /// <summary>
        /// 验证实体对象的所有带验证特性的元素  并返回验证结果  如果返回结果为String.Empty 则说明元素符合验证要求
        /// </summary>
        /// <param name="entityObject">实体对象</param>
        /// <returns></returns>
        public ValidateResult GetValidateResult()
        {
            object entityObject = this;

            ValidateResult result = new ValidateResult();

            if (entityObject == null)
                throw new ArgumentNullException("entityObject");

            Type type = entityObject.GetType();
            PropertyInfo[] properties = type.GetProperties();

            string validateResult = string.Empty;

            foreach (PropertyInfo property in properties)
            {
                //获取验证特性
                object[] validateContent = property.GetCustomAttributes(typeof(ValidateAttribute), true);

                string name = "";
                try
                {
                    name = ((ValidateAttribute)(validateContent[0])).Name;
                }
                catch { }
                if (string.IsNullOrEmpty(name))
                {
                    name = property.Name;
                }

                if (validateContent != null)
                {
                    //获取属性的值
                    object value = property.GetValue(entityObject, null);

                    foreach (ValidateAttribute validateAttribute in validateContent)
                    {
                        switch (validateAttribute.ValidateType)
                        {
                            //验证元素是否为空字串
                            case ValidateType.IsEmpty:
                                if (null == value || value.ToString().Length < 1)
                                    result.AddMessage(string.Format("{0} 不能为空", name));
                                break;
                            //验证元素的长度是否小于指定最小长度
                            case ValidateType.MinLength:
                                if (null == value || value.ToString().Length < 1) break;
                                if (value.ToString().Length < validateAttribute.MinLength)
                                    result.AddMessage(string.Format("{0} 的长度不能小于 {1}", name, validateAttribute.MinLength));
                                break;
                            //验证元素的长度是否大于指定最大长度
                            case ValidateType.MaxLength:
                                if (null == value || value.ToString().Length < 1) break;
                                if (value.ToString().Length > validateAttribute.MaxLength)
                                    result.AddMessage(string.Format("{0} 的长度不能大于{1}", name, validateAttribute.MaxLength));
                                break;
                            //验证元素的长度是否符合指定的最大长度和最小长度的范围
                            case ValidateType.MinLength | ValidateType.MaxLength:
                                if (null == value || value.ToString().Length < 1) break;
                                if (value.ToString().Length > validateAttribute.MaxLength || value.ToString().Length < validateAttribute.MinLength)
                                    result.AddMessage(string.Format("{0} 不符合指定的最小长度和最大长度的范围,应该在 {1} 与 {2} 之间", name, validateAttribute.MinLength, validateAttribute.MaxLength));
                                break;
                            //验证元素的值是否为值类型
                            case ValidateType.IsNumber:
                                if (null == value || value.ToString().Length < 1) break;
                                if (!System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), @"^\d+$"))
                                    result.AddMessage(string.Format("{0} 的值不是数字类型", name));
                                break;
                            //验证元素的值是否为正确的时间格式
                            case ValidateType.IsDateTime:
                                if (null == value || value.ToString().Length < 1) break;
                                if (!System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), @"(\d{2,4})[-/]?([0]?[1-9]|[1][12])[-/]?([0][1-9]|[12]\d|[3][01])\s*([01]\d|[2][0-4])?[:]?([012345]?\d)?[:]?([012345]?\d)?"))
                                    result.AddMessage(string.Format("{0} 不是正确的时间格式", name));
                                break;
                            //验证元素的值是否为正确的浮点格式
                            case ValidateType.IsDecimal:
                                if (null == value || value.ToString().Length < 1) break;
                                if (!System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), @"^\d+[.]?\d+$"))
                                    result.AddMessage(string.Format("{0} 不是正确的金额格式", name));
                                break;
                            //验证元素的值是否在指定的数据源中
                            case ValidateType.IsInCustomArray:
                                if (null == value || value.ToString().Length < 1) break;
                                if (null == validateAttribute.CustomArray || validateAttribute.CustomArray.Length < 1)
                                    result.AddMessage(string.Format("系统内部错误：{0} 指定的数据源为空或没有数据", name));

                                bool isHas = Array.Exists<string>(validateAttribute.CustomArray, delegate(string str)
                                {
                                    return str == value.ToString();
                                }
                                );

                                if (!isHas)
                                    result.AddMessage(string.Format("{0} 的值设定不正确 , 应该为 {1} 中的一种", name, string.Join(",", validateAttribute.CustomArray)));
                                break;
                            //验证元素的值是否为固定电话号码格式
                            case ValidateType.IsTelphone:
                                if (null == value || value.ToString().Length < 1) break;
                                if (!System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), @"^(\d{3,4}-)?\d{6,8}$"))
                                    result.AddMessage(string.Format("{0} 不是正确的固定电话号码格式", name));
                                break;
                            //验证元素的值是否为手机号码格式
                            case ValidateType.IsMobile:
                                if (null == value || value.ToString().Length < 1) break;
                                if (!System.Text.RegularExpressions.Regex.IsMatch(value.ToString(), @"^[1]+[3,5]+\d{9}$"))
                                    result.AddMessage(string.Format("元素 {0} 不是正确的手机号码格式", name));
                                break;
                            //验证元素是否为空且符合指定的最小长度
                            case ValidateType.IsEmpty | ValidateType.MinLength:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.MinLength;
                            //验证元素是否为空且符合指定的最大长度
                            case ValidateType.IsEmpty | ValidateType.MaxLength:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.MaxLength;
                            //验证元素是否为空且符合指定的长度范围
                            case ValidateType.IsEmpty | ValidateType.MinLength | ValidateType.MaxLength:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.MinLength | ValidateType.MaxLength;
                            //验证元素是否为空且值为数值型
                            case ValidateType.IsEmpty | ValidateType.IsNumber:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.IsNumber;
                            //验证元素是否为空且值为浮点型
                            case ValidateType.IsEmpty | ValidateType.IsDecimal:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.IsDecimal;
                            //验证元素是否为空且值为时间类型
                            case ValidateType.IsEmpty | ValidateType.IsDateTime:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.IsDateTime;
                            //验证元素是否为空且值在指定的数据源中
                            case ValidateType.IsEmpty | ValidateType.IsInCustomArray:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.IsInCustomArray;
                            //验证元素是否为空且值为固定电话号码格式
                            case ValidateType.IsEmpty | ValidateType.IsTelphone:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.IsTelphone;
                            //验证元素是否为空且值为手机号码格式
                            case ValidateType.IsEmpty | ValidateType.IsMobile:
                                if (null == value || value.ToString().Length < 1) goto case ValidateType.IsEmpty;
                                goto case ValidateType.IsMobile;
                            default:
                                break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(validateResult))
                    break;
            }

            return result;
        }

        public string GetValidateMessage()
        {
            StringBuilder sb = new StringBuilder();

            var result = GetValidateResult();
            if (result.IsSuccess == false)
            {
                foreach (string msg in result.Messages)
                {
                    sb.AppendLine(msg);
                }
            }
            return sb.ToString();
        }
    }
}
