"""
Text file Sink implementation for writing data to text files.
"""

from typing import Any, List, Dict
from ..orchestrator import Sink


class TextFileSink(Sink):
    """Sink implementation for writing data to text files."""

    def __init__(self, file_path: str, format_template: str = None):
        """
        Initialize text file sink.

        Args:
            file_path: Path to the output text file
            format_template: Optional template for formatting each record.
                           If None, will use a simple key=value format.
        """
        self.file_path = file_path
        self.format_template = format_template

    def write(self, data: List[Dict[str, Any]]) -> None:
        """
        Write data to text file.

        Args:
            data: List of dictionaries to write to the file
        """
        try:
            with open(self.file_path, "w", encoding="utf-8") as file:
                for i, record in enumerate(data):
                    if self.format_template:
                        # Use custom format template
                        formatted_line = self.format_template.format(**record)
                    else:
                        # Default format: key=value pairs separated by commas
                        formatted_line = ", ".join(
                            [f"{k}={v}" for k, v in record.items()]
                        )

                    file.write(formatted_line + "\n")
        except Exception as e:
            raise Exception(f"Error writing to file {self.file_path}: {str(e)}")
