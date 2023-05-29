namespace Xamarin.Utiles;
public class RuntimeException : Exception
{
    public int Code { get; private set; }

    public bool Error { get; private set; }

    public RuntimeException(string message, params object[] args)
        : base(string.Format(message, args))
    {
    }

    public RuntimeException(int code, string message, params object[] args)
        : this(code, error: false, message, args)
    {
    }

    public RuntimeException(int code, bool error, string message, params object[] args)
        : this(code, error, null, message, args)
    {
    }

    public RuntimeException(int code, bool error, Exception innerException, string message, params object[] args)
        : base(string.Format(message, args), innerException)
    {
        Code = code;
        Error = error;
    }
}
