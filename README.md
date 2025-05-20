# ECU Tuner - "Full Send" Edition

A simple Engine Control Unit (ECU) tuning application with a "Full Send" mode that removes performance limiters for maximum engine output.

## Features

- ECU status monitoring
- Multiple tuning levels
  - Mild tune (performance increase: ~10%)
  - Moderate tune (performance increase: ~25%)
  - FULL SEND mode (maximum performance, no limiters)
- User-friendly console interface

## Usage

1. Build the application using .NET:
   ```
   dotnet build
   ```

2. Run the application:
   ```
   dotnet run
   ```
   
   Or run the compiled executable directly:
   ```
   bin/Debug/net6.0/ecu.exe
   ```

3. Select option 4 for "FULL SEND" mode to remove all performance limiters.

## Warning

This application is for demonstration purposes only. In a real-world scenario, ECU modifications should only be performed by qualified professionals, as improper tuning can damage your engine and void your warranty.

## Requirements

- .NET 6.0 or higher
