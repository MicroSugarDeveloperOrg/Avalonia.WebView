using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Network.framework' instead.")]
public class SslContext : INativeObject, IDisposable
{
	private SslConnection connection;

	private SslStatus result;

	private bool disposed;

	public IntPtr Handle { get; private set; }

	public SslProtocol MaxProtocol
	{
		get
		{
			result = SSLGetProtocolVersionMax(Handle, out var maxVersion);
			return maxVersion;
		}
		set
		{
			result = SSLSetProtocolVersionMax(Handle, value);
		}
	}

	public SslProtocol MinProtocol
	{
		get
		{
			result = SSLGetProtocolVersionMin(Handle, out var minVersion);
			return minVersion;
		}
		set
		{
			result = SSLSetProtocolVersionMin(Handle, value);
		}
	}

	public SslProtocol NegotiatedProtocol
	{
		get
		{
			result = SSLGetNegotiatedProtocolVersion(Handle, out var protocol);
			return protocol;
		}
	}

	public SslConnection Connection
	{
		get
		{
			if (connection == null)
			{
				return null;
			}
			result = SSLGetConnection(Handle, out var intPtr);
			if (intPtr != connection.ConnectionId)
			{
				throw new InvalidOperationException();
			}
			return connection;
		}
		set
		{
			if (value == null)
			{
				result = SSLSetIOFuncs(Handle, null, null);
			}
			else
			{
				result = SSLSetIOFuncs(Handle, value.ReadFunc, value.WriteFunc);
			}
			if (result == SslStatus.Success)
			{
				result = SSLSetConnection(Handle, value?.ConnectionId ?? IntPtr.Zero);
				connection = value;
			}
		}
	}

	public SslSessionState SessionState
	{
		get
		{
			SslSessionState state = SslSessionState.Invalid;
			result = SSLGetSessionState(Handle, ref state);
			return state;
		}
	}

	public unsafe byte[] PeerId
	{
		get
		{
			result = SSLGetPeerID(Handle, out var peerID, out var peerIDLen);
			if (result != 0 || peerIDLen == 0)
			{
				return null;
			}
			byte[] destination = new byte[(long)peerIDLen];
			Marshal.Copy(peerID, destination, 0, (int)peerIDLen);
			return destination;
		}
		set
		{
			nint peerIDLen = ((value != null) ? value.Length : 0);
			fixed (byte* peerID = value)
			{
				result = SSLSetPeerID(Handle, peerID, peerIDLen);
			}
		}
	}

	public nint BufferedReadSize
	{
		get
		{
			result = SSLGetBufferedReadSize(Handle, out var bufSize);
			return bufSize;
		}
	}

	public SslCipherSuite NegotiatedCipher
	{
		get
		{
			result = SSLGetNegotiatedCipher(Handle, out var cipherSuite);
			return cipherSuite;
		}
	}

	public nint DatagramWriteSize
	{
		get
		{
			result = SSLGetDatagramWriteSize(Handle, out var bufSize);
			return bufSize;
		}
	}

	public nint MaxDatagramRecordSize
	{
		get
		{
			result = SSLGetMaxDatagramRecordSize(Handle, out var maxSize);
			return maxSize;
		}
		set
		{
			result = SSLSetMaxDatagramRecordSize(Handle, value);
		}
	}

	public string PeerDomainName
	{
		get
		{
			result = SSLGetPeerDomainNameLength(Handle, out var peerNameLen);
			if (result != 0 || peerNameLen == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[(long)peerNameLen];
			result = SSLGetPeerDomainName(Handle, array, ref peerNameLen);
			return (result == SslStatus.Success) ? Encoding.UTF8.GetString(array) : string.Empty;
		}
		set
		{
			if (value == null)
			{
				result = SSLSetPeerDomainName(Handle, null, 0);
				return;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			result = SSLSetPeerDomainName(Handle, bytes, bytes.Length);
		}
	}

	public SslClientCertificateState ClientCertificateState
	{
		get
		{
			result = SSLGetClientCertificateState(Handle, out var clientState);
			return clientState;
		}
	}

	public SecTrust PeerTrust
	{
		get
		{
			result = SSLCopyPeerTrust(Handle, out var trust);
			return (trust == IntPtr.Zero) ? null : new SecTrust(trust, owns: true);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SSLCreateContext(IntPtr alloc, SslProtocolSide protocolSide, SslConnectionType connectionType);

	public SslContext(SslProtocolSide protocolSide, SslConnectionType connectionType)
	{
		Handle = SSLCreateContext(IntPtr.Zero, protocolSide, connectionType);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLClose(IntPtr context);

	~SslContext()
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
		if (!disposed)
		{
			disposed = true;
			if (Handle != IntPtr.Zero)
			{
				result = SSLClose(Handle);
			}
			if (connection != null)
			{
				connection.Dispose();
				connection = null;
			}
			if (Handle != IntPtr.Zero)
			{
				CFObject.CFRelease(Handle);
				Handle = IntPtr.Zero;
			}
		}
	}

	public SslStatus GetLastStatus()
	{
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetProtocolVersionMax(IntPtr context, out SslProtocol maxVersion);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetProtocolVersionMax(IntPtr context, SslProtocol maxVersion);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetProtocolVersionMin(IntPtr context, out SslProtocol minVersion);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetProtocolVersionMin(IntPtr context, SslProtocol minVersion);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetNegotiatedProtocolVersion(IntPtr context, out SslProtocol protocol);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetConnection(IntPtr context, out IntPtr connection);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetConnection(IntPtr context, IntPtr connection);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetIOFuncs(IntPtr context, SslReadFunc readFunc, SslWriteFunc writeFunc);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetSessionOption(IntPtr context, SslSessionOption option, out bool value);

	public SslStatus GetSessionOption(SslSessionOption option, out bool value)
	{
		result = SSLGetSessionOption(Handle, option, out value);
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetSessionOption(IntPtr context, SslSessionOption option, bool value);

	public SslStatus SetSessionOption(SslSessionOption option, bool value)
	{
		result = SSLSetSessionOption(Handle, option, value);
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetClientSideAuthenticate(IntPtr context, SslAuthenticate auth);

	public SslStatus SetClientSideAuthenticate(SslAuthenticate auth)
	{
		result = SSLSetClientSideAuthenticate(Handle, auth);
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLHandshake(IntPtr context);

	public SslStatus Handshake()
	{
		result = SSLHandshake(Handle);
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetSessionState(IntPtr context, ref SslSessionState state);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetPeerID(IntPtr context, out IntPtr peerID, out nint peerIDLen);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLSetPeerID(IntPtr context, byte* peerID, nint peerIDLen);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetBufferedReadSize(IntPtr context, out nint bufSize);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLRead(IntPtr context, byte* data, nint dataLength, out nint processed);

	internal unsafe SslStatus Read(byte[] data, int offset, int size, out nint processed)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		fixed (byte* data2 = &data[offset])
		{
			result = SSLRead(Handle, data2, size, out processed);
		}
		return result;
	}

	public unsafe SslStatus Read(byte[] data, out nint processed)
	{
		int num = ((data != null) ? data.Length : 0);
		fixed (byte* data2 = data)
		{
			result = SSLRead(Handle, data2, num, out processed);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLWrite(IntPtr context, byte* data, nint dataLength, out nint processed);

	internal unsafe SslStatus Write(byte[] data, int offset, int size, out nint processed)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		fixed (byte* data2 = &data[offset])
		{
			result = SSLWrite(Handle, data2, size, out processed);
		}
		return result;
	}

	public unsafe SslStatus Write(byte[] data, out nint processed)
	{
		int num = ((data != null) ? data.Length : 0);
		fixed (byte* data2 = data)
		{
			result = SSLWrite(Handle, data2, num, out processed);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetNumberSupportedCiphers(IntPtr context, out nint numCiphers);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLGetSupportedCiphers(IntPtr context, SslCipherSuite* ciphers, ref nint numCiphers);

	public unsafe IList<SslCipherSuite> GetSupportedCiphers()
	{
		result = SSLGetNumberSupportedCiphers(Handle, out var numCiphers);
		if (result != 0 || numCiphers <= 0)
		{
			return null;
		}
		SslCipherSuite[] array = new SslCipherSuite[(long)numCiphers];
		fixed (SslCipherSuite* ciphers = array)
		{
			result = SSLGetSupportedCiphers(Handle, ciphers, ref numCiphers);
			if (result != 0)
			{
				return null;
			}
		}
		return new List<SslCipherSuite>(array);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetNumberEnabledCiphers(IntPtr context, out nint numCiphers);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLGetEnabledCiphers(IntPtr context, SslCipherSuite* ciphers, ref nint numCiphers);

	public unsafe IList<SslCipherSuite> GetEnabledCiphers()
	{
		result = SSLGetNumberEnabledCiphers(Handle, out var numCiphers);
		if (result != 0 || numCiphers <= 0)
		{
			return null;
		}
		SslCipherSuite[] array = new SslCipherSuite[(long)numCiphers];
		fixed (SslCipherSuite* ciphers = array)
		{
			result = SSLGetEnabledCiphers(Handle, ciphers, ref numCiphers);
			if (result != 0)
			{
				return null;
			}
		}
		return new List<SslCipherSuite>(array);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLSetEnabledCiphers(IntPtr context, SslCipherSuite* ciphers, nint numCiphers);

	public unsafe SslStatus SetEnabledCiphers(IEnumerable<SslCipherSuite> ciphers)
	{
		if (ciphers == null)
		{
			throw new ArgumentNullException("ciphers");
		}
		SslCipherSuite[] array = ciphers.ToArray();
		fixed (SslCipherSuite* ciphers2 = array)
		{
			result = SSLSetEnabledCiphers(Handle, ciphers2, array.Length);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetNegotiatedCipher(IntPtr context, out SslCipherSuite cipherSuite);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetDatagramWriteSize(IntPtr context, out nint bufSize);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetMaxDatagramRecordSize(IntPtr context, out nint maxSize);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetMaxDatagramRecordSize(IntPtr context, nint maxSize);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern SslStatus SSLSetDatagramHelloCookie(IntPtr context, byte* cookie, nint cookieLength);

	public unsafe SslStatus SetDatagramHelloCookie(byte[] cookie)
	{
		nint cookieLength = ((cookie != null) ? cookie.Length : 0);
		fixed (byte* cookie2 = cookie)
		{
			result = SSLSetDatagramHelloCookie(Handle, cookie2, cookieLength);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetPeerDomainNameLength(IntPtr context, out nint peerNameLen);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetPeerDomainName(IntPtr context, byte[] peerName, ref nint peerNameLen);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetPeerDomainName(IntPtr context, byte[] peerName, nint peerNameLen);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLSetCertificate(IntPtr context, IntPtr certRefs);

	private NSArray Bundle(SecIdentity identity, IEnumerable<SecCertificate> certificates)
	{
		int num = ((identity != null) ? 1 : 0);
		int num2 = certificates?.Count() ?? 0;
		IntPtr[] array = new IntPtr[num2 + num];
		if (num == 1)
		{
			array[0] = identity.Handle;
		}
		foreach (SecCertificate certificate in certificates)
		{
			array[num++] = certificate.Handle;
		}
		return NSArray.FromIntPtrs(array);
	}

	public SslStatus SetCertificate(SecIdentity identify, IEnumerable<SecCertificate> certificates)
	{
		using NSArray nSArray = Bundle(identify, certificates);
		result = SSLSetCertificate(Handle, nSArray.Handle);
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLGetClientCertificateState(IntPtr context, out SslClientCertificateState clientState);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	private static extern SslStatus SSLSetEncryptionCertificate(IntPtr context, IntPtr certRefs);

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Export ciphers are not available anymore.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Export ciphers are not available anymore.")]
	public SslStatus SetEncryptionCertificate(SecIdentity identify, IEnumerable<SecCertificate> certificates)
	{
		using NSArray nSArray = Bundle(identify, certificates);
		result = SSLSetEncryptionCertificate(Handle, nSArray.Handle);
		return result;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslStatus SSLCopyPeerTrust(IntPtr context, out IntPtr trust);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr SSLContextGetTypeID();

	public static IntPtr GetTypeId()
	{
		return SSLContextGetTypeID();
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	[Deprecated(PlatformName.iOS, 9, 2, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, "'SetSessionStrengthPolicy' is not available anymore.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, "'SetSessionStrengthPolicy' is not available anymore.")]
	[Obsolete("'SetSessionStrengthPolicy' is not available anymore.")]
	public SslStatus SetSessionStrengthPolicy(SslSessionStrengthPolicy policyStrength)
	{
		Console.WriteLine("SetSessionStrengthPolicy is not available anymore.");
		return SslStatus.Success;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	[Watch(3, 0)]
	private static extern int SSLSetSessionConfig(IntPtr context, IntPtr config);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	[Watch(3, 0)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public int SetSessionConfig(NSString config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
		return SSLSetSessionConfig(Handle, config.Handle);
	}

	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	public int SetSessionConfig(SslSessionConfig config)
	{
		return SetSessionConfig(config.GetConstant());
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	private static extern int SSLReHandshake(IntPtr context);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[Watch(3, 0)]
	[TV(10, 0)]
	public int ReHandshake()
	{
		return SSLReHandshake(Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern SslStatus SSLCopyRequestedPeerName(IntPtr context, byte[] peerName, ref nuint peerNameLen);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(9, 0)]
	[Mac(10, 11)]
	private static extern SslStatus SSLCopyRequestedPeerNameLength(IntPtr context, ref nuint peerNameLen);

	[iOS(9, 0)]
	[Mac(10, 11)]
	public string GetRequestedPeerName()
	{
		string text = string.Empty;
		nuint peerNameLen = (byte)0;
		if (SSLCopyRequestedPeerNameLength(Handle, ref peerNameLen) == SslStatus.Success)
		{
			byte[] array = new byte[(ulong)peerNameLen];
			if (SSLCopyRequestedPeerName(Handle, array, ref peerNameLen) == SslStatus.Success)
			{
				text = Encoding.UTF8.GetString(array);
			}
		}
		return text;
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	private static extern int SSLSetSessionTicketsEnabled(IntPtr context, [MarshalAs(UnmanagedType.I1)] bool enabled);

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	public int SetSessionTickets(bool enabled)
	{
		return SSLSetSessionTicketsEnabled(Handle, enabled);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	private static extern int SSLSetError(IntPtr context, SecStatusCode status);

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	public int SetError(SecStatusCode status)
	{
		return SSLSetError(Handle, status);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	private static extern int SSLSetOCSPResponse(IntPtr context, IntPtr response);

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	public int SetOcspResponse(NSData response)
	{
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		return SSLSetOCSPResponse(Handle, response.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13, 4)]
	private static extern int SSLSetALPNProtocols(IntPtr context, IntPtr protocols);

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13, 4)]
	public int SetAlpnProtocols(string[] protocols)
	{
		using NSArray nSArray = NSArray.FromStrings(protocols);
		return SSLSetALPNProtocols(Handle, nSArray.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13, 4)]
	private static extern int SSLCopyALPNProtocols(IntPtr context, ref IntPtr protocols);

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13, 4)]
	public string[] GetAlpnProtocols(out int error)
	{
		IntPtr protocols = IntPtr.Zero;
		error = SSLCopyALPNProtocols(Handle, ref protocols);
		if (protocols == IntPtr.Zero)
		{
			return Array.Empty<string>();
		}
		string[] array = NSArray.StringArrayFromHandle(protocols);
		CFObject.CFRelease(protocols);
		return array;
	}

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13, 4)]
	public string[] GetAlpnProtocols()
	{
		int error;
		return GetAlpnProtocols(out error);
	}
}
