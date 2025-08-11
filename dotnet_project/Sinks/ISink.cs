namespace EtlSystem.Sinks
{
    /// <summary>
    /// Interface for data sinks that can write data to destinations
    /// </summary>
    /// <typeparam name="T">The type of data records to write</typeparam>
    public interface ISink<T>
    {
        /// <summary>
        /// Write data to the sink destination
        /// </summary>
        /// <param name="data">Data records to write</param>
        void Write(IEnumerable<T> data);
    }
}
