using System;
using Foundation;

namespace AppKit;

public delegate NSObject NSRulerEditorChildCriterion(NSRuleEditor editor, nint index, NSObject criterion, NSRuleEditorRowType rowType);
