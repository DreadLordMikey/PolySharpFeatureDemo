
## Contents of this Project

This project contains types that demonstrate C# features that were added in C# 8.0, 9.0, 10.0 and 11.0. Wherever possible, the types provide samples from Microsoft's own documentation.

When added as a NuGet reference to a project that targets .NET 4.5 through .NET 4.8x and specifies a Language Version of C# 8 or higher, [PolySharp](https://www.nuget.org/packages/PolySharp) creates polyfills for those C# features that are not supported by the current C# compiler. Certain features require runtime support, and cannot be supported.

## Polyfills by C# Version

### C# 8

* [Readonly members](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#readonly-instance-members)
* [Default interface methods](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface#default-interface-members) (not supported; requires runtime support)
* [Pattern matching enhancements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns):
  * Switch expressions
  * Property patterns
  * Tuple patterns
  * Positional patterns
* [Using declarations](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive)
* [Static local functions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
* [Nullable reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types)
* [Asynchronous streams](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#await-foreach)
* [Indices and ranges](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#range-operator-):
    * Index from End operator
    * Range operator (not supported: requires .NET Core runtime support)
* [Null-coalescing assignment](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/assignment-operator#null-coalescing-assignment)
* [Unmanaged constructed types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint)
* [Stackalloc in nested expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/stackalloc)
* [Enhancement of interpolated verbatim strings](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)

### C# 9

* Record types
* Init only setters
* Top-level statements
* Pattern matching enhancements
* Performance and interop
  * Native sized integers
  * Function pointers
  * Suppress emitting localsinit flag
* Fit and finish features
  * Target-typed new expressions
  * static anonymous functions
  * Target-typed conditional expressions
  * Covariant return types
  * Extension GetEnumerator support for foreach loops
  * Lambda discard parameters
  * Attributes on local functions
* Support for code generators
  * Module initializers
  * New features for partial methods
* Warning wave 5

### C# 10

* Record structs
* Improvements of structure types
* Interpolated string handlers
* global using directives
* File-scoped namespace declaration
* Extended property patterns
* Improvements on lambda expressions
* Allow const interpolated strings
* Record types can seal ToString()
* Improved definite assignment
* Allow both assignment and declaration in the same deconstruction
* Allow AsyncMethodBuilder attribute on methods
* CallerArgumentExpression attribute
* Enhanced #line pragma
* Warning wave 6

### C# 11

* Raw string literals
* Generic math support
* Generic attributes
* UTF-8 string literals
* Newlines in string interpolation expressions
* List patterns
* File-local types
* Required members
* Auto-default structs
* Pattern match Span\<char\> on a constant string
* Extended nameof scope
* Numeric IntPtr
* ref fields and scoped ref
* Improved method group conversion to delegate
* Warning wave 7

## Verified C# Polyfills

* Global usings
* Pattern matching enhancements
* ReadOnly types and methods

## Adding PolySharp to a Project

1. Add a reference to PolySharp from NuGet Package Manager.
1. Manually add the analyzer to the project. In Solution Explorer, expand References, and right-click Analyzers. Select Add Analyzer. Browse to `packages\PolySharp.1.10.0\analyzers\dotnet\cs\` and select `PolySharp.SourceGenerators.dll`. Then clean and rebuild your solution.