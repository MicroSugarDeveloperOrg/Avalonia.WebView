using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "SKPaymentTransactionObserver", WrapperType = typeof(SKPaymentTransactionObserverWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdatedTransactions", Selector = "paymentQueue:updatedTransactions:", ParameterType = new Type[]
{
	typeof(SKPaymentQueue),
	typeof(SKPaymentTransaction[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemovedTransactions", Selector = "paymentQueue:removedTransactions:", ParameterType = new Type[]
{
	typeof(SKPaymentQueue),
	typeof(SKPaymentTransaction[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreCompletedTransactionsFailedWithError", Selector = "paymentQueue:restoreCompletedTransactionsFailedWithError:", ParameterType = new Type[]
{
	typeof(SKPaymentQueue),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RestoreCompletedTransactionsFinished", Selector = "paymentQueueRestoreCompletedTransactionsFinished:", ParameterType = new Type[] { typeof(SKPaymentQueue) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedDownloads", Selector = "paymentQueue:updatedDownloads:", ParameterType = new Type[]
{
	typeof(SKPaymentQueue),
	typeof(SKDownload[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeStorefront", Selector = "paymentQueueDidChangeStorefront:", ParameterType = new Type[] { typeof(SKPaymentQueue) }, ParameterByRef = new bool[] { false })]
public interface ISKPaymentTransactionObserver : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("paymentQueue:updatedTransactions:")]
	[Preserve(Conditional = true)]
	void UpdatedTransactions(SKPaymentQueue queue, SKPaymentTransaction[] transactions);
}
