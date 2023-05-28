using System;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(Name = "QTCaptureView_Delegate", WrapperType = typeof(QTCaptureViewDelegateWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillDisplayImage", Selector = "view:willDisplayImage:", ReturnType = typeof(CIImage), ParameterType = new Type[]
{
	typeof(QTCaptureView),
	typeof(CIImage)
}, ParameterByRef = new bool[] { false, false })]
public interface IQTCaptureViewDelegate : INativeObject, IDisposable
{
}
