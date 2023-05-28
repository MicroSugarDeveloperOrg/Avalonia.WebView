using System;
using System.ComponentModel;
using CoreML;
using Foundation;
using ObjCRuntime;

namespace NaturalLanguage;

[Register("NLModel", true)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class NLModel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelWithContentsOfURL_Error_ = "modelWithContentsOfURL:error:";

	private static readonly IntPtr selModelWithContentsOfURL_Error_Handle = Selector.GetHandle("modelWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelWithMLModel_Error_ = "modelWithMLModel:error:";

	private static readonly IntPtr selModelWithMLModel_Error_Handle = Selector.GetHandle("modelWithMLModel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredictedLabelForString_ = "predictedLabelForString:";

	private static readonly IntPtr selPredictedLabelForString_Handle = Selector.GetHandle("predictedLabelForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredictedLabelsForTokens_ = "predictedLabelsForTokens:";

	private static readonly IntPtr selPredictedLabelsForTokens_Handle = Selector.GetHandle("predictedLabelsForTokens:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NLModel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NLModelConfiguration Configuration
	{
		[Export("configuration", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NLModelConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<NLModelConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NLModel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NLModel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("modelWithContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLModel? Create(NSUrl url, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NLModel nSObject = Runtime.GetNSObject<NLModel>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selModelWithContentsOfURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("modelWithMLModel:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLModel? Create(MLModel mlModel, out NSError? error)
	{
		if (mlModel == null)
		{
			throw new ArgumentNullException("mlModel");
		}
		IntPtr arg = IntPtr.Zero;
		NLModel nSObject = Runtime.GetNSObject<NLModel>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selModelWithMLModel_Error_Handle, mlModel.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("predictedLabelForString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetPredictedLabel(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredictedLabelForString_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredictedLabelForString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("predictedLabelsForTokens:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetPredictedLabels(string[] tokens)
	{
		if (tokens == null)
		{
			throw new ArgumentNullException("tokens");
		}
		NSArray nSArray = NSArray.FromStrings(tokens);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPredictedLabelsForTokens_Handle, nSArray.Handle)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPredictedLabelsForTokens_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}
}
