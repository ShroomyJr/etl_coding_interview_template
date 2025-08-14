"""
CSV Source implementation for reading data from CSV files.
"""

import os
import csv
from typing import Any, List, Dict
from ..orchestrator import Source


class CSVSource(Source):
    """Source implementation for reading data from CSV files."""

    def __init__(self, file_path_dir: str, file_name: str):
        """
        Initialize CSV source.

        Args:
            file_path_dir: Directory containing the CSV file
            file_name: Name of the CSV file to read
        """
        self.file_name = file_name
        self.file_path = os.path.join(file_path_dir, file_name)

    def read(self) -> List[Dict[str, Any]]:
        """
        Read data from CSV file.

        Returns:
            List of dictionaries representing the CSV rows
        """
        data = []
        try:
            with open(self.file_path, "r", newline="", encoding="utf-8") as file:
                reader = csv.DictReader(file)
                for row in reader:
                    data.append(dict(row))
            return data
        except FileNotFoundError:
            raise FileNotFoundError(f"CSV file not found: {self.file_path}")
        except Exception as e:
            raise Exception(f"Error reading CSV file {self.file_path}: {str(e)}")
