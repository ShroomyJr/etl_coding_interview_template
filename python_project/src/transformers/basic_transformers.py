"""
Sample transformer implementations for demonstrating data transformation.
"""

from typing import Any, List, Dict
from ..orchestrator import Transform


class BasicTransformer(Transform):
    """A basic transformer that can apply simple transformations to data."""

    def __init__(self):
        """Initialize the basic transformer."""
        pass

    def transform(self, data: List[Dict[str, Any]]) -> List[Dict[str, Any]]:
        """
        Apply basic transformations to the data.
        This is a simple example

        Args:
            data: Input data as list of dictionaries

        Returns:
            Transformed data as list of dictionaries
        """
        transformed_data = []

        for record in data:
            # Create a copy to avoid modifying original data
            transformed_record = record.copy()

            # Here is where a transformer could modify the source data

            transformed_data.append(transformed_record)

        return transformed_data
