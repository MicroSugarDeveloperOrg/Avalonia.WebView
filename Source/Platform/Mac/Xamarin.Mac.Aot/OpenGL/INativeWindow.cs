using System;
using System.ComponentModel;
using System.Drawing;

namespace OpenGL;

public interface INativeWindow : IDisposable
{
	string Title { get; set; }

	bool Focused { get; }

	bool Visible { get; set; }

	bool Exists { get; }

	WindowState WindowState { get; set; }

	WindowBorder WindowBorder { get; set; }

	Rectangle Bounds { get; set; }

	Point Location { get; set; }

	Size Size { get; set; }

	int X { get; set; }

	int Y { get; set; }

	int Width { get; set; }

	int Height { get; set; }

	Rectangle ClientRectangle { get; set; }

	Size ClientSize { get; set; }

	event EventHandler<EventArgs> Move;

	event EventHandler<EventArgs> Resize;

	event EventHandler<CancelEventArgs> Closing;

	event EventHandler<EventArgs> Closed;

	event EventHandler<EventArgs> Disposed;

	event EventHandler<EventArgs> IconChanged;

	event EventHandler<EventArgs> TitleChanged;

	event EventHandler<EventArgs> VisibleChanged;

	event EventHandler<EventArgs> FocusedChanged;

	event EventHandler<EventArgs> WindowBorderChanged;

	event EventHandler<EventArgs> WindowStateChanged;

	void Close();

	void ProcessEvents();

	Point PointToClient(Point point);

	Point PointToScreen(Point point);
}
