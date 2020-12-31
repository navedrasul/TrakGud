using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TrakGud.API.UItils
{
    public class TypeConverter
    {
        public static ExpandoObject dtoToExpando<T>(T obj)
        {
            var expando = new ExpandoObject();
            var dictionary = (IDictionary<string, object>)expando;

            foreach (var property in obj.GetType().GetProperties())
                dictionary.Add(property.Name, property.GetValue(obj));

            return expando;
        }

        public static void CopyFieldsAndProps<T>(ref T copyTo, T copyFrom)
        {
            Type t = copyFrom.GetType();
            foreach (FieldInfo fieldInf in t.GetFields())
            {
                fieldInf.SetValue(copyTo, fieldInf.GetValue(copyFrom));
            }
            foreach (PropertyInfo propInf in t.GetProperties())
            {
                propInf.SetValue(copyTo, propInf.GetValue(copyFrom));
            }
        }
    }
}
