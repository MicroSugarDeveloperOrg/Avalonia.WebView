using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFAnnotationMarkup", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
public class PdfAnnotationMarkup : PdfAnnotation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkupType = "markupType";

	private static readonly IntPtr selMarkupTypeHandle = Selector.GetHandle("markupType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuadrilateralPoints = "quadrilateralPoints";

	private static readonly IntPtr selQuadrilateralPointsHandle = Selector.GetHandle("quadrilateralPoints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkupType_ = "setMarkupType:";

	private static readonly IntPtr selSetMarkupType_Handle = Selector.GetHandle("setMarkupType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQuadrilateralPoints_ = "setQuadrilateralPoints:";

	private static readonly IntPtr selSetQuadrilateralPoints_Handle = Selector.GetHandle("setQuadrilateralPoints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFAnnotationMarkup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakQuadrilateralPoints_var;

	private new CGPoint[] QuadrilateralPoints
	{
		get
		{
			NSArray weakQuadrilateralPoints = WeakQuadrilateralPoints;
			if (weakQuadrilateralPoints == null)
			{
				return null;
			}
			CGPoint[] array = new CGPoint[(ulong)weakQuadrilateralPoints.Count];
			for (uint num = 0u; num < array.Length; num++)
			{
				array[num] = weakQuadrilateralPoints.GetItem<NSValue>(num).CGPointValue;
			}
			return array;
		}
		set
		{
			if (value == null)
			{
				WeakQuadrilateralPoints = null;
				return;
			}
			NSValue[] array = new NSValue[value.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = NSValue.FromCGPoint(value[i]);
			}
			WeakQuadrilateralPoints = NSArray.FromNSObjects(array);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual PdfMarkupType MarkupType
	{
		[Export("markupType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfMarkupType)Messaging.Int64_objc_msgSend(base.Handle, selMarkupTypeHandle);
			}
			return (PdfMarkupType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMarkupTypeHandle);
		}
		[Export("setMarkupType:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMarkupType_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMarkupType_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray? WeakQuadrilateralPoints
	{
		[Export("quadrilateralPoints", ArgumentSemantic.Assign)]
		get
		{
			NSArray nSArray = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQuadrilateralPointsHandle)) : Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selQuadrilateralPointsHandle)));
			MarkDirty();
			__mt_WeakQuadrilateralPoints_var = nSArray;
			return nSArray;
		}
		[Export("setQuadrilateralPoints:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetQuadrilateralPoints_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetQuadrilateralPoints_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakQuadrilateralPoints_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfAnnotationMarkup()
		: base(NSObjectFlag.Empty)
	{
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PdfAnnotationMarkup(NSCoder coder)
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
	protected PdfAnnotationMarkup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfAnnotationMarkup(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakQuadrilateralPoints_var = null;
		}
	}
}
