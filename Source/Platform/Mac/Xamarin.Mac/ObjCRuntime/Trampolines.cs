using System;
using System.Runtime.InteropServices;
using Accounts;
using AppKit;
using AudioToolbox;
using AudioUnit;
using AuthenticationServices;
using AVFoundation;
using AVKit;
using CloudKit;
using Contacts;
using CoreData;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreMedia;
using CoreMidi;
using CoreML;
using CoreMotion;
using CoreSpotlight;
using DeviceCheck;
using EventKit;
using FinderSync;
using Foundation;
using GameController;
using GameKit;
using GameplayKit;
using GLKit;
using ImageIO;
using Intents;
using iTunesLibrary;
using JavaScriptCore;
using LinkPresentation;
using LocalAuthentication;
using MapKit;
using MediaPlayer;
using Metal;
using MetalKit;
using MetalPerformanceShaders;
using ModelIO;
using MultipeerConnectivity;
using NaturalLanguage;
using NetworkExtension;
using NotificationCenter;
using OpenTK;
using Photos;
using PhotosUI;
using QuickLookThumbnailing;
using SafariServices;
using SceneKit;
using Security;
using SoundAnalysis;
using Speech;
using SpriteKit;
using StoreKit;
using UserNotifications;
using Vision;
using WebKit;

namespace ObjCRuntime;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
internal static class Trampolines
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAssetImageGeneratorCompletionHandler))]
	internal delegate void DAVAssetImageGeneratorCompletionHandler(IntPtr block, CMTime requestedTime, IntPtr imageRef, CMTime actualTime, nint result, IntPtr error);

	internal static class SDAVAssetImageGeneratorCompletionHandler
	{
		internal static readonly DAVAssetImageGeneratorCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAssetImageGeneratorCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, CMTime requestedTime, IntPtr imageRef, CMTime actualTime, nint result, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AVAssetImageGeneratorCompletionHandler)ptr->Target)?.Invoke(requestedTime, imageRef, actualTime, (AVAssetImageGeneratorResult)(long)result, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDAVAssetImageGeneratorCompletionHandler : TrampolineBlockBase
	{
		private DAVAssetImageGeneratorCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAssetImageGeneratorCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAssetImageGeneratorCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAssetImageGeneratorCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAssetImageGeneratorCompletionHandler aVAssetImageGeneratorCompletionHandler = (AVAssetImageGeneratorCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAssetImageGeneratorCompletionHandler ?? new AVAssetImageGeneratorCompletionHandler(new NIDAVAssetImageGeneratorCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CMTime requestedTime, IntPtr imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, NSError error)
		{
			invoker(base.BlockPointer, requestedTime, imageRef, actualTime, (nint)(long)result, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioConverterInputHandler))]
	internal delegate IntPtr DAVAudioConverterInputHandler(IntPtr block, uint inNumberOfPackets, out AVAudioConverterInputStatus outStatus);

	internal static class SDAVAudioConverterInputHandler
	{
		internal static readonly DAVAudioConverterInputHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioConverterInputHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, uint inNumberOfPackets, out AVAudioConverterInputStatus outStatus)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AVAudioConverterInputHandler aVAudioConverterInputHandler = (AVAudioConverterInputHandler)ptr->Target;
			return aVAudioConverterInputHandler(inNumberOfPackets, out outStatus)?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDAVAudioConverterInputHandler : TrampolineBlockBase
	{
		private DAVAudioConverterInputHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioConverterInputHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioConverterInputHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioConverterInputHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioConverterInputHandler aVAudioConverterInputHandler = (AVAudioConverterInputHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioConverterInputHandler ?? new AVAudioConverterInputHandler(new NIDAVAudioConverterInputHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private AVAudioBuffer Invoke(uint inNumberOfPackets, out AVAudioConverterInputStatus outStatus)
		{
			return Runtime.GetNSObject<AVAudioBuffer>(invoker(base.BlockPointer, inNumberOfPackets, out outStatus));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioEngineManualRenderingBlock))]
	internal delegate IntPtr DAVAudioEngineManualRenderingBlock(IntPtr block, uint numberOfFrames, IntPtr outBuffer, ref int outError);

	internal static class SDAVAudioEngineManualRenderingBlock
	{
		internal static readonly DAVAudioEngineManualRenderingBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioEngineManualRenderingBlock))]
		private unsafe static IntPtr Invoke(IntPtr block, uint numberOfFrames, IntPtr outBuffer, ref int outError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AVAudioEngineManualRenderingBlock aVAudioEngineManualRenderingBlock = (AVAudioEngineManualRenderingBlock)ptr->Target;
			AVAudioEngineManualRenderingStatus aVAudioEngineManualRenderingStatus = aVAudioEngineManualRenderingBlock(numberOfFrames, new AudioBuffers(outBuffer), ref outError);
			return (IntPtr)(long)aVAudioEngineManualRenderingStatus;
		}
	}

	internal sealed class NIDAVAudioEngineManualRenderingBlock : TrampolineBlockBase
	{
		private DAVAudioEngineManualRenderingBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioEngineManualRenderingBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioEngineManualRenderingBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioEngineManualRenderingBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioEngineManualRenderingBlock aVAudioEngineManualRenderingBlock = (AVAudioEngineManualRenderingBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioEngineManualRenderingBlock ?? new AVAudioEngineManualRenderingBlock(new NIDAVAudioEngineManualRenderingBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private AVAudioEngineManualRenderingStatus Invoke(uint numberOfFrames, AudioBuffers outBuffer, ref int outError)
		{
			return (AVAudioEngineManualRenderingStatus)(long)invoker(base.BlockPointer, numberOfFrames, outBuffer?.Handle ?? IntPtr.Zero, ref outError);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioIONodeInputBlock))]
	internal delegate AudioBuffers DAVAudioIONodeInputBlock(IntPtr block, uint frameCount);

	internal static class SDAVAudioIONodeInputBlock
	{
		internal static readonly DAVAudioIONodeInputBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioIONodeInputBlock))]
		private unsafe static AudioBuffers Invoke(IntPtr block, uint frameCount)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AVAudioIONodeInputBlock aVAudioIONodeInputBlock = (AVAudioIONodeInputBlock)ptr->Target;
			return aVAudioIONodeInputBlock(frameCount);
		}
	}

	internal sealed class NIDAVAudioIONodeInputBlock : TrampolineBlockBase
	{
		private DAVAudioIONodeInputBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioIONodeInputBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioIONodeInputBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioIONodeInputBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioIONodeInputBlock aVAudioIONodeInputBlock = (AVAudioIONodeInputBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioIONodeInputBlock ?? new AVAudioIONodeInputBlock(new NIDAVAudioIONodeInputBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private AudioBuffers Invoke(uint frameCount)
		{
			return invoker(base.BlockPointer, frameCount);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioNodeTapBlock))]
	internal delegate void DAVAudioNodeTapBlock(IntPtr block, IntPtr buffer, IntPtr when);

	internal static class SDAVAudioNodeTapBlock
	{
		internal static readonly DAVAudioNodeTapBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioNodeTapBlock))]
		private unsafe static void Invoke(IntPtr block, IntPtr buffer, IntPtr when)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AVAudioNodeTapBlock)ptr->Target)?.Invoke(Runtime.GetNSObject<AVAudioPcmBuffer>(buffer), Runtime.GetNSObject<AVAudioTime>(when));
		}
	}

	internal sealed class NIDAVAudioNodeTapBlock : TrampolineBlockBase
	{
		private DAVAudioNodeTapBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioNodeTapBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioNodeTapBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioNodeTapBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioNodeTapBlock aVAudioNodeTapBlock = (AVAudioNodeTapBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioNodeTapBlock ?? new AVAudioNodeTapBlock(new NIDAVAudioNodeTapBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAudioPcmBuffer buffer, AVAudioTime when)
		{
			invoker(base.BlockPointer, buffer?.Handle ?? IntPtr.Zero, when?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioSinkNodeReceiverHandler))]
	internal delegate int DAVAudioSinkNodeReceiverHandler(IntPtr block, AudioTimeStamp timestamp, uint frameCount, ref IntPtr inputData);

	internal static class SDAVAudioSinkNodeReceiverHandler
	{
		internal static readonly DAVAudioSinkNodeReceiverHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioSinkNodeReceiverHandler))]
		private unsafe static int Invoke(IntPtr block, AudioTimeStamp timestamp, uint frameCount, ref IntPtr inputData)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AVAudioSinkNodeReceiverHandler aVAudioSinkNodeReceiverHandler = (AVAudioSinkNodeReceiverHandler)ptr->Target;
			AudioBuffers inputData2 = Runtime.GetINativeObject<AudioBuffers>(inputData, owns: false);
			int result = aVAudioSinkNodeReceiverHandler(timestamp, frameCount, ref inputData2);
			inputData = inputData2?.Handle ?? IntPtr.Zero;
			return result;
		}
	}

	internal sealed class NIDAVAudioSinkNodeReceiverHandler : TrampolineBlockBase
	{
		private DAVAudioSinkNodeReceiverHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioSinkNodeReceiverHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioSinkNodeReceiverHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioSinkNodeReceiverHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioSinkNodeReceiverHandler aVAudioSinkNodeReceiverHandler = (AVAudioSinkNodeReceiverHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioSinkNodeReceiverHandler ?? new AVAudioSinkNodeReceiverHandler(new NIDAVAudioSinkNodeReceiverHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private int Invoke(AudioTimeStamp timestamp, uint frameCount, ref AudioBuffers inputData)
		{
			IntPtr inputData2 = ((inputData == null) ? IntPtr.Zero : inputData.Handle);
			int result = invoker(base.BlockPointer, timestamp, frameCount, ref inputData2);
			if (inputData2 != ((inputData == null) ? IntPtr.Zero : inputData.Handle))
			{
				inputData = Runtime.GetINativeObject<AudioBuffers>(inputData2, forced_type: false, owns: false);
			}
			return result;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioSourceNodeRenderHandler))]
	internal delegate int DAVAudioSourceNodeRenderHandler(IntPtr block, bool isSilence, AudioTimeStamp timestamp, uint frameCunt, ref IntPtr outputData);

	internal static class SDAVAudioSourceNodeRenderHandler
	{
		internal static readonly DAVAudioSourceNodeRenderHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioSourceNodeRenderHandler))]
		private unsafe static int Invoke(IntPtr block, bool isSilence, AudioTimeStamp timestamp, uint frameCunt, ref IntPtr outputData)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AVAudioSourceNodeRenderHandler aVAudioSourceNodeRenderHandler = (AVAudioSourceNodeRenderHandler)ptr->Target;
			AudioBuffers outputData2 = Runtime.GetINativeObject<AudioBuffers>(outputData, owns: false);
			int result = aVAudioSourceNodeRenderHandler(isSilence, timestamp, frameCunt, ref outputData2);
			outputData = outputData2?.Handle ?? IntPtr.Zero;
			return result;
		}
	}

	internal sealed class NIDAVAudioSourceNodeRenderHandler : TrampolineBlockBase
	{
		private DAVAudioSourceNodeRenderHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioSourceNodeRenderHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioSourceNodeRenderHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioSourceNodeRenderHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioSourceNodeRenderHandler aVAudioSourceNodeRenderHandler = (AVAudioSourceNodeRenderHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioSourceNodeRenderHandler ?? new AVAudioSourceNodeRenderHandler(new NIDAVAudioSourceNodeRenderHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private int Invoke(bool isSilence, AudioTimeStamp timestamp, uint frameCunt, ref AudioBuffers outputData)
		{
			IntPtr outputData2 = ((outputData == null) ? IntPtr.Zero : outputData.Handle);
			int result = invoker(base.BlockPointer, isSilence, timestamp, frameCunt, ref outputData2);
			if (outputData2 != ((outputData == null) ? IntPtr.Zero : outputData.Handle))
			{
				outputData = Runtime.GetINativeObject<AudioBuffers>(outputData2, forced_type: false, owns: false);
			}
			return result;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVAudioUnitComponentFilter))]
	internal delegate bool DAVAudioUnitComponentFilter(IntPtr block, IntPtr comp, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDAVAudioUnitComponentFilter
	{
		internal static readonly DAVAudioUnitComponentFilter Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVAudioUnitComponentFilter))]
		private unsafe static bool Invoke(IntPtr block, IntPtr comp, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AVAudioUnitComponentFilter aVAudioUnitComponentFilter = (AVAudioUnitComponentFilter)ptr->Target;
			return aVAudioUnitComponentFilter(Runtime.GetNSObject<AVAudioUnitComponent>(comp), ref stop);
		}
	}

	internal sealed class NIDAVAudioUnitComponentFilter : TrampolineBlockBase
	{
		private DAVAudioUnitComponentFilter invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVAudioUnitComponentFilter(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVAudioUnitComponentFilter>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVAudioUnitComponentFilter? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVAudioUnitComponentFilter aVAudioUnitComponentFilter = (AVAudioUnitComponentFilter)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVAudioUnitComponentFilter ?? new AVAudioUnitComponentFilter(new NIDAVAudioUnitComponentFilter((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(AVAudioUnitComponent comp, ref bool stop)
		{
			return invoker(base.BlockPointer, comp?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVCaptureCompletionHandler))]
	internal delegate void DAVCaptureCompletionHandler(IntPtr block, IntPtr imageDataSampleBuffer, IntPtr error);

	internal static class SDAVCaptureCompletionHandler
	{
		internal static readonly DAVCaptureCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVCaptureCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr imageDataSampleBuffer, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AVCaptureCompletionHandler)ptr->Target)?.Invoke((imageDataSampleBuffer == IntPtr.Zero) ? null : new CMSampleBuffer(imageDataSampleBuffer, owns: false), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDAVCaptureCompletionHandler : TrampolineBlockBase
	{
		private DAVCaptureCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVCaptureCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVCaptureCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVCaptureCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVCaptureCompletionHandler aVCaptureCompletionHandler = (AVCaptureCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVCaptureCompletionHandler ?? new AVCaptureCompletionHandler(new NIDAVCaptureCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CMSampleBuffer imageDataSampleBuffer, NSError error)
		{
			invoker(base.BlockPointer, imageDataSampleBuffer?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVCompletion))]
	internal delegate void DAVCompletion(IntPtr block, bool finished);

	internal static class SDAVCompletion
	{
		internal static readonly DAVCompletion Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVCompletion))]
		private unsafe static void Invoke(IntPtr block, bool finished)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AVCompletion)ptr->Target)?.Invoke(finished);
		}
	}

	internal sealed class NIDAVCompletion : TrampolineBlockBase
	{
		private DAVCompletion invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVCompletion(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVCompletion>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVCompletion? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVCompletion aVCompletion = (AVCompletion)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVCompletion ?? new AVCompletion(new NIDAVCompletion((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool finished)
		{
			invoker(base.BlockPointer, finished);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AVRequestAccessStatus))]
	internal delegate void DAVRequestAccessStatus(IntPtr block, bool accessGranted);

	internal static class SDAVRequestAccessStatus
	{
		internal static readonly DAVRequestAccessStatus Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAVRequestAccessStatus))]
		private unsafe static void Invoke(IntPtr block, bool accessGranted)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AVRequestAccessStatus)ptr->Target)?.Invoke(accessGranted);
		}
	}

	internal sealed class NIDAVRequestAccessStatus : TrampolineBlockBase
	{
		private DAVRequestAccessStatus invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAVRequestAccessStatus(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAVRequestAccessStatus>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AVRequestAccessStatus? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AVRequestAccessStatus aVRequestAccessStatus = (AVRequestAccessStatus)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aVRequestAccessStatus ?? new AVRequestAccessStatus(new NIDAVRequestAccessStatus((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool accessGranted)
		{
			invoker(base.BlockPointer, accessGranted);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ACAccountStoreRemoveCompletionHandler))]
	internal delegate void DACAccountStoreRemoveCompletionHandler(IntPtr block, bool success, IntPtr error);

	internal static class SDACAccountStoreRemoveCompletionHandler
	{
		internal static readonly DACAccountStoreRemoveCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DACAccountStoreRemoveCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, bool success, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((ACAccountStoreRemoveCompletionHandler)ptr->Target)?.Invoke(success, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDACAccountStoreRemoveCompletionHandler : TrampolineBlockBase
	{
		private DACAccountStoreRemoveCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDACAccountStoreRemoveCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DACAccountStoreRemoveCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ACAccountStoreRemoveCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ACAccountStoreRemoveCompletionHandler aCAccountStoreRemoveCompletionHandler = (ACAccountStoreRemoveCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aCAccountStoreRemoveCompletionHandler ?? new ACAccountStoreRemoveCompletionHandler(new NIDACAccountStoreRemoveCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool success, NSError error)
		{
			invoker(base.BlockPointer, success, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ACAccountStoreSaveCompletionHandler))]
	internal delegate void DACAccountStoreSaveCompletionHandler(IntPtr block, bool success, IntPtr error);

	internal static class SDACAccountStoreSaveCompletionHandler
	{
		internal static readonly DACAccountStoreSaveCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DACAccountStoreSaveCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, bool success, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((ACAccountStoreSaveCompletionHandler)ptr->Target)?.Invoke(success, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDACAccountStoreSaveCompletionHandler : TrampolineBlockBase
	{
		private DACAccountStoreSaveCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDACAccountStoreSaveCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DACAccountStoreSaveCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ACAccountStoreSaveCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ACAccountStoreSaveCompletionHandler aCAccountStoreSaveCompletionHandler = (ACAccountStoreSaveCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aCAccountStoreSaveCompletionHandler ?? new ACAccountStoreSaveCompletionHandler(new NIDACAccountStoreSaveCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool success, NSError error)
		{
			invoker(base.BlockPointer, success, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ACRequestCompletionHandler))]
	internal delegate void DACRequestCompletionHandler(IntPtr block, bool granted, IntPtr error);

	internal static class SDACRequestCompletionHandler
	{
		internal static readonly DACRequestCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DACRequestCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, bool granted, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((ACRequestCompletionHandler)ptr->Target)?.Invoke(granted, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDACRequestCompletionHandler : TrampolineBlockBase
	{
		private DACRequestCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDACRequestCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DACRequestCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ACRequestCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ACRequestCompletionHandler aCRequestCompletionHandler = (ACRequestCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aCRequestCompletionHandler ?? new ACRequestCompletionHandler(new NIDACRequestCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool granted, NSError error)
		{
			invoker(base.BlockPointer, granted, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AttributedStringForCandidateHandler))]
	internal delegate IntPtr DAttributedStringForCandidateHandler(IntPtr block, IntPtr candidate, nint index);

	internal static class SDAttributedStringForCandidateHandler
	{
		internal static readonly DAttributedStringForCandidateHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAttributedStringForCandidateHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr candidate, nint index)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AttributedStringForCandidateHandler attributedStringForCandidateHandler = (AttributedStringForCandidateHandler)ptr->Target;
			return attributedStringForCandidateHandler(Runtime.GetNSObject<NSObject>(candidate), index)?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDAttributedStringForCandidateHandler : TrampolineBlockBase
	{
		private DAttributedStringForCandidateHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAttributedStringForCandidateHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAttributedStringForCandidateHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AttributedStringForCandidateHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AttributedStringForCandidateHandler attributedStringForCandidateHandler = (AttributedStringForCandidateHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return attributedStringForCandidateHandler ?? new AttributedStringForCandidateHandler(new NIDAttributedStringForCandidateHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSAttributedString Invoke(NSObject candidate, nint index)
		{
			return Runtime.GetNSObject<NSAttributedString>(invoker(base.BlockPointer, candidate?.Handle ?? IntPtr.Zero, index));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ContinueUserActivityRestorationHandler))]
	internal delegate void DContinueUserActivityRestorationHandler(IntPtr block, IntPtr restorableObjects);

	internal static class SDContinueUserActivityRestorationHandler
	{
		internal static readonly DContinueUserActivityRestorationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DContinueUserActivityRestorationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr restorableObjects)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((ContinueUserActivityRestorationHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSObject>(restorableObjects));
		}
	}

	internal sealed class NIDContinueUserActivityRestorationHandler : TrampolineBlockBase
	{
		private DContinueUserActivityRestorationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDContinueUserActivityRestorationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DContinueUserActivityRestorationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ContinueUserActivityRestorationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ContinueUserActivityRestorationHandler continueUserActivityRestorationHandler = (ContinueUserActivityRestorationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return continueUserActivityRestorationHandler ?? new ContinueUserActivityRestorationHandler(new NIDContinueUserActivityRestorationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject[] restorableObjects)
		{
			NSArray nSArray = ((restorableObjects == null) ? null : NSArray.FromNSObjects(restorableObjects));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(DownloadFontAssetsRequestCompletionHandler))]
	internal delegate bool DDownloadFontAssetsRequestCompletionHandler(IntPtr block, IntPtr error);

	internal static class SDDownloadFontAssetsRequestCompletionHandler
	{
		internal static readonly DDownloadFontAssetsRequestCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DDownloadFontAssetsRequestCompletionHandler))]
		private unsafe static bool Invoke(IntPtr block, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			DownloadFontAssetsRequestCompletionHandler downloadFontAssetsRequestCompletionHandler = (DownloadFontAssetsRequestCompletionHandler)ptr->Target;
			return downloadFontAssetsRequestCompletionHandler(Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDDownloadFontAssetsRequestCompletionHandler : TrampolineBlockBase
	{
		private DDownloadFontAssetsRequestCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDDownloadFontAssetsRequestCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DDownloadFontAssetsRequestCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static DownloadFontAssetsRequestCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			DownloadFontAssetsRequestCompletionHandler downloadFontAssetsRequestCompletionHandler = (DownloadFontAssetsRequestCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return downloadFontAssetsRequestCompletionHandler ?? new DownloadFontAssetsRequestCompletionHandler(new NIDDownloadFontAssetsRequestCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(NSError error)
		{
			return invoker(base.BlockPointer, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GlobalEventHandler))]
	internal delegate void DGlobalEventHandler(IntPtr block, IntPtr theEvent);

	internal static class SDGlobalEventHandler
	{
		internal static readonly DGlobalEventHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGlobalEventHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr theEvent)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GlobalEventHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSEvent>(theEvent));
		}
	}

	internal sealed class NIDGlobalEventHandler : TrampolineBlockBase
	{
		private DGlobalEventHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGlobalEventHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGlobalEventHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GlobalEventHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GlobalEventHandler globalEventHandler = (GlobalEventHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return globalEventHandler ?? new GlobalEventHandler(new NIDGlobalEventHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSEvent theEvent)
		{
			invoker(base.BlockPointer, theEvent?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(LocalEventHandler))]
	internal delegate IntPtr DLocalEventHandler(IntPtr block, IntPtr theEvent);

	internal static class SDLocalEventHandler
	{
		internal static readonly DLocalEventHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DLocalEventHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr theEvent)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			LocalEventHandler localEventHandler = (LocalEventHandler)ptr->Target;
			return localEventHandler(Runtime.GetNSObject<NSEvent>(theEvent))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDLocalEventHandler : TrampolineBlockBase
	{
		private DLocalEventHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDLocalEventHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DLocalEventHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static LocalEventHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			LocalEventHandler localEventHandler = (LocalEventHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return localEventHandler ?? new LocalEventHandler(new NIDLocalEventHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSEvent Invoke(NSEvent theEvent)
		{
			return Runtime.GetNSObject<NSEvent>(invoker(base.BlockPointer, theEvent?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSApplicationEnumerateWindowsHandler))]
	internal delegate void DNSApplicationEnumerateWindowsHandler(IntPtr block, IntPtr window, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSApplicationEnumerateWindowsHandler
	{
		internal static readonly DNSApplicationEnumerateWindowsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSApplicationEnumerateWindowsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr window, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSApplicationEnumerateWindowsHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSWindow>(window), ref stop);
		}
	}

	internal sealed class NIDNSApplicationEnumerateWindowsHandler : TrampolineBlockBase
	{
		private DNSApplicationEnumerateWindowsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSApplicationEnumerateWindowsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSApplicationEnumerateWindowsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSApplicationEnumerateWindowsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSApplicationEnumerateWindowsHandler nSApplicationEnumerateWindowsHandler = (NSApplicationEnumerateWindowsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSApplicationEnumerateWindowsHandler ?? new NSApplicationEnumerateWindowsHandler(new NIDNSApplicationEnumerateWindowsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSWindow window, ref bool stop)
		{
			invoker(base.BlockPointer, window?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSCollectionLayoutGroupCustomItemProvider))]
	internal delegate IntPtr DNSCollectionLayoutGroupCustomItemProvider(IntPtr block, IntPtr layout);

	internal static class SDNSCollectionLayoutGroupCustomItemProvider
	{
		internal static readonly DNSCollectionLayoutGroupCustomItemProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSCollectionLayoutGroupCustomItemProvider))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr layout)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSCollectionLayoutGroupCustomItemProvider nSCollectionLayoutGroupCustomItemProvider = (NSCollectionLayoutGroupCustomItemProvider)ptr->Target;
			NSCollectionLayoutGroupCustomItem[] items = nSCollectionLayoutGroupCustomItemProvider(Runtime.GetINativeObject<INSCollectionLayoutEnvironment>(layout, owns: false));
			return NSArray.FromNSObjects(items).Handle;
		}
	}

	internal sealed class NIDNSCollectionLayoutGroupCustomItemProvider : TrampolineBlockBase
	{
		private DNSCollectionLayoutGroupCustomItemProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSCollectionLayoutGroupCustomItemProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSCollectionLayoutGroupCustomItemProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCollectionLayoutGroupCustomItemProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSCollectionLayoutGroupCustomItemProvider nSCollectionLayoutGroupCustomItemProvider = (NSCollectionLayoutGroupCustomItemProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSCollectionLayoutGroupCustomItemProvider ?? new NSCollectionLayoutGroupCustomItemProvider(new NIDNSCollectionLayoutGroupCustomItemProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSCollectionLayoutGroupCustomItem[] Invoke(INSCollectionLayoutEnvironment layout)
		{
			return NSArray.ArrayFromHandle<NSCollectionLayoutGroupCustomItem>(invoker(base.BlockPointer, layout?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSCollectionLayoutSectionVisibleItemsInvalidationHandler))]
	internal delegate void DNSCollectionLayoutSectionVisibleItemsInvalidationHandler(IntPtr block, IntPtr items, CGPoint point, IntPtr layout);

	internal static class SDNSCollectionLayoutSectionVisibleItemsInvalidationHandler
	{
		internal static readonly DNSCollectionLayoutSectionVisibleItemsInvalidationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSCollectionLayoutSectionVisibleItemsInvalidationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr items, CGPoint point, IntPtr layout)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSCollectionLayoutSectionVisibleItemsInvalidationHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<INSCollectionLayoutVisibleItem>(items), point, Runtime.GetINativeObject<INSCollectionLayoutEnvironment>(layout, owns: false));
		}
	}

	internal sealed class NIDNSCollectionLayoutSectionVisibleItemsInvalidationHandler : TrampolineBlockBase
	{
		private DNSCollectionLayoutSectionVisibleItemsInvalidationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSCollectionLayoutSectionVisibleItemsInvalidationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSCollectionLayoutSectionVisibleItemsInvalidationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCollectionLayoutSectionVisibleItemsInvalidationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSCollectionLayoutSectionVisibleItemsInvalidationHandler nSCollectionLayoutSectionVisibleItemsInvalidationHandler = (NSCollectionLayoutSectionVisibleItemsInvalidationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSCollectionLayoutSectionVisibleItemsInvalidationHandler ?? new NSCollectionLayoutSectionVisibleItemsInvalidationHandler(new NIDNSCollectionLayoutSectionVisibleItemsInvalidationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSCollectionLayoutVisibleItem[] items, CGPoint point, INSCollectionLayoutEnvironment layout)
		{
			NSArray nSArray = ((items == null) ? null : NSArray.FromNSObjects(items));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, point, layout?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSCollectionViewCompositionalLayoutSectionProvider))]
	internal delegate IntPtr DNSCollectionViewCompositionalLayoutSectionProvider(IntPtr block, nint section, IntPtr layout);

	internal static class SDNSCollectionViewCompositionalLayoutSectionProvider
	{
		internal static readonly DNSCollectionViewCompositionalLayoutSectionProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSCollectionViewCompositionalLayoutSectionProvider))]
		private unsafe static IntPtr Invoke(IntPtr block, nint section, IntPtr layout)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSCollectionViewCompositionalLayoutSectionProvider nSCollectionViewCompositionalLayoutSectionProvider = (NSCollectionViewCompositionalLayoutSectionProvider)ptr->Target;
			return nSCollectionViewCompositionalLayoutSectionProvider(section, Runtime.GetINativeObject<INSCollectionLayoutEnvironment>(layout, owns: false))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDNSCollectionViewCompositionalLayoutSectionProvider : TrampolineBlockBase
	{
		private DNSCollectionViewCompositionalLayoutSectionProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSCollectionViewCompositionalLayoutSectionProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSCollectionViewCompositionalLayoutSectionProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCollectionViewCompositionalLayoutSectionProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSCollectionViewCompositionalLayoutSectionProvider nSCollectionViewCompositionalLayoutSectionProvider = (NSCollectionViewCompositionalLayoutSectionProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSCollectionViewCompositionalLayoutSectionProvider ?? new NSCollectionViewCompositionalLayoutSectionProvider(new NIDNSCollectionViewCompositionalLayoutSectionProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSCollectionLayoutSection Invoke(nint section, INSCollectionLayoutEnvironment layout)
		{
			return Runtime.GetNSObject<NSCollectionLayoutSection>(invoker(base.BlockPointer, section, layout?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSCollectionViewDiffableDataSourceItemProvider))]
	internal delegate IntPtr DNSCollectionViewDiffableDataSourceItemProvider(IntPtr block, IntPtr collectionView, IntPtr indexPath, IntPtr itemIdentifierType);

	internal static class SDNSCollectionViewDiffableDataSourceItemProvider
	{
		internal static readonly DNSCollectionViewDiffableDataSourceItemProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSCollectionViewDiffableDataSourceItemProvider))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr collectionView, IntPtr indexPath, IntPtr itemIdentifierType)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSCollectionViewDiffableDataSourceItemProvider nSCollectionViewDiffableDataSourceItemProvider = (NSCollectionViewDiffableDataSourceItemProvider)ptr->Target;
			return nSCollectionViewDiffableDataSourceItemProvider(Runtime.GetNSObject<NSCollectionView>(collectionView), Runtime.GetNSObject<NSIndexPath>(indexPath), Runtime.GetNSObject<NSObject>(itemIdentifierType))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDNSCollectionViewDiffableDataSourceItemProvider : TrampolineBlockBase
	{
		private DNSCollectionViewDiffableDataSourceItemProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSCollectionViewDiffableDataSourceItemProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSCollectionViewDiffableDataSourceItemProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCollectionViewDiffableDataSourceItemProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSCollectionViewDiffableDataSourceItemProvider nSCollectionViewDiffableDataSourceItemProvider = (NSCollectionViewDiffableDataSourceItemProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSCollectionViewDiffableDataSourceItemProvider ?? new NSCollectionViewDiffableDataSourceItemProvider(new NIDNSCollectionViewDiffableDataSourceItemProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSCollectionViewItem Invoke(NSCollectionView collectionView, NSIndexPath indexPath, NSObject itemIdentifierType)
		{
			return Runtime.GetNSObject<NSCollectionViewItem>(invoker(base.BlockPointer, collectionView?.Handle ?? IntPtr.Zero, indexPath?.Handle ?? IntPtr.Zero, itemIdentifierType?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSCollectionViewDiffableDataSourceSupplementaryViewProvider))]
	internal delegate IntPtr DNSCollectionViewDiffableDataSourceSupplementaryViewProvider(IntPtr block, IntPtr collectionView, IntPtr str, IntPtr indexPath);

	internal static class SDNSCollectionViewDiffableDataSourceSupplementaryViewProvider
	{
		internal static readonly DNSCollectionViewDiffableDataSourceSupplementaryViewProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSCollectionViewDiffableDataSourceSupplementaryViewProvider))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr collectionView, IntPtr str, IntPtr indexPath)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSCollectionViewDiffableDataSourceSupplementaryViewProvider nSCollectionViewDiffableDataSourceSupplementaryViewProvider = (NSCollectionViewDiffableDataSourceSupplementaryViewProvider)ptr->Target;
			return nSCollectionViewDiffableDataSourceSupplementaryViewProvider(Runtime.GetNSObject<NSCollectionView>(collectionView), NSString.FromHandle(str), Runtime.GetNSObject<NSIndexPath>(indexPath))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider : TrampolineBlockBase
	{
		private DNSCollectionViewDiffableDataSourceSupplementaryViewProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSCollectionViewDiffableDataSourceSupplementaryViewProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCollectionViewDiffableDataSourceSupplementaryViewProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSCollectionViewDiffableDataSourceSupplementaryViewProvider nSCollectionViewDiffableDataSourceSupplementaryViewProvider = (NSCollectionViewDiffableDataSourceSupplementaryViewProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSCollectionViewDiffableDataSourceSupplementaryViewProvider ?? new NSCollectionViewDiffableDataSourceSupplementaryViewProvider(new NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSView Invoke(NSCollectionView collectionView, string str, NSIndexPath indexPath)
		{
			IntPtr intPtr = NSString.CreateNative(str);
			NSView nSObject = Runtime.GetNSObject<NSView>(invoker(base.BlockPointer, collectionView?.Handle ?? IntPtr.Zero, intPtr, indexPath?.Handle ?? IntPtr.Zero));
			NSString.ReleaseNative(intPtr);
			return nSObject;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSCustomImageRepDrawingHandler))]
	internal delegate bool DNSCustomImageRepDrawingHandler(IntPtr block, CGRect dstRect);

	internal static class SDNSCustomImageRepDrawingHandler
	{
		internal static readonly DNSCustomImageRepDrawingHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSCustomImageRepDrawingHandler))]
		private unsafe static bool Invoke(IntPtr block, CGRect dstRect)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSCustomImageRepDrawingHandler nSCustomImageRepDrawingHandler = (NSCustomImageRepDrawingHandler)ptr->Target;
			return nSCustomImageRepDrawingHandler(dstRect);
		}
	}

	internal sealed class NIDNSCustomImageRepDrawingHandler : TrampolineBlockBase
	{
		private DNSCustomImageRepDrawingHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSCustomImageRepDrawingHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSCustomImageRepDrawingHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCustomImageRepDrawingHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSCustomImageRepDrawingHandler nSCustomImageRepDrawingHandler = (NSCustomImageRepDrawingHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSCustomImageRepDrawingHandler ?? new NSCustomImageRepDrawingHandler(new NIDNSCustomImageRepDrawingHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(CGRect dstRect)
		{
			return invoker(base.BlockPointer, dstRect);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentCompletionHandler))]
	internal delegate void DNSDocumentCompletionHandler(IntPtr block, IntPtr nsErrorPointerOrZero);

	internal static class SDNSDocumentCompletionHandler
	{
		internal static readonly DNSDocumentCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr nsErrorPointerOrZero)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentCompletionHandler)ptr->Target)?.Invoke(nsErrorPointerOrZero);
		}
	}

	internal sealed class NIDNSDocumentCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentCompletionHandler nSDocumentCompletionHandler = (NSDocumentCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentCompletionHandler ?? new NSDocumentCompletionHandler(new NIDNSDocumentCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr nsErrorPointerOrZero)
		{
			invoker(base.BlockPointer, nsErrorPointerOrZero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentControllerOpenPanelResultHandler))]
	internal delegate void DNSDocumentControllerOpenPanelResultHandler(IntPtr block, nint result);

	internal static class SDNSDocumentControllerOpenPanelResultHandler
	{
		internal static readonly DNSDocumentControllerOpenPanelResultHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentControllerOpenPanelResultHandler))]
		private unsafe static void Invoke(IntPtr block, nint result)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentControllerOpenPanelResultHandler)ptr->Target)?.Invoke(result);
		}
	}

	internal sealed class NIDNSDocumentControllerOpenPanelResultHandler : TrampolineBlockBase
	{
		private DNSDocumentControllerOpenPanelResultHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentControllerOpenPanelResultHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentControllerOpenPanelResultHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentControllerOpenPanelResultHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentControllerOpenPanelResultHandler nSDocumentControllerOpenPanelResultHandler = (NSDocumentControllerOpenPanelResultHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentControllerOpenPanelResultHandler ?? new NSDocumentControllerOpenPanelResultHandler(new NIDNSDocumentControllerOpenPanelResultHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint result)
		{
			invoker(base.BlockPointer, result);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentControllerOpenPanelWithCompletionHandler))]
	internal delegate void DNSDocumentControllerOpenPanelWithCompletionHandler(IntPtr block, IntPtr urlsToOpen);

	internal static class SDNSDocumentControllerOpenPanelWithCompletionHandler
	{
		internal static readonly DNSDocumentControllerOpenPanelWithCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentControllerOpenPanelWithCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr urlsToOpen)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentControllerOpenPanelWithCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSArray>(urlsToOpen));
		}
	}

	internal sealed class NIDNSDocumentControllerOpenPanelWithCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentControllerOpenPanelWithCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentControllerOpenPanelWithCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentControllerOpenPanelWithCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentControllerOpenPanelWithCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentControllerOpenPanelWithCompletionHandler nSDocumentControllerOpenPanelWithCompletionHandler = (NSDocumentControllerOpenPanelWithCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentControllerOpenPanelWithCompletionHandler ?? new NSDocumentControllerOpenPanelWithCompletionHandler(new NIDNSDocumentControllerOpenPanelWithCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSArray urlsToOpen)
		{
			invoker(base.BlockPointer, urlsToOpen?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentLockCompletionHandler))]
	internal delegate void DNSDocumentLockCompletionHandler(IntPtr block, IntPtr error);

	internal static class SDNSDocumentLockCompletionHandler
	{
		internal static readonly DNSDocumentLockCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentLockCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentLockCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSDocumentLockCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentLockCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentLockCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentLockCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentLockCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentLockCompletionHandler nSDocumentLockCompletionHandler = (NSDocumentLockCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentLockCompletionHandler ?? new NSDocumentLockCompletionHandler(new NIDNSDocumentLockCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSError error)
		{
			invoker(base.BlockPointer, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentLockDocumentCompletionHandler))]
	internal delegate void DNSDocumentLockDocumentCompletionHandler(IntPtr block, bool didLock);

	internal static class SDNSDocumentLockDocumentCompletionHandler
	{
		internal static readonly DNSDocumentLockDocumentCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentLockDocumentCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, bool didLock)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentLockDocumentCompletionHandler)ptr->Target)?.Invoke(didLock);
		}
	}

	internal sealed class NIDNSDocumentLockDocumentCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentLockDocumentCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentLockDocumentCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentLockDocumentCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentLockDocumentCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentLockDocumentCompletionHandler nSDocumentLockDocumentCompletionHandler = (NSDocumentLockDocumentCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentLockDocumentCompletionHandler ?? new NSDocumentLockDocumentCompletionHandler(new NIDNSDocumentLockDocumentCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool didLock)
		{
			invoker(base.BlockPointer, didLock);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentMoveCompletionHandler))]
	internal delegate void DNSDocumentMoveCompletionHandler(IntPtr block, bool didMove);

	internal static class SDNSDocumentMoveCompletionHandler
	{
		internal static readonly DNSDocumentMoveCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentMoveCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, bool didMove)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentMoveCompletionHandler)ptr->Target)?.Invoke(didMove);
		}
	}

	internal sealed class NIDNSDocumentMoveCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentMoveCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentMoveCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentMoveCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentMoveCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentMoveCompletionHandler nSDocumentMoveCompletionHandler = (NSDocumentMoveCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentMoveCompletionHandler ?? new NSDocumentMoveCompletionHandler(new NIDNSDocumentMoveCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool didMove)
		{
			invoker(base.BlockPointer, didMove);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentMoveToUrlCompletionHandler))]
	internal delegate void DNSDocumentMoveToUrlCompletionHandler(IntPtr block, IntPtr error);

	internal static class SDNSDocumentMoveToUrlCompletionHandler
	{
		internal static readonly DNSDocumentMoveToUrlCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentMoveToUrlCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentMoveToUrlCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSDocumentMoveToUrlCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentMoveToUrlCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentMoveToUrlCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentMoveToUrlCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentMoveToUrlCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentMoveToUrlCompletionHandler nSDocumentMoveToUrlCompletionHandler = (NSDocumentMoveToUrlCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentMoveToUrlCompletionHandler ?? new NSDocumentMoveToUrlCompletionHandler(new NIDNSDocumentMoveToUrlCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSError error)
		{
			invoker(base.BlockPointer, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentUnlockCompletionHandler))]
	internal delegate void DNSDocumentUnlockCompletionHandler(IntPtr block, IntPtr error);

	internal static class SDNSDocumentUnlockCompletionHandler
	{
		internal static readonly DNSDocumentUnlockCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentUnlockCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentUnlockCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSDocumentUnlockCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentUnlockCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentUnlockCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentUnlockCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentUnlockCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentUnlockCompletionHandler nSDocumentUnlockCompletionHandler = (NSDocumentUnlockCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentUnlockCompletionHandler ?? new NSDocumentUnlockCompletionHandler(new NIDNSDocumentUnlockCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSError error)
		{
			invoker(base.BlockPointer, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDocumentUnlockDocumentCompletionHandler))]
	internal delegate void DNSDocumentUnlockDocumentCompletionHandler(IntPtr block, bool didUnlock);

	internal static class SDNSDocumentUnlockDocumentCompletionHandler
	{
		internal static readonly DNSDocumentUnlockDocumentCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDocumentUnlockDocumentCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, bool didUnlock)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDocumentUnlockDocumentCompletionHandler)ptr->Target)?.Invoke(didUnlock);
		}
	}

	internal sealed class NIDNSDocumentUnlockDocumentCompletionHandler : TrampolineBlockBase
	{
		private DNSDocumentUnlockDocumentCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDocumentUnlockDocumentCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDocumentUnlockDocumentCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDocumentUnlockDocumentCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDocumentUnlockDocumentCompletionHandler nSDocumentUnlockDocumentCompletionHandler = (NSDocumentUnlockDocumentCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDocumentUnlockDocumentCompletionHandler ?? new NSDocumentUnlockDocumentCompletionHandler(new NIDNSDocumentUnlockDocumentCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool didUnlock)
		{
			invoker(base.BlockPointer, didUnlock);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDraggingEnumerator))]
	internal delegate void DNSDraggingEnumerator(IntPtr block, IntPtr draggingItem, nint idx, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSDraggingEnumerator
	{
		internal static readonly DNSDraggingEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDraggingEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr draggingItem, nint idx, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDraggingEnumerator)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDraggingItem>(draggingItem), idx, ref stop);
		}
	}

	internal sealed class NIDNSDraggingEnumerator : TrampolineBlockBase
	{
		private DNSDraggingEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDraggingEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDraggingEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDraggingEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDraggingEnumerator nSDraggingEnumerator = (NSDraggingEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDraggingEnumerator ?? new NSDraggingEnumerator(new NIDNSDraggingEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDraggingItem draggingItem, nint idx, ref bool stop)
		{
			invoker(base.BlockPointer, draggingItem?.Handle ?? IntPtr.Zero, idx, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDraggingItemImagesContentProvider))]
	internal delegate IntPtr DNSDraggingItemImagesContentProvider(IntPtr block);

	internal static class SDNSDraggingItemImagesContentProvider
	{
		internal static readonly DNSDraggingItemImagesContentProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDraggingItemImagesContentProvider))]
		private unsafe static IntPtr Invoke(IntPtr block)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSDraggingItemImagesContentProvider nSDraggingItemImagesContentProvider = (NSDraggingItemImagesContentProvider)ptr->Target;
			NSDraggingImageComponent[] items = nSDraggingItemImagesContentProvider();
			return NSArray.FromNSObjects(items).Handle;
		}
	}

	internal sealed class NIDNSDraggingItemImagesContentProvider : TrampolineBlockBase
	{
		private DNSDraggingItemImagesContentProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDraggingItemImagesContentProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDraggingItemImagesContentProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDraggingItemImagesContentProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDraggingItemImagesContentProvider nSDraggingItemImagesContentProvider = (NSDraggingItemImagesContentProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDraggingItemImagesContentProvider ?? new NSDraggingItemImagesContentProvider(new NIDNSDraggingItemImagesContentProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSDraggingImageComponent[] Invoke()
		{
			return NSArray.ArrayFromHandle<NSDraggingImageComponent>(invoker(base.BlockPointer));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSEventTrackHandler))]
	internal delegate void DNSEventTrackHandler(IntPtr block, nfloat gestureAmount, nuint eventPhase, bool isComplete, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSEventTrackHandler
	{
		internal static readonly DNSEventTrackHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSEventTrackHandler))]
		private unsafe static void Invoke(IntPtr block, nfloat gestureAmount, nuint eventPhase, bool isComplete, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSEventTrackHandler)ptr->Target)?.Invoke(gestureAmount, (NSEventPhase)(ulong)eventPhase, isComplete, ref stop);
		}
	}

	internal sealed class NIDNSEventTrackHandler : TrampolineBlockBase
	{
		private DNSEventTrackHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSEventTrackHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSEventTrackHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSEventTrackHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSEventTrackHandler nSEventTrackHandler = (NSEventTrackHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSEventTrackHandler ?? new NSEventTrackHandler(new NIDNSEventTrackHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nfloat gestureAmount, NSEventPhase eventPhase, bool isComplete, ref bool stop)
		{
			invoker(base.BlockPointer, gestureAmount, (nuint)(ulong)eventPhase, isComplete, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSSavePanelComplete))]
	internal delegate void DNSSavePanelComplete(IntPtr block, nint result);

	internal static class SDNSSavePanelComplete
	{
		internal static readonly DNSSavePanelComplete Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSSavePanelComplete))]
		private unsafe static void Invoke(IntPtr block, nint result)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSSavePanelComplete)ptr->Target)?.Invoke(result);
		}
	}

	internal sealed class NIDNSSavePanelComplete : TrampolineBlockBase
	{
		private DNSSavePanelComplete invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSSavePanelComplete(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSSavePanelComplete>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSSavePanelComplete? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSSavePanelComplete nSSavePanelComplete = (NSSavePanelComplete)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSSavePanelComplete ?? new NSSavePanelComplete(new NIDNSSavePanelComplete((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint result)
		{
			invoker(base.BlockPointer, result);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSSharingServiceHandler))]
	internal delegate void DNSSharingServiceHandler(IntPtr block);

	internal static class SDNSSharingServiceHandler
	{
		internal static readonly DNSSharingServiceHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSSharingServiceHandler))]
		private unsafe static void Invoke(IntPtr block)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSSharingServiceHandler)ptr->Target)?.Invoke();
		}
	}

	internal sealed class NIDNSSharingServiceHandler : TrampolineBlockBase
	{
		private DNSSharingServiceHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSSharingServiceHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSSharingServiceHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSSharingServiceHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSSharingServiceHandler nSSharingServiceHandler = (NSSharingServiceHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSSharingServiceHandler ?? new NSSharingServiceHandler(new NIDNSSharingServiceHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke()
		{
			invoker(base.BlockPointer);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSSpellCheckerShowCorrectionIndicatorOfTypeHandler))]
	internal delegate void DNSSpellCheckerShowCorrectionIndicatorOfTypeHandler(IntPtr block, IntPtr acceptedString);

	internal static class SDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler
	{
		internal static readonly DNSSpellCheckerShowCorrectionIndicatorOfTypeHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSSpellCheckerShowCorrectionIndicatorOfTypeHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr acceptedString)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSSpellCheckerShowCorrectionIndicatorOfTypeHandler)ptr->Target)?.Invoke(NSString.FromHandle(acceptedString));
		}
	}

	internal sealed class NIDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler : TrampolineBlockBase
	{
		private DNSSpellCheckerShowCorrectionIndicatorOfTypeHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSSpellCheckerShowCorrectionIndicatorOfTypeHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSSpellCheckerShowCorrectionIndicatorOfTypeHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSSpellCheckerShowCorrectionIndicatorOfTypeHandler nSSpellCheckerShowCorrectionIndicatorOfTypeHandler = (NSSpellCheckerShowCorrectionIndicatorOfTypeHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSSpellCheckerShowCorrectionIndicatorOfTypeHandler ?? new NSSpellCheckerShowCorrectionIndicatorOfTypeHandler(new NIDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string acceptedString)
		{
			IntPtr intPtr = NSString.CreateNative(acceptedString);
			invoker(base.BlockPointer, intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSStoryboardControllerCreator))]
	internal delegate IntPtr DNSStoryboardControllerCreator(IntPtr block, IntPtr coder);

	internal static class SDNSStoryboardControllerCreator
	{
		internal static readonly DNSStoryboardControllerCreator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSStoryboardControllerCreator))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr coder)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSStoryboardControllerCreator nSStoryboardControllerCreator = (NSStoryboardControllerCreator)ptr->Target;
			return nSStoryboardControllerCreator(Runtime.GetNSObject<NSCoder>(coder))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDNSStoryboardControllerCreator : TrampolineBlockBase
	{
		private DNSStoryboardControllerCreator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSStoryboardControllerCreator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSStoryboardControllerCreator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSStoryboardControllerCreator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSStoryboardControllerCreator nSStoryboardControllerCreator = (NSStoryboardControllerCreator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSStoryboardControllerCreator ?? new NSStoryboardControllerCreator(new NIDNSStoryboardControllerCreator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSObject Invoke(NSCoder coder)
		{
			return Runtime.GetNSObject(invoker(base.BlockPointer, coder?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSTableViewRowHandler))]
	internal delegate void DNSTableViewRowHandler(IntPtr block, IntPtr rowView, nint row);

	internal static class SDNSTableViewRowHandler
	{
		internal static readonly DNSTableViewRowHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSTableViewRowHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr rowView, nint row)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSTableViewRowHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSTableRowView>(rowView), row);
		}
	}

	internal sealed class NIDNSTableViewRowHandler : TrampolineBlockBase
	{
		private DNSTableViewRowHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSTableViewRowHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSTableViewRowHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSTableViewRowHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSTableViewRowHandler nSTableViewRowHandler = (NSTableViewRowHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSTableViewRowHandler ?? new NSTableViewRowHandler(new NIDNSTableViewRowHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSTableRowView rowView, nint row)
		{
			invoker(base.BlockPointer, rowView?.Handle ?? IntPtr.Zero, row);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSTextLayoutEnumerateEnclosingRects))]
	internal delegate void DNSTextLayoutEnumerateEnclosingRects(IntPtr block, CGRect rect, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDNSTextLayoutEnumerateEnclosingRects
	{
		internal static readonly DNSTextLayoutEnumerateEnclosingRects Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSTextLayoutEnumerateEnclosingRects))]
		private unsafe static void Invoke(IntPtr block, CGRect rect, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSTextLayoutEnumerateEnclosingRects nSTextLayoutEnumerateEnclosingRects = (NSTextLayoutEnumerateEnclosingRects)ptr->Target;
			if (nSTextLayoutEnumerateEnclosingRects != null)
			{
				nSTextLayoutEnumerateEnclosingRects(rect, out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDNSTextLayoutEnumerateEnclosingRects : TrampolineBlockBase
	{
		private DNSTextLayoutEnumerateEnclosingRects invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSTextLayoutEnumerateEnclosingRects(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSTextLayoutEnumerateEnclosingRects>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSTextLayoutEnumerateEnclosingRects? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSTextLayoutEnumerateEnclosingRects nSTextLayoutEnumerateEnclosingRects = (NSTextLayoutEnumerateEnclosingRects)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSTextLayoutEnumerateEnclosingRects ?? new NSTextLayoutEnumerateEnclosingRects(new NIDNSTextLayoutEnumerateEnclosingRects((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CGRect rect, out bool stop)
		{
			invoker(base.BlockPointer, rect, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSTextLayoutEnumerateLineFragments))]
	internal delegate void DNSTextLayoutEnumerateLineFragments(IntPtr block, CGRect rect, CGRect usedRectangle, IntPtr textContainer, NSRange glyphRange, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDNSTextLayoutEnumerateLineFragments
	{
		internal static readonly DNSTextLayoutEnumerateLineFragments Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSTextLayoutEnumerateLineFragments))]
		private unsafe static void Invoke(IntPtr block, CGRect rect, CGRect usedRectangle, IntPtr textContainer, NSRange glyphRange, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSTextLayoutEnumerateLineFragments nSTextLayoutEnumerateLineFragments = (NSTextLayoutEnumerateLineFragments)ptr->Target;
			if (nSTextLayoutEnumerateLineFragments != null)
			{
				nSTextLayoutEnumerateLineFragments(rect, usedRectangle, Runtime.GetNSObject<NSTextContainer>(textContainer), glyphRange, out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDNSTextLayoutEnumerateLineFragments : TrampolineBlockBase
	{
		private DNSTextLayoutEnumerateLineFragments invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSTextLayoutEnumerateLineFragments(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSTextLayoutEnumerateLineFragments>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSTextLayoutEnumerateLineFragments? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSTextLayoutEnumerateLineFragments nSTextLayoutEnumerateLineFragments = (NSTextLayoutEnumerateLineFragments)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSTextLayoutEnumerateLineFragments ?? new NSTextLayoutEnumerateLineFragments(new NIDNSTextLayoutEnumerateLineFragments((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CGRect rect, CGRect usedRectangle, NSTextContainer textContainer, NSRange glyphRange, out bool stop)
		{
			invoker(base.BlockPointer, rect, usedRectangle, textContainer?.Handle ?? IntPtr.Zero, glyphRange, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSWindowCompletionHandler))]
	internal delegate void DNSWindowCompletionHandler(IntPtr block, IntPtr window, IntPtr error);

	internal static class SDNSWindowCompletionHandler
	{
		internal static readonly DNSWindowCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSWindowCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr window, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSWindowCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSWindow>(window), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSWindowCompletionHandler : TrampolineBlockBase
	{
		private DNSWindowCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSWindowCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSWindowCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSWindowCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSWindowCompletionHandler nSWindowCompletionHandler = (NSWindowCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSWindowCompletionHandler ?? new NSWindowCompletionHandler(new NIDNSWindowCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSWindow window, NSError error)
		{
			invoker(base.BlockPointer, window?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSWindowTrackEventsMatchingCompletionHandler))]
	internal delegate void DNSWindowTrackEventsMatchingCompletionHandler(IntPtr block, IntPtr evt, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSWindowTrackEventsMatchingCompletionHandler
	{
		internal static readonly DNSWindowTrackEventsMatchingCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSWindowTrackEventsMatchingCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr evt, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSWindowTrackEventsMatchingCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSEvent>(evt), ref stop);
		}
	}

	internal sealed class NIDNSWindowTrackEventsMatchingCompletionHandler : TrampolineBlockBase
	{
		private DNSWindowTrackEventsMatchingCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSWindowTrackEventsMatchingCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSWindowTrackEventsMatchingCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSWindowTrackEventsMatchingCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSWindowTrackEventsMatchingCompletionHandler nSWindowTrackEventsMatchingCompletionHandler = (NSWindowTrackEventsMatchingCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSWindowTrackEventsMatchingCompletionHandler ?? new NSWindowTrackEventsMatchingCompletionHandler(new NIDNSWindowTrackEventsMatchingCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSEvent evt, ref bool stop)
		{
			invoker(base.BlockPointer, evt?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSWorkspaceUrlHandler))]
	internal delegate void DNSWorkspaceUrlHandler(IntPtr block, IntPtr newUrls, IntPtr error);

	internal static class SDNSWorkspaceUrlHandler
	{
		internal static readonly DNSWorkspaceUrlHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSWorkspaceUrlHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr newUrls, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSWorkspaceUrlHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(newUrls), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSWorkspaceUrlHandler : TrampolineBlockBase
	{
		private DNSWorkspaceUrlHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSWorkspaceUrlHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSWorkspaceUrlHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSWorkspaceUrlHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSWorkspaceUrlHandler nSWorkspaceUrlHandler = (NSWorkspaceUrlHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSWorkspaceUrlHandler ?? new NSWorkspaceUrlHandler(new NIDNSWorkspaceUrlHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary newUrls, NSError error)
		{
			invoker(base.BlockPointer, newUrls?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(OpenDocumentCompletionHandler))]
	internal delegate void DOpenDocumentCompletionHandler(IntPtr block, IntPtr document, bool documentWasAlreadyOpen, IntPtr error);

	internal static class SDOpenDocumentCompletionHandler
	{
		internal static readonly DOpenDocumentCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DOpenDocumentCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr document, bool documentWasAlreadyOpen, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((OpenDocumentCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDocument>(document), documentWasAlreadyOpen, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDOpenDocumentCompletionHandler : TrampolineBlockBase
	{
		private DOpenDocumentCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDOpenDocumentCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DOpenDocumentCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static OpenDocumentCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			OpenDocumentCompletionHandler openDocumentCompletionHandler = (OpenDocumentCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return openDocumentCompletionHandler ?? new OpenDocumentCompletionHandler(new NIDOpenDocumentCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDocument document, bool documentWasAlreadyOpen, NSError error)
		{
			invoker(base.BlockPointer, document?.Handle ?? IntPtr.Zero, documentWasAlreadyOpen, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUHostTransportStateBlock))]
	internal delegate bool DAUHostTransportStateBlock(IntPtr block, ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition);

	internal static class SDAUHostTransportStateBlock
	{
		internal static readonly DAUHostTransportStateBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUHostTransportStateBlock))]
		private unsafe static bool Invoke(IntPtr block, ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUHostTransportStateBlock aUHostTransportStateBlock = (AUHostTransportStateBlock)ptr->Target;
			return aUHostTransportStateBlock(ref transportStateFlags, ref currentSamplePosition, ref cycleStartBeatPosition, ref cycleEndBeatPosition);
		}
	}

	internal sealed class NIDAUHostTransportStateBlock : TrampolineBlockBase
	{
		private DAUHostTransportStateBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUHostTransportStateBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUHostTransportStateBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUHostTransportStateBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUHostTransportStateBlock aUHostTransportStateBlock = (AUHostTransportStateBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUHostTransportStateBlock ?? new AUHostTransportStateBlock(new NIDAUHostTransportStateBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition)
		{
			return invoker(base.BlockPointer, ref transportStateFlags, ref currentSamplePosition, ref cycleStartBeatPosition, ref cycleEndBeatPosition);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUImplementorDisplayNameWithLengthCallback))]
	internal delegate IntPtr DAUImplementorDisplayNameWithLengthCallback(IntPtr block, IntPtr node, nint desiredLength);

	internal static class SDAUImplementorDisplayNameWithLengthCallback
	{
		internal static readonly DAUImplementorDisplayNameWithLengthCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUImplementorDisplayNameWithLengthCallback))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr node, nint desiredLength)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUImplementorDisplayNameWithLengthCallback aUImplementorDisplayNameWithLengthCallback = (AUImplementorDisplayNameWithLengthCallback)ptr->Target;
			string str = aUImplementorDisplayNameWithLengthCallback(Runtime.GetNSObject<AUParameterNode>(node), desiredLength);
			return NSString.CreateNative(str, autorelease: true);
		}
	}

	internal sealed class NIDAUImplementorDisplayNameWithLengthCallback : TrampolineBlockBase
	{
		private DAUImplementorDisplayNameWithLengthCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUImplementorDisplayNameWithLengthCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUImplementorDisplayNameWithLengthCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUImplementorDisplayNameWithLengthCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUImplementorDisplayNameWithLengthCallback aUImplementorDisplayNameWithLengthCallback = (AUImplementorDisplayNameWithLengthCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUImplementorDisplayNameWithLengthCallback ?? new AUImplementorDisplayNameWithLengthCallback(new NIDAUImplementorDisplayNameWithLengthCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private string Invoke(AUParameterNode node, nint desiredLength)
		{
			return NSString.FromHandle(invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, desiredLength));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUImplementorStringFromValueCallback))]
	internal delegate IntPtr DAUImplementorStringFromValueCallback(IntPtr block, IntPtr param, IntPtr value);

	internal static class SDAUImplementorStringFromValueCallback
	{
		internal static readonly DAUImplementorStringFromValueCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUImplementorStringFromValueCallback))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr param, IntPtr value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUImplementorStringFromValueCallback aUImplementorStringFromValueCallback = (AUImplementorStringFromValueCallback)ptr->Target;
			float? value2 = null;
			if (value != IntPtr.Zero)
			{
				value2 = *(float*)(void*)value;
			}
			NSString nSString = aUImplementorStringFromValueCallback(Runtime.GetNSObject<AUParameter>(param), ref value2);
			return (nSString != null) ? nSString.Handle : IntPtr.Zero;
		}
	}

	internal sealed class NIDAUImplementorStringFromValueCallback : TrampolineBlockBase
	{
		private DAUImplementorStringFromValueCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUImplementorStringFromValueCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUImplementorStringFromValueCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUImplementorStringFromValueCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUImplementorStringFromValueCallback aUImplementorStringFromValueCallback = (AUImplementorStringFromValueCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUImplementorStringFromValueCallback ?? new AUImplementorStringFromValueCallback(new NIDAUImplementorStringFromValueCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe NSString Invoke(AUParameter param, ref float? value)
		{
			IntPtr value2 = IntPtr.Zero;
			float num = 0f;
			if (value.HasValue)
			{
				num = value.Value;
				value2 = new IntPtr(&num);
			}
			return Runtime.GetNSObject<NSString>(invoker(base.BlockPointer, param?.Handle ?? IntPtr.Zero, value2));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUImplementorValueFromStringCallback))]
	internal delegate float DAUImplementorValueFromStringCallback(IntPtr block, IntPtr param, IntPtr str);

	internal static class SDAUImplementorValueFromStringCallback
	{
		internal static readonly DAUImplementorValueFromStringCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUImplementorValueFromStringCallback))]
		private unsafe static float Invoke(IntPtr block, IntPtr param, IntPtr str)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUImplementorValueFromStringCallback aUImplementorValueFromStringCallback = (AUImplementorValueFromStringCallback)ptr->Target;
			return aUImplementorValueFromStringCallback(Runtime.GetNSObject<AUParameter>(param), NSString.FromHandle(str));
		}
	}

	internal sealed class NIDAUImplementorValueFromStringCallback : TrampolineBlockBase
	{
		private DAUImplementorValueFromStringCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUImplementorValueFromStringCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUImplementorValueFromStringCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUImplementorValueFromStringCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUImplementorValueFromStringCallback aUImplementorValueFromStringCallback = (AUImplementorValueFromStringCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUImplementorValueFromStringCallback ?? new AUImplementorValueFromStringCallback(new NIDAUImplementorValueFromStringCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private float Invoke(AUParameter param, string str)
		{
			IntPtr intPtr = NSString.CreateNative(str);
			float result = invoker(base.BlockPointer, param?.Handle ?? IntPtr.Zero, intPtr);
			NSString.ReleaseNative(intPtr);
			return result;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUImplementorValueObserver))]
	internal delegate void DAUImplementorValueObserver(IntPtr block, IntPtr param, float value);

	internal static class SDAUImplementorValueObserver
	{
		internal static readonly DAUImplementorValueObserver Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUImplementorValueObserver))]
		private unsafe static void Invoke(IntPtr block, IntPtr param, float value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUImplementorValueObserver)ptr->Target)?.Invoke(Runtime.GetNSObject<AUParameter>(param), value);
		}
	}

	internal sealed class NIDAUImplementorValueObserver : TrampolineBlockBase
	{
		private DAUImplementorValueObserver invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUImplementorValueObserver(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUImplementorValueObserver>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUImplementorValueObserver? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUImplementorValueObserver aUImplementorValueObserver = (AUImplementorValueObserver)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUImplementorValueObserver ?? new AUImplementorValueObserver(new NIDAUImplementorValueObserver((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AUParameter param, float value)
		{
			invoker(base.BlockPointer, param?.Handle ?? IntPtr.Zero, value);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUImplementorValueProvider))]
	internal delegate float DAUImplementorValueProvider(IntPtr block, IntPtr param);

	internal static class SDAUImplementorValueProvider
	{
		internal static readonly DAUImplementorValueProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUImplementorValueProvider))]
		private unsafe static float Invoke(IntPtr block, IntPtr param)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUImplementorValueProvider aUImplementorValueProvider = (AUImplementorValueProvider)ptr->Target;
			return aUImplementorValueProvider(Runtime.GetNSObject<AUParameter>(param));
		}
	}

	internal sealed class NIDAUImplementorValueProvider : TrampolineBlockBase
	{
		private DAUImplementorValueProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUImplementorValueProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUImplementorValueProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUImplementorValueProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUImplementorValueProvider aUImplementorValueProvider = (AUImplementorValueProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUImplementorValueProvider ?? new AUImplementorValueProvider(new NIDAUImplementorValueProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private float Invoke(AUParameter param)
		{
			return invoker(base.BlockPointer, param?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUInputHandler))]
	internal delegate void DAUInputHandler(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber);

	internal static class SDAUInputHandler
	{
		internal static readonly DAUInputHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUInputHandler))]
		private unsafe static void Invoke(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUInputHandler)ptr->Target)?.Invoke(ref actionFlags, ref timestamp, frameCount, inputBusNumber);
		}
	}

	internal sealed class NIDAUInputHandler : TrampolineBlockBase
	{
		private DAUInputHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUInputHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUInputHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUInputHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUInputHandler aUInputHandler = (AUInputHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUInputHandler ?? new AUInputHandler(new NIDAUInputHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber)
		{
			invoker(base.BlockPointer, ref actionFlags, ref timestamp, frameCount, inputBusNumber);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUInternalRenderBlock))]
	internal delegate AudioUnitStatus DAUInternalRenderBlock(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, IntPtr outputData, IntPtr realtimeEventListHead, IntPtr pullInputBlock);

	internal static class SDAUInternalRenderBlock
	{
		internal static readonly DAUInternalRenderBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUInternalRenderBlock))]
		private unsafe static AudioUnitStatus Invoke(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, IntPtr outputData, IntPtr realtimeEventListHead, IntPtr pullInputBlock)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUInternalRenderBlock aUInternalRenderBlock = (AUInternalRenderBlock)ptr->Target;
			return aUInternalRenderBlock(ref actionFlags, ref timestamp, frameCount, outputBusNumber, new AudioBuffers(outputData), new AURenderEventEnumerator(realtimeEventListHead), NIDAURenderPullInputBlock.Create(pullInputBlock));
		}
	}

	internal sealed class NIDAUInternalRenderBlock : TrampolineBlockBase
	{
		private DAUInternalRenderBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUInternalRenderBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUInternalRenderBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUInternalRenderBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUInternalRenderBlock aUInternalRenderBlock = (AUInternalRenderBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUInternalRenderBlock ?? new AUInternalRenderBlock(new NIDAUInternalRenderBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe AudioUnitStatus Invoke(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, AudioBuffers outputData, AURenderEventEnumerator realtimeEventListHead, [BlockProxy(typeof(NIDAURenderPullInputBlock))] AURenderPullInputBlock? pullInputBlock)
		{
			BlockLiteral* ptr;
			if (pullInputBlock == null)
			{
				ptr = null;
			}
			else
			{
				BlockLiteral blockLiteral = default(BlockLiteral);
				ptr = &blockLiteral;
				blockLiteral.SetupBlockUnsafe(SDAURenderPullInputBlock.Handler, pullInputBlock);
			}
			AudioUnitStatus result = invoker(base.BlockPointer, ref actionFlags, ref timestamp, frameCount, outputBusNumber, outputData?.Handle ?? IntPtr.Zero, realtimeEventListHead?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
			if (ptr != null)
			{
				ptr->CleanupBlock();
			}
			return result;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUMidiCIProfileChangedCallback))]
	internal delegate void DAUMidiCIProfileChangedCallback(IntPtr block, byte cable, byte channel, IntPtr profile, bool enabled);

	internal static class SDAUMidiCIProfileChangedCallback
	{
		internal static readonly DAUMidiCIProfileChangedCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUMidiCIProfileChangedCallback))]
		private unsafe static void Invoke(IntPtr block, byte cable, byte channel, IntPtr profile, bool enabled)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUMidiCIProfileChangedCallback)ptr->Target)?.Invoke(cable, channel, Runtime.GetNSObject<MidiCIProfile>(profile), enabled);
		}
	}

	internal sealed class NIDAUMidiCIProfileChangedCallback : TrampolineBlockBase
	{
		private DAUMidiCIProfileChangedCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUMidiCIProfileChangedCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUMidiCIProfileChangedCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUMidiCIProfileChangedCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUMidiCIProfileChangedCallback aUMidiCIProfileChangedCallback = (AUMidiCIProfileChangedCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUMidiCIProfileChangedCallback ?? new AUMidiCIProfileChangedCallback(new NIDAUMidiCIProfileChangedCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(byte cable, byte channel, MidiCIProfile profile, bool enabled)
		{
			invoker(base.BlockPointer, cable, channel, profile?.Handle ?? IntPtr.Zero, enabled);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUMidiOutputEventBlock))]
	internal delegate int DAUMidiOutputEventBlock(IntPtr block, long eventSampleTime, byte cable, nint length, IntPtr midiBytes);

	internal static class SDAUMidiOutputEventBlock
	{
		internal static readonly DAUMidiOutputEventBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUMidiOutputEventBlock))]
		private unsafe static int Invoke(IntPtr block, long eventSampleTime, byte cable, nint length, IntPtr midiBytes)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AUMidiOutputEventBlock aUMidiOutputEventBlock = (AUMidiOutputEventBlock)ptr->Target;
			return aUMidiOutputEventBlock(eventSampleTime, cable, length, midiBytes);
		}
	}

	internal sealed class NIDAUMidiOutputEventBlock : TrampolineBlockBase
	{
		private DAUMidiOutputEventBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUMidiOutputEventBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUMidiOutputEventBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUMidiOutputEventBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUMidiOutputEventBlock aUMidiOutputEventBlock = (AUMidiOutputEventBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUMidiOutputEventBlock ?? new AUMidiOutputEventBlock(new NIDAUMidiOutputEventBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private int Invoke(long eventSampleTime, byte cable, nint length, IntPtr midiBytes)
		{
			return invoker(base.BlockPointer, eventSampleTime, cable, length, midiBytes);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUParameterAutomationObserver))]
	internal delegate void DAUParameterAutomationObserver(IntPtr block, ulong address, float value);

	internal static class SDAUParameterAutomationObserver
	{
		internal static readonly DAUParameterAutomationObserver Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUParameterAutomationObserver))]
		private unsafe static void Invoke(IntPtr block, ulong address, float value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUParameterAutomationObserver)ptr->Target)?.Invoke(address, value);
		}
	}

	internal sealed class NIDAUParameterAutomationObserver : TrampolineBlockBase
	{
		private DAUParameterAutomationObserver invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUParameterAutomationObserver(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUParameterAutomationObserver>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUParameterAutomationObserver? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUParameterAutomationObserver aUParameterAutomationObserver = (AUParameterAutomationObserver)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUParameterAutomationObserver ?? new AUParameterAutomationObserver(new NIDAUParameterAutomationObserver((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ulong address, float value)
		{
			invoker(base.BlockPointer, address, value);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUParameterObserver))]
	internal delegate void DAUParameterObserver(IntPtr block, ulong address, float value);

	internal static class SDAUParameterObserver
	{
		internal static readonly DAUParameterObserver Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUParameterObserver))]
		private unsafe static void Invoke(IntPtr block, ulong address, float value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUParameterObserver)ptr->Target)?.Invoke(address, value);
		}
	}

	internal sealed class NIDAUParameterObserver : TrampolineBlockBase
	{
		private DAUParameterObserver invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUParameterObserver(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUParameterObserver>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUParameterObserver? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUParameterObserver aUParameterObserver = (AUParameterObserver)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUParameterObserver ?? new AUParameterObserver(new NIDAUParameterObserver((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ulong address, float value)
		{
			invoker(base.BlockPointer, address, value);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUParameterRecordingObserver))]
	internal delegate void DAUParameterRecordingObserver(IntPtr block, nint numberOfEvents, ref AURecordedParameterEvent events);

	internal static class SDAUParameterRecordingObserver
	{
		internal static readonly DAUParameterRecordingObserver Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUParameterRecordingObserver))]
		private unsafe static void Invoke(IntPtr block, nint numberOfEvents, ref AURecordedParameterEvent events)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUParameterRecordingObserver)ptr->Target)?.Invoke(numberOfEvents, ref events);
		}
	}

	internal sealed class NIDAUParameterRecordingObserver : TrampolineBlockBase
	{
		private DAUParameterRecordingObserver invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUParameterRecordingObserver(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUParameterRecordingObserver>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUParameterRecordingObserver? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUParameterRecordingObserver aUParameterRecordingObserver = (AUParameterRecordingObserver)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUParameterRecordingObserver ?? new AUParameterRecordingObserver(new NIDAUParameterRecordingObserver((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint numberOfEvents, ref AURecordedParameterEvent events)
		{
			invoker(base.BlockPointer, numberOfEvents, ref events);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AURenderBlock))]
	internal delegate AudioUnitStatus DAURenderBlock(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, IntPtr outputData, IntPtr pullInputBlock);

	internal static class SDAURenderBlock
	{
		internal static readonly DAURenderBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAURenderBlock))]
		private unsafe static AudioUnitStatus Invoke(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, IntPtr outputData, IntPtr pullInputBlock)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AURenderBlock aURenderBlock = (AURenderBlock)ptr->Target;
			return aURenderBlock(ref actionFlags, ref timestamp, frameCount, outputBusNumber, new AudioBuffers(outputData), NIDAURenderPullInputBlock.Create(pullInputBlock));
		}
	}

	internal sealed class NIDAURenderBlock : TrampolineBlockBase
	{
		private DAURenderBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAURenderBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAURenderBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AURenderBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AURenderBlock aURenderBlock = (AURenderBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aURenderBlock ?? new AURenderBlock(new NIDAURenderBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe AudioUnitStatus Invoke(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, AudioBuffers outputData, [BlockProxy(typeof(NIDAURenderPullInputBlock))] AURenderPullInputBlock? pullInputBlock)
		{
			BlockLiteral* ptr;
			if (pullInputBlock == null)
			{
				ptr = null;
			}
			else
			{
				BlockLiteral blockLiteral = default(BlockLiteral);
				ptr = &blockLiteral;
				blockLiteral.SetupBlockUnsafe(SDAURenderPullInputBlock.Handler, pullInputBlock);
			}
			AudioUnitStatus result = invoker(base.BlockPointer, ref actionFlags, ref timestamp, frameCount, outputBusNumber, outputData?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
			if (ptr != null)
			{
				ptr->CleanupBlock();
			}
			return result;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AURenderPullInputBlock))]
	internal delegate AudioUnitStatus DAURenderPullInputBlock(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber, IntPtr inputData);

	internal static class SDAURenderPullInputBlock
	{
		internal static readonly DAURenderPullInputBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAURenderPullInputBlock))]
		private unsafe static AudioUnitStatus Invoke(IntPtr block, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber, IntPtr inputData)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			AURenderPullInputBlock aURenderPullInputBlock = (AURenderPullInputBlock)ptr->Target;
			return aURenderPullInputBlock(ref actionFlags, ref timestamp, frameCount, inputBusNumber, new AudioBuffers(inputData));
		}
	}

	internal sealed class NIDAURenderPullInputBlock : TrampolineBlockBase
	{
		private DAURenderPullInputBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAURenderPullInputBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAURenderPullInputBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AURenderPullInputBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AURenderPullInputBlock aURenderPullInputBlock = (AURenderPullInputBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aURenderPullInputBlock ?? new AURenderPullInputBlock(new NIDAURenderPullInputBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private AudioUnitStatus Invoke(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber, AudioBuffers inputData)
		{
			return invoker(base.BlockPointer, ref actionFlags, ref timestamp, frameCount, inputBusNumber, inputData?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(AUScheduleParameterBlock))]
	internal delegate void DAUScheduleParameterBlock(IntPtr block, AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value);

	internal static class SDAUScheduleParameterBlock
	{
		internal static readonly DAUScheduleParameterBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAUScheduleParameterBlock))]
		private unsafe static void Invoke(IntPtr block, AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((AUScheduleParameterBlock)ptr->Target)?.Invoke(eventSampleTime, rampDurationSampleFrames, parameterAddress, value);
		}
	}

	internal sealed class NIDAUScheduleParameterBlock : TrampolineBlockBase
	{
		private DAUScheduleParameterBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAUScheduleParameterBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAUScheduleParameterBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static AUScheduleParameterBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			AUScheduleParameterBlock aUScheduleParameterBlock = (AUScheduleParameterBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aUScheduleParameterBlock ?? new AUScheduleParameterBlock(new NIDAUScheduleParameterBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value)
		{
			invoker(base.BlockPointer, eventSampleTime, rampDurationSampleFrames, parameterAddress, value);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ASWebAuthenticationSessionCompletionHandler))]
	internal delegate void DASWebAuthenticationSessionCompletionHandler(IntPtr block, IntPtr callbackUrl, IntPtr error);

	internal static class SDASWebAuthenticationSessionCompletionHandler
	{
		internal static readonly DASWebAuthenticationSessionCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DASWebAuthenticationSessionCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr callbackUrl, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((ASWebAuthenticationSessionCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(callbackUrl), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDASWebAuthenticationSessionCompletionHandler : TrampolineBlockBase
	{
		private DASWebAuthenticationSessionCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDASWebAuthenticationSessionCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DASWebAuthenticationSessionCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ASWebAuthenticationSessionCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ASWebAuthenticationSessionCompletionHandler aSWebAuthenticationSessionCompletionHandler = (ASWebAuthenticationSessionCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return aSWebAuthenticationSessionCompletionHandler ?? new ASWebAuthenticationSessionCompletionHandler(new NIDASWebAuthenticationSessionCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl? callbackUrl, NSError? error)
		{
			invoker(base.BlockPointer, (callbackUrl == null) ? IntPtr.Zero : callbackUrl.Handle, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKAcceptPerShareCompletionHandler))]
	internal delegate void DCKAcceptPerShareCompletionHandler(IntPtr block, IntPtr shareMetadata, IntPtr acceptedShare, IntPtr error);

	internal static class SDCKAcceptPerShareCompletionHandler
	{
		internal static readonly DCKAcceptPerShareCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKAcceptPerShareCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr shareMetadata, IntPtr acceptedShare, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKAcceptPerShareCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKShareMetadata>(shareMetadata), Runtime.GetNSObject<CKShare>(acceptedShare), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCKAcceptPerShareCompletionHandler : TrampolineBlockBase
	{
		private DCKAcceptPerShareCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKAcceptPerShareCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKAcceptPerShareCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKAcceptPerShareCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKAcceptPerShareCompletionHandler cKAcceptPerShareCompletionHandler = (CKAcceptPerShareCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKAcceptPerShareCompletionHandler ?? new CKAcceptPerShareCompletionHandler(new NIDCKAcceptPerShareCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKShareMetadata shareMetadata, CKShare acceptedShare, NSError error)
		{
			invoker(base.BlockPointer, shareMetadata?.Handle ?? IntPtr.Zero, acceptedShare?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKDatabaseDeleteSubscriptionHandler))]
	internal delegate void DCKDatabaseDeleteSubscriptionHandler(IntPtr block, IntPtr subscriptionId, IntPtr error);

	internal static class SDCKDatabaseDeleteSubscriptionHandler
	{
		internal static readonly DCKDatabaseDeleteSubscriptionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKDatabaseDeleteSubscriptionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr subscriptionId, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKDatabaseDeleteSubscriptionHandler)ptr->Target)?.Invoke(NSString.FromHandle(subscriptionId), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCKDatabaseDeleteSubscriptionHandler : TrampolineBlockBase
	{
		private DCKDatabaseDeleteSubscriptionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKDatabaseDeleteSubscriptionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKDatabaseDeleteSubscriptionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKDatabaseDeleteSubscriptionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKDatabaseDeleteSubscriptionHandler cKDatabaseDeleteSubscriptionHandler = (CKDatabaseDeleteSubscriptionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKDatabaseDeleteSubscriptionHandler ?? new CKDatabaseDeleteSubscriptionHandler(new NIDCKDatabaseDeleteSubscriptionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string subscriptionId, NSError error)
		{
			IntPtr intPtr = NSString.CreateNative(subscriptionId);
			invoker(base.BlockPointer, intPtr, error?.Handle ?? IntPtr.Zero);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKDiscoverUserInfosCompletionHandler))]
	internal delegate void DCKDiscoverUserInfosCompletionHandler(IntPtr block, IntPtr emailsToUserInfos, IntPtr userRecordIdsToUserInfos, IntPtr operationError);

	internal static class SDCKDiscoverUserInfosCompletionHandler
	{
		internal static readonly DCKDiscoverUserInfosCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKDiscoverUserInfosCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr emailsToUserInfos, IntPtr userRecordIdsToUserInfos, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKDiscoverUserInfosCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(emailsToUserInfos), Runtime.GetNSObject<NSDictionary>(userRecordIdsToUserInfos), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKDiscoverUserInfosCompletionHandler : TrampolineBlockBase
	{
		private DCKDiscoverUserInfosCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKDiscoverUserInfosCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKDiscoverUserInfosCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKDiscoverUserInfosCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKDiscoverUserInfosCompletionHandler cKDiscoverUserInfosCompletionHandler = (CKDiscoverUserInfosCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKDiscoverUserInfosCompletionHandler ?? new CKDiscoverUserInfosCompletionHandler(new NIDCKDiscoverUserInfosCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary emailsToUserInfos, NSDictionary userRecordIdsToUserInfos, NSError operationError)
		{
			invoker(base.BlockPointer, emailsToUserInfos?.Handle ?? IntPtr.Zero, userRecordIdsToUserInfos?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchDatabaseChangesCompletionHandler))]
	internal delegate void DCKFetchDatabaseChangesCompletionHandler(IntPtr block, IntPtr serverChangeToken, bool moreComing, IntPtr operationError);

	internal static class SDCKFetchDatabaseChangesCompletionHandler
	{
		internal static readonly DCKFetchDatabaseChangesCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchDatabaseChangesCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr serverChangeToken, bool moreComing, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchDatabaseChangesCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKServerChangeToken>(serverChangeToken), moreComing, Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKFetchDatabaseChangesCompletionHandler : TrampolineBlockBase
	{
		private DCKFetchDatabaseChangesCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchDatabaseChangesCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchDatabaseChangesCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchDatabaseChangesCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchDatabaseChangesCompletionHandler cKFetchDatabaseChangesCompletionHandler = (CKFetchDatabaseChangesCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchDatabaseChangesCompletionHandler ?? new CKFetchDatabaseChangesCompletionHandler(new NIDCKFetchDatabaseChangesCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKServerChangeToken serverChangeToken, bool moreComing, NSError operationError)
		{
			invoker(base.BlockPointer, serverChangeToken?.Handle ?? IntPtr.Zero, moreComing, operationError?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchPerShareMetadataHandler))]
	internal delegate void DCKFetchPerShareMetadataHandler(IntPtr block, IntPtr shareURL, IntPtr shareMetadata, IntPtr error);

	internal static class SDCKFetchPerShareMetadataHandler
	{
		internal static readonly DCKFetchPerShareMetadataHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchPerShareMetadataHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr shareURL, IntPtr shareMetadata, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchPerShareMetadataHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(shareURL), Runtime.GetNSObject<CKShareMetadata>(shareMetadata), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCKFetchPerShareMetadataHandler : TrampolineBlockBase
	{
		private DCKFetchPerShareMetadataHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchPerShareMetadataHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchPerShareMetadataHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchPerShareMetadataHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchPerShareMetadataHandler cKFetchPerShareMetadataHandler = (CKFetchPerShareMetadataHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchPerShareMetadataHandler ?? new CKFetchPerShareMetadataHandler(new NIDCKFetchPerShareMetadataHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl shareURL, CKShareMetadata shareMetadata, NSError error)
		{
			invoker(base.BlockPointer, (shareURL == null) ? IntPtr.Zero : shareURL.Handle, shareMetadata?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchRecordChangesHandler))]
	internal delegate void DCKFetchRecordChangesHandler(IntPtr block, IntPtr serverChangeToken, IntPtr clientChangeTokenData, IntPtr operationError);

	internal static class SDCKFetchRecordChangesHandler
	{
		internal static readonly DCKFetchRecordChangesHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchRecordChangesHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr serverChangeToken, IntPtr clientChangeTokenData, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchRecordChangesHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKServerChangeToken>(serverChangeToken), Runtime.GetNSObject<NSData>(clientChangeTokenData), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKFetchRecordChangesHandler : TrampolineBlockBase
	{
		private DCKFetchRecordChangesHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchRecordChangesHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchRecordChangesHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchRecordChangesHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchRecordChangesHandler cKFetchRecordChangesHandler = (CKFetchRecordChangesHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchRecordChangesHandler ?? new CKFetchRecordChangesHandler(new NIDCKFetchRecordChangesHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKServerChangeToken serverChangeToken, NSData clientChangeTokenData, NSError operationError)
		{
			invoker(base.BlockPointer, serverChangeToken?.Handle ?? IntPtr.Zero, clientChangeTokenData?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchRecordZoneChangesFetchCompletedHandler))]
	internal delegate void DCKFetchRecordZoneChangesFetchCompletedHandler(IntPtr block, IntPtr recordZoneID, IntPtr serverChangeToken, IntPtr clientChangeTokenData, bool moreComing, IntPtr recordZoneError);

	internal static class SDCKFetchRecordZoneChangesFetchCompletedHandler
	{
		internal static readonly DCKFetchRecordZoneChangesFetchCompletedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchRecordZoneChangesFetchCompletedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr recordZoneID, IntPtr serverChangeToken, IntPtr clientChangeTokenData, bool moreComing, IntPtr recordZoneError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchRecordZoneChangesFetchCompletedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordZoneID>(recordZoneID), Runtime.GetNSObject<CKServerChangeToken>(serverChangeToken), Runtime.GetNSObject<NSData>(clientChangeTokenData), moreComing, Runtime.GetNSObject<NSError>(recordZoneError));
		}
	}

	internal sealed class NIDCKFetchRecordZoneChangesFetchCompletedHandler : TrampolineBlockBase
	{
		private DCKFetchRecordZoneChangesFetchCompletedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchRecordZoneChangesFetchCompletedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchRecordZoneChangesFetchCompletedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchRecordZoneChangesFetchCompletedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchRecordZoneChangesFetchCompletedHandler cKFetchRecordZoneChangesFetchCompletedHandler = (CKFetchRecordZoneChangesFetchCompletedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchRecordZoneChangesFetchCompletedHandler ?? new CKFetchRecordZoneChangesFetchCompletedHandler(new NIDCKFetchRecordZoneChangesFetchCompletedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZoneID recordZoneID, CKServerChangeToken serverChangeToken, NSData clientChangeTokenData, bool moreComing, NSError recordZoneError)
		{
			invoker(base.BlockPointer, recordZoneID?.Handle ?? IntPtr.Zero, serverChangeToken?.Handle ?? IntPtr.Zero, clientChangeTokenData?.Handle ?? IntPtr.Zero, moreComing, recordZoneError?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchRecordZoneChangesTokensUpdatedHandler))]
	internal delegate void DCKFetchRecordZoneChangesTokensUpdatedHandler(IntPtr block, IntPtr recordZoneID, IntPtr serverChangeToken, IntPtr clientChangeTokenData);

	internal static class SDCKFetchRecordZoneChangesTokensUpdatedHandler
	{
		internal static readonly DCKFetchRecordZoneChangesTokensUpdatedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchRecordZoneChangesTokensUpdatedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr recordZoneID, IntPtr serverChangeToken, IntPtr clientChangeTokenData)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchRecordZoneChangesTokensUpdatedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordZoneID>(recordZoneID), Runtime.GetNSObject<CKServerChangeToken>(serverChangeToken), Runtime.GetNSObject<NSData>(clientChangeTokenData));
		}
	}

	internal sealed class NIDCKFetchRecordZoneChangesTokensUpdatedHandler : TrampolineBlockBase
	{
		private DCKFetchRecordZoneChangesTokensUpdatedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchRecordZoneChangesTokensUpdatedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchRecordZoneChangesTokensUpdatedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchRecordZoneChangesTokensUpdatedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchRecordZoneChangesTokensUpdatedHandler cKFetchRecordZoneChangesTokensUpdatedHandler = (CKFetchRecordZoneChangesTokensUpdatedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchRecordZoneChangesTokensUpdatedHandler ?? new CKFetchRecordZoneChangesTokensUpdatedHandler(new NIDCKFetchRecordZoneChangesTokensUpdatedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZoneID recordZoneID, CKServerChangeToken serverChangeToken, NSData clientChangeTokenData)
		{
			invoker(base.BlockPointer, recordZoneID?.Handle ?? IntPtr.Zero, serverChangeToken?.Handle ?? IntPtr.Zero, clientChangeTokenData?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchRecordZoneChangesWithIDWasDeletedHandler))]
	internal delegate void DCKFetchRecordZoneChangesWithIDWasDeletedHandler(IntPtr block, IntPtr recordID, IntPtr recordType);

	internal static class SDCKFetchRecordZoneChangesWithIDWasDeletedHandler
	{
		internal static readonly DCKFetchRecordZoneChangesWithIDWasDeletedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchRecordZoneChangesWithIDWasDeletedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr recordID, IntPtr recordType)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchRecordZoneChangesWithIDWasDeletedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordID>(recordID), Runtime.GetNSObject<NSString>(recordType));
		}
	}

	internal sealed class NIDCKFetchRecordZoneChangesWithIDWasDeletedHandler : TrampolineBlockBase
	{
		private DCKFetchRecordZoneChangesWithIDWasDeletedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchRecordZoneChangesWithIDWasDeletedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchRecordZoneChangesWithIDWasDeletedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchRecordZoneChangesWithIDWasDeletedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchRecordZoneChangesWithIDWasDeletedHandler cKFetchRecordZoneChangesWithIDWasDeletedHandler = (CKFetchRecordZoneChangesWithIDWasDeletedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchRecordZoneChangesWithIDWasDeletedHandler ?? new CKFetchRecordZoneChangesWithIDWasDeletedHandler(new NIDCKFetchRecordZoneChangesWithIDWasDeletedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordID recordID, NSString recordType)
		{
			invoker(base.BlockPointer, recordID?.Handle ?? IntPtr.Zero, (recordType == null) ? IntPtr.Zero : recordType.Handle);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchRecordsCompletedHandler))]
	internal delegate void DCKFetchRecordsCompletedHandler(IntPtr block, IntPtr recordsByRecordId, IntPtr error);

	internal static class SDCKFetchRecordsCompletedHandler
	{
		internal static readonly DCKFetchRecordsCompletedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchRecordsCompletedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr recordsByRecordId, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchRecordsCompletedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(recordsByRecordId), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCKFetchRecordsCompletedHandler : TrampolineBlockBase
	{
		private DCKFetchRecordsCompletedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchRecordsCompletedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchRecordsCompletedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchRecordsCompletedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchRecordsCompletedHandler cKFetchRecordsCompletedHandler = (CKFetchRecordsCompletedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchRecordsCompletedHandler ?? new CKFetchRecordsCompletedHandler(new NIDCKFetchRecordsCompletedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary recordsByRecordId, NSError error)
		{
			invoker(base.BlockPointer, recordsByRecordId?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchSubscriptionsCompleteHandler))]
	internal delegate void DCKFetchSubscriptionsCompleteHandler(IntPtr block, IntPtr subscriptionsBySubscriptionId, IntPtr operationError);

	internal static class SDCKFetchSubscriptionsCompleteHandler
	{
		internal static readonly DCKFetchSubscriptionsCompleteHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchSubscriptionsCompleteHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr subscriptionsBySubscriptionId, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchSubscriptionsCompleteHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(subscriptionsBySubscriptionId), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKFetchSubscriptionsCompleteHandler : TrampolineBlockBase
	{
		private DCKFetchSubscriptionsCompleteHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchSubscriptionsCompleteHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchSubscriptionsCompleteHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchSubscriptionsCompleteHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchSubscriptionsCompleteHandler cKFetchSubscriptionsCompleteHandler = (CKFetchSubscriptionsCompleteHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchSubscriptionsCompleteHandler ?? new CKFetchSubscriptionsCompleteHandler(new NIDCKFetchSubscriptionsCompleteHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary subscriptionsBySubscriptionId, NSError operationError)
		{
			invoker(base.BlockPointer, subscriptionsBySubscriptionId?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKFetchWebAuthTokenOperationHandler))]
	internal delegate void DCKFetchWebAuthTokenOperationHandler(IntPtr block, IntPtr webAuthToken, IntPtr operationError);

	internal static class SDCKFetchWebAuthTokenOperationHandler
	{
		internal static readonly DCKFetchWebAuthTokenOperationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKFetchWebAuthTokenOperationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr webAuthToken, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKFetchWebAuthTokenOperationHandler)ptr->Target)?.Invoke(NSString.FromHandle(webAuthToken), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKFetchWebAuthTokenOperationHandler : TrampolineBlockBase
	{
		private DCKFetchWebAuthTokenOperationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKFetchWebAuthTokenOperationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKFetchWebAuthTokenOperationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKFetchWebAuthTokenOperationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKFetchWebAuthTokenOperationHandler cKFetchWebAuthTokenOperationHandler = (CKFetchWebAuthTokenOperationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKFetchWebAuthTokenOperationHandler ?? new CKFetchWebAuthTokenOperationHandler(new NIDCKFetchWebAuthTokenOperationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string webAuthToken, NSError operationError)
		{
			IntPtr intPtr = NSString.CreateNative(webAuthToken);
			invoker(base.BlockPointer, intPtr, operationError?.Handle ?? IntPtr.Zero);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKMarkNotificationsReadHandler))]
	internal delegate void DCKMarkNotificationsReadHandler(IntPtr block, IntPtr notificationIDsMarkedRead, IntPtr operationError);

	internal static class SDCKMarkNotificationsReadHandler
	{
		internal static readonly DCKMarkNotificationsReadHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKMarkNotificationsReadHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr notificationIDsMarkedRead, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKMarkNotificationsReadHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKNotificationID>(notificationIDsMarkedRead), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKMarkNotificationsReadHandler : TrampolineBlockBase
	{
		private DCKMarkNotificationsReadHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKMarkNotificationsReadHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKMarkNotificationsReadHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKMarkNotificationsReadHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKMarkNotificationsReadHandler cKMarkNotificationsReadHandler = (CKMarkNotificationsReadHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKMarkNotificationsReadHandler ?? new CKMarkNotificationsReadHandler(new NIDCKMarkNotificationsReadHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKNotificationID[] notificationIDsMarkedRead, NSError operationError)
		{
			NSArray nSArray = ((notificationIDsMarkedRead == null) ? null : NSArray.FromNSObjects(notificationIDsMarkedRead));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKModifyRecordZonesHandler))]
	internal delegate void DCKModifyRecordZonesHandler(IntPtr block, IntPtr savedRecordZones, IntPtr deletedRecordZoneIds, IntPtr operationError);

	internal static class SDCKModifyRecordZonesHandler
	{
		internal static readonly DCKModifyRecordZonesHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKModifyRecordZonesHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr savedRecordZones, IntPtr deletedRecordZoneIds, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKModifyRecordZonesHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKRecordZone>(savedRecordZones), NSArray.ArrayFromHandle<CKRecordZoneID>(deletedRecordZoneIds), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKModifyRecordZonesHandler : TrampolineBlockBase
	{
		private DCKModifyRecordZonesHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKModifyRecordZonesHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKModifyRecordZonesHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKModifyRecordZonesHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKModifyRecordZonesHandler cKModifyRecordZonesHandler = (CKModifyRecordZonesHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKModifyRecordZonesHandler ?? new CKModifyRecordZonesHandler(new NIDCKModifyRecordZonesHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZone[] savedRecordZones, CKRecordZoneID[] deletedRecordZoneIds, NSError operationError)
		{
			NSArray nSArray = ((savedRecordZones == null) ? null : NSArray.FromNSObjects(savedRecordZones));
			NSArray nSArray2 = ((deletedRecordZoneIds == null) ? null : NSArray.FromNSObjects(deletedRecordZoneIds));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKModifyRecordsOperationHandler))]
	internal delegate void DCKModifyRecordsOperationHandler(IntPtr block, IntPtr savedRecords, IntPtr deletedRecordIds, IntPtr operationError);

	internal static class SDCKModifyRecordsOperationHandler
	{
		internal static readonly DCKModifyRecordsOperationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKModifyRecordsOperationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr savedRecords, IntPtr deletedRecordIds, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKModifyRecordsOperationHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKRecord>(savedRecords), NSArray.ArrayFromHandle<CKRecordID>(deletedRecordIds), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKModifyRecordsOperationHandler : TrampolineBlockBase
	{
		private DCKModifyRecordsOperationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKModifyRecordsOperationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKModifyRecordsOperationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKModifyRecordsOperationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKModifyRecordsOperationHandler cKModifyRecordsOperationHandler = (CKModifyRecordsOperationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKModifyRecordsOperationHandler ?? new CKModifyRecordsOperationHandler(new NIDCKModifyRecordsOperationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecord[] savedRecords, CKRecordID[] deletedRecordIds, NSError operationError)
		{
			NSArray nSArray = ((savedRecords == null) ? null : NSArray.FromNSObjects(savedRecords));
			NSArray nSArray2 = ((deletedRecordIds == null) ? null : NSArray.FromNSObjects(deletedRecordIds));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKModifySubscriptionsHandler))]
	internal delegate void DCKModifySubscriptionsHandler(IntPtr block, IntPtr savedSubscriptions, IntPtr deletedSubscriptionIds, IntPtr operationError);

	internal static class SDCKModifySubscriptionsHandler
	{
		internal static readonly DCKModifySubscriptionsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKModifySubscriptionsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr savedSubscriptions, IntPtr deletedSubscriptionIds, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKModifySubscriptionsHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKSubscription>(savedSubscriptions), NSArray.StringArrayFromHandle(deletedSubscriptionIds), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKModifySubscriptionsHandler : TrampolineBlockBase
	{
		private DCKModifySubscriptionsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKModifySubscriptionsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKModifySubscriptionsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKModifySubscriptionsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKModifySubscriptionsHandler cKModifySubscriptionsHandler = (CKModifySubscriptionsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKModifySubscriptionsHandler ?? new CKModifySubscriptionsHandler(new NIDCKModifySubscriptionsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKSubscription[] savedSubscriptions, string[] deletedSubscriptionIds, NSError operationError)
		{
			NSArray nSArray = ((savedSubscriptions == null) ? null : NSArray.FromNSObjects(savedSubscriptions));
			NSArray nSArray2 = ((deletedSubscriptionIds == null) ? null : NSArray.FromStrings(deletedSubscriptionIds));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CKRecordZoneCompleteHandler))]
	internal delegate void DCKRecordZoneCompleteHandler(IntPtr block, IntPtr recordZonesByZoneId, IntPtr operationError);

	internal static class SDCKRecordZoneCompleteHandler
	{
		internal static readonly DCKRecordZoneCompleteHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCKRecordZoneCompleteHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr recordZonesByZoneId, IntPtr operationError)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CKRecordZoneCompleteHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(recordZonesByZoneId), Runtime.GetNSObject<NSError>(operationError));
		}
	}

	internal sealed class NIDCKRecordZoneCompleteHandler : TrampolineBlockBase
	{
		private DCKRecordZoneCompleteHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCKRecordZoneCompleteHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCKRecordZoneCompleteHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CKRecordZoneCompleteHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CKRecordZoneCompleteHandler cKRecordZoneCompleteHandler = (CKRecordZoneCompleteHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cKRecordZoneCompleteHandler ?? new CKRecordZoneCompleteHandler(new NIDCKRecordZoneCompleteHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary recordZonesByZoneId, NSError operationError)
		{
			invoker(base.BlockPointer, recordZonesByZoneId?.Handle ?? IntPtr.Zero, operationError?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CNContactStoreEnumerateContactsHandler))]
	internal delegate void DCNContactStoreEnumerateContactsHandler(IntPtr block, IntPtr contact, bool stop);

	internal static class SDCNContactStoreEnumerateContactsHandler
	{
		internal static readonly DCNContactStoreEnumerateContactsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCNContactStoreEnumerateContactsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr contact, bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CNContactStoreEnumerateContactsHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CNContact>(contact), stop);
		}
	}

	internal sealed class NIDCNContactStoreEnumerateContactsHandler : TrampolineBlockBase
	{
		private DCNContactStoreEnumerateContactsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCNContactStoreEnumerateContactsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCNContactStoreEnumerateContactsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CNContactStoreEnumerateContactsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CNContactStoreEnumerateContactsHandler cNContactStoreEnumerateContactsHandler = (CNContactStoreEnumerateContactsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cNContactStoreEnumerateContactsHandler ?? new CNContactStoreEnumerateContactsHandler(new NIDCNContactStoreEnumerateContactsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CNContact contact, bool stop)
		{
			invoker(base.BlockPointer, contact?.Handle ?? IntPtr.Zero, stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CNContactStoreListContactsHandler))]
	internal delegate void DCNContactStoreListContactsHandler(IntPtr block, IntPtr contact, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDCNContactStoreListContactsHandler
	{
		internal static readonly DCNContactStoreListContactsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCNContactStoreListContactsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr contact, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CNContactStoreListContactsHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CNContact>(contact), ref stop);
		}
	}

	internal sealed class NIDCNContactStoreListContactsHandler : TrampolineBlockBase
	{
		private DCNContactStoreListContactsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCNContactStoreListContactsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCNContactStoreListContactsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CNContactStoreListContactsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CNContactStoreListContactsHandler cNContactStoreListContactsHandler = (CNContactStoreListContactsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cNContactStoreListContactsHandler ?? new CNContactStoreListContactsHandler(new NIDCNContactStoreListContactsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CNContact contact, ref bool stop)
		{
			invoker(base.BlockPointer, contact?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CNContactStoreRequestAccessHandler))]
	internal delegate void DCNContactStoreRequestAccessHandler(IntPtr block, bool granted, IntPtr error);

	internal static class SDCNContactStoreRequestAccessHandler
	{
		internal static readonly DCNContactStoreRequestAccessHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCNContactStoreRequestAccessHandler))]
		private unsafe static void Invoke(IntPtr block, bool granted, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CNContactStoreRequestAccessHandler)ptr->Target)?.Invoke(granted, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCNContactStoreRequestAccessHandler : TrampolineBlockBase
	{
		private DCNContactStoreRequestAccessHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCNContactStoreRequestAccessHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCNContactStoreRequestAccessHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CNContactStoreRequestAccessHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CNContactStoreRequestAccessHandler cNContactStoreRequestAccessHandler = (CNContactStoreRequestAccessHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cNContactStoreRequestAccessHandler ?? new CNContactStoreRequestAccessHandler(new NIDCNContactStoreRequestAccessHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool granted, NSError error)
		{
			invoker(base.BlockPointer, granted, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CIKernelRoiCallback))]
	internal delegate CGRect DCIKernelRoiCallback(IntPtr block, int index, CGRect rect);

	internal static class SDCIKernelRoiCallback
	{
		internal static readonly DCIKernelRoiCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCIKernelRoiCallback))]
		private unsafe static CGRect Invoke(IntPtr block, int index, CGRect rect)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			CIKernelRoiCallback cIKernelRoiCallback = (CIKernelRoiCallback)ptr->Target;
			return cIKernelRoiCallback(index, rect);
		}
	}

	internal sealed class NIDCIKernelRoiCallback : TrampolineBlockBase
	{
		private DCIKernelRoiCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCIKernelRoiCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCIKernelRoiCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CIKernelRoiCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CIKernelRoiCallback cIKernelRoiCallback = (CIKernelRoiCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cIKernelRoiCallback ?? new CIKernelRoiCallback(new NIDCIKernelRoiCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private CGRect Invoke(int index, CGRect rect)
		{
			return invoker(base.BlockPointer, index, rect);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CLGeocodeCompletionHandler))]
	internal delegate void DCLGeocodeCompletionHandler(IntPtr block, IntPtr placemarks, IntPtr error);

	internal static class SDCLGeocodeCompletionHandler
	{
		internal static readonly DCLGeocodeCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCLGeocodeCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr placemarks, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CLGeocodeCompletionHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CLPlacemark>(placemarks), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCLGeocodeCompletionHandler : TrampolineBlockBase
	{
		private DCLGeocodeCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCLGeocodeCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCLGeocodeCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CLGeocodeCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CLGeocodeCompletionHandler cLGeocodeCompletionHandler = (CLGeocodeCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cLGeocodeCompletionHandler ?? new CLGeocodeCompletionHandler(new NIDCLGeocodeCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CLPlacemark[] placemarks, NSError error)
		{
			NSArray nSArray = ((placemarks == null) ? null : NSArray.FromNSObjects(placemarks));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MidiCIProfileChangedHandler))]
	internal delegate void DMidiCIProfileChangedHandler(IntPtr block, IntPtr session, byte channel, IntPtr profile, bool enabled);

	internal static class SDMidiCIProfileChangedHandler
	{
		internal static readonly DMidiCIProfileChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMidiCIProfileChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr session, byte channel, IntPtr profile, bool enabled)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MidiCIProfileChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MidiCISession>(session), channel, Runtime.GetNSObject<MidiCIProfile>(profile), enabled);
		}
	}

	internal sealed class NIDMidiCIProfileChangedHandler : TrampolineBlockBase
	{
		private DMidiCIProfileChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMidiCIProfileChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMidiCIProfileChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MidiCIProfileChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MidiCIProfileChangedHandler midiCIProfileChangedHandler = (MidiCIProfileChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return midiCIProfileChangedHandler ?? new MidiCIProfileChangedHandler(new NIDMidiCIProfileChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MidiCISession session, byte channel, MidiCIProfile profile, bool enabled)
		{
			invoker(base.BlockPointer, session?.Handle ?? IntPtr.Zero, channel, profile?.Handle ?? IntPtr.Zero, enabled);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MidiCIPropertyChangedHandler))]
	internal delegate void DMidiCIPropertyChangedHandler(IntPtr block, IntPtr session, byte channel, IntPtr data);

	internal static class SDMidiCIPropertyChangedHandler
	{
		internal static readonly DMidiCIPropertyChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMidiCIPropertyChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr session, byte channel, IntPtr data)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MidiCIPropertyChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MidiCISession>(session), channel, Runtime.GetNSObject<NSData>(data));
		}
	}

	internal sealed class NIDMidiCIPropertyChangedHandler : TrampolineBlockBase
	{
		private DMidiCIPropertyChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMidiCIPropertyChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMidiCIPropertyChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MidiCIPropertyChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MidiCIPropertyChangedHandler midiCIPropertyChangedHandler = (MidiCIPropertyChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return midiCIPropertyChangedHandler ?? new MidiCIPropertyChangedHandler(new NIDMidiCIPropertyChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MidiCISession session, byte channel, NSData data)
		{
			invoker(base.BlockPointer, session?.Handle ?? IntPtr.Zero, channel, data?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MidiCIPropertyResponseHandler))]
	internal delegate void DMidiCIPropertyResponseHandler(IntPtr block, IntPtr session, byte channel, IntPtr response, IntPtr error);

	internal static class SDMidiCIPropertyResponseHandler
	{
		internal static readonly DMidiCIPropertyResponseHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMidiCIPropertyResponseHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr session, byte channel, IntPtr response, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MidiCIPropertyResponseHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MidiCISession>(session), channel, Runtime.GetNSObject<NSData>(response), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMidiCIPropertyResponseHandler : TrampolineBlockBase
	{
		private DMidiCIPropertyResponseHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMidiCIPropertyResponseHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMidiCIPropertyResponseHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MidiCIPropertyResponseHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MidiCIPropertyResponseHandler midiCIPropertyResponseHandler = (MidiCIPropertyResponseHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return midiCIPropertyResponseHandler ?? new MidiCIPropertyResponseHandler(new NIDMidiCIPropertyResponseHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MidiCISession session, byte channel, NSData response, NSError error)
		{
			invoker(base.BlockPointer, session?.Handle ?? IntPtr.Zero, channel, response?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CSSearchableIndexFetchHandler))]
	internal delegate void DCSSearchableIndexFetchHandler(IntPtr block, IntPtr clientState, IntPtr error);

	internal static class SDCSSearchableIndexFetchHandler
	{
		internal static readonly DCSSearchableIndexFetchHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCSSearchableIndexFetchHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr clientState, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CSSearchableIndexFetchHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(clientState), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCSSearchableIndexFetchHandler : TrampolineBlockBase
	{
		private DCSSearchableIndexFetchHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCSSearchableIndexFetchHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCSSearchableIndexFetchHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CSSearchableIndexFetchHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CSSearchableIndexFetchHandler cSSearchableIndexFetchHandler = (CSSearchableIndexFetchHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cSSearchableIndexFetchHandler ?? new CSSearchableIndexFetchHandler(new NIDCSSearchableIndexFetchHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData clientState, NSError error)
		{
			invoker(base.BlockPointer, clientState?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(DCDeviceGenerateTokenCompletionHandler))]
	internal delegate void DDCDeviceGenerateTokenCompletionHandler(IntPtr block, IntPtr token, IntPtr error);

	internal static class SDDCDeviceGenerateTokenCompletionHandler
	{
		internal static readonly DDCDeviceGenerateTokenCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DDCDeviceGenerateTokenCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr token, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((DCDeviceGenerateTokenCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(token), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDDCDeviceGenerateTokenCompletionHandler : TrampolineBlockBase
	{
		private DDCDeviceGenerateTokenCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDDCDeviceGenerateTokenCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DDCDeviceGenerateTokenCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static DCDeviceGenerateTokenCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			DCDeviceGenerateTokenCompletionHandler dCDeviceGenerateTokenCompletionHandler = (DCDeviceGenerateTokenCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return dCDeviceGenerateTokenCompletionHandler ?? new DCDeviceGenerateTokenCompletionHandler(new NIDDCDeviceGenerateTokenCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData? token, NSError? error)
		{
			invoker(base.BlockPointer, token?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(EKEventSearchCallback))]
	internal delegate void DEKEventSearchCallback(IntPtr block, IntPtr theEvent, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDEKEventSearchCallback
	{
		internal static readonly DEKEventSearchCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DEKEventSearchCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr theEvent, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((EKEventSearchCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<EKEvent>(theEvent), ref stop);
		}
	}

	internal sealed class NIDEKEventSearchCallback : TrampolineBlockBase
	{
		private DEKEventSearchCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDEKEventSearchCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DEKEventSearchCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static EKEventSearchCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			EKEventSearchCallback eKEventSearchCallback = (EKEventSearchCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return eKEventSearchCallback ?? new EKEventSearchCallback(new NIDEKEventSearchCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(EKEvent theEvent, ref bool stop)
		{
			invoker(base.BlockPointer, theEvent?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GetValuesCompletionHandler))]
	internal delegate void DGetValuesCompletionHandler(IntPtr block, IntPtr values, IntPtr error);

	internal static class SDGetValuesCompletionHandler
	{
		internal static readonly DGetValuesCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGetValuesCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr values, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GetValuesCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(values), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGetValuesCompletionHandler : TrampolineBlockBase
	{
		private DGetValuesCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGetValuesCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGetValuesCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GetValuesCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GetValuesCompletionHandler getValuesCompletionHandler = (GetValuesCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return getValuesCompletionHandler ?? new GetValuesCompletionHandler(new NIDGetValuesCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary<NSString, NSObject> values, NSError error)
		{
			invoker(base.BlockPointer, values?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CloudKitRegistrationPreparationAction))]
	internal delegate void DCloudKitRegistrationPreparationAction(IntPtr block, IntPtr handler);

	internal static class SDCloudKitRegistrationPreparationAction
	{
		internal static readonly DCloudKitRegistrationPreparationAction Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCloudKitRegistrationPreparationAction))]
		private unsafe static void Invoke(IntPtr block, IntPtr handler)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CloudKitRegistrationPreparationAction)ptr->Target)?.Invoke(NIDCloudKitRegistrationPreparationHandler.Create(handler));
		}
	}

	internal sealed class NIDCloudKitRegistrationPreparationAction : TrampolineBlockBase
	{
		private DCloudKitRegistrationPreparationAction invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCloudKitRegistrationPreparationAction(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCloudKitRegistrationPreparationAction>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CloudKitRegistrationPreparationAction? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CloudKitRegistrationPreparationAction cloudKitRegistrationPreparationAction = (CloudKitRegistrationPreparationAction)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cloudKitRegistrationPreparationAction ?? new CloudKitRegistrationPreparationAction(new NIDCloudKitRegistrationPreparationAction((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke([BlockProxy(typeof(NIDCloudKitRegistrationPreparationHandler))] CloudKitRegistrationPreparationHandler handler)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDCloudKitRegistrationPreparationHandler.Handler, handler);
			invoker(base.BlockPointer, (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(EnumerateDatesCallback))]
	internal delegate void DEnumerateDatesCallback(IntPtr block, IntPtr date, bool exactMatch, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDEnumerateDatesCallback
	{
		internal static readonly DEnumerateDatesCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DEnumerateDatesCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr date, bool exactMatch, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((EnumerateDatesCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDate>(date), exactMatch, ref stop);
		}
	}

	internal sealed class NIDEnumerateDatesCallback : TrampolineBlockBase
	{
		private DEnumerateDatesCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDEnumerateDatesCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DEnumerateDatesCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static EnumerateDatesCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			EnumerateDatesCallback enumerateDatesCallback = (EnumerateDatesCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return enumerateDatesCallback ?? new EnumerateDatesCallback(new NIDEnumerateDatesCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDate date, bool exactMatch, ref bool stop)
		{
			invoker(base.BlockPointer, date?.Handle ?? IntPtr.Zero, exactMatch, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(EnumerateIndexSetCallback))]
	internal delegate void DEnumerateIndexSetCallback(IntPtr block, nuint idx, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDEnumerateIndexSetCallback
	{
		internal static readonly DEnumerateIndexSetCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DEnumerateIndexSetCallback))]
		private unsafe static void Invoke(IntPtr block, nuint idx, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((EnumerateIndexSetCallback)ptr->Target)?.Invoke(idx, ref stop);
		}
	}

	internal sealed class NIDEnumerateIndexSetCallback : TrampolineBlockBase
	{
		private DEnumerateIndexSetCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDEnumerateIndexSetCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DEnumerateIndexSetCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static EnumerateIndexSetCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			EnumerateIndexSetCallback enumerateIndexSetCallback = (EnumerateIndexSetCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return enumerateIndexSetCallback ?? new EnumerateIndexSetCallback(new NIDEnumerateIndexSetCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nuint idx, ref bool stop)
		{
			invoker(base.BlockPointer, idx, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(LinguisticTagEnumerator))]
	internal delegate void DLinguisticTagEnumerator(IntPtr block, IntPtr tag, NSRange tokenRange, bool stop);

	internal static class SDLinguisticTagEnumerator
	{
		internal static readonly DLinguisticTagEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DLinguisticTagEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr tag, NSRange tokenRange, bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((LinguisticTagEnumerator)ptr->Target)?.Invoke(NSString.FromHandle(tag), tokenRange, stop);
		}
	}

	internal sealed class NIDLinguisticTagEnumerator : TrampolineBlockBase
	{
		private DLinguisticTagEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDLinguisticTagEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DLinguisticTagEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static LinguisticTagEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			LinguisticTagEnumerator linguisticTagEnumerator = (LinguisticTagEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return linguisticTagEnumerator ?? new LinguisticTagEnumerator(new NIDLinguisticTagEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string tag, NSRange tokenRange, bool stop)
		{
			IntPtr intPtr = NSString.CreateNative(tag);
			invoker(base.BlockPointer, intPtr, tokenRange, stop);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(LoadInPlaceFileRepresentationHandler))]
	internal delegate void DLoadInPlaceFileRepresentationHandler(IntPtr block, IntPtr fileUrl, bool isInPlace, IntPtr error);

	internal static class SDLoadInPlaceFileRepresentationHandler
	{
		internal static readonly DLoadInPlaceFileRepresentationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DLoadInPlaceFileRepresentationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr fileUrl, bool isInPlace, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((LoadInPlaceFileRepresentationHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(fileUrl), isInPlace, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDLoadInPlaceFileRepresentationHandler : TrampolineBlockBase
	{
		private DLoadInPlaceFileRepresentationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDLoadInPlaceFileRepresentationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DLoadInPlaceFileRepresentationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static LoadInPlaceFileRepresentationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			LoadInPlaceFileRepresentationHandler loadInPlaceFileRepresentationHandler = (LoadInPlaceFileRepresentationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return loadInPlaceFileRepresentationHandler ?? new LoadInPlaceFileRepresentationHandler(new NIDLoadInPlaceFileRepresentationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl fileUrl, bool isInPlace, NSError error)
		{
			invoker(base.BlockPointer, (fileUrl == null) ? IntPtr.Zero : fileUrl.Handle, isInPlace, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSAttributedRangeCallback))]
	internal delegate void DNSAttributedRangeCallback(IntPtr block, IntPtr attrs, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSAttributedRangeCallback
	{
		internal static readonly DNSAttributedRangeCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSAttributedRangeCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr attrs, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSAttributedRangeCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(attrs), range, ref stop);
		}
	}

	internal sealed class NIDNSAttributedRangeCallback : TrampolineBlockBase
	{
		private DNSAttributedRangeCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSAttributedRangeCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSAttributedRangeCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSAttributedRangeCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSAttributedRangeCallback nSAttributedRangeCallback = (NSAttributedRangeCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSAttributedRangeCallback ?? new NSAttributedRangeCallback(new NIDNSAttributedRangeCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary attrs, NSRange range, ref bool stop)
		{
			invoker(base.BlockPointer, attrs?.Handle ?? IntPtr.Zero, range, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSAttributedStringCallback))]
	internal delegate void DNSAttributedStringCallback(IntPtr block, IntPtr value, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSAttributedStringCallback
	{
		internal static readonly DNSAttributedStringCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSAttributedStringCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr value, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSAttributedStringCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(value), range, ref stop);
		}
	}

	internal sealed class NIDNSAttributedStringCallback : TrampolineBlockBase
	{
		private DNSAttributedStringCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSAttributedStringCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSAttributedStringCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSAttributedStringCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSAttributedStringCallback nSAttributedStringCallback = (NSAttributedStringCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSAttributedStringCallback ?? new NSAttributedStringCallback(new NIDNSAttributedStringCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject value, NSRange range, ref bool stop)
		{
			invoker(base.BlockPointer, value?.Handle ?? IntPtr.Zero, range, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSAttributedStringCompletionHandler))]
	internal delegate void DNSAttributedStringCompletionHandler(IntPtr block, IntPtr attributedString, IntPtr attributes, IntPtr error);

	internal static class SDNSAttributedStringCompletionHandler
	{
		internal static readonly DNSAttributedStringCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSAttributedStringCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr attributedString, IntPtr attributes, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSAttributedStringCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSAttributedString>(attributedString), Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(attributes), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSAttributedStringCompletionHandler : TrampolineBlockBase
	{
		private DNSAttributedStringCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSAttributedStringCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSAttributedStringCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSAttributedStringCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSAttributedStringCompletionHandler nSAttributedStringCompletionHandler = (NSAttributedStringCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSAttributedStringCompletionHandler ?? new NSAttributedStringCompletionHandler(new NIDNSAttributedStringCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSAttributedString? attributedString, NSDictionary<NSString, NSObject>? attributes, NSError? error)
		{
			invoker(base.BlockPointer, attributedString?.Handle ?? IntPtr.Zero, attributes?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSBackgroundActivityCompletionAction))]
	internal delegate void DNSBackgroundActivityCompletionAction(IntPtr block, IntPtr handler);

	internal static class SDNSBackgroundActivityCompletionAction
	{
		internal static readonly DNSBackgroundActivityCompletionAction Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSBackgroundActivityCompletionAction))]
		private unsafe static void Invoke(IntPtr block, IntPtr handler)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSBackgroundActivityCompletionAction)ptr->Target)?.Invoke(NIDNSBackgroundActivityCompletionHandler.Create(handler));
		}
	}

	internal sealed class NIDNSBackgroundActivityCompletionAction : TrampolineBlockBase
	{
		private DNSBackgroundActivityCompletionAction invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSBackgroundActivityCompletionAction(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSBackgroundActivityCompletionAction>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSBackgroundActivityCompletionAction? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSBackgroundActivityCompletionAction nSBackgroundActivityCompletionAction = (NSBackgroundActivityCompletionAction)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSBackgroundActivityCompletionAction ?? new NSBackgroundActivityCompletionAction(new NIDNSBackgroundActivityCompletionAction((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke([BlockProxy(typeof(NIDNSBackgroundActivityCompletionHandler))] NSBackgroundActivityCompletionHandler handler)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDNSBackgroundActivityCompletionHandler.Handler, handler);
			invoker(base.BlockPointer, (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSComparator))]
	internal delegate IntPtr DNSComparator(IntPtr block, IntPtr obj1, IntPtr obj2);

	internal static class SDNSComparator
	{
		internal static readonly DNSComparator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSComparator))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr obj1, IntPtr obj2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSComparator nSComparator = (NSComparator)ptr->Target;
			NSComparisonResult nSComparisonResult = nSComparator(Runtime.GetNSObject<NSObject>(obj1), Runtime.GetNSObject<NSObject>(obj2));
			return (IntPtr)(long)nSComparisonResult;
		}
	}

	internal sealed class NIDNSComparator : TrampolineBlockBase
	{
		private DNSComparator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSComparator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSComparator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSComparator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSComparator nSComparator = (NSComparator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSComparator ?? new NSComparator(new NIDNSComparator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSComparisonResult Invoke(NSObject obj1, NSObject obj2)
		{
			return (NSComparisonResult)(long)invoker(base.BlockPointer, obj1?.Handle ?? IntPtr.Zero, obj2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSDataByteRangeEnumerator))]
	internal delegate void DNSDataByteRangeEnumerator(IntPtr block, IntPtr bytes, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSDataByteRangeEnumerator
	{
		internal static readonly DNSDataByteRangeEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSDataByteRangeEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr bytes, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSDataByteRangeEnumerator)ptr->Target)?.Invoke(bytes, range, ref stop);
		}
	}

	internal sealed class NIDNSDataByteRangeEnumerator : TrampolineBlockBase
	{
		private DNSDataByteRangeEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSDataByteRangeEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSDataByteRangeEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDataByteRangeEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSDataByteRangeEnumerator nSDataByteRangeEnumerator = (NSDataByteRangeEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSDataByteRangeEnumerator ?? new NSDataByteRangeEnumerator(new NIDNSDataByteRangeEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr bytes, NSRange range, ref bool stop)
		{
			invoker(base.BlockPointer, bytes, range, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSEnumerateErrorHandler))]
	internal delegate bool DNSEnumerateErrorHandler(IntPtr block, IntPtr url, IntPtr error);

	internal static class SDNSEnumerateErrorHandler
	{
		internal static readonly DNSEnumerateErrorHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSEnumerateErrorHandler))]
		private unsafe static bool Invoke(IntPtr block, IntPtr url, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSEnumerateErrorHandler nSEnumerateErrorHandler = (NSEnumerateErrorHandler)ptr->Target;
			return nSEnumerateErrorHandler(Runtime.GetNSObject<NSUrl>(url), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSEnumerateErrorHandler : TrampolineBlockBase
	{
		private DNSEnumerateErrorHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSEnumerateErrorHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSEnumerateErrorHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSEnumerateErrorHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSEnumerateErrorHandler nSEnumerateErrorHandler = (NSEnumerateErrorHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSEnumerateErrorHandler ?? new NSEnumerateErrorHandler(new NIDNSEnumerateErrorHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(NSUrl url, NSError error)
		{
			return invoker(base.BlockPointer, (url == null) ? IntPtr.Zero : url.Handle, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSEnumerateLinguisticTagsEnumerator))]
	internal delegate bool DNSEnumerateLinguisticTagsEnumerator(IntPtr block, IntPtr tag, NSRange tokenRange, NSRange sentenceRange, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSEnumerateLinguisticTagsEnumerator
	{
		internal static readonly DNSEnumerateLinguisticTagsEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSEnumerateLinguisticTagsEnumerator))]
		private unsafe static bool Invoke(IntPtr block, IntPtr tag, NSRange tokenRange, NSRange sentenceRange, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSEnumerateLinguisticTagsEnumerator nSEnumerateLinguisticTagsEnumerator = (NSEnumerateLinguisticTagsEnumerator)ptr->Target;
			return nSEnumerateLinguisticTagsEnumerator(Runtime.GetNSObject<NSString>(tag), tokenRange, sentenceRange, ref stop);
		}
	}

	internal sealed class NIDNSEnumerateLinguisticTagsEnumerator : TrampolineBlockBase
	{
		private DNSEnumerateLinguisticTagsEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSEnumerateLinguisticTagsEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSEnumerateLinguisticTagsEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSEnumerateLinguisticTagsEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSEnumerateLinguisticTagsEnumerator nSEnumerateLinguisticTagsEnumerator = (NSEnumerateLinguisticTagsEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSEnumerateLinguisticTagsEnumerator ?? new NSEnumerateLinguisticTagsEnumerator(new NIDNSEnumerateLinguisticTagsEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(NSString tag, NSRange tokenRange, NSRange sentenceRange, ref bool stop)
		{
			return invoker(base.BlockPointer, (tag == null) ? IntPtr.Zero : tag.Handle, tokenRange, sentenceRange, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSErrorUserInfoValueProvider))]
	internal delegate IntPtr DNSErrorUserInfoValueProvider(IntPtr block, IntPtr error, IntPtr userInfoKey);

	internal static class SDNSErrorUserInfoValueProvider
	{
		internal static readonly DNSErrorUserInfoValueProvider Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSErrorUserInfoValueProvider))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr error, IntPtr userInfoKey)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSErrorUserInfoValueProvider nSErrorUserInfoValueProvider = (NSErrorUserInfoValueProvider)ptr->Target;
			return nSErrorUserInfoValueProvider(Runtime.GetNSObject<NSError>(error), Runtime.GetNSObject<NSString>(userInfoKey))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDNSErrorUserInfoValueProvider : TrampolineBlockBase
	{
		private DNSErrorUserInfoValueProvider invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSErrorUserInfoValueProvider(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSErrorUserInfoValueProvider>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSErrorUserInfoValueProvider? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSErrorUserInfoValueProvider nSErrorUserInfoValueProvider = (NSErrorUserInfoValueProvider)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSErrorUserInfoValueProvider ?? new NSErrorUserInfoValueProvider(new NIDNSErrorUserInfoValueProvider((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSObject Invoke(NSError error, NSString userInfoKey)
		{
			return Runtime.GetNSObject(invoker(base.BlockPointer, error?.Handle ?? IntPtr.Zero, (userInfoKey == null) ? IntPtr.Zero : userInfoKey.Handle));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSExpressionCallbackHandler))]
	internal delegate IntPtr DNSExpressionCallbackHandler(IntPtr block, IntPtr evaluatedObject, IntPtr expressions, IntPtr context);

	internal static class SDNSExpressionCallbackHandler
	{
		internal static readonly DNSExpressionCallbackHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSExpressionCallbackHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr evaluatedObject, IntPtr expressions, IntPtr context)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSExpressionCallbackHandler nSExpressionCallbackHandler = (NSExpressionCallbackHandler)ptr->Target;
			return nSExpressionCallbackHandler(Runtime.GetNSObject<NSObject>(evaluatedObject), NSArray.ArrayFromHandle<NSExpression>(expressions), Runtime.GetNSObject<NSMutableDictionary>(context))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDNSExpressionCallbackHandler : TrampolineBlockBase
	{
		private DNSExpressionCallbackHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSExpressionCallbackHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSExpressionCallbackHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSExpressionCallbackHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSExpressionCallbackHandler nSExpressionCallbackHandler = (NSExpressionCallbackHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSExpressionCallbackHandler ?? new NSExpressionCallbackHandler(new NIDNSExpressionCallbackHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSObject Invoke(NSObject evaluatedObject, NSExpression[] expressions, NSMutableDictionary context)
		{
			NSArray nSArray = ((expressions == null) ? null : NSArray.FromNSObjects(expressions));
			NSObject nSObject = Runtime.GetNSObject(invoker(base.BlockPointer, evaluatedObject?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero, context?.Handle ?? IntPtr.Zero));
			nSArray?.Dispose();
			return nSObject;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSExpressionHandler))]
	internal delegate void DNSExpressionHandler(IntPtr block, IntPtr evaluatedObject, IntPtr expressions, IntPtr context);

	internal static class SDNSExpressionHandler
	{
		internal static readonly DNSExpressionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSExpressionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr evaluatedObject, IntPtr expressions, IntPtr context)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSExpressionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(evaluatedObject), NSArray.ArrayFromHandle<NSExpression>(expressions), Runtime.GetNSObject<NSMutableDictionary>(context));
		}
	}

	internal sealed class NIDNSExpressionHandler : TrampolineBlockBase
	{
		private DNSExpressionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSExpressionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSExpressionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSExpressionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSExpressionHandler nSExpressionHandler = (NSExpressionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSExpressionHandler ?? new NSExpressionHandler(new NIDNSExpressionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject evaluatedObject, NSExpression[] expressions, NSMutableDictionary context)
		{
			NSArray nSArray = ((expressions == null) ? null : NSArray.FromNSObjects(expressions));
			invoker(base.BlockPointer, evaluatedObject?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero, context?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSFileCoordinatorWorkerRW))]
	internal delegate void DNSFileCoordinatorWorkerRW(IntPtr block, IntPtr newReadingUrl, IntPtr newWritingUrl);

	internal static class SDNSFileCoordinatorWorkerRW
	{
		internal static readonly DNSFileCoordinatorWorkerRW Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSFileCoordinatorWorkerRW))]
		private unsafe static void Invoke(IntPtr block, IntPtr newReadingUrl, IntPtr newWritingUrl)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSFileCoordinatorWorkerRW)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(newReadingUrl), Runtime.GetNSObject<NSUrl>(newWritingUrl));
		}
	}

	internal sealed class NIDNSFileCoordinatorWorkerRW : TrampolineBlockBase
	{
		private DNSFileCoordinatorWorkerRW invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSFileCoordinatorWorkerRW(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSFileCoordinatorWorkerRW>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSFileCoordinatorWorkerRW? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSFileCoordinatorWorkerRW nSFileCoordinatorWorkerRW = (NSFileCoordinatorWorkerRW)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSFileCoordinatorWorkerRW ?? new NSFileCoordinatorWorkerRW(new NIDNSFileCoordinatorWorkerRW((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl newReadingUrl, NSUrl newWritingUrl)
		{
			invoker(base.BlockPointer, (newReadingUrl == null) ? IntPtr.Zero : newReadingUrl.Handle, (newWritingUrl == null) ? IntPtr.Zero : newWritingUrl.Handle);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSFilePresenterReacquirer))]
	internal delegate void DNSFilePresenterReacquirer(IntPtr block, IntPtr reacquirer);

	internal static class SDNSFilePresenterReacquirer
	{
		internal static readonly DNSFilePresenterReacquirer Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSFilePresenterReacquirer))]
		private unsafe static void Invoke(IntPtr block, IntPtr reacquirer)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSFilePresenterReacquirer)ptr->Target)?.Invoke(NIDAction.Create(reacquirer));
		}
	}

	internal sealed class NIDNSFilePresenterReacquirer : TrampolineBlockBase
	{
		private DNSFilePresenterReacquirer invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSFilePresenterReacquirer(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSFilePresenterReacquirer>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSFilePresenterReacquirer? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSFilePresenterReacquirer nSFilePresenterReacquirer = (NSFilePresenterReacquirer)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSFilePresenterReacquirer ?? new NSFilePresenterReacquirer(new NIDNSFilePresenterReacquirer((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke([BlockProxy(typeof(NIDAction))] Action reacquirer)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDAction.Handler, reacquirer);
			invoker(base.BlockPointer, (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSFileVersionNonlocalVersionsCompletionHandler))]
	internal delegate void DNSFileVersionNonlocalVersionsCompletionHandler(IntPtr block, IntPtr nonlocalFileVersions, IntPtr error);

	internal static class SDNSFileVersionNonlocalVersionsCompletionHandler
	{
		internal static readonly DNSFileVersionNonlocalVersionsCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSFileVersionNonlocalVersionsCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr nonlocalFileVersions, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSFileVersionNonlocalVersionsCompletionHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSFileVersion>(nonlocalFileVersions), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSFileVersionNonlocalVersionsCompletionHandler : TrampolineBlockBase
	{
		private DNSFileVersionNonlocalVersionsCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSFileVersionNonlocalVersionsCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSFileVersionNonlocalVersionsCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSFileVersionNonlocalVersionsCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSFileVersionNonlocalVersionsCompletionHandler nSFileVersionNonlocalVersionsCompletionHandler = (NSFileVersionNonlocalVersionsCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSFileVersionNonlocalVersionsCompletionHandler ?? new NSFileVersionNonlocalVersionsCompletionHandler(new NIDNSFileVersionNonlocalVersionsCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSFileVersion[]? nonlocalFileVersions, NSError? error)
		{
			NSArray nSArray = ((nonlocalFileVersions == null) ? null : NSArray.FromNSObjects(nonlocalFileVersions));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSItemProviderLoadHandler))]
	internal delegate void DNSItemProviderLoadHandler(IntPtr block, IntPtr completionHandler, IntPtr expectedValueClass, IntPtr options);

	internal static class SDNSItemProviderLoadHandler
	{
		internal static readonly DNSItemProviderLoadHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSItemProviderLoadHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr completionHandler, IntPtr expectedValueClass, IntPtr options)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSItemProviderLoadHandler)ptr->Target)?.Invoke(NIDNSItemProviderCompletionHandler.Create(completionHandler), new Class(expectedValueClass), Runtime.GetNSObject<NSDictionary>(options));
		}
	}

	internal sealed class NIDNSItemProviderLoadHandler : TrampolineBlockBase
	{
		private DNSItemProviderLoadHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSItemProviderLoadHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSItemProviderLoadHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSItemProviderLoadHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSItemProviderLoadHandler nSItemProviderLoadHandler = (NSItemProviderLoadHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSItemProviderLoadHandler ?? new NSItemProviderLoadHandler(new NIDNSItemProviderLoadHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke([BlockProxy(typeof(NIDNSItemProviderCompletionHandler))] NSItemProviderCompletionHandler completionHandler, Class expectedValueClass, NSDictionary options)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDNSItemProviderCompletionHandler.Handler, completionHandler);
			invoker(base.BlockPointer, (IntPtr)ptr, expectedValueClass?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSLingusticEnumerator))]
	internal delegate void DNSLingusticEnumerator(IntPtr block, IntPtr tag, NSRange tokenRange, NSRange sentenceRange, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSLingusticEnumerator
	{
		internal static readonly DNSLingusticEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSLingusticEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr tag, NSRange tokenRange, NSRange sentenceRange, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSLingusticEnumerator)ptr->Target)?.Invoke(Runtime.GetNSObject<NSString>(tag), tokenRange, sentenceRange, ref stop);
		}
	}

	internal sealed class NIDNSLingusticEnumerator : TrampolineBlockBase
	{
		private DNSLingusticEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSLingusticEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSLingusticEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSLingusticEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSLingusticEnumerator nSLingusticEnumerator = (NSLingusticEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSLingusticEnumerator ?? new NSLingusticEnumerator(new NIDNSLingusticEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSString tag, NSRange tokenRange, NSRange sentenceRange, ref bool stop)
		{
			invoker(base.BlockPointer, (tag == null) ? IntPtr.Zero : tag.Handle, tokenRange, sentenceRange, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSMatchEnumerator))]
	internal delegate void DNSMatchEnumerator(IntPtr block, IntPtr result, nuint flags, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSMatchEnumerator
	{
		internal static readonly DNSMatchEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSMatchEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr result, nuint flags, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSMatchEnumerator)ptr->Target)?.Invoke(Runtime.GetNSObject<NSTextCheckingResult>(result), (NSMatchingFlags)(ulong)flags, ref stop);
		}
	}

	internal sealed class NIDNSMatchEnumerator : TrampolineBlockBase
	{
		private DNSMatchEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSMatchEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSMatchEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSMatchEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSMatchEnumerator nSMatchEnumerator = (NSMatchEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSMatchEnumerator ?? new NSMatchEnumerator(new NIDNSMatchEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSTextCheckingResult result, NSMatchingFlags flags, ref bool stop)
		{
			invoker(base.BlockPointer, result?.Handle ?? IntPtr.Zero, (nuint)(ulong)flags, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSMetadataQueryEnumerationCallback))]
	internal delegate void DNSMetadataQueryEnumerationCallback(IntPtr block, IntPtr result, nuint idx, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSMetadataQueryEnumerationCallback
	{
		internal static readonly DNSMetadataQueryEnumerationCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSMetadataQueryEnumerationCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr result, nuint idx, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSMetadataQueryEnumerationCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(result), idx, ref stop);
		}
	}

	internal sealed class NIDNSMetadataQueryEnumerationCallback : TrampolineBlockBase
	{
		private DNSMetadataQueryEnumerationCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSMetadataQueryEnumerationCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSMetadataQueryEnumerationCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSMetadataQueryEnumerationCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSMetadataQueryEnumerationCallback nSMetadataQueryEnumerationCallback = (NSMetadataQueryEnumerationCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSMetadataQueryEnumerationCallback ?? new NSMetadataQueryEnumerationCallback(new NIDNSMetadataQueryEnumerationCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject result, nuint idx, ref bool stop)
		{
			invoker(base.BlockPointer, result?.Handle ?? IntPtr.Zero, idx, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSPredicateEvaluator))]
	internal delegate bool DNSPredicateEvaluator(IntPtr block, IntPtr evaluatedObject, IntPtr bindings);

	internal static class SDNSPredicateEvaluator
	{
		internal static readonly DNSPredicateEvaluator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSPredicateEvaluator))]
		private unsafe static bool Invoke(IntPtr block, IntPtr evaluatedObject, IntPtr bindings)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NSPredicateEvaluator nSPredicateEvaluator = (NSPredicateEvaluator)ptr->Target;
			return nSPredicateEvaluator(Runtime.GetNSObject<NSObject>(evaluatedObject), Runtime.GetNSObject<NSDictionary>(bindings));
		}
	}

	internal sealed class NIDNSPredicateEvaluator : TrampolineBlockBase
	{
		private DNSPredicateEvaluator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSPredicateEvaluator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSPredicateEvaluator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSPredicateEvaluator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSPredicateEvaluator nSPredicateEvaluator = (NSPredicateEvaluator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSPredicateEvaluator ?? new NSPredicateEvaluator(new NIDNSPredicateEvaluator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(NSObject evaluatedObject, NSDictionary bindings)
		{
			return invoker(base.BlockPointer, evaluatedObject?.Handle ?? IntPtr.Zero, bindings?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSRangeIterator))]
	internal delegate void DNSRangeIterator(IntPtr block, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSRangeIterator
	{
		internal static readonly DNSRangeIterator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSRangeIterator))]
		private unsafe static void Invoke(IntPtr block, NSRange range, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSRangeIterator)ptr->Target)?.Invoke(range, ref stop);
		}
	}

	internal sealed class NIDNSRangeIterator : TrampolineBlockBase
	{
		private DNSRangeIterator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSRangeIterator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSRangeIterator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSRangeIterator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSRangeIterator nSRangeIterator = (NSRangeIterator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSRangeIterator ?? new NSRangeIterator(new NIDNSRangeIterator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSRange range, ref bool stop)
		{
			invoker(base.BlockPointer, range, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSSetEnumerator))]
	internal delegate void DNSSetEnumerator(IntPtr block, IntPtr obj, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNSSetEnumerator
	{
		internal static readonly DNSSetEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSSetEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSSetEnumerator)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(obj), ref stop);
		}
	}

	internal sealed class NIDNSSetEnumerator : TrampolineBlockBase
	{
		private DNSSetEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSSetEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSSetEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSSetEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSSetEnumerator nSSetEnumerator = (NSSetEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSSetEnumerator ?? new NSSetEnumerator(new NIDNSSetEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject obj, ref bool stop)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlConnectionDataResponse))]
	internal delegate void DNSUrlConnectionDataResponse(IntPtr block, IntPtr response, IntPtr data, IntPtr error);

	internal static class SDNSUrlConnectionDataResponse
	{
		internal static readonly DNSUrlConnectionDataResponse Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlConnectionDataResponse))]
		private unsafe static void Invoke(IntPtr block, IntPtr response, IntPtr data, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlConnectionDataResponse)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrlResponse>(response), Runtime.GetNSObject<NSData>(data), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSUrlConnectionDataResponse : TrampolineBlockBase
	{
		private DNSUrlConnectionDataResponse invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlConnectionDataResponse(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlConnectionDataResponse>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlConnectionDataResponse? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlConnectionDataResponse nSUrlConnectionDataResponse = (NSUrlConnectionDataResponse)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlConnectionDataResponse ?? new NSUrlConnectionDataResponse(new NIDNSUrlConnectionDataResponse((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlResponse response, NSData data, NSError error)
		{
			invoker(base.BlockPointer, response?.Handle ?? IntPtr.Zero, data?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlDownloadSessionResponse))]
	internal delegate void DNSUrlDownloadSessionResponse(IntPtr block, IntPtr location, IntPtr response, IntPtr error);

	internal static class SDNSUrlDownloadSessionResponse
	{
		internal static readonly DNSUrlDownloadSessionResponse Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlDownloadSessionResponse))]
		private unsafe static void Invoke(IntPtr block, IntPtr location, IntPtr response, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlDownloadSessionResponse)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(location), Runtime.GetNSObject<NSUrlResponse>(response), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSUrlDownloadSessionResponse : TrampolineBlockBase
	{
		private DNSUrlDownloadSessionResponse invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlDownloadSessionResponse(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlDownloadSessionResponse>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlDownloadSessionResponse? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlDownloadSessionResponse nSUrlDownloadSessionResponse = (NSUrlDownloadSessionResponse)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlDownloadSessionResponse ?? new NSUrlDownloadSessionResponse(new NIDNSUrlDownloadSessionResponse((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl location, NSUrlResponse response, NSError error)
		{
			invoker(base.BlockPointer, (location == null) ? IntPtr.Zero : location.Handle, response?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlSessionAllPendingTasks))]
	internal delegate void DNSUrlSessionAllPendingTasks(IntPtr block, IntPtr tasks);

	internal static class SDNSUrlSessionAllPendingTasks
	{
		internal static readonly DNSUrlSessionAllPendingTasks Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlSessionAllPendingTasks))]
		private unsafe static void Invoke(IntPtr block, IntPtr tasks)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlSessionAllPendingTasks)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSUrlSessionTask>(tasks));
		}
	}

	internal sealed class NIDNSUrlSessionAllPendingTasks : TrampolineBlockBase
	{
		private DNSUrlSessionAllPendingTasks invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlSessionAllPendingTasks(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlSessionAllPendingTasks>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionAllPendingTasks? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlSessionAllPendingTasks nSUrlSessionAllPendingTasks = (NSUrlSessionAllPendingTasks)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlSessionAllPendingTasks ?? new NSUrlSessionAllPendingTasks(new NIDNSUrlSessionAllPendingTasks((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionTask[] tasks)
		{
			NSArray nSArray = ((tasks == null) ? null : NSArray.FromNSObjects(tasks));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlSessionDataRead))]
	internal delegate void DNSUrlSessionDataRead(IntPtr block, IntPtr data, bool atEof, IntPtr error);

	internal static class SDNSUrlSessionDataRead
	{
		internal static readonly DNSUrlSessionDataRead Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlSessionDataRead))]
		private unsafe static void Invoke(IntPtr block, IntPtr data, bool atEof, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlSessionDataRead)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(data), atEof, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSUrlSessionDataRead : TrampolineBlockBase
	{
		private DNSUrlSessionDataRead invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlSessionDataRead(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlSessionDataRead>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionDataRead? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlSessionDataRead nSUrlSessionDataRead = (NSUrlSessionDataRead)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlSessionDataRead ?? new NSUrlSessionDataRead(new NIDNSUrlSessionDataRead((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData data, bool atEof, NSError error)
		{
			invoker(base.BlockPointer, data?.Handle ?? IntPtr.Zero, atEof, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlSessionPendingTasks))]
	internal delegate void DNSUrlSessionPendingTasks(IntPtr block, IntPtr dataTasks, IntPtr uploadTasks, IntPtr downloadTasks);

	internal static class SDNSUrlSessionPendingTasks
	{
		internal static readonly DNSUrlSessionPendingTasks Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlSessionPendingTasks))]
		private unsafe static void Invoke(IntPtr block, IntPtr dataTasks, IntPtr uploadTasks, IntPtr downloadTasks)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlSessionPendingTasks)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSUrlSessionDataTask>(dataTasks), NSArray.ArrayFromHandle<NSUrlSessionUploadTask>(uploadTasks), NSArray.ArrayFromHandle<NSUrlSessionDownloadTask>(downloadTasks));
		}
	}

	internal sealed class NIDNSUrlSessionPendingTasks : TrampolineBlockBase
	{
		private DNSUrlSessionPendingTasks invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlSessionPendingTasks(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlSessionPendingTasks>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionPendingTasks? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlSessionPendingTasks nSUrlSessionPendingTasks = (NSUrlSessionPendingTasks)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlSessionPendingTasks ?? new NSUrlSessionPendingTasks(new NIDNSUrlSessionPendingTasks((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionDataTask[] dataTasks, NSUrlSessionUploadTask[] uploadTasks, NSUrlSessionDownloadTask[] downloadTasks)
		{
			NSArray nSArray = ((dataTasks == null) ? null : NSArray.FromNSObjects(dataTasks));
			NSArray nSArray2 = ((uploadTasks == null) ? null : NSArray.FromNSObjects(uploadTasks));
			NSArray nSArray3 = ((downloadTasks == null) ? null : NSArray.FromNSObjects(downloadTasks));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
			nSArray3?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlSessionPendingTasks2))]
	internal delegate void DNSUrlSessionPendingTasks2(IntPtr block, IntPtr dataTasks, IntPtr uploadTasks, IntPtr downloadTasks);

	internal static class SDNSUrlSessionPendingTasks2
	{
		internal static readonly DNSUrlSessionPendingTasks2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlSessionPendingTasks2))]
		private unsafe static void Invoke(IntPtr block, IntPtr dataTasks, IntPtr uploadTasks, IntPtr downloadTasks)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlSessionPendingTasks2)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSUrlSessionTask>(dataTasks), NSArray.ArrayFromHandle<NSUrlSessionTask>(uploadTasks), NSArray.ArrayFromHandle<NSUrlSessionTask>(downloadTasks));
		}
	}

	internal sealed class NIDNSUrlSessionPendingTasks2 : TrampolineBlockBase
	{
		private DNSUrlSessionPendingTasks2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlSessionPendingTasks2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlSessionPendingTasks2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionPendingTasks2? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlSessionPendingTasks2 nSUrlSessionPendingTasks = (NSUrlSessionPendingTasks2)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlSessionPendingTasks ?? new NSUrlSessionPendingTasks2(new NIDNSUrlSessionPendingTasks2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionTask[] dataTasks, NSUrlSessionTask[] uploadTasks, NSUrlSessionTask[] downloadTasks)
		{
			NSArray nSArray = ((dataTasks == null) ? null : NSArray.FromNSObjects(dataTasks));
			NSArray nSArray2 = ((uploadTasks == null) ? null : NSArray.FromNSObjects(uploadTasks));
			NSArray nSArray3 = ((downloadTasks == null) ? null : NSArray.FromNSObjects(downloadTasks));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
			nSArray3?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSUrlSessionResponse))]
	internal delegate void DNSUrlSessionResponse(IntPtr block, IntPtr data, IntPtr response, IntPtr error);

	internal static class SDNSUrlSessionResponse
	{
		internal static readonly DNSUrlSessionResponse Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSUrlSessionResponse))]
		private unsafe static void Invoke(IntPtr block, IntPtr data, IntPtr response, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSUrlSessionResponse)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(data), Runtime.GetNSObject<NSUrlResponse>(response), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSUrlSessionResponse : TrampolineBlockBase
	{
		private DNSUrlSessionResponse invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSUrlSessionResponse(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSUrlSessionResponse>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrlSessionResponse? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSUrlSessionResponse nSUrlSessionResponse = (NSUrlSessionResponse)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSUrlSessionResponse ?? new NSUrlSessionResponse(new NIDNSUrlSessionResponse((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData data, NSUrlResponse response, NSError error)
		{
			invoker(base.BlockPointer, data?.Handle ?? IntPtr.Zero, response?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(RegisterDataRepresentationLoadHandler))]
	internal delegate IntPtr DRegisterDataRepresentationLoadHandler(IntPtr block, IntPtr completionHandler);

	internal static class SDRegisterDataRepresentationLoadHandler
	{
		internal static readonly DRegisterDataRepresentationLoadHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DRegisterDataRepresentationLoadHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr completionHandler)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			RegisterDataRepresentationLoadHandler registerDataRepresentationLoadHandler = (RegisterDataRepresentationLoadHandler)ptr->Target;
			return registerDataRepresentationLoadHandler(NIDItemProviderDataCompletionHandler.Create(completionHandler))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDRegisterDataRepresentationLoadHandler : TrampolineBlockBase
	{
		private DRegisterDataRepresentationLoadHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDRegisterDataRepresentationLoadHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DRegisterDataRepresentationLoadHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static RegisterDataRepresentationLoadHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			RegisterDataRepresentationLoadHandler registerDataRepresentationLoadHandler = (RegisterDataRepresentationLoadHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return registerDataRepresentationLoadHandler ?? new RegisterDataRepresentationLoadHandler(new NIDRegisterDataRepresentationLoadHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe NSProgress Invoke([BlockProxy(typeof(NIDItemProviderDataCompletionHandler))] ItemProviderDataCompletionHandler completionHandler)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDItemProviderDataCompletionHandler.Handler, completionHandler);
			NSProgress nSObject = Runtime.GetNSObject<NSProgress>(invoker(base.BlockPointer, (IntPtr)ptr));
			ptr->CleanupBlock();
			return nSObject;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(RegisterFileRepresentationLoadHandler))]
	internal delegate IntPtr DRegisterFileRepresentationLoadHandler(IntPtr block, IntPtr completionHandler);

	internal static class SDRegisterFileRepresentationLoadHandler
	{
		internal static readonly DRegisterFileRepresentationLoadHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DRegisterFileRepresentationLoadHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr completionHandler)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			RegisterFileRepresentationLoadHandler registerFileRepresentationLoadHandler = (RegisterFileRepresentationLoadHandler)ptr->Target;
			return registerFileRepresentationLoadHandler(NIDRegisterFileRepresentationCompletionHandler.Create(completionHandler))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDRegisterFileRepresentationLoadHandler : TrampolineBlockBase
	{
		private DRegisterFileRepresentationLoadHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDRegisterFileRepresentationLoadHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DRegisterFileRepresentationLoadHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static RegisterFileRepresentationLoadHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			RegisterFileRepresentationLoadHandler registerFileRepresentationLoadHandler = (RegisterFileRepresentationLoadHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return registerFileRepresentationLoadHandler ?? new RegisterFileRepresentationLoadHandler(new NIDRegisterFileRepresentationLoadHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe NSProgress Invoke([BlockProxy(typeof(NIDRegisterFileRepresentationCompletionHandler))] RegisterFileRepresentationCompletionHandler completionHandler)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDRegisterFileRepresentationCompletionHandler.Handler, completionHandler);
			NSProgress nSObject = Runtime.GetNSObject<NSProgress>(invoker(base.BlockPointer, (IntPtr)ptr));
			ptr->CleanupBlock();
			return nSObject;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(RegisterObjectRepresentationLoadHandler))]
	internal delegate IntPtr DRegisterObjectRepresentationLoadHandler(IntPtr block, IntPtr completionHandler);

	internal static class SDRegisterObjectRepresentationLoadHandler
	{
		internal static readonly DRegisterObjectRepresentationLoadHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DRegisterObjectRepresentationLoadHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr completionHandler)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			RegisterObjectRepresentationLoadHandler registerObjectRepresentationLoadHandler = (RegisterObjectRepresentationLoadHandler)ptr->Target;
			return registerObjectRepresentationLoadHandler(NIDRegisterObjectRepresentationCompletionHandler.Create(completionHandler))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDRegisterObjectRepresentationLoadHandler : TrampolineBlockBase
	{
		private DRegisterObjectRepresentationLoadHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDRegisterObjectRepresentationLoadHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DRegisterObjectRepresentationLoadHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static RegisterObjectRepresentationLoadHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			RegisterObjectRepresentationLoadHandler registerObjectRepresentationLoadHandler = (RegisterObjectRepresentationLoadHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return registerObjectRepresentationLoadHandler ?? new RegisterObjectRepresentationLoadHandler(new NIDRegisterObjectRepresentationLoadHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe NSProgress Invoke([BlockProxy(typeof(NIDRegisterObjectRepresentationCompletionHandler))] RegisterObjectRepresentationCompletionHandler completionHandler)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDRegisterObjectRepresentationCompletionHandler.Handler, completionHandler);
			NSProgress nSObject = Runtime.GetNSObject<NSProgress>(invoker(base.BlockPointer, (IntPtr)ptr));
			ptr->CleanupBlock();
			return nSObject;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GLKTextureLoaderCallback))]
	internal delegate void DGLKTextureLoaderCallback(IntPtr block, IntPtr textureInfo, IntPtr error);

	internal static class SDGLKTextureLoaderCallback
	{
		internal static readonly DGLKTextureLoaderCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGLKTextureLoaderCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr textureInfo, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GLKTextureLoaderCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<GLKTextureInfo>(textureInfo), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGLKTextureLoaderCallback : TrampolineBlockBase
	{
		private DGLKTextureLoaderCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGLKTextureLoaderCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGLKTextureLoaderCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GLKTextureLoaderCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GLKTextureLoaderCallback gLKTextureLoaderCallback = (GLKTextureLoaderCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gLKTextureLoaderCallback ?? new GLKTextureLoaderCallback(new NIDGLKTextureLoaderCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GLKTextureInfo textureInfo, NSError error)
		{
			invoker(base.BlockPointer, textureInfo?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GCControllerAxisValueChangedHandler))]
	internal delegate void DGCControllerAxisValueChangedHandler(IntPtr block, IntPtr axis, float value);

	internal static class SDGCControllerAxisValueChangedHandler
	{
		internal static readonly DGCControllerAxisValueChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGCControllerAxisValueChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr axis, float value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GCControllerAxisValueChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<GCControllerAxisInput>(axis), value);
		}
	}

	internal sealed class NIDGCControllerAxisValueChangedHandler : TrampolineBlockBase
	{
		private DGCControllerAxisValueChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGCControllerAxisValueChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGCControllerAxisValueChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GCControllerAxisValueChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GCControllerAxisValueChangedHandler gCControllerAxisValueChangedHandler = (GCControllerAxisValueChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gCControllerAxisValueChangedHandler ?? new GCControllerAxisValueChangedHandler(new NIDGCControllerAxisValueChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCControllerAxisInput axis, float value)
		{
			invoker(base.BlockPointer, axis?.Handle ?? IntPtr.Zero, value);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GCControllerButtonValueChanged))]
	internal delegate void DGCControllerButtonValueChanged(IntPtr block, IntPtr button, float buttonValue, bool pressed);

	internal static class SDGCControllerButtonValueChanged
	{
		internal static readonly DGCControllerButtonValueChanged Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGCControllerButtonValueChanged))]
		private unsafe static void Invoke(IntPtr block, IntPtr button, float buttonValue, bool pressed)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GCControllerButtonValueChanged)ptr->Target)?.Invoke(Runtime.GetNSObject<GCControllerButtonInput>(button), buttonValue, pressed);
		}
	}

	internal sealed class NIDGCControllerButtonValueChanged : TrampolineBlockBase
	{
		private DGCControllerButtonValueChanged invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGCControllerButtonValueChanged(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGCControllerButtonValueChanged>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GCControllerButtonValueChanged? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GCControllerButtonValueChanged gCControllerButtonValueChanged = (GCControllerButtonValueChanged)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gCControllerButtonValueChanged ?? new GCControllerButtonValueChanged(new NIDGCControllerButtonValueChanged((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCControllerButtonInput button, float buttonValue, bool pressed)
		{
			invoker(base.BlockPointer, button?.Handle ?? IntPtr.Zero, buttonValue, pressed);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GCControllerDirectionPadValueChangedHandler))]
	internal delegate void DGCControllerDirectionPadValueChangedHandler(IntPtr block, IntPtr dpad, float xValue, float yValue);

	internal static class SDGCControllerDirectionPadValueChangedHandler
	{
		internal static readonly DGCControllerDirectionPadValueChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGCControllerDirectionPadValueChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr dpad, float xValue, float yValue)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GCControllerDirectionPadValueChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<GCControllerDirectionPad>(dpad), xValue, yValue);
		}
	}

	internal sealed class NIDGCControllerDirectionPadValueChangedHandler : TrampolineBlockBase
	{
		private DGCControllerDirectionPadValueChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGCControllerDirectionPadValueChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGCControllerDirectionPadValueChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GCControllerDirectionPadValueChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GCControllerDirectionPadValueChangedHandler gCControllerDirectionPadValueChangedHandler = (GCControllerDirectionPadValueChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gCControllerDirectionPadValueChangedHandler ?? new GCControllerDirectionPadValueChangedHandler(new NIDGCControllerDirectionPadValueChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCControllerDirectionPad dpad, float xValue, float yValue)
		{
			invoker(base.BlockPointer, dpad?.Handle ?? IntPtr.Zero, xValue, yValue);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GCExtendedGamepadValueChangedHandler))]
	internal delegate void DGCExtendedGamepadValueChangedHandler(IntPtr block, IntPtr gamepad, IntPtr element);

	internal static class SDGCExtendedGamepadValueChangedHandler
	{
		internal static readonly DGCExtendedGamepadValueChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGCExtendedGamepadValueChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr gamepad, IntPtr element)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GCExtendedGamepadValueChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<GCExtendedGamepad>(gamepad), Runtime.GetNSObject<GCControllerElement>(element));
		}
	}

	internal sealed class NIDGCExtendedGamepadValueChangedHandler : TrampolineBlockBase
	{
		private DGCExtendedGamepadValueChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGCExtendedGamepadValueChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGCExtendedGamepadValueChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GCExtendedGamepadValueChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GCExtendedGamepadValueChangedHandler gCExtendedGamepadValueChangedHandler = (GCExtendedGamepadValueChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gCExtendedGamepadValueChangedHandler ?? new GCExtendedGamepadValueChangedHandler(new NIDGCExtendedGamepadValueChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCExtendedGamepad gamepad, GCControllerElement element)
		{
			invoker(base.BlockPointer, gamepad?.Handle ?? IntPtr.Zero, element?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GCGamepadValueChangedHandler))]
	internal delegate void DGCGamepadValueChangedHandler(IntPtr block, IntPtr gamepad, IntPtr element);

	internal static class SDGCGamepadValueChangedHandler
	{
		internal static readonly DGCGamepadValueChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGCGamepadValueChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr gamepad, IntPtr element)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GCGamepadValueChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<GCGamepad>(gamepad), Runtime.GetNSObject<GCControllerElement>(element));
		}
	}

	internal sealed class NIDGCGamepadValueChangedHandler : TrampolineBlockBase
	{
		private DGCGamepadValueChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGCGamepadValueChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGCGamepadValueChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GCGamepadValueChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GCGamepadValueChangedHandler gCGamepadValueChangedHandler = (GCGamepadValueChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gCGamepadValueChangedHandler ?? new GCGamepadValueChangedHandler(new NIDGCGamepadValueChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCGamepad gamepad, GCControllerElement element)
		{
			invoker(base.BlockPointer, gamepad?.Handle ?? IntPtr.Zero, element?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GCMicroGamepadValueChangedHandler))]
	internal delegate void DGCMicroGamepadValueChangedHandler(IntPtr block, IntPtr gamepad, IntPtr element);

	internal static class SDGCMicroGamepadValueChangedHandler
	{
		internal static readonly DGCMicroGamepadValueChangedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGCMicroGamepadValueChangedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr gamepad, IntPtr element)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GCMicroGamepadValueChangedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<GCMicroGamepad>(gamepad), Runtime.GetNSObject<GCControllerElement>(element));
		}
	}

	internal sealed class NIDGCMicroGamepadValueChangedHandler : TrampolineBlockBase
	{
		private DGCMicroGamepadValueChangedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGCMicroGamepadValueChangedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGCMicroGamepadValueChangedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GCMicroGamepadValueChangedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GCMicroGamepadValueChangedHandler gCMicroGamepadValueChangedHandler = (GCMicroGamepadValueChangedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gCMicroGamepadValueChangedHandler ?? new GCMicroGamepadValueChangedHandler(new NIDGCMicroGamepadValueChangedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCMicroGamepad gamepad, GCControllerElement element)
		{
			invoker(base.BlockPointer, gamepad?.Handle ?? IntPtr.Zero, element?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKAchievementDescriptionHandler))]
	internal delegate void DGKAchievementDescriptionHandler(IntPtr block, IntPtr descriptions, IntPtr error);

	internal static class SDGKAchievementDescriptionHandler
	{
		internal static readonly DGKAchievementDescriptionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKAchievementDescriptionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr descriptions, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKAchievementDescriptionHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKAchievementDescription>(descriptions), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKAchievementDescriptionHandler : TrampolineBlockBase
	{
		private DGKAchievementDescriptionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKAchievementDescriptionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKAchievementDescriptionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKAchievementDescriptionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKAchievementDescriptionHandler gKAchievementDescriptionHandler = (GKAchievementDescriptionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKAchievementDescriptionHandler ?? new GKAchievementDescriptionHandler(new NIDGKAchievementDescriptionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKAchievementDescription[] descriptions, NSError error)
		{
			NSArray nSArray = ((descriptions == null) ? null : NSArray.FromNSObjects(descriptions));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKCategoryHandler))]
	internal delegate void DGKCategoryHandler(IntPtr block, IntPtr categories, IntPtr titles, IntPtr error);

	internal static class SDGKCategoryHandler
	{
		internal static readonly DGKCategoryHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKCategoryHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr categories, IntPtr titles, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKCategoryHandler)ptr->Target)?.Invoke(NSArray.StringArrayFromHandle(categories), NSArray.StringArrayFromHandle(titles), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKCategoryHandler : TrampolineBlockBase
	{
		private DGKCategoryHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKCategoryHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKCategoryHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKCategoryHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKCategoryHandler gKCategoryHandler = (GKCategoryHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKCategoryHandler ?? new GKCategoryHandler(new NIDGKCategoryHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string[] categories, string[] titles, NSError error)
		{
			NSArray nSArray = ((categories == null) ? null : NSArray.FromStrings(categories));
			NSArray nSArray2 = ((titles == null) ? null : NSArray.FromStrings(titles));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKChallengeComposeHandler))]
	internal delegate void DGKChallengeComposeHandler(IntPtr block, IntPtr composeController, bool issuedChallenge, IntPtr sentPlayerIDs);

	internal static class SDGKChallengeComposeHandler
	{
		internal static readonly DGKChallengeComposeHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKChallengeComposeHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr composeController, bool issuedChallenge, IntPtr sentPlayerIDs)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKChallengeComposeHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSViewController>(composeController), issuedChallenge, NSArray.StringArrayFromHandle(sentPlayerIDs));
		}
	}

	internal sealed class NIDGKChallengeComposeHandler : TrampolineBlockBase
	{
		private DGKChallengeComposeHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKChallengeComposeHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKChallengeComposeHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKChallengeComposeHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKChallengeComposeHandler gKChallengeComposeHandler = (GKChallengeComposeHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKChallengeComposeHandler ?? new GKChallengeComposeHandler(new NIDGKChallengeComposeHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSViewController composeController, bool issuedChallenge, string[] sentPlayerIDs)
		{
			NSArray nSArray = ((sentPlayerIDs == null) ? null : NSArray.FromStrings(sentPlayerIDs));
			invoker(base.BlockPointer, composeController?.Handle ?? IntPtr.Zero, issuedChallenge, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKCompletionHandler))]
	internal delegate void DGKCompletionHandler(IntPtr block, IntPtr achivements, IntPtr error);

	internal static class SDGKCompletionHandler
	{
		internal static readonly DGKCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr achivements, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKCompletionHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKAchievement>(achivements), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKCompletionHandler : TrampolineBlockBase
	{
		private DGKCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKCompletionHandler gKCompletionHandler = (GKCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKCompletionHandler ?? new GKCompletionHandler(new NIDGKCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKAchievement[] achivements, NSError error)
		{
			NSArray nSArray = ((achivements == null) ? null : NSArray.FromNSObjects(achivements));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKFetchItemsForIdentityVerificationSignatureCompletionHandler))]
	internal delegate void DGKFetchItemsForIdentityVerificationSignatureCompletionHandler(IntPtr block, IntPtr publicKeyUrl, IntPtr signature, IntPtr salt, ulong timestamp, IntPtr error);

	internal static class SDGKFetchItemsForIdentityVerificationSignatureCompletionHandler
	{
		internal static readonly DGKFetchItemsForIdentityVerificationSignatureCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKFetchItemsForIdentityVerificationSignatureCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr publicKeyUrl, IntPtr signature, IntPtr salt, ulong timestamp, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKFetchItemsForIdentityVerificationSignatureCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(publicKeyUrl), Runtime.GetNSObject<NSData>(signature), Runtime.GetNSObject<NSData>(salt), timestamp, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKFetchItemsForIdentityVerificationSignatureCompletionHandler : TrampolineBlockBase
	{
		private DGKFetchItemsForIdentityVerificationSignatureCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKFetchItemsForIdentityVerificationSignatureCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKFetchItemsForIdentityVerificationSignatureCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKFetchItemsForIdentityVerificationSignatureCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKFetchItemsForIdentityVerificationSignatureCompletionHandler gKFetchItemsForIdentityVerificationSignatureCompletionHandler = (GKFetchItemsForIdentityVerificationSignatureCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKFetchItemsForIdentityVerificationSignatureCompletionHandler ?? new GKFetchItemsForIdentityVerificationSignatureCompletionHandler(new NIDGKFetchItemsForIdentityVerificationSignatureCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp, NSError error)
		{
			invoker(base.BlockPointer, (publicKeyUrl == null) ? IntPtr.Zero : publicKeyUrl.Handle, signature?.Handle ?? IntPtr.Zero, salt?.Handle ?? IntPtr.Zero, timestamp, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKFriendsHandler))]
	internal delegate void DGKFriendsHandler(IntPtr block, IntPtr friends, IntPtr error);

	internal static class SDGKFriendsHandler
	{
		internal static readonly DGKFriendsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKFriendsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr friends, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKFriendsHandler)ptr->Target)?.Invoke(NSArray.StringArrayFromHandle(friends), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKFriendsHandler : TrampolineBlockBase
	{
		private DGKFriendsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKFriendsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKFriendsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKFriendsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKFriendsHandler gKFriendsHandler = (GKFriendsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKFriendsHandler ?? new GKFriendsHandler(new NIDGKFriendsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string[] friends, NSError error)
		{
			NSArray nSArray = ((friends == null) ? null : NSArray.FromStrings(friends));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKIdentityVerificationSignatureHandler))]
	internal delegate void DGKIdentityVerificationSignatureHandler(IntPtr block, IntPtr publicKeyUrl, IntPtr signature, IntPtr salt, ulong timestamp, IntPtr error);

	internal static class SDGKIdentityVerificationSignatureHandler
	{
		internal static readonly DGKIdentityVerificationSignatureHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKIdentityVerificationSignatureHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr publicKeyUrl, IntPtr signature, IntPtr salt, ulong timestamp, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKIdentityVerificationSignatureHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(publicKeyUrl), Runtime.GetNSObject<NSData>(signature), Runtime.GetNSObject<NSData>(salt), timestamp, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKIdentityVerificationSignatureHandler : TrampolineBlockBase
	{
		private DGKIdentityVerificationSignatureHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKIdentityVerificationSignatureHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKIdentityVerificationSignatureHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKIdentityVerificationSignatureHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKIdentityVerificationSignatureHandler gKIdentityVerificationSignatureHandler = (GKIdentityVerificationSignatureHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKIdentityVerificationSignatureHandler ?? new GKIdentityVerificationSignatureHandler(new NIDGKIdentityVerificationSignatureHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp, NSError error)
		{
			invoker(base.BlockPointer, (publicKeyUrl == null) ? IntPtr.Zero : publicKeyUrl.Handle, signature?.Handle ?? IntPtr.Zero, salt?.Handle ?? IntPtr.Zero, timestamp, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKImageLoadedHandler))]
	internal delegate void DGKImageLoadedHandler(IntPtr block, IntPtr image, IntPtr error);

	internal static class SDGKImageLoadedHandler
	{
		internal static readonly DGKImageLoadedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKImageLoadedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr image, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKImageLoadedHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSImage>(image), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKImageLoadedHandler : TrampolineBlockBase
	{
		private DGKImageLoadedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKImageLoadedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKImageLoadedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKImageLoadedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKImageLoadedHandler gKImageLoadedHandler = (GKImageLoadedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKImageLoadedHandler ?? new GKImageLoadedHandler(new NIDGKImageLoadedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSImage image, NSError error)
		{
			invoker(base.BlockPointer, image?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKInviteHandler))]
	internal delegate void DGKInviteHandler(IntPtr block, IntPtr invite, IntPtr playerIDs);

	internal static class SDGKInviteHandler
	{
		internal static readonly DGKInviteHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKInviteHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr invite, IntPtr playerIDs)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKInviteHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<GKInvite>(invite), NSArray.StringArrayFromHandle(playerIDs));
		}
	}

	internal sealed class NIDGKInviteHandler : TrampolineBlockBase
	{
		private DGKInviteHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKInviteHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKInviteHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKInviteHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKInviteHandler gKInviteHandler = (GKInviteHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKInviteHandler ?? new GKInviteHandler(new NIDGKInviteHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKInvite invite, string[] playerIDs)
		{
			NSArray nSArray = ((playerIDs == null) ? null : NSArray.FromStrings(playerIDs));
			invoker(base.BlockPointer, invite?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKLeaderboardSetsHandler))]
	internal delegate void DGKLeaderboardSetsHandler(IntPtr block, IntPtr leaderboardSets, IntPtr error);

	internal static class SDGKLeaderboardSetsHandler
	{
		internal static readonly DGKLeaderboardSetsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKLeaderboardSetsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr leaderboardSets, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKLeaderboardSetsHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKLeaderboardSet>(leaderboardSets), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKLeaderboardSetsHandler : TrampolineBlockBase
	{
		private DGKLeaderboardSetsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKLeaderboardSetsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKLeaderboardSetsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKLeaderboardSetsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKLeaderboardSetsHandler gKLeaderboardSetsHandler = (GKLeaderboardSetsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKLeaderboardSetsHandler ?? new GKLeaderboardSetsHandler(new NIDGKLeaderboardSetsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKLeaderboardSet[] leaderboardSets, NSError error)
		{
			NSArray nSArray = ((leaderboardSets == null) ? null : NSArray.FromNSObjects(leaderboardSets));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKLeaderboardsHandler))]
	internal delegate void DGKLeaderboardsHandler(IntPtr block, IntPtr leaderboards, IntPtr error);

	internal static class SDGKLeaderboardsHandler
	{
		internal static readonly DGKLeaderboardsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKLeaderboardsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr leaderboards, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKLeaderboardsHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKLeaderboard>(leaderboards), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKLeaderboardsHandler : TrampolineBlockBase
	{
		private DGKLeaderboardsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKLeaderboardsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKLeaderboardsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKLeaderboardsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKLeaderboardsHandler gKLeaderboardsHandler = (GKLeaderboardsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKLeaderboardsHandler ?? new GKLeaderboardsHandler(new NIDGKLeaderboardsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKLeaderboard[] leaderboards, NSError error)
		{
			NSArray nSArray = ((leaderboards == null) ? null : NSArray.FromNSObjects(leaderboards));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKNotificationMatch))]
	internal delegate void DGKNotificationMatch(IntPtr block, IntPtr match, IntPtr error);

	internal static class SDGKNotificationMatch
	{
		internal static readonly DGKNotificationMatch Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKNotificationMatch))]
		private unsafe static void Invoke(IntPtr block, IntPtr match, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKNotificationMatch)ptr->Target)?.Invoke(Runtime.GetNSObject<GKMatch>(match), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKNotificationMatch : TrampolineBlockBase
	{
		private DGKNotificationMatch invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKNotificationMatch(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKNotificationMatch>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKNotificationMatch? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKNotificationMatch gKNotificationMatch = (GKNotificationMatch)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKNotificationMatch ?? new GKNotificationMatch(new NIDGKNotificationMatch((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKMatch match, NSError error)
		{
			invoker(base.BlockPointer, match?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKPlayerPhotoLoaded))]
	internal delegate void DGKPlayerPhotoLoaded(IntPtr block, IntPtr photo, IntPtr error);

	internal static class SDGKPlayerPhotoLoaded
	{
		internal static readonly DGKPlayerPhotoLoaded Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKPlayerPhotoLoaded))]
		private unsafe static void Invoke(IntPtr block, IntPtr photo, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKPlayerPhotoLoaded)ptr->Target)?.Invoke(Runtime.GetNSObject<NSImage>(photo), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKPlayerPhotoLoaded : TrampolineBlockBase
	{
		private DGKPlayerPhotoLoaded invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKPlayerPhotoLoaded(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKPlayerPhotoLoaded>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKPlayerPhotoLoaded? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKPlayerPhotoLoaded gKPlayerPhotoLoaded = (GKPlayerPhotoLoaded)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKPlayerPhotoLoaded ?? new GKPlayerPhotoLoaded(new NIDGKPlayerPhotoLoaded((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSImage photo, NSError error)
		{
			invoker(base.BlockPointer, photo?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKPlayerStateUpdateHandler))]
	internal delegate void DGKPlayerStateUpdateHandler(IntPtr block, IntPtr playerId, nint state);

	internal static class SDGKPlayerStateUpdateHandler
	{
		internal static readonly DGKPlayerStateUpdateHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKPlayerStateUpdateHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr playerId, nint state)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKPlayerStateUpdateHandler)ptr->Target)?.Invoke(NSString.FromHandle(playerId), (GKVoiceChatPlayerState)(long)state);
		}
	}

	internal sealed class NIDGKPlayerStateUpdateHandler : TrampolineBlockBase
	{
		private DGKPlayerStateUpdateHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKPlayerStateUpdateHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKPlayerStateUpdateHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKPlayerStateUpdateHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKPlayerStateUpdateHandler gKPlayerStateUpdateHandler = (GKPlayerStateUpdateHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKPlayerStateUpdateHandler ?? new GKPlayerStateUpdateHandler(new NIDGKPlayerStateUpdateHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string playerId, GKVoiceChatPlayerState state)
		{
			IntPtr intPtr = NSString.CreateNative(playerId);
			invoker(base.BlockPointer, intPtr, (nint)(long)state);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKPlayersHandler))]
	internal delegate void DGKPlayersHandler(IntPtr block, IntPtr players, IntPtr error);

	internal static class SDGKPlayersHandler
	{
		internal static readonly DGKPlayersHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKPlayersHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr players, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKPlayersHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKPlayer>(players), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKPlayersHandler : TrampolineBlockBase
	{
		private DGKPlayersHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKPlayersHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKPlayersHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKPlayersHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKPlayersHandler gKPlayersHandler = (GKPlayersHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKPlayersHandler ?? new GKPlayersHandler(new NIDGKPlayersHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKPlayer[] players, NSError error)
		{
			NSArray nSArray = ((players == null) ? null : NSArray.FromNSObjects(players));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKQueryHandler))]
	internal delegate void DGKQueryHandler(IntPtr block, nint activity, IntPtr error);

	internal static class SDGKQueryHandler
	{
		internal static readonly DGKQueryHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKQueryHandler))]
		private unsafe static void Invoke(IntPtr block, nint activity, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKQueryHandler)ptr->Target)?.Invoke(activity, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKQueryHandler : TrampolineBlockBase
	{
		private DGKQueryHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKQueryHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKQueryHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKQueryHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKQueryHandler gKQueryHandler = (GKQueryHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKQueryHandler ?? new GKQueryHandler(new NIDGKQueryHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint activity, NSError error)
		{
			invoker(base.BlockPointer, activity, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKScoresLoadedHandler))]
	internal delegate void DGKScoresLoadedHandler(IntPtr block, IntPtr scoreArray, IntPtr error);

	internal static class SDGKScoresLoadedHandler
	{
		internal static readonly DGKScoresLoadedHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKScoresLoadedHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr scoreArray, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKScoresLoadedHandler)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKScore>(scoreArray), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKScoresLoadedHandler : TrampolineBlockBase
	{
		private DGKScoresLoadedHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKScoresLoadedHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKScoresLoadedHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKScoresLoadedHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKScoresLoadedHandler gKScoresLoadedHandler = (GKScoresLoadedHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKScoresLoadedHandler ?? new GKScoresLoadedHandler(new NIDGKScoresLoadedHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKScore[] scoreArray, NSError error)
		{
			NSArray nSArray = ((scoreArray == null) ? null : NSArray.FromNSObjects(scoreArray));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKTurnBasedMatchData))]
	internal delegate void DGKTurnBasedMatchData(IntPtr block, IntPtr matchData, IntPtr error);

	internal static class SDGKTurnBasedMatchData
	{
		internal static readonly DGKTurnBasedMatchData Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKTurnBasedMatchData))]
		private unsafe static void Invoke(IntPtr block, IntPtr matchData, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKTurnBasedMatchData)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(matchData), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKTurnBasedMatchData : TrampolineBlockBase
	{
		private DGKTurnBasedMatchData invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKTurnBasedMatchData(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKTurnBasedMatchData>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKTurnBasedMatchData? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKTurnBasedMatchData gKTurnBasedMatchData = (GKTurnBasedMatchData)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKTurnBasedMatchData ?? new GKTurnBasedMatchData(new NIDGKTurnBasedMatchData((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData matchData, NSError error)
		{
			invoker(base.BlockPointer, matchData?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKTurnBasedMatchRequest))]
	internal delegate void DGKTurnBasedMatchRequest(IntPtr block, IntPtr match, IntPtr error);

	internal static class SDGKTurnBasedMatchRequest
	{
		internal static readonly DGKTurnBasedMatchRequest Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKTurnBasedMatchRequest))]
		private unsafe static void Invoke(IntPtr block, IntPtr match, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKTurnBasedMatchRequest)ptr->Target)?.Invoke(Runtime.GetNSObject<GKTurnBasedMatch>(match), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKTurnBasedMatchRequest : TrampolineBlockBase
	{
		private DGKTurnBasedMatchRequest invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKTurnBasedMatchRequest(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKTurnBasedMatchRequest>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKTurnBasedMatchRequest? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKTurnBasedMatchRequest gKTurnBasedMatchRequest = (GKTurnBasedMatchRequest)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKTurnBasedMatchRequest ?? new GKTurnBasedMatchRequest(new NIDGKTurnBasedMatchRequest((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKTurnBasedMatch match, NSError error)
		{
			invoker(base.BlockPointer, match?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(GKTurnBasedMatchesRequest))]
	internal delegate void DGKTurnBasedMatchesRequest(IntPtr block, IntPtr matches, IntPtr error);

	internal static class SDGKTurnBasedMatchesRequest
	{
		internal static readonly DGKTurnBasedMatchesRequest Handler = Invoke;

		[MonoPInvokeCallback(typeof(DGKTurnBasedMatchesRequest))]
		private unsafe static void Invoke(IntPtr block, IntPtr matches, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((GKTurnBasedMatchesRequest)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKTurnBasedMatch>(matches), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDGKTurnBasedMatchesRequest : TrampolineBlockBase
	{
		private DGKTurnBasedMatchesRequest invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDGKTurnBasedMatchesRequest(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DGKTurnBasedMatchesRequest>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static GKTurnBasedMatchesRequest? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			GKTurnBasedMatchesRequest gKTurnBasedMatchesRequest = (GKTurnBasedMatchesRequest)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return gKTurnBasedMatchesRequest ?? new GKTurnBasedMatchesRequest(new NIDGKTurnBasedMatchesRequest((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKTurnBasedMatch[] matches, NSError error)
		{
			NSArray nSArray = ((matches == null) ? null : NSArray.FromNSObjects(matches));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(JSContextExceptionHandler))]
	internal delegate void DJSContextExceptionHandler(IntPtr block, IntPtr context, IntPtr exception);

	internal static class SDJSContextExceptionHandler
	{
		internal static readonly DJSContextExceptionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DJSContextExceptionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr context, IntPtr exception)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((JSContextExceptionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<JSContext>(context), Runtime.GetNSObject<JSValue>(exception));
		}
	}

	internal sealed class NIDJSContextExceptionHandler : TrampolineBlockBase
	{
		private DJSContextExceptionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDJSContextExceptionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DJSContextExceptionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static JSContextExceptionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			JSContextExceptionHandler jSContextExceptionHandler = (JSContextExceptionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return jSContextExceptionHandler ?? new JSContextExceptionHandler(new NIDJSContextExceptionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(JSContext context, JSValue exception)
		{
			invoker(base.BlockPointer, context?.Handle ?? IntPtr.Zero, exception?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(JSPromiseCreationExecutor))]
	internal delegate void DJSPromiseCreationExecutor(IntPtr block, IntPtr resolve, IntPtr rejected);

	internal static class SDJSPromiseCreationExecutor
	{
		internal static readonly DJSPromiseCreationExecutor Handler = Invoke;

		[MonoPInvokeCallback(typeof(DJSPromiseCreationExecutor))]
		private unsafe static void Invoke(IntPtr block, IntPtr resolve, IntPtr rejected)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((JSPromiseCreationExecutor)ptr->Target)?.Invoke(Runtime.GetNSObject<JSValue>(resolve), Runtime.GetNSObject<JSValue>(rejected));
		}
	}

	internal sealed class NIDJSPromiseCreationExecutor : TrampolineBlockBase
	{
		private DJSPromiseCreationExecutor invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDJSPromiseCreationExecutor(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DJSPromiseCreationExecutor>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static JSPromiseCreationExecutor? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			JSPromiseCreationExecutor jSPromiseCreationExecutor = (JSPromiseCreationExecutor)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return jSPromiseCreationExecutor ?? new JSPromiseCreationExecutor(new NIDJSPromiseCreationExecutor((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(JSValue resolve, JSValue rejected)
		{
			invoker(base.BlockPointer, resolve?.Handle ?? IntPtr.Zero, rejected?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(LAContextReplyHandler))]
	internal delegate void DLAContextReplyHandler(IntPtr block, bool success, IntPtr error);

	internal static class SDLAContextReplyHandler
	{
		internal static readonly DLAContextReplyHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DLAContextReplyHandler))]
		private unsafe static void Invoke(IntPtr block, bool success, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((LAContextReplyHandler)ptr->Target)?.Invoke(success, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDLAContextReplyHandler : TrampolineBlockBase
	{
		private DLAContextReplyHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDLAContextReplyHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DLAContextReplyHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static LAContextReplyHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			LAContextReplyHandler lAContextReplyHandler = (LAContextReplyHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return lAContextReplyHandler ?? new LAContextReplyHandler(new NIDLAContextReplyHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool success, NSError error)
		{
			invoker(base.BlockPointer, success, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MKDirectionsHandler))]
	internal delegate void DMKDirectionsHandler(IntPtr block, IntPtr response, IntPtr error);

	internal static class SDMKDirectionsHandler
	{
		internal static readonly DMKDirectionsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMKDirectionsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr response, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MKDirectionsHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MKDirectionsResponse>(response), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMKDirectionsHandler : TrampolineBlockBase
	{
		private DMKDirectionsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMKDirectionsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMKDirectionsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MKDirectionsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MKDirectionsHandler mKDirectionsHandler = (MKDirectionsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mKDirectionsHandler ?? new MKDirectionsHandler(new NIDMKDirectionsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MKDirectionsResponse response, NSError error)
		{
			invoker(base.BlockPointer, response?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MKETAHandler))]
	internal delegate void DMKETAHandler(IntPtr block, IntPtr response, IntPtr error);

	internal static class SDMKETAHandler
	{
		internal static readonly DMKETAHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMKETAHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr response, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MKETAHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MKETAResponse>(response), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMKETAHandler : TrampolineBlockBase
	{
		private DMKETAHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMKETAHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMKETAHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MKETAHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MKETAHandler mKETAHandler = (MKETAHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mKETAHandler ?? new MKETAHandler(new NIDMKETAHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MKETAResponse response, NSError error)
		{
			invoker(base.BlockPointer, response?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MKLocalSearchCompletionHandler))]
	internal delegate void DMKLocalSearchCompletionHandler(IntPtr block, IntPtr response, IntPtr error);

	internal static class SDMKLocalSearchCompletionHandler
	{
		internal static readonly DMKLocalSearchCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMKLocalSearchCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr response, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MKLocalSearchCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MKLocalSearchResponse>(response), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMKLocalSearchCompletionHandler : TrampolineBlockBase
	{
		private DMKLocalSearchCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMKLocalSearchCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMKLocalSearchCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MKLocalSearchCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MKLocalSearchCompletionHandler mKLocalSearchCompletionHandler = (MKLocalSearchCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mKLocalSearchCompletionHandler ?? new MKLocalSearchCompletionHandler(new NIDMKLocalSearchCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MKLocalSearchResponse response, NSError error)
		{
			invoker(base.BlockPointer, response?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MKMapSnapshotCompletionHandler))]
	internal delegate void DMKMapSnapshotCompletionHandler(IntPtr block, IntPtr snapshot, IntPtr error);

	internal static class SDMKMapSnapshotCompletionHandler
	{
		internal static readonly DMKMapSnapshotCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMKMapSnapshotCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr snapshot, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MKMapSnapshotCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MKMapSnapshot>(snapshot), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMKMapSnapshotCompletionHandler : TrampolineBlockBase
	{
		private DMKMapSnapshotCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMKMapSnapshotCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMKMapSnapshotCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MKMapSnapshotCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MKMapSnapshotCompletionHandler mKMapSnapshotCompletionHandler = (MKMapSnapshotCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mKMapSnapshotCompletionHandler ?? new MKMapSnapshotCompletionHandler(new NIDMKMapSnapshotCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MKMapSnapshot snapshot, NSError error)
		{
			invoker(base.BlockPointer, snapshot?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MKTileOverlayLoadTileCompletionHandler))]
	internal delegate void DMKTileOverlayLoadTileCompletionHandler(IntPtr block, IntPtr tileData, IntPtr error);

	internal static class SDMKTileOverlayLoadTileCompletionHandler
	{
		internal static readonly DMKTileOverlayLoadTileCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMKTileOverlayLoadTileCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr tileData, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MKTileOverlayLoadTileCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(tileData), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMKTileOverlayLoadTileCompletionHandler : TrampolineBlockBase
	{
		private DMKTileOverlayLoadTileCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMKTileOverlayLoadTileCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMKTileOverlayLoadTileCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MKTileOverlayLoadTileCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MKTileOverlayLoadTileCompletionHandler mKTileOverlayLoadTileCompletionHandler = (MKTileOverlayLoadTileCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mKTileOverlayLoadTileCompletionHandler ?? new MKTileOverlayLoadTileCompletionHandler(new NIDMKTileOverlayLoadTileCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData tileData, NSError error)
		{
			invoker(base.BlockPointer, tileData?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MPMediaItemEnumerator))]
	internal delegate void DMPMediaItemEnumerator(IntPtr block, IntPtr property, IntPtr value, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDMPMediaItemEnumerator
	{
		internal static readonly DMPMediaItemEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMPMediaItemEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr property, IntPtr value, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MPMediaItemEnumerator)ptr->Target)?.Invoke(NSString.FromHandle(property), Runtime.GetNSObject<NSObject>(value), ref stop);
		}
	}

	internal sealed class NIDMPMediaItemEnumerator : TrampolineBlockBase
	{
		private DMPMediaItemEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMPMediaItemEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMPMediaItemEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPMediaItemEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MPMediaItemEnumerator mPMediaItemEnumerator = (MPMediaItemEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mPMediaItemEnumerator ?? new MPMediaItemEnumerator(new NIDMPMediaItemEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string property, NSObject value, ref bool stop)
		{
			IntPtr intPtr = NSString.CreateNative(property);
			invoker(base.BlockPointer, intPtr, value?.Handle ?? IntPtr.Zero, ref stop);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MTLDeallocator))]
	internal delegate void DMTLDeallocator(IntPtr block, IntPtr pointer, nuint length);

	internal static class SDMTLDeallocator
	{
		internal static readonly DMTLDeallocator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMTLDeallocator))]
		private unsafe static void Invoke(IntPtr block, IntPtr pointer, nuint length)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MTLDeallocator)ptr->Target)?.Invoke(pointer, length);
		}
	}

	internal sealed class NIDMTLDeallocator : TrampolineBlockBase
	{
		private DMTLDeallocator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMTLDeallocator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMTLDeallocator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MTLDeallocator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MTLDeallocator mTLDeallocator = (MTLDeallocator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mTLDeallocator ?? new MTLDeallocator(new NIDMTLDeallocator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr pointer, nuint length)
		{
			invoker(base.BlockPointer, pointer, length);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MTLNewComputePipelineStateWithReflectionCompletionHandler))]
	internal delegate void DMTLNewComputePipelineStateWithReflectionCompletionHandler(IntPtr block, IntPtr computePipelineState, IntPtr reflection, IntPtr error);

	internal static class SDMTLNewComputePipelineStateWithReflectionCompletionHandler
	{
		internal static readonly DMTLNewComputePipelineStateWithReflectionCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMTLNewComputePipelineStateWithReflectionCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr computePipelineState, IntPtr reflection, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MTLNewComputePipelineStateWithReflectionCompletionHandler)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLComputePipelineState>(computePipelineState, owns: false), Runtime.GetNSObject<MTLComputePipelineReflection>(reflection), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMTLNewComputePipelineStateWithReflectionCompletionHandler : TrampolineBlockBase
	{
		private DMTLNewComputePipelineStateWithReflectionCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMTLNewComputePipelineStateWithReflectionCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMTLNewComputePipelineStateWithReflectionCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MTLNewComputePipelineStateWithReflectionCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MTLNewComputePipelineStateWithReflectionCompletionHandler mTLNewComputePipelineStateWithReflectionCompletionHandler = (MTLNewComputePipelineStateWithReflectionCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mTLNewComputePipelineStateWithReflectionCompletionHandler ?? new MTLNewComputePipelineStateWithReflectionCompletionHandler(new NIDMTLNewComputePipelineStateWithReflectionCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLComputePipelineState computePipelineState, MTLComputePipelineReflection reflection, NSError error)
		{
			invoker(base.BlockPointer, computePipelineState?.Handle ?? IntPtr.Zero, reflection?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MTLSharedEventNotificationBlock))]
	internal delegate void DMTLSharedEventNotificationBlock(IntPtr block, IntPtr @event, ulong value);

	internal static class SDMTLSharedEventNotificationBlock
	{
		internal static readonly DMTLSharedEventNotificationBlock Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMTLSharedEventNotificationBlock))]
		private unsafe static void Invoke(IntPtr block, IntPtr @event, ulong value)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MTLSharedEventNotificationBlock)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLSharedEvent>(@event, owns: false), value);
		}
	}

	internal sealed class NIDMTLSharedEventNotificationBlock : TrampolineBlockBase
	{
		private DMTLSharedEventNotificationBlock invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMTLSharedEventNotificationBlock(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMTLSharedEventNotificationBlock>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MTLSharedEventNotificationBlock? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MTLSharedEventNotificationBlock mTLSharedEventNotificationBlock = (MTLSharedEventNotificationBlock)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mTLSharedEventNotificationBlock ?? new MTLSharedEventNotificationBlock(new NIDMTLSharedEventNotificationBlock((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLSharedEvent @event, ulong value)
		{
			invoker(base.BlockPointer, @event?.Handle ?? IntPtr.Zero, value);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MTKTextureLoaderArrayCallback))]
	internal delegate void DMTKTextureLoaderArrayCallback(IntPtr block, IntPtr textures, IntPtr error);

	internal static class SDMTKTextureLoaderArrayCallback
	{
		internal static readonly DMTKTextureLoaderArrayCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMTKTextureLoaderArrayCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr textures, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MTKTextureLoaderArrayCallback)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<IMTLTexture>(textures), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMTKTextureLoaderArrayCallback : TrampolineBlockBase
	{
		private DMTKTextureLoaderArrayCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMTKTextureLoaderArrayCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMTKTextureLoaderArrayCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MTKTextureLoaderArrayCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MTKTextureLoaderArrayCallback mTKTextureLoaderArrayCallback = (MTKTextureLoaderArrayCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mTKTextureLoaderArrayCallback ?? new MTKTextureLoaderArrayCallback(new NIDMTKTextureLoaderArrayCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLTexture[] textures, NSError? error)
		{
			NSArray nSArray = ((textures == null) ? null : NSArray.FromNSObjects(textures));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MTKTextureLoaderCallback))]
	internal delegate void DMTKTextureLoaderCallback(IntPtr block, IntPtr texture, IntPtr error);

	internal static class SDMTKTextureLoaderCallback
	{
		internal static readonly DMTKTextureLoaderCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMTKTextureLoaderCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr texture, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MTKTextureLoaderCallback)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLTexture>(texture, owns: false), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMTKTextureLoaderCallback : TrampolineBlockBase
	{
		private DMTKTextureLoaderCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMTKTextureLoaderCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMTKTextureLoaderCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MTKTextureLoaderCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MTKTextureLoaderCallback mTKTextureLoaderCallback = (MTKTextureLoaderCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mTKTextureLoaderCallback ?? new MTKTextureLoaderCallback(new NIDMTKTextureLoaderCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLTexture? texture, NSError? error)
		{
			invoker(base.BlockPointer, texture?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MPSAccelerationStructureCompletionHandler))]
	internal delegate void DMPSAccelerationStructureCompletionHandler(IntPtr block, IntPtr structure);

	internal static class SDMPSAccelerationStructureCompletionHandler
	{
		internal static readonly DMPSAccelerationStructureCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMPSAccelerationStructureCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr structure)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MPSAccelerationStructureCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MPSAccelerationStructure>(structure));
		}
	}

	internal sealed class NIDMPSAccelerationStructureCompletionHandler : TrampolineBlockBase
	{
		private DMPSAccelerationStructureCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMPSAccelerationStructureCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMPSAccelerationStructureCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSAccelerationStructureCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MPSAccelerationStructureCompletionHandler mPSAccelerationStructureCompletionHandler = (MPSAccelerationStructureCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mPSAccelerationStructureCompletionHandler ?? new MPSAccelerationStructureCompletionHandler(new NIDMPSAccelerationStructureCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MPSAccelerationStructure? structure)
		{
			invoker(base.BlockPointer, structure?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MPSCopyAllocator))]
	internal delegate IntPtr DMPSCopyAllocator(IntPtr block, IntPtr filter, IntPtr commandBuffer, IntPtr sourceTexture);

	internal static class SDMPSCopyAllocator
	{
		internal static readonly DMPSCopyAllocator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMPSCopyAllocator))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr filter, IntPtr commandBuffer, IntPtr sourceTexture)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			MPSCopyAllocator mPSCopyAllocator = (MPSCopyAllocator)ptr->Target;
			return mPSCopyAllocator(Runtime.GetNSObject<MPSKernel>(filter), Runtime.GetNSObject<NSObject>(commandBuffer), Runtime.GetNSObject<NSObject>(sourceTexture))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDMPSCopyAllocator : TrampolineBlockBase
	{
		private DMPSCopyAllocator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMPSCopyAllocator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMPSCopyAllocator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSCopyAllocator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MPSCopyAllocator mPSCopyAllocator = (MPSCopyAllocator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mPSCopyAllocator ?? new MPSCopyAllocator(new NIDMPSCopyAllocator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSObject Invoke(MPSKernel filter, NSObject commandBuffer, NSObject sourceTexture)
		{
			return Runtime.GetNSObject(invoker(base.BlockPointer, filter?.Handle ?? IntPtr.Zero, commandBuffer?.Handle ?? IntPtr.Zero, sourceTexture?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MPSGradientNodeHandler))]
	internal delegate void DMPSGradientNodeHandler(IntPtr block, IntPtr gradientNode, IntPtr inferenceNode, IntPtr inferenceSource, IntPtr gradientSource);

	internal static class SDMPSGradientNodeHandler
	{
		internal static readonly DMPSGradientNodeHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMPSGradientNodeHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr gradientNode, IntPtr inferenceNode, IntPtr inferenceSource, IntPtr gradientSource)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MPSGradientNodeHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MPSNNFilterNode>(gradientNode), Runtime.GetNSObject<MPSNNFilterNode>(inferenceNode), Runtime.GetNSObject<MPSNNImageNode>(inferenceSource), Runtime.GetNSObject<MPSNNImageNode>(gradientSource));
		}
	}

	internal sealed class NIDMPSGradientNodeHandler : TrampolineBlockBase
	{
		private DMPSGradientNodeHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMPSGradientNodeHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMPSGradientNodeHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSGradientNodeHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MPSGradientNodeHandler mPSGradientNodeHandler = (MPSGradientNodeHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mPSGradientNodeHandler ?? new MPSGradientNodeHandler(new NIDMPSGradientNodeHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MPSNNFilterNode gradientNode, MPSNNFilterNode inferenceNode, MPSNNImageNode inferenceSource, MPSNNImageNode gradientSource)
		{
			invoker(base.BlockPointer, gradientNode?.Handle ?? IntPtr.Zero, inferenceNode?.Handle ?? IntPtr.Zero, inferenceSource?.Handle ?? IntPtr.Zero, gradientSource?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MDLObjectHandler))]
	internal delegate void DMDLObjectHandler(IntPtr block, IntPtr mdlObject, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDMDLObjectHandler
	{
		internal static readonly DMDLObjectHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMDLObjectHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr mdlObject, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MDLObjectHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<MDLObject>(mdlObject), ref stop);
		}
	}

	internal sealed class NIDMDLObjectHandler : TrampolineBlockBase
	{
		private DMDLObjectHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMDLObjectHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMDLObjectHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MDLObjectHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MDLObjectHandler mDLObjectHandler = (MDLObjectHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mDLObjectHandler ?? new MDLObjectHandler(new NIDMDLObjectHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MDLObject mdlObject, ref bool stop)
		{
			invoker(base.BlockPointer, mdlObject?.Handle ?? IntPtr.Zero, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MCNearbyServiceAdvertiserInvitationHandler))]
	internal delegate void DMCNearbyServiceAdvertiserInvitationHandler(IntPtr block, bool accept, IntPtr session);

	internal static class SDMCNearbyServiceAdvertiserInvitationHandler
	{
		internal static readonly DMCNearbyServiceAdvertiserInvitationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMCNearbyServiceAdvertiserInvitationHandler))]
		private unsafe static void Invoke(IntPtr block, bool accept, IntPtr session)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MCNearbyServiceAdvertiserInvitationHandler)ptr->Target)?.Invoke(accept, Runtime.GetNSObject<MCSession>(session));
		}
	}

	internal sealed class NIDMCNearbyServiceAdvertiserInvitationHandler : TrampolineBlockBase
	{
		private DMCNearbyServiceAdvertiserInvitationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMCNearbyServiceAdvertiserInvitationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMCNearbyServiceAdvertiserInvitationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MCNearbyServiceAdvertiserInvitationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MCNearbyServiceAdvertiserInvitationHandler mCNearbyServiceAdvertiserInvitationHandler = (MCNearbyServiceAdvertiserInvitationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mCNearbyServiceAdvertiserInvitationHandler ?? new MCNearbyServiceAdvertiserInvitationHandler(new NIDMCNearbyServiceAdvertiserInvitationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool accept, MCSession? session)
		{
			invoker(base.BlockPointer, accept, session?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(MCSessionNearbyConnectionDataForPeerCompletionHandler))]
	internal delegate void DMCSessionNearbyConnectionDataForPeerCompletionHandler(IntPtr block, IntPtr connectionData, IntPtr error);

	internal static class SDMCSessionNearbyConnectionDataForPeerCompletionHandler
	{
		internal static readonly DMCSessionNearbyConnectionDataForPeerCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DMCSessionNearbyConnectionDataForPeerCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr connectionData, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((MCSessionNearbyConnectionDataForPeerCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(connectionData), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDMCSessionNearbyConnectionDataForPeerCompletionHandler : TrampolineBlockBase
	{
		private DMCSessionNearbyConnectionDataForPeerCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDMCSessionNearbyConnectionDataForPeerCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DMCSessionNearbyConnectionDataForPeerCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MCSessionNearbyConnectionDataForPeerCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			MCSessionNearbyConnectionDataForPeerCompletionHandler mCSessionNearbyConnectionDataForPeerCompletionHandler = (MCSessionNearbyConnectionDataForPeerCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return mCSessionNearbyConnectionDataForPeerCompletionHandler ?? new MCSessionNearbyConnectionDataForPeerCompletionHandler(new NIDMCSessionNearbyConnectionDataForPeerCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData connectionData, NSError error)
		{
			invoker(base.BlockPointer, connectionData?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NLEnumerateNeighborsHandler))]
	internal delegate void DNLEnumerateNeighborsHandler(IntPtr block, IntPtr neighbor, double distance, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDNLEnumerateNeighborsHandler
	{
		internal static readonly DNLEnumerateNeighborsHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNLEnumerateNeighborsHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr neighbor, double distance, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NLEnumerateNeighborsHandler)ptr->Target)?.Invoke(NSString.FromHandle(neighbor), distance, ref stop);
		}
	}

	internal sealed class NIDNLEnumerateNeighborsHandler : TrampolineBlockBase
	{
		private DNLEnumerateNeighborsHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNLEnumerateNeighborsHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNLEnumerateNeighborsHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NLEnumerateNeighborsHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NLEnumerateNeighborsHandler nLEnumerateNeighborsHandler = (NLEnumerateNeighborsHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nLEnumerateNeighborsHandler ?? new NLEnumerateNeighborsHandler(new NIDNLEnumerateNeighborsHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string neighbor, double distance, ref bool stop)
		{
			IntPtr intPtr = NSString.CreateNative(neighbor);
			invoker(base.BlockPointer, intPtr, distance, ref stop);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NLTaggerEnumerateTagsContinuationHandler))]
	internal delegate void DNLTaggerEnumerateTagsContinuationHandler(IntPtr block, IntPtr tag, NSRange tokenRange, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDNLTaggerEnumerateTagsContinuationHandler
	{
		internal static readonly DNLTaggerEnumerateTagsContinuationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNLTaggerEnumerateTagsContinuationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr tag, NSRange tokenRange, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NLTaggerEnumerateTagsContinuationHandler nLTaggerEnumerateTagsContinuationHandler = (NLTaggerEnumerateTagsContinuationHandler)ptr->Target;
			if (nLTaggerEnumerateTagsContinuationHandler != null)
			{
				nLTaggerEnumerateTagsContinuationHandler(Runtime.GetNSObject<NSString>(tag), tokenRange, out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDNLTaggerEnumerateTagsContinuationHandler : TrampolineBlockBase
	{
		private DNLTaggerEnumerateTagsContinuationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNLTaggerEnumerateTagsContinuationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNLTaggerEnumerateTagsContinuationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NLTaggerEnumerateTagsContinuationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NLTaggerEnumerateTagsContinuationHandler nLTaggerEnumerateTagsContinuationHandler = (NLTaggerEnumerateTagsContinuationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nLTaggerEnumerateTagsContinuationHandler ?? new NLTaggerEnumerateTagsContinuationHandler(new NIDNLTaggerEnumerateTagsContinuationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSString tag, NSRange tokenRange, out bool stop)
		{
			invoker(base.BlockPointer, (tag == null) ? IntPtr.Zero : tag.Handle, tokenRange, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NLTokenizerEnumerateContinuationHandler))]
	internal delegate void DNLTokenizerEnumerateContinuationHandler(IntPtr block, NSRange tokenRange, nuint flags, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDNLTokenizerEnumerateContinuationHandler
	{
		internal static readonly DNLTokenizerEnumerateContinuationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNLTokenizerEnumerateContinuationHandler))]
		private unsafe static void Invoke(IntPtr block, NSRange tokenRange, nuint flags, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NLTokenizerEnumerateContinuationHandler nLTokenizerEnumerateContinuationHandler = (NLTokenizerEnumerateContinuationHandler)ptr->Target;
			if (nLTokenizerEnumerateContinuationHandler != null)
			{
				nLTokenizerEnumerateContinuationHandler(tokenRange, (NLTokenizerAttributes)(ulong)flags, out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDNLTokenizerEnumerateContinuationHandler : TrampolineBlockBase
	{
		private DNLTokenizerEnumerateContinuationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNLTokenizerEnumerateContinuationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNLTokenizerEnumerateContinuationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NLTokenizerEnumerateContinuationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NLTokenizerEnumerateContinuationHandler nLTokenizerEnumerateContinuationHandler = (NLTokenizerEnumerateContinuationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nLTokenizerEnumerateContinuationHandler ?? new NLTokenizerEnumerateContinuationHandler(new NIDNLTokenizerEnumerateContinuationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSRange tokenRange, NLTokenizerAttributes flags, out bool stop)
		{
			invoker(base.BlockPointer, tokenRange, (nuint)(ulong)flags, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NEDatagramRead))]
	internal delegate void DNEDatagramRead(IntPtr block, IntPtr datagrams, IntPtr remoteEndpoints, IntPtr error);

	internal static class SDNEDatagramRead
	{
		internal static readonly DNEDatagramRead Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNEDatagramRead))]
		private unsafe static void Invoke(IntPtr block, IntPtr datagrams, IntPtr remoteEndpoints, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NEDatagramRead)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSData>(datagrams), NSArray.ArrayFromHandle<NWEndpoint>(remoteEndpoints), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNEDatagramRead : TrampolineBlockBase
	{
		private DNEDatagramRead invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNEDatagramRead(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNEDatagramRead>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NEDatagramRead? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NEDatagramRead nEDatagramRead = (NEDatagramRead)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nEDatagramRead ?? new NEDatagramRead(new NIDNEDatagramRead((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData[] datagrams, NWEndpoint[] remoteEndpoints, NSError error)
		{
			NSArray nSArray = ((datagrams == null) ? null : NSArray.FromNSObjects(datagrams));
			NSArray nSArray2 = ((remoteEndpoints == null) ? null : NSArray.FromNSObjects(remoteEndpoints));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NEFilterPacketHandler))]
	internal delegate IntPtr DNEFilterPacketHandler(IntPtr block, IntPtr context, IntPtr @interface, nint directiom, IntPtr packetBytes, nuint packetLength);

	internal static class SDNEFilterPacketHandler
	{
		internal static readonly DNEFilterPacketHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNEFilterPacketHandler))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr context, IntPtr @interface, nint directiom, IntPtr packetBytes, nuint packetLength)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			NEFilterPacketHandler nEFilterPacketHandler = (NEFilterPacketHandler)ptr->Target;
			NEFilterPacketProviderVerdict nEFilterPacketProviderVerdict = nEFilterPacketHandler(Runtime.GetNSObject<NEFilterPacketContext>(context), @interface, (NETrafficDirection)(long)directiom, packetBytes, packetLength);
			return (IntPtr)(long)nEFilterPacketProviderVerdict;
		}
	}

	internal sealed class NIDNEFilterPacketHandler : TrampolineBlockBase
	{
		private DNEFilterPacketHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNEFilterPacketHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNEFilterPacketHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NEFilterPacketHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NEFilterPacketHandler nEFilterPacketHandler = (NEFilterPacketHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nEFilterPacketHandler ?? new NEFilterPacketHandler(new NIDNEFilterPacketHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NEFilterPacketProviderVerdict Invoke(NEFilterPacketContext context, IntPtr @interface, NETrafficDirection directiom, IntPtr packetBytes, nuint packetLength)
		{
			return (NEFilterPacketProviderVerdict)(long)invoker(base.BlockPointer, context?.Handle ?? IntPtr.Zero, @interface, (nint)(long)directiom, packetBytes, packetLength);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHAssetImageProgressHandler))]
	internal delegate void DPHAssetImageProgressHandler(IntPtr block, double progress, IntPtr error, [MarshalAs(UnmanagedType.I1)] out bool stop, IntPtr info);

	internal static class SDPHAssetImageProgressHandler
	{
		internal static readonly DPHAssetImageProgressHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHAssetImageProgressHandler))]
		private unsafe static void Invoke(IntPtr block, double progress, IntPtr error, [MarshalAs(UnmanagedType.I1)] out bool stop, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			PHAssetImageProgressHandler pHAssetImageProgressHandler = (PHAssetImageProgressHandler)ptr->Target;
			if (pHAssetImageProgressHandler != null)
			{
				pHAssetImageProgressHandler(progress, Runtime.GetNSObject<NSError>(error), out stop, Runtime.GetNSObject<NSDictionary>(info));
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDPHAssetImageProgressHandler : TrampolineBlockBase
	{
		private DPHAssetImageProgressHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHAssetImageProgressHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHAssetImageProgressHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHAssetImageProgressHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHAssetImageProgressHandler pHAssetImageProgressHandler = (PHAssetImageProgressHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHAssetImageProgressHandler ?? new PHAssetImageProgressHandler(new NIDPHAssetImageProgressHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(double progress, NSError error, out bool stop, NSDictionary info)
		{
			invoker(base.BlockPointer, progress, error?.Handle ?? IntPtr.Zero, out stop, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHAssetVideoProgressHandler))]
	internal delegate void DPHAssetVideoProgressHandler(IntPtr block, double progress, IntPtr error, [MarshalAs(UnmanagedType.I1)] out bool stop, IntPtr info);

	internal static class SDPHAssetVideoProgressHandler
	{
		internal static readonly DPHAssetVideoProgressHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHAssetVideoProgressHandler))]
		private unsafe static void Invoke(IntPtr block, double progress, IntPtr error, [MarshalAs(UnmanagedType.I1)] out bool stop, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			PHAssetVideoProgressHandler pHAssetVideoProgressHandler = (PHAssetVideoProgressHandler)ptr->Target;
			if (pHAssetVideoProgressHandler != null)
			{
				pHAssetVideoProgressHandler(progress, Runtime.GetNSObject<NSError>(error), out stop, Runtime.GetNSObject<NSDictionary>(info));
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDPHAssetVideoProgressHandler : TrampolineBlockBase
	{
		private DPHAssetVideoProgressHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHAssetVideoProgressHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHAssetVideoProgressHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHAssetVideoProgressHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHAssetVideoProgressHandler pHAssetVideoProgressHandler = (PHAssetVideoProgressHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHAssetVideoProgressHandler ?? new PHAssetVideoProgressHandler(new NIDPHAssetVideoProgressHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(double progress, NSError error, out bool stop, NSDictionary info)
		{
			invoker(base.BlockPointer, progress, error?.Handle ?? IntPtr.Zero, out stop, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHChangeDetailEnumerator))]
	internal delegate void DPHChangeDetailEnumerator(IntPtr block, nuint fromIndex, nuint toIndex);

	internal static class SDPHChangeDetailEnumerator
	{
		internal static readonly DPHChangeDetailEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHChangeDetailEnumerator))]
		private unsafe static void Invoke(IntPtr block, nuint fromIndex, nuint toIndex)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHChangeDetailEnumerator)ptr->Target)?.Invoke(fromIndex, toIndex);
		}
	}

	internal sealed class NIDPHChangeDetailEnumerator : TrampolineBlockBase
	{
		private DPHChangeDetailEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHChangeDetailEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHChangeDetailEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHChangeDetailEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHChangeDetailEnumerator pHChangeDetailEnumerator = (PHChangeDetailEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHChangeDetailEnumerator ?? new PHChangeDetailEnumerator(new NIDPHChangeDetailEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nuint fromIndex, nuint toIndex)
		{
			invoker(base.BlockPointer, fromIndex, toIndex);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHContentEditingHandler))]
	internal delegate void DPHContentEditingHandler(IntPtr block, IntPtr contentEditingInput, IntPtr requestStatusInfo);

	internal static class SDPHContentEditingHandler
	{
		internal static readonly DPHContentEditingHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHContentEditingHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr contentEditingInput, IntPtr requestStatusInfo)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHContentEditingHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<PHContentEditingInput>(contentEditingInput), Runtime.GetNSObject<NSDictionary>(requestStatusInfo));
		}
	}

	internal sealed class NIDPHContentEditingHandler : TrampolineBlockBase
	{
		private DPHContentEditingHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHContentEditingHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHContentEditingHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHContentEditingHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHContentEditingHandler pHContentEditingHandler = (PHContentEditingHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHContentEditingHandler ?? new PHContentEditingHandler(new NIDPHContentEditingHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHContentEditingInput contentEditingInput, NSDictionary requestStatusInfo)
		{
			invoker(base.BlockPointer, contentEditingInput?.Handle ?? IntPtr.Zero, requestStatusInfo?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHFetchResultEnumerator))]
	internal delegate void DPHFetchResultEnumerator(IntPtr block, IntPtr element, nuint elementIndex, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDPHFetchResultEnumerator
	{
		internal static readonly DPHFetchResultEnumerator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHFetchResultEnumerator))]
		private unsafe static void Invoke(IntPtr block, IntPtr element, nuint elementIndex, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			PHFetchResultEnumerator pHFetchResultEnumerator = (PHFetchResultEnumerator)ptr->Target;
			if (pHFetchResultEnumerator != null)
			{
				pHFetchResultEnumerator(Runtime.GetNSObject<NSObject>(element), elementIndex, out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDPHFetchResultEnumerator : TrampolineBlockBase
	{
		private DPHFetchResultEnumerator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHFetchResultEnumerator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHFetchResultEnumerator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHFetchResultEnumerator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHFetchResultEnumerator pHFetchResultEnumerator = (PHFetchResultEnumerator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHFetchResultEnumerator ?? new PHFetchResultEnumerator(new NIDPHFetchResultEnumerator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject element, nuint elementIndex, out bool stop)
		{
			invoker(base.BlockPointer, element?.Handle ?? IntPtr.Zero, elementIndex, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHImageManagerRequestAvAssetHandler))]
	internal delegate void DPHImageManagerRequestAvAssetHandler(IntPtr block, IntPtr asset, IntPtr audioMix, IntPtr info);

	internal static class SDPHImageManagerRequestAvAssetHandler
	{
		internal static readonly DPHImageManagerRequestAvAssetHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHImageManagerRequestAvAssetHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr asset, IntPtr audioMix, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHImageManagerRequestAvAssetHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<AVAsset>(asset), Runtime.GetNSObject<AVAudioMix>(audioMix), Runtime.GetNSObject<NSDictionary>(info));
		}
	}

	internal sealed class NIDPHImageManagerRequestAvAssetHandler : TrampolineBlockBase
	{
		private DPHImageManagerRequestAvAssetHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHImageManagerRequestAvAssetHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHImageManagerRequestAvAssetHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHImageManagerRequestAvAssetHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHImageManagerRequestAvAssetHandler pHImageManagerRequestAvAssetHandler = (PHImageManagerRequestAvAssetHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHImageManagerRequestAvAssetHandler ?? new PHImageManagerRequestAvAssetHandler(new NIDPHImageManagerRequestAvAssetHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAsset asset, AVAudioMix audioMix, NSDictionary info)
		{
			invoker(base.BlockPointer, asset?.Handle ?? IntPtr.Zero, audioMix?.Handle ?? IntPtr.Zero, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHImageManagerRequestExportHandler))]
	internal delegate void DPHImageManagerRequestExportHandler(IntPtr block, IntPtr exportSession, IntPtr info);

	internal static class SDPHImageManagerRequestExportHandler
	{
		internal static readonly DPHImageManagerRequestExportHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHImageManagerRequestExportHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr exportSession, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHImageManagerRequestExportHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<AVAssetExportSession>(exportSession), Runtime.GetNSObject<NSDictionary>(info));
		}
	}

	internal sealed class NIDPHImageManagerRequestExportHandler : TrampolineBlockBase
	{
		private DPHImageManagerRequestExportHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHImageManagerRequestExportHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHImageManagerRequestExportHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHImageManagerRequestExportHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHImageManagerRequestExportHandler pHImageManagerRequestExportHandler = (PHImageManagerRequestExportHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHImageManagerRequestExportHandler ?? new PHImageManagerRequestExportHandler(new NIDPHImageManagerRequestExportHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAssetExportSession exportSession, NSDictionary info)
		{
			invoker(base.BlockPointer, exportSession?.Handle ?? IntPtr.Zero, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHImageManagerRequestImageDataHandler))]
	internal delegate void DPHImageManagerRequestImageDataHandler(IntPtr block, IntPtr imageData, IntPtr dataUti, CGImagePropertyOrientation orientation, IntPtr info);

	internal static class SDPHImageManagerRequestImageDataHandler
	{
		internal static readonly DPHImageManagerRequestImageDataHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHImageManagerRequestImageDataHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr imageData, IntPtr dataUti, CGImagePropertyOrientation orientation, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHImageManagerRequestImageDataHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(imageData), NSString.FromHandle(dataUti), orientation, Runtime.GetNSObject<NSDictionary>(info));
		}
	}

	internal sealed class NIDPHImageManagerRequestImageDataHandler : TrampolineBlockBase
	{
		private DPHImageManagerRequestImageDataHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHImageManagerRequestImageDataHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHImageManagerRequestImageDataHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHImageManagerRequestImageDataHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHImageManagerRequestImageDataHandler pHImageManagerRequestImageDataHandler = (PHImageManagerRequestImageDataHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHImageManagerRequestImageDataHandler ?? new PHImageManagerRequestImageDataHandler(new NIDPHImageManagerRequestImageDataHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData? imageData, string? dataUti, CGImagePropertyOrientation orientation, NSDictionary? info)
		{
			IntPtr intPtr = NSString.CreateNative(dataUti);
			invoker(base.BlockPointer, imageData?.Handle ?? IntPtr.Zero, intPtr, orientation, info?.Handle ?? IntPtr.Zero);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHImageManagerRequestLivePhoto))]
	internal delegate void DPHImageManagerRequestLivePhoto(IntPtr block, IntPtr livePhoto, IntPtr info);

	internal static class SDPHImageManagerRequestLivePhoto
	{
		internal static readonly DPHImageManagerRequestLivePhoto Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHImageManagerRequestLivePhoto))]
		private unsafe static void Invoke(IntPtr block, IntPtr livePhoto, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHImageManagerRequestLivePhoto)ptr->Target)?.Invoke(Runtime.GetNSObject<PHLivePhoto>(livePhoto), Runtime.GetNSObject<NSDictionary>(info));
		}
	}

	internal sealed class NIDPHImageManagerRequestLivePhoto : TrampolineBlockBase
	{
		private DPHImageManagerRequestLivePhoto invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHImageManagerRequestLivePhoto(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHImageManagerRequestLivePhoto>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHImageManagerRequestLivePhoto? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHImageManagerRequestLivePhoto pHImageManagerRequestLivePhoto = (PHImageManagerRequestLivePhoto)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHImageManagerRequestLivePhoto ?? new PHImageManagerRequestLivePhoto(new NIDPHImageManagerRequestLivePhoto((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHLivePhoto livePhoto, NSDictionary info)
		{
			invoker(base.BlockPointer, livePhoto?.Handle ?? IntPtr.Zero, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHImageManagerRequestPlayerHandler))]
	internal delegate void DPHImageManagerRequestPlayerHandler(IntPtr block, IntPtr playerItem, IntPtr info);

	internal static class SDPHImageManagerRequestPlayerHandler
	{
		internal static readonly DPHImageManagerRequestPlayerHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHImageManagerRequestPlayerHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr playerItem, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHImageManagerRequestPlayerHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<AVPlayerItem>(playerItem), Runtime.GetNSObject<NSDictionary>(info));
		}
	}

	internal sealed class NIDPHImageManagerRequestPlayerHandler : TrampolineBlockBase
	{
		private DPHImageManagerRequestPlayerHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHImageManagerRequestPlayerHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHImageManagerRequestPlayerHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHImageManagerRequestPlayerHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHImageManagerRequestPlayerHandler pHImageManagerRequestPlayerHandler = (PHImageManagerRequestPlayerHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHImageManagerRequestPlayerHandler ?? new PHImageManagerRequestPlayerHandler(new NIDPHImageManagerRequestPlayerHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVPlayerItem playerItem, NSDictionary info)
		{
			invoker(base.BlockPointer, playerItem?.Handle ?? IntPtr.Zero, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHImageResultHandler))]
	internal delegate void DPHImageResultHandler(IntPtr block, IntPtr result, IntPtr info);

	internal static class SDPHImageResultHandler
	{
		internal static readonly DPHImageResultHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHImageResultHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr result, IntPtr info)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHImageResultHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSImage>(result), Runtime.GetNSObject<NSDictionary>(info));
		}
	}

	internal sealed class NIDPHImageResultHandler : TrampolineBlockBase
	{
		private DPHImageResultHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHImageResultHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHImageResultHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHImageResultHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHImageResultHandler pHImageResultHandler = (PHImageResultHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHImageResultHandler ?? new PHImageResultHandler(new NIDPHImageResultHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSImage result, NSDictionary info)
		{
			invoker(base.BlockPointer, result?.Handle ?? IntPtr.Zero, info?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHLivePhotoFrameProcessingBlock2))]
	internal delegate IntPtr DPHLivePhotoFrameProcessingBlock2(IntPtr block, IntPtr frame, ref IntPtr error);

	internal static class SDPHLivePhotoFrameProcessingBlock2
	{
		internal static readonly DPHLivePhotoFrameProcessingBlock2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHLivePhotoFrameProcessingBlock2))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr frame, ref IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			PHLivePhotoFrameProcessingBlock2 pHLivePhotoFrameProcessingBlock = (PHLivePhotoFrameProcessingBlock2)ptr->Target;
			NSError error2 = Runtime.GetINativeObject<NSError>(error, owns: false);
			CIImage cIImage = pHLivePhotoFrameProcessingBlock(Runtime.GetINativeObject<IPHLivePhotoFrame>(frame, owns: false), ref error2);
			error = error2?.Handle ?? IntPtr.Zero;
			return cIImage?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDPHLivePhotoFrameProcessingBlock2 : TrampolineBlockBase
	{
		private DPHLivePhotoFrameProcessingBlock2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHLivePhotoFrameProcessingBlock2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHLivePhotoFrameProcessingBlock2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHLivePhotoFrameProcessingBlock2? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHLivePhotoFrameProcessingBlock2 pHLivePhotoFrameProcessingBlock = (PHLivePhotoFrameProcessingBlock2)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHLivePhotoFrameProcessingBlock ?? new PHLivePhotoFrameProcessingBlock2(new NIDPHLivePhotoFrameProcessingBlock2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private CIImage Invoke(IPHLivePhotoFrame frame, ref NSError error)
		{
			IntPtr error2 = ((error == null) ? IntPtr.Zero : error.Handle);
			CIImage nSObject = Runtime.GetNSObject<CIImage>(invoker(base.BlockPointer, frame?.Handle ?? IntPtr.Zero, ref error2));
			error = Runtime.GetNSObject<NSError>(error2);
			return nSObject;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(PHProgressHandler))]
	internal delegate void DPHProgressHandler(IntPtr block, double progress, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDPHProgressHandler
	{
		internal static readonly DPHProgressHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DPHProgressHandler))]
		private unsafe static void Invoke(IntPtr block, double progress, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((PHProgressHandler)ptr->Target)?.Invoke(progress, ref stop);
		}
	}

	internal sealed class NIDPHProgressHandler : TrampolineBlockBase
	{
		private DPHProgressHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDPHProgressHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DPHProgressHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static PHProgressHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			PHProgressHandler pHProgressHandler = (PHProgressHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return pHProgressHandler ?? new PHProgressHandler(new NIDPHProgressHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(double progress, ref bool stop)
		{
			invoker(base.BlockPointer, progress, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SFExtensionValidationHandler))]
	internal delegate void DSFExtensionValidationHandler(IntPtr block, bool shouldHide, IntPtr text);

	internal static class SDSFExtensionValidationHandler
	{
		internal static readonly DSFExtensionValidationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSFExtensionValidationHandler))]
		private unsafe static void Invoke(IntPtr block, bool shouldHide, IntPtr text)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SFExtensionValidationHandler)ptr->Target)?.Invoke(shouldHide, Runtime.GetNSObject<NSString>(text));
		}
	}

	internal sealed class NIDSFExtensionValidationHandler : TrampolineBlockBase
	{
		private DSFExtensionValidationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSFExtensionValidationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSFExtensionValidationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SFExtensionValidationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SFExtensionValidationHandler sFExtensionValidationHandler = (SFExtensionValidationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sFExtensionValidationHandler ?? new SFExtensionValidationHandler(new NIDSFExtensionValidationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool shouldHide, NSString text)
		{
			invoker(base.BlockPointer, shouldHide, (text == null) ? IntPtr.Zero : text.Handle);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNActionNodeWithElapsedTimeHandler))]
	internal delegate void DSCNActionNodeWithElapsedTimeHandler(IntPtr block, IntPtr node, nfloat elapsedTime);

	internal static class SDSCNActionNodeWithElapsedTimeHandler
	{
		internal static readonly DSCNActionNodeWithElapsedTimeHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNActionNodeWithElapsedTimeHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr node, nfloat elapsedTime)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNActionNodeWithElapsedTimeHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<SCNNode>(node), elapsedTime);
		}
	}

	internal sealed class NIDSCNActionNodeWithElapsedTimeHandler : TrampolineBlockBase
	{
		private DSCNActionNodeWithElapsedTimeHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNActionNodeWithElapsedTimeHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNActionNodeWithElapsedTimeHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNActionNodeWithElapsedTimeHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNActionNodeWithElapsedTimeHandler sCNActionNodeWithElapsedTimeHandler = (SCNActionNodeWithElapsedTimeHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNActionNodeWithElapsedTimeHandler ?? new SCNActionNodeWithElapsedTimeHandler(new NIDSCNActionNodeWithElapsedTimeHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNNode node, nfloat elapsedTime)
		{
			invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, elapsedTime);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNAnimationDidStartHandler))]
	internal delegate void DSCNAnimationDidStartHandler(IntPtr block, IntPtr animation, IntPtr receiver);

	internal static class SDSCNAnimationDidStartHandler
	{
		internal static readonly DSCNAnimationDidStartHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNAnimationDidStartHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr animation, IntPtr receiver)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNAnimationDidStartHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<SCNAnimation>(animation), Runtime.GetNSObject<SCNAnimatable>(receiver));
		}
	}

	internal sealed class NIDSCNAnimationDidStartHandler : TrampolineBlockBase
	{
		private DSCNAnimationDidStartHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNAnimationDidStartHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNAnimationDidStartHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAnimationDidStartHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNAnimationDidStartHandler sCNAnimationDidStartHandler = (SCNAnimationDidStartHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNAnimationDidStartHandler ?? new SCNAnimationDidStartHandler(new NIDSCNAnimationDidStartHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNAnimation animation, SCNAnimatable receiver)
		{
			invoker(base.BlockPointer, animation?.Handle ?? IntPtr.Zero, receiver?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNAnimationDidStartHandler2))]
	internal delegate void DSCNAnimationDidStartHandler2(IntPtr block, IntPtr animation, IntPtr receiver);

	internal static class SDSCNAnimationDidStartHandler2
	{
		internal static readonly DSCNAnimationDidStartHandler2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNAnimationDidStartHandler2))]
		private unsafe static void Invoke(IntPtr block, IntPtr animation, IntPtr receiver)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNAnimationDidStartHandler2)ptr->Target)?.Invoke(Runtime.GetNSObject<SCNAnimation>(animation), Runtime.GetINativeObject<ISCNAnimatable>(receiver, owns: false));
		}
	}

	internal sealed class NIDSCNAnimationDidStartHandler2 : TrampolineBlockBase
	{
		private DSCNAnimationDidStartHandler2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNAnimationDidStartHandler2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNAnimationDidStartHandler2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAnimationDidStartHandler2? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNAnimationDidStartHandler2 sCNAnimationDidStartHandler = (SCNAnimationDidStartHandler2)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNAnimationDidStartHandler ?? new SCNAnimationDidStartHandler2(new NIDSCNAnimationDidStartHandler2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNAnimation animation, ISCNAnimatable receiver)
		{
			invoker(base.BlockPointer, animation?.Handle ?? IntPtr.Zero, receiver?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNAnimationDidStopHandler))]
	internal delegate void DSCNAnimationDidStopHandler(IntPtr block, IntPtr animation, IntPtr receiver, bool completed);

	internal static class SDSCNAnimationDidStopHandler
	{
		internal static readonly DSCNAnimationDidStopHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNAnimationDidStopHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr animation, IntPtr receiver, bool completed)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNAnimationDidStopHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<SCNAnimation>(animation), Runtime.GetNSObject<SCNAnimatable>(receiver), completed);
		}
	}

	internal sealed class NIDSCNAnimationDidStopHandler : TrampolineBlockBase
	{
		private DSCNAnimationDidStopHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNAnimationDidStopHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNAnimationDidStopHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAnimationDidStopHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNAnimationDidStopHandler sCNAnimationDidStopHandler = (SCNAnimationDidStopHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNAnimationDidStopHandler ?? new SCNAnimationDidStopHandler(new NIDSCNAnimationDidStopHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNAnimation animation, SCNAnimatable receiver, bool completed)
		{
			invoker(base.BlockPointer, animation?.Handle ?? IntPtr.Zero, receiver?.Handle ?? IntPtr.Zero, completed);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNAnimationDidStopHandler2))]
	internal delegate void DSCNAnimationDidStopHandler2(IntPtr block, IntPtr animation, IntPtr receiver, bool completed);

	internal static class SDSCNAnimationDidStopHandler2
	{
		internal static readonly DSCNAnimationDidStopHandler2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNAnimationDidStopHandler2))]
		private unsafe static void Invoke(IntPtr block, IntPtr animation, IntPtr receiver, bool completed)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNAnimationDidStopHandler2)ptr->Target)?.Invoke(Runtime.GetNSObject<SCNAnimation>(animation), Runtime.GetINativeObject<ISCNAnimatable>(receiver, owns: false), completed);
		}
	}

	internal sealed class NIDSCNAnimationDidStopHandler2 : TrampolineBlockBase
	{
		private DSCNAnimationDidStopHandler2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNAnimationDidStopHandler2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNAnimationDidStopHandler2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNAnimationDidStopHandler2? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNAnimationDidStopHandler2 sCNAnimationDidStopHandler = (SCNAnimationDidStopHandler2)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNAnimationDidStopHandler ?? new SCNAnimationDidStopHandler2(new NIDSCNAnimationDidStopHandler2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNAnimation animation, ISCNAnimatable receiver, bool completed)
		{
			invoker(base.BlockPointer, animation?.Handle ?? IntPtr.Zero, receiver?.Handle ?? IntPtr.Zero, completed);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNBindingHandler))]
	internal delegate void DSCNBindingHandler(IntPtr block, uint programId, uint location, IntPtr renderedNode, IntPtr renderer);

	internal static class SDSCNBindingHandler
	{
		internal static readonly DSCNBindingHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNBindingHandler))]
		private unsafe static void Invoke(IntPtr block, uint programId, uint location, IntPtr renderedNode, IntPtr renderer)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNBindingHandler)ptr->Target)?.Invoke(programId, location, Runtime.GetNSObject<SCNNode>(renderedNode), Runtime.GetNSObject<SCNRenderer>(renderer));
		}
	}

	internal sealed class NIDSCNBindingHandler : TrampolineBlockBase
	{
		private DSCNBindingHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNBindingHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNBindingHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNBindingHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNBindingHandler sCNBindingHandler = (SCNBindingHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNBindingHandler ?? new SCNBindingHandler(new NIDSCNBindingHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(uint programId, uint location, SCNNode renderedNode, SCNRenderer renderer)
		{
			invoker(base.BlockPointer, programId, location, renderedNode?.Handle ?? IntPtr.Zero, renderer?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNBufferBindingHandler))]
	internal delegate void DSCNBufferBindingHandler(IntPtr block, IntPtr buffer, IntPtr node, IntPtr shadable, IntPtr renderer);

	internal static class SDSCNBufferBindingHandler
	{
		internal static readonly DSCNBufferBindingHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNBufferBindingHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr buffer, IntPtr node, IntPtr shadable, IntPtr renderer)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNBufferBindingHandler)ptr->Target)?.Invoke(Runtime.GetINativeObject<ISCNBufferStream>(buffer, owns: false), Runtime.GetNSObject<SCNNode>(node), Runtime.GetNSObject<SCNShadable>(shadable), Runtime.GetNSObject<SCNRenderer>(renderer));
		}
	}

	internal sealed class NIDSCNBufferBindingHandler : TrampolineBlockBase
	{
		private DSCNBufferBindingHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNBufferBindingHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNBufferBindingHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNBufferBindingHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNBufferBindingHandler sCNBufferBindingHandler = (SCNBufferBindingHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNBufferBindingHandler ?? new SCNBufferBindingHandler(new NIDSCNBufferBindingHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ISCNBufferStream buffer, SCNNode node, SCNShadable shadable, SCNRenderer renderer)
		{
			invoker(base.BlockPointer, buffer?.Handle ?? IntPtr.Zero, node?.Handle ?? IntPtr.Zero, shadable?.Handle ?? IntPtr.Zero, renderer?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNBufferBindingHandler2))]
	internal delegate void DSCNBufferBindingHandler2(IntPtr block, IntPtr buffer, IntPtr node, IntPtr shadable, IntPtr renderer);

	internal static class SDSCNBufferBindingHandler2
	{
		internal static readonly DSCNBufferBindingHandler2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNBufferBindingHandler2))]
		private unsafe static void Invoke(IntPtr block, IntPtr buffer, IntPtr node, IntPtr shadable, IntPtr renderer)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNBufferBindingHandler2)ptr->Target)?.Invoke(Runtime.GetINativeObject<ISCNBufferStream>(buffer, owns: false), Runtime.GetNSObject<SCNNode>(node), Runtime.GetINativeObject<ISCNShadable>(shadable, owns: false), Runtime.GetNSObject<SCNRenderer>(renderer));
		}
	}

	internal sealed class NIDSCNBufferBindingHandler2 : TrampolineBlockBase
	{
		private DSCNBufferBindingHandler2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNBufferBindingHandler2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNBufferBindingHandler2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNBufferBindingHandler2? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNBufferBindingHandler2 sCNBufferBindingHandler = (SCNBufferBindingHandler2)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNBufferBindingHandler ?? new SCNBufferBindingHandler2(new NIDSCNBufferBindingHandler2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ISCNBufferStream buffer, SCNNode node, ISCNShadable shadable, SCNRenderer renderer)
		{
			invoker(base.BlockPointer, buffer?.Handle ?? IntPtr.Zero, node?.Handle ?? IntPtr.Zero, shadable?.Handle ?? IntPtr.Zero, renderer?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNFieldForceEvaluator))]
	internal delegate SCNVector3 DSCNFieldForceEvaluator(IntPtr block, SCNVector3 position, SCNVector3 velocity, float mass, float charge, double timeInSeconds);

	internal static class SDSCNFieldForceEvaluator
	{
		internal static readonly DSCNFieldForceEvaluator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNFieldForceEvaluator))]
		private unsafe static SCNVector3 Invoke(IntPtr block, SCNVector3 position, SCNVector3 velocity, float mass, float charge, double timeInSeconds)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SCNFieldForceEvaluator sCNFieldForceEvaluator = (SCNFieldForceEvaluator)ptr->Target;
			return sCNFieldForceEvaluator(position, velocity, mass, charge, timeInSeconds);
		}
	}

	internal sealed class NIDSCNFieldForceEvaluator : TrampolineBlockBase
	{
		private DSCNFieldForceEvaluator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNFieldForceEvaluator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNFieldForceEvaluator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNFieldForceEvaluator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNFieldForceEvaluator sCNFieldForceEvaluator = (SCNFieldForceEvaluator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNFieldForceEvaluator ?? new SCNFieldForceEvaluator(new NIDSCNFieldForceEvaluator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private SCNVector3 Invoke(SCNVector3 position, SCNVector3 velocity, float mass, float charge, double timeInSeconds)
		{
			return invoker(base.BlockPointer, position, velocity, mass, charge, timeInSeconds);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNNodeHandler))]
	internal delegate void DSCNNodeHandler(IntPtr block, IntPtr node, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDSCNNodeHandler
	{
		internal static readonly DSCNNodeHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNNodeHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr node, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SCNNodeHandler sCNNodeHandler = (SCNNodeHandler)ptr->Target;
			if (sCNNodeHandler != null)
			{
				sCNNodeHandler(Runtime.GetNSObject<SCNNode>(node), out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDSCNNodeHandler : TrampolineBlockBase
	{
		private DSCNNodeHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNNodeHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNNodeHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNNodeHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNNodeHandler sCNNodeHandler = (SCNNodeHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNNodeHandler ?? new SCNNodeHandler(new NIDSCNNodeHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNNode node, out bool stop)
		{
			invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNNodePredicate))]
	internal delegate bool DSCNNodePredicate(IntPtr block, IntPtr node, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDSCNNodePredicate
	{
		internal static readonly DSCNNodePredicate Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNNodePredicate))]
		private unsafe static bool Invoke(IntPtr block, IntPtr node, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SCNNodePredicate sCNNodePredicate = (SCNNodePredicate)ptr->Target;
			return sCNNodePredicate(Runtime.GetNSObject<SCNNode>(node), out stop);
		}
	}

	internal sealed class NIDSCNNodePredicate : TrampolineBlockBase
	{
		private DSCNNodePredicate invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNNodePredicate(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNNodePredicate>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNNodePredicate? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNNodePredicate sCNNodePredicate = (SCNNodePredicate)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNNodePredicate ?? new SCNNodePredicate(new NIDSCNNodePredicate((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(SCNNode node, out bool stop)
		{
			return invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNParticleEventHandler))]
	internal delegate void DSCNParticleEventHandler(IntPtr block, IntPtr data, IntPtr dataStride, IntPtr indices, nint count);

	internal static class SDSCNParticleEventHandler
	{
		internal static readonly DSCNParticleEventHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNParticleEventHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr data, IntPtr dataStride, IntPtr indices, nint count)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNParticleEventHandler)ptr->Target)?.Invoke(data, dataStride, indices, count);
		}
	}

	internal sealed class NIDSCNParticleEventHandler : TrampolineBlockBase
	{
		private DSCNParticleEventHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNParticleEventHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNParticleEventHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNParticleEventHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNParticleEventHandler sCNParticleEventHandler = (SCNParticleEventHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNParticleEventHandler ?? new SCNParticleEventHandler(new NIDSCNParticleEventHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr data, IntPtr dataStride, IntPtr indices, nint count)
		{
			invoker(base.BlockPointer, data, dataStride, indices, count);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNParticleModifierHandler))]
	internal delegate void DSCNParticleModifierHandler(IntPtr block, IntPtr data, IntPtr dataStride, nint start, nint end, float deltaTime);

	internal static class SDSCNParticleModifierHandler
	{
		internal static readonly DSCNParticleModifierHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNParticleModifierHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr data, IntPtr dataStride, nint start, nint end, float deltaTime)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNParticleModifierHandler)ptr->Target)?.Invoke(data, dataStride, start, end, deltaTime);
		}
	}

	internal sealed class NIDSCNParticleModifierHandler : TrampolineBlockBase
	{
		private DSCNParticleModifierHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNParticleModifierHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNParticleModifierHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNParticleModifierHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNParticleModifierHandler sCNParticleModifierHandler = (SCNParticleModifierHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNParticleModifierHandler ?? new SCNParticleModifierHandler(new NIDSCNParticleModifierHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr data, IntPtr dataStride, nint start, nint end, float deltaTime)
		{
			invoker(base.BlockPointer, data, dataStride, start, end, deltaTime);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNSceneExportProgressHandler))]
	internal delegate void DSCNSceneExportProgressHandler(IntPtr block, float totalProgress, IntPtr error, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDSCNSceneExportProgressHandler
	{
		internal static readonly DSCNSceneExportProgressHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNSceneExportProgressHandler))]
		private unsafe static void Invoke(IntPtr block, float totalProgress, IntPtr error, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SCNSceneExportProgressHandler sCNSceneExportProgressHandler = (SCNSceneExportProgressHandler)ptr->Target;
			if (sCNSceneExportProgressHandler != null)
			{
				sCNSceneExportProgressHandler(totalProgress, Runtime.GetNSObject<NSError>(error), out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDSCNSceneExportProgressHandler : TrampolineBlockBase
	{
		private DSCNSceneExportProgressHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNSceneExportProgressHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNSceneExportProgressHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNSceneExportProgressHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNSceneExportProgressHandler sCNSceneExportProgressHandler = (SCNSceneExportProgressHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNSceneExportProgressHandler ?? new SCNSceneExportProgressHandler(new NIDSCNSceneExportProgressHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(float totalProgress, NSError error, out bool stop)
		{
			invoker(base.BlockPointer, totalProgress, error?.Handle ?? IntPtr.Zero, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNSceneSourceFilter))]
	internal delegate bool DSCNSceneSourceFilter(IntPtr block, IntPtr entry, IntPtr identifier, [MarshalAs(UnmanagedType.I1)] ref bool stop);

	internal static class SDSCNSceneSourceFilter
	{
		internal static readonly DSCNSceneSourceFilter Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNSceneSourceFilter))]
		private unsafe static bool Invoke(IntPtr block, IntPtr entry, IntPtr identifier, [MarshalAs(UnmanagedType.I1)] ref bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SCNSceneSourceFilter sCNSceneSourceFilter = (SCNSceneSourceFilter)ptr->Target;
			return sCNSceneSourceFilter(Runtime.GetNSObject<NSObject>(entry), Runtime.GetNSObject<NSString>(identifier), ref stop);
		}
	}

	internal sealed class NIDSCNSceneSourceFilter : TrampolineBlockBase
	{
		private DSCNSceneSourceFilter invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNSceneSourceFilter(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNSceneSourceFilter>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNSceneSourceFilter? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNSceneSourceFilter sCNSceneSourceFilter = (SCNSceneSourceFilter)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNSceneSourceFilter ?? new SCNSceneSourceFilter(new NIDSCNSceneSourceFilter((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(NSObject entry, NSString identifier, ref bool stop)
		{
			return invoker(base.BlockPointer, entry?.Handle ?? IntPtr.Zero, (identifier == null) ? IntPtr.Zero : identifier.Handle, ref stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNSceneSourceStatusHandler))]
	internal delegate void DSCNSceneSourceStatusHandler(IntPtr block, float totalProgress, nint status, IntPtr error, [MarshalAs(UnmanagedType.I1)] ref bool stopLoading);

	internal static class SDSCNSceneSourceStatusHandler
	{
		internal static readonly DSCNSceneSourceStatusHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNSceneSourceStatusHandler))]
		private unsafe static void Invoke(IntPtr block, float totalProgress, nint status, IntPtr error, [MarshalAs(UnmanagedType.I1)] ref bool stopLoading)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SCNSceneSourceStatusHandler)ptr->Target)?.Invoke(totalProgress, (SCNSceneSourceStatus)(long)status, Runtime.GetNSObject<NSError>(error), ref stopLoading);
		}
	}

	internal sealed class NIDSCNSceneSourceStatusHandler : TrampolineBlockBase
	{
		private DSCNSceneSourceStatusHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNSceneSourceStatusHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNSceneSourceStatusHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNSceneSourceStatusHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNSceneSourceStatusHandler sCNSceneSourceStatusHandler = (SCNSceneSourceStatusHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNSceneSourceStatusHandler ?? new SCNSceneSourceStatusHandler(new NIDSCNSceneSourceStatusHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(float totalProgress, SCNSceneSourceStatus status, NSError error, ref bool stopLoading)
		{
			invoker(base.BlockPointer, totalProgress, (nint)(long)status, error?.Handle ?? IntPtr.Zero, ref stopLoading);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SCNTransformConstraintHandler))]
	internal delegate SCNMatrix4 DSCNTransformConstraintHandler(IntPtr block, IntPtr node, SCNMatrix4 transform);

	internal static class SDSCNTransformConstraintHandler
	{
		internal static readonly DSCNTransformConstraintHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSCNTransformConstraintHandler))]
		private unsafe static SCNMatrix4 Invoke(IntPtr block, IntPtr node, SCNMatrix4 transform)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SCNTransformConstraintHandler sCNTransformConstraintHandler = (SCNTransformConstraintHandler)ptr->Target;
			return sCNTransformConstraintHandler(Runtime.GetNSObject<SCNNode>(node), transform);
		}
	}

	internal sealed class NIDSCNTransformConstraintHandler : TrampolineBlockBase
	{
		private DSCNTransformConstraintHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSCNTransformConstraintHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSCNTransformConstraintHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SCNTransformConstraintHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SCNTransformConstraintHandler sCNTransformConstraintHandler = (SCNTransformConstraintHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sCNTransformConstraintHandler ?? new SCNTransformConstraintHandler(new NIDSCNTransformConstraintHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private SCNMatrix4 Invoke(SCNNode node, SCNMatrix4 transform)
		{
			return invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, transform);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SecProtocolChallenge))]
	internal delegate void DSecProtocolChallenge(IntPtr block, IntPtr metadata, IntPtr challengeComplete);

	internal static class SDSecProtocolChallenge
	{
		internal static readonly DSecProtocolChallenge Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSecProtocolChallenge))]
		private unsafe static void Invoke(IntPtr block, IntPtr metadata, IntPtr challengeComplete)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SecProtocolChallenge)ptr->Target)?.Invoke(new SecProtocolMetadata(metadata), NIDSecProtocolChallengeComplete.Create(challengeComplete));
		}
	}

	internal sealed class NIDSecProtocolChallenge : TrampolineBlockBase
	{
		private DSecProtocolChallenge invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSecProtocolChallenge(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSecProtocolChallenge>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SecProtocolChallenge? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SecProtocolChallenge secProtocolChallenge = (SecProtocolChallenge)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return secProtocolChallenge ?? new SecProtocolChallenge(new NIDSecProtocolChallenge((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke(SecProtocolMetadata metadata, [BlockProxy(typeof(NIDSecProtocolChallengeComplete))] SecProtocolChallengeComplete challengeComplete)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDSecProtocolChallengeComplete.Handler, challengeComplete);
			invoker(base.BlockPointer, metadata?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SecProtocolKeyUpdate))]
	internal delegate void DSecProtocolKeyUpdate(IntPtr block, IntPtr metadata, IntPtr complete);

	internal static class SDSecProtocolKeyUpdate
	{
		internal static readonly DSecProtocolKeyUpdate Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSecProtocolKeyUpdate))]
		private unsafe static void Invoke(IntPtr block, IntPtr metadata, IntPtr complete)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SecProtocolKeyUpdate)ptr->Target)?.Invoke(new SecProtocolMetadata(metadata), NIDAction.Create(complete));
		}
	}

	internal sealed class NIDSecProtocolKeyUpdate : TrampolineBlockBase
	{
		private DSecProtocolKeyUpdate invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSecProtocolKeyUpdate(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSecProtocolKeyUpdate>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SecProtocolKeyUpdate? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SecProtocolKeyUpdate secProtocolKeyUpdate = (SecProtocolKeyUpdate)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return secProtocolKeyUpdate ?? new SecProtocolKeyUpdate(new NIDSecProtocolKeyUpdate((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke(SecProtocolMetadata metadata, [BlockProxy(typeof(NIDAction))] Action complete)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDAction.Handler, complete);
			invoker(base.BlockPointer, metadata?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SecProtocolVerify))]
	internal delegate void DSecProtocolVerify(IntPtr block, IntPtr metadata, IntPtr trust, IntPtr verifyComplete);

	internal static class SDSecProtocolVerify
	{
		internal static readonly DSecProtocolVerify Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSecProtocolVerify))]
		private unsafe static void Invoke(IntPtr block, IntPtr metadata, IntPtr trust, IntPtr verifyComplete)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SecProtocolVerify)ptr->Target)?.Invoke(new SecProtocolMetadata(metadata), new SecTrust2(trust), NIDSecProtocolVerifyComplete.Create(verifyComplete));
		}
	}

	internal sealed class NIDSecProtocolVerify : TrampolineBlockBase
	{
		private DSecProtocolVerify invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSecProtocolVerify(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSecProtocolVerify>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SecProtocolVerify? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SecProtocolVerify secProtocolVerify = (SecProtocolVerify)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return secProtocolVerify ?? new SecProtocolVerify(new NIDSecProtocolVerify((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private unsafe void Invoke(SecProtocolMetadata metadata, SecTrust2 trust, [BlockProxy(typeof(NIDSecProtocolVerifyComplete))] SecProtocolVerifyComplete verifyComplete)
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(SDSecProtocolVerifyComplete.Handler, verifyComplete);
			invoker(base.BlockPointer, metadata?.Handle ?? IntPtr.Zero, trust?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
			ptr->CleanupBlock();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SNAudioFileAnalyzerAnalyzeHandler))]
	internal delegate void DSNAudioFileAnalyzerAnalyzeHandler(IntPtr block, bool didReachEndOfFile);

	internal static class SDSNAudioFileAnalyzerAnalyzeHandler
	{
		internal static readonly DSNAudioFileAnalyzerAnalyzeHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSNAudioFileAnalyzerAnalyzeHandler))]
		private unsafe static void Invoke(IntPtr block, bool didReachEndOfFile)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SNAudioFileAnalyzerAnalyzeHandler)ptr->Target)?.Invoke(didReachEndOfFile);
		}
	}

	internal sealed class NIDSNAudioFileAnalyzerAnalyzeHandler : TrampolineBlockBase
	{
		private DSNAudioFileAnalyzerAnalyzeHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSNAudioFileAnalyzerAnalyzeHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSNAudioFileAnalyzerAnalyzeHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SNAudioFileAnalyzerAnalyzeHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SNAudioFileAnalyzerAnalyzeHandler sNAudioFileAnalyzerAnalyzeHandler = (SNAudioFileAnalyzerAnalyzeHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sNAudioFileAnalyzerAnalyzeHandler ?? new SNAudioFileAnalyzerAnalyzeHandler(new NIDSNAudioFileAnalyzerAnalyzeHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool didReachEndOfFile)
		{
			invoker(base.BlockPointer, didReachEndOfFile);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKActionDurationHandler))]
	internal delegate void DSKActionDurationHandler(IntPtr block, IntPtr node, nfloat elapsedTime);

	internal static class SDSKActionDurationHandler
	{
		internal static readonly DSKActionDurationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKActionDurationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr node, nfloat elapsedTime)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SKActionDurationHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<SKNode>(node), elapsedTime);
		}
	}

	internal sealed class NIDSKActionDurationHandler : TrampolineBlockBase
	{
		private DSKActionDurationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKActionDurationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKActionDurationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKActionDurationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKActionDurationHandler sKActionDurationHandler = (SKActionDurationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKActionDurationHandler ?? new SKActionDurationHandler(new NIDSKActionDurationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SKNode node, nfloat elapsedTime)
		{
			invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, elapsedTime);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKActionTimingFunction2))]
	internal delegate float DSKActionTimingFunction2(IntPtr block, float time);

	internal static class SDSKActionTimingFunction2
	{
		internal static readonly DSKActionTimingFunction2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKActionTimingFunction2))]
		private unsafe static float Invoke(IntPtr block, float time)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SKActionTimingFunction2 sKActionTimingFunction = (SKActionTimingFunction2)ptr->Target;
			return sKActionTimingFunction(time);
		}
	}

	internal sealed class NIDSKActionTimingFunction2 : TrampolineBlockBase
	{
		private DSKActionTimingFunction2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKActionTimingFunction2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKActionTimingFunction2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKActionTimingFunction2? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKActionTimingFunction2 sKActionTimingFunction = (SKActionTimingFunction2)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKActionTimingFunction ?? new SKActionTimingFunction2(new NIDSKActionTimingFunction2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private float Invoke(float time)
		{
			return invoker(base.BlockPointer, time);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKFieldForceEvaluator))]
	internal delegate Vector3 DSKFieldForceEvaluator(IntPtr block, Vector4 position, Vector4 velocity, float mass, float charge, double time);

	internal static class SDSKFieldForceEvaluator
	{
		internal static readonly DSKFieldForceEvaluator Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKFieldForceEvaluator))]
		private unsafe static Vector3 Invoke(IntPtr block, Vector4 position, Vector4 velocity, float mass, float charge, double time)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SKFieldForceEvaluator sKFieldForceEvaluator = (SKFieldForceEvaluator)ptr->Target;
			return sKFieldForceEvaluator(position, velocity, mass, charge, time);
		}
	}

	internal sealed class NIDSKFieldForceEvaluator : TrampolineBlockBase
	{
		private DSKFieldForceEvaluator invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKFieldForceEvaluator(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKFieldForceEvaluator>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKFieldForceEvaluator? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKFieldForceEvaluator sKFieldForceEvaluator = (SKFieldForceEvaluator)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKFieldForceEvaluator ?? new SKFieldForceEvaluator(new NIDSKFieldForceEvaluator((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private Vector3 Invoke(Vector4 position, Vector4 velocity, float mass, float charge, double time)
		{
			return invoker(base.BlockPointer, position, velocity, mass, charge, time);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKNodeChildEnumeratorHandler))]
	internal delegate void DSKNodeChildEnumeratorHandler(IntPtr block, IntPtr node, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDSKNodeChildEnumeratorHandler
	{
		internal static readonly DSKNodeChildEnumeratorHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKNodeChildEnumeratorHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr node, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SKNodeChildEnumeratorHandler sKNodeChildEnumeratorHandler = (SKNodeChildEnumeratorHandler)ptr->Target;
			if (sKNodeChildEnumeratorHandler != null)
			{
				sKNodeChildEnumeratorHandler(Runtime.GetNSObject<SKNode>(node), out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDSKNodeChildEnumeratorHandler : TrampolineBlockBase
	{
		private DSKNodeChildEnumeratorHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKNodeChildEnumeratorHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKNodeChildEnumeratorHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKNodeChildEnumeratorHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKNodeChildEnumeratorHandler sKNodeChildEnumeratorHandler = (SKNodeChildEnumeratorHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKNodeChildEnumeratorHandler ?? new SKNodeChildEnumeratorHandler(new NIDSKNodeChildEnumeratorHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SKNode node, out bool stop)
		{
			invoker(base.BlockPointer, node?.Handle ?? IntPtr.Zero, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler))]
	internal delegate void DSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler(IntPtr block, IntPtr body, CGPoint point, CGVector normal, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler
	{
		internal static readonly DSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr body, CGPoint point, CGVector normal, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler sKPhysicsWorldBodiesAlongRayStartEnumeratorHandler = (SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler)ptr->Target;
			if (sKPhysicsWorldBodiesAlongRayStartEnumeratorHandler != null)
			{
				sKPhysicsWorldBodiesAlongRayStartEnumeratorHandler(Runtime.GetNSObject<SKPhysicsBody>(body), point, normal, out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler : TrampolineBlockBase
	{
		private DSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler sKPhysicsWorldBodiesAlongRayStartEnumeratorHandler = (SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKPhysicsWorldBodiesAlongRayStartEnumeratorHandler ?? new SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler(new NIDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SKPhysicsBody body, CGPoint point, CGVector normal, out bool stop)
		{
			invoker(base.BlockPointer, body?.Handle ?? IntPtr.Zero, point, normal, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKPhysicsWorldBodiesEnumeratorHandler))]
	internal delegate void DSKPhysicsWorldBodiesEnumeratorHandler(IntPtr block, IntPtr body, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDSKPhysicsWorldBodiesEnumeratorHandler
	{
		internal static readonly DSKPhysicsWorldBodiesEnumeratorHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKPhysicsWorldBodiesEnumeratorHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr body, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			SKPhysicsWorldBodiesEnumeratorHandler sKPhysicsWorldBodiesEnumeratorHandler = (SKPhysicsWorldBodiesEnumeratorHandler)ptr->Target;
			if (sKPhysicsWorldBodiesEnumeratorHandler != null)
			{
				sKPhysicsWorldBodiesEnumeratorHandler(Runtime.GetNSObject<SKPhysicsBody>(body), out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDSKPhysicsWorldBodiesEnumeratorHandler : TrampolineBlockBase
	{
		private DSKPhysicsWorldBodiesEnumeratorHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKPhysicsWorldBodiesEnumeratorHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKPhysicsWorldBodiesEnumeratorHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKPhysicsWorldBodiesEnumeratorHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKPhysicsWorldBodiesEnumeratorHandler sKPhysicsWorldBodiesEnumeratorHandler = (SKPhysicsWorldBodiesEnumeratorHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKPhysicsWorldBodiesEnumeratorHandler ?? new SKPhysicsWorldBodiesEnumeratorHandler(new NIDSKPhysicsWorldBodiesEnumeratorHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SKPhysicsBody body, out bool stop)
		{
			invoker(base.BlockPointer, body?.Handle ?? IntPtr.Zero, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKTextureAtlasLoadCallback))]
	internal delegate void DSKTextureAtlasLoadCallback(IntPtr block, IntPtr error, IntPtr foundAtlases);

	internal static class SDSKTextureAtlasLoadCallback
	{
		internal static readonly DSKTextureAtlasLoadCallback Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKTextureAtlasLoadCallback))]
		private unsafe static void Invoke(IntPtr block, IntPtr error, IntPtr foundAtlases)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SKTextureAtlasLoadCallback)ptr->Target)?.Invoke(Runtime.GetNSObject<NSError>(error), Runtime.GetNSObject<SKTextureAtlas>(foundAtlases));
		}
	}

	internal sealed class NIDSKTextureAtlasLoadCallback : TrampolineBlockBase
	{
		private DSKTextureAtlasLoadCallback invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKTextureAtlasLoadCallback(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKTextureAtlasLoadCallback>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKTextureAtlasLoadCallback? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKTextureAtlasLoadCallback sKTextureAtlasLoadCallback = (SKTextureAtlasLoadCallback)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKTextureAtlasLoadCallback ?? new SKTextureAtlasLoadCallback(new NIDSKTextureAtlasLoadCallback((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSError error, SKTextureAtlas foundAtlases)
		{
			invoker(base.BlockPointer, error?.Handle ?? IntPtr.Zero, foundAtlases?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKTextureModify))]
	internal delegate void DSKTextureModify(IntPtr block, IntPtr pixelData, nuint lengthInBytes);

	internal static class SDSKTextureModify
	{
		internal static readonly DSKTextureModify Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKTextureModify))]
		private unsafe static void Invoke(IntPtr block, IntPtr pixelData, nuint lengthInBytes)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SKTextureModify)ptr->Target)?.Invoke(pixelData, lengthInBytes);
		}
	}

	internal sealed class NIDSKTextureModify : TrampolineBlockBase
	{
		private DSKTextureModify invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKTextureModify(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKTextureModify>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKTextureModify? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKTextureModify sKTextureModify = (SKTextureModify)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKTextureModify ?? new SKTextureModify(new NIDSKTextureModify((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr pixelData, nuint lengthInBytes)
		{
			invoker(base.BlockPointer, pixelData, lengthInBytes);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKArcadeServiceRegisterHandler))]
	internal delegate void DSKArcadeServiceRegisterHandler(IntPtr block, IntPtr randomFromFP, uint randomFromFPLength, IntPtr cmacOfAppPid, uint cmacOfAppPidLength, IntPtr error);

	internal static class SDSKArcadeServiceRegisterHandler
	{
		internal static readonly DSKArcadeServiceRegisterHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKArcadeServiceRegisterHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr randomFromFP, uint randomFromFPLength, IntPtr cmacOfAppPid, uint cmacOfAppPidLength, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SKArcadeServiceRegisterHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(randomFromFP), randomFromFPLength, Runtime.GetNSObject<NSData>(cmacOfAppPid), cmacOfAppPidLength, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDSKArcadeServiceRegisterHandler : TrampolineBlockBase
	{
		private DSKArcadeServiceRegisterHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKArcadeServiceRegisterHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKArcadeServiceRegisterHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKArcadeServiceRegisterHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKArcadeServiceRegisterHandler sKArcadeServiceRegisterHandler = (SKArcadeServiceRegisterHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKArcadeServiceRegisterHandler ?? new SKArcadeServiceRegisterHandler(new NIDSKArcadeServiceRegisterHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData randomFromFP, uint randomFromFPLength, NSData cmacOfAppPid, uint cmacOfAppPidLength, NSError error)
		{
			invoker(base.BlockPointer, randomFromFP?.Handle ?? IntPtr.Zero, randomFromFPLength, cmacOfAppPid?.Handle ?? IntPtr.Zero, cmacOfAppPidLength, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SKArcadeServiceSubscriptionHandler))]
	internal delegate void DSKArcadeServiceSubscriptionHandler(IntPtr block, IntPtr subscriptionStatus, uint subscriptionStatusLength, IntPtr cmacOfNonce, uint cmacOfNonceLength, IntPtr error);

	internal static class SDSKArcadeServiceSubscriptionHandler
	{
		internal static readonly DSKArcadeServiceSubscriptionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSKArcadeServiceSubscriptionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr subscriptionStatus, uint subscriptionStatusLength, IntPtr cmacOfNonce, uint cmacOfNonceLength, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SKArcadeServiceSubscriptionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(subscriptionStatus), subscriptionStatusLength, Runtime.GetNSObject<NSData>(cmacOfNonce), cmacOfNonceLength, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDSKArcadeServiceSubscriptionHandler : TrampolineBlockBase
	{
		private DSKArcadeServiceSubscriptionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSKArcadeServiceSubscriptionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSKArcadeServiceSubscriptionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SKArcadeServiceSubscriptionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SKArcadeServiceSubscriptionHandler sKArcadeServiceSubscriptionHandler = (SKArcadeServiceSubscriptionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return sKArcadeServiceSubscriptionHandler ?? new SKArcadeServiceSubscriptionHandler(new NIDSKArcadeServiceSubscriptionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData subscriptionStatus, uint subscriptionStatusLength, NSData cmacOfNonce, uint cmacOfNonceLength, NSError error)
		{
			invoker(base.BlockPointer, subscriptionStatus?.Handle ?? IntPtr.Zero, subscriptionStatusLength, cmacOfNonce?.Handle ?? IntPtr.Zero, cmacOfNonceLength, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action))]
	internal delegate void DAction(IntPtr block);

	internal static class SDAction
	{
		internal static readonly DAction Handler = Invoke;

		[MonoPInvokeCallback(typeof(DAction))]
		private unsafe static void Invoke(IntPtr block)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action)ptr->Target)?.Invoke();
		}
	}

	internal sealed class NIDAction : TrampolineBlockBase
	{
		private DAction invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDAction(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DAction>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action action = (Action)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action(new NIDAction((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke()
		{
			invoker(base.BlockPointer);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AVAsynchronousCIImageFilteringRequest>))]
	internal delegate void DActionArity1V4(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V4
	{
		internal static readonly DActionArity1V4 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V4))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AVAsynchronousCIImageFilteringRequest>)ptr->Target)?.Invoke(Runtime.GetNSObject<AVAsynchronousCIImageFilteringRequest>(obj));
		}
	}

	internal sealed class NIDActionArity1V4 : TrampolineBlockBase
	{
		private DActionArity1V4 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V4(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V4>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AVAsynchronousCIImageFilteringRequest>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AVAsynchronousCIImageFilteringRequest> action = (Action<AVAsynchronousCIImageFilteringRequest>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AVAsynchronousCIImageFilteringRequest>(new NIDActionArity1V4((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAsynchronousCIImageFilteringRequest obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AVAudioBuffer>))]
	internal delegate void DActionArity1V6(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V6
	{
		internal static readonly DActionArity1V6 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V6))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AVAudioBuffer>)ptr->Target)?.Invoke(Runtime.GetNSObject<AVAudioBuffer>(obj));
		}
	}

	internal sealed class NIDActionArity1V6 : TrampolineBlockBase
	{
		private DActionArity1V6 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V6(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V6>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AVAudioBuffer>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AVAudioBuffer> action = (Action<AVAudioBuffer>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AVAudioBuffer>(new NIDActionArity1V6((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAudioBuffer obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AVAudioPlayerNodeCompletionCallbackType>))]
	internal delegate void DActionArity1V2(IntPtr block, nint obj);

	internal static class SDActionArity1V2
	{
		internal static readonly DActionArity1V2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V2))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AVAudioPlayerNodeCompletionCallbackType>)ptr->Target)?.Invoke((AVAudioPlayerNodeCompletionCallbackType)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V2 : TrampolineBlockBase
	{
		private DActionArity1V2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AVAudioPlayerNodeCompletionCallbackType>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AVAudioPlayerNodeCompletionCallbackType> action = (Action<AVAudioPlayerNodeCompletionCallbackType>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AVAudioPlayerNodeCompletionCallbackType>(new NIDActionArity1V2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAudioPlayerNodeCompletionCallbackType obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AVMetadataItemValueRequest>))]
	internal delegate void DActionArity1V3(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V3
	{
		internal static readonly DActionArity1V3 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V3))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AVMetadataItemValueRequest>)ptr->Target)?.Invoke(Runtime.GetNSObject<AVMetadataItemValueRequest>(obj));
		}
	}

	internal sealed class NIDActionArity1V3 : TrampolineBlockBase
	{
		private DActionArity1V3 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V3(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V3>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AVMetadataItemValueRequest>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AVMetadataItemValueRequest> action = (Action<AVMetadataItemValueRequest>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AVMetadataItemValueRequest>(new NIDActionArity1V3((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVMetadataItemValueRequest obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AVPlayerViewTrimResult>))]
	internal delegate void DActionArity1V7(IntPtr block, nint obj);

	internal static class SDActionArity1V7
	{
		internal static readonly DActionArity1V7 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V7))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AVPlayerViewTrimResult>)ptr->Target)?.Invoke((AVPlayerViewTrimResult)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V7 : TrampolineBlockBase
	{
		private DActionArity1V7 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V7(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V7>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AVPlayerViewTrimResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AVPlayerViewTrimResult> action = (Action<AVPlayerViewTrimResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AVPlayerViewTrimResult>(new NIDActionArity1V7((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVPlayerViewTrimResult obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSAnimationContext>))]
	internal delegate void DActionArity1V9(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V9
	{
		internal static readonly DActionArity1V9 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V9))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSAnimationContext>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSAnimationContext>(obj));
		}
	}

	internal sealed class NIDActionArity1V9 : TrampolineBlockBase
	{
		private DActionArity1V9 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V9(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V9>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSAnimationContext>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSAnimationContext> action = (Action<NSAnimationContext>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSAnimationContext>(new NIDActionArity1V9((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSAnimationContext obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSColor>))]
	internal delegate void DActionArity1V10(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V10
	{
		internal static readonly DActionArity1V10 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V10))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSColor>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSColor>(obj));
		}
	}

	internal sealed class NIDActionArity1V10 : TrampolineBlockBase
	{
		private DActionArity1V10 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V10(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V10>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSColor>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSColor> action = (Action<NSColor>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSColor>(new NIDActionArity1V10((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSColor obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSImage>))]
	internal delegate void DActionArity1V80(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V80
	{
		internal static readonly DActionArity1V80 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V80))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSImage>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSImage>(obj));
		}
	}

	internal sealed class NIDActionArity1V80 : TrampolineBlockBase
	{
		private DActionArity1V80 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V80(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V80>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSImage>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSImage> action = (Action<NSImage>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSImage>(new NIDActionArity1V80((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSImage obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSModalResponse>))]
	internal delegate void DActionArity1V8(IntPtr block, nint obj);

	internal static class SDActionArity1V8
	{
		internal static readonly DActionArity1V8 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V8))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSModalResponse>)ptr->Target)?.Invoke((NSModalResponse)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V8 : TrampolineBlockBase
	{
		private DActionArity1V8 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V8(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V8>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSModalResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSModalResponse> action = (Action<NSModalResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSModalResponse>(new NIDActionArity1V8((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSModalResponse obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSRunningApplication>))]
	internal delegate void DActionArity1V76(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V76
	{
		internal static readonly DActionArity1V76 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V76))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSRunningApplication>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSRunningApplication>(obj));
		}
	}

	internal sealed class NIDActionArity1V76 : TrampolineBlockBase
	{
		private DActionArity1V76 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V76(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V76>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSRunningApplication>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSRunningApplication> action = (Action<NSRunningApplication>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSRunningApplication>(new NIDActionArity1V76((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSRunningApplication obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSSliderAccessory>))]
	internal delegate void DActionArity1V12(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V12
	{
		internal static readonly DActionArity1V12 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V12))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSSliderAccessory>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSSliderAccessory>(obj));
		}
	}

	internal sealed class NIDActionArity1V12 : TrampolineBlockBase
	{
		private DActionArity1V12 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V12(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V12>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSSliderAccessory>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSSliderAccessory> action = (Action<NSSliderAccessory>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSSliderAccessory>(new NIDActionArity1V12((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSSliderAccessory obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSViewController>))]
	internal delegate void DActionArity1V14(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V14
	{
		internal static readonly DActionArity1V14 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V14))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSViewController>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSViewController>(obj));
		}
	}

	internal sealed class NIDActionArity1V14 : TrampolineBlockBase
	{
		private DActionArity1V14 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V14(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V14>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSViewController>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSViewController> action = (Action<NSViewController>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSViewController>(new NIDActionArity1V14((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSViewController obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKNotification>))]
	internal delegate void DActionArity1V18(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V18
	{
		internal static readonly DActionArity1V18 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V18))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKNotification>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKNotification>(obj));
		}
	}

	internal sealed class NIDActionArity1V18 : TrampolineBlockBase
	{
		private DActionArity1V18 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V18(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V18>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKNotification>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKNotification> action = (Action<CKNotification>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKNotification>(new NIDActionArity1V18((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKNotification obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecord>))]
	internal delegate void DActionArity1V19(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V19
	{
		internal static readonly DActionArity1V19 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V19))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecord>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecord>(obj));
		}
	}

	internal sealed class NIDActionArity1V19 : TrampolineBlockBase
	{
		private DActionArity1V19 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V19(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V19>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecord>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecord> action = (Action<CKRecord>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecord>(new NIDActionArity1V19((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecord obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordID>))]
	internal delegate void DActionArity1V20(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V20
	{
		internal static readonly DActionArity1V20 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V20))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordID>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordID>(obj));
		}
	}

	internal sealed class NIDActionArity1V20 : TrampolineBlockBase
	{
		private DActionArity1V20 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V20(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V20>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordID>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordID> action = (Action<CKRecordID>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordID>(new NIDActionArity1V20((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordID obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordZoneID>))]
	internal delegate void DActionArity1V17(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V17
	{
		internal static readonly DActionArity1V17 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V17))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordZoneID>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordZoneID>(obj));
		}
	}

	internal sealed class NIDActionArity1V17 : TrampolineBlockBase
	{
		private DActionArity1V17 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V17(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V17>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordZoneID>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordZoneID> action = (Action<CKRecordZoneID>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordZoneID>(new NIDActionArity1V17((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZoneID obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKServerChangeToken>))]
	internal delegate void DActionArity1V16(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V16
	{
		internal static readonly DActionArity1V16 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V16))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKServerChangeToken>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKServerChangeToken>(obj));
		}
	}

	internal sealed class NIDActionArity1V16 : TrampolineBlockBase
	{
		private DActionArity1V16 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V16(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V16>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKServerChangeToken>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKServerChangeToken> action = (Action<CKServerChangeToken>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKServerChangeToken>(new NIDActionArity1V16((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKServerChangeToken obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKShareParticipant>))]
	internal delegate void DActionArity1V21(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V21
	{
		internal static readonly DActionArity1V21 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V21))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKShareParticipant>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKShareParticipant>(obj));
		}
	}

	internal sealed class NIDActionArity1V21 : TrampolineBlockBase
	{
		private DActionArity1V21 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V21(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V21>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKShareParticipant>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKShareParticipant> action = (Action<CKShareParticipant>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKShareParticipant>(new NIDActionArity1V21((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKShareParticipant obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKUserIdentity>))]
	internal delegate void DActionArity1V15(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V15
	{
		internal static readonly DActionArity1V15 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V15))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKUserIdentity>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKUserIdentity>(obj));
		}
	}

	internal sealed class NIDActionArity1V15 : TrampolineBlockBase
	{
		private DActionArity1V15 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V15(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V15>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKUserIdentity>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKUserIdentity> action = (Action<CKUserIdentity>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKUserIdentity>(new NIDActionArity1V15((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKUserIdentity obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSAsynchronousFetchResult>))]
	internal delegate void DActionArity1V22(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V22
	{
		internal static readonly DActionArity1V22 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V22))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSAsynchronousFetchResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSAsynchronousFetchResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V22 : TrampolineBlockBase
	{
		private DActionArity1V22 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V22(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V22>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSAsynchronousFetchResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSAsynchronousFetchResult> action = (Action<NSAsynchronousFetchResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSAsynchronousFetchResult>(new NIDActionArity1V22((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSAsynchronousFetchResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSManagedObjectContext>))]
	internal delegate void DActionArity1V23(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V23
	{
		internal static readonly DActionArity1V23 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V23))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSManagedObjectContext>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSManagedObjectContext>(obj));
		}
	}

	internal sealed class NIDActionArity1V23 : TrampolineBlockBase
	{
		private DActionArity1V23 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V23(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V23>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSManagedObjectContext>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSManagedObjectContext> action = (Action<NSManagedObjectContext>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSManagedObjectContext>(new NIDActionArity1V23((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSManagedObjectContext obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<MLUpdateContext>))]
	internal delegate void DActionArity1V25(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V25
	{
		internal static readonly DActionArity1V25 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V25))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<MLUpdateContext>)ptr->Target)?.Invoke(Runtime.GetNSObject<MLUpdateContext>(obj));
		}
	}

	internal sealed class NIDActionArity1V25 : TrampolineBlockBase
	{
		private DActionArity1V25 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V25(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V25>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<MLUpdateContext>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<MLUpdateContext> action = (Action<MLUpdateContext>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<MLUpdateContext>(new NIDActionArity1V25((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MLUpdateContext obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CMTime>))]
	internal delegate void DActionArity1V5(IntPtr block, CMTime obj);

	internal static class SDActionArity1V5
	{
		internal static readonly DActionArity1V5 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V5))]
		private unsafe static void Invoke(IntPtr block, CMTime obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CMTime>)ptr->Target)?.Invoke(obj);
		}
	}

	internal sealed class NIDActionArity1V5 : TrampolineBlockBase
	{
		private DActionArity1V5 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V5(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V5>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CMTime>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CMTime> action = (Action<CMTime>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CMTime>(new NIDActionArity1V5((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CMTime obj)
		{
			invoker(base.BlockPointer, obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CSSearchableItem[]>))]
	internal delegate void DActionArity1V26(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V26
	{
		internal static readonly DActionArity1V26 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V26))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CSSearchableItem[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CSSearchableItem>(obj));
		}
	}

	internal sealed class NIDActionArity1V26 : TrampolineBlockBase
	{
		private DActionArity1V26 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V26(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V26>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CSSearchableItem[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CSSearchableItem[]> action = (Action<CSSearchableItem[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CSSearchableItem[]>(new NIDActionArity1V26((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CSSearchableItem[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<EKReminder[]>))]
	internal delegate void DActionArity1V27(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V27
	{
		internal static readonly DActionArity1V27 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V27))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<EKReminder[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<EKReminder>(obj));
		}
	}

	internal sealed class NIDActionArity1V27 : TrampolineBlockBase
	{
		private DActionArity1V27 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V27(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V27>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<EKReminder[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<EKReminder[]> action = (Action<EKReminder[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<EKReminder[]>(new NIDActionArity1V27((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(EKReminder[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSArray>))]
	internal delegate void DActionArity1V96(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V96
	{
		internal static readonly DActionArity1V96 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V96))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSArray>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSArray>(obj));
		}
	}

	internal sealed class NIDActionArity1V96 : TrampolineBlockBase
	{
		private DActionArity1V96 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V96(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V96>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSArray>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSArray> action = (Action<NSArray>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSArray>(new NIDActionArity1V96((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSArray obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSCachedUrlResponse>))]
	internal delegate void DActionArity1V36(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V36
	{
		internal static readonly DActionArity1V36 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V36))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSCachedUrlResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSCachedUrlResponse>(obj));
		}
	}

	internal sealed class NIDActionArity1V36 : TrampolineBlockBase
	{
		private DActionArity1V36 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V36(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V36>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSCachedUrlResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSCachedUrlResponse> action = (Action<NSCachedUrlResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSCachedUrlResponse>(new NIDActionArity1V36((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSCachedUrlResponse obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSData>))]
	internal delegate void DActionArity1V28(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V28
	{
		internal static readonly DActionArity1V28 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V28))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSData>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(obj));
		}
	}

	internal sealed class NIDActionArity1V28 : TrampolineBlockBase
	{
		private DActionArity1V28 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V28(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V28>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSData>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSData> action = (Action<NSData>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSData>(new NIDActionArity1V28((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSDictionary>))]
	internal delegate void DActionArity1V37(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V37
	{
		internal static readonly DActionArity1V37 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V37))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSDictionary>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary>(obj));
		}
	}

	internal sealed class NIDActionArity1V37 : TrampolineBlockBase
	{
		private DActionArity1V37 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V37(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V37>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSDictionary>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSDictionary> action = (Action<NSDictionary>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSDictionary>(new NIDActionArity1V37((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSDictionary<NSString, NSString>>))]
	internal delegate void DActionArity1V77(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V77
	{
		internal static readonly DActionArity1V77 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V77))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSDictionary<NSString, NSString>>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary<NSString, NSString>>(obj));
		}
	}

	internal sealed class NIDActionArity1V77 : TrampolineBlockBase
	{
		private DActionArity1V77 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V77(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V77>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSDictionary<NSString, NSString>>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSDictionary<NSString, NSString>> action = (Action<NSDictionary<NSString, NSString>>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSDictionary<NSString, NSString>>(new NIDActionArity1V77((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary<NSString, NSString> obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSError>))]
	internal delegate void DActionArity1V11(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V11
	{
		internal static readonly DActionArity1V11 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V11))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSError>(obj));
		}
	}

	internal sealed class NIDActionArity1V11 : TrampolineBlockBase
	{
		private DActionArity1V11 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V11(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V11>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSError> action = (Action<NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSError>(new NIDActionArity1V11((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSError obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSFileHandle>))]
	internal delegate void DActionArity1V30(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V30
	{
		internal static readonly DActionArity1V30 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V30))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSFileHandle>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSFileHandle>(obj));
		}
	}

	internal sealed class NIDActionArity1V30 : TrampolineBlockBase
	{
		private DActionArity1V30 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V30(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V30>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSFileHandle>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSFileHandle> action = (Action<NSFileHandle>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSFileHandle>(new NIDActionArity1V30((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSFileHandle obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSHttpCookie[]>))]
	internal delegate void DActionArity1V31(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V31
	{
		internal static readonly DActionArity1V31 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V31))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSHttpCookie[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSHttpCookie>(obj));
		}
	}

	internal sealed class NIDActionArity1V31 : TrampolineBlockBase
	{
		private DActionArity1V31 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V31(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V31>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSHttpCookie[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSHttpCookie[]> action = (Action<NSHttpCookie[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSHttpCookie[]>(new NIDActionArity1V31((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSHttpCookie[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSInputStream>))]
	internal delegate void DActionArity1V41(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V41
	{
		internal static readonly DActionArity1V41 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V41))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSInputStream>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSInputStream>(obj));
		}
	}

	internal sealed class NIDActionArity1V41 : TrampolineBlockBase
	{
		private DActionArity1V41 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V41(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V41>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSInputStream>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSInputStream> action = (Action<NSInputStream>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSInputStream>(new NIDActionArity1V41((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSInputStream obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSNotification>))]
	internal delegate void DActionArity1V32(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V32
	{
		internal static readonly DActionArity1V32 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V32))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSNotification>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSNotification>(obj));
		}
	}

	internal sealed class NIDActionArity1V32 : TrampolineBlockBase
	{
		private DActionArity1V32 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V32(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V32>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSNotification>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSNotification> action = (Action<NSNotification>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSNotification>(new NIDActionArity1V32((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSNotification obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSObject>))]
	internal delegate void DActionArity1V35(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V35
	{
		internal static readonly DActionArity1V35 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V35))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSObject>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(obj));
		}
	}

	internal sealed class NIDActionArity1V35 : TrampolineBlockBase
	{
		private DActionArity1V35 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V35(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V35>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSObject>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSObject> action = (Action<NSObject>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSObject>(new NIDActionArity1V35((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSProgress>))]
	internal delegate void DActionArity1V33(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V33
	{
		internal static readonly DActionArity1V33 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V33))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSProgress>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSProgress>(obj));
		}
	}

	internal sealed class NIDActionArity1V33 : TrampolineBlockBase
	{
		private DActionArity1V33 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V33(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V33>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSProgress>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSProgress> action = (Action<NSProgress>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSProgress>(new NIDActionArity1V33((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSProgress obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSSet<UNNotificationCategory>>))]
	internal delegate void DActionArity1V89(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V89
	{
		internal static readonly DActionArity1V89 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V89))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSSet<UNNotificationCategory>>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSSet<UNNotificationCategory>>(obj));
		}
	}

	internal sealed class NIDActionArity1V89 : TrampolineBlockBase
	{
		private DActionArity1V89 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V89(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V89>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSSet<UNNotificationCategory>>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSSet<UNNotificationCategory>> action = (Action<NSSet<UNNotificationCategory>>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSSet<UNNotificationCategory>>(new NIDActionArity1V89((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSSet<UNNotificationCategory> obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSTimer>))]
	internal delegate void DActionArity1V34(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V34
	{
		internal static readonly DActionArity1V34 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V34))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSTimer>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSTimer>(obj));
		}
	}

	internal sealed class NIDActionArity1V34 : TrampolineBlockBase
	{
		private DActionArity1V34 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V34(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V34>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSTimer>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSTimer> action = (Action<NSTimer>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSTimer>(new NIDActionArity1V34((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSTimer obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrl>))]
	internal delegate void DActionArity1V29(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V29
	{
		internal static readonly DActionArity1V29 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V29))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrl>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(obj));
		}
	}

	internal sealed class NIDActionArity1V29 : TrampolineBlockBase
	{
		private DActionArity1V29 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V29(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V29>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrl>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrl> action = (Action<NSUrl>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrl>(new NIDActionArity1V29((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl obj)
		{
			invoker(base.BlockPointer, (obj == null) ? IntPtr.Zero : obj.Handle);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrlCredential>))]
	internal delegate void DActionArity1V38(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V38
	{
		internal static readonly DActionArity1V38 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V38))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrlCredential>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrlCredential>(obj));
		}
	}

	internal sealed class NIDActionArity1V38 : TrampolineBlockBase
	{
		private DActionArity1V38 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V38(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V38>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrlCredential>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrlCredential> action = (Action<NSUrlCredential>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrlCredential>(new NIDActionArity1V38((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlCredential obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrlRequest>))]
	internal delegate void DActionArity1V40(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V40
	{
		internal static readonly DActionArity1V40 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V40))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrlRequest>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrlRequest>(obj));
		}
	}

	internal sealed class NIDActionArity1V40 : TrampolineBlockBase
	{
		private DActionArity1V40 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V40(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V40>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrlRequest>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrlRequest> action = (Action<NSUrlRequest>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrlRequest>(new NIDActionArity1V40((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlRequest obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrlSessionResponseDisposition>))]
	internal delegate void DActionArity1V39(IntPtr block, nint obj);

	internal static class SDActionArity1V39
	{
		internal static readonly DActionArity1V39 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V39))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrlSessionResponseDisposition>)ptr->Target)?.Invoke((NSUrlSessionResponseDisposition)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V39 : TrampolineBlockBase
	{
		private DActionArity1V39 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V39(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V39>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrlSessionResponseDisposition>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrlSessionResponseDisposition> action = (Action<NSUrlSessionResponseDisposition>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrlSessionResponseDisposition>(new NIDActionArity1V39((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionResponseDisposition obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrl[]>))]
	internal delegate void DActionArity1V95(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V95
	{
		internal static readonly DActionArity1V95 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V95))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrl[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSUrl>(obj));
		}
	}

	internal sealed class NIDActionArity1V95 : TrampolineBlockBase
	{
		private DActionArity1V95 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V95(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V95>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrl[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrl[]> action = (Action<NSUrl[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrl[]>(new NIDActionArity1V95((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GCController>))]
	internal delegate void DActionArity1V42(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V42
	{
		internal static readonly DActionArity1V42 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V42))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GCController>)ptr->Target)?.Invoke(Runtime.GetNSObject<GCController>(obj));
		}
	}

	internal sealed class NIDActionArity1V42 : TrampolineBlockBase
	{
		private DActionArity1V42 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V42(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V42>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GCController>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GCController> action = (Action<GCController>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GCController>(new NIDActionArity1V42((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCController obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GCMotion>))]
	internal delegate void DActionArity1V43(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V43
	{
		internal static readonly DActionArity1V43 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V43))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GCMotion>)ptr->Target)?.Invoke(Runtime.GetNSObject<GCMotion>(obj));
		}
	}

	internal sealed class NIDActionArity1V43 : TrampolineBlockBase
	{
		private DActionArity1V43 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V43(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V43>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GCMotion>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GCMotion> action = (Action<GCMotion>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GCMotion>(new NIDActionArity1V43((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GCMotion obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKPlayer>))]
	internal delegate void DActionArity1V45(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V45
	{
		internal static readonly DActionArity1V45 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V45))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKPlayer>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKPlayer>(obj));
		}
	}

	internal sealed class NIDActionArity1V45 : TrampolineBlockBase
	{
		private DActionArity1V45 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V45(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V45>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKPlayer>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKPlayer> action = (Action<GKPlayer>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKPlayer>(new NIDActionArity1V45((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKPlayer obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKRuleSystem>))]
	internal delegate void DActionArity1V46(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V46
	{
		internal static readonly DActionArity1V46 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V46))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKRuleSystem>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKRuleSystem>(obj));
		}
	}

	internal sealed class NIDActionArity1V46 : TrampolineBlockBase
	{
		private DActionArity1V46 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V46(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V46>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKRuleSystem>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKRuleSystem> action = (Action<GKRuleSystem>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKRuleSystem>(new NIDActionArity1V46((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKRuleSystem obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INCallDestinationTypeResolutionResult>))]
	internal delegate void DActionArity1V63(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V63
	{
		internal static readonly DActionArity1V63 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V63))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INCallDestinationTypeResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INCallDestinationTypeResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V63 : TrampolineBlockBase
	{
		private DActionArity1V63 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V63(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V63>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INCallDestinationTypeResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INCallDestinationTypeResolutionResult> action = (Action<INCallDestinationTypeResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INCallDestinationTypeResolutionResult>(new NIDActionArity1V63((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INCallDestinationTypeResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INCallRecordTypeOptionsResolutionResult>))]
	internal delegate void DActionArity1V53(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V53
	{
		internal static readonly DActionArity1V53 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V53))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INCallRecordTypeOptionsResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INCallRecordTypeOptionsResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V53 : TrampolineBlockBase
	{
		private DActionArity1V53 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V53(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V53>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INCallRecordTypeOptionsResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INCallRecordTypeOptionsResolutionResult> action = (Action<INCallRecordTypeOptionsResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INCallRecordTypeOptionsResolutionResult>(new NIDActionArity1V53((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INCallRecordTypeOptionsResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INCallRecordTypeResolutionResult>))]
	internal delegate void DActionArity1V50(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V50
	{
		internal static readonly DActionArity1V50 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V50))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INCallRecordTypeResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INCallRecordTypeResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V50 : TrampolineBlockBase
	{
		private DActionArity1V50 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V50(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V50>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INCallRecordTypeResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INCallRecordTypeResolutionResult> action = (Action<INCallRecordTypeResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INCallRecordTypeResolutionResult>(new NIDActionArity1V50((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INCallRecordTypeResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INDateComponentsRangeResolutionResult>))]
	internal delegate void DActionArity1V51(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V51
	{
		internal static readonly DActionArity1V51 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V51))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INDateComponentsRangeResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V51 : TrampolineBlockBase
	{
		private DActionArity1V51 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V51(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V51>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INDateComponentsRangeResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INDateComponentsRangeResolutionResult> action = (Action<INDateComponentsRangeResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INDateComponentsRangeResolutionResult>(new NIDActionArity1V51((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INDateComponentsRangeResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INMessageAttributeOptionsResolutionResult>))]
	internal delegate void DActionArity1V56(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V56
	{
		internal static readonly DActionArity1V56 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V56))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INMessageAttributeOptionsResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V56 : TrampolineBlockBase
	{
		private DActionArity1V56 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V56(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V56>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INMessageAttributeOptionsResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INMessageAttributeOptionsResolutionResult> action = (Action<INMessageAttributeOptionsResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INMessageAttributeOptionsResolutionResult>(new NIDActionArity1V56((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INMessageAttributeOptionsResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INPersonResolutionResult>))]
	internal delegate void DActionArity1V52(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V52
	{
		internal static readonly DActionArity1V52 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V52))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INPersonResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INPersonResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V52 : TrampolineBlockBase
	{
		private DActionArity1V52 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V52(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V52>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INPersonResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INPersonResolutionResult> action = (Action<INPersonResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INPersonResolutionResult>(new NIDActionArity1V52((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INPersonResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INPersonResolutionResult[]>))]
	internal delegate void DActionArity1V55(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V55
	{
		internal static readonly DActionArity1V55 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V55))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INPersonResolutionResult[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<INPersonResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V55 : TrampolineBlockBase
	{
		private DActionArity1V55 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V55(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V55>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INPersonResolutionResult[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INPersonResolutionResult[]> action = (Action<INPersonResolutionResult[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INPersonResolutionResult[]>(new NIDActionArity1V55((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INPersonResolutionResult[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSearchCallHistoryIntentResponse>))]
	internal delegate void DActionArity1V47(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V47
	{
		internal static readonly DActionArity1V47 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V47))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSearchCallHistoryIntentResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<INSearchCallHistoryIntentResponse>(obj));
		}
	}

	internal sealed class NIDActionArity1V47 : TrampolineBlockBase
	{
		private DActionArity1V47 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V47(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V47>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSearchCallHistoryIntentResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSearchCallHistoryIntentResponse> action = (Action<INSearchCallHistoryIntentResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSearchCallHistoryIntentResponse>(new NIDActionArity1V47((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSearchCallHistoryIntentResponse obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSearchForMessagesIntentResponse>))]
	internal delegate void DActionArity1V54(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V54
	{
		internal static readonly DActionArity1V54 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V54))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSearchForMessagesIntentResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<INSearchForMessagesIntentResponse>(obj));
		}
	}

	internal sealed class NIDActionArity1V54 : TrampolineBlockBase
	{
		private DActionArity1V54 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V54(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V54>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSearchForMessagesIntentResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSearchForMessagesIntentResponse> action = (Action<INSearchForMessagesIntentResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSearchForMessagesIntentResponse>(new NIDActionArity1V54((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSearchForMessagesIntentResponse obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSendMessageIntentResponse>))]
	internal delegate void DActionArity1V59(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V59
	{
		internal static readonly DActionArity1V59 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V59))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSendMessageIntentResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<INSendMessageIntentResponse>(obj));
		}
	}

	internal sealed class NIDActionArity1V59 : TrampolineBlockBase
	{
		private DActionArity1V59 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V59(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V59>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSendMessageIntentResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSendMessageIntentResponse> action = (Action<INSendMessageIntentResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSendMessageIntentResponse>(new NIDActionArity1V59((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSendMessageIntentResponse obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSendMessageRecipientResolutionResult[]>))]
	internal delegate void DActionArity1V60(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V60
	{
		internal static readonly DActionArity1V60 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V60))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSendMessageRecipientResolutionResult[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<INSendMessageRecipientResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V60 : TrampolineBlockBase
	{
		private DActionArity1V60 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V60(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V60>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSendMessageRecipientResolutionResult[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSendMessageRecipientResolutionResult[]> action = (Action<INSendMessageRecipientResolutionResult[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSendMessageRecipientResolutionResult[]>(new NIDActionArity1V60((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSendMessageRecipientResolutionResult[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSpeakableStringResolutionResult>))]
	internal delegate void DActionArity1V62(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V62
	{
		internal static readonly DActionArity1V62 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V62))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSpeakableStringResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INSpeakableStringResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V62 : TrampolineBlockBase
	{
		private DActionArity1V62 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V62(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V62>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSpeakableStringResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSpeakableStringResolutionResult> action = (Action<INSpeakableStringResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSpeakableStringResolutionResult>(new NIDActionArity1V62((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSpeakableStringResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSpeakableStringResolutionResult[]>))]
	internal delegate void DActionArity1V58(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V58
	{
		internal static readonly DActionArity1V58 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V58))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSpeakableStringResolutionResult[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<INSpeakableStringResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V58 : TrampolineBlockBase
	{
		private DActionArity1V58 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V58(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V58>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSpeakableStringResolutionResult[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSpeakableStringResolutionResult[]> action = (Action<INSpeakableStringResolutionResult[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSpeakableStringResolutionResult[]>(new NIDActionArity1V58((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSpeakableStringResolutionResult[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INStartAudioCallIntentResponse>))]
	internal delegate void DActionArity1V48(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V48
	{
		internal static readonly DActionArity1V48 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V48))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INStartAudioCallIntentResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<INStartAudioCallIntentResponse>(obj));
		}
	}

	internal sealed class NIDActionArity1V48 : TrampolineBlockBase
	{
		private DActionArity1V48 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V48(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V48>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INStartAudioCallIntentResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INStartAudioCallIntentResponse> action = (Action<INStartAudioCallIntentResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INStartAudioCallIntentResponse>(new NIDActionArity1V48((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INStartAudioCallIntentResponse obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INStartVideoCallIntentResponse>))]
	internal delegate void DActionArity1V49(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V49
	{
		internal static readonly DActionArity1V49 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V49))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INStartVideoCallIntentResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<INStartVideoCallIntentResponse>(obj));
		}
	}

	internal sealed class NIDActionArity1V49 : TrampolineBlockBase
	{
		private DActionArity1V49 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V49(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V49>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INStartVideoCallIntentResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INStartVideoCallIntentResponse> action = (Action<INStartVideoCallIntentResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INStartVideoCallIntentResponse>(new NIDActionArity1V49((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INStartVideoCallIntentResponse obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INStringResolutionResult>))]
	internal delegate void DActionArity1V61(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V61
	{
		internal static readonly DActionArity1V61 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V61))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INStringResolutionResult>)ptr->Target)?.Invoke(Runtime.GetNSObject<INStringResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V61 : TrampolineBlockBase
	{
		private DActionArity1V61 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V61(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V61>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INStringResolutionResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INStringResolutionResult> action = (Action<INStringResolutionResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INStringResolutionResult>(new NIDActionArity1V61((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INStringResolutionResult obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INStringResolutionResult[]>))]
	internal delegate void DActionArity1V57(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V57
	{
		internal static readonly DActionArity1V57 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V57))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INStringResolutionResult[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<INStringResolutionResult>(obj));
		}
	}

	internal sealed class NIDActionArity1V57 : TrampolineBlockBase
	{
		private DActionArity1V57 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V57(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V57>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INStringResolutionResult[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INStringResolutionResult[]> action = (Action<INStringResolutionResult[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INStringResolutionResult[]>(new NIDActionArity1V57((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INStringResolutionResult[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLCommandBuffer>))]
	internal delegate void DActionArity1V64(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V64
	{
		internal static readonly DActionArity1V64 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V64))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLCommandBuffer>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLCommandBuffer>(obj, owns: false));
		}
	}

	internal sealed class NIDActionArity1V64 : TrampolineBlockBase
	{
		private DActionArity1V64 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V64(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V64>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLCommandBuffer>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLCommandBuffer> action = (Action<IMTLCommandBuffer>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLCommandBuffer>(new NIDActionArity1V64((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLCommandBuffer obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLDrawable>))]
	internal delegate void DActionArity1V65(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V65
	{
		internal static readonly DActionArity1V65 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V65))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLDrawable>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLDrawable>(obj, owns: false));
		}
	}

	internal sealed class NIDActionArity1V65 : TrampolineBlockBase
	{
		private DActionArity1V65 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V65(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V65>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLDrawable>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLDrawable> action = (Action<IMTLDrawable>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLDrawable>(new NIDActionArity1V65((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLDrawable obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<MDLMaterialPropertyNode>))]
	internal delegate void DActionArity1V66(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V66
	{
		internal static readonly DActionArity1V66 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V66))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<MDLMaterialPropertyNode>)ptr->Target)?.Invoke(Runtime.GetNSObject<MDLMaterialPropertyNode>(obj));
		}
	}

	internal sealed class NIDActionArity1V66 : TrampolineBlockBase
	{
		private DActionArity1V66 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V66(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V66>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<MDLMaterialPropertyNode>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<MDLMaterialPropertyNode> action = (Action<MDLMaterialPropertyNode>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<MDLMaterialPropertyNode>(new NIDActionArity1V66((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MDLMaterialPropertyNode obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NEPacket[]>))]
	internal delegate void DActionArity1V67(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V67
	{
		internal static readonly DActionArity1V67 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V67))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NEPacket[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NEPacket>(obj));
		}
	}

	internal sealed class NIDActionArity1V67 : TrampolineBlockBase
	{
		private DActionArity1V67 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V67(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V67>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NEPacket[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NEPacket[]> action = (Action<NEPacket[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NEPacket[]>(new NIDActionArity1V67((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NEPacket[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NCUpdateResult>))]
	internal delegate void DActionArity1V69(IntPtr block, nuint obj);

	internal static class SDActionArity1V69
	{
		internal static readonly DActionArity1V69 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V69))]
		private unsafe static void Invoke(IntPtr block, nuint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NCUpdateResult>)ptr->Target)?.Invoke((NCUpdateResult)(ulong)obj);
		}
	}

	internal sealed class NIDActionArity1V69 : TrampolineBlockBase
	{
		private DActionArity1V69 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V69(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V69>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NCUpdateResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NCUpdateResult> action = (Action<NCUpdateResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NCUpdateResult>(new NIDActionArity1V69((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NCUpdateResult obj)
		{
			invoker(base.BlockPointer, (nuint)(ulong)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<PHAuthorizationStatus>))]
	internal delegate void DActionArity1V71(IntPtr block, nint obj);

	internal static class SDActionArity1V71
	{
		internal static readonly DActionArity1V71 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V71))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<PHAuthorizationStatus>)ptr->Target)?.Invoke((PHAuthorizationStatus)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V71 : TrampolineBlockBase
	{
		private DActionArity1V71 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V71(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V71>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<PHAuthorizationStatus>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<PHAuthorizationStatus> action = (Action<PHAuthorizationStatus>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<PHAuthorizationStatus>(new NIDActionArity1V71((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHAuthorizationStatus obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<PHContentEditingOutput>))]
	internal delegate void DActionArity1V72(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V72
	{
		internal static readonly DActionArity1V72 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V72))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<PHContentEditingOutput>)ptr->Target)?.Invoke(Runtime.GetNSObject<PHContentEditingOutput>(obj));
		}
	}

	internal sealed class NIDActionArity1V72 : TrampolineBlockBase
	{
		private DActionArity1V72 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V72(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V72>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<PHContentEditingOutput>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<PHContentEditingOutput> action = (Action<PHContentEditingOutput>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<PHContentEditingOutput>(new NIDActionArity1V72((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHContentEditingOutput obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<PHProjectInfo>))]
	internal delegate void DActionArity1V73(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V73
	{
		internal static readonly DActionArity1V73 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V73))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<PHProjectInfo>)ptr->Target)?.Invoke(Runtime.GetNSObject<PHProjectInfo>(obj));
		}
	}

	internal sealed class NIDActionArity1V73 : TrampolineBlockBase
	{
		private DActionArity1V73 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V73(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V73>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<PHProjectInfo>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<PHProjectInfo> action = (Action<PHProjectInfo>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<PHProjectInfo>(new NIDActionArity1V73((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHProjectInfo obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariPage>))]
	internal delegate void DActionArity1V81(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V81
	{
		internal static readonly DActionArity1V81 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V81))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariPage>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFSafariPage>(obj));
		}
	}

	internal sealed class NIDActionArity1V81 : TrampolineBlockBase
	{
		private DActionArity1V81 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V81(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V81>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariPage>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariPage> action = (Action<SFSafariPage>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariPage>(new NIDActionArity1V81((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariPage obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariPageProperties>))]
	internal delegate void DActionArity1V79(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V79
	{
		internal static readonly DActionArity1V79 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V79))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariPageProperties>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFSafariPageProperties>(obj));
		}
	}

	internal sealed class NIDActionArity1V79 : TrampolineBlockBase
	{
		private DActionArity1V79 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V79(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V79>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariPageProperties>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariPageProperties> action = (Action<SFSafariPageProperties>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariPageProperties>(new NIDActionArity1V79((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariPageProperties obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariPage[]>))]
	internal delegate void DActionArity1V82(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V82
	{
		internal static readonly DActionArity1V82 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V82))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariPage[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<SFSafariPage>(obj));
		}
	}

	internal sealed class NIDActionArity1V82 : TrampolineBlockBase
	{
		private DActionArity1V82 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V82(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V82>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariPage[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariPage[]> action = (Action<SFSafariPage[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariPage[]>(new NIDActionArity1V82((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariPage[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariTab>))]
	internal delegate void DActionArity1V78(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V78
	{
		internal static readonly DActionArity1V78 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V78))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariTab>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFSafariTab>(obj));
		}
	}

	internal sealed class NIDActionArity1V78 : TrampolineBlockBase
	{
		private DActionArity1V78 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V78(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V78>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariTab>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariTab> action = (Action<SFSafariTab>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariTab>(new NIDActionArity1V78((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariTab obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariTab[]>))]
	internal delegate void DActionArity1V83(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V83
	{
		internal static readonly DActionArity1V83 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V83))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariTab[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<SFSafariTab>(obj));
		}
	}

	internal sealed class NIDActionArity1V83 : TrampolineBlockBase
	{
		private DActionArity1V83 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V83(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V83>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariTab[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariTab[]> action = (Action<SFSafariTab[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariTab[]>(new NIDActionArity1V83((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariTab[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariToolbarItem>))]
	internal delegate void DActionArity1V84(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V84
	{
		internal static readonly DActionArity1V84 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V84))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariToolbarItem>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFSafariToolbarItem>(obj));
		}
	}

	internal sealed class NIDActionArity1V84 : TrampolineBlockBase
	{
		private DActionArity1V84 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V84(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V84>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariToolbarItem>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariToolbarItem> action = (Action<SFSafariToolbarItem>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariToolbarItem>(new NIDActionArity1V84((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariToolbarItem obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariWindow>))]
	internal delegate void DActionArity1V74(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V74
	{
		internal static readonly DActionArity1V74 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V74))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariWindow>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFSafariWindow>(obj));
		}
	}

	internal sealed class NIDActionArity1V74 : TrampolineBlockBase
	{
		private DActionArity1V74 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V74(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V74>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariWindow>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariWindow> action = (Action<SFSafariWindow>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariWindow>(new NIDActionArity1V74((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariWindow obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSafariWindow[]>))]
	internal delegate void DActionArity1V75(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V75
	{
		internal static readonly DActionArity1V75 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V75))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSafariWindow[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<SFSafariWindow>(obj));
		}
	}

	internal sealed class NIDActionArity1V75 : TrampolineBlockBase
	{
		private DActionArity1V75 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V75(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V75>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSafariWindow[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSafariWindow[]> action = (Action<SFSafariWindow[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSafariWindow[]>(new NIDActionArity1V75((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSafariWindow[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SCNNode>))]
	internal delegate void DActionArity1V85(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V85
	{
		internal static readonly DActionArity1V85 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V85))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SCNNode>)ptr->Target)?.Invoke(Runtime.GetNSObject<SCNNode>(obj));
		}
	}

	internal sealed class NIDActionArity1V85 : TrampolineBlockBase
	{
		private DActionArity1V85 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V85(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V85>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SCNNode>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SCNNode> action = (Action<SCNNode>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SCNNode>(new NIDActionArity1V85((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SCNNode obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SecTrust>))]
	internal delegate void DActionArity1V68(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V68
	{
		internal static readonly DActionArity1V68 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V68))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SecTrust>)ptr->Target)?.Invoke(new SecTrust(obj));
		}
	}

	internal sealed class NIDActionArity1V68 : TrampolineBlockBase
	{
		private DActionArity1V68 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V68(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V68>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SecTrust>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SecTrust> action = (Action<SecTrust>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SecTrust>(new NIDActionArity1V68((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SecTrust obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSpeechRecognizerAuthorizationStatus>))]
	internal delegate void DActionArity1V86(IntPtr block, nint obj);

	internal static class SDActionArity1V86
	{
		internal static readonly DActionArity1V86 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V86))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSpeechRecognizerAuthorizationStatus>)ptr->Target)?.Invoke((SFSpeechRecognizerAuthorizationStatus)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V86 : TrampolineBlockBase
	{
		private DActionArity1V86 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V86(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V86>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSpeechRecognizerAuthorizationStatus>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSpeechRecognizerAuthorizationStatus> action = (Action<SFSpeechRecognizerAuthorizationStatus>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSpeechRecognizerAuthorizationStatus>(new NIDActionArity1V86((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSpeechRecognizerAuthorizationStatus obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<bool>))]
	internal delegate void DActionArity1V0(IntPtr block, bool obj);

	internal static class SDActionArity1V0
	{
		internal static readonly DActionArity1V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V0))]
		private unsafe static void Invoke(IntPtr block, bool obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<bool>)ptr->Target)?.Invoke(obj);
		}
	}

	internal sealed class NIDActionArity1V0 : TrampolineBlockBase
	{
		private DActionArity1V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<bool> action = (Action<bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<bool>(new NIDActionArity1V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool obj)
		{
			invoker(base.BlockPointer, obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<double>))]
	internal delegate void DActionArity1V70(IntPtr block, double obj);

	internal static class SDActionArity1V70
	{
		internal static readonly DActionArity1V70 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V70))]
		private unsafe static void Invoke(IntPtr block, double obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<double>)ptr->Target)?.Invoke(obj);
		}
	}

	internal sealed class NIDActionArity1V70 : TrampolineBlockBase
	{
		private DActionArity1V70 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V70(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V70>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<double>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<double> action = (Action<double>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<double>(new NIDActionArity1V70((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(double obj)
		{
			invoker(base.BlockPointer, obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IntPtr>))]
	internal delegate void DActionArity1V24(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V24
	{
		internal static readonly DActionArity1V24 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V24))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IntPtr>)ptr->Target)?.Invoke(obj);
		}
	}

	internal sealed class NIDActionArity1V24 : TrampolineBlockBase
	{
		private DActionArity1V24 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V24(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V24>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IntPtr>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IntPtr> action = (Action<IntPtr>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IntPtr>(new NIDActionArity1V24((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr obj)
		{
			invoker(base.BlockPointer, obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<string>))]
	internal delegate void DActionArity1V44(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V44
	{
		internal static readonly DActionArity1V44 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V44))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<string>)ptr->Target)?.Invoke(NSString.FromHandle(obj));
		}
	}

	internal sealed class NIDActionArity1V44 : TrampolineBlockBase
	{
		private DActionArity1V44 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V44(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V44>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<string>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<string> action = (Action<string>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<string>(new NIDActionArity1V44((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string obj)
		{
			IntPtr intPtr = NSString.CreateNative(obj);
			invoker(base.BlockPointer, intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<string[]>))]
	internal delegate void DActionArity1V1(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V1
	{
		internal static readonly DActionArity1V1 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V1))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<string[]>)ptr->Target)?.Invoke(NSArray.StringArrayFromHandle(obj));
		}
	}

	internal sealed class NIDActionArity1V1 : TrampolineBlockBase
	{
		private DActionArity1V1 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V1(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V1>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<string[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<string[]> action = (Action<string[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<string[]>(new NIDActionArity1V1((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromStrings(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<nint>))]
	internal delegate void DActionArity1V13(IntPtr block, nint obj);

	internal static class SDActionArity1V13
	{
		internal static readonly DActionArity1V13 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V13))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<nint>)ptr->Target)?.Invoke(obj);
		}
	}

	internal sealed class NIDActionArity1V13 : TrampolineBlockBase
	{
		private DActionArity1V13 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V13(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V13>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<nint>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<nint> action = (Action<nint>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<nint>(new NIDActionArity1V13((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint obj)
		{
			invoker(base.BlockPointer, obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<UNNotificationContent>))]
	internal delegate void DActionArity1V87(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V87
	{
		internal static readonly DActionArity1V87 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V87))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<UNNotificationContent>)ptr->Target)?.Invoke(Runtime.GetNSObject<UNNotificationContent>(obj));
		}
	}

	internal sealed class NIDActionArity1V87 : TrampolineBlockBase
	{
		private DActionArity1V87 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V87(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V87>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<UNNotificationContent>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<UNNotificationContent> action = (Action<UNNotificationContent>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<UNNotificationContent>(new NIDActionArity1V87((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(UNNotificationContent obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<UNNotificationPresentationOptions>))]
	internal delegate void DActionArity1V92(IntPtr block, nuint obj);

	internal static class SDActionArity1V92
	{
		internal static readonly DActionArity1V92 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V92))]
		private unsafe static void Invoke(IntPtr block, nuint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<UNNotificationPresentationOptions>)ptr->Target)?.Invoke((UNNotificationPresentationOptions)(ulong)obj);
		}
	}

	internal sealed class NIDActionArity1V92 : TrampolineBlockBase
	{
		private DActionArity1V92 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V92(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V92>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<UNNotificationPresentationOptions>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<UNNotificationPresentationOptions> action = (Action<UNNotificationPresentationOptions>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<UNNotificationPresentationOptions>(new NIDActionArity1V92((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(UNNotificationPresentationOptions obj)
		{
			invoker(base.BlockPointer, (nuint)(ulong)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<UNNotificationRequest[]>))]
	internal delegate void DActionArity1V91(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V91
	{
		internal static readonly DActionArity1V91 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V91))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<UNNotificationRequest[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<UNNotificationRequest>(obj));
		}
	}

	internal sealed class NIDActionArity1V91 : TrampolineBlockBase
	{
		private DActionArity1V91 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V91(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V91>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<UNNotificationRequest[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<UNNotificationRequest[]> action = (Action<UNNotificationRequest[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<UNNotificationRequest[]>(new NIDActionArity1V91((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(UNNotificationRequest[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<UNNotificationSettings>))]
	internal delegate void DActionArity1V90(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V90
	{
		internal static readonly DActionArity1V90 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V90))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<UNNotificationSettings>)ptr->Target)?.Invoke(Runtime.GetNSObject<UNNotificationSettings>(obj));
		}
	}

	internal sealed class NIDActionArity1V90 : TrampolineBlockBase
	{
		private DActionArity1V90 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V90(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V90>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<UNNotificationSettings>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<UNNotificationSettings> action = (Action<UNNotificationSettings>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<UNNotificationSettings>(new NIDActionArity1V90((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(UNNotificationSettings obj)
		{
			invoker(base.BlockPointer, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<UNNotification[]>))]
	internal delegate void DActionArity1V88(IntPtr block, IntPtr obj);

	internal static class SDActionArity1V88
	{
		internal static readonly DActionArity1V88 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V88))]
		private unsafe static void Invoke(IntPtr block, IntPtr obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<UNNotification[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<UNNotification>(obj));
		}
	}

	internal sealed class NIDActionArity1V88 : TrampolineBlockBase
	{
		private DActionArity1V88 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V88(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V88>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<UNNotification[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<UNNotification[]> action = (Action<UNNotification[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<UNNotification[]>(new NIDActionArity1V88((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(UNNotification[] obj)
		{
			NSArray nSArray = ((obj == null) ? null : NSArray.FromNSObjects(obj));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<WKNavigationActionPolicy>))]
	internal delegate void DActionArity1V93(IntPtr block, nint obj);

	internal static class SDActionArity1V93
	{
		internal static readonly DActionArity1V93 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V93))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<WKNavigationActionPolicy>)ptr->Target)?.Invoke((WKNavigationActionPolicy)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V93 : TrampolineBlockBase
	{
		private DActionArity1V93 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V93(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V93>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<WKNavigationActionPolicy>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<WKNavigationActionPolicy> action = (Action<WKNavigationActionPolicy>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<WKNavigationActionPolicy>(new NIDActionArity1V93((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(WKNavigationActionPolicy obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<WKNavigationResponsePolicy>))]
	internal delegate void DActionArity1V94(IntPtr block, nint obj);

	internal static class SDActionArity1V94
	{
		internal static readonly DActionArity1V94 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity1V94))]
		private unsafe static void Invoke(IntPtr block, nint obj)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<WKNavigationResponsePolicy>)ptr->Target)?.Invoke((WKNavigationResponsePolicy)(long)obj);
		}
	}

	internal sealed class NIDActionArity1V94 : TrampolineBlockBase
	{
		private DActionArity1V94 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity1V94(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity1V94>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<WKNavigationResponsePolicy>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<WKNavigationResponsePolicy> action = (Action<WKNavigationResponsePolicy>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<WKNavigationResponsePolicy>(new NIDActionArity1V94((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(WKNavigationResponsePolicy obj)
		{
			invoker(base.BlockPointer, (nint)(long)obj);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AVAudioUnit, NSError>))]
	internal delegate void DActionArity2V2(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V2
	{
		internal static readonly DActionArity2V2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V2))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AVAudioUnit, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<AVAudioUnit>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V2 : TrampolineBlockBase
	{
		private DActionArity2V2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AVAudioUnit, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AVAudioUnit, NSError> action = (Action<AVAudioUnit, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AVAudioUnit, NSError>(new NIDActionArity2V2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AVAudioUnit arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<ACAccountCredentialRenewResult, NSError>))]
	internal delegate void DActionArity2V5(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V5
	{
		internal static readonly DActionArity2V5 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V5))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<ACAccountCredentialRenewResult, NSError>)ptr->Target)?.Invoke((ACAccountCredentialRenewResult)(long)arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V5 : TrampolineBlockBase
	{
		private DActionArity2V5 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V5(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V5>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<ACAccountCredentialRenewResult, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<ACAccountCredentialRenewResult, NSError> action = (Action<ACAccountCredentialRenewResult, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<ACAccountCredentialRenewResult, NSError>(new NIDActionArity2V5((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ACAccountCredentialRenewResult arg1, NSError arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSImage, NSError>))]
	internal delegate void DActionArity2V86(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V86
	{
		internal static readonly DActionArity2V86 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V86))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSImage, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSImage>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V86 : TrampolineBlockBase
	{
		private DActionArity2V86 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V86(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V86>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSImage, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSImage, NSError> action = (Action<NSImage, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSImage, NSError>(new NIDActionArity2V86((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSImage arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSRunningApplication, NSError>))]
	internal delegate void DActionArity2V10(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V10
	{
		internal static readonly DActionArity2V10 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V10))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSRunningApplication, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSRunningApplication>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V10 : TrampolineBlockBase
	{
		private DActionArity2V10 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V10(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V10>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSRunningApplication, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSRunningApplication, NSError> action = (Action<NSRunningApplication, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSRunningApplication, NSError>(new NIDActionArity2V10((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSRunningApplication arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSTableViewRowAction, nint>))]
	internal delegate void DActionArity2V9(IntPtr block, IntPtr arg1, nint arg2);

	internal static class SDActionArity2V9
	{
		internal static readonly DActionArity2V9 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V9))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, nint arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSTableViewRowAction, nint>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSTableViewRowAction>(arg1), arg2);
		}
	}

	internal sealed class NIDActionArity2V9 : TrampolineBlockBase
	{
		private DActionArity2V9 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V9(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V9>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSTableViewRowAction, nint>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSTableViewRowAction, nint> action = (Action<NSTableViewRowAction, nint>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSTableViewRowAction, nint>(new NIDActionArity2V9((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSTableViewRowAction arg1, nint arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSViewController, NSError>))]
	internal delegate void DActionArity2V57(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V57
	{
		internal static readonly DActionArity2V57 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V57))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSViewController, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSViewController>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V57 : TrampolineBlockBase
	{
		private DActionArity2V57 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V57(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V57>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSViewController, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSViewController, NSError> action = (Action<NSViewController, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSViewController, NSError>(new NIDActionArity2V57((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSViewController arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSWorkspaceAuthorization, NSError>))]
	internal delegate void DActionArity2V11(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V11
	{
		internal static readonly DActionArity2V11 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V11))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSWorkspaceAuthorization, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSWorkspaceAuthorization>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V11 : TrampolineBlockBase
	{
		private DActionArity2V11 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V11(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V11>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSWorkspaceAuthorization, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSWorkspaceAuthorization, NSError> action = (Action<NSWorkspaceAuthorization, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSWorkspaceAuthorization, NSError>(new NIDActionArity2V11((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSWorkspaceAuthorization arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<AUAudioUnit, NSError>))]
	internal delegate void DActionArity2V12(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V12
	{
		internal static readonly DActionArity2V12 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V12))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<AUAudioUnit, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<AUAudioUnit>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V12 : TrampolineBlockBase
	{
		private DActionArity2V12 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V12(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V12>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<AUAudioUnit, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<AUAudioUnit, NSError> action = (Action<AUAudioUnit, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<AUAudioUnit, NSError>(new NIDActionArity2V12((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(AUAudioUnit arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<ASAuthorizationAppleIdProviderCredentialState, NSError>))]
	internal delegate void DActionArity2V13(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V13
	{
		internal static readonly DActionArity2V13 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V13))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<ASAuthorizationAppleIdProviderCredentialState, NSError>)ptr->Target)?.Invoke((ASAuthorizationAppleIdProviderCredentialState)(long)arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V13 : TrampolineBlockBase
	{
		private DActionArity2V13 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V13(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V13>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<ASAuthorizationAppleIdProviderCredentialState, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<ASAuthorizationAppleIdProviderCredentialState, NSError> action = (Action<ASAuthorizationAppleIdProviderCredentialState, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<ASAuthorizationAppleIdProviderCredentialState, NSError>(new NIDActionArity2V13((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(ASAuthorizationAppleIdProviderCredentialState arg1, NSError arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKAccountStatus, NSError>))]
	internal delegate void DActionArity2V23(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V23
	{
		internal static readonly DActionArity2V23 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V23))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKAccountStatus, NSError>)ptr->Target)?.Invoke((CKAccountStatus)(long)arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V23 : TrampolineBlockBase
	{
		private DActionArity2V23 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V23(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V23>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKAccountStatus, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKAccountStatus, NSError> action = (Action<CKAccountStatus, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKAccountStatus, NSError>(new NIDActionArity2V23((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKAccountStatus arg1, NSError arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKApplicationPermissionStatus, NSError>))]
	internal delegate void DActionArity2V24(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V24
	{
		internal static readonly DActionArity2V24 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V24))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKApplicationPermissionStatus, NSError>)ptr->Target)?.Invoke((CKApplicationPermissionStatus)(long)arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V24 : TrampolineBlockBase
	{
		private DActionArity2V24 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V24(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V24>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKApplicationPermissionStatus, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKApplicationPermissionStatus, NSError> action = (Action<CKApplicationPermissionStatus, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKApplicationPermissionStatus, NSError>(new NIDActionArity2V24((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKApplicationPermissionStatus arg1, NSError arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKDiscoveredUserInfo, NSError>))]
	internal delegate void DActionArity2V18(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V18
	{
		internal static readonly DActionArity2V18 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V18))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKDiscoveredUserInfo, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKDiscoveredUserInfo>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V18 : TrampolineBlockBase
	{
		private DActionArity2V18 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V18(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V18>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKDiscoveredUserInfo, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKDiscoveredUserInfo, NSError> action = (Action<CKDiscoveredUserInfo, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKDiscoveredUserInfo, NSError>(new NIDActionArity2V18((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKDiscoveredUserInfo arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKDiscoveredUserInfo[], NSError>))]
	internal delegate void DActionArity2V15(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V15
	{
		internal static readonly DActionArity2V15 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V15))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKDiscoveredUserInfo[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKDiscoveredUserInfo>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V15 : TrampolineBlockBase
	{
		private DActionArity2V15 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V15(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V15>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKDiscoveredUserInfo[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKDiscoveredUserInfo[], NSError> action = (Action<CKDiscoveredUserInfo[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKDiscoveredUserInfo[], NSError>(new NIDActionArity2V15((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKDiscoveredUserInfo[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKQueryCursor, NSError>))]
	internal delegate void DActionArity2V36(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V36
	{
		internal static readonly DActionArity2V36 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V36))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKQueryCursor, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKQueryCursor>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V36 : TrampolineBlockBase
	{
		private DActionArity2V36 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V36(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V36>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKQueryCursor, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKQueryCursor, NSError> action = (Action<CKQueryCursor, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKQueryCursor, NSError>(new NIDActionArity2V36((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKQueryCursor arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecord, NSError>))]
	internal delegate void DActionArity2V28(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V28
	{
		internal static readonly DActionArity2V28 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V28))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecord, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecord>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V28 : TrampolineBlockBase
	{
		private DActionArity2V28 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V28(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V28>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecord, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecord, NSError> action = (Action<CKRecord, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecord, NSError>(new NIDActionArity2V28((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecord arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecord, double>))]
	internal delegate void DActionArity2V35(IntPtr block, IntPtr arg1, double arg2);

	internal static class SDActionArity2V35
	{
		internal static readonly DActionArity2V35 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V35))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, double arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecord, double>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecord>(arg1), arg2);
		}
	}

	internal sealed class NIDActionArity2V35 : TrampolineBlockBase
	{
		private DActionArity2V35 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V35(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V35>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecord, double>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecord, double> action = (Action<CKRecord, double>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecord, double>(new NIDActionArity2V35((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecord arg1, double arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordID, NSError>))]
	internal delegate void DActionArity2V22(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V22
	{
		internal static readonly DActionArity2V22 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V22))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordID, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordID>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V22 : TrampolineBlockBase
	{
		private DActionArity2V22 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V22(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V22>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordID, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordID, NSError> action = (Action<CKRecordID, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordID, NSError>(new NIDActionArity2V22((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordID arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordID, double>))]
	internal delegate void DActionArity2V34(IntPtr block, IntPtr arg1, double arg2);

	internal static class SDActionArity2V34
	{
		internal static readonly DActionArity2V34 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V34))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, double arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordID, double>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordID>(arg1), arg2);
		}
	}

	internal sealed class NIDActionArity2V34 : TrampolineBlockBase
	{
		private DActionArity2V34 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V34(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V34>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordID, double>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordID, double> action = (Action<CKRecordID, double>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordID, double>(new NIDActionArity2V34((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordID arg1, double arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordZone, NSError>))]
	internal delegate void DActionArity2V29(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V29
	{
		internal static readonly DActionArity2V29 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V29))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordZone, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordZone>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V29 : TrampolineBlockBase
	{
		private DActionArity2V29 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V29(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V29>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordZone, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordZone, NSError> action = (Action<CKRecordZone, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordZone, NSError>(new NIDActionArity2V29((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZone arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordZoneID, NSError>))]
	internal delegate void DActionArity2V25(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V25
	{
		internal static readonly DActionArity2V25 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V25))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordZoneID, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecordZoneID>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V25 : TrampolineBlockBase
	{
		private DActionArity2V25 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V25(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V25>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordZoneID, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordZoneID, NSError> action = (Action<CKRecordZoneID, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordZoneID, NSError>(new NIDActionArity2V25((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZoneID arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecordZone[], NSError>))]
	internal delegate void DActionArity2V26(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V26
	{
		internal static readonly DActionArity2V26 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V26))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecordZone[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKRecordZone>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V26 : TrampolineBlockBase
	{
		private DActionArity2V26 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V26(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V26>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecordZone[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecordZone[], NSError> action = (Action<CKRecordZone[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecordZone[], NSError>(new NIDActionArity2V26((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecordZone[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecord[], NSError>))]
	internal delegate void DActionArity2V31(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V31
	{
		internal static readonly DActionArity2V31 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V31))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecord[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKRecord>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V31 : TrampolineBlockBase
	{
		private DActionArity2V31 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V31(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V31>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecord[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecord[], NSError> action = (Action<CKRecord[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecord[], NSError>(new NIDActionArity2V31((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecord[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKServerChangeToken, NSError>))]
	internal delegate void DActionArity2V33(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V33
	{
		internal static readonly DActionArity2V33 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V33))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKServerChangeToken, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKServerChangeToken>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V33 : TrampolineBlockBase
	{
		private DActionArity2V33 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V33(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V33>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKServerChangeToken, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKServerChangeToken, NSError> action = (Action<CKServerChangeToken, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKServerChangeToken, NSError>(new NIDActionArity2V33((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKServerChangeToken arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKShare, NSError>))]
	internal delegate void DActionArity2V14(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V14
	{
		internal static readonly DActionArity2V14 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V14))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKShare, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKShare>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V14 : TrampolineBlockBase
	{
		private DActionArity2V14 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V14(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V14>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKShare, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKShare, NSError> action = (Action<CKShare, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKShare, NSError>(new NIDActionArity2V14((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKShare arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKShareMetadata, NSError>))]
	internal delegate void DActionArity2V20(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V20
	{
		internal static readonly DActionArity2V20 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V20))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKShareMetadata, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKShareMetadata>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V20 : TrampolineBlockBase
	{
		private DActionArity2V20 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V20(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V20>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKShareMetadata, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKShareMetadata, NSError> action = (Action<CKShareMetadata, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKShareMetadata, NSError>(new NIDActionArity2V20((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKShareMetadata arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKShareParticipant, NSError>))]
	internal delegate void DActionArity2V21(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V21
	{
		internal static readonly DActionArity2V21 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V21))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKShareParticipant, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKShareParticipant>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V21 : TrampolineBlockBase
	{
		private DActionArity2V21 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V21(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V21>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKShareParticipant, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKShareParticipant, NSError> action = (Action<CKShareParticipant, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKShareParticipant, NSError>(new NIDActionArity2V21((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKShareParticipant arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKSubscription, NSError>))]
	internal delegate void DActionArity2V30(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V30
	{
		internal static readonly DActionArity2V30 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V30))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKSubscription, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKSubscription>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V30 : TrampolineBlockBase
	{
		private DActionArity2V30 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V30(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V30>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKSubscription, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKSubscription, NSError> action = (Action<CKSubscription, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKSubscription, NSError>(new NIDActionArity2V30((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKSubscription arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKSubscription[], NSError>))]
	internal delegate void DActionArity2V27(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V27
	{
		internal static readonly DActionArity2V27 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V27))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKSubscription[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKSubscription>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V27 : TrampolineBlockBase
	{
		private DActionArity2V27 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V27(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V27>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKSubscription[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKSubscription[], NSError> action = (Action<CKSubscription[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKSubscription[], NSError>(new NIDActionArity2V27((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKSubscription[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKUserIdentity, CKUserIdentityLookupInfo>))]
	internal delegate void DActionArity2V32(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V32
	{
		internal static readonly DActionArity2V32 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V32))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKUserIdentity, CKUserIdentityLookupInfo>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKUserIdentity>(arg1), Runtime.GetNSObject<CKUserIdentityLookupInfo>(arg2));
		}
	}

	internal sealed class NIDActionArity2V32 : TrampolineBlockBase
	{
		private DActionArity2V32 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V32(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V32>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKUserIdentity, CKUserIdentityLookupInfo>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKUserIdentity, CKUserIdentityLookupInfo> action = (Action<CKUserIdentity, CKUserIdentityLookupInfo>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKUserIdentity, CKUserIdentityLookupInfo>(new NIDActionArity2V32((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKUserIdentity arg1, CKUserIdentityLookupInfo arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKUserIdentity, NSError>))]
	internal delegate void DActionArity2V17(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V17
	{
		internal static readonly DActionArity2V17 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V17))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKUserIdentity, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKUserIdentity>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V17 : TrampolineBlockBase
	{
		private DActionArity2V17 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V17(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V17>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKUserIdentity, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKUserIdentity, NSError> action = (Action<CKUserIdentity, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKUserIdentity, NSError>(new NIDActionArity2V17((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKUserIdentity arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKUserIdentity[], NSError>))]
	internal delegate void DActionArity2V16(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V16
	{
		internal static readonly DActionArity2V16 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V16))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKUserIdentity[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<CKUserIdentity>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V16 : TrampolineBlockBase
	{
		private DActionArity2V16 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V16(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V16>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKUserIdentity[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKUserIdentity[], NSError> action = (Action<CKUserIdentity[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKUserIdentity[], NSError>(new NIDActionArity2V16((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKUserIdentity[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSPersistentStoreDescription, NSError>))]
	internal delegate void DActionArity2V37(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V37
	{
		internal static readonly DActionArity2V37 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V37))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSPersistentStoreDescription, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSPersistentStoreDescription>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V37 : TrampolineBlockBase
	{
		private DActionArity2V37 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V37(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V37>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSPersistentStoreDescription, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSPersistentStoreDescription, NSError> action = (Action<NSPersistentStoreDescription, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSPersistentStoreDescription, NSError>(new NIDActionArity2V37((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSPersistentStoreDescription arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CGRect, double>))]
	internal delegate void DActionArity2V8(IntPtr block, CGRect arg1, double arg2);

	internal static class SDActionArity2V8
	{
		internal static readonly DActionArity2V8 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V8))]
		private unsafe static void Invoke(IntPtr block, CGRect arg1, double arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CGRect, double>)ptr->Target)?.Invoke(arg1, arg2);
		}
	}

	internal sealed class NIDActionArity2V8 : TrampolineBlockBase
	{
		private DActionArity2V8 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V8(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V8>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CGRect, double>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CGRect, double> action = (Action<CGRect, double>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CGRect, double>(new NIDActionArity2V8((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CGRect arg1, double arg2)
		{
			invoker(base.BlockPointer, arg1, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CMTime, NSError>))]
	internal delegate void DActionArity2V0(IntPtr block, CMTime arg1, IntPtr arg2);

	internal static class SDActionArity2V0
	{
		internal static readonly DActionArity2V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V0))]
		private unsafe static void Invoke(IntPtr block, CMTime arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CMTime, NSError>)ptr->Target)?.Invoke(arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V0 : TrampolineBlockBase
	{
		private DActionArity2V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CMTime, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CMTime, NSError> action = (Action<CMTime, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CMTime, NSError>(new NIDActionArity2V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CMTime arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CMPedometerData, NSError>))]
	internal delegate void DActionArity2V38(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V38
	{
		internal static readonly DActionArity2V38 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V38))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CMPedometerData, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CMPedometerData>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V38 : TrampolineBlockBase
	{
		private DActionArity2V38 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V38(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V38>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CMPedometerData, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CMPedometerData, NSError> action = (Action<CMPedometerData, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CMPedometerData, NSError>(new NIDActionArity2V38((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CMPedometerData arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CMPedometerEvent, NSError>))]
	internal delegate void DActionArity2V39(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V39
	{
		internal static readonly DActionArity2V39 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V39))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CMPedometerEvent, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CMPedometerEvent>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V39 : TrampolineBlockBase
	{
		private DActionArity2V39 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V39(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V39>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CMPedometerEvent, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CMPedometerEvent, NSError> action = (Action<CMPedometerEvent, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CMPedometerEvent, NSError>(new NIDActionArity2V39((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CMPedometerEvent arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<INSItemProviderReading, NSError>))]
	internal delegate void DActionArity2V43(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V43
	{
		internal static readonly DActionArity2V43 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V43))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<INSItemProviderReading, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<INSItemProviderReading>(arg1, owns: false), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V43 : TrampolineBlockBase
	{
		private DActionArity2V43 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V43(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V43>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<INSItemProviderReading, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<INSItemProviderReading, NSError> action = (Action<INSItemProviderReading, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<INSItemProviderReading, NSError>(new NIDActionArity2V43((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSItemProviderReading arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSArray, NSError>))]
	internal delegate void DActionArity2V73(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V73
	{
		internal static readonly DActionArity2V73 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V73))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSArray, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSArray>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V73 : TrampolineBlockBase
	{
		private DActionArity2V73 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V73(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V73>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSArray, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSArray, NSError> action = (Action<NSArray, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSArray, NSError>(new NIDActionArity2V73((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSArray arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSData, NSError>))]
	internal delegate void DActionArity2V3(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V3
	{
		internal static readonly DActionArity2V3 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V3))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSData, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V3 : TrampolineBlockBase
	{
		private DActionArity2V3 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V3(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V3>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSData, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSData, NSError> action = (Action<NSData, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSData, NSError>(new NIDActionArity2V3((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSData[], NSNumber[]>))]
	internal delegate void DActionArity2V74(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V74
	{
		internal static readonly DActionArity2V74 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V74))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSData[], NSNumber[]>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NSData>(arg1), NSArray.ArrayFromHandle<NSNumber>(arg2));
		}
	}

	internal sealed class NIDActionArity2V74 : TrampolineBlockBase
	{
		private DActionArity2V74 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V74(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V74>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSData[], NSNumber[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSData[], NSNumber[]> action = (Action<NSData[], NSNumber[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSData[], NSNumber[]>(new NIDActionArity2V74((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData[] arg1, NSNumber[] arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			NSArray nSArray2 = ((arg2 == null) ? null : NSArray.FromNSObjects(arg2));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
			nSArray2?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSDictionary<NSString, NSFileProviderService>, NSError>))]
	internal delegate void DActionArity2V41(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V41
	{
		internal static readonly DActionArity2V41 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V41))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSDictionary<NSString, NSFileProviderService>, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary<NSString, NSFileProviderService>>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V41 : TrampolineBlockBase
	{
		private DActionArity2V41 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V41(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V41>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSDictionary<NSString, NSFileProviderService>, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSDictionary<NSString, NSFileProviderService>, NSError> action = (Action<NSDictionary<NSString, NSFileProviderService>, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSDictionary<NSString, NSFileProviderService>, NSError>(new NIDActionArity2V41((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary<NSString, NSFileProviderService> arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSDictionary<NSString, NSOperation>, NSError>))]
	internal delegate void DActionArity2V19(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V19
	{
		internal static readonly DActionArity2V19 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V19))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSDictionary<NSString, NSOperation>, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSDictionary<NSString, NSOperation>>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V19 : TrampolineBlockBase
	{
		private DActionArity2V19 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V19(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V19>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSDictionary<NSString, NSOperation>, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSDictionary<NSString, NSOperation>, NSError> action = (Action<NSDictionary<NSString, NSOperation>, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSDictionary<NSString, NSOperation>, NSError>(new NIDActionArity2V19((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSDictionary<NSString, NSOperation> arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSObject, NSError>))]
	internal delegate void DActionArity2V42(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V42
	{
		internal static readonly DActionArity2V42 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V42))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSObject, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V42 : TrampolineBlockBase
	{
		private DActionArity2V42 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V42(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V42>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSObject, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSObject, NSError> action = (Action<NSObject, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSObject, NSError>(new NIDActionArity2V42((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrl, NSError>))]
	internal delegate void DActionArity2V6(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V6
	{
		internal static readonly DActionArity2V6 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V6))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrl, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V6 : TrampolineBlockBase
	{
		private DActionArity2V6 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V6(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V6>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrl, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrl, NSError> action = (Action<NSUrl, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrl, NSError>(new NIDActionArity2V6((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl arg1, NSError arg2)
		{
			invoker(base.BlockPointer, (arg1 == null) ? IntPtr.Zero : arg1.Handle, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>))]
	internal delegate void DActionArity2V44(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V44
	{
		internal static readonly DActionArity2V44 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V44))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>)ptr->Target)?.Invoke((NSUrlSessionAuthChallengeDisposition)(long)arg1, Runtime.GetNSObject<NSUrlCredential>(arg2));
		}
	}

	internal sealed class NIDActionArity2V44 : TrampolineBlockBase
	{
		private DActionArity2V44 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V44(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V44>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> action = (Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>(new NIDActionArity2V44((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionAuthChallengeDisposition arg1, NSUrlCredential arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>))]
	internal delegate void DActionArity2V45(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V45
	{
		internal static readonly DActionArity2V45 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V45))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>)ptr->Target)?.Invoke((NSUrlSessionDelayedRequestDisposition)(long)arg1, Runtime.GetNSObject<NSUrlRequest>(arg2));
		}
	}

	internal sealed class NIDActionArity2V45 : TrampolineBlockBase
	{
		private DActionArity2V45 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V45(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V45>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest> action = (Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>(new NIDActionArity2V45((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionDelayedRequestDisposition arg1, NSUrlRequest arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSUrlSessionWebSocketMessage, NSError>))]
	internal delegate void DActionArity2V46(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V46
	{
		internal static readonly DActionArity2V46 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V46))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSUrlSessionWebSocketMessage, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrlSessionWebSocketMessage>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V46 : TrampolineBlockBase
	{
		private DActionArity2V46 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V46(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V46>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSUrlSessionWebSocketMessage, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSUrlSessionWebSocketMessage, NSError> action = (Action<NSUrlSessionWebSocketMessage, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSUrlSessionWebSocketMessage, NSError>(new NIDActionArity2V46((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrlSessionWebSocketMessage arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKChallenge[], NSError>))]
	internal delegate void DActionArity2V49(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V49
	{
		internal static readonly DActionArity2V49 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V49))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKChallenge[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKChallenge>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V49 : TrampolineBlockBase
	{
		private DActionArity2V49 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V49(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V49>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKChallenge[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKChallenge[], NSError> action = (Action<GKChallenge[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKChallenge[], NSError>(new NIDActionArity2V49((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKChallenge[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKCloudPlayer, NSError>))]
	internal delegate void DActionArity2V50(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V50
	{
		internal static readonly DActionArity2V50 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V50))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKCloudPlayer, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKCloudPlayer>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V50 : TrampolineBlockBase
	{
		private DActionArity2V50 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V50(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V50>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKCloudPlayer, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKCloudPlayer, NSError> action = (Action<GKCloudPlayer, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKCloudPlayer, NSError>(new NIDActionArity2V50((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKCloudPlayer arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKGameSession, NSError>))]
	internal delegate void DActionArity2V51(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V51
	{
		internal static readonly DActionArity2V51 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V51))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKGameSession, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKGameSession>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V51 : TrampolineBlockBase
	{
		private DActionArity2V51 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V51(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V51>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKGameSession, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKGameSession, NSError> action = (Action<GKGameSession, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKGameSession, NSError>(new NIDActionArity2V51((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKGameSession arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKGameSession[], NSError>))]
	internal delegate void DActionArity2V52(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V52
	{
		internal static readonly DActionArity2V52 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V52))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKGameSession[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKGameSession>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V52 : TrampolineBlockBase
	{
		private DActionArity2V52 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V52(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V52>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKGameSession[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKGameSession[], NSError> action = (Action<GKGameSession[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKGameSession[], NSError>(new NIDActionArity2V52((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKGameSession[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKLeaderboard[], NSError>))]
	internal delegate void DActionArity2V53(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V53
	{
		internal static readonly DActionArity2V53 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V53))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKLeaderboard[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKLeaderboard>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V53 : TrampolineBlockBase
	{
		private DActionArity2V53 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V53(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V53>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKLeaderboard[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKLeaderboard[], NSError> action = (Action<GKLeaderboard[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKLeaderboard[], NSError>(new NIDActionArity2V53((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKLeaderboard[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKMatch, NSError>))]
	internal delegate void DActionArity2V58(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V58
	{
		internal static readonly DActionArity2V58 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V58))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKMatch, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKMatch>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V58 : TrampolineBlockBase
	{
		private DActionArity2V58 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V58(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V58>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKMatch, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKMatch, NSError> action = (Action<GKMatch, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKMatch, NSError>(new NIDActionArity2V58((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKMatch arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKPlayer, GKInviteRecipientResponse>))]
	internal delegate void DActionArity2V60(IntPtr block, IntPtr arg1, nint arg2);

	internal static class SDActionArity2V60
	{
		internal static readonly DActionArity2V60 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V60))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, nint arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKPlayer, GKInviteRecipientResponse>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKPlayer>(arg1), (GKInviteRecipientResponse)(long)arg2);
		}
	}

	internal sealed class NIDActionArity2V60 : TrampolineBlockBase
	{
		private DActionArity2V60 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V60(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V60>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKPlayer, GKInviteRecipientResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKPlayer, GKInviteRecipientResponse> action = (Action<GKPlayer, GKInviteRecipientResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKPlayer, GKInviteRecipientResponse>(new NIDActionArity2V60((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKPlayer arg1, GKInviteRecipientResponse arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, (nint)(long)arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKPlayer, GKVoiceChatPlayerState>))]
	internal delegate void DActionArity2V65(IntPtr block, IntPtr arg1, nint arg2);

	internal static class SDActionArity2V65
	{
		internal static readonly DActionArity2V65 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V65))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, nint arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKPlayer, GKVoiceChatPlayerState>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKPlayer>(arg1), (GKVoiceChatPlayerState)(long)arg2);
		}
	}

	internal sealed class NIDActionArity2V65 : TrampolineBlockBase
	{
		private DActionArity2V65 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V65(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V65>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKPlayer, GKVoiceChatPlayerState>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKPlayer, GKVoiceChatPlayerState> action = (Action<GKPlayer, GKVoiceChatPlayerState>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKPlayer, GKVoiceChatPlayerState>(new NIDActionArity2V65((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKPlayer arg1, GKVoiceChatPlayerState arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, (nint)(long)arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKPlayer, bool>))]
	internal delegate void DActionArity2V62(IntPtr block, IntPtr arg1, bool arg2);

	internal static class SDActionArity2V62
	{
		internal static readonly DActionArity2V62 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V62))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, bool arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKPlayer, bool>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKPlayer>(arg1), arg2);
		}
	}

	internal sealed class NIDActionArity2V62 : TrampolineBlockBase
	{
		private DActionArity2V62 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V62(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V62>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKPlayer, bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKPlayer, bool> action = (Action<GKPlayer, bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKPlayer, bool>(new NIDActionArity2V62((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKPlayer arg1, bool arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKPlayer[], NSError>))]
	internal delegate void DActionArity2V48(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V48
	{
		internal static readonly DActionArity2V48 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V48))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKPlayer[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKPlayer>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V48 : TrampolineBlockBase
	{
		private DActionArity2V48 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V48(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V48>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKPlayer[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKPlayer[], NSError> action = (Action<GKPlayer[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKPlayer[], NSError>(new NIDActionArity2V48((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKPlayer[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKSavedGame, NSError>))]
	internal delegate void DActionArity2V56(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V56
	{
		internal static readonly DActionArity2V56 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V56))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKSavedGame, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKSavedGame>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V56 : TrampolineBlockBase
	{
		private DActionArity2V56 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V56(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V56>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKSavedGame, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKSavedGame, NSError> action = (Action<GKSavedGame, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKSavedGame, NSError>(new NIDActionArity2V56((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKSavedGame arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKSavedGame[], NSError>))]
	internal delegate void DActionArity2V54(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V54
	{
		internal static readonly DActionArity2V54 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V54))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKSavedGame[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<GKSavedGame>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V54 : TrampolineBlockBase
	{
		private DActionArity2V54 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V54(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V54>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKSavedGame[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKSavedGame[], NSError> action = (Action<GKSavedGame[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKSavedGame[], NSError>(new NIDActionArity2V54((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKSavedGame[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKTurnBasedExchange, NSError>))]
	internal delegate void DActionArity2V64(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V64
	{
		internal static readonly DActionArity2V64 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V64))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKTurnBasedExchange, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKTurnBasedExchange>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V64 : TrampolineBlockBase
	{
		private DActionArity2V64 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V64(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V64>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKTurnBasedExchange, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKTurnBasedExchange, NSError> action = (Action<GKTurnBasedExchange, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKTurnBasedExchange, NSError>(new NIDActionArity2V64((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKTurnBasedExchange arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<GKTurnBasedMatch, NSError>))]
	internal delegate void DActionArity2V63(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V63
	{
		internal static readonly DActionArity2V63 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V63))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<GKTurnBasedMatch, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<GKTurnBasedMatch>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V63 : TrampolineBlockBase
	{
		private DActionArity2V63 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V63(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V63>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<GKTurnBasedMatch, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<GKTurnBasedMatch, NSError> action = (Action<GKTurnBasedMatch, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<GKTurnBasedMatch, NSError>(new NIDActionArity2V63((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(GKTurnBasedMatch arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<LPLinkMetadata, NSError>))]
	internal delegate void DActionArity2V66(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V66
	{
		internal static readonly DActionArity2V66 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V66))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<LPLinkMetadata, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<LPLinkMetadata>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V66 : TrampolineBlockBase
	{
		private DActionArity2V66 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V66(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V66>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<LPLinkMetadata, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<LPLinkMetadata, NSError> action = (Action<LPLinkMetadata, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<LPLinkMetadata, NSError>(new NIDActionArity2V66((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(LPLinkMetadata arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLComputePipelineState, NSError>))]
	internal delegate void DActionArity2V69(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V69
	{
		internal static readonly DActionArity2V69 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V69))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLComputePipelineState, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLComputePipelineState>(arg1, owns: false), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V69 : TrampolineBlockBase
	{
		private DActionArity2V69 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V69(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V69>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLComputePipelineState, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLComputePipelineState, NSError> action = (Action<IMTLComputePipelineState, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLComputePipelineState, NSError>(new NIDActionArity2V69((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLComputePipelineState arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLFunction, NSError>))]
	internal delegate void DActionArity2V70(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V70
	{
		internal static readonly DActionArity2V70 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V70))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLFunction, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLFunction>(arg1, owns: false), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V70 : TrampolineBlockBase
	{
		private DActionArity2V70 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V70(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V70>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLFunction, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLFunction, NSError> action = (Action<IMTLFunction, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLFunction, NSError>(new NIDActionArity2V70((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLFunction arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLLibrary, NSError>))]
	internal delegate void DActionArity2V67(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V67
	{
		internal static readonly DActionArity2V67 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V67))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLLibrary, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLLibrary>(arg1, owns: false), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V67 : TrampolineBlockBase
	{
		private DActionArity2V67 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V67(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V67>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLLibrary, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLLibrary, NSError> action = (Action<IMTLLibrary, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLLibrary, NSError>(new NIDActionArity2V67((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLLibrary arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLRenderPipelineState, NSError>))]
	internal delegate void DActionArity2V68(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V68
	{
		internal static readonly DActionArity2V68 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V68))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLRenderPipelineState, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLRenderPipelineState>(arg1, owns: false), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V68 : TrampolineBlockBase
	{
		private DActionArity2V68 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V68(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V68>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLRenderPipelineState, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLRenderPipelineState, NSError> action = (Action<IMTLRenderPipelineState, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLRenderPipelineState, NSError>(new NIDActionArity2V68((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLRenderPipelineState arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<MPSImage, NSError>))]
	internal delegate void DActionArity2V71(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V71
	{
		internal static readonly DActionArity2V71 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V71))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<MPSImage, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<MPSImage>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V71 : TrampolineBlockBase
	{
		private DActionArity2V71 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V71(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V71>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<MPSImage, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<MPSImage, NSError> action = (Action<MPSImage, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<MPSImage, NSError>(new NIDActionArity2V71((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(MPSImage arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NLTaggerAssetsResult, NSError>))]
	internal delegate void DActionArity2V72(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V72
	{
		internal static readonly DActionArity2V72 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V72))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NLTaggerAssetsResult, NSError>)ptr->Target)?.Invoke((NLTaggerAssetsResult)(long)arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V72 : TrampolineBlockBase
	{
		private DActionArity2V72 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V72(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V72>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NLTaggerAssetsResult, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NLTaggerAssetsResult, NSError> action = (Action<NLTaggerAssetsResult, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NLTaggerAssetsResult, NSError>(new NIDActionArity2V72((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NLTaggerAssetsResult arg1, NSError arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NETransparentProxyManager[], NSError>))]
	internal delegate void DActionArity2V75(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V75
	{
		internal static readonly DActionArity2V75 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V75))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NETransparentProxyManager[], NSError>)ptr->Target)?.Invoke(NSArray.ArrayFromHandle<NETransparentProxyManager>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V75 : TrampolineBlockBase
	{
		private DActionArity2V75 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V75(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V75>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NETransparentProxyManager[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NETransparentProxyManager[], NSError> action = (Action<NETransparentProxyManager[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NETransparentProxyManager[], NSError>(new NIDActionArity2V75((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NETransparentProxyManager[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromNSObjects(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<PHLivePhoto, NSDictionary>))]
	internal delegate void DActionArity2V77(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V77
	{
		internal static readonly DActionArity2V77 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V77))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<PHLivePhoto, NSDictionary>)ptr->Target)?.Invoke(Runtime.GetNSObject<PHLivePhoto>(arg1), Runtime.GetNSObject<NSDictionary>(arg2));
		}
	}

	internal sealed class NIDActionArity2V77 : TrampolineBlockBase
	{
		private DActionArity2V77 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V77(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V77>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<PHLivePhoto, NSDictionary>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<PHLivePhoto, NSDictionary> action = (Action<PHLivePhoto, NSDictionary>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<PHLivePhoto, NSDictionary>(new NIDActionArity2V77((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHLivePhoto arg1, NSDictionary arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<PHLivePhoto, NSError>))]
	internal delegate void DActionArity2V78(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V78
	{
		internal static readonly DActionArity2V78 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V78))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<PHLivePhoto, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<PHLivePhoto>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V78 : TrampolineBlockBase
	{
		private DActionArity2V78 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V78(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V78>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<PHLivePhoto, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<PHLivePhoto, NSError> action = (Action<PHLivePhoto, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<PHLivePhoto, NSError>(new NIDActionArity2V78((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(PHLivePhoto arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<QLThumbnailReply, NSError>))]
	internal delegate void DActionArity2V80(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V80
	{
		internal static readonly DActionArity2V80 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V80))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<QLThumbnailReply, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<QLThumbnailReply>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V80 : TrampolineBlockBase
	{
		private DActionArity2V80 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V80(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V80>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<QLThumbnailReply, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<QLThumbnailReply, NSError> action = (Action<QLThumbnailReply, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<QLThumbnailReply, NSError>(new NIDActionArity2V80((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(QLThumbnailReply arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<QLThumbnailRepresentation, NSError>))]
	internal delegate void DActionArity2V79(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V79
	{
		internal static readonly DActionArity2V79 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V79))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<QLThumbnailRepresentation, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<QLThumbnailRepresentation>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V79 : TrampolineBlockBase
	{
		private DActionArity2V79 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V79(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V79>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<QLThumbnailRepresentation, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<QLThumbnailRepresentation, NSError> action = (Action<QLThumbnailRepresentation, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<QLThumbnailRepresentation, NSError>(new NIDActionArity2V79((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(QLThumbnailRepresentation arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFContentBlockerState, NSError>))]
	internal delegate void DActionArity2V81(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V81
	{
		internal static readonly DActionArity2V81 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V81))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFContentBlockerState, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFContentBlockerState>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V81 : TrampolineBlockBase
	{
		private DActionArity2V81 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V81(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V81>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFContentBlockerState, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFContentBlockerState, NSError> action = (Action<SFContentBlockerState, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFContentBlockerState, NSError>(new NIDActionArity2V81((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFContentBlockerState arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SecIdentity, NSArray>))]
	internal delegate void DActionArity2V76(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V76
	{
		internal static readonly DActionArity2V76 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V76))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SecIdentity, NSArray>)ptr->Target)?.Invoke(new SecIdentity(arg1), Runtime.GetNSObject<NSArray>(arg2));
		}
	}

	internal sealed class NIDActionArity2V76 : TrampolineBlockBase
	{
		private DActionArity2V76 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V76(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V76>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SecIdentity, NSArray>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SecIdentity, NSArray> action = (Action<SecIdentity, NSArray>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SecIdentity, NSArray>(new NIDActionArity2V76((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SecIdentity arg1, NSArray arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<SFSpeechRecognitionResult, NSError>))]
	internal delegate void DActionArity2V83(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V83
	{
		internal static readonly DActionArity2V83 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V83))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<SFSpeechRecognitionResult, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<SFSpeechRecognitionResult>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V83 : TrampolineBlockBase
	{
		private DActionArity2V83 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V83(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V83>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<SFSpeechRecognitionResult, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<SFSpeechRecognitionResult, NSError> action = (Action<SFSpeechRecognitionResult, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<SFSpeechRecognitionResult, NSError>(new NIDActionArity2V83((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SFSpeechRecognitionResult arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<bool, NSError>))]
	internal delegate void DActionArity2V4(IntPtr block, bool arg1, IntPtr arg2);

	internal static class SDActionArity2V4
	{
		internal static readonly DActionArity2V4 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V4))]
		private unsafe static void Invoke(IntPtr block, bool arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<bool, NSError>)ptr->Target)?.Invoke(arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V4 : TrampolineBlockBase
	{
		private DActionArity2V4 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V4(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V4>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<bool, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<bool, NSError> action = (Action<bool, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<bool, NSError>(new NIDActionArity2V4((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<bool, NSString>))]
	internal delegate void DActionArity2V82(IntPtr block, bool arg1, IntPtr arg2);

	internal static class SDActionArity2V82
	{
		internal static readonly DActionArity2V82 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V82))]
		private unsafe static void Invoke(IntPtr block, bool arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<bool, NSString>)ptr->Target)?.Invoke(arg1, Runtime.GetNSObject<NSString>(arg2));
		}
	}

	internal sealed class NIDActionArity2V82 : TrampolineBlockBase
	{
		private DActionArity2V82 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V82(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V82>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<bool, NSString>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<bool, NSString> action = (Action<bool, NSString>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<bool, NSString>(new NIDActionArity2V82((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool arg1, NSString arg2)
		{
			invoker(base.BlockPointer, arg1, (arg2 == null) ? IntPtr.Zero : arg2.Handle);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<long, NSError>))]
	internal delegate void DActionArity2V1(IntPtr block, long arg1, IntPtr arg2);

	internal static class SDActionArity2V1
	{
		internal static readonly DActionArity2V1 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V1))]
		private unsafe static void Invoke(IntPtr block, long arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<long, NSError>)ptr->Target)?.Invoke(arg1, Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V1 : TrampolineBlockBase
	{
		private DActionArity2V1 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V1(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V1>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<long, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<long, NSError> action = (Action<long, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<long, NSError>(new NIDActionArity2V1((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(long arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IntPtr, nuint>))]
	internal delegate void DActionArity2V40(IntPtr block, IntPtr arg1, nuint arg2);

	internal static class SDActionArity2V40
	{
		internal static readonly DActionArity2V40 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V40))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, nuint arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IntPtr, nuint>)ptr->Target)?.Invoke(arg1, arg2);
		}
	}

	internal sealed class NIDActionArity2V40 : TrampolineBlockBase
	{
		private DActionArity2V40 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V40(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V40>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IntPtr, nuint>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IntPtr, nuint> action = (Action<IntPtr, nuint>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IntPtr, nuint>(new NIDActionArity2V40((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr arg1, nuint arg2)
		{
			invoker(base.BlockPointer, arg1, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<string, NSError>))]
	internal delegate void DActionArity2V55(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V55
	{
		internal static readonly DActionArity2V55 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V55))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<string, NSError>)ptr->Target)?.Invoke(NSString.FromHandle(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V55 : TrampolineBlockBase
	{
		private DActionArity2V55 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V55(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V55>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<string, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<string, NSError> action = (Action<string, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<string, NSError>(new NIDActionArity2V55((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string arg1, NSError arg2)
		{
			IntPtr intPtr = NSString.CreateNative(arg1);
			invoker(base.BlockPointer, intPtr, arg2?.Handle ?? IntPtr.Zero);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<string, GKInviteeResponse>))]
	internal delegate void DActionArity2V59(IntPtr block, IntPtr arg1, nint arg2);

	internal static class SDActionArity2V59
	{
		internal static readonly DActionArity2V59 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V59))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, nint arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<string, GKInviteeResponse>)ptr->Target)?.Invoke(NSString.FromHandle(arg1), (GKInviteeResponse)(long)arg2);
		}
	}

	internal sealed class NIDActionArity2V59 : TrampolineBlockBase
	{
		private DActionArity2V59 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V59(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V59>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<string, GKInviteeResponse>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<string, GKInviteeResponse> action = (Action<string, GKInviteeResponse>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<string, GKInviteeResponse>(new NIDActionArity2V59((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string arg1, GKInviteeResponse arg2)
		{
			IntPtr intPtr = NSString.CreateNative(arg1);
			invoker(base.BlockPointer, intPtr, (nint)(long)arg2);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<string, bool>))]
	internal delegate void DActionArity2V61(IntPtr block, IntPtr arg1, bool arg2);

	internal static class SDActionArity2V61
	{
		internal static readonly DActionArity2V61 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V61))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, bool arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<string, bool>)ptr->Target)?.Invoke(NSString.FromHandle(arg1), arg2);
		}
	}

	internal sealed class NIDActionArity2V61 : TrampolineBlockBase
	{
		private DActionArity2V61 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V61(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V61>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<string, bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<string, bool> action = (Action<string, bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<string, bool>(new NIDActionArity2V61((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string arg1, bool arg2)
		{
			IntPtr intPtr = NSString.CreateNative(arg1);
			invoker(base.BlockPointer, intPtr, arg2);
			NSString.ReleaseNative(intPtr);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<string[], NSError>))]
	internal delegate void DActionArity2V47(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V47
	{
		internal static readonly DActionArity2V47 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V47))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<string[], NSError>)ptr->Target)?.Invoke(NSArray.StringArrayFromHandle(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V47 : TrampolineBlockBase
	{
		private DActionArity2V47 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V47(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V47>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<string[], NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<string[], NSError> action = (Action<string[], NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<string[], NSError>(new NIDActionArity2V47((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(string[] arg1, NSError arg2)
		{
			NSArray nSArray = ((arg1 == null) ? null : NSArray.FromStrings(arg1));
			invoker(base.BlockPointer, nSArray?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<nint, NSTextCheckingResult[]>))]
	internal delegate void DActionArity2V7(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V7
	{
		internal static readonly DActionArity2V7 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V7))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<nint, NSTextCheckingResult[]>)ptr->Target)?.Invoke(arg1, NSArray.ArrayFromHandle<NSTextCheckingResult>(arg2));
		}
	}

	internal sealed class NIDActionArity2V7 : TrampolineBlockBase
	{
		private DActionArity2V7 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V7(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V7>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<nint, NSTextCheckingResult[]>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<nint, NSTextCheckingResult[]> action = (Action<nint, NSTextCheckingResult[]>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<nint, NSTextCheckingResult[]>(new NIDActionArity2V7((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint arg1, NSTextCheckingResult[] arg2)
		{
			NSArray nSArray = ((arg2 == null) ? null : NSArray.FromNSObjects(arg2));
			invoker(base.BlockPointer, arg1, nSArray?.Handle ?? IntPtr.Zero);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<WKContentRuleList, NSError>))]
	internal delegate void DActionArity2V84(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDActionArity2V84
	{
		internal static readonly DActionArity2V84 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V84))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<WKContentRuleList, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<WKContentRuleList>(arg1), Runtime.GetNSObject<NSError>(arg2));
		}
	}

	internal sealed class NIDActionArity2V84 : TrampolineBlockBase
	{
		private DActionArity2V84 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V84(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V84>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<WKContentRuleList, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<WKContentRuleList, NSError> action = (Action<WKContentRuleList, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<WKContentRuleList, NSError>(new NIDActionArity2V84((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(WKContentRuleList arg1, NSError arg2)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<WKNavigationActionPolicy, WKWebpagePreferences>))]
	internal delegate void DActionArity2V85(IntPtr block, nint arg1, IntPtr arg2);

	internal static class SDActionArity2V85
	{
		internal static readonly DActionArity2V85 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity2V85))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<WKNavigationActionPolicy, WKWebpagePreferences>)ptr->Target)?.Invoke((WKNavigationActionPolicy)(long)arg1, Runtime.GetNSObject<WKWebpagePreferences>(arg2));
		}
	}

	internal sealed class NIDActionArity2V85 : TrampolineBlockBase
	{
		private DActionArity2V85 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity2V85(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity2V85>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<WKNavigationActionPolicy, WKWebpagePreferences>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<WKNavigationActionPolicy, WKWebpagePreferences> action = (Action<WKNavigationActionPolicy, WKWebpagePreferences>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<WKNavigationActionPolicy, WKWebpagePreferences>(new NIDActionArity2V85((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(WKNavigationActionPolicy arg1, WKWebpagePreferences arg2)
		{
			invoker(base.BlockPointer, (nint)(long)arg1, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<CKRecord, CKRecordID, NSError>))]
	internal delegate void DActionArity3V0(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	internal static class SDActionArity3V0
	{
		internal static readonly DActionArity3V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V0))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<CKRecord, CKRecordID, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<CKRecord>(arg1), Runtime.GetNSObject<CKRecordID>(arg2), Runtime.GetNSObject<NSError>(arg3));
		}
	}

	internal sealed class NIDActionArity3V0 : TrampolineBlockBase
	{
		private DActionArity3V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<CKRecord, CKRecordID, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<CKRecord, CKRecordID, NSError> action = (Action<CKRecord, CKRecordID, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<CKRecord, CKRecordID, NSError>(new NIDActionArity3V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKRecord arg1, CKRecordID arg2, NSError arg3)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero, arg3?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSData, NSHttpUrlResponse, NSError>))]
	internal delegate void DActionArity3V6(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	internal static class SDActionArity3V6
	{
		internal static readonly DActionArity3V6 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V6))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSData, NSHttpUrlResponse, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(arg1), Runtime.GetNSObject<NSHttpUrlResponse>(arg2), Runtime.GetNSObject<NSError>(arg3));
		}
	}

	internal sealed class NIDActionArity3V6 : TrampolineBlockBase
	{
		private DActionArity3V6 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V6(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V6>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSData, NSHttpUrlResponse, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSData, NSHttpUrlResponse, NSError> action = (Action<NSData, NSHttpUrlResponse, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSData, NSHttpUrlResponse, NSError>(new NIDActionArity3V6((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData arg1, NSHttpUrlResponse arg2, NSError arg3)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero, arg3?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<NSInputStream, NSOutputStream, NSError>))]
	internal delegate void DActionArity3V1(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	internal static class SDActionArity3V1
	{
		internal static readonly DActionArity3V1 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V1))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<NSInputStream, NSOutputStream, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<NSInputStream>(arg1), Runtime.GetNSObject<NSOutputStream>(arg2), Runtime.GetNSObject<NSError>(arg3));
		}
	}

	internal sealed class NIDActionArity3V1 : TrampolineBlockBase
	{
		private DActionArity3V1 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V1(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V1>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<NSInputStream, NSOutputStream, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<NSInputStream, NSOutputStream, NSError> action = (Action<NSInputStream, NSOutputStream, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<NSInputStream, NSOutputStream, NSError>(new NIDActionArity3V1((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSInputStream arg1, NSOutputStream arg2, NSError arg3)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero, arg3?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError>))]
	internal delegate void DActionArity3V3(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	internal static class SDActionArity3V3
	{
		internal static readonly DActionArity3V3 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V3))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLComputePipelineState>(arg1, owns: false), Runtime.GetNSObject<MTLComputePipelineReflection>(arg2), Runtime.GetNSObject<NSError>(arg3));
		}
	}

	internal sealed class NIDActionArity3V3 : TrampolineBlockBase
	{
		private DActionArity3V3 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V3(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V3>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError> action = (Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError>(new NIDActionArity3V3((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLComputePipelineState arg1, MTLComputePipelineReflection arg2, NSError arg3)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero, arg3?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError>))]
	internal delegate void DActionArity3V2(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3);

	internal static class SDActionArity3V2
	{
		internal static readonly DActionArity3V2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V2))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError>)ptr->Target)?.Invoke(Runtime.GetINativeObject<IMTLRenderPipelineState>(arg1, owns: false), Runtime.GetNSObject<MTLRenderPipelineReflection>(arg2), Runtime.GetNSObject<NSError>(arg3));
		}
	}

	internal sealed class NIDActionArity3V2 : TrampolineBlockBase
	{
		private DActionArity3V2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError> action = (Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError>(new NIDActionArity3V2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IMTLRenderPipelineState arg1, MTLRenderPipelineReflection arg2, NSError arg3)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero, arg3?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError>))]
	internal delegate void DActionArity3V4(IntPtr block, IntPtr arg1, nint arg2, IntPtr arg3);

	internal static class SDActionArity3V4
	{
		internal static readonly DActionArity3V4 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V4))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, nint arg2, IntPtr arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError>)ptr->Target)?.Invoke(Runtime.GetNSObject<QLThumbnailRepresentation>(arg1), (QLThumbnailRepresentationType)(long)arg2, Runtime.GetNSObject<NSError>(arg3));
		}
	}

	internal sealed class NIDActionArity3V4 : TrampolineBlockBase
	{
		private DActionArity3V4 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V4(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V4>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError> action = (Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError>(new NIDActionArity3V4((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(QLThumbnailRepresentation arg1, QLThumbnailRepresentationType arg2, NSError arg3)
		{
			invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, (nint)(long)arg2, arg3?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<IntPtr, NSObject, bool>))]
	internal delegate void DActionArity3V5(IntPtr block, IntPtr arg1, IntPtr arg2, bool arg3);

	internal static class SDActionArity3V5
	{
		internal static readonly DActionArity3V5 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity3V5))]
		private unsafe static void Invoke(IntPtr block, IntPtr arg1, IntPtr arg2, bool arg3)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<IntPtr, NSObject, bool>)ptr->Target)?.Invoke(arg1, Runtime.GetNSObject<NSObject>(arg2), arg3);
		}
	}

	internal sealed class NIDActionArity3V5 : TrampolineBlockBase
	{
		private DActionArity3V5 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity3V5(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity3V5>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<IntPtr, NSObject, bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<IntPtr, NSObject, bool> action = (Action<IntPtr, NSObject, bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<IntPtr, NSObject, bool>(new NIDActionArity3V5((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(IntPtr arg1, NSObject arg2, bool arg3)
		{
			invoker(base.BlockPointer, arg1, arg2?.Handle ?? IntPtr.Zero, arg3);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Action<nint, NSTextCheckingResult[], NSOrthography, nint>))]
	internal delegate void DActionArity4V0(IntPtr block, nint arg1, IntPtr arg2, IntPtr arg3, nint arg4);

	internal static class SDActionArity4V0
	{
		internal static readonly DActionArity4V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DActionArity4V0))]
		private unsafe static void Invoke(IntPtr block, nint arg1, IntPtr arg2, IntPtr arg3, nint arg4)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((Action<nint, NSTextCheckingResult[], NSOrthography, nint>)ptr->Target)?.Invoke(arg1, NSArray.ArrayFromHandle<NSTextCheckingResult>(arg2), Runtime.GetNSObject<NSOrthography>(arg3), arg4);
		}
	}

	internal sealed class NIDActionArity4V0 : TrampolineBlockBase
	{
		private DActionArity4V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDActionArity4V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DActionArity4V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Action<nint, NSTextCheckingResult[], NSOrthography, nint>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Action<nint, NSTextCheckingResult[], NSOrthography, nint> action = (Action<nint, NSTextCheckingResult[], NSOrthography, nint>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return action ?? new Action<nint, NSTextCheckingResult[], NSOrthography, nint>(new NIDActionArity4V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(nint arg1, NSTextCheckingResult[] arg2, NSOrthography arg3, nint arg4)
		{
			NSArray nSArray = ((arg2 == null) ? null : NSArray.FromNSObjects(arg2));
			invoker(base.BlockPointer, arg1, nSArray?.Handle ?? IntPtr.Zero, arg3?.Handle ?? IntPtr.Zero, arg4);
			nSArray?.Dispose();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<IMTLTexture>))]
	internal delegate IntPtr DFuncArity1V1(IntPtr block);

	internal static class SDFuncArity1V1
	{
		internal static readonly DFuncArity1V1 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity1V1))]
		private unsafe static IntPtr Invoke(IntPtr block)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<IMTLTexture> func = (Func<IMTLTexture>)ptr->Target;
			return func()?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDFuncArity1V1 : TrampolineBlockBase
	{
		private DFuncArity1V1 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity1V1(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity1V1>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<IMTLTexture>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<IMTLTexture> func = (Func<IMTLTexture>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<IMTLTexture>(new NIDFuncArity1V1((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private IMTLTexture Invoke()
		{
			return Runtime.GetINativeObject<IMTLTexture>(invoker(base.BlockPointer), owns: false);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<bool>))]
	internal delegate bool DFuncArity1V0(IntPtr block);

	internal static class SDFuncArity1V0
	{
		internal static readonly DFuncArity1V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity1V0))]
		private unsafe static bool Invoke(IntPtr block)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<bool> func = (Func<bool>)ptr->Target;
			return func();
		}
	}

	internal sealed class NIDFuncArity1V0 : TrampolineBlockBase
	{
		private DFuncArity1V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity1V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity1V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<bool> func = (Func<bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<bool>(new NIDFuncArity1V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke()
		{
			return invoker(base.BlockPointer);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<NSAppearance, NSColor>))]
	internal delegate IntPtr DFuncArity2V0(IntPtr block, IntPtr arg);

	internal static class SDFuncArity2V0
	{
		internal static readonly DFuncArity2V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V0))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<NSAppearance, NSColor> func = (Func<NSAppearance, NSColor>)ptr->Target;
			return func(Runtime.GetNSObject<NSAppearance>(arg))?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDFuncArity2V0 : TrampolineBlockBase
	{
		private DFuncArity2V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<NSAppearance, NSColor>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<NSAppearance, NSColor> func = (Func<NSAppearance, NSColor>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<NSAppearance, NSColor>(new NIDFuncArity2V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSColor Invoke(NSAppearance arg)
		{
			return Runtime.GetNSObject<NSColor>(invoker(base.BlockPointer, arg?.Handle ?? IntPtr.Zero));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<CGContext, bool>))]
	internal delegate bool DFuncArity2V5(IntPtr block, IntPtr arg);

	internal static class SDFuncArity2V5
	{
		internal static readonly DFuncArity2V5 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V5))]
		private unsafe static bool Invoke(IntPtr block, IntPtr arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<CGContext, bool> func = (Func<CGContext, bool>)ptr->Target;
			return func(new CGContext(arg));
		}
	}

	internal sealed class NIDFuncArity2V5 : TrampolineBlockBase
	{
		private DFuncArity2V5 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V5(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V5>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<CGContext, bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<CGContext, bool> func = (Func<CGContext, bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<CGContext, bool>(new NIDFuncArity2V5((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(CGContext arg)
		{
			return invoker(base.BlockPointer, arg?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<CGSize, NSImage>))]
	internal delegate IntPtr DFuncArity2V2(IntPtr block, CGSize arg);

	internal static class SDFuncArity2V2
	{
		internal static readonly DFuncArity2V2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V2))]
		private unsafe static IntPtr Invoke(IntPtr block, CGSize arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<CGSize, NSImage> func = (Func<CGSize, NSImage>)ptr->Target;
			return func(arg)?.Handle ?? IntPtr.Zero;
		}
	}

	internal sealed class NIDFuncArity2V2 : TrampolineBlockBase
	{
		private DFuncArity2V2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<CGSize, NSImage>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<CGSize, NSImage> func = (Func<CGSize, NSImage>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<CGSize, NSImage>(new NIDFuncArity2V2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSImage Invoke(CGSize arg)
		{
			return Runtime.GetNSObject<NSImage>(invoker(base.BlockPointer, arg));
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<GKRuleSystem, bool>))]
	internal delegate bool DFuncArity2V1(IntPtr block, IntPtr arg);

	internal static class SDFuncArity2V1
	{
		internal static readonly DFuncArity2V1 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V1))]
		private unsafe static bool Invoke(IntPtr block, IntPtr arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<GKRuleSystem, bool> func = (Func<GKRuleSystem, bool>)ptr->Target;
			return func(Runtime.GetNSObject<GKRuleSystem>(arg));
		}
	}

	internal sealed class NIDFuncArity2V1 : TrampolineBlockBase
	{
		private DFuncArity2V1 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V1(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V1>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<GKRuleSystem, bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<GKRuleSystem, bool> func = (Func<GKRuleSystem, bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<GKRuleSystem, bool>(new NIDFuncArity2V1((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(GKRuleSystem arg)
		{
			return invoker(base.BlockPointer, arg?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus>))]
	internal delegate IntPtr DFuncArity2V3(IntPtr block, IntPtr arg);

	internal static class SDFuncArity2V3
	{
		internal static readonly DFuncArity2V3 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V3))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus> func = (Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus>)ptr->Target;
			MPRemoteCommandHandlerStatus mPRemoteCommandHandlerStatus = func(Runtime.GetNSObject<MPRemoteCommandEvent>(arg));
			return (IntPtr)(long)mPRemoteCommandHandlerStatus;
		}
	}

	internal sealed class NIDFuncArity2V3 : TrampolineBlockBase
	{
		private DFuncArity2V3 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V3(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V3>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus> func = (Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<MPRemoteCommandEvent, MPRemoteCommandHandlerStatus>(new NIDFuncArity2V3((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private MPRemoteCommandHandlerStatus Invoke(MPRemoteCommandEvent arg)
		{
			return (MPRemoteCommandHandlerStatus)(long)invoker(base.BlockPointer, arg?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<PHAdjustmentData, bool>))]
	internal delegate bool DFuncArity2V4(IntPtr block, IntPtr arg);

	internal static class SDFuncArity2V4
	{
		internal static readonly DFuncArity2V4 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V4))]
		private unsafe static bool Invoke(IntPtr block, IntPtr arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<PHAdjustmentData, bool> func = (Func<PHAdjustmentData, bool>)ptr->Target;
			return func(Runtime.GetNSObject<PHAdjustmentData>(arg));
		}
	}

	internal sealed class NIDFuncArity2V4 : TrampolineBlockBase
	{
		private DFuncArity2V4 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V4(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V4>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<PHAdjustmentData, bool>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<PHAdjustmentData, bool> func = (Func<PHAdjustmentData, bool>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<PHAdjustmentData, bool>(new NIDFuncArity2V4((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private bool Invoke(PHAdjustmentData arg)
		{
			return invoker(base.BlockPointer, arg?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<float, float>))]
	internal delegate float DFuncArity2V6(IntPtr block, float arg);

	internal static class SDFuncArity2V6
	{
		internal static readonly DFuncArity2V6 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity2V6))]
		private unsafe static float Invoke(IntPtr block, float arg)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<float, float> func = (Func<float, float>)ptr->Target;
			return func(arg);
		}
	}

	internal sealed class NIDFuncArity2V6 : TrampolineBlockBase
	{
		private DFuncArity2V6 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity2V6(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity2V6>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<float, float>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<float, float> func = (Func<float, float>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<float, float>(new NIDFuncArity2V6((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private float Invoke(float arg)
		{
			return invoker(base.BlockPointer, arg);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<NSObject, NSObject, NSComparisonResult>))]
	internal delegate IntPtr DFuncArity3V0(IntPtr block, IntPtr arg1, IntPtr arg2);

	internal static class SDFuncArity3V0
	{
		internal static readonly DFuncArity3V0 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity3V0))]
		private unsafe static IntPtr Invoke(IntPtr block, IntPtr arg1, IntPtr arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<NSObject, NSObject, NSComparisonResult> func = (Func<NSObject, NSObject, NSComparisonResult>)ptr->Target;
			NSComparisonResult nSComparisonResult = func(Runtime.GetNSObject<NSObject>(arg1), Runtime.GetNSObject<NSObject>(arg2));
			return (IntPtr)(long)nSComparisonResult;
		}
	}

	internal sealed class NIDFuncArity3V0 : TrampolineBlockBase
	{
		private DFuncArity3V0 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity3V0(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity3V0>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<NSObject, NSObject, NSComparisonResult>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<NSObject, NSObject, NSComparisonResult> func = (Func<NSObject, NSObject, NSComparisonResult>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<NSObject, NSObject, NSComparisonResult>(new NIDFuncArity3V0((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private NSComparisonResult Invoke(NSObject arg1, NSObject arg2)
		{
			return (NSComparisonResult)(long)invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<SCNNode, SCNQuaternion, SCNQuaternion>))]
	internal delegate SCNQuaternion DFuncArity3V1(IntPtr block, IntPtr arg1, SCNQuaternion arg2);

	internal static class SDFuncArity3V1
	{
		internal static readonly DFuncArity3V1 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity3V1))]
		private unsafe static SCNQuaternion Invoke(IntPtr block, IntPtr arg1, SCNQuaternion arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<SCNNode, SCNQuaternion, SCNQuaternion> func = (Func<SCNNode, SCNQuaternion, SCNQuaternion>)ptr->Target;
			return func(Runtime.GetNSObject<SCNNode>(arg1), arg2);
		}
	}

	internal sealed class NIDFuncArity3V1 : TrampolineBlockBase
	{
		private DFuncArity3V1 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity3V1(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity3V1>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<SCNNode, SCNQuaternion, SCNQuaternion>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<SCNNode, SCNQuaternion, SCNQuaternion> func = (Func<SCNNode, SCNQuaternion, SCNQuaternion>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<SCNNode, SCNQuaternion, SCNQuaternion>(new NIDFuncArity3V1((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private SCNQuaternion Invoke(SCNNode arg1, SCNQuaternion arg2)
		{
			return invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(Func<SCNNode, SCNVector3, SCNVector3>))]
	internal delegate SCNVector3 DFuncArity3V2(IntPtr block, IntPtr arg1, SCNVector3 arg2);

	internal static class SDFuncArity3V2
	{
		internal static readonly DFuncArity3V2 Handler = Invoke;

		[MonoPInvokeCallback(typeof(DFuncArity3V2))]
		private unsafe static SCNVector3 Invoke(IntPtr block, IntPtr arg1, SCNVector3 arg2)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			Func<SCNNode, SCNVector3, SCNVector3> func = (Func<SCNNode, SCNVector3, SCNVector3>)ptr->Target;
			return func(Runtime.GetNSObject<SCNNode>(arg1), arg2);
		}
	}

	internal sealed class NIDFuncArity3V2 : TrampolineBlockBase
	{
		private DFuncArity3V2 invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDFuncArity3V2(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DFuncArity3V2>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Func<SCNNode, SCNVector3, SCNVector3>? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			Func<SCNNode, SCNVector3, SCNVector3> func = (Func<SCNNode, SCNVector3, SCNVector3>)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return func ?? new Func<SCNNode, SCNVector3, SCNVector3>(new NIDFuncArity3V2((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private SCNVector3 Invoke(SCNNode arg1, SCNVector3 arg2)
		{
			return invoker(base.BlockPointer, arg1?.Handle ?? IntPtr.Zero, arg2);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(VNRequestCompletionHandler))]
	internal delegate void DVNRequestCompletionHandler(IntPtr block, IntPtr request, IntPtr error);

	internal static class SDVNRequestCompletionHandler
	{
		internal static readonly DVNRequestCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DVNRequestCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr request, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((VNRequestCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<VNRequest>(request), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDVNRequestCompletionHandler : TrampolineBlockBase
	{
		private DVNRequestCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDVNRequestCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DVNRequestCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static VNRequestCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			VNRequestCompletionHandler vNRequestCompletionHandler = (VNRequestCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return vNRequestCompletionHandler ?? new VNRequestCompletionHandler(new NIDVNRequestCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(VNRequest request, NSError error)
		{
			invoker(base.BlockPointer, request?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(VNRequestProgressHandler))]
	internal delegate void DVNRequestProgressHandler(IntPtr block, IntPtr request, double fractionCompleted, IntPtr error);

	internal static class SDVNRequestProgressHandler
	{
		internal static readonly DVNRequestProgressHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DVNRequestProgressHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr request, double fractionCompleted, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((VNRequestProgressHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<VNRequest>(request), fractionCompleted, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDVNRequestProgressHandler : TrampolineBlockBase
	{
		private DVNRequestProgressHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDVNRequestProgressHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DVNRequestProgressHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static VNRequestProgressHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			VNRequestProgressHandler vNRequestProgressHandler = (VNRequestProgressHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return vNRequestProgressHandler ?? new VNRequestProgressHandler(new NIDVNRequestProgressHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(VNRequest request, double fractionCompleted, NSError? error)
		{
			invoker(base.BlockPointer, request?.Handle ?? IntPtr.Zero, fractionCompleted, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(WKJavascriptEvaluationResult))]
	internal delegate void DWKJavascriptEvaluationResult(IntPtr block, IntPtr result, IntPtr error);

	internal static class SDWKJavascriptEvaluationResult
	{
		internal static readonly DWKJavascriptEvaluationResult Handler = Invoke;

		[MonoPInvokeCallback(typeof(DWKJavascriptEvaluationResult))]
		private unsafe static void Invoke(IntPtr block, IntPtr result, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((WKJavascriptEvaluationResult)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(result), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDWKJavascriptEvaluationResult : TrampolineBlockBase
	{
		private DWKJavascriptEvaluationResult invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDWKJavascriptEvaluationResult(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DWKJavascriptEvaluationResult>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static WKJavascriptEvaluationResult? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			WKJavascriptEvaluationResult wKJavascriptEvaluationResult = (WKJavascriptEvaluationResult)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return wKJavascriptEvaluationResult ?? new WKJavascriptEvaluationResult(new NIDWKJavascriptEvaluationResult((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject result, NSError error)
		{
			invoker(base.BlockPointer, result?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ITLibMediaEntityEnumerateValuesHandler))]
	internal delegate void DITLibMediaEntityEnumerateValuesHandler(IntPtr block, IntPtr property, IntPtr value, [MarshalAs(UnmanagedType.I1)] out bool stop);

	internal static class SDITLibMediaEntityEnumerateValuesHandler
	{
		internal static readonly DITLibMediaEntityEnumerateValuesHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DITLibMediaEntityEnumerateValuesHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr property, IntPtr value, [MarshalAs(UnmanagedType.I1)] out bool stop)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			ITLibMediaEntityEnumerateValuesHandler iTLibMediaEntityEnumerateValuesHandler = (ITLibMediaEntityEnumerateValuesHandler)ptr->Target;
			if (iTLibMediaEntityEnumerateValuesHandler != null)
			{
				iTLibMediaEntityEnumerateValuesHandler(Runtime.GetNSObject<NSString>(property), Runtime.GetNSObject<NSObject>(value), out stop);
			}
			else
			{
				stop = false;
			}
		}
	}

	internal sealed class NIDITLibMediaEntityEnumerateValuesHandler : TrampolineBlockBase
	{
		private DITLibMediaEntityEnumerateValuesHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDITLibMediaEntityEnumerateValuesHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DITLibMediaEntityEnumerateValuesHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ITLibMediaEntityEnumerateValuesHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ITLibMediaEntityEnumerateValuesHandler iTLibMediaEntityEnumerateValuesHandler = (ITLibMediaEntityEnumerateValuesHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return iTLibMediaEntityEnumerateValuesHandler ?? new ITLibMediaEntityEnumerateValuesHandler(new NIDITLibMediaEntityEnumerateValuesHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSString property, NSObject value, out bool stop)
		{
			invoker(base.BlockPointer, (property == null) ? IntPtr.Zero : property.Handle, value?.Handle ?? IntPtr.Zero, out stop);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(CloudKitRegistrationPreparationHandler))]
	internal delegate void DCloudKitRegistrationPreparationHandler(IntPtr block, IntPtr share, IntPtr container, IntPtr error);

	internal static class SDCloudKitRegistrationPreparationHandler
	{
		internal static readonly DCloudKitRegistrationPreparationHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DCloudKitRegistrationPreparationHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr share, IntPtr container, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((CloudKitRegistrationPreparationHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<CKShare>(share), Runtime.GetNSObject<CKContainer>(container), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDCloudKitRegistrationPreparationHandler : TrampolineBlockBase
	{
		private DCloudKitRegistrationPreparationHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDCloudKitRegistrationPreparationHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DCloudKitRegistrationPreparationHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static CloudKitRegistrationPreparationHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			CloudKitRegistrationPreparationHandler cloudKitRegistrationPreparationHandler = (CloudKitRegistrationPreparationHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return cloudKitRegistrationPreparationHandler ?? new CloudKitRegistrationPreparationHandler(new NIDCloudKitRegistrationPreparationHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(CKShare share, CKContainer container, NSError error)
		{
			invoker(base.BlockPointer, share?.Handle ?? IntPtr.Zero, container?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(ItemProviderDataCompletionHandler))]
	internal delegate void DItemProviderDataCompletionHandler(IntPtr block, IntPtr data, IntPtr error);

	internal static class SDItemProviderDataCompletionHandler
	{
		internal static readonly DItemProviderDataCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DItemProviderDataCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr data, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((ItemProviderDataCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSData>(data), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDItemProviderDataCompletionHandler : TrampolineBlockBase
	{
		private DItemProviderDataCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDItemProviderDataCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DItemProviderDataCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static ItemProviderDataCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			ItemProviderDataCompletionHandler itemProviderDataCompletionHandler = (ItemProviderDataCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return itemProviderDataCompletionHandler ?? new ItemProviderDataCompletionHandler(new NIDItemProviderDataCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSData data, NSError error)
		{
			invoker(base.BlockPointer, data?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSBackgroundActivityCompletionHandler))]
	internal delegate void DNSBackgroundActivityCompletionHandler(IntPtr block, nint result);

	internal static class SDNSBackgroundActivityCompletionHandler
	{
		internal static readonly DNSBackgroundActivityCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSBackgroundActivityCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, nint result)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSBackgroundActivityCompletionHandler)ptr->Target)?.Invoke((NSBackgroundActivityResult)(long)result);
		}
	}

	internal sealed class NIDNSBackgroundActivityCompletionHandler : TrampolineBlockBase
	{
		private DNSBackgroundActivityCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSBackgroundActivityCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSBackgroundActivityCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSBackgroundActivityCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSBackgroundActivityCompletionHandler nSBackgroundActivityCompletionHandler = (NSBackgroundActivityCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSBackgroundActivityCompletionHandler ?? new NSBackgroundActivityCompletionHandler(new NIDNSBackgroundActivityCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSBackgroundActivityResult result)
		{
			invoker(base.BlockPointer, (nint)(long)result);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(NSItemProviderCompletionHandler))]
	internal delegate void DNSItemProviderCompletionHandler(IntPtr block, IntPtr itemBeingLoaded, IntPtr error);

	internal static class SDNSItemProviderCompletionHandler
	{
		internal static readonly DNSItemProviderCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DNSItemProviderCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr itemBeingLoaded, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((NSItemProviderCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSObject>(itemBeingLoaded), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDNSItemProviderCompletionHandler : TrampolineBlockBase
	{
		private DNSItemProviderCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDNSItemProviderCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DNSItemProviderCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSItemProviderCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			NSItemProviderCompletionHandler nSItemProviderCompletionHandler = (NSItemProviderCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return nSItemProviderCompletionHandler ?? new NSItemProviderCompletionHandler(new NIDNSItemProviderCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSObject itemBeingLoaded, NSError error)
		{
			invoker(base.BlockPointer, itemBeingLoaded?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(RegisterFileRepresentationCompletionHandler))]
	internal delegate void DRegisterFileRepresentationCompletionHandler(IntPtr block, IntPtr fileUrl, bool coordinated, IntPtr error);

	internal static class SDRegisterFileRepresentationCompletionHandler
	{
		internal static readonly DRegisterFileRepresentationCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DRegisterFileRepresentationCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr fileUrl, bool coordinated, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((RegisterFileRepresentationCompletionHandler)ptr->Target)?.Invoke(Runtime.GetNSObject<NSUrl>(fileUrl), coordinated, Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDRegisterFileRepresentationCompletionHandler : TrampolineBlockBase
	{
		private DRegisterFileRepresentationCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDRegisterFileRepresentationCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DRegisterFileRepresentationCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static RegisterFileRepresentationCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			RegisterFileRepresentationCompletionHandler registerFileRepresentationCompletionHandler = (RegisterFileRepresentationCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return registerFileRepresentationCompletionHandler ?? new RegisterFileRepresentationCompletionHandler(new NIDRegisterFileRepresentationCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(NSUrl fileUrl, bool coordinated, NSError error)
		{
			invoker(base.BlockPointer, (fileUrl == null) ? IntPtr.Zero : fileUrl.Handle, coordinated, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(RegisterObjectRepresentationCompletionHandler))]
	internal delegate void DRegisterObjectRepresentationCompletionHandler(IntPtr block, IntPtr @object, IntPtr error);

	internal static class SDRegisterObjectRepresentationCompletionHandler
	{
		internal static readonly DRegisterObjectRepresentationCompletionHandler Handler = Invoke;

		[MonoPInvokeCallback(typeof(DRegisterObjectRepresentationCompletionHandler))]
		private unsafe static void Invoke(IntPtr block, IntPtr @object, IntPtr error)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((RegisterObjectRepresentationCompletionHandler)ptr->Target)?.Invoke(Runtime.GetINativeObject<INSItemProviderWriting>(@object, owns: false), Runtime.GetNSObject<NSError>(error));
		}
	}

	internal sealed class NIDRegisterObjectRepresentationCompletionHandler : TrampolineBlockBase
	{
		private DRegisterObjectRepresentationCompletionHandler invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDRegisterObjectRepresentationCompletionHandler(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DRegisterObjectRepresentationCompletionHandler>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static RegisterObjectRepresentationCompletionHandler? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			RegisterObjectRepresentationCompletionHandler registerObjectRepresentationCompletionHandler = (RegisterObjectRepresentationCompletionHandler)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return registerObjectRepresentationCompletionHandler ?? new RegisterObjectRepresentationCompletionHandler(new NIDRegisterObjectRepresentationCompletionHandler((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(INSItemProviderWriting @object, NSError error)
		{
			invoker(base.BlockPointer, @object?.Handle ?? IntPtr.Zero, error?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SecProtocolChallengeComplete))]
	internal delegate void DSecProtocolChallengeComplete(IntPtr block, IntPtr identity);

	internal static class SDSecProtocolChallengeComplete
	{
		internal static readonly DSecProtocolChallengeComplete Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSecProtocolChallengeComplete))]
		private unsafe static void Invoke(IntPtr block, IntPtr identity)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SecProtocolChallengeComplete)ptr->Target)?.Invoke(new SecIdentity2(identity));
		}
	}

	internal sealed class NIDSecProtocolChallengeComplete : TrampolineBlockBase
	{
		private DSecProtocolChallengeComplete invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSecProtocolChallengeComplete(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSecProtocolChallengeComplete>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SecProtocolChallengeComplete? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SecProtocolChallengeComplete secProtocolChallengeComplete = (SecProtocolChallengeComplete)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return secProtocolChallengeComplete ?? new SecProtocolChallengeComplete(new NIDSecProtocolChallengeComplete((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(SecIdentity2 identity)
		{
			invoker(base.BlockPointer, identity?.Handle ?? IntPtr.Zero);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	[UserDelegateType(typeof(SecProtocolVerifyComplete))]
	internal delegate void DSecProtocolVerifyComplete(IntPtr block, bool complete);

	internal static class SDSecProtocolVerifyComplete
	{
		internal static readonly DSecProtocolVerifyComplete Handler = Invoke;

		[MonoPInvokeCallback(typeof(DSecProtocolVerifyComplete))]
		private unsafe static void Invoke(IntPtr block, bool complete)
		{
			BlockLiteral* ptr = (BlockLiteral*)(void*)block;
			((SecProtocolVerifyComplete)ptr->Target)?.Invoke(complete);
		}
	}

	internal sealed class NIDSecProtocolVerifyComplete : TrampolineBlockBase
	{
		private DSecProtocolVerifyComplete invoker;

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NIDSecProtocolVerifyComplete(BlockLiteral* block)
			: base(block)
		{
			invoker = block->GetDelegateForBlock<DSecProtocolVerifyComplete>();
		}

		[Preserve(Conditional = true)]
		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static SecProtocolVerifyComplete? Create(IntPtr block)
		{
			if (block == IntPtr.Zero)
			{
				return null;
			}
			SecProtocolVerifyComplete secProtocolVerifyComplete = (SecProtocolVerifyComplete)TrampolineBlockBase.GetExistingManagedDelegate(block);
			return secProtocolVerifyComplete ?? new SecProtocolVerifyComplete(new NIDSecProtocolVerifyComplete((BlockLiteral*)(void*)block).Invoke);
		}

		[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		private void Invoke(bool complete)
		{
			invoker(base.BlockPointer, complete);
		}
	}
}
