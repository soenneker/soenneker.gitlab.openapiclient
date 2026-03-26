using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.GitLab.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class GitLabOpenApiClientTests : FixturedUnitTest
{
    public GitLabOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
