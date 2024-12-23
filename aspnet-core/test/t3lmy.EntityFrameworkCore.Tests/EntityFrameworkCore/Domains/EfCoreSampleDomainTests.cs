using t3lmy.Samples;
using Xunit;

namespace t3lmy.EntityFrameworkCore.Domains;

[Collection(t3lmyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<t3lmyEntityFrameworkCoreTestModule>
{

}
