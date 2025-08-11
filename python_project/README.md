# ETL Coding Interview Project

A simple ETL (Extract, Transform, Load) system implementing the SOURCE/TRANSFORM/SINK pattern for coding interviews.

## Project Structure

```
python_project/
├── src/
│   ├── __init__.py
│   ├── orchestrator.py      # ETL orchestration logic
│   ├── sources/
│   │   ├── __init__.py
│   │   └── csv_source.py    # CSV Source implementation
│   ├── sinks/
│   │   ├── __init__.py
│   │   └── text_sink.py     # Text file Sink implementation
│   └── transformers/
│       ├── __init__.py
│       ├── basic_transformers.py  # Basic transformation implementations
├── example.py               # Example usage of the ETL system
└── README.md               # This file
```

## Architecture

The ETL system follows a clean architecture with three main components:

### 1. SOURCE
- **Purpose**: Read data from various sources
- **Implementation**: `CSVSource` class for reading CSV files
- **Interface**: `Source` abstract base class with `read()` method

### 2. TRANSFORM
- **Purpose**: Process and transform data
- **Implementations**: 
  - `BasicTransformer`: Applies basic transformations (uppercase strings, add timestamps, record IDs)
- **Interface**: `Transform` abstract base class with `transform()` method

### 3. SINK
- **Purpose**: Write processed data to destinations
- **Implementation**: `TextFileSink` class for writing to text files
- **Interface**: `Sink` abstract base class with `write()` method

### Orchestrator
Orchestrates the entire process:
-   (SOURCE → TRANSFORM → SINK)

## Quick Start

1. **Run the example**:
   ```bash
   python example.py
   ```

2. **Check the output files**:
   - `output_basic.txt`: All records with basic transformations
