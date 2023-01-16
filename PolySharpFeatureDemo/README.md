
## Contents of this Project

This project contains types that demonstrate C# features that were added in C# 8.0, 9.0, 10.0 and 11.0. Wherever possible, the types provide samples from Microsoft's own documentation.

## Verified C# Polyfills

* Global usings
* Pattern matching enhancements
* ReadOnly types and methods

## Adding PolySharp to a Project

1. Add a reference to PolySharp from NuGet Package Manager.
1. Manually add the analyzer to the project. In Solution Explorer, expand References, and right-click Analyzers. Select Add Analyzer. Browse to `packages\PolySharp.1.10.0\analyzers\dotnet\cs\` and select `PolySharp.SourceGenerators.dll`. Then clean and rebuild your solution.