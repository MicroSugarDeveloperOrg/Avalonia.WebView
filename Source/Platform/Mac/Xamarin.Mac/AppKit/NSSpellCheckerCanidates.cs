using System;
using Foundation;

namespace AppKit;

public class NSSpellCheckerCanidates
{
	public nint Arg1 { get; set; }

	public NSTextCheckingResult[] Arg2 { get; set; }

	public NSSpellCheckerCanidates(nint arg1, NSTextCheckingResult[] arg2)
	{
		Arg1 = arg1;
		Arg2 = arg2;
	}
}
