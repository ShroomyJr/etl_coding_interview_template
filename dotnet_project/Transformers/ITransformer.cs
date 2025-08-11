namespace EtlSystem.Transformers
{
    /// <summary>
    /// Interface for data transformers that process and modify data
    /// </summary>
    /// <typeparam name="TInput">The input data type</typeparam>
    /// <typeparam name="TOutput">The output data type</typeparam>
    public interface ITransformer<TInput, TOutput>
    {
        /// <summary>
        /// Transform a collection of input data to output data
        /// </summary>
        /// <param name="data">Input data to transform</param>
        /// <returns>Transformed output data</returns>
        IEnumerable<TOutput> Transform(IEnumerable<TInput> data);
    }
}
