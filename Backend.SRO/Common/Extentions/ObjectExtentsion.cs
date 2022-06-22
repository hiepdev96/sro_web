using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extentions
{
    public static class ObjectExtentsion
    {
        public static void TrimAllProperties<T>(this T o)
        {
            var properties = o.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(string))
                {
                    string v = (string)property.GetValue(o);
                    v = v?.Trim();
                    if (property.CanWrite)
                    {
                        property.SetValue(o, v);
                    }
                }
            }
        }
    }
}
