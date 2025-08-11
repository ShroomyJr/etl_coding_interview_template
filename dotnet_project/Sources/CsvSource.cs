using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace EtlSystem.Sources
{
    /// <summary>
    /// CSV source implementation for reading data from CSV files as generic objects
    /// </summary>
    public class CsvSource : ISource<object>
    {
        private readonly string _filePath;

        public CsvSource(string filePath)
        {
            _filePath = filePath ?? throw new ArgumentNullException(nameof(filePath));
        }

        public IEnumerable<object> Read()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException($"CSV file not found: {_filePath}");
            }

            var records = new List<object>();

            using var reader = new StreamReader(_filePath);
            using var csv = new CsvReader(
                reader,
                new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HeaderValidated = null,
                    MissingFieldFound = null,
                    TrimOptions = TrimOptions.Trim
                }
            );

            // Read header
            csv.Read();
            csv.ReadHeader();
            var headers = csv.HeaderRecord ?? Array.Empty<string>();

            while (csv.Read())
            {
                try
                {
                    var record = new Dictionary<string, string>();

                    foreach (var header in headers)
                    {
                        var value = csv.GetField(header) ?? string.Empty;
                        record[header.Trim()] = value;
                    }

                    records.Add(record);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"Warning: Failed to parse row {csv.Context.Parser?.Row}: {ex.Message}"
                    );
                    continue;
                }
            }

            Console.WriteLine($"Successfully read {records.Count} records from {_filePath}");
            return records;
        }
    }
}
