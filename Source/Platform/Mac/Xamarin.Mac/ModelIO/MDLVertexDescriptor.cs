using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using Metal;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLVertexDescriptor", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLVertexDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOrReplaceAttribute_ = "addOrReplaceAttribute:";

	private static readonly IntPtr selAddOrReplaceAttribute_Handle = Selector.GetHandle("addOrReplaceAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeNamed_ = "attributeNamed:";

	private static readonly IntPtr selAttributeNamed_Handle = Selector.GetHandle("attributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVertexDescriptor_ = "initWithVertexDescriptor:";

	private static readonly IntPtr selInitWithVertexDescriptor_Handle = Selector.GetHandle("initWithVertexDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayouts = "layouts";

	private static readonly IntPtr selLayoutsHandle = Selector.GetHandle("layouts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttributeNamed_ = "removeAttributeNamed:";

	private static readonly IntPtr selRemoveAttributeNamed_Handle = Selector.GetHandle("removeAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributes_ = "setAttributes:";

	private static readonly IntPtr selSetAttributes_Handle = Selector.GetHandle("setAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayouts_ = "setLayouts:";

	private static readonly IntPtr selSetLayouts_Handle = Selector.GetHandle("setLayouts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPackedOffsets = "setPackedOffsets";

	private static readonly IntPtr selSetPackedOffsetsHandle = Selector.GetHandle("setPackedOffsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPackedStrides = "setPackedStrides";

	private static readonly IntPtr selSetPackedStridesHandle = Selector.GetHandle("setPackedStrides");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLVertexDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableArray<MDLVertexAttribute> Attributes
	{
		[Export("attributes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableArray<MDLVertexAttribute>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<NSMutableArray<MDLVertexAttribute>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
		[Export("setAttributes:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableArray<MDLVertexBufferLayout> Layouts
	{
		[Export("layouts", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableArray<MDLVertexBufferLayout>>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutsHandle));
			}
			return Runtime.GetNSObject<NSMutableArray<MDLVertexBufferLayout>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutsHandle));
		}
		[Export("setLayouts:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayouts_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayouts_Handle, value.Handle);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/MetalKit.framework/MetalKit")]
	private static extern IntPtr MTKModelIOVertexDescriptorFromMetal(IntPtr mtlDescriptor);

	public static MDLVertexDescriptor FromMetal(MTLVertexDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentException("descriptor");
		}
		return Runtime.GetNSObject<MDLVertexDescriptor>(MTKModelIOVertexDescriptorFromMetal(descriptor.Handle));
	}

	[DllImport("/System/Library/Frameworks/MetalKit.framework/MetalKit")]
	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	private static extern IntPtr MTKModelIOVertexDescriptorFromMetalWithError(IntPtr metalDescriptor, out IntPtr error);

	[iOS(10, 0)]
	[Mac(10, 12)]
	[TV(10, 0)]
	public static MDLVertexDescriptor FromMetal(MTLVertexDescriptor descriptor, out NSError error)
	{
		if (descriptor == null)
		{
			throw new ArgumentException("descriptor");
		}
		IntPtr error2;
		MDLVertexDescriptor nSObject = Runtime.GetNSObject<MDLVertexDescriptor>(MTKModelIOVertexDescriptorFromMetalWithError(descriptor.Handle, out error2));
		error = Runtime.GetNSObject<NSError>(error2);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLVertexDescriptor()
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
	protected MDLVertexDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLVertexDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithVertexDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLVertexDescriptor(MDLVertexDescriptor vertexDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (vertexDescriptor == null)
		{
			throw new ArgumentNullException("vertexDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithVertexDescriptor_Handle, vertexDescriptor.Handle), "initWithVertexDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithVertexDescriptor_Handle, vertexDescriptor.Handle), "initWithVertexDescriptor:");
		}
	}

	[Export("addOrReplaceAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOrReplaceAttribute(MDLVertexAttribute attribute)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOrReplaceAttribute_Handle, attribute.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOrReplaceAttribute_Handle, attribute.Handle);
		}
	}

	[Export("attributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLVertexAttribute? AttributeNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLVertexAttribute result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLVertexAttribute>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeNamed_Handle, arg)) : Runtime.GetNSObject<MDLVertexAttribute>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("removeAttributeNamed:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAttributeNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttributeNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("setPackedOffsets")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPackedOffsets()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetPackedOffsetsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetPackedOffsetsHandle);
		}
	}

	[Export("setPackedStrides")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetPackedStrides()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetPackedStridesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetPackedStridesHandle);
		}
	}
}
