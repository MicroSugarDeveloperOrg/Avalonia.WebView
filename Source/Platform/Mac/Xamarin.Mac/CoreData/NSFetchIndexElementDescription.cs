using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSFetchIndexElementDescription", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class NSFetchIndexElementDescription : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollationType = "collationType";

	private static readonly IntPtr selCollationTypeHandle = Selector.GetHandle("collationType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexDescription = "indexDescription";

	private static readonly IntPtr selIndexDescriptionHandle = Selector.GetHandle("indexDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProperty_CollationType_ = "initWithProperty:collationType:";

	private static readonly IntPtr selInitWithProperty_CollationType_Handle = Selector.GetHandle("initWithProperty:collationType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAscending = "isAscending";

	private static readonly IntPtr selIsAscendingHandle = Selector.GetHandle("isAscending");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProperty = "property";

	private static readonly IntPtr selPropertyHandle = Selector.GetHandle("property");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyName = "propertyName";

	private static readonly IntPtr selPropertyNameHandle = Selector.GetHandle("propertyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAscending_ = "setAscending:";

	private static readonly IntPtr selSetAscending_Handle = Selector.GetHandle("setAscending:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCollationType_ = "setCollationType:";

	private static readonly IntPtr selSetCollationType_Handle = Selector.GetHandle("setCollationType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFetchIndexElementDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_IndexDescription_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchIndexElementType CollationType
	{
		[Export("collationType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFetchIndexElementType)Messaging.UInt64_objc_msgSend(base.Handle, selCollationTypeHandle);
			}
			return (NSFetchIndexElementType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCollationTypeHandle);
		}
		[Export("setCollationType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCollationType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCollationType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchIndexDescription? IndexDescription
	{
		[Export("indexDescription", ArgumentSemantic.Assign)]
		get
		{
			NSFetchIndexDescription nSFetchIndexDescription = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFetchIndexDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexDescriptionHandle)) : Runtime.GetNSObject<NSFetchIndexDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexDescriptionHandle)));
			MarkDirty();
			__mt_IndexDescription_var = nSFetchIndexDescription;
			return nSFetchIndexDescription;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAscending
	{
		[Export("isAscending")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAscendingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAscendingHandle);
		}
		[Export("setAscending:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAscending_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAscending_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPropertyDescription? Property
	{
		[Export("property", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPropertyDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyHandle));
			}
			return Runtime.GetNSObject<NSPropertyDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? PropertyName
	{
		[Export("propertyName", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFetchIndexElementDescription()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFetchIndexElementDescription(NSCoder coder)
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
	protected NSFetchIndexElementDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFetchIndexElementDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProperty:collationType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFetchIndexElementDescription(NSPropertyDescription property, NSFetchIndexElementType collationType)
		: base(NSObjectFlag.Empty)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithProperty_CollationType_Handle, property.Handle, (ulong)collationType), "initWithProperty:collationType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithProperty_CollationType_Handle, property.Handle, (ulong)collationType), "initWithProperty:collationType:");
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_IndexDescription_var = null;
		}
	}
}
