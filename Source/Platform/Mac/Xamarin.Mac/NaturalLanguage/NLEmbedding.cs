using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NaturalLanguage;

[Register("NLEmbedding", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NLEmbedding : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsString_ = "containsString:";

	private static readonly IntPtr selContainsString_Handle = Selector.GetHandle("containsString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentRevisionForLanguage_ = "currentRevisionForLanguage:";

	private static readonly IntPtr selCurrentRevisionForLanguage_Handle = Selector.GetHandle("currentRevisionForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDimension = "dimension";

	private static readonly IntPtr selDimensionHandle = Selector.GetHandle("dimension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistanceBetweenString_AndString_DistanceType_ = "distanceBetweenString:andString:distanceType:";

	private static readonly IntPtr selDistanceBetweenString_AndString_DistanceType_Handle = Selector.GetHandle("distanceBetweenString:andString:distanceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmbeddingWithContentsOfURL_Error_ = "embeddingWithContentsOfURL:error:";

	private static readonly IntPtr selEmbeddingWithContentsOfURL_Error_Handle = Selector.GetHandle("embeddingWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateNeighborsForString_MaximumCount_DistanceType_UsingBlock_ = "enumerateNeighborsForString:maximumCount:distanceType:usingBlock:";

	private static readonly IntPtr selEnumerateNeighborsForString_MaximumCount_DistanceType_UsingBlock_Handle = Selector.GetHandle("enumerateNeighborsForString:maximumCount:distanceType:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateNeighborsForString_MaximumCount_MaximumDistance_DistanceType_UsingBlock_ = "enumerateNeighborsForString:maximumCount:maximumDistance:distanceType:usingBlock:";

	private static readonly IntPtr selEnumerateNeighborsForString_MaximumCount_MaximumDistance_DistanceType_UsingBlock_Handle = Selector.GetHandle("enumerateNeighborsForString:maximumCount:maximumDistance:distanceType:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateNeighborsForVector_MaximumCount_DistanceType_UsingBlock_ = "enumerateNeighborsForVector:maximumCount:distanceType:usingBlock:";

	private static readonly IntPtr selEnumerateNeighborsForVector_MaximumCount_DistanceType_UsingBlock_Handle = Selector.GetHandle("enumerateNeighborsForVector:maximumCount:distanceType:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_UsingBlock_ = "enumerateNeighborsForVector:maximumCount:maximumDistance:distanceType:usingBlock:";

	private static readonly IntPtr selEnumerateNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_UsingBlock_Handle = Selector.GetHandle("enumerateNeighborsForVector:maximumCount:maximumDistance:distanceType:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetVector_ForString_ = "getVector:forString:";

	private static readonly IntPtr selGetVector_ForString_Handle = Selector.GetHandle("getVector:forString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguage = "language";

	private static readonly IntPtr selLanguageHandle = Selector.GetHandle("language");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeighborsForString_MaximumCount_DistanceType_ = "neighborsForString:maximumCount:distanceType:";

	private static readonly IntPtr selNeighborsForString_MaximumCount_DistanceType_Handle = Selector.GetHandle("neighborsForString:maximumCount:distanceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeighborsForString_MaximumCount_MaximumDistance_DistanceType_ = "neighborsForString:maximumCount:maximumDistance:distanceType:";

	private static readonly IntPtr selNeighborsForString_MaximumCount_MaximumDistance_DistanceType_Handle = Selector.GetHandle("neighborsForString:maximumCount:maximumDistance:distanceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeighborsForVector_MaximumCount_DistanceType_ = "neighborsForVector:maximumCount:distanceType:";

	private static readonly IntPtr selNeighborsForVector_MaximumCount_DistanceType_Handle = Selector.GetHandle("neighborsForVector:maximumCount:distanceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_ = "neighborsForVector:maximumCount:maximumDistance:distanceType:";

	private static readonly IntPtr selNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_Handle = Selector.GetHandle("neighborsForVector:maximumCount:maximumDistance:distanceType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevision = "revision";

	private static readonly IntPtr selRevisionHandle = Selector.GetHandle("revision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedRevisionsForLanguage_ = "supportedRevisionsForLanguage:";

	private static readonly IntPtr selSupportedRevisionsForLanguage_Handle = Selector.GetHandle("supportedRevisionsForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorForString_ = "vectorForString:";

	private static readonly IntPtr selVectorForString_Handle = Selector.GetHandle("vectorForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVocabularySize = "vocabularySize";

	private static readonly IntPtr selVocabularySizeHandle = Selector.GetHandle("vocabularySize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWordEmbeddingForLanguage_ = "wordEmbeddingForLanguage:";

	private static readonly IntPtr selWordEmbeddingForLanguage_Handle = Selector.GetHandle("wordEmbeddingForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWordEmbeddingForLanguage_Revision_ = "wordEmbeddingForLanguage:revision:";

	private static readonly IntPtr selWordEmbeddingForLanguage_Revision_Handle = Selector.GetHandle("wordEmbeddingForLanguage:revision:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteEmbeddingForDictionary_Language_Revision_ToURL_Error_ = "writeEmbeddingForDictionary:language:revision:toURL:error:";

	private static readonly IntPtr selWriteEmbeddingForDictionary_Language_Revision_ToURL_Error_Handle = Selector.GetHandle("writeEmbeddingForDictionary:language:revision:toURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NLEmbedding");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Dimension
	{
		[Export("dimension")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDimensionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDimensionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[BindAs(typeof(NLLanguage?), OriginalType = typeof(NSString))]
	public virtual NLLanguage? Language
	{
		[Export("language")]
		get
		{
			IntPtr ptr;
			if (base.IsDirectBinding)
			{
				return ((ptr = Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageHandle)) == IntPtr.Zero) ? null : new NLLanguage?(NLLanguageExtensions.GetValue(Runtime.GetNSObject<NSString>(ptr)));
			}
			IntPtr ptr2;
			return ((ptr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageHandle)) == IntPtr.Zero) ? null : new NLLanguage?(NLLanguageExtensions.GetValue(Runtime.GetNSObject<NSString>(ptr2)));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Revision
	{
		[Export("revision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRevisionHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRevisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VocabularySize
	{
		[Export("vocabularySize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVocabularySizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVocabularySizeHandle);
		}
	}

	public unsafe bool TryGetVector(string @string, out float[] vector)
	{
		bool flag = false;
		vector = new float[(ulong)Dimension];
		fixed (float* ptr = vector)
		{
			flag = GetVector((IntPtr)ptr, @string);
		}
		if (!flag)
		{
			vector = null;
		}
		return flag;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NLEmbedding(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NLEmbedding(IntPtr handle)
		: base(handle)
	{
	}

	[Export("containsString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsString_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("enumerateNeighborsForString:maximumCount:distanceType:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateNeighbors(string @string, nuint maxCount, NLDistanceType distanceType, [BlockProxy(typeof(Trampolines.NIDNLEnumerateNeighborsHandler))] NLEnumerateNeighborsHandler handler)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(@string);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNLEnumerateNeighborsHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Int64_IntPtr(base.Handle, selEnumerateNeighborsForString_MaximumCount_DistanceType_UsingBlock_Handle, arg, maxCount, (long)distanceType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Int64_IntPtr(base.SuperHandle, selEnumerateNeighborsForString_MaximumCount_DistanceType_UsingBlock_Handle, arg, maxCount, (long)distanceType, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("enumerateNeighborsForString:maximumCount:maximumDistance:distanceType:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateNeighbors(string @string, nuint maxCount, double maxDistance, NLDistanceType distanceType, [BlockProxy(typeof(Trampolines.NIDNLEnumerateNeighborsHandler))] NLEnumerateNeighborsHandler handler)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(@string);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNLEnumerateNeighborsHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double_Int64_IntPtr(base.Handle, selEnumerateNeighborsForString_MaximumCount_MaximumDistance_DistanceType_UsingBlock_Handle, arg, maxCount, maxDistance, (long)distanceType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double_Int64_IntPtr(base.SuperHandle, selEnumerateNeighborsForString_MaximumCount_MaximumDistance_DistanceType_UsingBlock_Handle, arg, maxCount, maxDistance, (long)distanceType, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("enumerateNeighborsForVector:maximumCount:distanceType:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateNeighbors([BindAs(typeof(float[]), OriginalType = typeof(NSNumber[]))] float[] vector, nuint maxCount, NLDistanceType distanceType, [BlockProxy(typeof(Trampolines.NIDNLEnumerateNeighborsHandler))] NLEnumerateNeighborsHandler handler)
	{
		if (vector == null)
		{
			throw new ArgumentNullException("vector");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects((float o) => new NSNumber(o), vector);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNLEnumerateNeighborsHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Int64_IntPtr(base.Handle, selEnumerateNeighborsForVector_MaximumCount_DistanceType_UsingBlock_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, (long)distanceType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Int64_IntPtr(base.SuperHandle, selEnumerateNeighborsForVector_MaximumCount_DistanceType_UsingBlock_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, (long)distanceType, (IntPtr)ptr);
		}
		nSArray?.Dispose();
		ptr->CleanupBlock();
	}

	[Export("enumerateNeighborsForVector:maximumCount:maximumDistance:distanceType:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateNeighbors([BindAs(typeof(float[]), OriginalType = typeof(NSNumber[]))] float[] vector, nuint maxCount, double maxDistance, NLDistanceType distanceType, [BlockProxy(typeof(Trampolines.NIDNLEnumerateNeighborsHandler))] NLEnumerateNeighborsHandler handler)
	{
		if (vector == null)
		{
			throw new ArgumentNullException("vector");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects((float o) => new NSNumber(o), vector);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNLEnumerateNeighborsHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double_Int64_IntPtr(base.Handle, selEnumerateNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_UsingBlock_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, maxDistance, (long)distanceType, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double_Int64_IntPtr(base.SuperHandle, selEnumerateNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_UsingBlock_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, maxDistance, (long)distanceType, (IntPtr)ptr);
		}
		nSArray?.Dispose();
		ptr->CleanupBlock();
	}

	[Export("currentRevisionForLanguage:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCurrentRevision(NSString language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		return Messaging.nuint_objc_msgSend_IntPtr(class_ptr, selCurrentRevisionForLanguage_Handle, language.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCurrentRevision(NLLanguage language)
	{
		return GetCurrentRevision(language.GetConstant());
	}

	[Export("distanceBetweenString:andString:distanceType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetDistance(string firstString, string secondString, NLDistanceType distanceType)
	{
		if (firstString == null)
		{
			throw new ArgumentNullException("firstString");
		}
		if (secondString == null)
		{
			throw new ArgumentNullException("secondString");
		}
		IntPtr arg = NSString.CreateNative(firstString);
		IntPtr arg2 = NSString.CreateNative(secondString);
		double result = ((!base.IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr_IntPtr_Int64(base.SuperHandle, selDistanceBetweenString_AndString_DistanceType_Handle, arg, arg2, (long)distanceType) : Messaging.Double_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, selDistanceBetweenString_AndString_DistanceType_Handle, arg, arg2, (long)distanceType));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("embeddingWithContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLEmbedding? GetEmbedding(NSUrl url, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NLEmbedding nSObject = Runtime.GetNSObject<NLEmbedding>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selEmbeddingWithContentsOfURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("neighborsForString:maximumCount:distanceType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? GetNeighbors(string @string, nuint maxCount, NLDistanceType distanceType)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_Int64(base.SuperHandle, selNeighborsForString_MaximumCount_DistanceType_Handle, arg, maxCount, (long)distanceType)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_Int64(base.Handle, selNeighborsForString_MaximumCount_DistanceType_Handle, arg, maxCount, (long)distanceType)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("neighborsForString:maximumCount:maximumDistance:distanceType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? GetNeighbors(string @string, nuint maxCount, double maxDistance, NLDistanceType distanceType)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_Double_Int64(base.SuperHandle, selNeighborsForString_MaximumCount_MaximumDistance_DistanceType_Handle, arg, maxCount, maxDistance, (long)distanceType)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_Double_Int64(base.Handle, selNeighborsForString_MaximumCount_MaximumDistance_DistanceType_Handle, arg, maxCount, maxDistance, (long)distanceType)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("neighborsForVector:maximumCount:distanceType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetNeighbors([BindAs(typeof(float[]), OriginalType = typeof(NSNumber[]))] float[] vector, nuint maxCount, NLDistanceType distanceType)
	{
		if (vector == null)
		{
			throw new ArgumentNullException("vector");
		}
		NSArray nSArray = NSArray.FromNSObjects((float o) => new NSNumber(o), vector);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_Int64(base.SuperHandle, selNeighborsForVector_MaximumCount_DistanceType_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, (long)distanceType)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_Int64(base.Handle, selNeighborsForVector_MaximumCount_DistanceType_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, (long)distanceType)));
		nSArray?.Dispose();
		return result;
	}

	[Export("neighborsForVector:maximumCount:maximumDistance:distanceType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetNeighbors([BindAs(typeof(float[]), OriginalType = typeof(NSNumber[]))] float[] vector, nuint maxCount, double maxDistance, NLDistanceType distanceType)
	{
		if (vector == null)
		{
			throw new ArgumentNullException("vector");
		}
		NSArray nSArray = NSArray.FromNSObjects((float o) => new NSNumber(o), vector);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_Double_Int64(base.SuperHandle, selNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, maxDistance, (long)distanceType)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_Double_Int64(base.Handle, selNeighborsForVector_MaximumCount_MaximumDistance_DistanceType_Handle, nSArray?.Handle ?? IntPtr.Zero, maxCount, maxDistance, (long)distanceType)));
		nSArray?.Dispose();
		return result;
	}

	[Export("supportedRevisionsForLanguage:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet GetSupportedRevisions(NSString language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSupportedRevisionsForLanguage_Handle, language.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexSet GetSupportedRevisions(NLLanguage language)
	{
		return GetSupportedRevisions(language.GetConstant());
	}

	[Export("vectorForString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: BindAs(typeof(float[]), OriginalType = typeof(NSNumber[]))]
	public virtual float[]? GetVector(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		IntPtr intPtr;
		IntPtr intPtr2;
		float[] result = ((!base.IsDirectBinding) ? (((intPtr = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selVectorForString_Handle, arg)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr, delegate(IntPtr ptr)
		{
			using NSNumber nSNumber2 = Runtime.GetNSObject<NSNumber>(ptr);
			return nSNumber2.FloatValue;
		})) : (((intPtr2 = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selVectorForString_Handle, arg)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr2, delegate(IntPtr ptr)
		{
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(ptr);
			return nSNumber.FloatValue;
		})));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getVector:forString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool GetVector(IntPtr vector, string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetVector_ForString_Handle, vector, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetVector_ForString_Handle, vector, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("wordEmbeddingForLanguage:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLEmbedding? GetWordEmbedding(NSString language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		return Runtime.GetNSObject<NLEmbedding>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selWordEmbeddingForLanguage_Handle, language.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLEmbedding? GetWordEmbedding(NLLanguage language)
	{
		return GetWordEmbedding(language.GetConstant());
	}

	[Export("wordEmbeddingForLanguage:revision:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLEmbedding? GetWordEmbedding(NSString language, nuint revision)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		return Runtime.GetNSObject<NLEmbedding>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selWordEmbeddingForLanguage_Revision_Handle, language.Handle, revision));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLEmbedding? GetWordEmbedding(NLLanguage language, nuint revision)
	{
		return GetWordEmbedding(language.GetConstant());
	}

	[Export("writeEmbeddingForDictionary:language:revision:toURL:error:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Write(NSDictionary dictionary, NSString? language, nuint revision, NSUrl url, out NSError? error)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_ref_IntPtr(class_ptr, selWriteEmbeddingForDictionary_Language_Revision_ToURL_Error_Handle, dictionary.Handle, (language == null) ? IntPtr.Zero : language.Handle, revision, url.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Write(NLVectorDictionary dictionary, NLLanguage? language, nuint revision, NSUrl url, out NSError? error)
	{
		return Write(dictionary.GetDictionary(), language.HasValue ? language.Value.GetConstant() : null, revision, url, out error);
	}
}
