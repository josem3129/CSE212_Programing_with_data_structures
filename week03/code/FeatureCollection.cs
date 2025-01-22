
public class FeatureCollection
{
    public string Type { get; set; }
    public List<Feature> Features { get; set; }
    
}

public class Feature
{
    public string Type { get; set; }
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
}

public class Properties
{
    public double Magnitude { get; set; }
    public string Place { get; set; }
}

public class Geometry
{
    public List<double> Coordinates { get; set; }
}
