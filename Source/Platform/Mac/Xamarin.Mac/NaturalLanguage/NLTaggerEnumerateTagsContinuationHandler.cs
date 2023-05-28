using Foundation;

namespace NaturalLanguage;

public delegate void NLTaggerEnumerateTagsContinuationHandler(NSString tag, NSRange tokenRange, out bool stop);
