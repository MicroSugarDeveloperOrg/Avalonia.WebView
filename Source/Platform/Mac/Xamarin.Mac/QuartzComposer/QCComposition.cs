using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuartzComposer;

[Register("QCComposition", true)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
public class QCComposition : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionWithData_ = "compositionWithData:";

	private static readonly IntPtr selCompositionWithData_Handle = Selector.GetHandle("compositionWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionWithFile_ = "compositionWithFile:";

	private static readonly IntPtr selCompositionWithFile_Handle = Selector.GetHandle("compositionWithFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputKeys = "inputKeys";

	private static readonly IntPtr selInputKeysHandle = Selector.GetHandle("inputKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputKeys = "outputKeys";

	private static readonly IntPtr selOutputKeysHandle = Selector.GetHandle("outputKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocols = "protocols";

	private static readonly IntPtr selProtocolsHandle = Selector.GetHandle("protocols");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QCComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeBuiltInKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeCategoryKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeCopyrightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeDescriptionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeHasConsumersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeIsTimeDependentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AttributeNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CategoryDistortion;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CategoryStylize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CategoryUtility;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputAudioPeakKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputAudioSpectrumKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputDestinationImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputPaceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputPreviewModeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputPrimaryColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputRSSArticleDurationKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputRSSFeedURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputScreenImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputSecondaryColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputSourceImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputTrackInfoKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputTrackPositionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputTrackSignalKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputXKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputYKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OutputWebPageURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolGraphicAnimation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolGraphicTransition;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolImageFilter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolMusicVisualizer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolRSSVisualizer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolScreenSaver;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Attributes
	{
		[Export("attributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] InputKeys
	{
		[Export("inputKeys")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputKeysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] OutputKeys
	{
		[Export("outputKeys")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputKeysHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Protocols
	{
		[Export("protocols")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolsHandle));
		}
	}

	[Field("QCCompositionAttributeBuiltInKey", "QuartzComposer")]
	public static NSString AttributeBuiltInKey
	{
		get
		{
			if (_AttributeBuiltInKey == null)
			{
				_AttributeBuiltInKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeBuiltInKey");
			}
			return _AttributeBuiltInKey;
		}
	}

	[Field("QCCompositionAttributeCategoryKey", "QuartzComposer")]
	public static NSString AttributeCategoryKey
	{
		get
		{
			if (_AttributeCategoryKey == null)
			{
				_AttributeCategoryKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeCategoryKey");
			}
			return _AttributeCategoryKey;
		}
	}

	[Field("QCCompositionAttributeCopyrightKey", "QuartzComposer")]
	public static NSString AttributeCopyrightKey
	{
		get
		{
			if (_AttributeCopyrightKey == null)
			{
				_AttributeCopyrightKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeCopyrightKey");
			}
			return _AttributeCopyrightKey;
		}
	}

	[Field("QCCompositionAttributeDescriptionKey", "QuartzComposer")]
	public static NSString AttributeDescriptionKey
	{
		get
		{
			if (_AttributeDescriptionKey == null)
			{
				_AttributeDescriptionKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeDescriptionKey");
			}
			return _AttributeDescriptionKey;
		}
	}

	[Field("QCCompositionAttributeHasConsumersKey", "QuartzComposer")]
	public static NSString AttributeHasConsumersKey
	{
		get
		{
			if (_AttributeHasConsumersKey == null)
			{
				_AttributeHasConsumersKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeHasConsumersKey");
			}
			return _AttributeHasConsumersKey;
		}
	}

	[Field("QCCompositionAttributeIsTimeDependentKey", "QuartzComposer")]
	public static NSString AttributeIsTimeDependentKey
	{
		get
		{
			if (_AttributeIsTimeDependentKey == null)
			{
				_AttributeIsTimeDependentKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeIsTimeDependentKey");
			}
			return _AttributeIsTimeDependentKey;
		}
	}

	[Field("QCCompositionAttributeNameKey", "QuartzComposer")]
	public static NSString AttributeNameKey
	{
		get
		{
			if (_AttributeNameKey == null)
			{
				_AttributeNameKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionAttributeNameKey");
			}
			return _AttributeNameKey;
		}
	}

	[Field("QCCompositionCategoryDistortion", "QuartzComposer")]
	public static NSString CategoryDistortion
	{
		get
		{
			if (_CategoryDistortion == null)
			{
				_CategoryDistortion = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionCategoryDistortion");
			}
			return _CategoryDistortion;
		}
	}

	[Field("QCCompositionCategoryStylize", "QuartzComposer")]
	public static NSString CategoryStylize
	{
		get
		{
			if (_CategoryStylize == null)
			{
				_CategoryStylize = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionCategoryStylize");
			}
			return _CategoryStylize;
		}
	}

	[Field("QCCompositionCategoryUtility", "QuartzComposer")]
	public static NSString CategoryUtility
	{
		get
		{
			if (_CategoryUtility == null)
			{
				_CategoryUtility = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionCategoryUtility");
			}
			return _CategoryUtility;
		}
	}

	[Field("QCCompositionInputAudioPeakKey", "QuartzComposer")]
	public static NSString InputAudioPeakKey
	{
		get
		{
			if (_InputAudioPeakKey == null)
			{
				_InputAudioPeakKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputAudioPeakKey");
			}
			return _InputAudioPeakKey;
		}
	}

	[Field("QCCompositionInputAudioSpectrumKey", "QuartzComposer")]
	public static NSString InputAudioSpectrumKey
	{
		get
		{
			if (_InputAudioSpectrumKey == null)
			{
				_InputAudioSpectrumKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputAudioSpectrumKey");
			}
			return _InputAudioSpectrumKey;
		}
	}

	[Field("QCCompositionInputDestinationImageKey", "QuartzComposer")]
	public static NSString InputDestinationImageKey
	{
		get
		{
			if (_InputDestinationImageKey == null)
			{
				_InputDestinationImageKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputDestinationImageKey");
			}
			return _InputDestinationImageKey;
		}
	}

	[Field("QCCompositionInputImageKey", "QuartzComposer")]
	public static NSString InputImageKey
	{
		get
		{
			if (_InputImageKey == null)
			{
				_InputImageKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputImageKey");
			}
			return _InputImageKey;
		}
	}

	[Field("QCCompositionInputPaceKey", "QuartzComposer")]
	public static NSString InputPaceKey
	{
		get
		{
			if (_InputPaceKey == null)
			{
				_InputPaceKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputPaceKey");
			}
			return _InputPaceKey;
		}
	}

	[Field("QCCompositionInputPreviewModeKey", "QuartzComposer")]
	public static NSString InputPreviewModeKey
	{
		get
		{
			if (_InputPreviewModeKey == null)
			{
				_InputPreviewModeKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputPreviewModeKey");
			}
			return _InputPreviewModeKey;
		}
	}

	[Field("QCCompositionInputPrimaryColorKey", "QuartzComposer")]
	public static NSString InputPrimaryColorKey
	{
		get
		{
			if (_InputPrimaryColorKey == null)
			{
				_InputPrimaryColorKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputPrimaryColorKey");
			}
			return _InputPrimaryColorKey;
		}
	}

	[Field("QCCompositionInputRSSArticleDurationKey", "QuartzComposer")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	public static NSString InputRSSArticleDurationKey
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
		get
		{
			if (_InputRSSArticleDurationKey == null)
			{
				_InputRSSArticleDurationKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputRSSArticleDurationKey");
			}
			return _InputRSSArticleDurationKey;
		}
	}

	[Field("QCCompositionInputRSSFeedURLKey", "QuartzComposer")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	public static NSString InputRSSFeedURLKey
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
		get
		{
			if (_InputRSSFeedURLKey == null)
			{
				_InputRSSFeedURLKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputRSSFeedURLKey");
			}
			return _InputRSSFeedURLKey;
		}
	}

	[Field("QCCompositionInputScreenImageKey", "QuartzComposer")]
	public static NSString InputScreenImageKey
	{
		get
		{
			if (_InputScreenImageKey == null)
			{
				_InputScreenImageKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputScreenImageKey");
			}
			return _InputScreenImageKey;
		}
	}

	[Field("QCCompositionInputSecondaryColorKey", "QuartzComposer")]
	public static NSString InputSecondaryColorKey
	{
		get
		{
			if (_InputSecondaryColorKey == null)
			{
				_InputSecondaryColorKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputSecondaryColorKey");
			}
			return _InputSecondaryColorKey;
		}
	}

	[Field("QCCompositionInputSourceImageKey", "QuartzComposer")]
	public static NSString InputSourceImageKey
	{
		get
		{
			if (_InputSourceImageKey == null)
			{
				_InputSourceImageKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputSourceImageKey");
			}
			return _InputSourceImageKey;
		}
	}

	[Field("QCCompositionInputTrackInfoKey", "QuartzComposer")]
	public static NSString InputTrackInfoKey
	{
		get
		{
			if (_InputTrackInfoKey == null)
			{
				_InputTrackInfoKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputTrackInfoKey");
			}
			return _InputTrackInfoKey;
		}
	}

	[Field("QCCompositionInputTrackPositionKey", "QuartzComposer")]
	public static NSString InputTrackPositionKey
	{
		get
		{
			if (_InputTrackPositionKey == null)
			{
				_InputTrackPositionKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputTrackPositionKey");
			}
			return _InputTrackPositionKey;
		}
	}

	[Field("QCCompositionInputTrackSignalKey", "QuartzComposer")]
	public static NSString InputTrackSignalKey
	{
		get
		{
			if (_InputTrackSignalKey == null)
			{
				_InputTrackSignalKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputTrackSignalKey");
			}
			return _InputTrackSignalKey;
		}
	}

	[Field("QCCompositionInputXKey", "QuartzComposer")]
	public static NSString InputXKey
	{
		get
		{
			if (_InputXKey == null)
			{
				_InputXKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputXKey");
			}
			return _InputXKey;
		}
	}

	[Field("QCCompositionInputYKey", "QuartzComposer")]
	public static NSString InputYKey
	{
		get
		{
			if (_InputYKey == null)
			{
				_InputYKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputYKey");
			}
			return _InputYKey;
		}
	}

	[Field("QCCompositionOutputImageKey", "QuartzComposer")]
	public static NSString OutputImageKey
	{
		get
		{
			if (_OutputImageKey == null)
			{
				_OutputImageKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionOutputImageKey");
			}
			return _OutputImageKey;
		}
	}

	[Field("QCCompositionOutputWebPageURLKey", "QuartzComposer")]
	public static NSString OutputWebPageURLKey
	{
		get
		{
			if (_OutputWebPageURLKey == null)
			{
				_OutputWebPageURLKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionOutputWebPageURLKey");
			}
			return _OutputWebPageURLKey;
		}
	}

	[Field("QCCompositionProtocolGraphicAnimation", "QuartzComposer")]
	public static NSString ProtocolGraphicAnimation
	{
		get
		{
			if (_ProtocolGraphicAnimation == null)
			{
				_ProtocolGraphicAnimation = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolGraphicAnimation");
			}
			return _ProtocolGraphicAnimation;
		}
	}

	[Field("QCCompositionProtocolGraphicTransition", "QuartzComposer")]
	public static NSString ProtocolGraphicTransition
	{
		get
		{
			if (_ProtocolGraphicTransition == null)
			{
				_ProtocolGraphicTransition = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolGraphicTransition");
			}
			return _ProtocolGraphicTransition;
		}
	}

	[Field("QCCompositionProtocolImageFilter", "QuartzComposer")]
	public static NSString ProtocolImageFilter
	{
		get
		{
			if (_ProtocolImageFilter == null)
			{
				_ProtocolImageFilter = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolImageFilter");
			}
			return _ProtocolImageFilter;
		}
	}

	[Field("QCCompositionProtocolMusicVisualizer", "QuartzComposer")]
	public static NSString ProtocolMusicVisualizer
	{
		get
		{
			if (_ProtocolMusicVisualizer == null)
			{
				_ProtocolMusicVisualizer = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolMusicVisualizer");
			}
			return _ProtocolMusicVisualizer;
		}
	}

	[Field("QCCompositionProtocolRSSVisualizer", "QuartzComposer")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	public static NSString ProtocolRSSVisualizer
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
		get
		{
			if (_ProtocolRSSVisualizer == null)
			{
				_ProtocolRSSVisualizer = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolRSSVisualizer");
			}
			return _ProtocolRSSVisualizer;
		}
	}

	[Field("QCCompositionProtocolScreenSaver", "QuartzComposer")]
	public static NSString ProtocolScreenSaver
	{
		get
		{
			if (_ProtocolScreenSaver == null)
			{
				_ProtocolScreenSaver = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolScreenSaver");
			}
			return _ProtocolScreenSaver;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QCComposition()
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
	protected QCComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QCComposition(IntPtr handle)
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

	[Export("compositionWithFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QCComposition GetComposition(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		QCComposition nSObject = Runtime.GetNSObject<QCComposition>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionWithFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("compositionWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QCComposition GetComposition(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<QCComposition>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionWithData_Handle, data.Handle));
	}
}
