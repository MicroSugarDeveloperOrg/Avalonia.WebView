using Foundation;

namespace AudioUnit;

public delegate NSString AUImplementorStringFromValueCallback(AUParameter param, ref float? value);
