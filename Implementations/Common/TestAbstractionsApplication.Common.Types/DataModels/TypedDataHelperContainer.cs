using Newtonsoft.Json.Linq;

namespace TestAbstractionsApplication.Common.Types.DataModels
{
    public class TypedDataHelperContainer<T>
    {
        private T _data { get; set; }

        public T DataTyped
        {
            get { return _data; }
            set { _data = value; }
        }

        public object Data
        {
            get => _data;
            set
            {
                if (value is JObject jobject) _data = jobject.ToObject<T>();
                else
                {
                    if (!(value is T typedData)) throw new System.ArgumentException($"Invalid argument type, {typeof(T).Name} expected.", nameof(value));
                    else _data = typedData;
                }
            }
        }
    }
}