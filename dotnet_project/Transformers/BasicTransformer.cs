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
            // Shape of 'object' passed in:
            // Dictionary<string, string> where keys are CSV headers and values are row values
            // Example:
            // {
            //     "Name": "Jane Doe",
            //     "Email": "jdoe@gmail.com",
            //     "Phone": "555-555-5555",
            //     "SavedAt": "2024-09-01T12:54:00Z"
            // }
            return data;
        }
    }
}
