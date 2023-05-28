using System;
using ObjCRuntime;

namespace AVFoundation;

[Native]
public enum AVAudioSessionErrorCode : long
{
	None = 0L,
	MediaServicesFailed = 1836282486L,
	IsBusy = 560030580L,
	IncompatibleCategory = 560161140L,
	CannotInterruptOthers = 560557684L,
	MissingEntitlement = 1701737535L,
	SiriIsRecording = 1936290409L,
	CannotStartPlaying = 561015905L,
	CannotStartRecording = 561145187L,
	BadParam = -50L,
	InsufficientPriority = 561017449L,
	[Obsolete("Use 'ResourceNotAvailable' instead.", false)]
	CodeResourceNotAvailable = 561145203L,
	ResourceNotAvailable = 561145203L,
	Unspecified = 2003329396L,
	ExpiredSession = 561210739L,
	SessionNotActive = 1768841571L
}
