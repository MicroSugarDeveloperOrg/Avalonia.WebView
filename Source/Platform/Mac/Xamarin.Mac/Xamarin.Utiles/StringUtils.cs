using System.Text;

namespace Xamarin.Utiles;
internal class StringUtils
{
    private static char shellQuoteChar;

    private static char[] mustQuoteCharacters;

    private static char[] mustQuoteCharactersProcess;

    static StringUtils()
    {
        mustQuoteCharacters = new char[5] { ' ', '\'', ',', '$', '\\' };
        mustQuoteCharactersProcess = new char[4] { ' ', '\\', '"', '\'' };
        PlatformID platform = Environment.OSVersion.Platform;
        if (platform != (PlatformID)128 && platform != PlatformID.Unix && platform != PlatformID.MacOSX)
        {
            shellQuoteChar = '"';
        }
        else
        {
            shellQuoteChar = '\'';
        }
    }

    public static string[] Quote(params string[] array)
    {
        if (array == null || array.Length == 0)
        {
            return array;
        }
        string[] array2 = new string[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = Quote(array[i]);
        }
        return array2;
    }

    public static string Quote(string f)
    {
        if (string.IsNullOrEmpty(f))
        {
            return f ?? string.Empty;
        }
        if (f.IndexOfAny(mustQuoteCharacters) == -1)
        {
            return f;
        }
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(shellQuoteChar);
        foreach (char c in f)
        {
            if (c == '\'' || c == '"' || c == '\\')
            {
                stringBuilder.Append('\\');
            }
            stringBuilder.Append(c);
        }
        stringBuilder.Append(shellQuoteChar);
        return stringBuilder.ToString();
    }

    public static string[] QuoteForProcess(IList<string> arguments)
    {
        if (arguments == null)
        {
            return Array.Empty<string>();
        }
        return QuoteForProcess(arguments.ToArray());
    }

    public static string[] QuoteForProcess(params string[] array)
    {
        if (array == null || array.Length == 0)
        {
            return array;
        }
        string[] array2 = new string[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = QuoteForProcess(array[i]);
        }
        return array2;
    }

    public static string QuoteForProcess(string f)
    {
        if (string.IsNullOrEmpty(f))
        {
            return f ?? string.Empty;
        }
        if (f.IndexOfAny(mustQuoteCharactersProcess) == -1)
        {
            return f;
        }
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append('"');
        foreach (char c in f)
        {
            switch (c)
            {
                case '"':
                    stringBuilder.Append('\\');
                    stringBuilder.Append(c).Append(c);
                    break;
                case '\\':
                    stringBuilder.Append(c);
                    break;
            }
            stringBuilder.Append(c);
        }
        stringBuilder.Append('"');
        return stringBuilder.ToString();
    }

    public static string FormatArguments(params string[] arguments)
    {
        return FormatArguments((IList<string>)arguments);
    }

    public static string FormatArguments(IList<string> arguments)
    {
        return string.Join(" ", QuoteForProcess(arguments));
    }

    public static string Unquote(string input)
    {
        if (input == null || input.Length == 0 || input[0] != shellQuoteChar)
        {
            return input;
        }
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 1; i < input.Length - 1; i++)
        {
            char c = input[i];
            if (c == '\\')
            {
                stringBuilder.Append(input[i + 1]);
                i++;
            }
            else
            {
                stringBuilder.Append(input[i]);
            }
        }
        return stringBuilder.ToString();
    }

    public static bool TryParseArguments(string quotedArguments, out string[] argv, out Exception ex)
    {
        StringBuilder builder = new StringBuilder();
        List<string> list = new List<string>();
        for (int i = 0; i < quotedArguments.Length; i++)
        {
            char c = quotedArguments[i];
            if (c != ' ' && c != '\t')
            {
                string argument;
                if ((argument = GetArgument(builder, quotedArguments, i, out var endIndex, out ex)) == null)
                {
                    argv = null;
                    return false;
                }
                list.Add(argument);
                i = endIndex;
            }
        }
        argv = list.ToArray();
        ex = null;
        return true;
    }

    private static string GetArgument(StringBuilder builder, string buf, int startIndex, out int endIndex, out Exception ex)
    {
        bool flag = false;
        char c = '\0';
        int num = startIndex;
        builder.Clear();
        char c2;
        switch (buf[startIndex])
        {
            case '\'':
                c2 = '\'';
                num++;
                break;
            case '"':
                c2 = '"';
                num++;
                break;
            default:
                c2 = '\0';
                break;
        }
        while (num < buf.Length)
        {
            c = buf[num];
            if (c == c2 && !flag)
            {
                num++;
                break;
            }
            if (c == '\\')
            {
                flag = true;
            }
            else if (flag)
            {
                builder.Append(c);
                flag = false;
            }
            else
            {
                if (c2 == '\0' && (c == ' ' || c == '\t'))
                {
                    break;
                }
                if (c2 == '\0' && (c == '\'' || c == '"'))
                {
                    string value = builder.ToString();
                    string argument;
                    if ((argument = GetArgument(builder, buf, num, out endIndex, out ex)) == null)
                    {
                        return null;
                    }
                    num = endIndex;
                    builder.Clear();
                    builder.Append(value);
                    builder.Append(argument);
                    continue;
                }
                builder.Append(c);
            }
            num++;
        }
        if (flag || (c2 != 0 && c != c2))
        {
            ex = new FormatException(flag ? "Incomplete escape sequence." : "No matching quote found.");
            endIndex = -1;
            return null;
        }
        endIndex = num;
        ex = null;
        return builder.ToString();
    }

    public static Version ParseVersion(string v)
    {
        if (int.TryParse(v, out var result))
        {
            return new Version(result, 0);
        }
        return Version.Parse(v);
    }

    public static string SanitizeObjectiveCName(string name)
    {
        StringBuilder stringBuilder = null;
        for (int i = 0; i < name.Length; i++)
        {
            char c = name[i];
            switch (c)
            {
                case '$':
                case '+':
                case '-':
                case '.':
                case '/':
                case '<':
                case '>':
                case '@':
                case '`':
                    if (stringBuilder == null)
                    {
                        stringBuilder = new StringBuilder(name, 0, i, name.Length);
                    }
                    stringBuilder.Append('_');
                    break;
                default:
                    stringBuilder?.Append(c);
                    break;
            }
        }
        if (stringBuilder != null)
        {
            return stringBuilder.ToString();
        }
        return name;
    }
}