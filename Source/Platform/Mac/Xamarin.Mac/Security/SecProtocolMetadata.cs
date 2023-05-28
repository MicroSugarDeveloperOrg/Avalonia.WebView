using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Security;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(5, 0)]
public class SecProtocolMetadata : NativeObject
{
	private delegate void sec_protocol_metadata_access_distinguished_names_handler_t(IntPtr block, IntPtr dispatchData);

	private delegate void sec_protocol_metadata_access_ocsp_response_handler_t(IntPtr block, IntPtr dispatchData);

	private delegate void sec_protocol_metadata_access_peer_certificate_chain_handler_t(IntPtr block, IntPtr certificate);

	private delegate void sec_protocol_metadata_access_supported_signature_algorithms_handler_t(IntPtr block, ushort signatureAlgorithm);

	public delegate void SecAccessPreSharedKeysHandler(DispatchData psk, DispatchData pskIdentity);

	internal delegate void AccessPreSharedKeysHandler(IntPtr block, IntPtr dd_psk, IntPtr dd_psk_identity);

	private static sec_protocol_metadata_access_distinguished_names_handler_t static_DistinguishedNamesForPeer = TrampolineDistinguishedNamesForPeer;

	private static sec_protocol_metadata_access_ocsp_response_handler_t static_OcspReposeForPeer = TrampolineOcspReposeForPeer;

	private static sec_protocol_metadata_access_peer_certificate_chain_handler_t static_CertificateChainForPeer = TrampolineCertificateChainForPeer;

	private static sec_protocol_metadata_access_supported_signature_algorithms_handler_t static_SignatureAlgorithmsForPeer = TrampolineSignatureAlgorithmsForPeer;

	private static readonly AccessPreSharedKeysHandler presharedkeys = TrampolineAccessPreSharedKeys;

	public string NegotiatedProtocol => Marshal.PtrToStringAnsi(sec_protocol_metadata_get_negotiated_protocol(GetCheckedHandle()));

	public DispatchData PeerPublicKey => CreateDispatchData(sec_protocol_metadata_copy_peer_public_key(GetCheckedHandle()));

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	public SslProtocol NegotiatedProtocolVersion => sec_protocol_metadata_get_negotiated_protocol_version(GetCheckedHandle());

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public TlsProtocolVersion NegotiatedTlsProtocolVersion => sec_protocol_metadata_get_negotiated_tls_protocol_version(GetCheckedHandle());

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public TlsCipherSuite NegotiatedTlsCipherSuite => sec_protocol_metadata_get_negotiated_tls_ciphersuite(GetCheckedHandle());

	public SslCipherSuite NegotiatedCipherSuite => sec_protocol_metadata_get_negotiated_ciphersuite(GetCheckedHandle());

	public bool EarlyDataAccepted => sec_protocol_metadata_get_early_data_accepted(GetCheckedHandle()) != 0;

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public string ServerName => Marshal.PtrToStringAnsi(sec_protocol_metadata_get_server_name(GetCheckedHandle()));

	internal SecProtocolMetadata(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	internal SecProtocolMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_protocol_metadata_get_negotiated_protocol(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_protocol_metadata_copy_peer_public_key(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NegotiatedTlsProtocolVersion' instead.")]
	private static extern SslProtocol sec_protocol_metadata_get_negotiated_protocol_version(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern TlsProtocolVersion sec_protocol_metadata_get_negotiated_tls_protocol_version(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern TlsCipherSuite sec_protocol_metadata_get_negotiated_tls_ciphersuite(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SslCipherSuite sec_protocol_metadata_get_negotiated_ciphersuite(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern byte sec_protocol_metadata_get_early_data_accepted(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool sec_protocol_metadata_challenge_parameters_are_equal(IntPtr metadataA, IntPtr metadataB);

	public static bool ChallengeParametersAreEqual(SecProtocolMetadata metadataA, SecProtocolMetadata metadataB)
	{
		if (metadataA == null)
		{
			return metadataB == null;
		}
		if (metadataB == null)
		{
			return false;
		}
		return sec_protocol_metadata_challenge_parameters_are_equal(metadataA.GetCheckedHandle(), metadataB.GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool sec_protocol_metadata_peers_are_equal(IntPtr metadataA, IntPtr metadataB);

	public static bool PeersAreEqual(SecProtocolMetadata metadataA, SecProtocolMetadata metadataB)
	{
		if (metadataA == null)
		{
			return metadataB == null;
		}
		if (metadataB == null)
		{
			return false;
		}
		return sec_protocol_metadata_peers_are_equal(metadataA.GetCheckedHandle(), metadataB.GetCheckedHandle());
	}

	[MonoPInvokeCallback(typeof(sec_protocol_metadata_access_distinguished_names_handler_t))]
	private static void TrampolineDistinguishedNamesForPeer(IntPtr block, IntPtr data)
	{
		Action<DispatchData> target = BlockLiteral.GetTarget<Action<DispatchData>>(block);
		if (target != null)
		{
			DispatchData obj = new DispatchData(data, owns: false);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool sec_protocol_metadata_access_distinguished_names(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetDistinguishedNamesForPeerHandler(Action<DispatchData> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_DistinguishedNamesForPeer, callback);
		try
		{
			if (!sec_protocol_metadata_access_distinguished_names(GetCheckedHandle(), ref callback2))
			{
				throw new InvalidOperationException("Distinguished names are not accessible.");
			}
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(sec_protocol_metadata_access_ocsp_response_handler_t))]
	private static void TrampolineOcspReposeForPeer(IntPtr block, IntPtr data)
	{
		Action<DispatchData> target = BlockLiteral.GetTarget<Action<DispatchData>>(block);
		if (target != null)
		{
			DispatchData obj = new DispatchData(data, owns: false);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool sec_protocol_metadata_access_ocsp_response(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetOcspResponseForPeerHandler(Action<DispatchData> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_OcspReposeForPeer, callback);
		try
		{
			if (!sec_protocol_metadata_access_ocsp_response(GetCheckedHandle(), ref callback2))
			{
				throw new InvalidOperationException("The OSCP response is not accessible.");
			}
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(sec_protocol_metadata_access_peer_certificate_chain_handler_t))]
	private static void TrampolineCertificateChainForPeer(IntPtr block, IntPtr certificate)
	{
		Action<SecCertificate> target = BlockLiteral.GetTarget<Action<SecCertificate>>(block);
		if (target != null)
		{
			SecCertificate obj = new SecCertificate(certificate, owns: false);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool sec_protocol_metadata_access_peer_certificate_chain(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetCertificateChainForPeerHandler(Action<SecCertificate> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_CertificateChainForPeer, callback);
		try
		{
			if (!sec_protocol_metadata_access_peer_certificate_chain(GetCheckedHandle(), ref callback2))
			{
				throw new InvalidOperationException("The peer certificates are not accessible.");
			}
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(sec_protocol_metadata_access_supported_signature_algorithms_handler_t))]
	private static void TrampolineSignatureAlgorithmsForPeer(IntPtr block, ushort signatureAlgorithm)
	{
		BlockLiteral.GetTarget<Action<ushort>>(block)?.Invoke(signatureAlgorithm);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool sec_protocol_metadata_access_supported_signature_algorithms(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetSignatureAlgorithmsForPeerHandler(Action<ushort> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_SignatureAlgorithmsForPeer, callback);
		try
		{
			if (!sec_protocol_metadata_access_supported_signature_algorithms(GetCheckedHandle(), ref callback2))
			{
				throw new InvalidOperationException("The supported signature list is not accessible.");
			}
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern IntPtr sec_protocol_metadata_create_secret(IntPtr metadata, nuint label_len, [MarshalAs(UnmanagedType.LPStr)] string label, nuint exporter_length);

	public DispatchData CreateSecret(string label, nuint exporterLength)
	{
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		return CreateDispatchData(sec_protocol_metadata_create_secret(GetCheckedHandle(), (nuint)label.Length, label, exporterLength));
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private unsafe static extern IntPtr sec_protocol_metadata_create_secret_with_context(IntPtr metadata, nuint label_len, [MarshalAs(UnmanagedType.LPStr)] string label, nuint context_len, byte* context, nuint exporter_length);

	public unsafe DispatchData CreateSecret(string label, byte[] context, nuint exporterLength)
	{
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		fixed (byte* context2 = context)
		{
			return CreateDispatchData(sec_protocol_metadata_create_secret_with_context(GetCheckedHandle(), (nuint)label.Length, label, (nuint)context.Length, context2, exporterLength));
		}
	}

	internal static DispatchData CreateDispatchData(IntPtr handle)
	{
		return (handle == IntPtr.Zero) ? null : new DispatchData(handle, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern IntPtr sec_protocol_metadata_get_server_name(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern bool sec_protocol_metadata_access_pre_shared_keys(IntPtr handle, ref BlockLiteral block);

	[MonoPInvokeCallback(typeof(AccessPreSharedKeysHandler))]
	private static void TrampolineAccessPreSharedKeys(IntPtr block, IntPtr psk, IntPtr psk_identity)
	{
		BlockLiteral.GetTarget<Action<DispatchData, DispatchData>>(block)?.Invoke(CreateDispatchData(psk), CreateDispatchData(psk_identity));
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool AccessPreSharedKeys(SecAccessPreSharedKeysHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral block = default(BlockLiteral);
		try
		{
			block.SetupBlockUnsafe(presharedkeys, handler);
			return sec_protocol_metadata_access_pre_shared_keys(GetCheckedHandle(), ref block);
		}
		finally
		{
			block.CleanupBlock();
		}
	}
}
