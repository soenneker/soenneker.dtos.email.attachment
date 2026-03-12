using System.Text.Json.Serialization;

namespace Soenneker.Dtos.Email.Attachment;

/// <summary>
/// A DTO type for email attachment encapsulation
/// </summary>
public class EmailAttachmentDto
{
    [JsonPropertyName("fileName")]
    public string FileName { get; set; } = null!;

    [JsonPropertyName("data")]
    public byte[] Data { get; set; } = [];

    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; } = "application/octet-stream";
}