using System;

namespace AppKit;

public struct NSEdgeInsets
{
	public nfloat Top;

	public nfloat Left;

	public nfloat Bottom;

	public nfloat Right;

	public NSEdgeInsets(nfloat top, nfloat left, nfloat bottom, nfloat right)
	{
		Top = top;
		Left = left;
		Bottom = bottom;
		Right = right;
	}
}
