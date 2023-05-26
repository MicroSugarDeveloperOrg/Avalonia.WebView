using System;

namespace AudioUnit;

public struct AUParameterObserverToken
{
	public IntPtr ObserverToken;

	public AUParameterObserverToken(IntPtr observerToken)
	{
		ObserverToken = observerToken;
	}
}
