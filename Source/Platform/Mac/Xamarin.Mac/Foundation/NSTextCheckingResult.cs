using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSTextCheckingResult", true)]
public class NSTextCheckingResult : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddressCheckingResultWithRange_Components_ = "addressCheckingResultWithRange:components:";

	private static readonly IntPtr selAddressCheckingResultWithRange_Components_Handle = Selector.GetHandle("addressCheckingResultWithRange:components:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddressComponents = "addressComponents";

	private static readonly IntPtr selAddressComponentsHandle = Selector.GetHandle("addressComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlternativeStrings = "alternativeStrings";

	private static readonly IntPtr selAlternativeStringsHandle = Selector.GetHandle("alternativeStrings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents = "components";

	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCorrectionCheckingResultWithRange_ReplacementString_ = "correctionCheckingResultWithRange:replacementString:";

	private static readonly IntPtr selCorrectionCheckingResultWithRange_ReplacementString_Handle = Selector.GetHandle("correctionCheckingResultWithRange:replacementString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCorrectionCheckingResultWithRange_ReplacementString_AlternativeStrings_ = "correctionCheckingResultWithRange:replacementString:alternativeStrings:";

	private static readonly IntPtr selCorrectionCheckingResultWithRange_ReplacementString_AlternativeStrings_Handle = Selector.GetHandle("correctionCheckingResultWithRange:replacementString:alternativeStrings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDashCheckingResultWithRange_ReplacementString_ = "dashCheckingResultWithRange:replacementString:";

	private static readonly IntPtr selDashCheckingResultWithRange_ReplacementString_Handle = Selector.GetHandle("dashCheckingResultWithRange:replacementString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDate = "date";

	private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateCheckingResultWithRange_Date_ = "dateCheckingResultWithRange:date:";

	private static readonly IntPtr selDateCheckingResultWithRange_Date_Handle = Selector.GetHandle("dateCheckingResultWithRange:date:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateCheckingResultWithRange_Date_TimeZone_Duration_ = "dateCheckingResultWithRange:date:timeZone:duration:";

	private static readonly IntPtr selDateCheckingResultWithRange_Date_TimeZone_Duration_Handle = Selector.GetHandle("dateCheckingResultWithRange:date:timeZone:duration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrammarCheckingResultWithRange_Details_ = "grammarCheckingResultWithRange:details:";

	private static readonly IntPtr selGrammarCheckingResultWithRange_Details_Handle = Selector.GetHandle("grammarCheckingResultWithRange:details:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrammarDetails = "grammarDetails";

	private static readonly IntPtr selGrammarDetailsHandle = Selector.GetHandle("grammarDetails");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkCheckingResultWithRange_URL_ = "linkCheckingResultWithRange:URL:";

	private static readonly IntPtr selLinkCheckingResultWithRange_URL_Handle = Selector.GetHandle("linkCheckingResultWithRange:URL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRanges = "numberOfRanges";

	private static readonly IntPtr selNumberOfRangesHandle = Selector.GetHandle("numberOfRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrthography = "orthography";

	private static readonly IntPtr selOrthographyHandle = Selector.GetHandle("orthography");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrthographyCheckingResultWithRange_Orthography_ = "orthographyCheckingResultWithRange:orthography:";

	private static readonly IntPtr selOrthographyCheckingResultWithRange_Orthography_Handle = Selector.GetHandle("orthographyCheckingResultWithRange:orthography:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneNumber = "phoneNumber";

	private static readonly IntPtr selPhoneNumberHandle = Selector.GetHandle("phoneNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhoneNumberCheckingResultWithRange_PhoneNumber_ = "phoneNumberCheckingResultWithRange:phoneNumber:";

	private static readonly IntPtr selPhoneNumberCheckingResultWithRange_PhoneNumber_Handle = Selector.GetHandle("phoneNumberCheckingResultWithRange:phoneNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuoteCheckingResultWithRange_ReplacementString_ = "quoteCheckingResultWithRange:replacementString:";

	private static readonly IntPtr selQuoteCheckingResultWithRange_ReplacementString_Handle = Selector.GetHandle("quoteCheckingResultWithRange:replacementString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRange = "range";

	private static readonly IntPtr selRangeHandle = Selector.GetHandle("range");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeAtIndex_ = "rangeAtIndex:";

	private static readonly IntPtr selRangeAtIndex_Handle = Selector.GetHandle("rangeAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithName_ = "rangeWithName:";

	private static readonly IntPtr selRangeWithName_Handle = Selector.GetHandle("rangeWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplacementCheckingResultWithRange_ReplacementString_ = "replacementCheckingResultWithRange:replacementString:";

	private static readonly IntPtr selReplacementCheckingResultWithRange_ReplacementString_Handle = Selector.GetHandle("replacementCheckingResultWithRange:replacementString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplacementString = "replacementString";

	private static readonly IntPtr selReplacementStringHandle = Selector.GetHandle("replacementString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultByAdjustingRangesWithOffset_ = "resultByAdjustingRangesWithOffset:";

	private static readonly IntPtr selResultByAdjustingRangesWithOffset_Handle = Selector.GetHandle("resultByAdjustingRangesWithOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpellCheckingResultWithRange_ = "spellCheckingResultWithRange:";

	private static readonly IntPtr selSpellCheckingResultWithRange_Handle = Selector.GetHandle("spellCheckingResultWithRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeZone = "timeZone";

	private static readonly IntPtr selTimeZoneHandle = Selector.GetHandle("timeZone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransitInformationCheckingResultWithRange_Components_ = "transitInformationCheckingResultWithRange:components:";

	private static readonly IntPtr selTransitInformationCheckingResultWithRange_Components_Handle = Selector.GetHandle("transitInformationCheckingResultWithRange:components:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextCheckingResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextCheckingAddressComponents AddressComponents
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakAddressComponents != null) ? new NSMutableDictionary(WeakAddressComponents) : null);
			return (nSMutableDictionary == null) ? null : new NSTextCheckingAddressComponents(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string[] AlternativeStrings
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("alternativeStrings")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlternativeStringsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlternativeStringsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextCheckingTransitComponents Components
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakComponents != null) ? new NSMutableDictionary(WeakComponents) : null);
			return (nSMutableDictionary == null) ? null : new NSTextCheckingTransitComponents(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate Date
	{
		[Export("date")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GrammarDetails
	{
		[Export("grammarDetails")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGrammarDetailsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGrammarDetailsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfRanges
	{
		[Export("numberOfRanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfRangesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfRangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOrthography Orthography
	{
		[Export("orthography")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOrthography>(Messaging.IntPtr_objc_msgSend(base.Handle, selOrthographyHandle));
			}
			return Runtime.GetNSObject<NSOrthography>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOrthographyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PhoneNumber
	{
		[Export("phoneNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneNumberHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneNumberHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange Range
	{
		[Export("range")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ReplacementString
	{
		[Export("replacementString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReplacementStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReplacementStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingType ResultType
	{
		[Export("resultType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSTextCheckingType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSTextCheckingType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeInterval
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTimeZone TimeZone
	{
		[Export("timeZone")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeZoneHandle));
			}
			return Runtime.GetNSObject<NSTimeZone>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeZoneHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary WeakAddressComponents
	{
		[Export("addressComponents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAddressComponentsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAddressComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary WeakComponents
	{
		[Export("components")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selComponentsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSTextCheckingResult(NSCoder coder)
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
	protected NSTextCheckingResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextCheckingResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addressCheckingResultWithRange:components:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult AddressCheckingResult(NSRange range, NSDictionary components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selAddressCheckingResultWithRange_Components_Handle, range, components.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult AddressCheckingResult(NSRange range, NSTextCheckingAddressComponents components)
	{
		return AddressCheckingResult(range, components.GetDictionary());
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

	[Export("correctionCheckingResultWithRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult CorrectionCheckingResult(NSRange range, string replacementString)
	{
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		NSTextCheckingResult nSObject = Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selCorrectionCheckingResultWithRange_ReplacementString_Handle, range, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("correctionCheckingResultWithRange:replacementString:alternativeStrings:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult CorrectionCheckingResult(NSRange range, string replacementString, string[] alternativeStrings)
	{
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		if (alternativeStrings == null)
		{
			throw new ArgumentNullException("alternativeStrings");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		NSArray nSArray = NSArray.FromStrings(alternativeStrings);
		NSTextCheckingResult nSObject = Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr(class_ptr, selCorrectionCheckingResultWithRange_ReplacementString_AlternativeStrings_Handle, range, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("dashCheckingResultWithRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult DashCheckingResult(NSRange range, string replacementString)
	{
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		NSTextCheckingResult nSObject = Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selDashCheckingResultWithRange_ReplacementString_Handle, range, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("dateCheckingResultWithRange:date:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult DateCheckingResult(NSRange range, NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selDateCheckingResultWithRange_Date_Handle, range, date.Handle));
	}

	[Export("dateCheckingResultWithRange:date:timeZone:duration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult DateCheckingResult(NSRange range, NSDate date, NSTimeZone timezone, double duration)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (timezone == null)
		{
			throw new ArgumentNullException("timezone");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_Double(class_ptr, selDateCheckingResultWithRange_Date_TimeZone_Duration_Handle, range, date.Handle, timezone.Handle, duration));
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

	[Export("rangeWithName:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetRange(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSRange result = ((!base.IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr(base.SuperHandle, selRangeWithName_Handle, arg) : Messaging.NSRange_objc_msgSend_IntPtr(base.Handle, selRangeWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("grammarCheckingResultWithRange:details:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult GrammarCheckingResult(NSRange range, string[] details)
	{
		if (details == null)
		{
			throw new ArgumentNullException("details");
		}
		NSArray nSArray = NSArray.FromStrings(details);
		NSTextCheckingResult nSObject = Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selGrammarCheckingResultWithRange_Details_Handle, range, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("linkCheckingResultWithRange:URL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult LinkCheckingResult(NSRange range, NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selLinkCheckingResultWithRange_URL_Handle, range, url.Handle));
	}

	[Export("orthographyCheckingResultWithRange:orthography:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult OrthographyCheckingResult(NSRange range, NSOrthography ortography)
	{
		if (ortography == null)
		{
			throw new ArgumentNullException("ortography");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selOrthographyCheckingResultWithRange_Orthography_Handle, range, ortography.Handle));
	}

	[Export("phoneNumberCheckingResultWithRange:phoneNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult PhoneNumberCheckingResult(NSRange range, string phoneNumber)
	{
		if (phoneNumber == null)
		{
			throw new ArgumentNullException("phoneNumber");
		}
		IntPtr arg = NSString.CreateNative(phoneNumber);
		NSTextCheckingResult nSObject = Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selPhoneNumberCheckingResultWithRange_PhoneNumber_Handle, range, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("quoteCheckingResultWithRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult QuoteCheckingResult(NSRange range, NSString replacementString)
	{
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selQuoteCheckingResultWithRange_ReplacementString_Handle, range, replacementString.Handle));
	}

	[Export("rangeAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange RangeAtIndex(nuint idx)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint(base.Handle, selRangeAtIndex_Handle, idx);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint(base.SuperHandle, selRangeAtIndex_Handle, idx);
	}

	[Export("replacementCheckingResultWithRange:replacementString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult ReplacementCheckingResult(NSRange range, string replacementString)
	{
		if (replacementString == null)
		{
			throw new ArgumentNullException("replacementString");
		}
		IntPtr arg = NSString.CreateNative(replacementString);
		NSTextCheckingResult nSObject = Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selReplacementCheckingResultWithRange_ReplacementString_Handle, range, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("resultByAdjustingRangesWithOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult ResultByAdjustingRanges(nint offset)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selResultByAdjustingRangesWithOffset_Handle, offset));
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selResultByAdjustingRangesWithOffset_Handle, offset));
	}

	[Export("spellCheckingResultWithRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult SpellCheckingResult(NSRange range)
	{
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selSpellCheckingResultWithRange_Handle, range));
	}

	[Export("transitInformationCheckingResultWithRange:components:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult TransitInformationCheckingResult(NSRange range, NSDictionary components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		return Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(class_ptr, selTransitInformationCheckingResultWithRange_Components_Handle, range, components.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextCheckingResult TransitInformationCheckingResult(NSRange range, NSTextCheckingTransitComponents components)
	{
		return TransitInformationCheckingResult(range, components.GetDictionary());
	}
}
