using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKLocalSearchCompletion", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
public class MKLocalSearchCompletion : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtitle = "subtitle";

	private static readonly IntPtr selSubtitleHandle = Selector.GetHandle("subtitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtitleHighlightRanges = "subtitleHighlightRanges";

	private static readonly IntPtr selSubtitleHighlightRangesHandle = Selector.GetHandle("subtitleHighlightRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitleHighlightRanges = "titleHighlightRanges";

	private static readonly IntPtr selTitleHighlightRangesHandle = Selector.GetHandle("titleHighlightRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKLocalSearchCompletion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Subtitle
	{
		[Export("subtitle", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] SubtitleHighlightRanges
	{
		[Export("subtitleHighlightRanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtitleHighlightRangesHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtitleHighlightRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] TitleHighlightRanges
	{
		[Export("titleHighlightRanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHighlightRangesHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHighlightRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKLocalSearchCompletion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKLocalSearchCompletion(IntPtr handle)
		: base(handle)
	{
	}
}
