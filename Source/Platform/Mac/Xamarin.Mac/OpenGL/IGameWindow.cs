using System;

namespace OpenGL;

public interface IGameWindow : INativeWindow, IDisposable
{
	event EventHandler<EventArgs> Load;

	event EventHandler<EventArgs> Unload;

	event EventHandler<FrameEventArgs> UpdateFrame;

	event EventHandler<FrameEventArgs> RenderFrame;

	void Run();

	void Run(double updateRate);

	void MakeCurrent();

	void SwapBuffers();
}
