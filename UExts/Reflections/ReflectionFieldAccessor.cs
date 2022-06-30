using System;
using System.Linq;
using System.Reflection;

namespace UExts.Reflections
{
    public static class ReflectionFieldAccessor<TType>
    {
        private readonly static FieldInfo[] fields = typeof(TType).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);



        public static FieldInfo GetFieldByName(string name)
        {
            return fields.First(f => f.Name.Equals(name));
        }

        public static object GetValue(string fieldName, object instance = null)
        {
            if (fieldName == null)
            {
                throw new ArgumentNullException(nameof(fieldName));
            }

            return GetFieldByName(fieldName).GetValue(instance);
        }

        public static TValue GetValue<TValue>(string fieldName, object instance = null)
        {
            return (TValue)GetValue(fieldName, instance);
        }

        public static void SetValue(string fieldName, object value, object instance = null)
        {
            if (fieldName == null)
            {
                throw new ArgumentNullException(nameof(fieldName));
            }

            GetFieldByName(fieldName).SetValue(instance, value);
        }
    }
}
