namespace CoreMotion;

[Mac(10, 15)]
public struct CMCalibratedMagneticField
{
	public CMMagneticField Field;

	public CMMagneticFieldCalibrationAccuracy Accuracy;

	public override string ToString()
	{
		return $"({Field},{Accuracy})";
	}
}
