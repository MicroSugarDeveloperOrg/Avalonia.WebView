using System;
using System.ComponentModel;
using System.Drawing;
using AppKit;
using CoreGraphics;
using CoreVideo;
using Foundation;

namespace OpenGL;

public class MonoMacGameView : NSView, IGameWindow, INativeWindow, IDisposable
{
	private bool disposed;

	private NSOpenGLContext openGLContext;

	private NSOpenGLPixelFormat pixelFormat;

	private CVDisplayLink displayLink;

	private NSObject notificationProxy;

	private NSTimer animationTimer;

	private bool animating;

	private bool displayLinkSupported;

	private WindowState windowState;

	private DateTime prevUpdateTime;

	private DateTime prevRenderTime;

	private FrameEventArgs updateEventArgs = new FrameEventArgs();

	private FrameEventArgs renderEventArgs = new FrameEventArgs();

	private Size size;

	public NSOpenGLContext OpenGLContext => openGLContext;

	public NSOpenGLPixelFormat PixelFormat => pixelFormat;

	public virtual string Title
	{
		get
		{
			AssertValid();
			if (Window != null)
			{
				return Window.Title;
			}
			throw new NotSupportedException();
		}
		set
		{
			AssertValid();
			if (Window != null)
			{
				Window.Title = value;
				return;
			}
			throw new NotSupportedException();
		}
	}

	bool INativeWindow.Focused
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual bool Visible
	{
		get
		{
			AssertValid();
			return !base.Hidden;
		}
		set
		{
			AssertValid();
			if (base.Hidden != !value)
			{
				base.Hidden = !value;
				OnVisibleChanged(EventArgs.Empty);
			}
		}
	}

	bool INativeWindow.Exists
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public virtual WindowState WindowState
	{
		get
		{
			AssertValid();
			return windowState;
		}
		set
		{
			AssertValid();
			if (windowState != value)
			{
				windowState = value;
				OnWindowStateChanged(EventArgs.Empty);
			}
		}
	}

	public virtual WindowBorder WindowBorder
	{
		get
		{
			AssertValid();
			return WindowBorder.Hidden;
		}
		set
		{
		}
	}

	Rectangle INativeWindow.Bounds
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	Point INativeWindow.Location
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public Size Size
	{
		get
		{
			AssertValid();
			return size;
		}
		set
		{
			AssertValid();
			if (size != value)
			{
				size = value;
				openGLContext.CGLContext.Lock();
				OnResize(EventArgs.Empty);
				openGLContext.Update();
				openGLContext.CGLContext.Unlock();
			}
		}
	}

	int INativeWindow.X
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	int INativeWindow.Y
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	int INativeWindow.Width
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	int INativeWindow.Height
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	Rectangle INativeWindow.ClientRectangle
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	Size INativeWindow.ClientSize
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	private bool SwapInterval { get; set; }

	private bool DisplaylinkSupported
	{
		get
		{
			return displayLinkSupported;
		}
		set
		{
			displayLinkSupported = value;
		}
	}

	event EventHandler<EventArgs> INativeWindow.Move
	{
		add
		{
			throw new NotSupportedException();
		}
		remove
		{
			throw new NotSupportedException();
		}
	}

	public event EventHandler<EventArgs> Resize;

	event EventHandler<CancelEventArgs> INativeWindow.Closing
	{
		add
		{
			throw new NotSupportedException();
		}
		remove
		{
			throw new NotSupportedException();
		}
	}

	public event EventHandler<EventArgs> Closed;

	public event EventHandler<EventArgs> Disposed;

	public event EventHandler<EventArgs> TitleChanged;

	public event EventHandler<EventArgs> VisibleChanged;

	event EventHandler<EventArgs> INativeWindow.FocusedChanged
	{
		add
		{
			throw new NotSupportedException();
		}
		remove
		{
			throw new NotSupportedException();
		}
	}

	event EventHandler<EventArgs> INativeWindow.WindowBorderChanged
	{
		add
		{
			throw new NotSupportedException();
		}
		remove
		{
			throw new NotSupportedException();
		}
	}

	public event EventHandler<EventArgs> WindowStateChanged;

	event EventHandler<EventArgs> INativeWindow.IconChanged
	{
		add
		{
			throw new NotSupportedException();
		}
		remove
		{
			throw new NotSupportedException();
		}
	}

	public event EventHandler<EventArgs> Load;

	public event EventHandler<EventArgs> Unload;

	public event EventHandler<FrameEventArgs> UpdateFrame;

	public event EventHandler<FrameEventArgs> RenderFrame;

	[Export("initWithFrame:")]
	public MonoMacGameView(CGRect frame)
		: this(frame, null)
	{
	}

	public MonoMacGameView(CGRect frame, NSOpenGLContext context)
		: base(frame)
	{
		object[] attribs = new object[7]
		{
			NSOpenGLPixelFormatAttribute.Accelerated,
			NSOpenGLPixelFormatAttribute.NoRecovery,
			NSOpenGLPixelFormatAttribute.DoubleBuffer,
			NSOpenGLPixelFormatAttribute.ColorSize,
			24,
			NSOpenGLPixelFormatAttribute.DepthSize,
			16
		};
		pixelFormat = new NSOpenGLPixelFormat(attribs);
		if (pixelFormat == null)
		{
			Console.WriteLine("No OpenGL pixel format");
		}
		openGLContext = new NSOpenGLContext(pixelFormat, context);
		openGLContext.MakeCurrentContext();
		SwapInterval = true;
		DisplaylinkSupported = true;
		notificationProxy = NSNotificationCenter.DefaultCenter.AddObserver(NSView.GlobalFrameChangedNotification, HandleReshape);
	}

	[Preserve(Conditional = true)]
	public override void DrawRect(CGRect dirtyRect)
	{
		if (!animating)
		{
			return;
		}
		if (displayLinkSupported)
		{
			if (displayLink.IsRunning)
			{
				RenderScene();
			}
		}
		else
		{
			RenderScene();
		}
	}

	[Preserve(Conditional = true)]
	public override void LockFocus()
	{
		base.LockFocus();
		if (openGLContext.View != this)
		{
			openGLContext.View = this;
		}
	}

	private NSViewController GetViewController()
	{
		for (NSResponder nSResponder = this; nSResponder != null; nSResponder = nSResponder.NextResponder)
		{
			if (nSResponder is NSViewController result)
			{
				return result;
			}
		}
		return null;
	}

	protected void UpdateView()
	{
		Size = new Size((int)Bounds.Width, (int)Bounds.Height);
	}

	private void HandleReshape(NSNotification note)
	{
		UpdateView();
	}

	private void StartAnimation(double updatesPerSecond)
	{
		if (!animating)
		{
			if (displayLinkSupported)
			{
				if (displayLink != null && !displayLink.IsRunning)
				{
					displayLink.Start();
				}
			}
			else
			{
				TimeSpan when = new TimeSpan((long)(10000000.0 / updatesPerSecond + 0.5));
				if (SwapInterval)
				{
					animationTimer = NSTimer.CreateRepeatingScheduledTimer(when, delegate
					{
						NeedsDisplay = true;
					});
				}
				else
				{
					animationTimer = NSTimer.CreateRepeatingScheduledTimer(when, delegate
					{
						RenderScene();
					});
				}
				NSRunLoop.Current.AddTimer(animationTimer, NSRunLoopMode.Default);
				NSRunLoop.Current.AddTimer(animationTimer, NSRunLoopMode.EventTracking);
			}
		}
		animating = true;
	}

	public void Stop()
	{
		if (animating)
		{
			if (displayLinkSupported)
			{
				if (displayLink != null && displayLink.IsRunning)
				{
					displayLink.Stop();
				}
			}
			else
			{
				animationTimer.Invalidate();
				animationTimer = null;
			}
		}
		animating = false;
	}

	private void DeAllocate()
	{
		Stop();
		displayLink = null;
		NSNotificationCenter.DefaultCenter.RemoveObserver(notificationProxy);
	}

	private void AssertValid()
	{
		if (disposed)
		{
			throw new ObjectDisposedException("");
		}
	}

	private void AssertContext()
	{
		if (OpenGLContext == null)
		{
			throw new InvalidOperationException("Operation requires an OpenGLContext, which hasn't been created yet.");
		}
	}

	protected virtual void OnTitleChanged(EventArgs e)
	{
		this.TitleChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnVisibleChanged(EventArgs e)
	{
		this.VisibleChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnWindowStateChanged(EventArgs e)
	{
		this.WindowStateChanged?.Invoke(this, EventArgs.Empty);
	}

	protected virtual void OnResize(EventArgs e)
	{
		this.Resize?.Invoke(this, e);
	}

	public virtual void Close()
	{
		AssertValid();
		OnClosed(EventArgs.Empty);
	}

	protected virtual void OnClosed(EventArgs e)
	{
		this.Closed?.Invoke(this, e);
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				DeAllocate();
			}
			base.Dispose(disposing);
			disposed = true;
			if (disposing)
			{
				OnDisposed(EventArgs.Empty);
			}
		}
	}

	protected virtual void OnDisposed(EventArgs e)
	{
		this.Disposed?.Invoke(this, e);
	}

	void INativeWindow.ProcessEvents()
	{
		throw new NotSupportedException();
	}

	Point INativeWindow.PointToClient(Point point)
	{
		return point;
	}

	Point INativeWindow.PointToScreen(Point point)
	{
		return point;
	}

	public virtual void MakeCurrent()
	{
		AssertValid();
		AssertContext();
		OpenGLContext.MakeCurrentContext();
	}

	public virtual void SwapBuffers()
	{
		AssertValid();
		AssertContext();
		OpenGLContext.FlushBuffer();
	}

	public void Run()
	{
		AssertValid();
		OnLoad(EventArgs.Empty);
		openGLContext.SwapInterval = SwapInterval;
		if (displayLinkSupported)
		{
			SetupDisplayLink();
		}
		StartAnimation(0.0);
	}

	public void Run(double updatesPerSecond)
	{
		AssertValid();
		if (updatesPerSecond == 0.0)
		{
			Run();
			return;
		}
		OnLoad(EventArgs.Empty);
		SwapInterval = false;
		DisplaylinkSupported = false;
		openGLContext.SwapInterval = SwapInterval;
		if (displayLinkSupported)
		{
			SetupDisplayLink();
		}
		StartAnimation(updatesPerSecond);
	}

	private void RenderScene()
	{
		openGLContext.CGLContext.Lock();
		openGLContext.MakeCurrentContext();
		DateTime now = DateTime.Now;
		if (prevUpdateTime.Ticks == 0L)
		{
			prevUpdateTime = now;
		}
		double num = (now - prevUpdateTime).TotalSeconds;
		if (num <= 0.0)
		{
			num = double.Epsilon;
		}
		updateEventArgs.Time = num;
		OnUpdateFrame(updateEventArgs);
		prevUpdateTime = now;
		DateTime now2 = DateTime.Now;
		if (prevRenderTime.Ticks == 0L)
		{
			prevRenderTime = now2;
		}
		num = (now2 - prevRenderTime).TotalSeconds;
		if (num <= 0.0)
		{
			num = double.Epsilon;
		}
		renderEventArgs.Time = num;
		OnRenderFrame(renderEventArgs);
		prevRenderTime = now2;
		openGLContext.FlushBuffer();
		openGLContext.CGLContext.Unlock();
	}

	private void SetupDisplayLink()
	{
		if (displayLink == null)
		{
			displayLink = new CVDisplayLink();
			displayLink.SetOutputCallback(MyDisplayLinkOutputCallback);
			CGLContext cGLContext = openGLContext.CGLContext;
			CGLPixelFormat cGLPixelFormat = PixelFormat.CGLPixelFormat;
			displayLink.SetCurrentDisplay(cGLContext, cGLPixelFormat);
		}
	}

	private CVReturn MyDisplayLinkOutputCallback(CVDisplayLink displayLink, ref CVTimeStamp inNow, ref CVTimeStamp inOutputTime, CVOptionFlags flagsIn, ref CVOptionFlags flagsOut)
	{
		CVReturn cVReturn = CVReturn.First;
		using (new NSAutoreleasePool())
		{
			BeginInvokeOnMainThread(RenderScene);
			return CVReturn.Success;
		}
	}

	protected virtual void OnLoad(EventArgs e)
	{
		this.Load?.Invoke(this, e);
	}

	protected virtual void OnUnload(EventArgs e)
	{
		EventHandler<EventArgs> unload = this.Unload;
		Stop();
		unload?.Invoke(this, e);
	}

	protected virtual void OnUpdateFrame(FrameEventArgs e)
	{
		this.UpdateFrame?.Invoke(this, e);
	}

	protected virtual void OnRenderFrame(FrameEventArgs e)
	{
		this.RenderFrame?.Invoke(this, e);
	}
}
