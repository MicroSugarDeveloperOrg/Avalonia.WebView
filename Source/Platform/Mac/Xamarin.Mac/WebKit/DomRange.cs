using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMRange", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomRange : DomObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloneContents = "cloneContents";

	private static readonly IntPtr selCloneContentsHandle = Selector.GetHandle("cloneContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloneRange = "cloneRange";

	private static readonly IntPtr selCloneRangeHandle = Selector.GetHandle("cloneRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapse_ = "collapse:";

	private static readonly IntPtr selCollapse_Handle = Selector.GetHandle("collapse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapsed = "collapsed";

	private static readonly IntPtr selCollapsedHandle = Selector.GetHandle("collapsed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonAncestorContainer = "commonAncestorContainer";

	private static readonly IntPtr selCommonAncestorContainerHandle = Selector.GetHandle("commonAncestorContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareBoundaryPoints_SourceRange_ = "compareBoundaryPoints:sourceRange:";

	private static readonly IntPtr selCompareBoundaryPoints_SourceRange_Handle = Selector.GetHandle("compareBoundaryPoints:sourceRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareNode_ = "compareNode:";

	private static readonly IntPtr selCompareNode_Handle = Selector.GetHandle("compareNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComparePoint_Offset_ = "comparePoint:offset:";

	private static readonly IntPtr selComparePoint_Offset_Handle = Selector.GetHandle("comparePoint:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateContextualFragment_ = "createContextualFragment:";

	private static readonly IntPtr selCreateContextualFragment_Handle = Selector.GetHandle("createContextualFragment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteContents = "deleteContents";

	private static readonly IntPtr selDeleteContentsHandle = Selector.GetHandle("deleteContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetach = "detach";

	private static readonly IntPtr selDetachHandle = Selector.GetHandle("detach");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndContainer = "endContainer";

	private static readonly IntPtr selEndContainerHandle = Selector.GetHandle("endContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndOffset = "endOffset";

	private static readonly IntPtr selEndOffsetHandle = Selector.GetHandle("endOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtractContents = "extractContents";

	private static readonly IntPtr selExtractContentsHandle = Selector.GetHandle("extractContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertNode_ = "insertNode:";

	private static readonly IntPtr selInsertNode_Handle = Selector.GetHandle("insertNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectsNode_ = "intersectsNode:";

	private static readonly IntPtr selIntersectsNode_Handle = Selector.GetHandle("intersectsNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPointInRange_Offset_ = "isPointInRange:offset:";

	private static readonly IntPtr selIsPointInRange_Offset_Handle = Selector.GetHandle("isPointInRange:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNode_ = "selectNode:";

	private static readonly IntPtr selSelectNode_Handle = Selector.GetHandle("selectNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectNodeContents_ = "selectNodeContents:";

	private static readonly IntPtr selSelectNodeContents_Handle = Selector.GetHandle("selectNodeContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnd_Offset_ = "setEnd:offset:";

	private static readonly IntPtr selSetEnd_Offset_Handle = Selector.GetHandle("setEnd:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndAfter_ = "setEndAfter:";

	private static readonly IntPtr selSetEndAfter_Handle = Selector.GetHandle("setEndAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndBefore_ = "setEndBefore:";

	private static readonly IntPtr selSetEndBefore_Handle = Selector.GetHandle("setEndBefore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStart_Offset_ = "setStart:offset:";

	private static readonly IntPtr selSetStart_Offset_Handle = Selector.GetHandle("setStart:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartAfter_ = "setStartAfter:";

	private static readonly IntPtr selSetStartAfter_Handle = Selector.GetHandle("setStartAfter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartBefore_ = "setStartBefore:";

	private static readonly IntPtr selSetStartBefore_Handle = Selector.GetHandle("setStartBefore:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartContainer = "startContainer";

	private static readonly IntPtr selStartContainerHandle = Selector.GetHandle("startContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartOffset = "startOffset";

	private static readonly IntPtr selStartOffsetHandle = Selector.GetHandle("startOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSurroundContents_ = "surroundContents:";

	private static readonly IntPtr selSurroundContents_Handle = Selector.GetHandle("surroundContents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selText = "text";

	private static readonly IntPtr selTextHandle = Selector.GetHandle("text");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToString = "toString";

	private static readonly IntPtr selToStringHandle = Selector.GetHandle("toString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMRange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Collapsed
	{
		[Export("collapsed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCollapsedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCollapsedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode CommonAncestorContainer
	{
		[Export("commonAncestorContainer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonAncestorContainerHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonAncestorContainerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode EndContainer
	{
		[Export("endContainer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndContainerHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndContainerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int EndOffset
	{
		[Export("endOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selEndOffsetHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selEndOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode StartContainer
	{
		[Export("startContainer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartContainerHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartContainerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int StartOffset
	{
		[Export("startOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selStartOffsetHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selStartOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Text
	{
		[Export("text", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomRange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomRange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cloneContents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocumentFragment CloneContents()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSend(base.Handle, selCloneContentsHandle));
		}
		return Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCloneContentsHandle));
	}

	[Export("cloneRange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomRange CloneRange()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selCloneRangeHandle));
		}
		return Runtime.GetNSObject<DomRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCloneRangeHandle));
	}

	[Export("collapse:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Collapse(bool toStart)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selCollapse_Handle, toStart);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selCollapse_Handle, toStart);
		}
	}

	[Export("compareBoundaryPoints:sourceRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual short CompareBoundaryPoints(DomRangeCompareHow how, DomRange sourceRange)
	{
		if (sourceRange == null)
		{
			throw new ArgumentNullException("sourceRange");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.short_objc_msgSend_UInt16_IntPtr(base.Handle, selCompareBoundaryPoints_SourceRange_Handle, (ushort)how, sourceRange.Handle);
		}
		return Messaging.short_objc_msgSendSuper_UInt16_IntPtr(base.SuperHandle, selCompareBoundaryPoints_SourceRange_Handle, (ushort)how, sourceRange.Handle);
	}

	[Export("compareNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual short CompareNode(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.short_objc_msgSend_IntPtr(base.Handle, selCompareNode_Handle, refNode.Handle);
		}
		return Messaging.short_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompareNode_Handle, refNode.Handle);
	}

	[Export("comparePoint:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual short ComparePoint(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.short_objc_msgSend_IntPtr_int(base.Handle, selComparePoint_Offset_Handle, refNode.Handle, offset);
		}
		return Messaging.short_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selComparePoint_Offset_Handle, refNode.Handle, offset);
	}

	[Export("createContextualFragment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocumentFragment CreateContextualFragment(string html)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		IntPtr arg = NSString.CreateNative(html);
		DomDocumentFragment result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateContextualFragment_Handle, arg)) : Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateContextualFragment_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("deleteContents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteContents()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeleteContentsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeleteContentsHandle);
		}
	}

	[Export("detach")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Detach()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDetachHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDetachHandle);
		}
	}

	[Export("extractContents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocumentFragment ExtractContents()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtractContentsHandle));
		}
		return Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtractContentsHandle));
	}

	[Export("insertNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertNode(DomNode newNode)
	{
		if (newNode == null)
		{
			throw new ArgumentNullException("newNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertNode_Handle, newNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertNode_Handle, newNode.Handle);
		}
	}

	[Export("intersectsNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IntersectsNode(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIntersectsNode_Handle, refNode.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectsNode_Handle, refNode.Handle);
	}

	[Export("isPointInRange:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPointInRange(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_int(base.Handle, selIsPointInRange_Offset_Handle, refNode.Handle, offset);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selIsPointInRange_Offset_Handle, refNode.Handle, offset);
	}

	[Export("selectNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNode(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNode_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNode_Handle, refNode.Handle);
		}
	}

	[Export("selectNodeContents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectNodeContents(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectNodeContents_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectNodeContents_Handle, refNode.Handle);
		}
	}

	[Export("setEnd:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEnd(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetEnd_Offset_Handle, refNode.Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetEnd_Offset_Handle, refNode.Handle, offset);
		}
	}

	[Export("setEndAfter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEndAfter(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEndAfter_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEndAfter_Handle, refNode.Handle);
		}
	}

	[Export("setEndBefore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEndBefore(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEndBefore_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEndBefore_Handle, refNode.Handle);
		}
	}

	[Export("setStart:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetStart(DomNode refNode, int offset)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetStart_Offset_Handle, refNode.Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetStart_Offset_Handle, refNode.Handle, offset);
		}
	}

	[Export("setStartAfter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetStartAfter(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartAfter_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartAfter_Handle, refNode.Handle);
		}
	}

	[Export("setStartBefore:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetStartBefore(DomNode refNode)
	{
		if (refNode == null)
		{
			throw new ArgumentNullException("refNode");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartBefore_Handle, refNode.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartBefore_Handle, refNode.Handle);
		}
	}

	[Export("surroundContents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SurroundContents(DomNode newParent)
	{
		if (newParent == null)
		{
			throw new ArgumentNullException("newParent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSurroundContents_Handle, newParent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSurroundContents_Handle, newParent.Handle);
		}
	}

	[Export("toString")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string ToString()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToStringHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToStringHandle));
	}
}
