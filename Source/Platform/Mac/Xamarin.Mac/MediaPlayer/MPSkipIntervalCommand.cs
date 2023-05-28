using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPSkipIntervalCommand", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPSkipIntervalCommand : MPRemoteCommand
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredIntervals = "preferredIntervals";

	private static readonly IntPtr selPreferredIntervalsHandle = Selector.GetHandle("preferredIntervals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredIntervals_ = "setPreferredIntervals:";

	private static readonly IntPtr selSetPreferredIntervals_Handle = Selector.GetHandle("setPreferredIntervals:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSkipIntervalCommand");

	public double[] PreferredIntervals
	{
		get
		{
			NSArray preferredIntervals = _PreferredIntervals;
			if (preferredIntervals == null)
			{
				return null;
			}
			return NSArray.ArrayFromHandle(preferredIntervals.Handle, (IntPtr input) => new NSNumber(input).DoubleValue);
		}
		set
		{
			if (value == null)
			{
				_PreferredIntervals = null;
				return;
			}
			NSObject[] array = new NSObject[value.Length];
			for (int i = 0; i < value.Length; i++)
			{
				array[i] = new NSNumber(value[i]);
			}
			_PreferredIntervals = NSArray.FromNSObjects(array);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSArray _PreferredIntervals
	{
		[Export("preferredIntervals")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredIntervalsHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredIntervalsHandle));
		}
		[Export("setPreferredIntervals:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreferredIntervals_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreferredIntervals_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSkipIntervalCommand(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSkipIntervalCommand(IntPtr handle)
		: base(handle)
	{
	}
}
