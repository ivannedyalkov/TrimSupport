using System;
using System.Linq;
using System.Reflection;

public static class Trim
{
    public static void TrimSupport(object obj)
    {
        if (obj.GetType().IsClass)
        {
            PropertyInfo[] property = obj
                                        .GetType()
                                        .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                        .Where(x => x.PropertyType == typeof(System.String))
                                        .ToArray();

            foreach (PropertyInfo prop in property)
            {
                object value = prop
                                  .GetValue(obj)? 
                                  .ToString()? 
                                  .Trim();

                if ((string)value == String.Empty)
                {
                    value = null;
                }

                prop.SetValue(obj, value);
            }
        }
    }
}
