using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWFramerMessage : NWProtocolMetadata
{
	private delegate void nw_framer_message_set_value_t(IntPtr block, IntPtr data);

	private delegate bool nw_framer_message_access_value_t(IntPtr block, IntPtr data);

	private static nw_framer_message_set_value_t static_SetDataHandler = TrampolineSetDataHandler;

	private static nw_framer_message_access_value_t static_AccessValueHandler = TrampolineAccessValueHandler;

	internal NWFramerMessage(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_protocol_create_message(IntPtr definition);

	public static NWFramerMessage Create(NWProtocolDefinition protocolDefinition)
	{
		if (protocolDefinition == null)
		{
			throw new ArgumentNullException("protocolDefinition");
		}
		return new NWFramerMessage(nw_framer_protocol_create_message(protocolDefinition.Handle), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_message_set_value(IntPtr message, string key, IntPtr value, ref BlockLiteral dispose_value);

	[MonoPInvokeCallback(typeof(nw_framer_message_set_value_t))]
	private static void TrampolineSetDataHandler(IntPtr block, IntPtr data)
	{
		BlockLiteral.GetTarget<Action<IntPtr>>(block)?.Invoke(data);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetData(string key, byte[] value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		GCHandle pinned = GCHandle.Alloc(value, GCHandleType.Pinned);
		Action<IntPtr> userDelegate = delegate
		{
			pinned.Free();
		};
		BlockLiteral dispose_value = default(BlockLiteral);
		dispose_value.SetupBlockUnsafe(static_SetDataHandler, userDelegate);
		try
		{
			nw_framer_message_set_value(GetCheckedHandle(), key, pinned.AddrOfPinnedObject(), ref dispose_value);
		}
		finally
		{
			dispose_value.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_framer_message_access_value(IntPtr message, string key, ref BlockLiteral access_value);

	[MonoPInvokeCallback(typeof(nw_framer_message_access_value_t))]
	private static bool TrampolineAccessValueHandler(IntPtr block, IntPtr data)
	{
		return BlockLiteral.GetTarget<Func<IntPtr, bool>>(block)?.Invoke(data) ?? false;
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe bool GetData(string key, int dataLength, out ReadOnlySpan<byte> outData)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		IntPtr outPointer = IntPtr.Zero;
		Func<IntPtr, bool> userDelegate = delegate(IntPtr inData)
		{
			if (inData != IntPtr.Zero)
			{
				outPointer = inData;
				return true;
			}
			return false;
		};
		BlockLiteral access_value = default(BlockLiteral);
		access_value.SetupBlockUnsafe(static_AccessValueHandler, userDelegate);
		try
		{
			bool flag = nw_framer_message_access_value(GetCheckedHandle(), key, ref access_value);
			if (flag)
			{
				outData = new ReadOnlySpan<byte>((void*)outPointer, dataLength);
			}
			else
			{
				outData = ReadOnlySpan<byte>.Empty;
			}
			return flag;
		}
		finally
		{
			access_value.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_message_set_object_value(IntPtr message, string key, IntPtr value);

	public void SetObject(string key, NSObject value)
	{
		nw_framer_message_set_object_value(GetCheckedHandle(), key, value.GetHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_message_copy_object_value(IntPtr message, string key);

	public T GetObject<T>(string key) where T : NSObject
	{
		return Runtime.GetNSObject<T>(nw_framer_message_copy_object_value(GetCheckedHandle(), key), owns: true);
	}
}
