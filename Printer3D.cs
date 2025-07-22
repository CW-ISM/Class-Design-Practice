using System;

public class Printer3D
{
	public required float BuildVolume { get; set; }
    public required string[] SupportedFilaments { get; set; }
    public required string ProductName { get; set; }
    public required float Cost { get; set; }
	public required DateTime ReleaseDate { get; set; }

    public Printer3D(
		float buildVolume, string[] supportedFilaments,
		string productName, float cost, DateTime releaseDate)
	{
		BuildVolume = buildVolume;
        SupportedFilaments = supportedFilaments;
        ProductName = productName;
        Cost = cost;
        ReleaseDate = releaseDate;
    }
}
