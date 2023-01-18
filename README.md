
## Contents of this Project

This project contains unit tests that verify the availability of C# features that were added in C# 8.0 or higher using polyfills provided by [PolySharp](https://www.nuget.org/packages/PolySharp) when targeting .NET 4.8x or lower. Wherever possible, the tests use samples from Microsoft's own online documentation for the individual features.

This document lists all C# features that were added from C# 8 forward, and notes where features are either not supported or require additional setup or configuration. 

## Adding PolySharp to a Project

1. Add a reference to PolySharp from NuGet Package Manager.
1. Manually add the analyzer to the project. In Solution Explorer, expand References, and right-click Analyzers. Select Add Analyzer. Browse to `packages\PolySharp.1.10.0\analyzers\dotnet\cs\` and select `PolySharp.SourceGenerators.dll`. Then clean and rebuild your solution.

## Polyfills by C# Version

In each section below, if a bullet point is a hyperlink, the feature has been tested via unit test. Unless otherwise specified, the presence of a hyperlink indicates that the tests pass, and the feature is available via polyfill and works as documented in the linked Microsoft online documentation.

### C# 8

* [Readonly members](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct#readonly-instance-members)
* [Default interface methods](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface#default-interface-members) 
    - Not supported; requires support only available in later runtime versions.
* [Pattern matching enhancements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns):
  * [Is expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/is)
  * [Switch statement](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement)
  * [Switch expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression)
  * [Property patterns](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#property-pattern)
  * [Tuple patterns](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#positional-pattern)
  * [Positional patterns](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns#positional-pattern)
* [Using declarations](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive)
* [Static local functions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
* [Nullable reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types)
* [Asynchronous streams](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#await-foreach)
* [Indices and ranges](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#range-operator-):
    * [Index from End operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#index-from-end-operator-)
    * [Range operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#range-operator-) 
        - Not supported on arrays unless converted to a [Span\<T\>](https://learn.microsoft.com/en-us/dotnet/api/system.span-1?view=net-7.0) or [ReadOnlySpan\<T\>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1?view=net-7.0).
        - Requires a reference to System.Memory.dll.
* [Null-coalescing assignment](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/assignment-operator#null-coalescing-assignment)
* [Unmanaged constructed types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint)
* [Stackalloc in nested expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/stackalloc)
* [Enhancement of interpolated verbatim strings](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)

### C# 9

* [Record types](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types)
* [Init only setters](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#init-only-setters)
* [Top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#top-level-statements)
    * Not verifiable via unit test. However, the `TopLevelStatementsTest` project is a console application that verifies that this feature works as documented. 
* [Pattern matching enhancements](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements)
* Performance and interop
  * Native sized integers
  * Function pointers
  * Suppress emitting localsinit flag
* Fit and finish features
  * [Target-typed new expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-new)
  * [static anonymous functions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/static-anonymous-functions)
  * [Target-typed conditional expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-conditional-expression)
  * [Covariant return types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/covariant-returns)
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

