using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Email.Attachment;

/// <summary>
/// Represents an in-memory email attachment.
/// </summary>
public class EmailAttachmentDto
{
    /// <summary>
    /// Gets or sets the attachment file name presented to the recipient.
    /// </summary>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the attachment content.
    /// </summary>
    [JsonPropertyName("data")]
    public byte[] Data { get; set; } = [];

    /// <summary>
    /// Gets or sets the declared MIME type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "application/octet-stream";
}
