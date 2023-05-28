using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMediaSelection", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMediaSelection : NSObject, INSCopying, INativeObject, IDisposable, INSMutableCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup_ = "mediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup:";

	private static readonly IntPtr selMediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup_Handle = Selector.GetHandle("mediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedMediaOptionInMediaSelectionGroup_ = "selectedMediaOptionInMediaSelectionGroup:";

	private static readonly IntPtr selSelectedMediaOptionInMediaSelectionGroup_Handle = Selector.GetHandle("selectedMediaOptionInMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMediaSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Asset_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAsset? Asset
	{
		[Export("asset", ArgumentSemantic.Weak)]
		get
		{
			AVAsset aVAsset = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle)) : Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle)));
			MarkDirty();
			__mt_Asset_var = aVAsset;
			return aVAsset;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMediaSelection()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMediaSelection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMediaSelection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("mediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup(AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selMediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup_Handle, mediaSelectionGroup.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaSelectionCriteriaCanBeAppliedAutomaticallyToMediaSelectionGroup_Handle, mediaSelectionGroup.Handle);
	}

	[Export("selectedMediaOptionInMediaSelectionGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionOption? GetSelectedMediaOption(AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSelectedMediaOptionInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle));
		}
		return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectedMediaOptionInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle));
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Asset_var = null;
		}
	}
}
