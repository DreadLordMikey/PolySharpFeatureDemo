using System.Text;
using System.Runtime.CompilerServices;

namespace CSharp10.Tests.Helpers;

[InterpolatedStringHandler]
public ref struct LogInterpolatedStringHandler
{
    // Storage for the built-up string
    StringBuilder builder;

    public LogInterpolatedStringHandler(int literalLength, int formattedCount)
    {
        builder = new StringBuilder(literalLength);
        builder.AppendLine($"\tliteral length: {literalLength}, formattedCount: {formattedCount}");
    }

    public void AppendLiteral(string s)
    {
        builder.AppendLine($"\tAppendLiteral called: {{{s}}}");

        builder.Append(s);
        builder.AppendLine($"\tAppended the literal string");
    }

    public void AppendFormatted<T>(T t)
    {
        builder.AppendLine($"\tAppendFormatted called: {{{t}}} is of type {typeof(T)}");

        builder.Append(t?.ToString());
        builder.AppendLine($"\tAppended the formatted object");
    }

    internal string GetFormattedText() => builder.ToString();
}
