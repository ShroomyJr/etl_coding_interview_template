This is a sample ETL (Extract, Transform, Load) project for processing contact data from various sources.

The project includes implementations in both .NET and Python, allowing for the interviewee's choice of language.

Each implementation follows a similar structure:

An Orchestrator runs these steps as the pipeline:
1. **Source**: Reads data from the input CSV files.
2. **Transform**: Applies any necessary transformations to the data.
3. **Load**: Writes the transformed data to the output destination.

The Source step is written. No changes are needed, though they are permitted.
An implementation of the Transform step is written, but it is incomplete. It doesn't actually do any transformations yet.
An implementation of Sink exists which writes the transformed data to the a file. Other implementations can be added later.

Feel free to make whatever edits to the codebase you like.

The C# implementation is located in the `dotnet_project` directory, while the Python implementation can be found in the `python_project` directory.
The sample data is located in the `data` directory. The desired output format is specified in `data/formats.md`.
