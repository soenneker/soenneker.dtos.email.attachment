using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Email.Attachment;

/// <summary>
/// A DTO type for email attachment encapsulation
/// </summary>
public class EmailAttachmentDto
{
    /// <summary>
    /// Gets or sets file name.
    /// </summary>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; } = null!;

    /// <summary>
    /// Gets or sets data.
    /// </summary>
    [JsonPropertyName("data")]
    public byte[] Data { get; set; } = [];

    /// <summary>
    /// Gets or sets mime type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "application/octet-stream";
}