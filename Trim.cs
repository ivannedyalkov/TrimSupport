using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public static class Trim
{
    public static void TrimSupport(object obj)
    {
        Type type = obj.GetType();

        if (type.IsClass)
        {
            IEnumerable<PropertyInfo> property = type
                                                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                                    .Where(x => x.PropertyType == typeof(System.String))
                                                    .AsEnumerable();

            foreach (PropertyInfo prop in property)
            {
                object value = prop
                                  .GetValue(obj)? 
                                  .ToString()? 
                                  .Trim();

                if (!String.IsNullOrEmpty((string)value))
                {
                    prop.SetValue(obj, value);
                }
            }
        }
    }
}
