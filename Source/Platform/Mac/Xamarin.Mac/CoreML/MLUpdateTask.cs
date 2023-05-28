using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLUpdateTask", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLUpdateTask : MLTask
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeWithParameters_ = "resumeWithParameters:";

	private static readonly IntPtr selResumeWithParameters_Handle = Selector.GetHandle("resumeWithParameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateTaskForModelAtURL_TrainingData_Configuration_CompletionHandler_Error_ = "updateTaskForModelAtURL:trainingData:configuration:completionHandler:error:";

	private static readonly IntPtr selUpdateTaskForModelAtURL_TrainingData_Configuration_CompletionHandler_Error_Handle = Selector.GetHandle("updateTaskForModelAtURL:trainingData:configuration:completionHandler:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateTaskForModelAtURL_TrainingData_Configuration_ProgressHandlers_Error_ = "updateTaskForModelAtURL:trainingData:configuration:progressHandlers:error:";

	private static readonly IntPtr selUpdateTaskForModelAtURL_TrainingData_Configuration_ProgressHandlers_Error_Handle = Selector.GetHandle("updateTaskForModelAtURL:trainingData:configuration:progressHandlers:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLUpdateTask");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLUpdateTask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLUpdateTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("updateTaskForModelAtURL:trainingData:configuration:completionHandler:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static MLUpdateTask? Create(NSUrl modelUrl, IMLBatchProvider trainingData, MLModelConfiguration? configuration, [BlockProxy(typeof(Trampolines.NIDActionArity1V25))] Action<MLUpdateContext> completionHandler, out NSError? error)
	{
		if (modelUrl == null)
		{
			throw new ArgumentNullException("modelUrl");
		}
		if (trainingData == null)
		{
			throw new ArgumentNullException("trainingData");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V25.Handler, completionHandler);
		MLUpdateTask nSObject = Runtime.GetNSObject<MLUpdateTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selUpdateTaskForModelAtURL_TrainingData_Configuration_CompletionHandler_Error_Handle, modelUrl.Handle, trainingData.Handle, configuration?.Handle ?? IntPtr.Zero, (IntPtr)ptr, ref arg));
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("updateTaskForModelAtURL:trainingData:configuration:progressHandlers:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLUpdateTask? Create(NSUrl modelUrl, IMLBatchProvider trainingData, MLModelConfiguration? configuration, MLUpdateProgressHandlers progressHandlers, out NSError? error)
	{
		if (modelUrl == null)
		{
			throw new ArgumentNullException("modelUrl");
		}
		if (trainingData == null)
		{
			throw new ArgumentNullException("trainingData");
		}
		if (progressHandlers == null)
		{
			throw new ArgumentNullException("progressHandlers");
		}
		IntPtr arg = IntPtr.Zero;
		MLUpdateTask nSObject = Runtime.GetNSObject<MLUpdateTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selUpdateTaskForModelAtURL_TrainingData_Configuration_ProgressHandlers_Error_Handle, modelUrl.Handle, trainingData.Handle, configuration?.Handle ?? IntPtr.Zero, progressHandlers.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("resumeWithParameters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resume(NSDictionary<MLParameterKey, NSObject> updateParameters)
	{
		if (updateParameters == null)
		{
			throw new ArgumentNullException("updateParameters");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeWithParameters_Handle, updateParameters.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeWithParameters_Handle, updateParameters.Handle);
		}
	}
}
