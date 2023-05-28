using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLookThumbnailing;

[Register("QLThumbnailReply", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class QLThumbnailReply : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyWithContextSize_CurrentContextDrawingBlock_ = "replyWithContextSize:currentContextDrawingBlock:";

	private static readonly IntPtr selReplyWithContextSize_CurrentContextDrawingBlock_Handle = Selector.GetHandle("replyWithContextSize:currentContextDrawingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyWithContextSize_DrawingBlock_ = "replyWithContextSize:drawingBlock:";

	private static readonly IntPtr selReplyWithContextSize_DrawingBlock_Handle = Selector.GetHandle("replyWithContextSize:drawingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyWithImageFileURL_ = "replyWithImageFileURL:";

	private static readonly IntPtr selReplyWithImageFileURL_Handle = Selector.GetHandle("replyWithImageFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QLThumbnailReply");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QLThumbnailReply(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLThumbnailReply(IntPtr handle)
		: base(handle)
	{
	}

	[Export("replyWithContextSize:drawingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static QLThumbnailReply CreateReply(CGSize contextSize, [BlockProxy(typeof(Trampolines.NIDFuncArity2V5))] Func<CGContext, bool> drawingBlock)
	{
		if (drawingBlock == null)
		{
			throw new ArgumentNullException("drawingBlock");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity2V5.Handler, drawingBlock);
		QLThumbnailReply nSObject = Runtime.GetNSObject<QLThumbnailReply>(Messaging.IntPtr_objc_msgSend_CGSize_IntPtr(class_ptr, selReplyWithContextSize_DrawingBlock_Handle, contextSize, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("replyWithContextSize:currentContextDrawingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static QLThumbnailReply CreateReply(CGSize contextSize, [BlockProxy(typeof(Trampolines.NIDFuncArity1V0))] Func<bool> drawingBlock)
	{
		if (drawingBlock == null)
		{
			throw new ArgumentNullException("drawingBlock");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity1V0.Handler, drawingBlock);
		QLThumbnailReply nSObject = Runtime.GetNSObject<QLThumbnailReply>(Messaging.IntPtr_objc_msgSend_CGSize_IntPtr(class_ptr, selReplyWithContextSize_CurrentContextDrawingBlock_Handle, contextSize, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("replyWithImageFileURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QLThumbnailReply CreateReply(NSUrl fileUrl)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		return Runtime.GetNSObject<QLThumbnailReply>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReplyWithImageFileURL_Handle, fileUrl.Handle));
	}
}
