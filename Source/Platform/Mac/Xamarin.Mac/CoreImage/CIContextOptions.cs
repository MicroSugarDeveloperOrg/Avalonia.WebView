using CoreFoundation;
using CoreGraphics;
using Foundation;

namespace CoreImage;

public class CIContextOptions
{
	public CGColorSpace OutputColorSpace { get; set; }

	public CGColorSpace WorkingColorSpace { get; set; }

	public bool UseSoftwareRenderer { get; set; }

	internal NSDictionary ToDictionary()
	{
		if (OutputColorSpace == null && WorkingColorSpace == null && !UseSoftwareRenderer)
		{
			return null;
		}
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (OutputColorSpace != null)
		{
			nSMutableDictionary.LowlevelSetObject(OutputColorSpace.Handle, CIContext.OutputColorSpace.Handle);
		}
		if (WorkingColorSpace != null)
		{
			nSMutableDictionary.LowlevelSetObject(WorkingColorSpace.Handle, CIContext.WorkingColorSpace.Handle);
		}
		if (UseSoftwareRenderer)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, CIContext.UseSoftwareRenderer.Handle);
		}
		return nSMutableDictionary;
	}
}
