using System;

namespace ObjCRuntime;

[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
internal static class Libraries
{
	public static class System
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/usr/lib/libSystem.dylib", 0);
	}

	public static class LibC
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/usr/lib/libc.dylib", 0);
	}

	public static class CoreMidi
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreMIDI.framework/CoreMIDI", 0);
	}

	public static class AudioToolbox
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", 0);
	}

	public static class AVFoundation
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AVFoundation.framework/AVFoundation", 0);
	}

	public static class AVKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AVKit.framework/AVKit", 0);
	}

	public static class Accounts
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Accounts.framework/Accounts", 0);
	}

	public static class AppKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AppKit.framework/AppKit", 0);
	}

	public static class AudioUnit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AudioUnit.framework/AudioUnit", 0);
	}

	public static class AuthenticationServices
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AuthenticationServices.framework/AuthenticationServices", 0);
	}

	public static class AutomaticAssessmentConfiguration
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/AutomaticAssessmentConfiguration.framework/AutomaticAssessmentConfiguration", 0);
	}

	public static class BusinessChat
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/BusinessChat.framework/BusinessChat", 0);
	}

	public static class CFNetwork
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork", 0);
	}

	public static class CloudKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CloudKit.framework/CloudKit", 0);
	}

	public static class Contacts
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Contacts.framework/Contacts", 0);
	}

	public static class CoreAnimation
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", 0);
	}

	public static class CoreBluetooth
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/IOBluetooth.framework/Versions/A/Frameworks/CoreBluetooth.framework/CoreBluetooth", 0);
	}

	public static class CoreData
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreData.framework/CoreData", 0);
	}

	public static class CoreFoundation
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", 0);
	}

	public static class CoreGraphics
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", 0);
	}

	public static class CoreImage
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/Versions/A/Frameworks/CoreImage.framework/CoreImage", 0);
	}

	public static class CoreLocation
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreLocation.framework/CoreLocation", 0);
	}

	public static class CoreML
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreML.framework/CoreML", 0);
	}

	public static class CoreMedia
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreMedia.framework/CoreMedia", 0);
	}

	public static class CoreMotion
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreMotion.framework/CoreMotion", 0);
	}

	public static class CoreServices
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreServices.framework/CoreServices", 0);
	}

	public static class CoreSpotlight
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreSpotlight.framework/CoreSpotlight", 0);
	}

	public static class CoreText
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
	}

	public static class CoreVideo
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", 0);
	}

	public static class CoreWlan
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreWLAN.framework/CoreWLAN", 0);
	}

	public static class DeviceCheck
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/DeviceCheck.framework/DeviceCheck", 0);
	}

	public static class EventKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/EventKit.framework/EventKit", 0);
	}

	public static class ExecutionPolicy
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ExecutionPolicy.framework/ExecutionPolicy", 0);
	}

	public static class ExternalAccessory
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ExternalAccessory.framework/ExternalAccessory", 0);
	}

	public static class FileProviderUI
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/FileProviderUI.framework/FileProviderUI", 0);
	}

	public static class Foundation
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Foundation.framework/Foundation", 0);
	}

	public static class GLKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/GLKit.framework/GLKit", 0);
	}

	public static class GameController
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/GameController.framework/GameController", 0);
	}

	public static class GameKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/GameKit.framework/GameKit", 0);
	}

	public static class IOSurface
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/IOSurface.framework/IOSurface", 0);
	}

	public static class ImageCaptureCore
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ImageCaptureCore.framework/ImageCaptureCore", 0);
	}

	public static class ImageIO
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", 0);
	}

	public static class ImageKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/ImageKit.framework/ImageKit", 0);
	}

	public static class Intents
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Intents.framework/Intents", 0);
	}

	public static class JavaScriptCore
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/JavaScriptCore.framework/JavaScriptCore", 0);
	}

	public static class LinkPresentation
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/LinkPresentation.framework/LinkPresentation", 0);
	}

	public static class LocalAuthentication
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/LocalAuthentication.framework/LocalAuthentication", 0);
	}

	public static class MapKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MapKit.framework/MapKit", 0);
	}

	public static class MediaAccessibility
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MediaAccessibility.framework/MediaAccessibility", 0);
	}

	public static class MediaLibrary
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MediaLibrary.framework/MediaLibrary", 0);
	}

	public static class MediaPlayer
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MediaPlayer.framework/MediaPlayer", 0);
	}

	public static class Metal
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Metal.framework/Metal", 0);
	}

	public static class MetalKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MetalKit.framework/MetalKit", 0);
	}

	public static class MetalPerformanceShaders
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders", 0);
	}

	public static class ModelIO
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/ModelIO.framework/ModelIO", 0);
	}

	public static class MultipeerConnectivity
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/MultipeerConnectivity.framework/MultipeerConnectivity", 0);
	}

	public static class NaturalLanguage
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/NaturalLanguage.framework/NaturalLanguage", 0);
	}

	public static class Network
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Network.framework/Network", 0);
	}

	public static class NetworkExtension
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/NetworkExtension.framework/NetworkExtension", 0);
	}

	public static class PdfKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/PDFKit.framework/PDFKit", 0);
	}

	public static class PencilKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/PencilKit.framework/PencilKit", 0);
	}

	public static class Photos
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Photos.framework/Photos", 0);
	}

	public static class PhotosUI
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/PhotosUI.framework/PhotosUI", 0);
	}

	public static class PushKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/PushKit.framework/PushKit", 0);
	}

	public static class QTKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QTKit.framework/QTKit", 0);
	}

	public static class Quartz
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", 0);
	}

	public static class QuartzComposer
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/QuartzComposer.framework/QuartzComposer", 0);
	}

	public static class QuickLook
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuickLook.framework/QuickLook", 0);
	}

	public static class QuickLookThumbnailing
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/QuickLookThumbnailing.framework/QuickLookThumbnailing", 0);
	}

	public static class SafariServices
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/SafariServices.framework/SafariServices", 0);
	}

	public static class SceneKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/SceneKit.framework/SceneKit", 0);
	}

	public static class SearchKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit", 0);
	}

	public static class Security
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Security.framework/Security", 0);
	}

	public static class Social
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Social.framework/Social", 0);
	}

	public static class SoundAnalysis
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/SoundAnalysis.framework/SoundAnalysis", 0);
	}

	public static class StoreKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/StoreKit.framework/StoreKit", 0);
	}

	public static class SystemConfiguration
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration", 0);
	}

	public static class UserNotifications
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/UserNotifications.framework/UserNotifications", 0);
	}

	public static class VideoSubscriberAccount
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/VideoSubscriberAccount.framework/VideoSubscriberAccount", 0);
	}

	public static class VideoToolbox
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/VideoToolbox.framework/VideoToolbox", 0);
	}

	public static class Vision
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/Vision.framework/Vision", 0);
	}

	public static class WebKit
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/WebKit.framework/WebKit", 0);
	}

	public static class iTunesLibrary
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/System/Library/Frameworks/iTunesLibrary.framework/iTunesLibrary", 0);
	}

	public static class libdispatch
	{
		public static readonly IntPtr Handle = Dlfcn.dlopen("/usr/lib/system/libdispatch.dylib", 0);
	}
}
