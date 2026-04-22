using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.Email.Attachment.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EmailAttachmentDtoTests : HostedUnitTest
{
    public EmailAttachmentDtoTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
