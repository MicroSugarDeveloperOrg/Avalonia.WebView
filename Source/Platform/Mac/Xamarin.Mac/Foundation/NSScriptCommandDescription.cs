using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSScriptCommandDescription", true)]
public class NSScriptCommandDescription : NSObject, INSCoding, INativeObject, IDisposable
{
	private NSScriptCommandDescriptionDictionary description = null;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEventClassCode = "appleEventClassCode";

	private static readonly IntPtr selAppleEventClassCodeHandle = Selector.GetHandle("appleEventClassCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEventCode = "appleEventCode";

	private static readonly IntPtr selAppleEventCodeHandle = Selector.GetHandle("appleEventCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEventCodeForArgumentWithName_ = "appleEventCodeForArgumentWithName:";

	private static readonly IntPtr selAppleEventCodeForArgumentWithName_Handle = Selector.GetHandle("appleEventCodeForArgumentWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEventCodeForReturnType = "appleEventCodeForReturnType";

	private static readonly IntPtr selAppleEventCodeForReturnTypeHandle = Selector.GetHandle("appleEventCodeForReturnType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArgumentNames = "argumentNames";

	private static readonly IntPtr selArgumentNamesHandle = Selector.GetHandle("argumentNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandClassName = "commandClassName";

	private static readonly IntPtr selCommandClassNameHandle = Selector.GetHandle("commandClassName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommandName = "commandName";

	private static readonly IntPtr selCommandNameHandle = Selector.GetHandle("commandName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCommandInstance = "createCommandInstance";

	private static readonly IntPtr selCreateCommandInstanceHandle = Selector.GetHandle("createCommandInstance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSuiteName_CommandName_Dictionary_ = "initWithSuiteName:commandName:dictionary:";

	private static readonly IntPtr selInitWithSuiteName_CommandName_Dictionary_Handle = Selector.GetHandle("initWithSuiteName:commandName:dictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOptionalArgumentWithName_ = "isOptionalArgumentWithName:";

	private static readonly IntPtr selIsOptionalArgumentWithName_Handle = Selector.GetHandle("isOptionalArgumentWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReturnType = "returnType";

	private static readonly IntPtr selReturnTypeHandle = Selector.GetHandle("returnType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuiteName = "suiteName";

	private static readonly IntPtr selSuiteNameHandle = Selector.GetHandle("suiteName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypeForArgumentWithName_ = "typeForArgumentWithName:";

	private static readonly IntPtr selTypeForArgumentWithName_Handle = Selector.GetHandle("typeForArgumentWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScriptCommandDescription");

	public string AppleEventClassCode => ToFourCCString(FCCAppleEventClassCode);

	public string AppleEventCode => ToFourCCString(FCCAppleEventCode);

	public string AppleEventCodeForReturnType => ToFourCCString(FCCAppleEventCodeForReturnType);

	public NSDictionary Dictionary => description.Dictionary;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] ArgumentNames
	{
		[Export("argumentNames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selArgumentNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArgumentNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ClassName
	{
		[Export("commandClassName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandClassNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int FCCAppleEventClassCode
	{
		[Export("appleEventClassCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selAppleEventClassCodeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selAppleEventClassCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int FCCAppleEventCode
	{
		[Export("appleEventCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selAppleEventCodeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selAppleEventCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int FCCAppleEventCodeForReturnType
	{
		[Export("appleEventCodeForReturnType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selAppleEventCodeForReturnTypeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selAppleEventCodeForReturnTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("commandName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommandNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommandNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ReturnType
	{
		[Export("returnType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReturnTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReturnTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SuitName
	{
		[Export("suiteName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSuiteNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuiteNameHandle));
		}
	}

	private static string ToFourCCString(int value)
	{
		return new string(new char[4]
		{
			(char)(byte)(value >> 24),
			(char)(byte)(value >> 16),
			(char)(byte)(value >> 8),
			(char)(byte)value
		});
	}

	private static int ToIntValue(string fourCC)
	{
		if (fourCC.Length != 4)
		{
			throw new FormatException(string.Format("{0} must have a lenght of 4", "fourCC"));
		}
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			num <<= 8;
			num |= fourCC[i];
		}
		return num;
	}

	public static NSScriptCommandDescription Create(string suiteName, string commandName, NSScriptCommandDescriptionDictionary commandDeclaration)
	{
		if (string.IsNullOrEmpty(suiteName))
		{
			throw new ArgumentException("suiteName cannot be null or empty");
		}
		if (string.IsNullOrEmpty(commandName))
		{
			throw new ArgumentException("commandName cannot be null or empty");
		}
		if (commandDeclaration == null)
		{
			throw new ArgumentNullException("commandDeclaration");
		}
		if (string.IsNullOrEmpty(commandDeclaration.CommandClass))
		{
			throw new ArgumentException("cmdClass");
		}
		if (string.IsNullOrEmpty(commandDeclaration.AppleEventCode))
		{
			throw new ArgumentException("eventCode");
		}
		if (commandDeclaration.AppleEventCode.Length != 4)
		{
			throw new ArgumentException("eventCode must be a four characters string.");
		}
		if (string.IsNullOrEmpty(commandDeclaration.AppleEventClassCode))
		{
			throw new ArgumentException("eventClass");
		}
		if (commandDeclaration.AppleEventClassCode.Length != 4)
		{
			throw new ArgumentException("eventClass must be a four characters string.");
		}
		if (commandDeclaration.ResultAppleEventCode != null && commandDeclaration.ResultAppleEventCode.Length != 4)
		{
			throw new ArgumentException("resultAppleEvent must be a four characters string.");
		}
		using NSString suiteName2 = new NSString(suiteName);
		using NSString commandName2 = new NSString(commandName);
		try
		{
			NSScriptCommandDescription nSScriptCommandDescription = new NSScriptCommandDescription(suiteName2, commandName2, commandDeclaration.Dictionary);
			nSScriptCommandDescription.description = commandDeclaration;
			return nSScriptCommandDescription;
		}
		catch (Exception innerException)
		{
			throw new ArgumentException("commandDeclaration", "Wrong description dictionary: Check that the event constant, class name and argument definitions are well formed as per apple documentation.", innerException);
		}
	}

	public string GetTypeForArgument(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		using NSString name2 = new NSString(name);
		using NSString nSString = GetNSTypeForArgument(name2);
		return nSString?.ToString();
	}

	public string GetAppleEventCodeForArgument(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException(name);
		}
		using NSString name2 = new NSString(name);
		return ToFourCCString(FCCAppleEventCodeForArgument(name2));
	}

	public bool IsOptionalArgument(string name)
	{
		using NSString name2 = new NSString(name);
		return NSIsOptionalArgument(name2);
	}

	public NSScriptCommand CreateCommand()
	{
		return new NSScriptCommand(CreateCommandInstancePtr());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSScriptCommandDescription(NSCoder coder)
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
	protected NSScriptCommandDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScriptCommandDescription(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSuiteName:commandName:dictionary:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSScriptCommandDescription(NSString suiteName, NSString commandName, NSDictionary commandDeclaration)
		: base(NSObjectFlag.Empty)
	{
		if (suiteName == null)
		{
			throw new ArgumentNullException("suiteName");
		}
		if (commandName == null)
		{
			throw new ArgumentNullException("commandName");
		}
		if (commandDeclaration == null)
		{
			throw new ArgumentNullException("commandDeclaration");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSuiteName_CommandName_Dictionary_Handle, suiteName.Handle, commandName.Handle, commandDeclaration.Handle), "initWithSuiteName:commandName:dictionary:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSuiteName_CommandName_Dictionary_Handle, suiteName.Handle, commandName.Handle, commandDeclaration.Handle), "initWithSuiteName:commandName:dictionary:");
		}
	}

	[Export("createCommandInstance")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr CreateCommandInstancePtr()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selCreateCommandInstanceHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateCommandInstanceHandle);
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

	[Export("appleEventCodeForArgumentWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int FCCAppleEventCodeForArgument(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_IntPtr(base.Handle, selAppleEventCodeForArgumentWithName_Handle, name.Handle);
		}
		return Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppleEventCodeForArgumentWithName_Handle, name.Handle);
	}

	[Export("typeForArgumentWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString GetNSTypeForArgument(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTypeForArgumentWithName_Handle, name.Handle));
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTypeForArgumentWithName_Handle, name.Handle));
	}

	[Export("isOptionalArgumentWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool NSIsOptionalArgument(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsOptionalArgumentWithName_Handle, name.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsOptionalArgumentWithName_Handle, name.Handle);
	}
}
