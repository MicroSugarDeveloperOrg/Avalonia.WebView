using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLMaterialPropertyNode", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class MDLMaterialPropertyNode : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluationFunction = "evaluationFunction";

	private static readonly IntPtr selEvaluationFunctionHandle = Selector.GetHandle("evaluationFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInputs_Outputs_EvaluationFunction_ = "initWithInputs:outputs:evaluationFunction:";

	private static readonly IntPtr selInitWithInputs_Outputs_EvaluationFunction_Handle = Selector.GetHandle("initWithInputs:outputs:evaluationFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputs = "inputs";

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputs = "outputs";

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEvaluationFunction_ = "setEvaluationFunction:";

	private static readonly IntPtr selSetEvaluationFunction_Handle = Selector.GetHandle("setEvaluationFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMaterialPropertyNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<MDLMaterialPropertyNode> EvaluationFunction
	{
		[Export("evaluationFunction", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V66))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEvaluationFunctionHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selEvaluationFunctionHandle));
			return Trampolines.NIDActionArity1V66.Create(block);
		}
		[Export("setEvaluationFunction:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V66))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V66.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEvaluationFunction_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEvaluationFunction_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty[] Inputs
	{
		[Export("inputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle));
			}
			return NSArray.ArrayFromHandle<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
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
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialProperty[] Outputs
	{
		[Export("outputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle));
			}
			return NSArray.ArrayFromHandle<MDLMaterialProperty>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLMaterialPropertyNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMaterialPropertyNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithInputs:outputs:evaluationFunction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe MDLMaterialPropertyNode(MDLMaterialProperty[] inputs, MDLMaterialProperty[] outputs, [BlockProxy(typeof(Trampolines.NIDActionArity1V66))] Action<MDLMaterialPropertyNode> function)
		: base(NSObjectFlag.Empty)
	{
		if (inputs == null)
		{
			throw new ArgumentNullException("inputs");
		}
		if (outputs == null)
		{
			throw new ArgumentNullException("outputs");
		}
		if (function == null)
		{
			throw new ArgumentNullException("function");
		}
		NSArray nSArray = NSArray.FromNSObjects(inputs);
		NSArray nSArray2 = NSArray.FromNSObjects(outputs);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V66.Handler, function);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithInputs_Outputs_EvaluationFunction_Handle, nSArray.Handle, nSArray2.Handle, (IntPtr)ptr), "initWithInputs:outputs:evaluationFunction:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithInputs_Outputs_EvaluationFunction_Handle, nSArray.Handle, nSArray2.Handle, (IntPtr)ptr), "initWithInputs:outputs:evaluationFunction:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		ptr->CleanupBlock();
	}
}
