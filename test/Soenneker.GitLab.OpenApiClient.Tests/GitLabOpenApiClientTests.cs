using Soenneker.Tests.HostedUnit;

namespace Soenneker.GitLab.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GitLabOpenApiClientTests : HostedUnitTest
{
    public GitLabOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
