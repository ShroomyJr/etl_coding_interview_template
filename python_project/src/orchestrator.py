"""
Base classes for ETL components following SOURCE/TRANSFORM/SINK pattern.
"""

from abc import ABC, abstractmethod
from typing import Any, List, Dict


class Source(ABC):
    """Abstract base class for data sources."""

    @abstractmethod
    def read(self) -> List[Dict[str, Any]]:
        """Read data from the source and return as list of dictionaries."""
        pass


class Transform(ABC):
    """Abstract base class for data transformers."""

    @abstractmethod
    def transform(self, data: List[Dict[str, Any]]) -> List[Dict[str, Any]]:
        """Transform the input data and return transformed data."""
        pass


class Sink(ABC):
    """Abstract base class for data sinks."""

    @abstractmethod
    def write(self, data: List[Dict[str, Any]]) -> None:
        """Write data to the sink destination."""
        pass


class Orchestrator:
    """Main ETL pipeline that orchestrates SOURCE -> TRANSFORM -> SINK."""

    def __init__(self, source: Source, transform: Transform, sink: Sink):
        self.source = source
        self.transform = transform
        self.sink = sink

    def run(self) -> None:
        """Execute the complete ETL pipeline."""
        print("Starting ETL pipeline...")

        # SOURCE: Read data
        print("Reading data from source...")
        data = self.source.read()
        print(f"Read {len(data)} records")

        # TRANSFORM: Process data
        print("Transforming data...")
        transformed_data = self.transform.transform(data, self.source.file_name)
        print(f"Transformed to {len(transformed_data)} records")

        # SINK: Write data
        print("Writing data to sink...")
        self.sink.write(transformed_data)
        print("ETL pipeline completed successfully!")
