namespace EtlSystem.Sources
{
    /// <summary>
    /// Interface for data sources that can read and provide data
    /// </summary>
    /// <typeparam name="T">The type of data records to read</typeparam>
    public interface ISource<T>
    {
        /// <summary>
        /// Read all data from the source
        /// </summary>
        /// <returns>Collection of data records</returns>
        IEnumerable<T> Read();

        string FileName { get; }
        string FilePathDir { get; }
    }
}
