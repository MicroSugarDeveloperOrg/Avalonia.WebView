using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFilePromiseReceiver", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSFilePromiseReceiver : NSObject, INSPasteboardReading, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileNames = "fileNames";

	private static readonly IntPtr selFileNamesHandle = Selector.GetHandle("fileNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileTypes = "fileTypes";

	private static readonly IntPtr selFileTypesHandle = Selector.GetHandle("fileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableDraggedTypes = "readableDraggedTypes";

	private static readonly IntPtr selReadableDraggedTypesHandle = Selector.GetHandle("readableDraggedTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReceivePromisedFilesAtDestination_Options_OperationQueue_Reader_ = "receivePromisedFilesAtDestination:options:operationQueue:reader:";

	private static readonly IntPtr selReceivePromisedFilesAtDestination_Options_OperationQueue_Reader_Handle = Selector.GetHandle("receivePromisedFilesAtDestination:options:operationQueue:reader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

	private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFilePromiseReceiver");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] FileNames
	{
		[Export("fileNames", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] FileTypes
	{
		[Export("fileTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ReadableDraggedTypes
	{
		[Export("readableDraggedTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selReadableDraggedTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFilePromiseReceiver()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSFilePromiseReceiver(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFilePromiseReceiver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("readableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("readingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		NSApplication.EnsureUIThread();
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("receivePromisedFilesAtDestination:options:operationQueue:reader:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReceivePromisedFiles(NSUrl destinationDir, NSDictionary options, NSOperationQueue operationQueue, [BlockProxy(typeof(Trampolines.NIDActionArity2V6))] Action<NSUrl, NSError> reader)
	{
		NSApplication.EnsureUIThread();
		if (destinationDir == null)
		{
			throw new ArgumentNullException("destinationDir");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (operationQueue == null)
		{
			throw new ArgumentNullException("operationQueue");
		}
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V6.Handler, reader);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selReceivePromisedFilesAtDestination_Options_OperationQueue_Reader_Handle, destinationDir.Handle, options.Handle, operationQueue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReceivePromisedFilesAtDestination_Options_OperationQueue_Reader_Handle, destinationDir.Handle, options.Handle, operationQueue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
