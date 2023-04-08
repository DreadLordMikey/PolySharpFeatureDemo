# CSharp 8 Features

See [C# version 8.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history?source=recommendations#c-version-80) in [C# Version History](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history) at [Microsoft's C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) site.

## Feaures and Compatibility

Feature                                          |4.5 |4.5.1|4.5.2|4.6 |4.6.1|4.6.2|4.7|4.7.1|4.7.2|4.8
-------------------------------------------------|:--:|:---:|:---:|:--:|:---:|:---:|:--:|:--:|:--:|:--:
Asynchronous streams<sup>1</sup>                 |❌ |❌   |❌   |❌ |❌  |✔️    |✔️   |✔️  |✔️  |✔️
Default interface methods                        |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Disposable ref structs                           |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Enhancement of interpolated verbatim strings     |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Indices and ranges                               |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Null-coalescing assignment                       |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Nullable reference types                         |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Pattern matching enhancement: Positional patterns|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Pattern matching enhancement: Property patterns  |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Pattern matching enhancement: Switch expressions |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Pattern matching enhancement: Tuple patterns     |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Readonly members                                 |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
Stackalloc in nested expressions<sup>1</sup>     |❔  |❔   |❔    |❔  |❔  |❔    |❔   |❔  |❔  |❔
Static local functions<sup>1</sup>               |❔  |❔   |❔    |❔  |❔  |❔    |❔   |❔  |❔  |❔
[Using declarations](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/using#pattern-based-using)                               |✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
                                                                                               
<div style="font-size: smaller;">   

<sup>1</sup> Reqires runtime support.

<sup>2</sup> This feature cannot be tested via unit test as there is no way to verify the results of the test.
</div>