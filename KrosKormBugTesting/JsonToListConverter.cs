using Kros.KORM.Converter;
using Newtonsoft.Json;

namespace KrosKormBugTesting
{
    /// <summary>
    /// Generic converter for Json Array.
    /// </summary>
    /// <seealso cref="IConverter" />
    public class JsonToListConverter<T> : IConverter
    {
        /// <inheritdoc />
        public object Convert(object value)
        {
            string json = (string)value;
            if (string.IsNullOrEmpty(json))
            {
                return new List<T>();
            }
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        /// <inheritdoc />
        public object ConvertBack(object value)
            => JsonConvert.SerializeObject(value);
    }
}
