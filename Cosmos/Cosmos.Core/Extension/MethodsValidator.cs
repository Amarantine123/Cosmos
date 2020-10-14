using Cosmos.Core.ObjectActionValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Cosmos.Core.Extension
{
    public static class MethodsValidator
    {
        public static Dictionary<string, string[]> ValidatorCollection { get; } = new Dictionary<string, string[]>();

        public static void Add<T>(this ValidatorLoginModel validatorGroup, Expression<Func<T, object>> loginExpress = null)
        {
            if (!ValidatorCollection.TryAdd(validatorGroup.ToString().ToLower(),loginExpress==null?typeof(T).GetGenericProperties().Select(x=>x.Name).ToArray():loginExpress.GetExpressionToArray()))
            {
                throw new Exception($"key{validatorGroup.ToString()}, has registed");
            }
        }


        public static Dictionary<string, GeneralOptions> ValidatorGeneralCollection { get; } = new Dictionary<string, GeneralOptions>();
        
        public static void Add(this ValidatorGeneral general,string CNName,ParamType type, int?min=null,int? max = null)
        {
            GeneralOptions options = new GeneralOptions(general, CNName, type, min, max);
            if (!ValidatorGeneralCollection.TryAdd(general.ToString().ToLower(),options))
            {
                throw new Exception($"key{general.ToString()}has registed");
            }
        }

        // General Parameters vertification
        public static void Add(this ValidatorGeneral general,string CNName)
        {
            general.Add(CNName, ParamType.String, null, null);
        }
        public static void Add(this ValidatorGeneral general, string CNName, int? max)
        {
            general.Add(CNName, ParamType.String, null, max);
        }
        public static void Add(this ValidatorGeneral general, string CNName, ParamType type)
        {
            general.Add(CNName, type, null, null);
        }

        public static void Add(this ValidatorGeneral general, string CNName, ParamType type, int? max)
        {
            general.Add(CNName, type, null, max);
        }

        public static void Add(this ValidatorGeneral general, string CNName, int? min, int? max)
        {
            general.Add(CNName, ParamType.String, min, max);
        }

        public static void Add(this ValidatorGeneral general, string CNName, Func<object, ObjectValidatorResult> customValidator)
        {
            GeneralOptions options = new GeneralOptions(general, CNName, customValidator);
            if (!ValidatorGeneralCollection.TryAdd(general.ToString().ToLower(), options))
            {
                throw new Exception($"键{general.ToString()}参数配置已经注入过了");
            }
        }

    }
}
