using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWContentContext : NativeObject
{
	private delegate void ProtocolIterator(IntPtr block, IntPtr definition, IntPtr metadata);

	private bool global;

	private static ProtocolIterator static_ProtocolIterator = TrampolineProtocolIterator;

	private static NWContentContext defaultMessage;

	private static NWContentContext finalMessage;

	private static NWContentContext defaultStream;

	public string Identifier => Marshal.PtrToStringAnsi(nw_content_context_get_identifier(GetCheckedHandle()));

	public bool IsFinal
	{
		get
		{
			return nw_content_context_get_is_final(GetCheckedHandle());
		}
		set
		{
			nw_content_context_set_is_final(GetCheckedHandle(), value);
		}
	}

	public ulong ExpirationMilliseconds
	{
		get
		{
			return nw_content_context_get_expiration_milliseconds(GetCheckedHandle());
		}
		set
		{
			nw_content_context_set_expiration_milliseconds(GetCheckedHandle(), value);
		}
	}

	public double RelativePriority
	{
		get
		{
			return nw_content_context_get_relative_priority(GetCheckedHandle());
		}
		set
		{
			nw_content_context_set_relative_priority(GetCheckedHandle(), value);
		}
	}

	public NWContentContext Antecedent
	{
		get
		{
			IntPtr intPtr = nw_content_context_copy_antecedent(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWContentContext(intPtr, owns: true);
		}
		set
		{
			nw_content_context_set_antecedent(GetCheckedHandle(), value.GetHandle());
		}
	}

	public static NWContentContext DefaultMessage
	{
		get
		{
			if (defaultMessage == null)
			{
				defaultMessage = MakeGlobal(NWContentContextConstants._DefaultMessage);
			}
			return defaultMessage;
		}
	}

	public static NWContentContext FinalMessage
	{
		get
		{
			if (finalMessage == null)
			{
				finalMessage = MakeGlobal(NWContentContextConstants._FinalSend);
			}
			return finalMessage;
		}
	}

	public static NWContentContext DefaultStream
	{
		get
		{
			if (defaultStream == null)
			{
				defaultStream = MakeGlobal(NWContentContextConstants._DefaultStream);
			}
			return defaultStream;
		}
	}

	public NWContentContext(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	private NWContentContext(IntPtr handle, bool owns, bool global)
		: base(handle, owns)
	{
		this.global = global;
	}

	private static NWContentContext MakeGlobal(IntPtr handle)
	{
		return new NWContentContext(handle, owns: true, global: true);
	}

	protected override void Release()
	{
		if (!global)
		{
			base.Release();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_content_context_create(string contextIdentifier);

	public NWContentContext(string contextIdentifier)
	{
		if (contextIdentifier == null)
		{
			throw new ArgumentNullException("contextIdentifier");
		}
		InitializeHandle(nw_content_context_create(contextIdentifier));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_content_context_get_identifier(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_content_context_get_is_final(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_content_context_set_is_final(IntPtr handle, [MarshalAs(UnmanagedType.I1)] bool is_final);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_content_context_get_expiration_milliseconds(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_content_context_set_expiration_milliseconds(IntPtr handle, ulong value);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern double nw_content_context_get_relative_priority(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_content_context_set_relative_priority(IntPtr handle, double value);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_content_context_copy_antecedent(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_content_context_set_antecedent(IntPtr handle, IntPtr value);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_content_context_copy_protocol_metadata(IntPtr handle, IntPtr protocol);

	public NWProtocolMetadata GetProtocolMetadata(NWProtocolDefinition protocolDefinition)
	{
		if (protocolDefinition == null)
		{
			throw new ArgumentNullException("protocolDefinition");
		}
		IntPtr intPtr = nw_content_context_copy_protocol_metadata(GetCheckedHandle(), protocolDefinition.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWProtocolMetadata(intPtr, owns: true);
	}

	public T GetProtocolMetadata<T>(NWProtocolDefinition protocolDefinition) where T : NWProtocolMetadata
	{
		if (protocolDefinition == null)
		{
			throw new ArgumentNullException("protocolDefinition");
		}
		IntPtr ptr = nw_content_context_copy_protocol_metadata(GetCheckedHandle(), protocolDefinition.Handle);
		return Runtime.GetINativeObject<T>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_content_context_set_metadata_for_protocol(IntPtr handle, IntPtr protocolMetadata);

	public void SetMetadata(NWProtocolMetadata protocolMetadata)
	{
		if (protocolMetadata == null)
		{
			throw new ArgumentNullException("protocolMetadata");
		}
		nw_content_context_set_metadata_for_protocol(GetCheckedHandle(), protocolMetadata.Handle);
	}

	[MonoPInvokeCallback(typeof(ProtocolIterator))]
	private static void TrampolineProtocolIterator(IntPtr block, IntPtr definition, IntPtr metadata)
	{
		Action<NWProtocolDefinition, NWProtocolMetadata> target = BlockLiteral.GetTarget<Action<NWProtocolDefinition, NWProtocolMetadata>>(block);
		if (target != null)
		{
			NWProtocolDefinition nWProtocolDefinition = ((definition == IntPtr.Zero) ? null : new NWProtocolDefinition(definition, owns: true));
			NWProtocolMetadata nWProtocolMetadata = ((metadata == IntPtr.Zero) ? null : new NWProtocolMetadata(metadata, owns: true));
			target(nWProtocolDefinition, nWProtocolMetadata);
			nWProtocolDefinition?.Dispose();
			nWProtocolMetadata?.Dispose();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_content_context_foreach_protocol_metadata(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void IterateProtocolMetadata(Action<NWProtocolDefinition, NWProtocolMetadata> callback)
	{
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ProtocolIterator, callback);
		try
		{
			nw_content_context_foreach_protocol_metadata(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}
}
