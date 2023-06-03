namespace Linux.WebView.Core;
public class LinuxApplicationManager
{
    static LinuxApplicationManager()
    {
        _librariesNotFound = new();
        _libraries = new();
        _libraryDefinitions = new();
        _libraryDefinitions[gLibrary.GLib] = new string[4] { "libglib-2.0-0.dll", "libglib-2.0.so.0", "libglib-2.0.0.dylib", "glib-2.dll" };
        _libraryDefinitions[gLibrary.GObject] = new string[4] { "libgobject-2.0-0.dll", "libgobject-2.0.so.0", "libgobject-2.0.0.dylib", "gobject-2.dll" };
        _libraryDefinitions[gLibrary.Cairo] = new string[4] { "libcairo-2.dll", "libcairo.so.2", "libcairo.2.dylib", "cairo.dll" };
        _libraryDefinitions[gLibrary.Gio] = new string[4] { "libgio-2.0-0.dll", "libgio-2.0.so.0", "libgio-2.0.0.dylib", "gio-2.dll" };
        _libraryDefinitions[gLibrary.Atk] = new string[4] { "libatk-1.0-0.dll", "libatk-1.0.so.0", "libatk-1.0.0.dylib", "atk-1.dll" };
        _libraryDefinitions[gLibrary.Pango] = new string[4] { "libpango-1.0-0.dll", "libpango-1.0.so.0", "libpango-1.0.0.dylib", "pango-1.dll" };
        _libraryDefinitions[gLibrary.Gdk] = new string[4] { "libgdk-3-0.dll", "libgdk-3.so.0", "libgdk-3.0.dylib", "gdk-3.dll" };
        _libraryDefinitions[gLibrary.GdkPixbuf] = new string[4] { "libgdk_pixbuf-2.0-0.dll", "libgdk_pixbuf-2.0.so.0", "libgdk_pixbuf-2.0.dylib", "gdk_pixbuf-2.dll" };
        _libraryDefinitions[gLibrary.Gtk] = new string[4] { "libgtk-3-0.dll", "libgtk-3.so.0", "libgtk-3.0.dylib", "gtk-3.dll" };
        _libraryDefinitions[gLibrary.PangoCairo] = new string[4] { "libpangocairo-1.0-0.dll", "libpangocairo-1.0.so.0", "libpangocairo-1.0.0.dylib", "pangocairo-1.dll" };
        _libraryDefinitions[gLibrary.GtkSource] = new string[4] { "libgtksourceview-4-0.dll", "libgtksourceview-4.so.0", "libgtksourceview-4.0.dylib", "gtksourceview-4.dll" };
        _libraryDefinitions[gLibrary.Webkit] = new string[4] { "libwebkit2gtk-4.0.dll", "libwebkit2gtk-4.0.so.37", "libwebkit2gtk-4.0.dylib", "libwebkit2gtk-4.0.0.dll" };
    }

    private static Dictionary<gLibrary, string[]> _libraryDefinitions;
    private static Dictionary<gLibrary, nint> _libraries;
    private static HashSet<gLibrary> _librariesNotFound;

    static nint Load(gLibrary library)
    {
        if (_libraries.TryGetValue(library, out var value))
            return value;

        if (TryGet(library, out value))
            return value;

        throw new DllNotFoundException(library.ToString() + ": " + string.Join(", ", _libraryDefinitions[library]));
    }

    static bool TryGet(gLibrary library, out nint ret)
    {
        ret = IntPtr.Zero;
        if (_libraries.TryGetValue(library, out ret))
            return true;

        if (_librariesNotFound.Contains(library))
            return false;

        ret = LibraryLoader.LoadLibrary(_libraryDefinitions[library][1]);
        if (ret == IntPtr.Zero)
        {
            for (int i = 0; i < _libraryDefinitions[library].Length; i++)
            {
                ret = LibraryLoader.LoadLibrary(_libraryDefinitions[library][i]);
                if (ret != IntPtr.Zero)
                    break;
            }
        }

        if (ret != IntPtr.Zero)
            _libraries[library] = ret;
        else
            _librariesNotFound.Add(library);

        return ret != IntPtr.Zero;
    }

    public static bool IsSupported(gLibrary library)
    {
        IntPtr ret;
        return TryGet(library, out ret);
    }

    public static T? LoadDelegate<T>(gLibrary library, string procName)
    {
        var hModule = Load(library);
        if (hModule == IntPtr.Zero)
            return default;

        var pFunction = LibraryLoader.GetProcAddress(hModule, procName);
        if (pFunction == IntPtr.Zero)
            return default;

        return LibraryLoader.LoadDelegate<T>(pFunction);
    }

    public static nint LoadFunction<T>(T @delegate)
    {
        return LibraryLoader.LoadFunction(@delegate);
    }

}
