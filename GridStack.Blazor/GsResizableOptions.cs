using System.Text.Json.Serialization;

namespace GridStack.Blazor;

public sealed record GsResizableOptions
{
    /// <summary>
    /// Do resize handle hide by default until mouse over. Default: true on desktop, false on mobile.
    /// </summary>
    [JsonPropertyName("autoHide")]
    public bool? AutoHide { get; set; }

    /// <summary>
    /// Custom element or query inside the widget node that is used instead of the generated resize handle.
    /// </summary>
    [JsonPropertyName("element")]
    public string? Element { get; set; }

    /// <summary>
    /// Sides where you can resize from (ex: 'e, se, s, sw, w') - default 'se' (south-east) Note: it is not recommended to resize from the top sides as weird side effect may occur.
    /// </summary>
    [JsonPropertyName("handles")]
    public string? Handles { get; set; }
}