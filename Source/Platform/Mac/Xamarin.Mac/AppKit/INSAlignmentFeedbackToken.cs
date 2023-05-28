using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSAlignmentFeedbackToken", WrapperType = typeof(NSAlignmentFeedbackTokenWrapper))]
public interface INSAlignmentFeedbackToken : INativeObject, IDisposable
{
}
