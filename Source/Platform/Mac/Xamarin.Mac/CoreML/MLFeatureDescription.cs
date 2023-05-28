using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLFeatureDescription", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MLFeatureDescription : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryConstraint = "dictionaryConstraint";

	private static readonly IntPtr selDictionaryConstraintHandle = Selector.GetHandle("dictionaryConstraint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageConstraint = "imageConstraint";

	private static readonly IntPtr selImageConstraintHandle = Selector.GetHandle("imageConstraint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAllowedValue_ = "isAllowedValue:";

	private static readonly IntPtr selIsAllowedValue_Handle = Selector.GetHandle("isAllowedValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOptional = "isOptional";

	private static readonly IntPtr selIsOptionalHandle = Selector.GetHandle("isOptional");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiArrayConstraint = "multiArrayConstraint";

	private static readonly IntPtr selMultiArrayConstraintHandle = Selector.GetHandle("multiArrayConstraint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSequenceConstraint = "sequenceConstraint";

	private static readonly IntPtr selSequenceConstraintHandle = Selector.GetHandle("sequenceConstraint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLFeatureDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DictionaryConstraint_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ImageConstraint_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_MultiArrayConstraint_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLDictionaryConstraint? DictionaryConstraint
	{
		[Export("dictionaryConstraint", ArgumentSemantic.Assign)]
		get
		{
			MLDictionaryConstraint mLDictionaryConstraint = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLDictionaryConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDictionaryConstraintHandle)) : Runtime.GetNSObject<MLDictionaryConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selDictionaryConstraintHandle)));
			MarkDirty();
			__mt_DictionaryConstraint_var = mLDictionaryConstraint;
			return mLDictionaryConstraint;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLImageConstraint? ImageConstraint
	{
		[Export("imageConstraint", ArgumentSemantic.Assign)]
		get
		{
			MLImageConstraint mLImageConstraint = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLImageConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageConstraintHandle)) : Runtime.GetNSObject<MLImageConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageConstraintHandle)));
			MarkDirty();
			__mt_ImageConstraint_var = mLImageConstraint;
			return mLImageConstraint;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMultiArrayConstraint? MultiArrayConstraint
	{
		[Export("multiArrayConstraint", ArgumentSemantic.Assign)]
		get
		{
			MLMultiArrayConstraint mLMultiArrayConstraint = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLMultiArrayConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMultiArrayConstraintHandle)) : Runtime.GetNSObject<MLMultiArrayConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selMultiArrayConstraintHandle)));
			MarkDirty();
			__mt_MultiArrayConstraint_var = mLMultiArrayConstraint;
			return mLMultiArrayConstraint;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Optional
	{
		[Export("isOptional")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOptionalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOptionalHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MLSequenceConstraint? SequenceConstraint
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("sequenceConstraint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLSequenceConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selSequenceConstraintHandle));
			}
			return Runtime.GetNSObject<MLSequenceConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSequenceConstraintHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLFeatureType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLFeatureType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (MLFeatureType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MLFeatureDescription()
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
	public MLFeatureDescription(NSCoder coder)
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
	protected MLFeatureDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLFeatureDescription(IntPtr handle)
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

	[Export("isAllowedValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAllowed(MLFeatureValue value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsAllowedValue_Handle, value.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsAllowedValue_Handle, value.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DictionaryConstraint_var = null;
			__mt_ImageConstraint_var = null;
			__mt_MultiArrayConstraint_var = null;
		}
	}
}
