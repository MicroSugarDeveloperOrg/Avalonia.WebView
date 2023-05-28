using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

internal sealed class INSpeakableWrapper : BaseWrapper, IINSpeakable, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string SpokenPhrase
	{
		[Export("spokenPhrase")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("spokenPhrase")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? PronunciationHint
	{
		[Export("pronunciationHint")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("pronunciationHint")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
	public string? Identifier
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'VocabularyIdentifier' instead.")]
		[Export("identifier")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("identifier")));
		}
	}

	[Preserve(Conditional = true)]
	public INSpeakableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
