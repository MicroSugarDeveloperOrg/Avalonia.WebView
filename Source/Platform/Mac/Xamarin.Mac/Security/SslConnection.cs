using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
public abstract class SslConnection : IDisposable
{
	private GCHandle handle;

	public IntPtr ConnectionId { get; private set; }

	internal SslReadFunc ReadFunc { get; private set; }

	internal SslWriteFunc WriteFunc { get; private set; }

	protected SslConnection()
	{
		handle = GCHandle.Alloc(this);
		ConnectionId = GCHandle.ToIntPtr(handle);
		ReadFunc = Read;
		WriteFunc = Write;
	}

	~SslConnection()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle.IsAllocated)
		{
			handle.Free();
		}
	}

	public abstract SslStatus Read(IntPtr data, ref nint dataLength);

	public abstract SslStatus Write(IntPtr data, ref nint dataLength);

	[MonoPInvokeCallback(typeof(SslReadFunc))]
	private static SslStatus Read(IntPtr connection, IntPtr data, ref nint dataLength)
	{
		SslConnection sslConnection = (SslConnection)GCHandle.FromIntPtr(connection).Target;
		return sslConnection.Read(data, ref dataLength);
	}

	[MonoPInvokeCallback(typeof(SslWriteFunc))]
	private static SslStatus Write(IntPtr connection, IntPtr data, ref nint dataLength)
	{
		SslConnection sslConnection = (SslConnection)GCHandle.FromIntPtr(connection).Target;
		return sslConnection.Write(data, ref dataLength);
	}
}
