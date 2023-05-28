using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[Register("AUParameterTree", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AUParameterTree : AUParameterGroup, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateGroupFromTemplate_Identifier_Name_AddressOffset_ = "createGroupFromTemplate:identifier:name:addressOffset:";

	private static readonly IntPtr selCreateGroupFromTemplate_Identifier_Name_AddressOffset_Handle = Selector.GetHandle("createGroupFromTemplate:identifier:name:addressOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateGroupTemplate_ = "createGroupTemplate:";

	private static readonly IntPtr selCreateGroupTemplate_Handle = Selector.GetHandle("createGroupTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateGroupWithIdentifier_Name_Children_ = "createGroupWithIdentifier:name:children:";

	private static readonly IntPtr selCreateGroupWithIdentifier_Name_Children_Handle = Selector.GetHandle("createGroupWithIdentifier:name:children:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateParameterWithIdentifier_Name_Address_Min_Max_Unit_UnitName_Flags_ValueStrings_DependentParameters_ = "createParameterWithIdentifier:name:address:min:max:unit:unitName:flags:valueStrings:dependentParameters:";

	private static readonly IntPtr selCreateParameterWithIdentifier_Name_Address_Min_Max_Unit_UnitName_Flags_ValueStrings_DependentParameters_Handle = Selector.GetHandle("createParameterWithIdentifier:name:address:min:max:unit:unitName:flags:valueStrings:dependentParameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateTreeWithChildren_ = "createTreeWithChildren:";

	private static readonly IntPtr selCreateTreeWithChildren_Handle = Selector.GetHandle("createTreeWithChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterWithAddress_ = "parameterWithAddress:";

	private static readonly IntPtr selParameterWithAddress_Handle = Selector.GetHandle("parameterWithAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterWithID_Scope_Element_ = "parameterWithID:scope:element:";

	private static readonly IntPtr selParameterWithID_Scope_Element_Handle = Selector.GetHandle("parameterWithID:scope:element:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUParameterTree");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AUParameterTree()
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
	public AUParameterTree(NSCoder coder)
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
	protected AUParameterTree(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUParameterTree(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createGroupWithIdentifier:name:children:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AUParameterGroup CreateGroup(string identifier, string name, AUParameterNode[] children)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (children == null)
		{
			throw new ArgumentNullException("children");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(name);
		NSArray nSArray = NSArray.FromNSObjects(children);
		AUParameterGroup nSObject = Runtime.GetNSObject<AUParameterGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selCreateGroupWithIdentifier_Name_Children_Handle, arg, arg2, nSArray.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("createGroupFromTemplate:identifier:name:addressOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AUParameterGroup CreateGroup(AUParameterGroup templateGroup, string identifier, string name, ulong addressOffset)
	{
		if (templateGroup == null)
		{
			throw new ArgumentNullException("templateGroup");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(name);
		AUParameterGroup nSObject = Runtime.GetNSObject<AUParameterGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(class_ptr, selCreateGroupFromTemplate_Identifier_Name_AddressOffset_Handle, templateGroup.Handle, arg, arg2, addressOffset));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("createGroupTemplate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AUParameterGroup CreateGroupTemplate(AUParameterNode[] children)
	{
		if (children == null)
		{
			throw new ArgumentNullException("children");
		}
		NSArray nSArray = NSArray.FromNSObjects(children);
		AUParameterGroup nSObject = Runtime.GetNSObject<AUParameterGroup>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreateGroupTemplate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("createParameterWithIdentifier:name:address:min:max:unit:unitName:flags:valueStrings:dependentParameters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AUParameter CreateParameter(string identifier, string name, ulong address, float min, float max, AudioUnitParameterUnit unit, string? unitName, AudioUnitParameterOptions flags, string[]? valueStrings, NSNumber[]? dependentParameters)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(name);
		IntPtr arg3 = NSString.CreateNative(unitName);
		NSArray nSArray = ((valueStrings == null) ? null : NSArray.FromStrings(valueStrings));
		NSArray nSArray2 = ((dependentParameters == null) ? null : NSArray.FromNSObjects(dependentParameters));
		AUParameter nSObject = Runtime.GetNSObject<AUParameter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_float_float_int_IntPtr_UInt32_IntPtr_IntPtr(class_ptr, selCreateParameterWithIdentifier_Name_Address_Min_Max_Unit_UnitName_Flags_ValueStrings_DependentParameters_Handle, arg, arg2, address, min, max, (int)unit, arg3, (uint)flags, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		nSArray?.Dispose();
		nSArray2?.Dispose();
		return nSObject;
	}

	[Export("createTreeWithChildren:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AUParameterTree CreateTree(AUParameterNode[] children)
	{
		if (children == null)
		{
			throw new ArgumentNullException("children");
		}
		NSArray nSArray = NSArray.FromNSObjects(children);
		AUParameterTree nSObject = Runtime.GetNSObject<AUParameterTree>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreateTreeWithChildren_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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

	[Export("parameterWithAddress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUParameter? GetParameter(ulong address)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AUParameter>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selParameterWithAddress_Handle, address));
		}
		return Runtime.GetNSObject<AUParameter>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selParameterWithAddress_Handle, address));
	}

	[Export("parameterWithID:scope:element:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AUParameter? GetParameter(uint paramID, uint scope, uint element)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AUParameter>(Messaging.IntPtr_objc_msgSend_UInt32_UInt32_UInt32(base.Handle, selParameterWithID_Scope_Element_Handle, paramID, scope, element));
		}
		return Runtime.GetNSObject<AUParameter>(Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32_UInt32(base.SuperHandle, selParameterWithID_Scope_Element_Handle, paramID, scope, element));
	}
}
