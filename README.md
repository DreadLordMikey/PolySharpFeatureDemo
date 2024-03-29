﻿# PolySharp Feature Tests

## Contents of this Project

This project contains unit tests that verify the availability of C# features that were added in C# 8.0 or higher using polyfills provided by PolySharp when targeting .NET Framework 4.5.1 through 4.8. Wherever possible, the tests use samples from Microsoft's own online documentation for the individual features.

> **NOTE:** Tests for .NET Framework 4.5 are not provided as the .NET Framework 4.5 SDK is well past its end of life and Microsoft no longer makes it available for download from [.NET SDK Downloads for Visual Studio](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks). 
>
>As the SDK can no longer be acquired, forks of this repository would not be able to run these tests if they did not already have the SDK installed.

This document lists all C# features that were added from C# 8 forward, and notes where features are either not supported or require additional setup or configuration. 

PolySharp is sponsored by Sergio Pedri, and be found on github [here](https://github.com/Sergio0694/PolySharp). The NuGet package is available at NuGet.org [here](https://www.nuget.org/packages/PolySharp).

## Adding PolySharp to a Project

1. Add a reference to PolySharp from NuGet Package Manager.
1. Manually add the analyzer to the project. In Solution Explorer, expand References, and right-click Analyzers. Select Add Analyzer. Browse to `packages\PolySharp.1.10.0\analyzers\dotnet\cs\` and select `PolySharp.SourceGenerators.dll`. Then clean and rebuild your solution.

If your project uses a `packages.config` file, consider migrating it to use the newer [PackageReference](https://learn.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files) element in the `.csproj` file. Source code generation is more reliable when `PackageReference` elements are used as opposed to a `packages.config` file.


## Test Results by Version

Each of the pages below provides a feature compatibility matrix that describes the availability of each feature in each version of the .NET Framework tested.

- [C# 8](CSharp8.Tests/CSharp8.md)
- [C# 9](CSharp9.Tests/CSharp9.md)
- [C# 10](CSharp10.Tests/CSharp10.md)
- [C# 11](CSharp11.Tests/CSharp11.md) _In progress_

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
    * Not supported prior to .NET Framework 4.6.1.
    * Requires a reference to [Microsoft.Bcl.AsyncInterfaces](https://www.nuget.org/packages/Microsoft.Bcl.AsyncInterfaces).
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
  * [Extension GetEnumerator support for foreach loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extension-getenumerator)
  * [Lambda discard parameters](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/lambda-discard-parameters)
  * [Attributes on local functions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/local-function-attributes)
* Support for code generators
  * [Module initializers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/module-initializers)
  * [New features for partial methods](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extending-partial-methods)
* [Warning wave 5](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves#cs7023---a-static-type-is-used-in-an-is-or-as-expression)

### C# 10

* [Record structs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-structs)
* Improvements of structure types
    * [Parameterless constructors and field initializers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/parameterless-struct-constructors)
    * [With expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/record-structs#allow-with-expression-on-structs)
* Interpolated string handlers
* [Global using directives](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#global-using-directives)
* [File-scoped namespace declaration](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#file-scoped-namespace-declaration)
    * Not testable via unit test. However, all types in the CSharp10 folder use file-scoped namespace declarations, verifying that this functionality compiles and works as intended.
* [Extended property patterns](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#extended-property-patterns)
* [Improvements on lambda expressions](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#improved-definite-assignment)
* [Allow const interpolated strings](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-types-can-seal-tostring)
* [Record types can seal ToString()](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-types-can-seal-tostring)
* [Improved definite assignment](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#improved-definite-assignment)
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

