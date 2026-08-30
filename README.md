[![](https://img.shields.io/nuget/v/soenneker.dtos.email.attachment.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.email.attachment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.email.attachment/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.email.attachment/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.email.attachment.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.email.attachment/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.email.attachment/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.email.attachment/actions/workflows/codeql.yml)

# Soenneker.Dtos.Email.Attachment

Defines an in-memory email attachment with a file name, MIME type, and byte content.

## Installation

```bash
dotnet add package Soenneker.Dtos.Email.Attachment
```

## Usage

```csharp
using Soenneker.Dtos.Email.Attachment;

var attachment = new EmailAttachmentDto
{
    FileName = "receipt.pdf",
    MimeType = "application/pdf",
    Data = await File.ReadAllBytesAsync(path, cancellationToken)
};
```

`Data` defaults to an empty array and `MimeType` defaults to `application/octet-stream`. `FileName` is not initialized, so assign it before sending or serialization.

System.Text.Json serializes the DTO as `fileName`, `data`, and `mimeType`; the byte array becomes a base64 JSON string. Newtonsoft.Json behavior depends on the caller’s naming strategy because the DTO declares only System.Text.Json attributes.

The DTO retains the supplied byte-array reference and does not copy, stream, compress, encrypt, or dispose it. Avoid loading unbounded files into memory, and apply the email provider’s attachment-size limits before constructing a message.

Treat `FileName` and `MimeType` as untrusted metadata when they originate outside the application. Do not combine `FileName` directly with a filesystem path, and do not rely on `MimeType` as proof of the content’s actual format.
