using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMRange", true)]
public class DomRange : DomObject
{
	private static readonly IntPtr selStartContainerHandle = Selector.GetHandle("startContainer");

	private static readonly IntPtr selStartOffsetHandle = Selector.GetHandle("startOffset");

	private static readonly IntPtr selEndContainerHandle = Selector.GetHandle("endContainer");

	private static readonly IntPtr selEndOffsetHandle = Selector.GetHandle("endOffset");

	private static readonly IntPtr selCollapsedHandle = Selector.GetHandle("collapsed");

	private static readonly IntPtr selCommonAncestorContainerHandle = Selector.GetHandle("commonAncestorContainer");

	private static readonly IntPtr selTextHandle = Selector.GetHandle("text");

	private static readonly IntPtr selSetStartOffset_Handle = Selector.GetHandle("setStart:offset:");

	private static readonly IntPtr selSetEndOffset_Handle = Selector.GetHandle("setEnd:offset:");

	private static readonly IntPtr selSetStartBefore_Handle = Selector.GetHandle("setStartBefore:");

	private static readonly IntPtr selSetStartAfter_Handle = Selector.GetHandle("setStartAfter:");

	private static readonly IntPtr selSetEndBefore_Handle = Selector.GetHandle("setEndBefore:");

	private static readonly IntPtr selSetEndAfter_Handle = Selector.GetHandle("setEndAfter:");

	private static readonly IntPtr selCollapse_Handle = Selector.GetHandle("collapse:");

	private static readonly IntPtr selSelectNode_Handle = Selector.GetHandle("selectNode:");

	private static readonly IntPtr selSelectNodeContents_Handle = Selector.GetHandle("selectNodeContents:");

	private static readonly IntPtr selCompareBoundaryPointsSourceRange_Handle = Selector.GetHandle("compareBoundaryPoints:sourceRange:");

	private static readonly IntPtr selDeleteContentsHandle = Selector.GetHandle("deleteContents");

	private static readonly IntPtr selExtractContentsHandle = Selector.GetHandle("extractContents");

	private static readonly IntPtr selCloneContentsHandle = Selector.GetHandle("cloneContents");

	private static readonly IntPtr selInsertNode_Handle = Selector.GetHandle("insertNode:");

	private static readonly IntPtr selSurroundContents_Handle = Selector.GetHandle("surroundContents:");

	private static readonly IntPtr selCloneRangeHandle = Selector.GetHandle("cloneRange");

	private static readonly IntPtr selToStringHandle = Selector.GetHandle("toString");

	private static readonly IntPtr selDetachHandle = Selector.GetHandle("detach");

	private static readonly IntPtr selCreateContextualFragment_Handle = Selector.GetHandle("createContextualFragment:");

	private static readonly IntPtr selIntersectsNode_Handle = Selector.GetHandle("intersectsNode:");

	private static readonly IntPtr selCompareNode_Handle = Selector.GetHandle("compareNode:");

	private static readonly IntPtr selComparePointOffset_Handle = Selector.GetHandle("comparePoint:offset:");

	private static readonly IntPtr selIsPointInRangeOffset_Handle = Selector.GetHandle("isPointInRange:offset:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMRange");

	private object __mt_StartContainer_var;

	private object __mt_EndContainer_var;

	private object __mt_CommonAncestorContainer_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual DomNode StartContainer
	{
		[Export("startContainer")]
		get
		{
			return (DomNode)(__mt_StartContainer_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartContainerHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStartContainerHandle)))));
		}
	}

	public virtual int StartOffset
	{
		[Export("startOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selStartOffsetHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selStartOffsetHandle);
		}
	}

	public virtual DomNode EndContainer
	{
		[Export("endContainer")]
		get
		{
			return (DomNode)(__mt_EndContainer_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndContainerHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEndContainerHandle)))));
		}
	}

	public virtual int EndOffset
	{
		[Export("endOffset")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selEndOffsetHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selEndOffsetHandle);
		}
	}

	public virtual bool Collapsed
	{
		[Export("collapsed")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCollapsedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCollapsedHandle);
		}
	}

	public virtual DomNode CommonAncestorContainer
	{
		[Export("commonAncestorContainer")]
		get
		{
			return (DomNode)(__mt_CommonAncestorContainer_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonAncestorContainerHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonAncestorContainerHandle)))));
		}
	}

	public virtual string Text
	{
		[Export("text")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomRange(NSCoder coder)
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
	public DomRange(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomRange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setStart:offset:")]
	public virtual void SetStart(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetStartOffset_Handle, refNode.Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetStartOffset_Handle, refNode.Handle, offset);
		}
	}

	[Export("setEnd:offset:")]
	public virtual void SetEnd(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetEndOffset_Handle, refNode.Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetEndOffset_Handle, refNode.Handle, offset);
		}
	}

	[Export("setStartBefore:")]
	public virtual void SetStartBefore(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartBefore_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartBefore_Handle, refNode.Handle);
		}
	}

	[Export("setStartAfter:")]
	public virtual void SetStartAfter(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartAfter_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartAfter_Handle, refNode.Handle);
		}
	}

	[Export("setEndBefore:")]
	public virtual void SetEndBefore(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEndBefore_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEndBefore_Handle, refNode.Handle);
		}
	}

	[Export("setEndAfter:")]
	public virtual void SetEndAfter(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEndAfter_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEndAfter_Handle, refNode.Handle);
		}
	}

	[Export("collapse:")]
	public virtual void Collapse(bool toStart)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selCollapse_Handle, toStart);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selCollapse_Handle, toStart);
		}
	}

	[Export("selectNode:")]
	public virtual void SelectNode(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNode_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNode_Handle, refNode.Handle);
		}
	}

	[Export("selectNodeContents:")]
	public virtual void SelectNodeContents(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNodeContents_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNodeContents_Handle, refNode.Handle);
		}
	}

	[Export("compareBoundaryPoints:sourceRange:")]
	public virtual short CompareBoundaryPoints(DomRangeCompareHow how, DomRange sourceRange)
	{
		if (sourceRange == null)
		{
			throw new ArgumentNullException("sourceRange");
		}
		if (IsDirectBinding)
		{
			return Messaging.short_objc_msgSend_UInt16_IntPtr(base.Handle, selCompareBoundaryPointsSourceRange_Handle, (ushort)how, sourceRange.Handle);
		}
		return Messaging.short_objc_msgSendSuper_UInt16_IntPtr(base.SuperHandle, selCompareBoundaryPointsSourceRange_Handle, (ushort)how, sourceRange.Handle);
	}

	[Export("deleteContents")]
	public virtual void DeleteContents()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeleteContentsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeleteContentsHandle);
		}
	}

	[Export("extractContents")]
	public virtual DomDocumentFragment ExtractContents()
	{
		if (IsDirectBinding)
		{
			return (DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExtractContentsHandle));
		}
		return (DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtractContentsHandle));
	}

	[Export("cloneContents")]
	public virtual DomDocumentFragment CloneContents()
	{
		if (IsDirectBinding)
		{
			return (DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCloneContentsHandle));
		}
		return (DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCloneContentsHandle));
	}

	[Export("insertNode:")]
	public virtual void InsertNode(DomNode newNode)
	{
		if (newNode == null)
		{
			throw new ArgumentNullException("newNode");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertNode_Handle, newNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertNode_Handle, newNode.Handle);
		}
	}

	[Export("surroundContents:")]
	public virtual void SurroundContents(DomNode newParent)
	{
		if (newParent == null)
		{
			throw new ArgumentNullException("newParent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSurroundContents_Handle, newParent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSurroundContents_Handle, newParent.Handle);
		}
	}

	[Export("cloneRange")]
	public virtual DomRange CloneRange()
	{
		if (IsDirectBinding)
		{
			return (DomRange)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCloneRangeHandle));
		}
		return (DomRange)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCloneRangeHandle));
	}

	[Export("toString")]
	public new virtual string ToString()
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToStringHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToStringHandle));
	}

	[Export("detach")]
	public virtual void Detach()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDetachHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDetachHandle);
		}
	}

	[Export("createContextualFragment:")]
	public virtual DomDocumentFragment CreateContextualFragment(string html)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		IntPtr arg = NSString.CreateNative(html);
		DomDocumentFragment result = ((!IsDirectBinding) ? ((DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateContextualFragment_Handle, arg))) : ((DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateContextualFragment_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("intersectsNode:")]
	public virtual bool IntersectsNode(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsNode_Handle, refNode.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsNode_Handle, refNode.Handle);
	}

	[Export("compareNode:")]
	public virtual short CompareNode(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			return Messaging.short_objc_msgSend_IntPtr(base.Handle, selCompareNode_Handle, refNode.Handle);
		}
		return Messaging.short_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompareNode_Handle, refNode.Handle);
	}

	[Export("comparePoint:offset:")]
	public virtual short ComparePoint(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			return Messaging.short_objc_msgSend_IntPtr_int(base.Handle, selComparePointOffset_Handle, refNode.Handle, offset);
		}
		return Messaging.short_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selComparePointOffset_Handle, refNode.Handle, offset);
	}

	[Export("isPointInRange:offset:")]
	public virtual bool IsPointInRange(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_int(base.Handle, selIsPointInRangeOffset_Handle, refNode.Handle, offset);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selIsPointInRangeOffset_Handle, refNode.Handle, offset);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_StartContainer_var = null;
			__mt_EndContainer_var = null;
			__mt_CommonAncestorContainer_var = null;
		}
	}
}
