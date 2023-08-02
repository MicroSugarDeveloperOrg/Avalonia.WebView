using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuartzComposer;

[Register("QCComposition", true)]
public class QCComposition : NSObject
{
	private static readonly IntPtr selProtocolsHandle = Selector.GetHandle("protocols");

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	private static readonly IntPtr selInputKeysHandle = Selector.GetHandle("inputKeys");

	private static readonly IntPtr selOutputKeysHandle = Selector.GetHandle("outputKeys");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selCompositionWithFile_Handle = Selector.GetHandle("compositionWithFile:");

	private static readonly IntPtr selCompositionWithData_Handle = Selector.GetHandle("compositionWithData:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QCComposition");

	private object __mt_Attributes_var;

	private static NSString _AttributeNameKey;

	private static NSString _AttributeDescriptionKey;

	private static NSString _AttributeCopyrightKey;

	private static NSString _AttributeBuiltInKey;

	private static NSString _AttributeIsTimeDependentKey;

	private static NSString _AttributeHasConsumersKey;

	private static NSString _AttributeCategoryKey;

	private static NSString _CategoryDistortion;

	private static NSString _CategoryStylize;

	private static NSString _CategoryUtility;

	private static NSString _InputImageKey;

	private static NSString _InputSourceImageKey;

	private static NSString _InputDestinationImageKey;

	private static NSString _InputRSSFeedURLKey;

	private static NSString _InputRSSArticleDurationKey;

	private static NSString _InputPreviewModeKey;

	private static NSString _InputXKey;

	private static NSString _InputYKey;

	private static NSString _InputScreenImageKey;

	private static NSString _InputAudioPeakKey;

	private static NSString _InputAudioSpectrumKey;

	private static NSString _InputTrackPositionKey;

	private static NSString _InputTrackInfoKey;

	private static NSString _InputTrackSignalKey;

	private static NSString _InputPrimaryColorKey;

	private static NSString _InputSecondaryColorKey;

	private static NSString _InputPaceKey;

	private static NSString _OutputImageKey;

	private static NSString _OutputWebPageURLKey;

	private static NSString _ProtocolGraphicAnimation;

	private static NSString _ProtocolGraphicTransition;

	private static NSString _ProtocolImageFilter;

	private static NSString _ProtocolScreenSaver;

	private static NSString _ProtocolRSSVisualizer;

	private static NSString _ProtocolMusicVisualizer;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string[] Protocols
	{
		[Export("protocols")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolsHandle));
		}
	}

	public virtual NSDictionary Attributes
	{
		[Export("attributes")]
		get
		{
			return (NSDictionary)(__mt_Attributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle)))));
		}
	}

	public virtual string[] InputKeys
	{
		[Export("inputKeys")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputKeysHandle));
		}
	}

	public virtual string[] OutputKeys
	{
		[Export("outputKeys")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputKeysHandle));
		}
	}

	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
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

	[Field("QCCompositionInputRSSFeedURLKey", "QuartzComposer")]
	public static NSString InputRSSFeedURLKey
	{
		get
		{
			if (_InputRSSFeedURLKey == null)
			{
				_InputRSSFeedURLKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputRSSFeedURLKey");
			}
			return _InputRSSFeedURLKey;
		}
	}

	[Field("QCCompositionInputRSSArticleDurationKey", "QuartzComposer")]
	public static NSString InputRSSArticleDurationKey
	{
		get
		{
			if (_InputRSSArticleDurationKey == null)
			{
				_InputRSSArticleDurationKey = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionInputRSSArticleDurationKey");
			}
			return _InputRSSArticleDurationKey;
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

	[Field("QCCompositionProtocolRSSVisualizer", "QuartzComposer")]
	public static NSString ProtocolRSSVisualizer
	{
		get
		{
			if (_ProtocolRSSVisualizer == null)
			{
				_ProtocolRSSVisualizer = Dlfcn.GetStringConstant(Libraries.QuartzComposer.Handle, "QCCompositionProtocolRSSVisualizer");
			}
			return _ProtocolRSSVisualizer;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QCComposition()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QCComposition(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QCComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QCComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compositionWithFile:")]
	public static QCComposition GetComposition(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		QCComposition result = (QCComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionWithFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compositionWithData:")]
	public static QCComposition GetComposition(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (QCComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionWithData_Handle, data.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Attributes_var = null;
		}
	}
}
