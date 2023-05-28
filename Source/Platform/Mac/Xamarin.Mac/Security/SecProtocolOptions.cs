using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(5, 0)]
public class SecProtocolOptions : NativeObject
{
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static TlsProtocolVersion DefaultMinDtlsProtocolVersion => sec_protocol_options_get_default_min_dtls_protocol_version();

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static TlsProtocolVersion DefaultMaxDtlsProtocolVersion => sec_protocol_options_get_default_max_dtls_protocol_version();

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static TlsProtocolVersion DefaultMinTlsProtocolVersion => sec_protocol_options_get_default_min_tls_protocol_version();

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static TlsProtocolVersion DefaultMaxTlsProtocolVersion => sec_protocol_options_get_default_max_tls_protocol_version();

	internal SecProtocolOptions(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_local_identity(IntPtr handle, IntPtr identity);

	public void SetLocalIdentity(SecIdentity2 identity)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		sec_protocol_options_set_local_identity(GetCheckedHandle(), identity.GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	private static extern void sec_protocol_options_add_tls_ciphersuite(IntPtr handle, SslCipherSuite cipherSuite);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuite (TlsCipherSuite)' instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public void AddTlsCipherSuite(SslCipherSuite cipherSuite)
	{
		sec_protocol_options_add_tls_ciphersuite(GetCheckedHandle(), cipherSuite);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void sec_protocol_options_append_tls_ciphersuite(IntPtr options, TlsCipherSuite ciphersuite);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void AddTlsCipherSuite(TlsCipherSuite cipherSuite)
	{
		sec_protocol_options_append_tls_ciphersuite(GetCheckedHandle(), cipherSuite);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	private static extern void sec_protocol_options_add_tls_ciphersuite_group(IntPtr handle, SslCipherSuiteGroup cipherSuiteGroup);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'AddTlsCipherSuiteGroup (TlsCipherSuiteGroup)' instead.")]
	public void AddTlsCipherSuiteGroup(SslCipherSuiteGroup cipherSuiteGroup)
	{
		sec_protocol_options_add_tls_ciphersuite_group(GetCheckedHandle(), cipherSuiteGroup);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void sec_protocol_options_append_tls_ciphersuite_group(IntPtr options, TlsCipherSuiteGroup group);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void AddTlsCipherSuiteGroup(TlsCipherSuiteGroup cipherSuiteGroup)
	{
		sec_protocol_options_append_tls_ciphersuite_group(GetCheckedHandle(), cipherSuiteGroup);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	private static extern void sec_protocol_options_set_tls_min_version(IntPtr handle, SslProtocol protocol);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMinVersion (TlsProtocolVersion)' instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public void SetTlsMinVersion(SslProtocol protocol)
	{
		sec_protocol_options_set_tls_min_version(GetCheckedHandle(), protocol);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void sec_protocol_options_set_min_tls_protocol_version(IntPtr handle, TlsProtocolVersion version);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void SetTlsMinVersion(TlsProtocolVersion protocol)
	{
		sec_protocol_options_set_min_tls_protocol_version(GetCheckedHandle(), protocol);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	private static extern void sec_protocol_options_set_tls_max_version(IntPtr handle, SslProtocol protocol);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'SetTlsMaxVersion (TlsProtocolVersion)' instead.")]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[Advice("This API is not available when using UIKit on macOS.")]
	public void SetTlsMaxVersion(SslProtocol protocol)
	{
		sec_protocol_options_set_tls_max_version(GetCheckedHandle(), protocol);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void sec_protocol_options_set_max_tls_protocol_version(IntPtr handle, TlsProtocolVersion version);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void SetTlsMaxVersion(TlsProtocolVersion protocol)
	{
		sec_protocol_options_set_max_tls_protocol_version(GetCheckedHandle(), protocol);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern TlsProtocolVersion sec_protocol_options_get_default_min_dtls_protocol_version();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern TlsProtocolVersion sec_protocol_options_get_default_max_dtls_protocol_version();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern TlsProtocolVersion sec_protocol_options_get_default_min_tls_protocol_version();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern TlsProtocolVersion sec_protocol_options_get_default_max_tls_protocol_version();

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_add_tls_application_protocol(IntPtr handle, string applicationProtocol);

	public void AddTlsApplicationProtocol(string applicationProtocol)
	{
		if (applicationProtocol == null)
		{
			throw new ArgumentNullException("applicationProtocol");
		}
		sec_protocol_options_add_tls_application_protocol(GetCheckedHandle(), applicationProtocol);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_server_name(IntPtr handle, string serverName);

	public void SetTlsServerName(string serverName)
	{
		if (serverName == null)
		{
			throw new ArgumentNullException("serverName");
		}
		sec_protocol_options_set_tls_server_name(GetCheckedHandle(), serverName);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	private static extern void sec_protocol_options_set_tls_diffie_hellman_parameters(IntPtr handle, IntPtr dispatchDataParameter);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use non-DHE cipher suites instead.")]
	public void SetTlsDiffieHellmanParameters(DispatchData parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		sec_protocol_options_set_tls_diffie_hellman_parameters(GetCheckedHandle(), parameters.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_add_pre_shared_key(IntPtr handle, IntPtr dispatchDataParameter);

	public void AddPreSharedKey(DispatchData parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		sec_protocol_options_set_tls_diffie_hellman_parameters(GetCheckedHandle(), parameters.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_tickets_enabled(IntPtr handle, byte ticketsEnabled);

	public void SetTlsTicketsEnabled(bool ticketsEnabled)
	{
		sec_protocol_options_set_tls_tickets_enabled(GetCheckedHandle(), (byte)(ticketsEnabled ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_is_fallback_attempt(IntPtr handle, byte isFallbackAttempt);

	public void SetTlsIsFallbackAttempt(bool isFallbackAttempt)
	{
		sec_protocol_options_set_tls_is_fallback_attempt(GetCheckedHandle(), (byte)(isFallbackAttempt ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_resumption_enabled(IntPtr handle, byte resumptionEnabled);

	public void SetTlsResumptionEnabled(bool resumptionEnabled)
	{
		sec_protocol_options_set_tls_resumption_enabled(GetCheckedHandle(), (byte)(resumptionEnabled ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_false_start_enabled(IntPtr handle, byte falseStartEnabled);

	public void SetTlsFalseStartEnabled(bool falseStartEnabled)
	{
		sec_protocol_options_set_tls_false_start_enabled(GetCheckedHandle(), (byte)(falseStartEnabled ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_ocsp_enabled(IntPtr handle, byte ocspEnabled);

	public void SetTlsOcspEnabled(bool ocspEnabled)
	{
		sec_protocol_options_set_tls_ocsp_enabled(GetCheckedHandle(), (byte)(ocspEnabled ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_sct_enabled(IntPtr handle, byte sctEnabled);

	public void SetTlsSignCertificateTimestampEnabled(bool sctEnabled)
	{
		sec_protocol_options_set_tls_sct_enabled(GetCheckedHandle(), (byte)(sctEnabled ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_tls_renegotiation_enabled(IntPtr handle, byte renegotiationEnabled);

	public void SetTlsRenegotiationEnabled(bool renegotiationEnabled)
	{
		sec_protocol_options_set_tls_renegotiation_enabled(GetCheckedHandle(), (byte)(renegotiationEnabled ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_peer_authentication_required(IntPtr handle, byte peerAuthenticationRequired);

	public void SetPeerAuthenticationRequired(bool peerAuthenticationRequired)
	{
		sec_protocol_options_set_peer_authentication_required(GetCheckedHandle(), (byte)(peerAuthenticationRequired ? 1u : 0u));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern void sec_protocol_options_set_key_update_block(IntPtr options, ref BlockLiteral key_update_block, IntPtr key_update_queue);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetKeyUpdateCallback(SecProtocolKeyUpdate keyUpdate, DispatchQueue keyUpdateQueue)
	{
		if (keyUpdate == null)
		{
			throw new ArgumentNullException("keyUpdate");
		}
		if (keyUpdateQueue == null)
		{
			throw new ArgumentNullException("keyUpdateQueue");
		}
		BlockLiteral key_update_block = default(BlockLiteral);
		key_update_block.SetupBlockUnsafe(Trampolines.SDSecProtocolKeyUpdate.Handler, keyUpdate);
		sec_protocol_options_set_key_update_block(base.Handle, ref key_update_block, keyUpdateQueue.Handle);
		key_update_block.CleanupBlock();
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern bool sec_protocol_options_are_equal(IntPtr optionsA, IntPtr optionsB);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public bool IsEqual(SecProtocolOptions other)
	{
		if (other == null)
		{
			return false;
		}
		return sec_protocol_options_are_equal(GetCheckedHandle(), other.Handle);
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static bool IsEqual(SecProtocolOptions optionsA, SecProtocolOptions optionsB)
	{
		if (optionsA == null)
		{
			return optionsB == null;
		}
		if (optionsB == null)
		{
			return false;
		}
		return sec_protocol_options_are_equal(optionsA.Handle, optionsB.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void sec_protocol_options_set_tls_pre_shared_key_identity_hint(IntPtr options, IntPtr psk_identity_hint);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void SetTlsPreSharedKeyIdentityHint(DispatchData pskIdentityHint)
	{
		if (pskIdentityHint == null)
		{
			throw new ArgumentNullException("pskIdentityHint");
		}
		sec_protocol_options_set_tls_pre_shared_key_identity_hint(GetCheckedHandle(), pskIdentityHint.Handle);
	}
}
