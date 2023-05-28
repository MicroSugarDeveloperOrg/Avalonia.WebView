using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

public static class ICButtonType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Copy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Mail;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Print;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Scan;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Transfer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Web;

	[Field("ICButtonTypeCopy", "ImageCaptureCore")]
	public static NSString Copy
	{
		get
		{
			if (_Copy == null)
			{
				_Copy = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICButtonTypeCopy");
			}
			return _Copy;
		}
	}

	[Field("ICButtonTypeMail", "ImageCaptureCore")]
	public static NSString Mail
	{
		get
		{
			if (_Mail == null)
			{
				_Mail = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICButtonTypeMail");
			}
			return _Mail;
		}
	}

	[Field("ICButtonTypePrint", "ImageCaptureCore")]
	public static NSString Print
	{
		get
		{
			if (_Print == null)
			{
				_Print = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICButtonTypePrint");
			}
			return _Print;
		}
	}

	[Field("ICButtonTypeScan", "ImageCaptureCore")]
	public static NSString Scan
	{
		get
		{
			if (_Scan == null)
			{
				_Scan = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICButtonTypeScan");
			}
			return _Scan;
		}
	}

	[Field("ICButtonTypeTransfer", "ImageCaptureCore")]
	public static NSString Transfer
	{
		get
		{
			if (_Transfer == null)
			{
				_Transfer = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICButtonTypeTransfer");
			}
			return _Transfer;
		}
	}

	[Field("ICButtonTypeWeb", "ImageCaptureCore")]
	public static NSString Web
	{
		get
		{
			if (_Web == null)
			{
				_Web = Dlfcn.GetStringConstant(Libraries.ImageCaptureCore.Handle, "ICButtonTypeWeb");
			}
			return _Web;
		}
	}
}
