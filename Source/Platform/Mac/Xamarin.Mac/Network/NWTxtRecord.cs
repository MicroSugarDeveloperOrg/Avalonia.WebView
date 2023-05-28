using System;
using System.Runtime.InteropServices;
using System.Text;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWTxtRecord : NativeObject
{
	private delegate byte nw_txt_record_apply_t(IntPtr block, IntPtr key, NWTxtRecordFindKey found, IntPtr value, nuint valueLen);

	public delegate void NWTxtRecordApplyDelegate(string key, NWTxtRecordFindKey rersult, ReadOnlySpan<byte> value);

	public delegate bool NWTxtRecordApplyDelegate2(string key, NWTxtRecordFindKey result, ReadOnlySpan<byte> value);

	private delegate void nw_txt_record_access_key_t(IntPtr block, IntPtr keyPointer, NWTxtRecordFindKey found, IntPtr value, nuint valueLen);

	public delegate void NWTxtRecordGetValueDelegete(string key, NWTxtRecordFindKey result, ReadOnlySpan<byte> value);

	private delegate void nw_txt_record_access_bytes_t(IntPtr block, IntPtr value, nuint valueLen);

	public delegate void NWTxtRecordGetRawByteDelegate(ReadOnlySpan<byte> value);

	private static nw_txt_record_apply_t static_ApplyHandler = TrampolineApplyHandler;

	private static nw_txt_record_access_key_t static_AccessKeyHandler = TrampolineAccessKeyHandler;

	private static nw_txt_record_access_bytes_t static_RawBytesHandler = TrampolineRawBytesHandler;

	public long KeyCount => nw_txt_record_get_key_count(GetCheckedHandle());

	public bool IsDictionary => nw_txt_record_is_dictionary(GetCheckedHandle()) != 0;

	internal NWTxtRecord(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern IntPtr nw_txt_record_create_with_bytes(byte* txtBytes, nuint len);

	public unsafe static NWTxtRecord FromBytes(ReadOnlySpan<byte> bytes)
	{
		fixed (byte* txtBytes = &bytes.GetPinnableReference())
		{
			IntPtr intPtr = nw_txt_record_create_with_bytes(txtBytes, (nuint)bytes.Length);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWTxtRecord(intPtr, owns: true);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_txt_record_create_dictionary();

	public static NWTxtRecord CreateDictionary()
	{
		IntPtr intPtr = nw_txt_record_create_dictionary();
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWTxtRecord(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_txt_record_copy(IntPtr other);

	public NWTxtRecord Clone()
	{
		return new NWTxtRecord(nw_txt_record_copy(GetCheckedHandle()), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWTxtRecordFindKey nw_txt_record_find_key(IntPtr handle, string key);

	public NWTxtRecordFindKey FindKey(string key)
	{
		return nw_txt_record_find_key(GetCheckedHandle(), key);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern byte nw_txt_record_set_key(IntPtr handle, string key, IntPtr value, nuint valueLen);

	public unsafe bool Add(string key, ReadOnlySpan<byte> value)
	{
		fixed (byte* ptr = &value.GetPinnableReference())
		{
			return nw_txt_record_set_key(GetCheckedHandle(), key, (IntPtr)ptr, (nuint)value.Length) != 0;
		}
	}

	public bool Add(string key)
	{
		return nw_txt_record_set_key(GetCheckedHandle(), key, IntPtr.Zero, (byte)0) != 0;
	}

	public bool Add(string key, string value)
            => Add(key, value is null ? null : Encoding.UTF8.GetBytes(value));

    [DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern byte nw_txt_record_remove_key(IntPtr handle, string key);

	public bool Remove(string key)
	{
		return nw_txt_record_remove_key(GetCheckedHandle(), key) != 0;
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern long nw_txt_record_get_key_count(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern byte nw_txt_record_is_dictionary(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_txt_record_is_equal(IntPtr left, IntPtr right);

	public bool Equals(NWTxtRecord other)
	{
		if (other == null)
		{
			return false;
		}
		return nw_txt_record_is_equal(GetCheckedHandle(), other.GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_txt_record_apply(IntPtr txt_record, ref BlockLiteral applier);

	[MonoPInvokeCallback(typeof(nw_txt_record_apply_t))]
	private unsafe static byte TrampolineApplyHandler(IntPtr block, IntPtr keyPointer, NWTxtRecordFindKey found, IntPtr value, nuint valueLen)
	{
        var del = BlockLiteral.GetTarget<MulticastDelegate>(block);
        if (del is null)
            return (byte)0;

        var mValue = new ReadOnlySpan<byte>((void*)value, (int)valueLen);
        var key = Marshal.PtrToStringAuto(keyPointer);

        if (del is NWTxtRecordApplyDelegate apply)
        {
            apply(key, found, mValue);
            return (byte)1;
        }
        if (del is NWTxtRecordApplyDelegate2 apply2)
            return apply2(key, found, mValue) ? (byte)1 : (byte)0; ;

        return (byte)0;
    }

	[Obsolete("Use the overload that takes an NWTxtRecordApplyDelegate2 instead.")]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool Apply(NWTxtRecordApplyDelegate handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral applier = default(BlockLiteral);
		applier.SetupBlockUnsafe(static_ApplyHandler, handler);
		try
		{
			return nw_txt_record_apply(GetCheckedHandle(), ref applier);
		}
		finally
		{
			applier.CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool Apply(NWTxtRecordApplyDelegate2 handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral applier = default(BlockLiteral);
		applier.SetupBlockUnsafe(static_ApplyHandler, handler);
		try
		{
			return nw_txt_record_apply(GetCheckedHandle(), ref applier);
		}
		finally
		{
			applier.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_txt_record_access_key(IntPtr txt_record, string key, ref BlockLiteral access_value);

	[MonoPInvokeCallback(typeof(nw_txt_record_access_key_t))]
	private unsafe static void TrampolineAccessKeyHandler(IntPtr block, IntPtr keyPointer, NWTxtRecordFindKey found, IntPtr value, nuint valueLen)
	{
        var del = BlockLiteral.GetTarget<NWTxtRecordGetValueDelegete>(block);
        if (del is not null)
        {
            ReadOnlySpan<byte> mValue;
            if (found == NWTxtRecordFindKey.NonEmptyValue)
                mValue = new ReadOnlySpan<byte>((void*)value, (int)valueLen);
            else
                mValue = Array.Empty<byte>();
            var key = Marshal.PtrToStringAuto(keyPointer);
            del(key, found, mValue);
        }
    }

	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool GetValue(string key, NWTxtRecordGetValueDelegete handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral access_value = default(BlockLiteral);
		access_value.SetupBlockUnsafe(static_AccessKeyHandler, handler);
		try
		{
			return nw_txt_record_access_key(GetCheckedHandle(), key, ref access_value);
		}
		finally
		{
			access_value.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_txt_record_access_bytes(IntPtr txt_record, ref BlockLiteral access_bytes);

	[MonoPInvokeCallback(typeof(nw_txt_record_access_bytes_t))]
	private unsafe static void TrampolineRawBytesHandler(IntPtr block, IntPtr value, nuint valueLen)
	{
        var del = BlockLiteral.GetTarget<NWTxtRecordGetRawByteDelegate>(block);
        if (del is not null)
        {
            var mValue = new ReadOnlySpan<byte>((void*)value, (int)valueLen);
            del(mValue);
        }
    }

	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool GetRawBytes(NWTxtRecordGetRawByteDelegate handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral access_bytes = default(BlockLiteral);
		access_bytes.SetupBlockUnsafe(static_RawBytesHandler, handler);
		try
		{
			return nw_txt_record_access_bytes(GetCheckedHandle(), ref access_bytes);
		}
		finally
		{
			access_bytes.CleanupBlock();
		}
	}
}
