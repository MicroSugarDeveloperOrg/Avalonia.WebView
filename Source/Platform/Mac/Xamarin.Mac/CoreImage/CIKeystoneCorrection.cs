using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public abstract class CIKeystoneCorrection : CIFilter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float FocalLength
	{
		get
		{
			return GetFloat("inputFocalLength");
		}
		set
		{
			SetFloat("inputFocalLength", value);
		}
	}

	[Obsolete("Use 'InputTopRight' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? TopRight
	{
		get
		{
			return ValueForKey("inputTopRight") as CIVector;
		}
		set
		{
			SetValue("inputTopRight", value);
		}
	}

	[Obsolete("Use 'InputBottomRight' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? BottomRight
	{
		get
		{
			return ValueForKey("inputBottomRight") as CIVector;
		}
		set
		{
			SetValue("inputBottomRight", value);
		}
	}

	[Obsolete("Use 'InputTopLeft' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? TopLeft
	{
		get
		{
			return ValueForKey("inputTopLeft") as CIVector;
		}
		set
		{
			SetValue("inputTopLeft", value);
		}
	}

	[Obsolete("Use 'InputBottomLeft' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIVector? BottomLeft
	{
		get
		{
			return ValueForKey("inputBottomLeft") as CIVector;
		}
		set
		{
			SetValue("inputBottomLeft", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputTopRight
	{
		get
		{
			return GetPoint("inputTopRight");
		}
		set
		{
			SetValue("inputTopRight", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputBottomRight
	{
		get
		{
			return GetPoint("inputBottomRight");
		}
		set
		{
			SetValue("inputBottomRight", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputTopLeft
	{
		get
		{
			return GetPoint("inputTopLeft");
		}
		set
		{
			SetValue("inputTopLeft", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint InputBottomLeft
	{
		get
		{
			return GetPoint("inputBottomLeft");
		}
		set
		{
			SetValue("inputBottomLeft", value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIKeystoneCorrection(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIKeystoneCorrection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIKeystoneCorrection(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected CIKeystoneCorrection(string name)
		: base(CIFilter.CreateFilter(name))
	{
	}
}
