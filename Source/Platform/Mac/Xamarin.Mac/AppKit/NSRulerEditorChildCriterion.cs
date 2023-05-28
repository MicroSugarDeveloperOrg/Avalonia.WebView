using Foundation;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public delegate NSObject NSRulerEditorChildCriterion(NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType);
