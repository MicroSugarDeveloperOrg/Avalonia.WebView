using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using AudioToolbox;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioChannelLayout", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioChannelLayout : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[ThreadStatic]
	private static IntPtr handleToLayout;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelCount = "channelCount";

	private static readonly IntPtr selChannelCountHandle = Selector.GetHandle("channelCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLayout_ = "initWithLayout:";

	private static readonly IntPtr selInitWithLayout_Handle = Selector.GetHandle("initWithLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLayoutTag_ = "initWithLayoutTag:";

	private static readonly IntPtr selInitWithLayoutTag_Handle = Selector.GetHandle("initWithLayoutTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqual_ = "isEqual:";

	private static readonly IntPtr selIsEqual_Handle = Selector.GetHandle("isEqual:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayout = "layout";

	private static readonly IntPtr selLayoutHandle = Selector.GetHandle("layout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutTag = "layoutTag";

	private static readonly IntPtr selLayoutTagHandle = Selector.GetHandle("layoutTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioChannelLayout");

	public AudioChannelLayout Layout => AudioChannelLayout.FromHandle(_Layout);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ChannelCount
	{
		[Export("channelCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selChannelCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selChannelCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint LayoutTag
	{
		[Export("layoutTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selLayoutTagHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLayoutTagHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Layout
	{
		[Export("layout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutHandle);
		}
	}

	private static IntPtr CreateLayoutPtr(AudioChannelLayout layout)
	{
		handleToLayout = layout.ToBlock(out var _);
		return handleToLayout;
	}

	[DesignatedInitializer]
	public AVAudioChannelLayout(AudioChannelLayout layout)
		: this((nint)CreateLayoutPtr(layout))
	{
		Marshal.FreeHGlobal(handleToLayout);
	}

	public static bool operator ==(AVAudioChannelLayout a, AVAudioChannelLayout b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(AVAudioChannelLayout a, AVAudioChannelLayout b)
	{
		return !a.Equals(b);
	}

	[Obsolete("Valid instance of this type cannot be directly created.")]
	public AVAudioChannelLayout()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAudioChannelLayout(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioChannelLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioChannelLayout(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLayoutTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioChannelLayout(uint layoutTag)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selInitWithLayoutTag_Handle, layoutTag), "initWithLayoutTag:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selInitWithLayoutTag_Handle, layoutTag), "initWithLayoutTag:");
		}
	}

	[Export("initWithLayout:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal AVAudioChannelLayout(nint layout)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selInitWithLayout_Handle, layout), "initWithLayout:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selInitWithLayout_Handle, layout), "initWithLayout:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("isEqual:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual bool IsEqual(NSObject other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqual_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqual_Handle, other.Handle);
	}
}
