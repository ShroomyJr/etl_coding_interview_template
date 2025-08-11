namespace EtlSystem.Sinks
{
    /// <summary>
    /// Text file sink implementation for writing transformed data to text files
    /// </summary>
    public class TextFileSink : ISink<object>
    {
        private readonly string _filePath;

        public TextFileSink(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public void Write(IEnumerable<object> data)
        {
            try
            {
                using var writer = new StreamWriter(_filePath);

                var recordCount = 0;
                foreach (var item in data)
                {
                    writer.WriteLine(item.ToString());
                    recordCount++;
                }

                Console.WriteLine(
                    $"Successfully wrote {recordCount} transformed items to {_filePath}"
                );
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"Failed to write data to {_filePath}: {ex.Message}",
                    ex
                );
            }
        }
    }
}
