using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
//using System.Type;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionChartsCore
{
    public class ChartParameterJsonConverter : JsonConverter
    {
        [ThreadStatic]
        static bool cannotWrite;

        // Disables the converter in a thread-safe manner.
        bool CannotWrite { get { return cannotWrite; } set { cannotWrite = value; } }

        public override bool CanWrite { get { return !CannotWrite; } }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(ChartParameters))
                return true;

            else return false;
            //return (typeof(ChartParameters)).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();

            //var obj = JObject.Load(reader);
            //obj.SelectToken("details.size").MoveTo(obj);
            //obj.SelectToken("details.weight").MoveTo(obj);
            //using (reader = obj.CreateReader())
            //{
            //    // Using "populate" avoids infinite recursion.
            //    existingValue = (existingValue ?? new ChartParameters());
            //    serializer.Populate(reader, existingValue);
            //}
            //return existingValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // Disabling writing prevents infinite recursion.
            using (new PushValue<bool>(true, () => CannotWrite, val => CannotWrite = val))
            {
                var obj = JObject.FromObject(value, serializer);
                var details = new JObject();
                
                foreach(var p in obj["additionalParameters"])
                {
                    obj.Add(p);
                }

                obj.Remove("additionalParameters");

                obj.WriteTo(writer);
            }
        }
    }

    public static class JsonExtensions
    {
        public static void MoveTo(this JToken token, JObject newParent)
        {
            if (newParent == null)
                throw new ArgumentNullException();
            if (token != null)
            {
                if (token is JProperty)
                {
                    token.Remove();
                    newParent.Add(token);
                }
                else if (token.Parent is JProperty)
                {
                    token.Parent.Remove();
                    newParent.Add(token.Parent);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    public struct PushValue<T> : IDisposable
    {
        Action<T> setValue;
        T oldValue;

        public PushValue(T value, Func<T> getValue, Action<T> setValue)
        {
            if (getValue == null || setValue == null)
                throw new ArgumentNullException();
            this.setValue = setValue;
            this.oldValue = getValue();
            setValue(value);
        }

        #region IDisposable Members

        // By using a disposable struct we avoid the overhead of allocating and freeing an instance of a finalizable class.
        public void Dispose()
        {
            if (setValue != null)
                setValue(oldValue);
        }

        #endregion
    }
    
}
