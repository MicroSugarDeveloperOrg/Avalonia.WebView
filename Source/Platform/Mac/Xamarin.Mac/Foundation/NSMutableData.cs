using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableData", true)]
public class NSMutableData : NSData, IEnumerable, IEnumerable<byte>
{
	private static readonly IntPtr selMutableBytesHandle = Selector.GetHandle("mutableBytes");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selSetLength_Handle = Selector.GetHandle("setLength:");

	private static readonly IntPtr selDataWithCapacity_Handle = Selector.GetHandle("dataWithCapacity:");

	private static readonly IntPtr selDataWithLength_Handle = Selector.GetHandle("dataWithLength:");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	private static readonly IntPtr selAppendData_Handle = Selector.GetHandle("appendData:");

	private static readonly IntPtr selAppendBytesLength_Handle = Selector.GetHandle("appendBytes:length:");

	private static readonly IntPtr selSetData_Handle = Selector.GetHandle("setData:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableData");

	public override byte this[int idx]
	{
		set
		{
			if (idx < 0 || idx >= int.MaxValue || idx > (int)Length)
			{
				throw new ArgumentException("idx");
			}
			Marshal.WriteByte(Bytes, idx, value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual IntPtr MutableBytes
	{
		[Export("mutableBytes")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selMutableBytesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMutableBytesHandle);
		}
	}

	public override ulong Length
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
		[Export("setLength:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLength_Handle, value);
			}
		}
	}

	public unsafe void AppendBytes(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		fixed (byte* ptr = &bytes[0])
		{
			AppendBytes((IntPtr)ptr, (uint)bytes.Length);
		}
	}

	public unsafe void AppendBytes(byte[] bytes, int start, int len)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (start < 0 || start > bytes.Length)
		{
			throw new ArgumentException("start");
		}
		if (start + len > bytes.Length)
		{
			throw new ArgumentException("len");
		}
		fixed (byte* ptr = &bytes[start])
		{
			AppendBytes((IntPtr)ptr, (uint)len);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IntPtr source = Bytes;
		int top = (int)Length;
		for (int i = 0; i < top; i++)
		{
			if (source == Bytes && top == (int)Length)
			{
				yield return Marshal.ReadByte(source, i);
				continue;
			}
			throw new InvalidOperationException("The NSMutableData has changed");
		}
	}

	IEnumerator<byte> IEnumerable<byte>.GetEnumerator()
	{
		IntPtr source = Bytes;
		int top = (int)Length;
		for (int i = 0; i < top; i++)
		{
			if (source == Bytes && top == (int)Length)
			{
				yield return Marshal.ReadByte(source, i);
				continue;
			}
			throw new InvalidOperationException("The NSMutableData has changed");
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableData()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableData(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableData(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dataWithCapacity:")]
	public static NSMutableData FromCapacity(ulong capacity)
	{
		using (new NSAutoreleasePool())
		{
			return (NSMutableData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selDataWithCapacity_Handle, capacity));
		}
	}

	[Export("dataWithLength:")]
	public static NSMutableData FromLength(ulong length)
	{
		using (new NSAutoreleasePool())
		{
			return (NSMutableData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selDataWithLength_Handle, length));
		}
	}

	[Export("data")]
	public static NSMutableData Create()
	{
		using (new NSAutoreleasePool())
		{
			return (NSMutableData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDataHandle));
		}
	}

	[Export("setLength:")]
	public virtual void SetLength(ulong len)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLength_Handle, len);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLength_Handle, len);
		}
	}

	[Export("initWithCapacity:")]
	public NSMutableData(ulong len)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithCapacity_Handle, len);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithCapacity_Handle, len);
		}
	}

	[Export("appendData:")]
	public virtual void AppendData(NSData other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendData_Handle, other.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendData_Handle, other.Handle);
		}
	}

	[Export("appendBytes:length:")]
	public virtual void AppendBytes(IntPtr bytes, ulong len)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selAppendBytesLength_Handle, bytes, len);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selAppendBytesLength_Handle, bytes, len);
		}
	}

	[Export("setData:")]
	public virtual void SetData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetData_Handle, data.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetData_Handle, data.Handle);
		}
	}
}
