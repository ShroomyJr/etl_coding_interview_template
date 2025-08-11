# ETL System - .NET C# Implementation

A flexible C# implementation of the ETL (Extract, Transform, Load) system using the SOURCE/TRANSFORM/SINK pattern for coding interviews. This implementation uses generic interfaces and works with any data structure, allowing interviewees to define their own models.

## Project Structure

```
dotnet_project/
├── Sources/
│   ├── ISource.cs          # Generic source interface
│   └── CsvSource.cs        # CSV source implementation (returns dynamic objects)
├── Transformers/
│   ├── ITransformer.cs     # Generic transformer interface
│   └── BasicTransformer.cs # Basic transformation implementation
├── Sinks/
│   ├── ISink.cs           # Generic sink interface
│   └── TextFileSink.cs    # Text file sink implementation
├── Examples/              # Example models (not used in implementation)
│   ├── Contact.cs         # Example contact model
│   └── TransformedContact.cs # Example transformed model
├── Orchestrator.cs        # ETL pipeline orchestrator
├── Program.cs             # Main application entry point
├── dotnet_project.csproj  # Project file with dependencies
└── README.md             # This file
```

## Architecture

The ETL system follows a clean, generic architecture with three main components. All interfaces use `object` types to provide maximum flexibility:

### 1. SOURCE
- **Purpose**: Read data from various sources
- **Implementation**: `CsvSource` class reads CSV files and returns dynamic objects
- **Interface**: `ISource<object>` - located in `Sources/ISource.cs`

### 2. TRANSFORM
- **Purpose**: Process and transform data
- **Implementation**: `BasicTransformer` works with any object structure
- **Interface**: `ITransformer<object, object>` - located in `Transformers/ITransformer.cs`

### 3. SINK
- **Purpose**: Write processed data to destinations
- **Implementation**: `TextFileSink` accepts any object type
- **Interface**: `ISink<object>` - located in `Sinks/ISink.cs`

### Orchestrator
Fully generic orchestrator that coordinates the entire process:
- `Orchestrator<object, object>` (SOURCE → TRANSFORM → SINK)

## Dependencies

- **.NET 8.0** (or compatible version)
- **CsvHelper** - For robust CSV parsing and handling

## Quick Start

1. **Ensure .NET is installed**:
   ```bash
   dotnet --version
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Build the project**:
   ```bash
   dotnet build
   ```

4. **Run the application**:
   ```bash
   dotnet run
   ```

5. **Check the output files**:
   - `output_basic.txt`: All records with basic transformations
