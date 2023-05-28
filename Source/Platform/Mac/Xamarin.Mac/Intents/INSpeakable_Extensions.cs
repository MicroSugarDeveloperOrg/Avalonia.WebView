using Foundation;
using ObjCRuntime;

namespace Intents;

public static class INSpeakable_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetVocabularyIdentifier(this IINSpeakable This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("vocabularyIdentifier")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IINSpeakable[] GetAlternativeSpeakableMatches(this IINSpeakable This)
	{
		return NSArray.ArrayFromHandle<IINSpeakable>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("alternativeSpeakableMatches")));
	}
}
