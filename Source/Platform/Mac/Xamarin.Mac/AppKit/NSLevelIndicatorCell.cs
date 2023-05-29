using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLevelIndicatorCell", true)]
public class NSLevelIndicatorCell : NSActionCell
{
	private static readonly IntPtr selLevelIndicatorStyleHandle = Selector.GetHandle("levelIndicatorStyle");

	private static readonly IntPtr selSetLevelIndicatorStyle_Handle = Selector.GetHandle("setLevelIndicatorStyle:");

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	private static readonly IntPtr selSetMinValue_Handle = Selector.GetHandle("setMinValue:");

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	private static readonly IntPtr selSetMaxValue_Handle = Selector.GetHandle("setMaxValue:");

	private static readonly IntPtr selWarningValueHandle = Selector.GetHandle("warningValue");

	private static readonly IntPtr selSetWarningValue_Handle = Selector.GetHandle("setWarningValue:");

	private static readonly IntPtr selCriticalValueHandle = Selector.GetHandle("criticalValue");

	private static readonly IntPtr selSetCriticalValue_Handle = Selector.GetHandle("setCriticalValue:");

	private static readonly IntPtr selTickMarkPositionHandle = Selector.GetHandle("tickMarkPosition");

	private static readonly IntPtr selSetTickMarkPosition_Handle = Selector.GetHandle("setTickMarkPosition:");

	private static readonly IntPtr selNumberOfTickMarksHandle = Selector.GetHandle("numberOfTickMarks");

	private static readonly IntPtr selSetNumberOfTickMarks_Handle = Selector.GetHandle("setNumberOfTickMarks:");

	private static readonly IntPtr selNumberOfMajorTickMarksHandle = Selector.GetHandle("numberOfMajorTickMarks");

	private static readonly IntPtr selSetNumberOfMajorTickMarks_Handle = Selector.GetHandle("setNumberOfMajorTickMarks:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selInitWithLevelIndicatorStyle_Handle = Selector.GetHandle("initWithLevelIndicatorStyle:");

	private static readonly IntPtr selRectOfTickMarkAtIndex_Handle = Selector.GetHandle("rectOfTickMarkAtIndex:");

	private static readonly IntPtr selTickMarkValueAtIndex_Handle = Selector.GetHandle("tickMarkValueAtIndex:");

	private static readonly IntPtr selSetImage_Handle = Selector.GetHandle("setImage:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSLevelIndicatorCell");

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSLevelIndicatorStyle LevelIndicatorStyle
	{
		[Export("levelIndicatorStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLevelIndicatorStyle)Messaging.UInt64_objc_msgSend(base.Handle, selLevelIndicatorStyleHandle);
			}
			return (NSLevelIndicatorStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLevelIndicatorStyleHandle);
		}
		[Export("setLevelIndicatorStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLevelIndicatorStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLevelIndicatorStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual double MinValue
	{
		[Export("minValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinValueHandle);
		}
		[Export("setMinValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinValue_Handle, value);
			}
		}
	}

	public virtual double MaxValue
	{
		[Export("maxValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaxValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaxValueHandle);
		}
		[Export("setMaxValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMaxValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMaxValue_Handle, value);
			}
		}
	}

	public virtual double WarningValue
	{
		[Export("warningValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selWarningValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selWarningValueHandle);
		}
		[Export("setWarningValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetWarningValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetWarningValue_Handle, value);
			}
		}
	}

	public virtual double CriticalValue
	{
		[Export("criticalValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCriticalValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCriticalValueHandle);
		}
		[Export("setCriticalValue:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCriticalValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCriticalValue_Handle, value);
			}
		}
	}

	public virtual NSTickMarkPosition TickMarkPosition
	{
		[Export("tickMarkPosition")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTickMarkPosition)Messaging.UInt64_objc_msgSend(base.Handle, selTickMarkPositionHandle);
			}
			return (NSTickMarkPosition)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTickMarkPositionHandle);
		}
		[Export("setTickMarkPosition:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTickMarkPosition_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTickMarkPosition_Handle, (ulong)value);
			}
		}
	}

	public virtual long TickMarkCount
	{
		[Export("numberOfTickMarks")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfTickMarksHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfTickMarksHandle);
		}
		[Export("setNumberOfTickMarks:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetNumberOfTickMarks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNumberOfTickMarks_Handle, value);
			}
		}
	}

	public virtual long MajorTickMarkCount
	{
		[Export("numberOfMajorTickMarks")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfMajorTickMarksHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfMajorTickMarksHandle);
		}
		[Export("setNumberOfMajorTickMarks:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetNumberOfMajorTickMarks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetNumberOfMajorTickMarks_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLevelIndicatorCell()
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
	public NSLevelIndicatorCell(NSCoder coder)
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
	public NSLevelIndicatorCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLevelIndicatorCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSLevelIndicatorCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSLevelIndicatorCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
		}
	}

	[Export("initWithLevelIndicatorStyle:")]
	public NSLevelIndicatorCell(NSLevelIndicatorStyle levelIndicatorStyle)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithLevelIndicatorStyle_Handle, (ulong)levelIndicatorStyle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithLevelIndicatorStyle_Handle, (ulong)levelIndicatorStyle);
		}
	}

	[Export("rectOfTickMarkAtIndex:")]
	public virtual CGRect RectOfTickMarkAt(long index)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selRectOfTickMarkAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selRectOfTickMarkAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("tickMarkValueAtIndex:")]
	public virtual double TickMarkValueAt(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selTickMarkValueAtIndex_Handle, index);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selTickMarkValueAtIndex_Handle, index);
	}

	[Export("setImage:")]
	public virtual void SetImage(NSImage image)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImage_Handle, image.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImage_Handle, image.Handle);
		}
	}
}
