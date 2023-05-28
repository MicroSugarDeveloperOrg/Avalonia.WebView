using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNFilterNode", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNFilterNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFilterWithSource_ = "gradientFilterWithSource:";

	private static readonly IntPtr selGradientFilterWithSource_Handle = Selector.GetHandle("gradientFilterWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFilterWithSources_ = "gradientFilterWithSources:";

	private static readonly IntPtr selGradientFilterWithSources_Handle = Selector.GetHandle("gradientFilterWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFiltersWithSource_ = "gradientFiltersWithSource:";

	private static readonly IntPtr selGradientFiltersWithSource_Handle = Selector.GetHandle("gradientFiltersWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFiltersWithSources_ = "gradientFiltersWithSources:";

	private static readonly IntPtr selGradientFiltersWithSources_Handle = Selector.GetHandle("gradientFiltersWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingPolicy = "paddingPolicy";

	private static readonly IntPtr selPaddingPolicyHandle = Selector.GetHandle("paddingPolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultImage = "resultImage";

	private static readonly IntPtr selResultImageHandle = Selector.GetHandle("resultImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultState = "resultState";

	private static readonly IntPtr selResultStateHandle = Selector.GetHandle("resultState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStates = "resultStates";

	private static readonly IntPtr selResultStatesHandle = Selector.GetHandle("resultStates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaddingPolicy_ = "setPaddingPolicy:";

	private static readonly IntPtr selSetPaddingPolicy_Handle = Selector.GetHandle("setPaddingPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrainingGraphWithSourceGradient_NodeHandler_ = "trainingGraphWithSourceGradient:nodeHandler:";

	private static readonly IntPtr selTrainingGraphWithSourceGradient_NodeHandler_Handle = Selector.GetHandle("trainingGraphWithSourceGradient:nodeHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNFilterNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSNNPadding PaddingPolicy
	{
		[Export("paddingPolicy", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSend(base.Handle, selPaddingPolicyHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaddingPolicyHandle), owns: false);
		}
		[Export("setPaddingPolicy:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPaddingPolicy_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPaddingPolicy_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNImageNode ResultImage
	{
		[Export("resultImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNNImageNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultImageHandle));
			}
			return Runtime.GetNSObject<MPSNNImageNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNStateNode? ResultState
	{
		[Export("resultState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNNStateNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultStateHandle));
			}
			return Runtime.GetNSObject<MPSNNStateNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNStateNode[]? ResultStates
	{
		[Export("resultStates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MPSNNStateNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultStatesHandle));
			}
			return NSArray.ArrayFromHandle<MPSNNStateNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultStatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNFilterNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNFilterNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("gradientFilterWithSource:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNGradientFilterNode GetFilter(MPSNNImageNode gradientImageSource)
	{
		if (gradientImageSource == null)
		{
			throw new ArgumentNullException("gradientImageSource");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFilterWithSource_Handle, gradientImageSource.Handle));
		}
		return Runtime.GetNSObject<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFilterWithSource_Handle, gradientImageSource.Handle));
	}

	[Export("gradientFilterWithSources:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNGradientFilterNode GetFilter(MPSNNImageNode[] gradientImagesSources)
	{
		if (gradientImagesSources == null)
		{
			throw new ArgumentNullException("gradientImagesSources");
		}
		NSArray nSArray = NSArray.FromNSObjects(gradientImagesSources);
		MPSNNGradientFilterNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFilterWithSources_Handle, nSArray.Handle)) : Runtime.GetNSObject<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFilterWithSources_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("gradientFiltersWithSources:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNGradientFilterNode[] GetFilters(MPSNNImageNode[] gradientImagesSources)
	{
		if (gradientImagesSources == null)
		{
			throw new ArgumentNullException("gradientImagesSources");
		}
		NSArray nSArray = NSArray.FromNSObjects(gradientImagesSources);
		MPSNNGradientFilterNode[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFiltersWithSources_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFiltersWithSources_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("gradientFiltersWithSource:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNGradientFilterNode[] GetFilters(MPSNNImageNode gradientImageSource)
	{
		if (gradientImageSource == null)
		{
			throw new ArgumentNullException("gradientImageSource");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFiltersWithSource_Handle, gradientImageSource.Handle));
		}
		return NSArray.ArrayFromHandle<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFiltersWithSource_Handle, gradientImageSource.Handle));
	}

	[Export("trainingGraphWithSourceGradient:nodeHandler:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual MPSNNFilterNode[]? GetTrainingGraph(MPSNNImageNode? gradientImageSource, [BlockProxy(typeof(Trampolines.NIDMPSGradientNodeHandler))] MPSGradientNodeHandler? nodeHandler)
	{
		BlockLiteral* ptr;
		if (nodeHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDMPSGradientNodeHandler.Handler, nodeHandler);
		}
		MPSNNFilterNode[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<MPSNNFilterNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTrainingGraphWithSourceGradient_NodeHandler_Handle, gradientImageSource?.Handle ?? IntPtr.Zero, (IntPtr)ptr)) : NSArray.ArrayFromHandle<MPSNNFilterNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selTrainingGraphWithSourceGradient_NodeHandler_Handle, gradientImageSource?.Handle ?? IntPtr.Zero, (IntPtr)ptr)));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}
}
