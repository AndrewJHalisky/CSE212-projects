using System.ComponentModel;
using System.Security.Cryptography;

public class FeatureCollection
{
    public List<Feature> features { get; set; }

    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
}

public class Feature
{
    public Properties properties { get; set; }
}

public class Properties
{
    public double Mag { get; set; }
    public string place { get; set; }

}