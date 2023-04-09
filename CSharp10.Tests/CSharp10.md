# C# 10 Feature Tests

See [C# version 10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history?source=recommendations#c-version-10) in [C# Version History](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history) at [Microsoft's C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) site.

## Compatibility Table Legend

Icon|Description
:-:|:-
✔️|All tests passed for this version.
❌|Tests failed for this version.
--|Feature not tested for this version.


### C# 10 Feature Compatiblity Mtrix

Feature                                          |4.5 |4.5.1|4.5.2|4.6 |4.6.1|4.6.2|4.7|4.7.1|4.7.2|4.8
-------------------------------------------------|:--:|:---:|:---:|:--:|:---:|:---:|:--:|:--:|:--:|:--:
[Allow AsyncMethodBuilder attribute on methods](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#allow-asyncmethodbuilder-attribute-on-methods) <sup>1</sup>|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Allow both assignment and declaration in the same deconstruction](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#assignment-and-declaration-in-same-deconstruction)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Allow const interpolated strings](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-types-can-seal-tostring)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[CallerArgumentExpression attribute](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#callerargumentexpression-attribute-diagnostics)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Enhanced #line pragma](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#enhanced-line-pragma) <sup>2</sup>|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Extended property patterns](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#extended-property-patterns)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[File-scoped namespace declaration](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#file-scoped-namespace-declaration) <sup>3</sup>|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Global using directives](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#global-using-directives) <sup>4</sup>|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Improved definite assignment](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#improved-definite-assignment)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Improvements on lambda expressions](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#improved-definite-assignment)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Interpolated string handlers](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#interpolated-string-handler)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Record types can seal ToString()](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-types-can-seal-tostring)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Record structs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10#record-structs)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Structs: Parameterless constructors and field initializers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/parameterless-struct-constructors)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Structs: With expression](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/record-structs#allow-with-expression-on-structs)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️

<div style="font-size: smaller;">   

<sup>1</sup> This feature is designed to support code generators. More research is required before an adequate suite of unit tests can be developed for this feature.

<sup>2</sup> Not testable via unit test. The effect of this improvement is apparent when debugging, as the accuracy of line numbers is improved.

<sup>3</sup> Not testable via unit test. However, all types in the CSharp10.Tests project use file-scoped namespace declarations, verifying that this functionality compiles and works as intended.</sup>

<sup>4</sup> Not testable via unit test. However, the CSharp10.Tests project defines global usings in the `GlobalUsings.cs` file, and does not import those namespaces in the individual source files. This should serve as adequate proof that this feature works in all tested versions of the framework.

</div>

<div style="display: none">

|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
|--  |--   |--    |--  |--  |--    |--   |--  |--  |--

❔✔️❌

<sup>2</sup> Requires more research before adequate testing methods can be developed.

<sup>3</sup> This cannot be verified via unit test. However, a separate project within this solution, `TopLevelStatementsTest.csproj`, has been provided to demonstrate this feature.

</div>