using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCommandBuffer", WrapperType = typeof(MTLCommandBufferWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Enqueue", Selector = "enqueue")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Commit", Selector = "commit")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddScheduledHandler", Selector = "addScheduledHandler:", ParameterType = new Type[] { typeof(Action<IMTLCommandBuffer>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V64) })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitUntilScheduled", Selector = "waitUntilScheduled")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddCompletedHandler", Selector = "addCompletedHandler:", ParameterType = new Type[] { typeof(Action<IMTLCommandBuffer>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V64) })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitUntilCompleted", Selector = "waitUntilCompleted")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ComputeCommandEncoderDispatch", Selector = "computeCommandEncoderWithDispatchType:", ReturnType = typeof(IMTLComputeCommandEncoder), ParameterType = new Type[] { typeof(MTLDispatchType) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EncodeWait", Selector = "encodeWaitForEvent:value:", ParameterType = new Type[]
{
	typeof(IMTLEvent),
	typeof(ulong)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EncodeSignal", Selector = "encodeSignalEvent:value:", ParameterType = new Type[]
{
	typeof(IMTLEvent),
	typeof(ulong)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateParallelRenderCommandEncoder", Selector = "parallelRenderCommandEncoderWithDescriptor:", ReturnType = typeof(IMTLParallelRenderCommandEncoder), ParameterType = new Type[] { typeof(MTLRenderPassDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentDrawable", Selector = "presentDrawable:", ParameterType = new Type[] { typeof(IMTLDrawable) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentDrawable", Selector = "presentDrawable:atTime:", ParameterType = new Type[]
{
	typeof(IMTLDrawable),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentDrawableAfter", Selector = "presentDrawable:afterMinimumDuration:", ParameterType = new Type[]
{
	typeof(IMTLDrawable),
	typeof(double)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderCommandEncoder", Selector = "renderCommandEncoderWithDescriptor:", ReturnType = typeof(IMTLRenderCommandEncoder), ParameterType = new Type[] { typeof(MTLRenderPassDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PushDebugGroup", Selector = "pushDebugGroup:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PopDebugGroup", Selector = "popDebugGroup")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CommandQueue", Selector = "commandQueue", PropertyType = typeof(IMTLCommandQueue), GetterSelector = "commandQueue", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RetainedReferences", Selector = "retainedReferences", PropertyType = typeof(bool), GetterSelector = "retainedReferences", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Status", Selector = "status", PropertyType = typeof(MTLCommandBufferStatus), GetterSelector = "status", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Error", Selector = "error", PropertyType = typeof(NSError), GetterSelector = "error", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BlitCommandEncoder", Selector = "blitCommandEncoder", PropertyType = typeof(IMTLBlitCommandEncoder), GetterSelector = "blitCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ComputeCommandEncoder", Selector = "computeCommandEncoder", PropertyType = typeof(IMTLComputeCommandEncoder), GetterSelector = "computeCommandEncoder", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "KernelStartTime", Selector = "kernelStartTime", PropertyType = typeof(double), GetterSelector = "kernelStartTime", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "KernelEndTime", Selector = "kernelEndTime", PropertyType = typeof(double), GetterSelector = "kernelEndTime", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "GpuStartTime", Selector = "GPUStartTime", PropertyType = typeof(double), GetterSelector = "GPUStartTime", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "GpuEndTime", Selector = "GPUEndTime", PropertyType = typeof(double), GetterSelector = "GPUEndTime", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLCommandBuffer : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	IMTLCommandQueue CommandQueue
	{
		[Export("commandQueue")]
		get;
	}

	[Preserve(Conditional = true)]
	bool RetainedReferences
	{
		[Export("retainedReferences")]
		get;
	}

	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
		[Export("setLabel:")]
		set;
	}

	[Preserve(Conditional = true)]
	MTLCommandBufferStatus Status
	{
		[Export("status")]
		get;
	}

	[Preserve(Conditional = true)]
	NSError Error
	{
		[Export("error")]
		get;
	}

	[Preserve(Conditional = true)]
	IMTLBlitCommandEncoder BlitCommandEncoder
	{
		[Export("blitCommandEncoder")]
		get;
	}

	[Preserve(Conditional = true)]
	IMTLComputeCommandEncoder ComputeCommandEncoder
	{
		[Export("computeCommandEncoder")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("enqueue")]
	[Preserve(Conditional = true)]
	void Enqueue();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("commit")]
	[Preserve(Conditional = true)]
	void Commit();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("addScheduledHandler:")]
	[Preserve(Conditional = true)]
	void AddScheduledHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V64))] Action<IMTLCommandBuffer> block);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("waitUntilScheduled")]
	[Preserve(Conditional = true)]
	void WaitUntilScheduled();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("addCompletedHandler:")]
	[Preserve(Conditional = true)]
	void AddCompletedHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V64))] Action<IMTLCommandBuffer> block);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("waitUntilCompleted")]
	[Preserve(Conditional = true)]
	void WaitUntilCompleted();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("parallelRenderCommandEncoderWithDescriptor:")]
	[Preserve(Conditional = true)]
	IMTLParallelRenderCommandEncoder? CreateParallelRenderCommandEncoder(MTLRenderPassDescriptor renderPassDescriptor);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("presentDrawable:")]
	[Preserve(Conditional = true)]
	void PresentDrawable(IMTLDrawable drawable);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("presentDrawable:atTime:")]
	[Preserve(Conditional = true)]
	void PresentDrawable(IMTLDrawable drawable, double presentationTime);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("renderCommandEncoderWithDescriptor:")]
	[Preserve(Conditional = true)]
	IMTLRenderCommandEncoder CreateRenderCommandEncoder(MTLRenderPassDescriptor renderPassDescriptor);
}
