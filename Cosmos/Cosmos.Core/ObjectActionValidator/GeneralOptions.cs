using Cosmos.Core.Extension;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.Core.ObjectActionValidator
{
    public class GeneralOptions
    {
        public GeneralOptions(ValidatorGeneral generalName,string CNName,Func<object, ObjectValidatorResult> customerValidator)
        {
            this.CNName = CNName;
            this.CustomerValidator = customerValidator;
            this.Name = generalName.ToString().ToLower();
        }
        public GeneralOptions(ValidatorGeneral generalName, string CNName)
        {
            this.Name = generalName.ToString().ToLower();
            this.CNName = CNName;
            this.ParamType = ParamType.String;
        }
        public GeneralOptions(ValidatorGeneral generalName, string CNName, ParamType type)
        {
            this.Name = generalName.ToString().ToLower();
            this.CNName = CNName;
            this.ParamType = ParamType.String;
        }
        public GeneralOptions(ValidatorGeneral generalName, string CNName, int? min, int? max)
        {
            this.Name = generalName.ToString().ToLower();
            this.CNName = CNName;
            this.ParamType = ParamType.String;
            this.Min = min;
            this.Max = max;
        }

        public GeneralOptions(ValidatorGeneral generalName, string CNName, ParamType type, int? min, int? max)
        {
            this.Name = generalName.ToString().ToLower();
            this.CNName = CNName;
            this.ParamType = type;
            this.Min = min;
            this.Max = max;
        }

        public Func<object, ObjectValidatorResult> CustomerValidator;

        // 方法上的参数名
        public string Name { get; set; }

        public string CNName { get; set; }

        // 参数类型
        public ParamType ParamType { get; set; }

        //数字为最小值, 字符串为最小长度
        public int?  Min { get; set; }
        //数字为最大值, 字符串为最大长度
        public int? Max { get; set; }

       
    }
    public enum ParamType
    {
        Int,
        Bool,
        String,
        DateTime,
        Decimal,
        Guid
    }
}
