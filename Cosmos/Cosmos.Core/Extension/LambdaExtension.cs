using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Cosmos.Core.Extension
{
   public static class LambdaExtension
    {
        // Get the list of Properties according Type
        public static IEnumerable<PropertyInfo>GetGenericProperties(this Type type)
        {
            return type.GetProperties().GetGenericProperties();
        }

        // Filter The list of property accoding Type
        public static IEnumerable<PropertyInfo> GetGenericProperties(this IEnumerable<PropertyInfo> properties)
        {
            return properties.Where(x => !x.PropertyType.IsGenericType && x.PropertyType.GetInterface("IList") == null || x.PropertyType.GetInterface("IEnumerable", false) == null);
        }

        public static string[] GetExpressionToArray<TEntity>(this Expression<Func<TEntity, object>> expression)
        {
            string[] propertyNames = null;
            if (expression.Body is MemberExpression)
            {
                propertyNames = new string[]
                {
                    ((MemberExpression)expression.Body).Member.Name
                };

            }
            else
            {
                propertyNames = expression.GetExpressionProperty<TEntity>().Distinct().ToArray();
            }
            return propertyNames;
        }

        // Get the specified member in the object
        public static  string[]GetExpressionProperty<TEntity>(this Expression<Func<TEntity,object>>expression)
        {
            if (expression==null)
            {
               return new string[]{ };
            } // if end
            if (expression.Body is NewExpression)
            {
                return ((NewExpression)expression.Body).Members.Select(x => x.Name).ToArray();
            } // if end
            if (expression.Body is MemberExpression)
            {
                return new string[]{((MemberExpression)expression.Body).Member.Name};
            }// if end
            if (expression.Body is UnaryExpression)
            {
                return new string[]
                {
                    (((UnaryExpression)expression.Body).Operand as MemberExpression).Member.Name
                };
            }// end if

            throw new Exception("Unimplement Expression");
        }
    }
}
