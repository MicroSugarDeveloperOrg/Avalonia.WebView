using System;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(Name = "QTMovieViewDelegate", WrapperType = typeof(QTMovieViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ViewWillDisplayImage", Selector = "view:willDisplayImage:", ReturnType = typeof(CIImage), ParameterType = new Type[]
{
	typeof(QTMovieView),
	typeof(CIImage)
}, ParameterByRef = new bool[] { false, false })]
public interface IQTMovieViewDelegate : INativeObject, IDisposable
{
}
