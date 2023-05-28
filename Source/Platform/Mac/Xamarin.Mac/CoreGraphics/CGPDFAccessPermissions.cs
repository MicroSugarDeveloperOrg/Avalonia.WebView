namespace CoreGraphics;

[iOS(11, 0)]
[Mac(10, 13)]
public enum CGPDFAccessPermissions : uint
{
	AllowsLowQualityPrinting = 1u,
	AllowsHighQualityPrinting = 2u,
	AllowsDocumentChanges = 4u,
	AllowsDocumentAssembly = 8u,
	AllowsContentCopying = 0x10u,
	AllowsContentAccessibility = 0x20u,
	AllowsCommenting = 0x40u,
	AllowsFormFieldEntry = 0x80u
}
