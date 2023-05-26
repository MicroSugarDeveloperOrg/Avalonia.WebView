using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSOrthography", true)]
public class NSOrthography : NSObject
{
	private static readonly IntPtr selDominantScriptHandle = Selector.GetHandle("dominantScript");

	private static readonly IntPtr selLanguageMapHandle = Selector.GetHandle("languageMap");

	private static readonly IntPtr selDominantLanguageHandle = Selector.GetHandle("dominantLanguage");

	private static readonly IntPtr selAllScriptsHandle = Selector.GetHandle("allScripts");

	private static readonly IntPtr selAllLanguagesHandle = Selector.GetHandle("allLanguages");

	private static readonly IntPtr selLanguagesForScript_Handle = Selector.GetHandle("languagesForScript:");

	private static readonly IntPtr selDominantLanguageForScript_Handle = Selector.GetHandle("dominantLanguageForScript:");

	private static readonly IntPtr selInitWithDominantScriptLanguageMap_Handle = Selector.GetHandle("initWithDominantScript:languageMap:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOrthography");

	private object __mt_LanguageMap_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string DominantScript
	{
		[Export("dominantScript")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDominantScriptHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDominantScriptHandle));
		}
	}

	public virtual NSDictionary LanguageMap
	{
		[Export("languageMap")]
		get
		{
			return (NSDictionary)(__mt_LanguageMap_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageMapHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageMapHandle)))));
		}
	}

	public virtual string DominantLanguage
	{
		[Export("dominantLanguage")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDominantLanguageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDominantLanguageHandle));
		}
	}

	public virtual string[] AllScripts
	{
		[Export("allScripts")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllScriptsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllScriptsHandle));
		}
	}

	public virtual string[] AllLanguages
	{
		[Export("allLanguages")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllLanguagesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllLanguagesHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOrthography(NSCoder coder)
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
	public NSOrthography(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOrthography(IntPtr handle)
		: base(handle)
	{
	}

	[Export("languagesForScript:")]
	public virtual string[] LanguagesForScript(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLanguagesForScript_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLanguagesForScript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dominantLanguageForScript:")]
	public virtual string DominantLanguageForScript(string script)
	{
		if (script == null)
		{
			throw new ArgumentNullException("script");
		}
		IntPtr arg = NSString.CreateNative(script);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDominantLanguageForScript_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDominantLanguageForScript_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithDominantScript:languageMap:")]
	public NSOrthography(string dominantScript, NSDictionary languageMap)
		: base(NSObjectFlag.Empty)
	{
		if (dominantScript == null)
		{
			throw new ArgumentNullException("dominantScript");
		}
		IntPtr arg = NSString.CreateNative(dominantScript);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDominantScriptLanguageMap_Handle, arg, languageMap?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDominantScriptLanguageMap_Handle, arg, languageMap?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LanguageMap_var = null;
		}
	}
}
