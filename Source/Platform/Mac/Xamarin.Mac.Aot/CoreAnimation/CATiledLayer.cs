using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CATiledLayer", true)]
public class CATiledLayer : CALayer
{
	private static readonly IntPtr selFadeDurationHandle = Selector.GetHandle("fadeDuration");

	private static readonly IntPtr selLevelsOfDetailHandle = Selector.GetHandle("levelsOfDetail");

	private static readonly IntPtr selSetLevelsOfDetail_Handle = Selector.GetHandle("setLevelsOfDetail:");

	private static readonly IntPtr selLevelsOfDetailBiasHandle = Selector.GetHandle("levelsOfDetailBias");

	private static readonly IntPtr selSetLevelsOfDetailBias_Handle = Selector.GetHandle("setLevelsOfDetailBias:");

	private static readonly IntPtr selTileSizeHandle = Selector.GetHandle("tileSize");

	private static readonly IntPtr selSetTileSize_Handle = Selector.GetHandle("setTileSize:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr class_ptr = Class.GetHandle("CATiledLayer");

	public override IntPtr ClassHandle => class_ptr;

	public static double FadeDuration
	{
		[Export("fadeDuration")]
		get
		{
			return Messaging.Double_objc_msgSend(class_ptr, selFadeDurationHandle);
		}
	}

	public virtual int LevelsOfDetail
	{
		[Export("levelsOfDetail")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLevelsOfDetailHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLevelsOfDetailHandle);
		}
		[Export("setLevelsOfDetail:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLevelsOfDetail_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLevelsOfDetail_Handle, value);
			}
		}
	}

	public virtual int LevelsOfDetailBias
	{
		[Export("levelsOfDetailBias")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLevelsOfDetailBiasHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLevelsOfDetailBiasHandle);
		}
		[Export("setLevelsOfDetailBias:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLevelsOfDetailBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLevelsOfDetailBias_Handle, value);
			}
		}
	}

	public virtual CGSize TileSize
	{
		[Export("tileSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selTileSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selTileSizeHandle);
		}
		[Export("setTileSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetTileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetTileSize_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CATiledLayer()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CATiledLayer(NSCoder coder)
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
	public CATiledLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CATiledLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}
