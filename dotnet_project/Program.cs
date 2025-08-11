using EtlSystem.Sinks;
using EtlSystem.Sources;
using EtlSystem.Transformers;

namespace EtlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ETL System Demo ===");
            Console.WriteLine("A C# implementation of the SOURCE/TRANSFORM/SINK pattern");
            Console.WriteLine();

            try
            {
                // Run the basic ETL example
                RunBasicEtlExample();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Application error: {ex.Message}");
                Environment.Exit(1);
            }
        }

        static void RunBasicEtlExample()
        {
            Console.WriteLine("=== Basic ETL Example ===");

            // SOURCE: Create CSV source
            var source = new CsvSource("../data/contacts/ms_14489.csv");

            // TRANSFORM: Create basic transformer
            var transformer = new BasicTransformer();

            // SINK: Create text file sink
            var sink = new TextFileSink("output_basic.txt");

            // Create and run ETL pipeline
            var pipeline = new Orchestrator<object, object>(source, transformer, sink);
            pipeline.Run();

            Console.WriteLine("Output written to: output_basic.txt");
        }
    }
}
