"""
Example usage of the ETL system.
This demonstrates how to use the SOURCE/TRANSFORM/SINK pattern.
"""

from src.sources.csv_source import CSVSource
from src.sinks.text_sink import TextFileSink
from src.transformers.basic_transformers import BasicTransformer
from src.orchestrator import Orchestrator


def basic_etl_example():
    """Demonstrate basic ETL pipeline with CSV source and text sink."""
    print("=== Basic ETL Example ===")

    # SOURCE: Create CSV source for contacts data
    file_path_dir = "../data/contacts"
    file_name = "ms_14489.csv"
    source = CSVSource(file_path_dir, file_name)

    # TRANSFORM: Create basic transformer
    transformer = BasicTransformer()

    # SINK: Create text file sink
    sink = TextFileSink("output_basic.txt")

    # Create and run ETL pipeline
    pipeline = Orchestrator(source, transformer, sink)
    pipeline.run()

    print("Output written to: output_basic.txt\n")


if __name__ == "__main__":
    # Run examples
    basic_etl_example()

    print("ETL examples completed!")
    print("\nFiles created:")
    print("- output_basic.txt: All records with basic transformations")
