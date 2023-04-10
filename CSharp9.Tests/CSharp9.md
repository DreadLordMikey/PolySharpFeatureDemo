# CSharp 9 Features

See [C# version 9.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history?source=recommendations#c-version-9) in [C# Version History](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history) at [Microsoft's C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) site.


## Compatibility Table Legend

Icon|Description
:-:|:-
✔️|All tests passed for this version.
❌|Tests failed for this version.
--|Feature not tested for this version.

## Feaures and Compatibility

Feature                                          |4.5 |4.5.1|4.5.2|4.6 |4.6.1|4.6.2|4.7|4.7.1|4.7.2|4.8
-------------------------------------------------|:--:|:---:|:---:|:--:|:---:|:---:|:--:|:--:|:--:|:--:
[Attributes on local functions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/local-function-attributes)                    |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Covariant return types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/covariant-returns)                           |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Extension GetEnumerator support for foreach loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extension-getenumerator)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Function pointers <sup>1</sup>                                |--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Init only setters](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#init-only-setters)                                |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Lambda discard parameters](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/lambda-discard-parameters)                        |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Module initializers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/module-initializers)                              |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Native sized integers <sup>1</sup>                            |--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[New features for partial methods](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extending-partial-methods) <sup>2</sup>|--  |--   |--    |--  |--  |--    |--  |--  |--    |-- 
[Pattern matching enhancements](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements)                    |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Record types](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types)                                    |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[static anonymous functions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/static-anonymous-functions)                       |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Suppress emitting localsinit flag <sup>1</sup>                |--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Target-typed conditional expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-conditional-expression)             |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Target-typed new expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-new)                     |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#top-level-statements) <sup>3</sup>                             |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
                                                                                               
<div style="font-size: smaller;">   

<sup>1</sup> Not verifiable via unit test.</sup>

<sup>2</sup> Requires more research before adequate testing methods can be developed.

<sup>3</sup> This cannot be verified via unit test. However, a separate project within this solution, `TopLevelStatementsTest.csproj`, has been provided to demonstrate this feature.

</div>
