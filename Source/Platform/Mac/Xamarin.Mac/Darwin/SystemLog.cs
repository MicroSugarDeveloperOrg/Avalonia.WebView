using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Darwin;

public class SystemLog : IDisposable, INativeObject
{
	[Flags]
	public enum Option
	{
		Stderr = 0,
		NoDelay = 1,
		NoRemote = 2
	}

	private static SystemLog _default;

	private bool disposed;

	private IntPtr handle;

	public static SystemLog Default
	{
		get
		{
			if (_default == null)
			{
				_default = new SystemLog(IntPtr.Zero);
			}
			return _default;
		}
	}

	public IntPtr Handle => handle;

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~SystemLog()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			asl_close(handle);
			disposed = true;
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern void asl_close(IntPtr handle);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr asl_open(string ident, string facility, Option options);

	private SystemLog(IntPtr handle)
	{
		this.handle = handle;
	}

	public SystemLog(string ident, string facility, Option options = Option.Stderr)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		if (facility == null)
		{
			throw new ArgumentNullException("facility");
		}
		handle = asl_open(ident, facility, options);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr asl_open_from_file(int fd, string ident, string facility);

	public SystemLog(int fileDescriptor, string ident, string facility)
	{
		if (ident == null)
		{
			throw new ArgumentNullException("ident");
		}
		if (facility == null)
		{
			throw new ArgumentNullException("facility");
		}
		handle = asl_open_from_file(fileDescriptor, ident, facility);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr asl_add_log_file(IntPtr handle, int fd);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr asl_remove_log_file(IntPtr handle, int fd);

	public void AddLogFile(int descriptor)
	{
		asl_add_log_file(handle, descriptor);
	}

	public void RemoveLogFile(int descriptor)
	{
		asl_remove_log_file(handle, descriptor);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int asl_log(IntPtr handle, IntPtr msgHandle, string text);

	public int Log(Message msg, string text, params object[] args)
	{
		string text2 = ((text == null) ? "" : string.Format(text, args));
		if (text2.IndexOf("%") != -1)
		{
			text2 = text2.Replace("%", "%%");
		}
		return asl_log(handle, msg?.Handle ?? IntPtr.Zero, text2);
	}

	public int Log(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return asl_log(handle, IntPtr.Zero, text);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int asl_send(IntPtr handle, IntPtr msgHandle);

	public int Log(Message msg)
	{
		if (msg == null)
		{
			throw new ArgumentNullException("msg");
		}
		return asl_send(handle, msg.Handle);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int asl_set_filter(IntPtr handle, int f);

	public int SetFilter(int level)
	{
		return asl_set_filter(handle, level);
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr asl_search(IntPtr handle, IntPtr msg);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern IntPtr aslresponse_next(IntPtr handle);

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern void aslresponse_free(IntPtr handle);

	public IEnumerable<Message> Search(Message msg)
	{
		if (msg == null)
		{
			throw new ArgumentNullException("msg");
		}
		IntPtr search = asl_search(handle, msg.Handle);
		while (true)
		{
			IntPtr intPtr;
			IntPtr mh = (intPtr = aslresponse_next(search));
			if (!(intPtr != IntPtr.Zero))
			{
				break;
			}
			yield return new Message(mh);
		}
		aslresponse_free(search);
	}
}
