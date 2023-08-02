namespace Xamarin.Utiles;
internal static class ErrorHelper
{
    public enum WarningLevel
    {
        Error = -1,
        Warning,
        Disable
    }

    private const string Prefix = "MM";

    private static Dictionary<int, WarningLevel> warning_levels;

    public static int Verbosity { get; set; }

    public static WarningLevel GetWarningLevel(int code)
    {
        if (warning_levels == null)
        {
            return WarningLevel.Warning;
        }
        if (warning_levels.TryGetValue(-1, out var value))
        {
            return value;
        }
        if (warning_levels.TryGetValue(code, out value))
        {
            return value;
        }
        return WarningLevel.Warning;
    }

    public static void SetWarningLevel(WarningLevel level, int? code = null)
    {
        if (warning_levels == null)
        {
            warning_levels = new Dictionary<int, WarningLevel>();
        }
        if (code.HasValue)
        {
            warning_levels[code.Value] = level;
        }
        else
        {
            warning_levels[-1] = level;
        }
    }

    public static RuntimeException CreateError(int code, string message, params object[] args)
    {
        return new RuntimeException(code, error: true, message, args);
    }

    public static RuntimeException CreateError(int code, Exception innerException, string message, params object[] args)
    {
        return new RuntimeException(code, error: true, innerException, message, args);
    }

    public static RuntimeException CreateWarning(int code, string message, params object[] args)
    {
        return new RuntimeException(code, error: false, message, args);
    }

    public static RuntimeException CreateWarning(int code, Exception innerException, string message, params object[] args)
    {
        return new RuntimeException(code, error: false, innerException, message, args);
    }

    public static void Error(int code, Exception innerException, string message, params object[] args)
    {
        throw new RuntimeException(code, error: true, innerException, message, args);
    }

    public static void Error(int code, string message, params object[] args)
    {
        throw new RuntimeException(code, error: true, message, args);
    }

    public static void Warning(int code, string message, params object[] args)
    {
        Show(new RuntimeException(code, error: false, message, args));
    }

    public static void Warning(int code, Exception innerException, string message, params object[] args)
    {
        Show(new RuntimeException(code, error: false, innerException, message, args));
    }

    public static void Show(IEnumerable<Exception> list)
    {
        List<Exception> list2 = new List<Exception>();
        bool flag = false;
        foreach (Exception item in list)
        {
            CollectExceptions(item, list2);
        }
        foreach (Exception item2 in list2)
        {
            flag |= ShowInternal(item2);
        }
        if (flag)
        {
            Exit(1);
        }
    }

    public static void Show(Exception e)
    {
        List<Exception> list = new List<Exception>();
        bool flag = false;
        CollectExceptions(e, list);
        foreach (Exception item in list)
        {
            flag |= ShowInternal(item);
        }
        if (flag)
        {
            Exit(1);
        }
    }

    private static void Exit(int exitCode)
    {
        Environment.Exit(exitCode);
    }

    private static void CollectExceptions(Exception ex, List<Exception> exceptions)
    {
        if (ex is AggregateException ex2 && ex2.InnerExceptions.Count > 0)
        {
            foreach (Exception innerException in ex2.InnerExceptions)
            {
                CollectExceptions(innerException, exceptions);
            }
            return;
        }
        exceptions.Add(ex);
    }

    private static bool ShowInternal(Exception e)
    {
        RuntimeException ex = e as RuntimeException;
        bool flag = true;
        if (ex != null)
        {
            flag = ex.Error;
            if (!flag && GetWarningLevel(ex.Code) == WarningLevel.Disable)
            {
                return false;
            }
            Console.Error.WriteLine(ex.ToString());
            if (ex.Code > 8999)
            {
                return flag;
            }
            if (Verbosity > 1)
            {
                ShowInner(e);
            }
            if (Verbosity > 2 && !string.IsNullOrEmpty(e.StackTrace))
            {
                Console.Error.WriteLine(e.StackTrace);
            }
        }
        else
        {
            Console.Error.WriteLine(e.ToString());
            if (Verbosity > 1)
            {
                ShowInner(e);
            }
            if (Verbosity > 2 && !string.IsNullOrEmpty(e.StackTrace))
            {
                Console.Error.WriteLine(e.StackTrace);
            }
        }
        return flag;
    }

    private static void ShowInner(Exception e)
    {
        Exception innerException = e.InnerException;
        if (innerException != null)
        {
            if (Verbosity > 3)
            {
                Console.Error.WriteLine("--- inner exception");
                Console.Error.WriteLine(innerException);
                Console.Error.WriteLine("---");
            }
            else
            {
                Console.Error.WriteLine("\t{0}", innerException.Message);
            }
            ShowInner(innerException);
        }
    }
}