using Foundation;

namespace NaturalLanguage;

public delegate void NLTokenizerEnumerateContinuationHandler(NSRange tokenRange, NLTokenizerAttributes flags, out bool stop);
