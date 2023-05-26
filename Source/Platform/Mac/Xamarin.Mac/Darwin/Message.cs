using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Darwin;

public class Message : IDisposable, INativeObject
{
	public enum Kind
	{
		Message,
		Query
	}

	[Flags]
	public enum Op
	{
		CaseFold = 0x10,
		Prefix = 0x20,
		Suffix = 0x40,
		Substring = 0x60,
		Numeric = 0x80,
		Regex = 0x100,
		Equal = 1,
		Greater = 2,
		GreaterEqual = 3,
		Less = 4,
		LessEqual = 5,
		NotEqual = 6,
		True = 7
	}

	public IntPtr Handle { get; private set; }

	public string this[string key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return asl_get(Handle, key);
		}
		set
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			asl_set(Handle, key, value);
		}
	}

	public string this[int key] => asl_key(Handle, key);

	public string Time
	{
		get
		{
			return this["Time"];
		}
		set
		{
			this["Time"] = value;
		}
	}

	public string Host
	{
		get
		{
			return this["Host"];
		}
		set
		{
			this["Host"] = value;
		}
	}

	public string Sender
	{
		get
		{
			return this["Sender"];
		}
		set
		{
			this["Sender"] = value;
		}
	}

	public string Facility
	{
		get
		{
			return this["Facility"];
		}
		set
		{
			this["Facility"] = value;
		}
	}

	public string PID
	{
		get
		{
			return this["PID"];
		}
		set
		{
			this["PID"] = value;
		}
	}

	public string UID
	{
		get
		{
			return this["UID"];
		}
		set
		{
			this["UID"] = value;
		}
	}

	public string GID
	{
		get
		{
			return this["GID"];
		}
		set
		{
			this["GID"] = value;
		}
	}

	public string Level
	{
		get
		{
			return this["Level"];
		}
		set
		{
			this["Level"] = value;
		}
	}

	public string Msg
	{
		get
		{
			return this["Message"];
		}
		set
		{
			this["Message"] = value;
		}
	}

	internal Message(IntPtr handle)
	{
		Handle = handle;
	}

	public Message(Kind kind)
	{
		Handle = asl_new(kind);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~Message()
	{
		Dispose(disposing: false);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern void asl_free(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (Handle != IntPtr.Zero)
		{
			asl_free(Handle);
			Handle = IntPtr.Zero;
		}
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr asl_new(Kind kind);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern string asl_get(IntPtr handle, string key);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int asl_set(IntPtr handle, string key, string value);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int asl_unset(IntPtr handle, string key);

	public void Remove(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		asl_unset(Handle, key);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern string asl_key(IntPtr handle, int key);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int asl_set_query(IntPtr handle, string key, string value, int op);

	public bool SetQuery(string key, Op op, string value)
	{
		return asl_set_query(Handle, key, value, (int)op) == 0;
	}
}
