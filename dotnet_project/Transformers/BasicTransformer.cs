namespace EtlSystem.Transformers
{
    /// <summary>
    /// Basic transformer that passes data through without modification
    /// </summary>
    public class BasicTransformer : ITransformer<object, object>
    {
        public IEnumerable<object> Transform(IEnumerable<object> data)
        {
            // Simple passthrough - no transformation logic
            return data;
        }
    }
}
