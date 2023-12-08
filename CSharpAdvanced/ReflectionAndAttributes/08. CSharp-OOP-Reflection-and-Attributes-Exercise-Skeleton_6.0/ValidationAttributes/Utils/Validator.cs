using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Utils
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();

            PropertyInfo[] propInfos = objType
                .GetProperties()
                .Where(p => p.CustomAttributes
                .Any(ca => typeof(MyValidationAttribute)
                .IsAssignableFrom(ca.AttributeType)))
                .ToArray();

            foreach (PropertyInfo prop in propInfos)
            {
                IEnumerable<MyValidationAttribute> attributes = prop.GetCustomAttributes()
                    .Where(ca => typeof(MyValidationAttribute).IsAssignableFrom(ca.GetType()))
                    .Cast<MyValidationAttribute>();

                foreach (var attribute in attributes)
                {
                    if (!attribute.IsValid(prop.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
