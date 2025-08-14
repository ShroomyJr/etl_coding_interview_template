using EtlSystem.Sinks;
using EtlSystem.Sources;
using EtlSystem.Transformers;

namespace EtlSystem
{
    /// <summary>
    /// Orchestrates the ETL pipeline by coordinating SOURCE → TRANSFORM → SINK operations
    /// </summary>
    /// <typeparam name="TInput">The input data type from the source</typeparam>
    /// <typeparam name="TOutput">The output data type to the sink</typeparam>
    public class Orchestrator<TInput, TOutput>
    {
        private readonly ISource<TInput> _source;
        private readonly ITransformer<TInput, TOutput> _transformer;
        private readonly ISink<TOutput> _sink;

        public Orchestrator(
            ISource<TInput> source,
            ITransformer<TInput, TOutput> transformer,
            ISink<TOutput> sink
        )
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
            _transformer = transformer ?? throw new ArgumentNullException(nameof(transformer));
            _sink = sink ?? throw new ArgumentNullException(nameof(sink));
        }

        /// <summary>
        /// Execute the complete ETL pipeline
        /// </summary>
        public void Run()
        {
            try
            {
                Console.WriteLine("Starting ETL pipeline...");

                // SOURCE: Extract data
                Console.WriteLine("Step 1: Extracting data from source...");
                var sourceData = _source.Read();

                // TRANSFORM: Process data
                Console.WriteLine("Step 2: Transforming data...");
                var transformedData = _transformer.Transform(sourceData, _source.FileName);

                // SINK: Load data
                Console.WriteLine("Step 3: Loading data to sink...");
                _sink.Write(transformedData);

                Console.WriteLine("ETL pipeline completed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ETL pipeline failed: {ex.Message}");
                throw;
            }
        }
    }
}
