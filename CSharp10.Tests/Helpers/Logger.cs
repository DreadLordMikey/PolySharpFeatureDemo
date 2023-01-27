namespace PolySharpFeatureTests.Helpers;

public class Logger
{
    public LogLevel EnabledLevel { get; init; } = LogLevel.Error;

    public string LogMessage(LogLevel level, string msg)
    {
        if (EnabledLevel < level) return null;
        return msg;
    }

    public string LogMessage(LogLevel level, LogInterpolatedStringHandler builder)
    {
        if (EnabledLevel < level) return null;
        return builder.GetFormattedText();
    }
}
