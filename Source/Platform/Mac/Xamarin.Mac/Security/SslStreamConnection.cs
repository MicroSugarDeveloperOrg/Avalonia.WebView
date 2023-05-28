using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Security;

public class SslStreamConnection : SslConnection
{
	private byte[] buffer;

	public Stream InnerStream { get; private set; }

	public SslStreamConnection(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		InnerStream = stream;
		buffer = new byte[16384];
	}

	public override SslStatus Read(IntPtr data, ref nint dataLength)
	{
		int count = (int)Math.Min(dataLength, buffer.Length);
		int num = InnerStream.Read(buffer, 0, count);
		Marshal.Copy(buffer, 0, data, num);
		bool flag = num < dataLength;
		dataLength = num;
		return flag ? SslStatus.WouldBlock : SslStatus.Success;
	}

	public unsafe override SslStatus Write(IntPtr data, ref nint dataLength)
	{
		using (UnmanagedMemoryStream unmanagedMemoryStream = new UnmanagedMemoryStream((byte*)(void*)data, dataLength))
		{
			try
			{
				unmanagedMemoryStream.CopyTo(InnerStream);
			}
			catch (IOException)
			{
				return SslStatus.ClosedGraceful;
			}
			catch
			{
				return SslStatus.Internal;
			}
		}
		return SslStatus.Success;
	}
}
