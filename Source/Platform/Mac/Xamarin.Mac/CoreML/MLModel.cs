using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLModel", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MLModel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompileModelAtURL_Error_ = "compileModelAtURL:error:";

	private static readonly IntPtr selCompileModelAtURL_Error_Handle = Selector.GetHandle("compileModelAtURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelDescription = "modelDescription";

	private static readonly IntPtr selModelDescriptionHandle = Selector.GetHandle("modelDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelWithContentsOfURL_Configuration_Error_ = "modelWithContentsOfURL:configuration:error:";

	private static readonly IntPtr selModelWithContentsOfURL_Configuration_Error_Handle = Selector.GetHandle("modelWithContentsOfURL:configuration:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelWithContentsOfURL_Error_ = "modelWithContentsOfURL:error:";

	private static readonly IntPtr selModelWithContentsOfURL_Error_Handle = Selector.GetHandle("modelWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterValueForKey_Error_ = "parameterValueForKey:error:";

	private static readonly IntPtr selParameterValueForKey_Error_Handle = Selector.GetHandle("parameterValueForKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredictionFromFeatures_Error_ = "predictionFromFeatures:error:";

	private static readonly IntPtr selPredictionFromFeatures_Error_Handle = Selector.GetHandle("predictionFromFeatures:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredictionFromFeatures_Options_Error_ = "predictionFromFeatures:options:error:";

	private static readonly IntPtr selPredictionFromFeatures_Options_Error_Handle = Selector.GetHandle("predictionFromFeatures:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredictionsFromBatch_Error_ = "predictionsFromBatch:error:";

	private static readonly IntPtr selPredictionsFromBatch_Error_Handle = Selector.GetHandle("predictionsFromBatch:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredictionsFromBatch_Options_Error_ = "predictionsFromBatch:options:error:";

	private static readonly IntPtr selPredictionsFromBatch_Options_Error_Handle = Selector.GetHandle("predictionsFromBatch:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLModel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MLModelConfiguration Configuration
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("configuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLModelConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<MLModelConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLModelDescription ModelDescription
	{
		[Export("modelDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLModelDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selModelDescriptionHandle));
			}
			return Runtime.GetNSObject<MLModelDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MLModel()
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
	protected MLModel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLModel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compileModelAtURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl? CompileModel(NSUrl modelUrl, out NSError error)
	{
		if (modelUrl == null)
		{
			throw new ArgumentNullException("modelUrl");
		}
		IntPtr arg = IntPtr.Zero;
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selCompileModelAtURL_Error_Handle, modelUrl.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("modelWithContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLModel? Create(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		MLModel nSObject = Runtime.GetNSObject<MLModel>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selModelWithContentsOfURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("modelWithContentsOfURL:configuration:error:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLModel? Create(NSUrl url, MLModelConfiguration configuration, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		IntPtr arg = IntPtr.Zero;
		MLModel nSObject = Runtime.GetNSObject<MLModel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selModelWithContentsOfURL_Configuration_Error_Handle, url.Handle, configuration.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("parameterValueForKey:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetParameterValue(MLParameterKey key, out NSError? error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selParameterValueForKey_Error_Handle, key.Handle, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selParameterValueForKey_Error_Handle, key.Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("predictionFromFeatures:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLFeatureProvider? GetPrediction(IMLFeatureProvider input, out NSError error)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		IntPtr arg = IntPtr.Zero;
		IMLFeatureProvider result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPredictionFromFeatures_Error_Handle, input.Handle, ref arg), owns: false) : Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPredictionFromFeatures_Error_Handle, input.Handle, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("predictionFromFeatures:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLFeatureProvider? GetPrediction(IMLFeatureProvider input, MLPredictionOptions options, out NSError error)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IMLFeatureProvider result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPredictionFromFeatures_Options_Error_Handle, input.Handle, options.Handle, ref arg), owns: false) : Runtime.GetINativeObject<IMLFeatureProvider>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPredictionFromFeatures_Options_Error_Handle, input.Handle, options.Handle, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("predictionsFromBatch:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLBatchProvider? GetPredictions(IMLBatchProvider inputBatch, out NSError? error)
	{
		if (inputBatch == null)
		{
			throw new ArgumentNullException("inputBatch");
		}
		IntPtr arg = IntPtr.Zero;
		IMLBatchProvider result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMLBatchProvider>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPredictionsFromBatch_Error_Handle, inputBatch.Handle, ref arg), owns: false) : Runtime.GetINativeObject<IMLBatchProvider>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPredictionsFromBatch_Error_Handle, inputBatch.Handle, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("predictionsFromBatch:options:error:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLBatchProvider? GetPredictions(IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
	{
		if (inputBatch == null)
		{
			throw new ArgumentNullException("inputBatch");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IMLBatchProvider result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMLBatchProvider>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selPredictionsFromBatch_Options_Error_Handle, inputBatch.Handle, options.Handle, ref arg), owns: false) : Runtime.GetINativeObject<IMLBatchProvider>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selPredictionsFromBatch_Options_Error_Handle, inputBatch.Handle, options.Handle, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
