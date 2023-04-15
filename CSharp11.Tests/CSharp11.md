# CSharp 11 Features

See [C# version 11.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-11) in [C# Version History](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history) at [Microsoft's C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) site.

## Compatibility Table Legend

Icon|Description
:-:|:-
✔️|All tests passed for this version.
❌|Tests failed for this version.
❌|Feature not tested for this version.

## Feaures and Compatibility

Feature                                          |4.5 |4.5.1|4.5.2|4.6 |4.6.1|4.6.2|4.7|4.7.1|4.7.2|4.8
-------------------------------------------------|:--:|:---:|:---:|:--:|:---:|:---:|:--:|:--:|:--:|:--:
[Auto default structs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#auto-default-struct)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Extended nameof scope](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#extended-nameof-scope) <sup>1</sup>|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[File local types](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#file-local-types)|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️
[Generic attributes](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#generic-attributes) <sup>2</sup>|❌  |❌   |❌    |❌  |❌  |❌    |❌   |❌  |❌  |❌
[Generic math support](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#generic-math-support)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Improved method group conversion to delegate](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#improved-method-group-conversion-to-delegate)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[List patterns](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#list-patterns)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Newlines in string interpolation expressions](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#newlines-in-string-interpolations)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Numeric Intptr](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#numeric-intptr-and-uintptr)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Pattern match Span&lt;char&gt; on a constant string](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#pattern-match-spanchar-or-readonlyspanchar-on-a-constant-string)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Raw string literals](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#raw-string-literals)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[ref fields and scoped ref](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#ref-fields-and-ref-scoped-variables)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[Required members](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#required-members)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
[UTF-8 string literals](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11#utf-8-string-literals)|--  |--   |--    |--  |--  |--    |--   |--  |--  |--
                                                                                               
<div style="font-size: smaller;">   

<sup>1</sup> See [Extended nameof Scope](https://learn.microsoft.com/En-Us/dotnet/csharp/language-reference/proposals/csharp-11.0/extended-nameof-scope) in the *C# 11 Feature Specification* for more details.

<sup>2</sup> During testing, the compiler threw an error for all versions of the .NET Framework when attempting to use a generic attribute. The specific error was `System.NotSupportedException: Generic types are not valid.
` and it occurred during the call to [MemberInfo.GetCustomAttributes](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo.getcustomattributes?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Reflection.MemberInfo.GetCustomAttributes)%3Bk(DevLang-csharp)%26rd%3Dtrue&view=net-7.0).  See [Generic Attributes](https://learn.microsoft.com/En-Us/dotnet/csharp/language-reference/proposals/csharp-11.0/generic-attributes) in the *C# 11 Feature Specification* for more details.
</div>

<div style="display: none;">
<sup>1</sup> Reqires runtime support.

<sup>2</sup> This feature cannot be tested via unit test as there is no way to verify the results of the test.

|✔️  |✔️   |✔️    |✔️  |✔️  |✔️    |✔️   |✔️  |✔️  |✔️

</div>