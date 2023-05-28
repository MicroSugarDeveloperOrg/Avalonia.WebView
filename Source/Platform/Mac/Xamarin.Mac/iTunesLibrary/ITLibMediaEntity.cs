using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace iTunesLibrary;

[Register("ITLibMediaEntity", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class ITLibMediaEntity : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateValuesExceptForProperties_UsingBlock_ = "enumerateValuesExceptForProperties:usingBlock:";

	private static readonly IntPtr selEnumerateValuesExceptForProperties_UsingBlock_Handle = Selector.GetHandle("enumerateValuesExceptForProperties:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateValuesForProperties_UsingBlock_ = "enumerateValuesForProperties:usingBlock:";

	private static readonly IntPtr selEnumerateValuesForProperties_UsingBlock_Handle = Selector.GetHandle("enumerateValuesForProperties:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentID = "persistentID";

	private static readonly IntPtr selPersistentIDHandle = Selector.GetHandle("persistentID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForProperty_ = "valueForProperty:";

	private static readonly IntPtr selValueForProperty_Handle = Selector.GetHandle("valueForProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ITLibMediaEntity");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber PersistentId
	{
		[Export("persistentID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentIDHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ITLibMediaEntity()
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
	protected ITLibMediaEntity(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ITLibMediaEntity(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enumerateValuesForProperties:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateValues(NSSet<NSString>? properties, [BlockProxy(typeof(Trampolines.NIDITLibMediaEntityEnumerateValuesHandler))] ITLibMediaEntityEnumerateValuesHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDITLibMediaEntityEnumerateValuesHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnumerateValuesForProperties_UsingBlock_Handle, properties?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnumerateValuesForProperties_UsingBlock_Handle, properties?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateValuesExceptForProperties:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateValuesExcept(NSSet<NSString>? properties, [BlockProxy(typeof(Trampolines.NIDITLibMediaEntityEnumerateValuesHandler))] ITLibMediaEntityEnumerateValuesHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDITLibMediaEntityEnumerateValuesHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnumerateValuesExceptForProperties_UsingBlock_Handle, properties?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnumerateValuesExceptForProperties_UsingBlock_Handle, properties?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("valueForProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetValue(string property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		IntPtr arg = NSString.CreateNative(property);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForProperty_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForProperty_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
