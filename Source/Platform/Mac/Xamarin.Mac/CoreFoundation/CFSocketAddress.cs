using System;
using System.Net;
using System.Net.Sockets;

namespace CoreFoundation;

internal class CFSocketAddress : CFDataBuffer
{
	public CFSocketAddress(IPEndPoint endpoint)
		: base(CreateData(endpoint))
	{
	}

	internal static IPEndPoint EndPointFromAddressPtr(IntPtr address)
	{
		using CFDataBuffer cFDataBuffer = new CFDataBuffer(address);
		if (cFDataBuffer[1] == 30)
		{
			int port = (cFDataBuffer[2] << 8) + cFDataBuffer[3];
			byte[] array = new byte[16];
			Buffer.BlockCopy(cFDataBuffer.Data, 8, array, 0, 16);
			return new IPEndPoint(new IPAddress(array), port);
		}
		if (cFDataBuffer[1] == 2)
		{
			int port2 = (cFDataBuffer[2] << 8) + cFDataBuffer[3];
			byte[] array2 = new byte[4];
			Buffer.BlockCopy(cFDataBuffer.Data, 4, array2, 0, 4);
			return new IPEndPoint(new IPAddress(array2), port2);
		}
		throw new ArgumentException();
	}

	private static byte[] CreateData(IPEndPoint endpoint)
	{
		if (endpoint == null)
		{
			throw new ArgumentNullException("endpoint");
		}
		if (endpoint.AddressFamily == AddressFamily.InterNetwork)
		{
			byte[] array = new byte[16]
			{
				16,
				2,
				(byte)(endpoint.Port >> 8),
				(byte)((uint)endpoint.Port & 0xFFu),
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};
			Buffer.BlockCopy(endpoint.Address.GetAddressBytes(), 0, array, 4, 4);
			return array;
		}
		if (endpoint.AddressFamily != AddressFamily.InterNetworkV6)
		{
			throw new ArgumentException();
		}
		byte[] array2 = new byte[28]
		{
			32,
			30,
			(byte)(endpoint.Port >> 8),
			(byte)((uint)endpoint.Port & 0xFFu),
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0
		};
		Buffer.BlockCopy(endpoint.Address.GetAddressBytes(), 0, array2, 8, 16);
		return array2;
	}
}
