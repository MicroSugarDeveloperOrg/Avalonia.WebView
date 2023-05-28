using System;
using ObjCRuntime;

namespace Foundation;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NSRunLoopModeExtensions
{
	private static IntPtr[] values = new IntPtr[5];

	[Field("NSDefaultRunLoopMode", "Foundation")]
	internal unsafe static IntPtr NSDefaultRunLoopMode
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSDefaultRunLoopMode", storage);
			}
		}
	}

	[Field("NSRunLoopCommonModes", "Foundation")]
	internal unsafe static IntPtr NSRunLoopCommonModes
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSRunLoopCommonModes", storage);
			}
		}
	}

	[Field("NSConnectionReplyMode", "Foundation")]
	internal unsafe static IntPtr NSConnectionReplyMode
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Foundation.Handle, "NSConnectionReplyMode", storage);
			}
		}
	}

	[Field("NSModalPanelRunLoopMode", "AppKit")]
	internal unsafe static IntPtr NSModalPanelRunLoopMode
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSModalPanelRunLoopMode", storage);
			}
		}
	}

	[Field("NSEventTrackingRunLoopMode", "AppKit")]
	internal unsafe static IntPtr NSEventTrackingRunLoopMode
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.AppKit.Handle, "NSEventTrackingRunLoopMode", storage);
			}
		}
	}

	public static NSString[] GetConstants(this NSRunLoopMode[] self)
	{
		if (self == null)
		{
			throw new ArgumentNullException("self");
		}
		NSString[] array = new NSString[self.Length];
		for (int i = 0; i < self.Length; i++)
		{
			array[i] = self[i].GetConstant();
		}
		return array;
	}

	public static NSString? GetConstant(this NSRunLoopMode self)
	{
		IntPtr zero = IntPtr.Zero;
		return (NSString)Runtime.GetNSObject((int)self switch
		{
			1 => NSRunLoopCommonModes, 
			2 => NSConnectionReplyMode, 
			3 => NSModalPanelRunLoopMode, 
			4 => NSEventTrackingRunLoopMode, 
			_ => NSDefaultRunLoopMode, 
		});
	}

	public static NSRunLoopMode GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return NSRunLoopMode.Other;
		}
		if (constant.IsEqualTo(NSDefaultRunLoopMode))
		{
			return NSRunLoopMode.Default;
		}
		if (constant.IsEqualTo(NSRunLoopCommonModes))
		{
			return NSRunLoopMode.Common;
		}
		if (constant.IsEqualTo(NSConnectionReplyMode))
		{
			return NSRunLoopMode.ConnectionReply;
		}
		if (constant.IsEqualTo(NSModalPanelRunLoopMode))
		{
			return NSRunLoopMode.ModalPanel;
		}
		if (constant.IsEqualTo(NSEventTrackingRunLoopMode))
		{
			return NSRunLoopMode.EventTracking;
		}
		return NSRunLoopMode.Default;
	}
}
