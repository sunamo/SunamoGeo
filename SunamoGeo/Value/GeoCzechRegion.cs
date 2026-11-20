namespace SunamoGeo.Value;

/// <summary>
/// Represents the geo czech region type.
/// </summary>
public class GeoCzechRegion
{
    /// <summary>
    /// Initializes a new instance of the geo czech region class.
    /// </summary>
    /// <param name="shortcutRZ">The shortcut RZ.</param>
    /// <param name="name">The name.</param>
    /// <param name="shortcutCSU">The shortcut CSU.</param>
    /// <param name="mainCity">The main city.</param>
    public GeoCzechRegion(string shortcutRZ, string name, string shortcutCSU, string mainCity)
    {
        ShortcutRZ = shortcutRZ;
        ShortcutCSU = shortcutCSU;
        Name = name;
        MainCity = mainCity;
    }

    /// <summary>
    /// Gets or sets the shortcut RZ.
    /// </summary>
    public string ShortcutRZ { get; set; }

    /// <summary>
    /// Gets or sets the shortcut CSU.
    /// </summary>
    public string ShortcutCSU { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the main city.
    /// </summary>
    public string MainCity { get; set; }
}
