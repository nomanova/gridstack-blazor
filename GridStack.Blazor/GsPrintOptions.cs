using System.Text.Json.Serialization;

namespace GridStack.Blazor;

public sealed record GsPrintOptions
{
    /// <summary>
    /// Prevent this widget from printing (default?: undefined). Applies to both print modes. 
    /// </summary>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }

    /// <summary>
    /// Set the orientation of the printed page (default?: 'portrait'). Note: Only works in exact mode (printMode: 'exact').
    /// <para>Options: "portrait" | "landscape"</para>
    /// </summary>
    [JsonPropertyName("orientation")]
    public string? Orientation { get; set; }

    /// <summary>
    /// Add a page break before this widget (default?: undefined). Note: Only works in exact mode (printMode: 'exact'). 
    /// </summary>
    [JsonPropertyName("pageBreak")]
    public bool? PageBreak { get; set; }

    /// <summary>
    /// Application specific print options for a given widget
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}